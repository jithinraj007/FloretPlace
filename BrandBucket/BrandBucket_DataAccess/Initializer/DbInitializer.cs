using BrandBucket_Models;
using BrandBucket_Utility;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrandBucket_DataAccess.Initializer
{
    public class DbInitializer : IDbInitializer
    {
        private readonly ApplicationDbContext _db;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public DbInitializer(ApplicationDbContext db, UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _db = db;
            _roleManager = roleManager;
            _userManager = userManager;
        }
        public void Initialize()
        {
            try
            {
                if (_db.Database.GetPendingMigrations().Count() > 0)
                {
                    _db.Database.Migrate();
                }
            }
            catch(Exception)
            {

            }

            try
            {
                if (!_roleManager.RoleExistsAsync(WC.AdminRole).GetAwaiter().GetResult())
                {
                    _roleManager.CreateAsync(new IdentityRole(WC.AdminRole)).GetAwaiter().GetResult();
                }

                if (!_roleManager.RoleExistsAsync(WC.CustomerRole).GetAwaiter().GetResult())
                {
                    _roleManager.CreateAsync(new IdentityRole(WC.CustomerRole)).GetAwaiter().GetResult();
                }
            }
            catch
            {
                // If the configured SQL user cannot access identity role tables,
                // skip seed logic instead of crashing the application startup.
                return;
            }

            const string adminEmail = "jithinrajkalarikkal@gmail.com";
            const string adminUserName = "jithinrajkalarikkal007";
            const string adminPassword = "Jithin123.";

            var existingAdmin = _db.ApplicationUser
                .OrderBy(u => u.Id)
                .FirstOrDefault(u => u.NormalizedEmail == adminEmail.ToUpper());

            if (existingAdmin != null)
            {
                if (!_userManager.IsInRoleAsync(existingAdmin, WC.AdminRole).GetAwaiter().GetResult())
                {
                    _userManager.AddToRoleAsync(existingAdmin, WC.AdminRole).GetAwaiter().GetResult();
                }
                return;
            }

            ApplicationUser user = new ApplicationUser
            {
                UserName = adminUserName,
                Email = adminEmail,
                EmailConfirmed = true,
                FullName = "Jithinraj",
                PhoneNumber = "1111111111"
            };

            var createResult = _userManager.CreateAsync(user, adminPassword).GetAwaiter().GetResult();
            if (!createResult.Succeeded)
            {
                return;
            }

            if (!_userManager.IsInRoleAsync(user, WC.AdminRole).GetAwaiter().GetResult())
            {
                _userManager.AddToRoleAsync(user, WC.AdminRole).GetAwaiter().GetResult();
            }
        }
    }
}
