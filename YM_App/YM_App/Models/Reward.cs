using System;
using System.Collections.Generic;
using System.Text;
using YM_App.Constants;

namespace YM_App.Models
{
    public class Reward
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool IsCompleted => Status == RewardStatus.Completed;
        public string Status { get; set; }
    }
}
