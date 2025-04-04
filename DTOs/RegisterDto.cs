using System;
using System.ComponentModel.DataAnnotations;

namespace DatingApp.DTOs;

public class RegisterDto
{
    [Required]
    [MaxLength(100)]
    public string UserName { get; set; } = string.Empty;
    [Required]
    [StringLength(8, MinimumLength =4)]
    public string Password { get; set; } = string.Empty;
}
