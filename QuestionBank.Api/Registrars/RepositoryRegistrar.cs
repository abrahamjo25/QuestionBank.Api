using ChapaNET;
using QuestionBank.Application.Services.GenericRepository;
using QuestionBank.Domain.Models;
using QuestionBank.Domain.Models.Clients;
using QuestionBank.Domain.Models.QuestionBanks;
using QuestionBank.Domain.Models.User;

namespace QuestionBank.Api.Registrars
{
    public class RepositoryRegistrar : IWebApplicationBuilderRegistrar
    {
        public void RegisterServices(WebApplicationBuilder builder)
        {
            builder.Services.AddScoped(typeof(IRepositoryBase<Role>), typeof(RepositoryBase<Role>));
            builder.Services.AddScoped(typeof(IRepositoryBase<Client>), typeof(RepositoryBase<Client>));
            builder.Services.AddScoped(typeof(IRepositoryBase<Service>), typeof(RepositoryBase<Service>));
            builder.Services.AddScoped(typeof(IRepositoryBase<ApiClaim>),typeof(RepositoryBase<ApiClaim>));
            builder.Services.AddScoped(typeof(IRepositoryBase<ClientClaim>), typeof(RepositoryBase<ClientClaim>));
            builder.Services.AddScoped(typeof(IRepositoryBase<IdentityUser>),typeof(RepositoryBase<IdentityUser>));
            builder.Services.AddScoped(typeof(IRepositoryBase<IdentityUserRole>),typeof(RepositoryBase<IdentityUserRole>));
            builder.Services.AddScoped(typeof(IRepositoryBase<UserSubscription>),typeof(RepositoryBase<UserSubscription>));
            builder.Services.AddScoped(typeof(IRepositoryBase<Organization>),typeof(RepositoryBase<Organization>));
            builder.Services.AddScoped(typeof(IRepositoryBase<Subscription>),typeof(RepositoryBase<Subscription>));
            builder.Services.AddScoped(typeof(IRepositoryBase<Course>),typeof(RepositoryBase<Course>));
            builder.Services.AddScoped(typeof(IRepositoryBase<Module>),typeof(RepositoryBase<Module>));
            builder.Services.AddScoped(typeof(IRepositoryBase<Question>),typeof(RepositoryBase<Question>));
            builder.Services.AddScoped(typeof(IRepositoryBase<Choice>),typeof(RepositoryBase<Choice>));
            builder.Services.AddScoped(typeof(IRepositoryBase<UserModule>),typeof(RepositoryBase<UserModule>));
            builder.Services.AddScoped(typeof(IRepositoryBase<ExamResult>),typeof(RepositoryBase<ExamResult>));
            builder.Services.AddScoped(typeof(IRepositoryBase<ChapaResponse>),typeof(RepositoryBase<ChapaResponse>));
        }
    }
}
