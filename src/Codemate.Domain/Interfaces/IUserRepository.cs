using Codemate.Domain.Entities;

namespace Codemate.Domain.Interfaces;

public interface IUserRepository
{
    Task<ICollection<User>> GetAll();
    Task<User> GetById(Guid id);
    Task<User> GetByUsername(string username);
    Task<User> Add(User user);
    Task<User> Update(User user);
    Task AddSkill(Guid userId, Guid skillId);
    Task Delete(Guid id);
}