
namespace OnlineCourses.BlazorWasm.Domain.Entity.Dto.CourseDto;

public  class CreateCourseRequest
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string CreatedBy { get; set; } = string.Empty;
}
