using DonationPortal.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DonationPortal.DLL.Interfaces
{
    public interface ILogin
    {
        public UserDTO GetLoginDetails(string name, string pwd);
    }
}
