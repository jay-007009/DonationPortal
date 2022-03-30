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
        public virtual int UserId { get; set; }

        [StringLength(30), Required(ErrorMessage = "UserName is Required")]
        public virtual string UserName { get; set; }


        public virtual string Password { get; set; }

        public virtual bool IsActive { get; set; }
        public virtual ICollection<FirmDTO> firmList { get; set; }
       
    }

}
