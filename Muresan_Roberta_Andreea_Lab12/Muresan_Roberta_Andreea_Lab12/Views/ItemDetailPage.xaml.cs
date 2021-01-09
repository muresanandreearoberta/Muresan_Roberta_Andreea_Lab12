using System.ComponentModel;
using Xamarin.Forms;
using Muresan_Roberta_Andreea_Lab12.ViewModels;

namespace Muresan_Roberta_Andreea_Lab12.Views
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