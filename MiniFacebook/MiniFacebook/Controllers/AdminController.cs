using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MiniFacebook.Data;
using MiniFacebook.Models.Entities;

namespace MiniFacebook.Controllers
{
    public class AdminController : Controller
    {

        private readonly UserManager<User> userManager;
        //private readonly RoleManager<User> roleManager;
        public readonly UserState userState = new UserState();
        public readonly UserRole userRole = new UserRole();

        public AdminController(UserManager<User> userManager /*,RoleManager<User> roleManager*/)
        {
            this.userManager = userManager;
        //    this.roleManager = roleManager;
        }

        //public async Task<List<IdentityUser>> GetUsersAsync()
        //{
        //    using (var context = new ApplicationDbContext())
        //    {
        //        return await context.Users.ToListAsync();
        //    }
        //}
        [HttpGet]
        public IActionResult Users()
        {
            //ViewBag.Role = userRole;
            //ViewBag.userState = userState;

          //  ViewBag.Authority = roleManager.Roles;
            return View(userManager);
        }



        [HttpPost]
        public IActionResult Users(User adminInput)
        {
            //if(adminInput.UserState==)

            if (ModelState.IsValid) {
                userManager.UpdateAsync(adminInput); 
            }
            return View(userManager);
        }







    }
}