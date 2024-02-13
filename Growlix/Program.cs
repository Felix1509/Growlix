using FluentMigrator;
using FluentMigrator.Runner;
using System;
using Microsoft.Extensions.DependencyInjection;
using DataBaseMigrations;
using FluentNHibernate.Cfg.Db;
using FluentNHibernate.Cfg;
using NHibernate.SqlCommand;
using NHibernate;
using Entities;
using NHibernate.Action;

namespace Growlix
{
    internal class Program
    {
        private ISession session;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var sh = new SessionHandler();
            Application.Run(new MainWindow(sh.GetFactory()));
        }

    }
}