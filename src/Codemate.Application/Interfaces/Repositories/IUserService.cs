using Codemate.Application.DTOs.Request;
using Codemate.Application.DTOs.Response;

namespace Codemate.Application.Interfaces.Repositories;

public interface IUserService
{
    Task<Guid> Register(RegisterUserRequest request);
    Task<string> Login(LoginUserRequest request);
    Task<Guid> Logout();
    Task<List<GetUserResponse?>> GetAll();
    Task Delete(Guid id);
}