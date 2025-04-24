namespace Codemate.Application.DTOs.Response;

public record GetUserResponse(
    Guid Id,
    string Name,
    string Username,
    string Email,
    string Bio);