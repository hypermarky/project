using System.ComponentModel.DataAnnotations;

namespace SkillHub.Models;

public class UserProfile
{
    [Required]
    public string Name { get; set; }
    [Required]
    [EmailAddress]
    public string Email { get; set; }
    public string ProfilePicture { get; set; }
    public string Bio { get; set; } 
    public string Skills { get; set; }  
    
}

