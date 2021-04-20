using System.ComponentModel;
using Xamarin.Forms;
using YM_App.ViewModels;

namespace YM_App.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}