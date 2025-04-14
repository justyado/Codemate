using Codemate.Domain.Entities;
using Codemate.Domain.Interfaces;
using Codemate.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Codemate.Infrastructure.Repository;

public class SkillRepository : ISkillRepository
{
    private readonly ApplicationDbContext _context;
    public SkillRepository(ApplicationDbContext context)
    {
        _context = context;
    }
    
    public async Task<ICollection<Skill>> GetAll()
    {
        return await _context.Skills
            .AsNoTracking()
            .ToListAsync();
    }

    public async Task<Skill?> GetById(Guid id)
    {
        return await _context.Skills
            .AsNoTracking()
            .FirstOrDefaultAsync(s => s.Id == id);
    }

    public async Task<Skill> Add(Skill skill)
    {
        await _context.Skills.AddAsync(skill);
        
        await _context.SaveChangesAsync();
        
        return skill;
    }

    public async Task<Skill> Update(Skill skill)
    {
        await _context.Users
            .Where(s => s.Id == skill.Id)
            .ExecuteUpdateAsync(x => x
                .SetProperty(s => s.Name, skill.Name)
            );
        
        return skill;
    }

    public async Task Delete(Guid id)
    {
        await _context.Skills
            .Where(s => s.Id == id)
            .ExecuteDeleteAsync();
    }
}