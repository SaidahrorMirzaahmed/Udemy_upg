using Udemy.Services.DTOs.BoughtCourses;
using Udemy.Services.DTOs.Deposits;

namespace Udemy.Services.Interfaces;

public interface IDepositService
{
    public ValueTask<DepositView> CreateAsync(CreateBoughtCourse boughtCourseCreation);
}
