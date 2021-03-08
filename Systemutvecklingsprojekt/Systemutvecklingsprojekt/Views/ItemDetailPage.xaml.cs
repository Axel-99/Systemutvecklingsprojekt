using System.ComponentModel;
using Xamarin.Forms;
using Systemutvecklingsprojekt.ViewModels;

namespace Systemutvecklingsprojekt.Views
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