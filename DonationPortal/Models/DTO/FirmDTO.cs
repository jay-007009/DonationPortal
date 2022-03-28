using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DonationPortal.Models.DTO
{
    public class FirmDTO
    {
        [Key]
        public int FirmId { get; set; }

        [StringLength(30), Required(ErrorMessage = "FirmName is Required")]
        public string FirmName { get; set; }

        [RegularExpression(@"[0-9]{2}", ErrorMessage = "Only Alphabets are allowed")]
        public int RegisterNo { get; set; }

        
        [RegularExpression(@"[0-9]{4}-[0-9]{2}-[0-9]{2}", ErrorMessage = "Date in proper format")]
        public string RegisterDate { get; set; }


        public decimal DonationLimit { get; set; }

        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }

        public int UserId { get; set; }
        public virtual UserDTO UserList { get; set; }
        public int CityId { get; set; }
        public virtual CityDTO CityList { get; set; }
        public int StateId { get; set; }
        public virtual StateDTO StateList{ get; set; }
        public DateTime ModificationDate { get; set; }
    }
}
