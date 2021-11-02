﻿using Microsoft.AspNetCore.Mvc;
using SpaDay.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpaDay.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [Route("/user")]
        public IActionResult SubmitAddUserForm(User newUser, string verify)
        {
            if (verify.Equals(newUser.Password))
            {
                ViewBag.NewUser = newUser;
               return View("Index");
            }
            else
            {
                ViewBag.passwordMismatch = true;
                ViewBag.UserName = newUser.UserName;
                ViewBag.Email = newUser.Email;
                return View("Add");
            }
        }

    }
}
