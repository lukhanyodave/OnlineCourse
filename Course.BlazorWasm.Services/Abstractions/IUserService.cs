using OnlineCourses.BlazorWasm.Domain.Entity;
using OnlineCourses.BlazorWasm.Domain.Entity.Dto.UserDto;


namespace OnlineCourses.BlazorWasm.Services.Abstractions;

public interface IUserService
{
 
    Task<User> GetUser(Guid id);
    /// <summary>
    /// A service create user 
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    Task<User> GetUserGoogleById(string id,string name);
    /// <summary>
    /// 
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    Task<User> CreateUser(CreateUserRequest request);

    /// <summary>
    /// A service update user 
    /// </summary>
    Task Update(UpdateUserRequest request);

    /// <summary>
    /// A service editing user account 
    /// </summary>
   // Task UpdateUser(UpdateUserCourseRequest request);

    /// <summary>
    /// A search directory users
    /// </summary>
    //Task<List<User>> SearchDirectoryUsers(string displayName);

    /// <summary>
    /// Delete a user from the application.
    /// </summary>
    /// <param name="id">The user id.</param>
    /// <returns></returns>
    //Task RemoveUserCourse(Guid id);
}
