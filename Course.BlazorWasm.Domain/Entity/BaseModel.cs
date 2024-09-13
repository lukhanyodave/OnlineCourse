

using System.ComponentModel.DataAnnotations;

namespace OnlineCourses.BlazorWasm.Domain.Entity;

public class BaseModel
{
    [Required]
    public Guid Id { get; set; }
    [Required]
    public string CreatedBy { get; set; } = string.Empty;
    [Required]
    public DateTime CreatedDate { get; set; }
}
