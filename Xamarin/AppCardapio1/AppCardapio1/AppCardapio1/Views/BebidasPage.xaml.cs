using AppCardapio1.Models;
using AppCardapio1.Services;
using AppCardapio1.Views;
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
    public partial class BebidasPage : ContentPage
    {
        private ObservableCollection<ItemsBebidas> _bebida;
        public BebidasPage()
        {
            InitializeComponent();
            _bebida = BebidasService.GetBebidasItens();
            lvBebida.ItemsSource = _bebida;
        }
        private async void lvBebida_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;
            var pro = (e.SelectedItem as ItemsBebidas);
            await Navigation.PushAsync(new DetalhesPage(pro.Image, pro.Name, pro.Description, pro.Price));
            lvBebida.SelectedItem = null;
        }
    }
}