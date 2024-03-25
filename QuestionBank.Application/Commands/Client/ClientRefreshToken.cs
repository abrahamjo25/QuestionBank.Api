using MediatR;
using QuestionBank.Application.Helpers.Common;
using QuestionBank.Application.Helpers.Dtos;

namespace QuestionBank.Application.Commands.Clients
{
    public class ClientRefreshToken : IRequest<OperationResult<ClientLoginDto>>
    {
        public string RefreshToken { get; set; }
    }
    internal class ClientRefreshTokenHandler : IRequestHandler<ClientRefreshToken, OperationResult<ClientLoginDto>>
    {
        public Task<OperationResult<ClientLoginDto>> Handle(ClientRefreshToken request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
