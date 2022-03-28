using DonationPortal.DLL.Interfaces;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DonationPortal;
using DonationPortal.Models.DTO;

namespace DonationPortal.DLL.Services
{
    public class Firm :IFirm
    {
        /// <summary>
        /// Add New Firm Details
        /// </summary>
        public string AddFirmDetails(FirmDTO firmdetails)
        {
            try
            {
                using (ISession session = NHibernateSession.OpenSession())
                {
                    using (ITransaction transaction = session.BeginTransaction())
                    {
                        //firmdetails.FirmId = (int)session.Save(firmdetails);
                        //var UserId = session.Get<UserDTO>(firmdetails.UserId);
                        //foreach (var firm in firmdetails.)
                        //{
                        //    firm. = newcourierOffice;
                        //    session.Save(customer);
                        //}
                        session.Save(firmdetails);
                       

                        transaction.Commit();
                    }
                    return "Donor Details Added Successfully.";
                }
            }
            catch (Exception error)
            {
                return error.Message;
            }
        }
    }
}
