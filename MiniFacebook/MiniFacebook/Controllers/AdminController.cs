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
        private UserManager<User> userSearchManager;
        //private RoleManager<User> roleManager;

        //private readonly RoleManager<User> roleManager;
        public readonly UserState userState = new UserState();
        public readonly UserRole userRole = new UserRole();

        public AdminController(UserManager<User> userManager, UserManager<User>  userSearchManager /*,RoleManager<User> roleManager*/)
        {
            this.userManager = userManager;
            //this.roleManager = roleManager;
            this.userSearchManager = userSearchManager;
        }

        //public async Task<List<IdentityUser>> GetUsersAsync()
        //{
        //    using (var context = new ApplicationDbContext())
        //    {
        //        return await context.Users.ToListAsync();
        //    }
        //}

        [HttpGet]
        public IActionResult Index() {

            return Users(null);
        }




        [HttpGet]
        public IActionResult Users(string Usrname)
        {
            if (Usrname == null)
            {
                return View(userManager.Users);
            }
            else {
                var _users = userManager.Users.Where((a) => a.UserName.Contains(Usrname));
                //foreach (var _user in _users)
                // userSearchManager.UpdateAsync(_user);
                return View(_users);
            }


            //ViewBag.Role = userRole;
            //ViewBag.userState = userState;

            //  ViewBag.Authority = roleManager.Roles;
        }



        //[HttpPost]
        //public async Task<IActionResult> UsersAsync(User adminInput)
        //{
        //    //if(adminInput.UserState==)

        //    if (ModelState.IsValid) {
        //        //roleManager.FindByIdAsync(adminInput.Id).Status;
        //        //foreach (var item in adminInput)
        //        //{
        //            var _user = userManager.Users.FirstOrDefault((a) => a.Id == adminInput.Id);
        //            _user.UserState = adminInput.UserState;
        //            _user.UserRole = adminInput.UserRole;
        //            //userManager.UpdateAsync(adminInput);
        //            IdentityResult x = await userManager.UpdateAsync(_user);

        //        //}
        //        return View(userManager);
        //    }
        //    return View();
        //}



        

        [HttpPost]
        public async Task<IActionResult> UsersAsync(User adminInput,string Usrname)
        {
            //if(adminInput.UserState==)



            if (Usrname == null)
            {
                if (ModelState.IsValid)
                {
                    //roleManager.FindByIdAsync(adminInput.Id).Status;
                    //foreach (var item in adminInput)
                    //{
                    var _user = userManager.Users.FirstOrDefault((a) => a.Id == adminInput.Id);
                    _user.UserState = adminInput.UserState;
                    _user.UserRole = adminInput.UserRole;
                    //userManager.UpdateAsync(adminInput);
                    IdentityResult x = await userManager.UpdateAsync(_user);

                    //}
                    return View(userManager.Users);
                }
            }

            else
            {
                var _users = userManager.Users.Where((a) => a.UserName.Contains(Usrname));
                //foreach (var _user in _users)
                // userSearchManager.UpdateAsync(_user);


                if (ModelState.IsValid)
                {
                    //roleManager.FindByIdAsync(adminInput.Id).Status;
                    //foreach (var item in adminInput)
                    //{
                    var _user = userManager.Users.FirstOrDefault((a) => a.Id == adminInput.Id);
                    _user.UserState = adminInput.UserState;
                    _user.UserRole = adminInput.UserRole;
                    //userManager.UpdateAsync(adminInput);
                    IdentityResult x = await userManager.UpdateAsync(_user);

                    //}
                    return View(_users);
                }

                return View(_users);
            }



            return View();
        }







    }
}