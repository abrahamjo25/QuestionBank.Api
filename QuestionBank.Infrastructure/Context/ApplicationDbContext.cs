using Microsoft.EntityFrameworkCore;
using QuestionBank.Domain.Models;
using QuestionBank.Domain.Models.Clients;
using QuestionBank.Domain.Models.QuestionBanks;
using QuestionBank.Domain.Models.User;
using QuestionBank.Infrastructure.Configurations;

namespace QuestionBank.Infrastructure.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            DataSeed.seed(modelBuilder);

        }
        #region client
        public DbSet<Client> Client { get; set; }
        public DbSet<ClientApiResources> ClientAPIResource { get; set; }
        public DbSet<Service> Service { get; set; }
        public DbSet<ApiClaim> ApiClaim { get; set; }
        #endregion
        #region Identity user
        public DbSet<Role> Role { get; set; }
        public DbSet<RoleClaim> RoleClaim { get; set; }
        public DbSet<ClientClaim> ClientClaim { get; set; }
        public DbSet<IdentityUser> IdentityUser { get; set; }
        public DbSet<IdentityUserRole> IdentityUserRole { get; set; }
        #endregion
        #region subscription
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }
        public DbSet<UserSubscription> UserSubscription { get; set; }
        #endregion

        #region question bank
        public DbSet<Course> Courses { get; set; }
        public DbSet<Module> Modules { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Choice> Choices { get; set; }
        public DbSet<UserModule> UserModules { get; set; }
        public DbSet<ExamResult> ExamResults { get; set; }
        #endregion
    }
}
