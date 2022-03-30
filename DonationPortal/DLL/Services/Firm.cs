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
    public class Firm : IFirm
    {
        /// <summary>
        /// Add New Firm Details
        /// </summary>
        public void AddFirmDetails(FirmDTO firmdetails)
        {
            try
            {
                using (ISession session = NHibernateSession.OpenSession())
                {
                    using (ITransaction transaction = session.BeginTransaction())
                    {
                        //UserDTO user = new UserDTO();
                        //user.UserName = firmdetails.UserList.UserName;
                        //user.Password = firmdetails.UserList.Password;
                        //session.Save(user);
                        //firmdetails.UserList.UserId = user.UserId;
                       

                        session.Save(firmdetails);


                        transaction.Commit();
                    }
                  
                }
               
            }
            catch (Exception error)
            {

                throw new Exception(error.Message);
            }
        }


       





        /// <summary>
        /// Edit Details of Firm Table
        /// </summary>
        public string EditFirmDetails(int firmid, FirmDTO firmdetail)
        {
            try
            {
                using (ISession session = NHibernateSession.OpenSession())
                {
                    var firmUpdate = session.Get<FirmDTO>(firmid);
                    if (firmUpdate != null)
                    {
                        firmUpdate.FirmName = firmdetail.FirmName;
                        firmUpdate.RegisterNo = firmdetail.RegisterNo;
                        firmUpdate.RegisterDate = firmdetail.RegisterDate;
                        firmUpdate.DonationLimit = firmdetail.DonationLimit;
                        firmUpdate.AddressLine1 = firmdetail.AddressLine1;
                        firmUpdate.AddressLine2 = firmdetail.AddressLine2;

                        firmUpdate.CityId = firmdetail.CityId;
                        firmUpdate.StateId = firmdetail.StateId;
                      

                        using (ITransaction transaction = session.BeginTransaction())
                        {
                            session.Save(firmUpdate);
                            transaction.Commit();
                        }
                    }
                    return "FirmDetails Updated Successfully.";
                }
            }
            catch (Exception error)
            {
                return error.Message;
            }
        }

        /// <summary>
        /// Fetch Particular Courier's Details By Id
        /// </summary>
        public FirmDTO GetFirmById(int id)
        {
            try
            {
                FirmDTO firm;
                using (ISession session = NHibernateSession.OpenSession())
                {
                    using (ITransaction transaction = session.BeginTransaction())
                    {
                        firm = session.Get<FirmDTO>(id);
                        transaction.Commit();
                    }
                    return firm;
                }
            }
            catch (Exception error)
            {
                throw error;
            }
        }


    }
}
