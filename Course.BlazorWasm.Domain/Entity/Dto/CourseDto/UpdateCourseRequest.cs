

namespace OnlineCourses.BlazorWasm.Domain.Entity.Dto.CourseDto;

public  class UpdateCourseRequest
{
    public string Name { get; set; } = string.Empty;    
    public string Description { get; set; } = string.Empty;
    public string UpdatedBy { get; set; } = string.Empty;
}
