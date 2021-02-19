using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Uppgift1_ASP.Net.Data;

namespace Uppgift1_ASP.Net.Services
{
    public interface IIdentityService
    {
        Task CreateRootAccountAsync();

        Task CreateNewRole(string roleName);
        Task<IdentityResult> CreateNewUserAsync(AppUser user, string password);
        Task AddUserToRole(AppUser user, string roleName);

        IEnumerable<AppUser> GetAllUsers();

        IEnumerable<IdentityRole> GetAllRoles();

      
    }
}
