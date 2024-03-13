using Udemy.Domain.Entites;
using Udemy.Services.DTOs.Users;
using Udemy.Services.Interfaces;
using Udemy.DataAccess.Repositories;
using Udemy.Services.Helpers;

namespace Udemy.Services.Services;

public class UserService : IUserService
{
    private readonly Genericss<User> context;
    public async ValueTask<UserView> CreateAsync(UserCreate userCreation)
    {
        await context.InsertAsync(userCreation.MapTo<User>());
        await context.SaveAsync();
        return userCreation.MapTo<UserView>();
    }

    public async ValueTask<bool> DeleteAsync(int id)
    {
        var user = await context.SelectAsync(id);
        await context.DeleteAsync(user);
        await context.SaveAsync();
        return true;
    }

    public async ValueTask<UserView> GetAsync(int id)
    {
        var user = await context.SelectAsync(id);
        return user.MapTo<UserView>();
    }

    public async ValueTask<List<UserView>> GetAllAsync()
    {
        var users=context.SelectAllAsEnumerable();
        return  users.ToList().Select(x => x.MapTo<UserView>()).ToList();
    }

    public async ValueTask<UserView> UpdateAsync(int id, UserCreate userViewModel)
    {
        var user = await context.SelectAsync(id);

        user.UpdatedAt = DateTime.UtcNow;
        user.FirstName= userViewModel.FirstName;
        user.LastName= userViewModel.LastName;
        user.PhoneNumber= userViewModel.PhoneNumber;
        user.Password= userViewModel.Password;

        await context.UpdateAsync(user);
        await context.SaveAsync();
        return user.MapTo<UserView>();
    }
}
