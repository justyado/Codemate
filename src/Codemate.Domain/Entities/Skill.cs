namespace Codemate.Domain.Entities;

public class Skill
{
    /// <summary>
    /// Unique skill identifier
    /// </summary>
    public Guid Id { get; set; }
    
    /// <summary>
    /// Skill name
    /// </summary>
    public string Name { get; set; }
}