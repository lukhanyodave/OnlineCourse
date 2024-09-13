using System.Text.Json.Serialization;

namespace OnlineCourses.BlazorWasm.Domain.Entity;

public class Course : BaseModel
{  
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;

    [JsonIgnore]
    public bool enrolled { get; set; } = false;
}
