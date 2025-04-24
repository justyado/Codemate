using Codemate.Domain.Entities;

namespace Codemate.Application.Interfaces.Auth;

public interface IJwtProvider
{
    string GenerateToken(User user);
}