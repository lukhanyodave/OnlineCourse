using Microsoft.Extensions.DependencyInjection;
using OnlineCourses.BlazorWasm.Services.Abstractions;
using OnlineCourses.BlazorWasm.Services.Features.CoursesFeatures;
using OnlineCourses.BlazorWasm.Services.Features.UserCourseFeatures;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCourses.BlazorWasm.Services.Extensions
{
    /// <summary>
    /// A helper class for managing the registration of client services in the WebClient.
    /// </summary>
    public static class ServiceCollectionExtensions
    {
       /// <summary>
       /// register all services
       /// </summary>
       /// <param name="services"></param>
        public static void AddServices(this IServiceCollection services)
        {
            // Register each service with it's HttpClient and add any additional configuration needed here.
            services.AddScoped<ICourseService, CourseService>();
            services.AddScoped<IUserService, UserService>();
        }
    }
}
