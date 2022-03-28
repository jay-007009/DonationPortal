using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DonationDTO
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

        public int StateId { get; set; }

        public DateTime ModificationDate { get; set; }

        public int UserId { get; set; }

        public int FirmId { get; set; }
    }
}
