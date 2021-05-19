using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using YM_App.Constants;
using YM_App.Models;

namespace YM_App.ViewModels
{
    public class RewardViewModel : BaseViewModel
    {
        public ObservableCollection<Reward> Rewards { get; set; }
        public Reward CurrentReward { get; set; }

        public RewardViewModel()
        {
            Rewards = new ObservableCollection<Reward>();
            Rewards.Add(new Reward()
            {
                Name = "Eat Candy",
                Status = RewardStatus.NotStarted,
                Id = new Guid()
            });
            Rewards.Add(new Reward()
            {
                Name = "Play video games (10 min)",
                Status = RewardStatus.NotStarted,
                Id = new Guid()
            });
            Rewards.Add(new Reward()
            {
                Name = "Take a nap",
                Status = RewardStatus.NotStarted,
                Id = new Guid()
            });
            Rewards.Add(new Reward()
            {
                Name = "Ride bike",
                Status = RewardStatus.NotStarted,
                Id = new Guid()
            });
            Rewards.Add(new Reward()
            {
                Name = "Go swimming",
                Status = RewardStatus.NotStarted,
                Id = new Guid()
            });
        }
    }
}
