using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using YM_App.Services;
using YM_App.Views;

namespace YM_App
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
