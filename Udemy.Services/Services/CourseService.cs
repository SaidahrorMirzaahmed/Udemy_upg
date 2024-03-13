using Udemy.DataAccess.Repositories;
using Udemy.Domain.Entites;
using Udemy.Services.DTOs.Cources;
using Udemy.Services.DTOs.Users;
using Udemy.Services.Helpers;
using Udemy.Services.Interfaces;

namespace Udemy.Services.Services;

public class CourseService : ICourseService
{
    private readonly Genericss<Course> context;
    public async ValueTask<CourseView> CreateAsync(CourseCreate courseCreation)
    {
        await context.InsertAsync(courseCreation.MapTo<Course>());
        await context.SaveAsync();
        return courseCreation.MapTo<CourseView>();
    }

    public async ValueTask<bool> DeleteAsync(int id)
    {
        var course = await context.SelectAsync(id);
        await context.DeleteAsync(course);
        await context.SaveAsync();
        return true;
    }

    public async ValueTask<List<CourseView>> GetAllAsync()
    {
        var courses = context.SelectAllAsEnumerable();
        return courses.ToList().Select(x => x.MapTo<CourseView>()).ToList();
    }

    public async ValueTask<CourseView> GetByIdAsync(int id)
    {
        var course = await context.SelectAsync(id);
        return course.MapTo<CourseView>();
    }

    public async ValueTask<CourseView> UpdateAsync(int id, CourseCreate courseViewModel)
    {
        var course = await context.SelectAsync(id);

        course.UpdatedAt = DateTime.UtcNow;
        course.Name=courseViewModel.Name;
        course.Description=courseViewModel.Description;
        course.Price=courseViewModel.Price;
        course.Duration=courseViewModel.Duration;

        await context.UpdateAsync(course);
        await context.SaveAsync();
        return course.MapTo<CourseView>();
    }
}