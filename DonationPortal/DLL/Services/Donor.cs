using DonationPortal.DLL.Interfaces;
using DonationPortal.Models.DTO;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DonationPortal.DLL.Services
{
    public class Donor :IDonor
    {
        /// <summary>
        /// Add Donor Details
        /// </summary>
        public string AddDonorDetails(DonorDTO donordetails)
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
                        session.Save(donordetails);


                        transaction.Commit();
                    }
                    return "Firm Details Added Successfully.";
                }
            }
            catch (Exception error)
            {
                return error.Message;
            }
        }
    }
}
