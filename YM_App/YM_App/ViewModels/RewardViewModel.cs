using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace YM_App.ViewModels
{
    public class RewardViewModel : BaseViewModel
    {
        public ObservableCollection<string> Rewards { get; set; }

        public RewardViewModel()
        {
            Rewards = new ObservableCollection<string>();
            Rewards.Add("Eat Candy");
            Rewards.Add("Play video games (10 min)");
            Rewards.Add("Take a nap");
            Rewards.Add("Ride bike");
            Rewards.Add("Go swimming");
        }
    }
}
