using ChapaNET;
using Flurl.Http;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using QuestionBank.Application.Helpers.Common;
using QuestionBank.Domain.Models.QuestionBanks;
using QuestionBank.Domain.Models.Shared;

namespace QuestionBank.Application.Queries.UserModules
{
    public class GetAllUserModule : IRequest<OperationResult<IEnumerable<UserModule>>>
    {
        public RecordStatus? recordStatus { get; set; }
    }
    internal class GetAllUserModuleQueryHandler : IRequestHandler<GetAllUserModule, OperationResult<IEnumerable<UserModule>>>
    {
        private readonly IRepositoryBase<UserModule> _userModule;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private ISession _session => _httpContextAccessor.HttpContext.Session;
        public GetAllUserModuleQueryHandler(IRepositoryBase<UserModule> userModule, IHttpContextAccessor httpContextAccessor)
        {
            _userModule = userModule;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<OperationResult<IEnumerable<UserModule>>> Handle(GetAllUserModule request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<IEnumerable<UserModule>>();
            try
            {
                var getPayed = await _userModule.Where(p => p.Username == _session.GetString("user") && p.Payment == PaymentStatus.OnProgress && p.RecordStatus == RecordStatus.Active).ToListAsync();

                if (getPayed.Count > 0)
                {

                    foreach (var payed in getPayed)
                    {
                        if (payed.Reference != null)
                        {
                            var isValid = await VerifyTransaction(payed.Reference);

                            if (isValid != null && isValid.Status == "success")
                            {
                                payed.UpdateStatus(PaymentStatus.Payed);
                                _userModule.Update(payed);
                            }
                            else
                            {
                                if ((DateTime.UtcNow - payed.RegisteredDate).TotalHours >= 1)
                                {
                                    payed.DeleteStatus(RecordStatus.Deleted);
                                    _userModule.Update(payed);
                                }

                            }
                        }
                    }
                }



                var userModule = _userModule
                    .Where(x => x.Username == _session.GetString("user") && x.RecordStatus != RecordStatus.Deleted)
                    .Include(x => x.ExamResults)
                    .Include(x => x.Module)
                        .ThenInclude(m => m.Course)
                    .ToList();

                if (userModule is null || userModule.Count == 0)
                {
                    result.AddError(ErrorCode.NotFound, "User Module is not found!");
                    return result;
                }
                result.Payload = userModule;
                return result;

            }
            catch (Exception ex)
            {
                result.AddError(ErrorCode.ServerError, ex.Message);
            }
            return result;
        }
        public async Task<TransactionResponse> VerifyTransaction(string txRef)
        {
            try
            {
                string ApiBaseUrl = "https://api.chapa.co/v1/transaction/verify/";

                var response = await (ApiBaseUrl + txRef)
                            .WithHeader("Authorization", "Bearer CHASECK_TEST-4iIyyglbVjkRZaHweGfQXxxspc8oJN41")
                            .GetJsonAsync<TransactionResponse>();

                return response;
            }
            catch (FlurlHttpException ex)
            {
                return null;
            }
        }
        public class TransactionResponse
        {
            public string Message { get; set; }
            public string Status { get; set; }
            public TransactionData Data { get; set; }
        }
        public class TransactionData
        {
            public string First_name { get; set; }
            public string Last_name { get; set; }
            public string Email { get; set; }
            public string Phone_number { get; set; }
            public string Currency { get; set; }
            public decimal Amount { get; set; }
            public decimal Charge { get; set; }
            public string Mode { get; set; }
            public string Method { get; set; }
            public string Type { get; set; }
            public string Status { get; set; }
            public string Reference { get; set; }
            public string Tx_ref { get; set; }
            public Customization Customization { get; set; }
            public object Meta { get; set; }
            public DateTime? Created_at { get; set; }
            public DateTime? Updated_at { get; set; }
        }

        public class Customization
        {
            public string Title { get; set; }
            public string Description { get; set; }
            public string Logo { get; set; }
        }
    }
}
