using Entities;
using DataBaseMigrations;
using FluentNHibernate;
using FluentMigrator.Runner;
using FluentMigrator.MySql;
using NHibernate;
using System;
using System.IO;
using Microsoft.Extensions.DependencyInjection;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate.Dialect;

namespace Growlix
{
    public class SessionHandler
    {
        private static ISessionFactory _sessionFactory;

        public SessionHandler()
        {
            migrate_db();
        }
        public ISessionFactory GetFactory()
        {

            var sqlcBuilder = new System.Data.SqlClient.SqlConnectionStringBuilder
            {
                DataSource = "localhost",
                InitialCatalog = "grow_db",
                UserID = "root",
                Password = "mVeroDith0910."
            };

            // Wenn _sessionFactory null ist, wird die Initialisierung durchgeführt
            if (_sessionFactory == null)
            {
                InitializeSessionFactory();
            }

            // Fluent Configuration für NHibernate
            return Fluently.Configure()
                // Verwendung des MySQL-Standards
                .Database(MySQLConfiguration.Standard.ConnectionString(sqlcBuilder.ConnectionString))
                // Mappings hinzufügen, hier werden die Fluent Mappings geladen
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<SpendingMap>())
                // Konfigurationsexposition für spezifische Eigenschaften
                .ExposeConfiguration(cfg => cfg
                    // Verbindungsbereitsteller, Dialekt, Aktueller Sitzungskontext usw. einstellen
                    .SetProperty(NHibernate.Cfg.Environment.ConnectionProvider, "NHibernate.Connection.DriverConnectionProvider")
                    .SetProperty(NHibernate.Cfg.Environment.CommandTimeout, "100")
                    .SetProperty(NHibernate.Cfg.Environment.Dialect, "NHibernate.Dialect.MySQL5Dialect")
                    .SetProperty(NHibernate.Cfg.Environment.CurrentSessionContextClass, "thread_static")
                    .SetProperty(NHibernate.Cfg.Environment.QuerySubstitutions, "true 1, false 0, yes 1, no 0, 1 true, 0 false")
                    .SetProperty(NHibernate.Cfg.Environment.ShowSql, "true")
                    .SetProperty(NHibernate.Cfg.Environment.MaxFetchDepth, "3"))
                // Session Factory aufbauen
                .BuildSessionFactory();


        }

        private static void InitializeSessionFactory()
        {

        }

        #region Migration Methods
        private static void migrate_db()
        {
            var serviceProvider = CreateService();
            using (var scope = serviceProvider.CreateScope())
            {
                UpdateDatabaseSchema(scope.ServiceProvider);
            }

        }
        private static void UpdateDatabaseSchema(IServiceProvider serviceProvider)
        {
            var runner = serviceProvider.GetRequiredService<IMigrationRunner>();
            runner.MigrateUp();
        }
        private static IServiceProvider CreateService()
        {
            var sqlcBuilder = new System.Data.SqlClient.SqlConnectionStringBuilder
            {
                DataSource = "localhost",
                InitialCatalog = "grow_db",
                UserID = "root",
                Password = "mVeroDith0910."

            };

            return new ServiceCollection()
                .AddFluentMigratorCore()
                .ConfigureRunner(rb => rb
                    .AddMySql5()
                    .WithGlobalConnectionString(sqlcBuilder.ConnectionString)
                .ScanIn(typeof(CreateTableSpendingCategories).Assembly).For.Migrations().WithGlobalCommandTimeout(new TimeSpan(0, 0, 2, 0)))
                .AddLogging(lg => lg.AddFluentMigratorConsole())
                .BuildServiceProvider(false);
        }
        #endregion
    }
}
