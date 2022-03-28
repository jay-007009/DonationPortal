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
    public class FirmController : ControllerBase
    {
        private readonly IFirm _firmdetails;

        public FirmController(IFirm firmdetails)
        {
            _firmdetails = firmdetails;
        }

        // POST api/<FirmController>
        [HttpPost]
        public IActionResult Post([FromBody] FirmDTO firms)
        {
            return Ok(_firmdetails.AddFirmDetails(firms));
        }

    }
}
