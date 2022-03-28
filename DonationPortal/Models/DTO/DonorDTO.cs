using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DonationPortal.Models.DTO
{
    public class DonorDTO
    {
        [Key]
        public int DonorId { get; set; }

        [StringLength(30), Required(ErrorMessage = "DonorName is Requires")]
        public string DonorName { get; set; }


        public decimal DonationAmount { get; set; }


        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }

     
        public int CityId { get; set; }
        public virtual CityDTO CityList { get; set; }
        public int StateId { get; set; }
        public virtual StateDTO StateList { get; set; }
        public DateTime ModificationDate { get; set; }

        public int UserId { get; set; }
      
        public int FirmId { get; set; }

        public virtual FirmDTO FirmList { get; set; }
        public string MobileNo { get; set; }
    }
}
