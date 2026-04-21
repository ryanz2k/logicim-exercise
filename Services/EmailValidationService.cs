namespace UserFormApp.Services;

public class EmailValidationService : IEmailValidationService
{
    private static string? _lastSubmittedEmail;

    public async Task<bool> IsEmailUniqueAsync(string email)
    {
        await Task.Delay(1000);
        
        var trimmedEmail = email.Trim();

        if (string.Equals(trimmedEmail, "test@test.com", StringComparison.OrdinalIgnoreCase) ||
            string.Equals(trimmedEmail, "admin@example.com", StringComparison.OrdinalIgnoreCase))
        {
            return false;
        }

        if (string.Equals(trimmedEmail, _lastSubmittedEmail, StringComparison.OrdinalIgnoreCase))
        {
            return false;
        }

        return true;
    }

    public void RegisterEmail(string email)
    {
        if (!string.IsNullOrWhiteSpace(email))
        {
            _lastSubmittedEmail = email.Trim();
        }
    }
}
