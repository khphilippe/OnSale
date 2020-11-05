using Microsoft.AspNetCore.Identity;
using OnSale.Web.Data.Entities;
using OnSale.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnSale.Web.Helpers
{
    public interface IUserHelper
    {
         Task<IdentityResult> AddUserAsync(User user, string password);

        Task AddUserToRoleAsync(User user, string roleName);

        Task CheckRoleAsync(string roleName);

        Task<User> GetUserAsync(string email);

        Task<SignInResult> LoginAsync(LoginViewModel model);

        Task LogoutAsync();

        Task<bool> IsUserInRoleAsync(User user, string roleName);
    }

}
