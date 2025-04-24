using Codemate.Application.DTOs.Response;
using Codemate.Domain.Entities;

namespace Codemate.Application.Mappers;

public static class UserMappers
{
    public static GetUserResponse? ToGetUserResponse(this User user)
    {
        return new GetUserResponse
        (
            user.Id,
            user.Name,
            user.Username,
            user.Email,
            user.Bio
        );
    }

}