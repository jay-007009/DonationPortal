using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DonationPortal.Models.DTO
{
    public class UserDTO
    {
        [Key]
        public int UserId { get; set; }

        [StringLength(30), Required(ErrorMessage = "UserName is Requires")]
        public string UserName { get; set; }


        public string Password { get; set; }

        public bool IsActive { get; set; }
    }
}
