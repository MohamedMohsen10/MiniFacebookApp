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
        
        public AdminController(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            this.userManager = userManager;
           
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
            return View(userManager.Users.ToList());
        }
    }
}