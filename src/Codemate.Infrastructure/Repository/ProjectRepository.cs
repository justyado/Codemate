using Codemate.Domain.Entities;
using Codemate.Domain.Interfaces;

namespace Codemate.Infrastructure.Repository;

public class ProjectRepository : IProjectRepository
{
    public Task<ICollection<Project>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<Project> GetById(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<Project> GetByName(string name)
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