using System.ComponentModel.DataAnnotations;

namespace UserFormApp.Models;

public class UserModel
{
    [Required(ErrorMessage = "Name is required.")]
    [StringLength(100, ErrorMessage = "Name cannot exceed 100 characters.")]
    public string Name { get; set; } = string.Empty;

    [StringLength(250, ErrorMessage = "Address cannot exceed 250 characters.")]
    public string Address { get; set; } = string.Empty;

    [Required(ErrorMessage = "Age is required.")]
    [Range(18, 120, ErrorMessage = "Age must be between 18 and 120.")]
    public int? Age { get; set; }

    [Required(ErrorMessage = "Email is required.")]
    [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
    public string Email { get; set; } = string.Empty;

    public UserModel Clone()
    {
        return new UserModel
        {
            Name = this.Name,
            Address = this.Address,
            Age = this.Age,
            Email = this.Email
        };
    }
}
