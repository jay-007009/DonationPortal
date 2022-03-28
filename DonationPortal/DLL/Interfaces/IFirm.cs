using DonationPortal.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DonationPortal.DLL.Interfaces
{
   public interface IFirm
    {
        /// <summary>
        /// Add New Firm Details
        /// </summary>
        public string AddFirmDetails(FirmDTO firmdetails);
    }
}
