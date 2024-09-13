using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using OnlineCourses.BlazorWasm.Domain.Entity;
using OnlineCourses.BlazorWasm.Domain.Entity.Dto.CourseDto;
using OnlineCourses.BlazorWasm.Services.Abstractions;


namespace OnlineCourses.BlazorWasm.Services.Features.CoursesFeatures;

public class CourseService : ICourseService
{
    private readonly ILogger<CourseService> _logger;
    private readonly HttpClient _client;
    public CourseService(ILogger<CourseService> logger, HttpClient client, IConfiguration configuration)
    {
        _logger = logger;
        _client = client;
        _client.BaseAddress = new System.Uri(configuration["WebApi:BaseAddress"]?? "");
    }

    public async  Task<List<Course>> GetAllCourses()
    {
        var response = await _client.GetAsync($"Course");
        if (response.IsSuccessStatusCode)
        {
            var json = await response.Content.ReadAsStringAsync();
            var courses = JsonConvert.DeserializeObject<List<Course>>(json);
            return courses?? new List<Course>() ;
        }
        return new List<Course>();
    }

    public Task<Course> CreateCourse(CreateCourseRequest request)
    {
        throw new NotImplementedException();
    }

    public Task DeleteCourse(Guid id)
    {
        throw new NotImplementedException();
    }

    public async  Task<List<Course>> GetAllCourses(int skip, int top, Guid id)
    {
        var response = await _client.GetAsync($"Course?skip={skip}&top={top}&id={id}");
        if (response.IsSuccessStatusCode)
        {
            var json = await response.Content.ReadAsStringAsync();
            var courses = JsonConvert.DeserializeObject<List<Course>>(json);
            return courses ?? new List<Course>();
        }
        return new List<Course>();
    }

   
    public Task<Course> GetCourse(string id)
    {
        throw new NotImplementedException();
    }

    public Task<List<Course>> SearchCourses(string displayName)
    {
        throw new NotImplementedException();
    }

    public Task UpdateCourse(UpdateCourseRequest request)
    {
        throw new NotImplementedException();
    }
}
