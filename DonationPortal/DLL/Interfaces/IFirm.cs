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
        public void AddFirmDetails(FirmDTO firmdetails);

      

        /// <summary>
        /// Edit Firm Details
        /// </summary>
        public string EditFirmDetails(int firmid, FirmDTO firmdetail);

        /// <summary>
        /// Edit Firm Details By Id
        /// </summary>
        public FirmDTO GetFirmById(int id);
    }
}
