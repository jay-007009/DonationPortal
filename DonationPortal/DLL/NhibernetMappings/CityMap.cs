using DonationPortal.Models.DTO;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DonationPortal.DLL.NhibernetMappings
{
    public class CityMap : ClassMap <CityDTO>
    {
        public CityMap()
        {
            Id(x => x.CityId);
            Map(x => x.CityName);
            Map(x => x.StateId);
          
            References(x => x.StateList).Column("StateId").Fetch.Join();
          
            Table("City");
        }
    }
}
