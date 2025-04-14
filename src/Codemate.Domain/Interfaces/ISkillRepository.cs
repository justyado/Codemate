using Codemate.Domain.Entities;

namespace Codemate.Domain.Interfaces;

public interface ISkillRepository
{
    Task<ICollection<Skill>> GetAll();
    Task<Skill?> GetById(Guid id);
    Task<Skill> Add(Skill skill);
    Task<Skill> Update(Skill skill);
    Task Delete(Guid id);
}