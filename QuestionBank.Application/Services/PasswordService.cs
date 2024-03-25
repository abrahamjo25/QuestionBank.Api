namespace QuestionBank.Application.Services
{
    public interface IPassword
    {
        Task<string> HashPassword(string password);
        Task<bool> ValidatePassword(string encrypted, string password);
    }
    public class PasswordService : IPassword
    {
        public async Task<string> HashPassword(string password) => BCrypt.Net.BCrypt.HashPassword(password);
        public async Task<bool> ValidatePassword(string encrypted, string password) => BCrypt.Net.BCrypt.Verify(password, encrypted);

    }
}
