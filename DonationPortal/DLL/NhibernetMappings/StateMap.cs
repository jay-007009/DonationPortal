using DonationPortal.Models.DTO;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DonationPortal.DLL.NhibernetMappings
{
    public class StateMap : ClassMap<StateDTO>
    {

        public StateMap()
        {
            Id(x => x.StateId);
            Map(x => x.StateName);
          
            Table("State");
        }

    }
}
