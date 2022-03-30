
using DonationPortal.DLL.NhibernetMappings;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DonationPortal
{
    public class NHibernateSession
    {
        public static ISession OpenSession()
        {
            //   ISessionFactory SessionFactory = Fluently.Configure()
            //  .Database(MsSqlConfiguration.MsSql2012
            //  .ConnectionString(@"Data Source=.;Initial Catalog=DonationDB;Integrated Security=True")
            //  .ShowSql())
            //  .Mappings(m => m.FluentMappings.AddFromAssemblyOf<FirmMap>())
            ////  .Mappings(m => m.FluentMappings.AddFromAssemblyOf<DonationMap>())
            //  .Mappings(m => m.FluentMappings.AddFromAssemblyOf<LoginMap>())
            // // .Mappings(m => m.FluentMappings.AddFromAssemblyOf<StateMap>())
            ////  .Mappings(m => m.FluentMappings.AddFromAssemblyOf<CityMap>())
            //  .ExposeConfiguration(cfg => new SchemaExport(cfg)
            //  .Create(false, false))
            //  .BuildSessionFactory();
            //   return SessionFactory.OpenSession();




            ISessionFactory sessionFactory = Fluently.Configure()
          .Database(MsSqlConfiguration.MsSql2008
            .ConnectionString(@"Data Source=.;Initial Catalog=DonationDB;Integrated Security=True")
                        .ShowSql()
          )
         .Mappings(m =>
                    m.FluentMappings
                        .AddFromAssemblyOf<LoginMap>()
                        .AddFromAssemblyOf<FirmMap>()
                        .AddFromAssemblyOf<DonationMap>())
          .ExposeConfiguration(cfg => new SchemaExport(cfg)
                                          .Create(false, false))
          .BuildSessionFactory();
            return sessionFactory.OpenSession();
        }
    }
}
