using DonationPortal.Models.DTO;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DonationPortal.DLL.NhibernetMappings
{
    public class LoginMap : ClassMap<UserDTO>
    {
        public LoginMap()
        {
            Id(x => x.UserId);
            Map(x => x.UserName);
            Map(x => x.Password);
            Map(x => x.IsActive);
            Table("UserLogin");
        }
    }
}
