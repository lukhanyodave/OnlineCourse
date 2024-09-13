using OnlineCourses.BlazorWasm.Domain.Entity;
using OnlineCourses.BlazorWasm.Domain.Entity.Dto.UserDto;
using OnlineCourses.BlazorWasm.Services.Abstractions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using OnlineCourses.BlazorWasm.Services.Features.CoursesFeatures;
using System.Text;

namespace OnlineCourses.BlazorWasm.Services.Features.UserCourseFeatures;

public  class UserService : IUserService
{

    private readonly ILogger<UserService> _logger;
    private readonly HttpClient _client;
    public UserService(ILogger<UserService> logger, HttpClient client, IConfiguration configuration)
    {
        _logger = logger;
        _client = client;
        _client.BaseAddress = new System.Uri(configuration["WebApi:BaseAddress"] ?? "");
    }

    public async  Task<User> CreateUser(CreateUserRequest request)
    {
        var json = JsonConvert.SerializeObject(request);
        var content = new StringContent(json, Encoding.UTF8, "application/json");

        var response = await _client.PostAsync($"user/", content);

        response.EnsureSuccessStatusCode();
        if (response.IsSuccessStatusCode)
        {
            var body = await response.Content.ReadAsStringAsync();
            var user = JsonConvert.DeserializeObject<User>(body);

            return user;
        }

        return null;
    }

    public async Task<User> GetUser(Guid id)
    {
        var response = await _client.GetAsync($"user/{id}");

        if (response.IsSuccessStatusCode)
        {
            var json = await response.Content.ReadAsStringAsync();
            var user = JsonConvert.DeserializeObject<User>(json);

            return user;
        }

        return null;
    }

    public async  Task<User> GetUserGoogleById(string id,string name)
    {
        var response = await _client.GetAsync($"User/GetUserByGoogleId?id={id}&name={name}"); https://localhost:7184/api/v1/User/GetUserByGoogleId?id=ghjfhgs67843678&name=nita

        if (response.IsSuccessStatusCode)
        {
            var json = await response.Content.ReadAsStringAsync();
            var user = JsonConvert.DeserializeObject<User>(json);

            return user;
        }

        return null;
    }

    public async  Task Update(UpdateUserRequest request)
    {
        string id = request.Id.ToString();
        var json = JsonConvert.SerializeObject(request);
        var content = new StringContent(json, Encoding.UTF8, "application/json");

        var response = await _client.PutAsync($"User/{id}", content);
        response.EnsureSuccessStatusCode();
    }
}