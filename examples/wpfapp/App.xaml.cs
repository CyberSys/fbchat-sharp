﻿using System.Windows;

namespace wpfapp
{
    /// <summary>
    /// Logica di interazione per App.xaml
    /// </summary>
    public partial class App : Application
    {
        // FBClient
        private FBClient_Wpf _client;

        public FBClient_Wpf client
        {
            get
            {
                if (_client == null)
                    _client = new FBClient_Wpf();
                return _client;
            }
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            Helpers.WtfWpf.UnsetRestrictedHeaders();
        }
    }
}
