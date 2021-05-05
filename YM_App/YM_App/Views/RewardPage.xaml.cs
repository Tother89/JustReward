using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using YM_App.ViewModels;

namespace YM_App.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RewardPage : ContentPage
    {
        public RewardPage()
        {
            InitializeComponent();
            this.BindingContext = new RewardViewModel();
        }
    }
}