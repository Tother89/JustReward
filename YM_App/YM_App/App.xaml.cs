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

        public const string ACTION_NOT_ALLOWED = "Action not allowed\n";
        public const string REMOVE_ITEM = "Are you sure you want to remove this item?\n";
        public const string DELETE = "Delete";
        public const string YES = "Yes";
        public const string NO = "No";
    }
}
