using System.ComponentModel.DataAnnotations;

namespace OnlineMarket.Models;

public class ProfileViewModel
{
    [Required]
    public string FirstName { get; set; } = string.Empty;
    [Required]
    public string LastName { get; set; } = string.Empty;

    [Required]
    public DateTime DateOfBirth { get; set; }

    [Required]
    public string Email { get; set; } = string.Empty;
}
