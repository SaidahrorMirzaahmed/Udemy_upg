using Udemy.DataAccess.Repositories;
using Udemy.Domain.Entites;
using Udemy.Services.DTOs.BoughtCourses;
using Udemy.Services.DTOs.Cards;
using Udemy.Services.DTOs.Cources;
using Udemy.Services.Helpers;
using Udemy.Services.Interfaces;

namespace Udemy.Services.Services;

public class BoughtCourseService : IBoughtCourse
{
    private readonly Genericss<BoughtCources> context;
    public async ValueTask<BoughtCourseView> CreateAsync(CreateBoughtCourse boughtCourseCreation)
    {
        await context.InsertAsync(boughtCourseCreation.MapTo<BoughtCources>());
        await context.SaveAsync();
        return boughtCourseCreation.MapTo<BoughtCourseView>();
    }
}
