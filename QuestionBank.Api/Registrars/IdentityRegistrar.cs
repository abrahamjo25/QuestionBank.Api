using QuestionBank.Application.Queries.Clients;

namespace QuestionBank.Api.Registrars
{
    public class IdentityRegistrar : IWebApplicationBuilderRegistrar
    {
        public void RegisterServices(WebApplicationBuilder builder)
        {
            builder.Services.AddAutoMapper(typeof(Program), typeof(GetAllClient));
            builder.Services.AddMediatR(typeof(GetAllClient));
        }
    }
}
