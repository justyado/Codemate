using Codemate.Domain.Entities;
using Codemate.Domain.Interfaces;

namespace Codemate.Infrastructure.Repository;

public class UserRepository : IUserRepository
{
    public Task<ICollection<User>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<User> GetById(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<User> GetByUsername(string username)
    {
        throw new NotImplementedException();
    }

    public Task<User> Add(User user)
    {
        throw new NotImplementedException();
    }

    public Task<User> Update(User user)
    {
        throw new NotImplementedException();
    }

    public Task AddSkill(Guid userId, Guid skillId)
    {
        throw new NotImplementedException();
    }

    public Task Delete(Guid id)
    {
        throw new NotImplementedException();
    }
}