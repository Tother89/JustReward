using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace YM_App.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
        }

        public void AddReward(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RewardPage());
        }
    }
}