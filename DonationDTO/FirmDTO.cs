using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DonationDTO
{
    public class FirmDTO
    {
        [Key]
        public int FirmId { get; set; }

        [RegularExpression("^[a-zA-Z]+$", ErrorMessage = ("Only Alphabets are Allowed."))]
        [StringLength(30), Required(ErrorMessage = "FirmName is Required")]
        public string FirmName { get; set; }

        [RegularExpression("[0-9]{5}", ErrorMessage = ("Only Alphabets are Allowed."))]
        public int RegisterNo { get; set; }

        public DateTime RegisterDate { get; set; }

        public decimal DonationLimit { get; set; }

        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }

        public int UserId { get; set; }
        public int CityId { get; set; }

        public int StateId { get; set; }

        public DateTime ModificationDate { get; set; }
    }
}
