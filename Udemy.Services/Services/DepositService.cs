using Udemy.DataAccess.Repositories;
using Udemy.Domain.Entites;
using Udemy.Services.DTOs.BoughtCourses;
using Udemy.Services.DTOs.Deposits;
using Udemy.Services.Helpers;
using Udemy.Services.Interfaces;

namespace Udemy.Services.Services;

public class DepositService : IDepositService
{
    private readonly Genericss<Deposit> context;
    public async ValueTask<DepositView> CreateAsync(CreateBoughtCourse boughtCourseCreation)
    {
        await context.InsertAsync(boughtCourseCreation.MapTo<Deposit>());
        await context.SaveAsync();
        return boughtCourseCreation.MapTo<DepositView>();
    }
}
