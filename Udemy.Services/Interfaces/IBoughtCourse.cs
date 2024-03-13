using Udemy.Services.DTOs.BoughtCourses;
using Udemy.Services.DTOs.Cources;

namespace Udemy.Services.Interfaces;

public interface IBoughtCourse
{
    public ValueTask<BoughtCourseView> CreateAsync(CreateBoughtCourse boughtCourseCreation);
}
