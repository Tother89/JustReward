using System;
using System.Collections.Generic;
using System.Text;

namespace YM_App.Models
{
    public class Reward
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool IsCompleted { get; set; }
        public string Status { get; set; }
    }
}
