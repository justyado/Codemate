using Codemate.Application.DTOs.Request;
using Codemate.Application.Interfaces.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Codemate.Api.Controllers;

[ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        
        [HttpPost("register")]
        public async Task<IResult> Register([FromBody] RegisterUserRequest request)
        {
            var user = await _userService.Register(request);
            
            return Results.Ok(user);
        }

        [HttpPost("login")]
        public async Task<IResult> Login([FromBody] LoginUserRequest request)
        {
            var token = await _userService.Login(request);
            
            HttpContext.Response.Cookies.Append("khinkali", token);
            
            return Results.Ok(token);
        }
        
        [Authorize]
        [HttpPost("get-all")]
        public async Task<IResult> GetAll()
        {
            var users =  await _userService.GetAll();
            return Results.Ok(users);
        }
    }
