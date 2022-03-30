using System;
using System.Collections.Generic;
using System.Text;

namespace DonationPortal.Models.DTO
{
   public class CityDTO
    {
        public virtual int CityId { get; set; }
        public virtual int CityName { get; set; }
        public virtual int StateId { get; set; }

        public virtual StateDTO StateList { get; set; }
    }
}
