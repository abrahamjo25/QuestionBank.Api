using ChapaNET;
using MediatR;
using Microsoft.AspNetCore.Http;
using QuestionBank.Application.Helpers.Common;
using QuestionBank.Domain.Models.QuestionBanks;
using QuestionBank.Domain.Models.Shared;

namespace QuestionBank.Application.Commands.Payment
{
    public class CreatePayment : IRequest<OperationResult<ChapaResponse>>
    {
        public long ModuleId { get; set; }
        public double Amount { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    internal class CreatePaymentHandler : IRequestHandler<CreatePayment, OperationResult<ChapaResponse>>
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private ISession _session => _httpContextAccessor.HttpContext.Session;
        private readonly IRepositoryBase<UserModule> _userModule;
        public CreatePaymentHandler(IRepositoryBase<ChapaResponse> question, IHttpContextAccessor httpContextAccessor, IRepositoryBase<UserModule> userModule)
        {
            _httpContextAccessor = httpContextAccessor;
            _userModule = userModule;
        }
        public async Task<OperationResult<ChapaResponse>> Handle(CreatePayment request, CancellationToken cancellationToken)
        {

            var result = new OperationResult<ChapaResponse>();
            try
            {
                Chapa chapa = new("CHASECK_TEST-4iIyyglbVjkRZaHweGfQXxxspc8oJN41");
                var ID = Chapa.GetUniqueRef();
                var banks = await chapa.GetBanksAsync();

                var Request = new ChapaRequest(
                    amount: request.Amount,
                    email: request.Email,
                    firstName: request.FirstName,
                    lastName: request.LastName,
                    tx_ref: ID,
                    callback_url: "https://google.com"
                    );
                var Result = await chapa.RequestAsync(Request);
                if(Result.Status == "success")
                {

                    var userModule = await _userModule.FirstOrDefaultAsync(e => e.Username == _session.GetString("user") && e.ModuleId == request.ModuleId  && e.RecordStatus == RecordStatus.Active);

                    if (userModule == null)
                    {
                        userModule = UserModule.CreatePayment(_session.GetString("user"), request.ModuleId, ID);
                        userModule.Register(_session.GetString("user"));

                        await _userModule.AddAsync(userModule);
                    }
                    else
                    {
                        userModule.UpdateReference(ID);
                         _userModule.Update(userModule);
                    }


                }

                result.Payload = Result;
            }
            catch (Exception e)
            {
                result.AddError(ErrorCode.ServerError, e.Message);
            }
            return result;

        }
    }
}
