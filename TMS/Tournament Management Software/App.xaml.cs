﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Animation;
using Tournament_Management_Software.Helpers.Context;

namespace Tournament_Management_Software
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            using (var db = new TMSContext())
            {
                base.OnStartup(e);
                var init = new TMSContextInitializer();
                Database.SetInitializer(init);
                init.InitializeDatabase(db);
            }
        }
    }
}
