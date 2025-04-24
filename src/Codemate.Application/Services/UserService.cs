using Codemate.Application.DTOs.Request;
using Codemate.Application.DTOs.Response;
using Codemate.Application.Interfaces;
using Codemate.Application.Interfaces.Auth;
using Codemate.Application.Interfaces.Repositories;
using Codemate.Application.Mappers;
using Codemate.Domain.Entities;
using Codemate.Domain.Interfaces;

namespace Codemate.Application.Services;

public class UserService : IUserService
{
    public UserService(IPasswordHasher passwordHasher, IUserRepository userRepository, IJwtProvider jwtProvider)
    {
        _passwordHasher = passwordHasher;
        _userRepository = userRepository;
        _jwtProvider = jwtProvider;
        
    }
    private readonly IPasswordHasher _passwordHasher;
    private readonly IUserRepository _userRepository;
    private readonly IJwtProvider _jwtProvider;

    public async Task<Guid> Register(RegisterUserRequest request)
    {
        var hashedPassword = _passwordHasher.Generate(request.Password);
            
        var user = new User
        {
            Id = Guid.NewGuid(),
            Name = request.Name,
            Username = request.Username,
            Email = request.Email,
            Bio = request.Bio,
            PasswordHash = hashedPassword
        };
            
        await _userRepository.Add(user);
            
        return user.Id;

    }

    public async Task<string> Login(LoginUserRequest request)
    {
        var user = await _userRepository.GetByUsername(request.Username) 
                   ?? throw new Exception("User not found.");

        var token = _jwtProvider.GenerateToken(user);

        return token;

    }

    public Task<Guid> Logout()
    {
        throw new NotImplementedException();
    }

    public async Task<List<GetUserResponse?>> GetAll()
    {
        var users = await _userRepository.GetAll();
            
        return users.Select(user => user.ToGetUserResponse()).ToList();

    }


    public Task Delete(Guid id)
    {
        throw new NotImplementedException();
    }
}