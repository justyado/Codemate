using System.ComponentModel.DataAnnotations;

namespace Codemate.Application.DTOs.Request;

public record RegisterUserRequest(
    [Required] string Name,
    [Required] string Username,
    [Required] string Email,
    [Required] string Password,
    [Required] string Bio);
