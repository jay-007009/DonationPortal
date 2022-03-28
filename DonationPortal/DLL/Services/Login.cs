using DonationPortal.DLL.Interfaces;
using DonationPortal.Models.DTO;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DonationPortal.DLL.Services
{
    public class Login :ILogin
    {

        /// <summary>
        /// Fetch Login Details By Name
        /// </summary>
        public UserDTO GetLoginDetails(string name,string pwd)
        {
            try
            {
                UserDTO user;
                using (ISession session = NHibernateSession.OpenSession())
                {
                    using (ITransaction transaction = session.BeginTransaction())
                    {
                      
                            user = session.Get<UserDTO>(name, pwd);
                        if (user.IsActive != true)
                        {
                            transaction.Commit();
                        }
                    }
                    return user;
                }
            }
            catch (Exception error)
            {
                throw error;
            }
        }
    }
}
