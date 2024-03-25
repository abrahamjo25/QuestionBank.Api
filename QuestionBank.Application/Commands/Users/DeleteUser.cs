using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Http;
using QuestionBank.Application.Helpers.Common;
using QuestionBank.Application.Services.GenericRepository;
using QuestionBank.Domain.Models;
using QuestionBank.Domain.Models.Shared;

namespace QuestionBank.Application.Commands.Users
{
    public record DeleteUser(long Id) : IRequest<OperationResult<Unit>>;
    internal class DeleteUserCommandHandler : IRequestHandler<DeleteUser, OperationResult<Unit>>
    {

        private readonly IRepositoryBase<IdentityUser> _identityUser;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private ISession _session => _httpContextAccessor.HttpContext.Session;
        public DeleteUserCommandHandler(IRepositoryBase<IdentityUser> identityUser, IHttpContextAccessor httpContextAccessor)
        {
            _identityUser = identityUser;
            _httpContextAccessor = httpContextAccessor;
        }
        public async Task<OperationResult<Unit>> Handle(DeleteUser request, CancellationToken cancellationToken)
        {
            var result = new OperationResult<Unit>();
            var userAccount = await _identityUser.FindAsync(request.Id);
            if (userAccount is null)
            {
                result.AddError(ErrorCode.IdentityUserDoesNotExist, "Account Does not Exist");
                return result;
            }
            if (userAccount.IsReadOnly)
            {
                result.AddError(ErrorCode.IdentityUserDoesNotExist, "Cannot Delete System Account");
                return result;
            }
            userAccount.UpdateStatus(RecordStatus.Deleted);
            userAccount.UpdateAudit(_session.GetString("user"));
           _identityUser.Update(userAccount);
            result.Message = "Oparation success";
            result.Payload = Unit.Value;
            return result;
        }

    }
}

