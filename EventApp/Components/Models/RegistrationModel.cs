using System.ComponentModel.DataAnnotations;

namespace EventApp;

public class RegistrationModel
{
    [Required]
    public string Name { get; set; } = "";


    [Required]
    [EmailAddress]
    public string Email { get; set; } = "";


    public int EventId { get; set; }
}