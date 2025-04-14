using Codemate.Domain.Entities;
using Codemate.Domain.Interfaces;
using Codemate.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Codemate.Infrastructure.Repository;

public class UserRepository : IUserRepository
{
    private readonly ApplicationDbContext _context;
    public UserRepository(ApplicationDbContext context)
    {
        _context = context;
    }
    
    public async Task<ICollection<User>> GetAll()
    {
        return await _context.Users
            .AsNoTracking()
            .ToListAsync();
    }

    public async Task<User?> GetById(Guid id)
    {
        return await _context.Users
            .AsNoTracking()
            .FirstOrDefaultAsync(u => u.Id == id);
    }

    public async Task<User?> GetByUsername(string username)
    {
        return await _context.Users
            .AsNoTracking()
            .FirstOrDefaultAsync(u => u.Username == username);
    }

    public async Task<User> Add(User user)
    {
        await _context.Users.AddAsync(user);
        
        await _context.SaveChangesAsync();
        
        return user;
    }

    public async Task<User> Update(User user)
    {
        await _context.Users
            .Where(u => u.Id == user.Id)
            .ExecuteUpdateAsync(s => s
                .SetProperty(u => u.Name, user.Name)
                .SetProperty(u => u.Bio, user.Bio)
            );
        
        return user;
    }

    public async Task AddSkill(Guid userId, Guid skillId)
    {
        var user = await _context.Users.FirstOrDefaultAsync(u => u.Id == userId);
        var skill = await _context.Skills.FirstOrDefaultAsync(s => s.Id == skillId);
        
        user?.Skills.Add(skill);
        
        await _context.SaveChangesAsync();
    }

    public async Task Delete(Guid id)
    {
        await _context.Users
            .Where(u => u.Id == id)
            .ExecuteDeleteAsync();
    }
}