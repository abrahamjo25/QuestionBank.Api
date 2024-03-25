using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using QuestionBank.Application.Helpers.Common;
using QuestionBank.Domain.Models;
using QuestionBank.Infrastructure.Context;

namespace QuestionBank.Application.Commands.ClientApiResource
{
    public class CreateClientApiResource : IRequest<OperationResult<Unit>>
    {
        public long ClientId { get; set; }
        public List<long> ApiClaimId { get; set; }
    }
    internal class CreatClientApiResourceHandler : IRequestHandler<CreateClientApiResource, OperationResult<Unit>>
    {
        private readonly ApplicationDbContext _context;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private ISession _session => _httpContextAccessor.HttpContext.Session;
        public CreatClientApiResourceHandler(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _httpContextAccessor = httpContextAccessor;
        }
        public async Task<OperationResult<Unit>> Handle(CreateClientApiResource request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<Unit>();
            try
            {
                foreach (var item in request.ApiClaimId)
                {
                    var existingClientApiResource = await _context.ClientAPIResource.FirstOrDefaultAsync(x => x.ClientId == request.ClientId && x.ApiClaimId == item);
                    if (existingClientApiResource is not null)
                        continue;
                    var clientApiResource = ClientApiResources.Create(request.ClientId, item);
                    clientApiResource.Register(_session.GetString("user"));
                    _context.ClientAPIResource.Add(clientApiResource);

                }


                await _context.SaveChangesAsync();
                result.Payload = Unit.Value;
            }
            catch (Exception e)
            {
                result.AddError(ErrorCode.ServerError, e.Message);
            }
            return result;
        }
    }
}
