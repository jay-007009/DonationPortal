using DonationPortal.Models.DTO;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DonationPortal.DLL.NhibernetMappings
{
    public class DonationMap : ClassMap<DonorDTO>
    {
        public DonationMap()
        {
            Id(x => x.DonorId);
            Map(x => x.DonorName);
            Map(x => x.AddressLine1);
            Map(x => x.AddressLine2);
            Map(x => x.CityId);
            Map(x => x.StateId);
            Map(x => x.DonationAmount);
            Map(x => x.MobileNo);
            Map(x => x.FirmId);
            References(x => x.FirmList).Column("FirmId").Fetch.Join();
            References(x => x.CityList).Column("CityId").Fetch.Join();
            References(x => x.StateList).Column("StateId").Fetch.Join();
            Table("Donor");
        }
    }
}
