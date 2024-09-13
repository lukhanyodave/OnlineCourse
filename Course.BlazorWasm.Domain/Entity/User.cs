using System.Data;

namespace OnlineCourses.BlazorWasm.Domain.Entity;

public class User : BaseModel
{
    public Guid  UserId { get; set; }
    public string IdentityId { get; set; } = string.Empty;
    public string FullName { get; set; }    
    public List<Course> courses { get; set; }
    public User()
    {
        courses = new List<Course>();     
    }
   
}
