using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.Services.DTOs.Users;
using Udemy.Services.Interfaces;
namespace Udemy.Services.Services;

public class UserService : IUserService
{
    public GenericRepository context { get; set; }
    public async ValueTask<UserView> CreateAsync(UserCreate userCreation)
    {
        throw new NotImplementedException();
    }

    public async ValueTask<bool> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public async ValueTask<UserView> GetAsync(int id)
    {
        throw new NotImplementedException();
    }

    public async ValueTask<List<UserView>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public async ValueTask<UserView> UpdateAsync(int id, UserCreate userViewModel)
    {
        throw new NotImplementedException();
    }
}
