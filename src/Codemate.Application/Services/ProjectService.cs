using Codemate.Application.Interfaces.Repositories;
using Codemate.Domain.Entities;
using Codemate.Domain.Interfaces;

namespace Codemate.Application.Services;

public class ProjectService : IProjectService
{
    private readonly IProjectRepository _projectRepository;

    public ProjectService(IProjectRepository projectRepository)
    {
        _projectRepository = projectRepository;
    }
    
    public Task<ICollection<Project>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<Project?> GetById(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<Project?> GetByName(string name)
    {
        throw new NotImplementedException();
    }

    public Task<Project> Add(Project project)
    {
        throw new NotImplementedException();
    }

    public Task<Project> Update(Project project)
    {
        throw new NotImplementedException();
    }

    public Task AddSkill(Guid projectId, Guid skillId)
    {
        throw new NotImplementedException();
    }

    public Task Delete(Guid id)
    {
        throw new NotImplementedException();
    }
}