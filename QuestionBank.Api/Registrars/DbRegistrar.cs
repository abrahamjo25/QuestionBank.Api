using QuestionBank.Infrastructure.Context;

namespace QuestionBank.Api.Registrars
{
    public class DbRegistrar : IWebApplicationBuilderRegistrar
    {
        public void RegisterServices(WebApplicationBuilder builder)
        {
            var connectionString = Environment.GetEnvironmentVariable("MSSQLDB_HOST");
#if DEBUG
            connectionString = string.Empty;
#endif
            if (string.IsNullOrEmpty(connectionString))
                connectionString = builder.Configuration.GetConnectionString("Default");
            builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionString));
        }
    }
}
