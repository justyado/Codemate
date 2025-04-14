namespace Codemate.Domain.Entities;

public class Project
{
    /// <summary>
    /// Unique project identifier
    /// </summary>
    public Guid Id { get; set; }
    
    /// <summary>
    /// Unique ID of the project creator
    /// </summary>
    public Guid CreatorId { get; set; }
    
    /// <summary>
    /// Reference to the creator's user model
    /// </summary>
    public User Creator { get; set; }
    
    /// <summary>
    /// Project name
    /// </summary>
    public string Name { get; set; }    
    
    /// <summary>
    /// Project description
    /// </summary>
    public string? Description { get; set; }
    
    /// <summary>
    /// Required skills for the project
    /// </summary>
    public ICollection<Skill> RequiredSkills { get; set; }
    
    /// <summary>
    /// List of project members
    /// </summary>
    public ICollection<User> Members { get; set; }
}