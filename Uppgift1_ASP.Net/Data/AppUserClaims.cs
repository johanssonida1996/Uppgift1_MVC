﻿using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Uppgift1_ASP.Net.Data
{
    public class AppUserClaims : UserClaimsPrincipalFactory<AppUser, IdentityRole>
    {
        public AppUserClaims(
            UserManager<AppUser> userManager,
            RoleManager<IdentityRole> roleManager,
            IOptions<IdentityOptions> options) : base(userManager, roleManager, options)
        {
        }

        protected override async Task<ClaimsIdentity> GenerateClaimsAsync(AppUser user)
        {
            var _identity = await base.GenerateClaimsAsync(user);
            _identity.AddClaim(new Claim("DisplayName", user.DisplayName ?? ""));

            return _identity;
        }
    }
}
