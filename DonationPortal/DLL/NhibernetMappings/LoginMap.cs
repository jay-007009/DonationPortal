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
            Table("UserLogin");
            Id(x => x.UserId);
            //LazyLoad();
            Map(x => x.UserName);
            Map(x => x.Password);
            Map(x => x.IsActive);
          //  HasMany(x => x.firmList).KeyColumn("UserId").Inverse().Cascade.All().Fetch.Join().AsSet().Not.LazyLoad();
        }
    }
}
