

using System.ComponentModel.DataAnnotations;

namespace OnlineCourses.BlazorWasm.Domain.Entity.Dto.UserDto;

public  class UpdateUserRequest
{
   
    public string? last_updated_by { get; set; } = string.Empty;
    [Required]
    public Guid Id { get; set; }
    public List<Guid> courses { get; set; }
    public UpdateUserRequest()
    {
        courses = new List<Guid>();
      
    }
}
