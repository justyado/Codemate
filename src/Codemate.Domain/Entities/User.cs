namespace Codemate.Domain.Entities;

public class User
{
    /// <summary>
    /// Unique user identifier
    /// </summary>
    public Guid Id { get; set; }
    
    /// <summary>
    /// User's full name
    /// </summary>
    public string Name { get; set; }
    
    /// <summary>
    /// Unique username
    /// </summary>
    public string Username { get; set; }        
    
    /// <summary>
    /// Short bio or profile description
    /// </summary>
    public string Bio { get; set; }
    
    /// <summary>
    /// User's email address
    /// </summary>
    public string Email { get; set; }
    
    /// <summary>
    /// Hashed password
    /// </summary>
    public string PasswordHash { get; set; }
    
    /// <summary>
    /// User's skills
    /// </summary>
    public ICollection<Skill> Skills { get; set; }
    
    /// <summary>
    /// Projects created by the user
    /// </summary>
    public ICollection<Project> CreatedProjects { get; set; }
    
    /// <summary>
    /// Projects the user is a member of
    /// </summary>
    public ICollection<Project> JoinedProjects { get; set; }
}