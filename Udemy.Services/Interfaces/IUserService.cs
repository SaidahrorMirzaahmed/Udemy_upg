using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.Services.DTOs.Users;

namespace Udemy.Services.Interfaces;

public interface IUserService
{
    public ValueTask<UserView> CreateAsync(UserCreate userCreation);
    public ValueTask<UserView> UpdateAsync(int id, UserCreate userViewModel);
    public ValueTask<bool> DeleteAsync(int id);
    public ValueTask<UserView> GetAsync(int id);
    public ValueTask<List<UserView>> GetAllAsync();
}
