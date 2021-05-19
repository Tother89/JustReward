using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using YM_App.Constants;
using YM_App.Models;
using YM_App.ViewModels;

namespace YM_App.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RewardPage : ContentPage
    {
        private RewardViewModel ViewModel { get; set; }

        public RewardPage()
        {
            InitializeComponent();
            this.BindingContext = ViewModel = new RewardViewModel();
        }

        private void CheckBox_OnCheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            CheckBox checkBox = (CheckBox) sender;

            if (checkBox.IsChecked)
            {
                // Set status to completed
            }
        }



        private async void DeleteActionOnClicked(object sender, EventArgs e)
        {
            if (sender is MenuItem mi)
            {
                if (await Application.Current.MainPage.DisplayAlert(App.DELETE, App.REMOVE_ITEM, App.YES, App.NO))
                {
                    var reward = (Reward) mi.CommandParameter;
                    ViewModel.Rewards.Remove(reward);
                }
            }
        }

        private void TapGestureRecognizer_OnTapped(object sender, EventArgs e)
        {
            
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            Button button = (Button) sender;
            
            // Create a new item in the list
            this.ViewModel.Rewards.Add(new Reward()
            {
                Id = new Guid(),
                Name = RewardInput.Text,
                Status = RewardStatus.NotStarted
            });
        }
    }
}