using Codemate.Domain.Entities;
using Codemate.Domain.Interfaces;
using Codemate.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Codemate.Infrastructure.Repository;

public class ProjectRepository : IProjectRepository
{
    private readonly ApplicationDbContext _context;
    public ProjectRepository(ApplicationDbContext context)
    {
        _context = context;
    }
    
    public async Task<ICollection<Project>> GetAll()
    {
        return await _context.Projects
            .AsNoTracking()
            .ToListAsync();
    }

    public async Task<Project?> GetById(Guid id)
    {
        return await _context.Projects
            .AsNoTracking()
            .FirstOrDefaultAsync(p => p.Id == id);
    }

    public async Task<Project?> GetByName(string name)
    {
        return await _context.Projects
            .AsNoTracking()
            .FirstOrDefaultAsync(p => p.Name == name);
    }

    public async Task<Project> Add(Project project)
    {
        await _context.Projects.AddAsync(project);
        
        await _context.SaveChangesAsync();
        
        return project;
    }

    public async Task<Project> Update(Project project)
    {
        await _context.Projects
            .Where(p => p.Id == project.Id)
            .ExecuteUpdateAsync(s => s
                .SetProperty(p => p.Name, project.Name)
                .SetProperty(p => p.Description, project.Description)
            );
        
        return project;
    }

    public async Task AddSkill(Guid projectId, Guid skillId)
    {
        var project = await _context.Projects.FirstOrDefaultAsync(p => p.Id == projectId);
        var skill = await _context.Skills.FirstOrDefaultAsync(s => s.Id == skillId);
        
        project?.RequiredSkills.Add(skill);
        
        await _context.SaveChangesAsync();
    }

    public async Task Delete(Guid id)
    {
        await _context.Projects
            .Where(p => p.Id == id)
            .ExecuteDeleteAsync();
    }
}