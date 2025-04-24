using System.ComponentModel.DataAnnotations;

namespace Codemate.Application.DTOs.Request;


public record LoginUserRequest(
    [Required] string Username,
    [Required] string Password);
