using DonationPortal.DLL.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DonationPortal.Controllers
{
    public class LoginMvcController : Controller
    {
        private readonly ILogin _login;
        public LoginMvcController(ILogin login)
        {
            _login = login;
        }
        // GET: LoginMvcController
        public ActionResult Index()
        {
            return View();
        }

       
    }
}
