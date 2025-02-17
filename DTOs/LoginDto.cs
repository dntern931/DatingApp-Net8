using System;
using System.ComponentModel.DataAnnotations;

namespace DatingApp.DTOs;

public class LoginDto
{
    [Required]
    [MaxLength(100)]
    public required string UserName { get; set; }
    [Required]
    public required string Password { get; set; }
}