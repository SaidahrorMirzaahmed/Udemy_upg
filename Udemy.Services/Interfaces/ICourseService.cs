using Udemy.Services.DTOs.Cources;
using Udemy.Services.DTOs.Users;

namespace Udemy.Services.Interfaces;

public interface ICourseService
{
    public ValueTask<CourseView> CreateAsync(CourseCreate courseCreation);
    public ValueTask<CourseView> UpdateAsync(int id, CourseCreate courseViewModel);
    public ValueTask<bool> DeleteAsync(int id);
    public ValueTask<CourseView> GetByIdAsync(int id);
    public ValueTask<List<CourseView>> GetAllAsync();
}
