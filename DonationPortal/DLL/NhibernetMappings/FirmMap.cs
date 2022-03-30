using DonationPortal.Models.DTO;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DonationPortal.DLL.NhibernetMappings
{
    public class FirmMap : ClassMap<FirmDTO>
    {
        public FirmMap()
        {
            Table("Firm");
            Id(x => x.FirmId);
            //LazyLoad();
            Map(x => x.FirmName);
            Map(x => x.RegisterNo);
            Map(x => x.RegisterDate);
            Map(x => x.DonationLimit);
            Map(x => x.AddressLine1);
            Map(x => x.AddressLine2);
          //  Map(x => x.CityId);
          //  Map(x => x.StateId);
            Map(x => x.UserId);
          
            References(x => x.UserList).Column("UserId").Fetch.Join();
           // References(x => x.CityList).Column("CityId").Fetch.Join();
          //  References(x => x.StateList).Column("StateId").Fetch.Join();
          //  HasMany(x => x.DonorList).KeyColumn("FirmId").Inverse().Cascade.All().Fetch.Join().AsSet().Not.LazyLoad();
        }
    }
}
