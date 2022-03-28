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
    public class DonorController : ControllerBase
    {
        private readonly IDonor _donordetails;

        public DonorController(IDonor donordetails)
        {
            _donordetails = donordetails;
        }

        // POST api/<DonorController>
        [HttpPost]
        public IActionResult Post([FromBody] DonorDTO donors)
        {
            return Ok(_donordetails.AddDonorDetails(donors));
        }
    }
}
