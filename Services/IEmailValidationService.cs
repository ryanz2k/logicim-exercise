namespace UserFormApp.Services;

public interface IEmailValidationService
{
    Task<bool> IsEmailUniqueAsync(string email);
    void RegisterEmail(string email);
}
