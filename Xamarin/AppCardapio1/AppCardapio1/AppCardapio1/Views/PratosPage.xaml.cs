using AppCardapio1.Models;
using AppCardapio1.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppCardapio1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PratosPage : ContentPage
    {
        private ObservableCollection<ItemsPratos> _prato;
        public PratosPage()
        {
            InitializeComponent();
            _prato = PratosService.GetPratoItens();
            lvPrato.ItemsSource = _prato;
        }
        private async void lvPrato_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;
            var pro = (e.SelectedItem as ItemsPratos);
            await Navigation.PushAsync(new DetalhesPage(pro.Image, pro.Name, pro.Description, pro.Price));
            lvPrato.SelectedItem = null;
        }
    }
}