using OnlineCourses.BlazorWasm.Domain.Entity;
using OnlineCourses.BlazorWasm.Domain.Entity.Dto.CourseDto;

namespace OnlineCourses.BlazorWasm.Services.Abstractions;

public  interface ICourseService
{
   /// <summary>
   /// gets a list of course 
   /// </summary>
   /// <returns></returns>
    Task<List<Course>> GetAllCourses();

    /// <summary>
    /// Query all Courses.
    /// </summary>
    /// <param name="skip">The number of Courses to skip.</param>
    /// <param name="top">The number of records to return.</param>
    /// <param name="name">The name to match, if not supplied all Courses are returned.</param>
    /// <returns></returns>
    Task<List<Course>> GetAllCourses(int skip, int top, Guid id );

    /// <summary>
    /// Get a Course by id.
    /// </summary>
    /// <param name="id">The Course id.</param>
    /// <returns></returns>
    Task<Course> GetCourse(string id);

    /// <summary>
    /// A service create Course account 
    /// </summary>
    Task<Course> CreateCourse(CreateCourseRequest request);

    /// <summary>
    /// A service editing Course account 
    /// </summary>
    Task UpdateCourse(UpdateCourseRequest request);

    /// <summary>
    /// A search directory Courses
    /// </summary>
    Task<List<Course>> SearchCourses(string displayName);

    /// <summary>
    /// Delete a Course from the application.
    /// </summary>
    /// <param name="id">The Course id.</param>
    /// <returns></returns>
    Task DeleteCourse(Guid id);
}
