
using System.ComponentModel.DataAnnotations;


namespace OnlineCourses.BlazorWasm.Domain.Entity.Dto.UserDto;

public class CreateUserRequest
{
    [Required]
    public string GoogleId { get; set; } = string.Empty;
    [Required]
    public string Name { get; set; } = string.Empty;
}
