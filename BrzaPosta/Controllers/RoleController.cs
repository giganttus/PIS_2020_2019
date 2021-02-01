﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BrzaPosta.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;


namespace BrzaPosta.Controllers
{
    [Authorize(Roles = "Super Admin")]
    public class RoleController : Controller
    {
        RoleManager<IdentityRole> roleManager;
        private readonly UserManager<IdentityUser> userManager;
        public RoleController(RoleManager<IdentityRole> roleManager, UserManager<IdentityUser> userManager)
        {
            this.roleManager = roleManager;
            this.userManager = userManager;
        }

        public IActionResult Index(string search)
        {
            if (!String.IsNullOrEmpty(search))
            {
                var roles = roleManager.Roles.AsNoTracking().Where(x => x.Name.Contains(search)).OrderBy(s => s.Id);
                return View(roles);
            }
            else
            {
                var roles = roleManager.Roles.AsNoTracking().OrderBy(s => s.Id);
                return View(roles);
            }
        }

        public IActionResult Create()
        {
            return View(new IdentityRole());
        }

        [HttpPost]
        public async Task<IActionResult> Create(IdentityRole role)
        {
            await roleManager.CreateAsync(role);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Delete(string id)
        {
            IdentityRole role = await roleManager.FindByIdAsync(id);
            if (role != null)
            {
                IdentityResult result = await roleManager.DeleteAsync(role);
                if (result.Succeeded)
                    return RedirectToAction("Index");
                else
                    Errors(result);
            }
            else
                ModelState.AddModelError("", "Nije pronađena");
            return View("Index", roleManager.Roles);
        }

        private void Errors(IdentityResult result)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        public async Task<IActionResult> Update(string id)
        {
            var role = await roleManager.FindByIdAsync(id);
            if (role == null)
            {
                ViewBag.ErrorMessage = "Ne postoji";
                return View(role);
            }
            var model = new EditRoleViewModel
            {
                Id = role.Id,
                Name = role.Name

            };
            foreach (var user in userManager.Users)
            {
                if (await userManager.IsInRoleAsync(user, role.Name))
                {
                    model.Users.Add(user.UserName);
                }
            }
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> EditUsersInRole(string search, string roleId)
        {
            ViewBag.roleId = roleId;

            var role = await roleManager.FindByIdAsync(roleId);

            if (role == null)
            {
                ViewBag.ErrorMessage = $"Rola s id-a = {roleId} nije pronađena";
                return View("NotFound");
            }

            var model = new List<UserRoleViewModel>();
            if (!String.IsNullOrEmpty(search))
            {
                foreach (var user in userManager.Users)
                {
                    if (user.UserName.Contains(search))
                    {
                        var userRoleViewModel = new UserRoleViewModel
                        {
                            UserId = user.Id,
                            UserName = user.UserName
                        };

                        if (await userManager.IsInRoleAsync(user, role.Name))
                        {
                            userRoleViewModel.IsSelected = true;
                        }
                        else
                        {
                            userRoleViewModel.IsSelected = false;
                        }

                        model.Add(userRoleViewModel);
                    }
                }
                return View(model);
            }
            else
            {
                foreach (var user in userManager.Users)
                {
                    var userRoleViewModel = new UserRoleViewModel
                    {
                        UserId = user.Id,
                        UserName = user.UserName
                    };

                    if (await userManager.IsInRoleAsync(user, role.Name))
                    {
                        userRoleViewModel.IsSelected = true;
                    }
                    else
                    {
                        userRoleViewModel.IsSelected = false;
                    }

                    model.Add(userRoleViewModel);
                }
                return View(model);
            }

        }



        [HttpPost]
        public async Task<IActionResult> EditUsersInRole(List<UserRoleViewModel> model, string roleId)
        {
            var role = await roleManager.FindByIdAsync(roleId);

            if (role == null)
            {
                ViewBag.ErrorMessage = $"Rola s id-a = {roleId} nije pronađena";
                return View("NotFound");
            }

            for (int i = 0; i < model.Count; i++)
            {
                var user = await userManager.FindByIdAsync(model[i].UserId);

                IdentityResult result = null;

                if (model[i].IsSelected && !(await userManager.IsInRoleAsync(user, role.Name)))
                {
                    result = await userManager.AddToRoleAsync(user, role.Name);
                }
                else if (!model[i].IsSelected && await userManager.IsInRoleAsync(user, role.Name))
                {
                    result = await userManager.RemoveFromRoleAsync(user, role.Name);
                }
                else
                {
                    continue;
                }

                if (result.Succeeded)
                {
                    if (i < (model.Count - 1))
                        continue;
                    else
                        return RedirectToAction("Update", new { Id = roleId });
                }
            }

            return View("Update");
        }
    }
}