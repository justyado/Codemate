using Codemate.Domain.Entities;
using Codemate.Domain.Interfaces;

namespace Codemate.Infrastructure.Repository;

public class SkillRepository : ISkillRepository
{
    public Task<ICollection<Skill>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<Skill> GetById(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<Skill> Add(Skill skill)
    {
        throw new NotImplementedException();
    }

    public Task<Skill> Update(Skill skill)
    {
        throw new NotImplementedException();
    }

    public Task Delete(Guid id)
    {
        throw new NotImplementedException();
    }
}