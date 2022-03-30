using DonationPortal.DLL.Interfaces;
using DonationPortal.Models.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DonationPortal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ILogin _logindetails;

        public LoginController(ILogin logindetails)
        {
            _logindetails = logindetails;
        }

        // GET api/<Login>/5
        [HttpPost]
        public UserDTO Get([FromBody]string username, string pwd)
        {
            return _logindetails.AddLoginDetails(username,pwd);
        }


    }
}
