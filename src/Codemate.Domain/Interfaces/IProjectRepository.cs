using Codemate.Domain.Entities;

namespace Codemate.Domain.Interfaces;

public interface IProjectRepository
{
    Task<ICollection<Project>> GetAll();
    Task<Project?> GetById(Guid id);
    Task<Project?> GetByName(string name);
    Task<Project> Add(Project project);
    Task<Project> Update(Project project);
    Task AddSkill(Guid projectId, Guid skillId);
    Task Delete(Guid id);
}