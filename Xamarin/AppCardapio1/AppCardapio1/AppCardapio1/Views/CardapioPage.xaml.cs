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
    public partial class CardapioPage : ContentPage
    {
        private ObservableCollection<Cardapio> _cardapio;
        public CardapioPage()
        {
            InitializeComponent();
            _cardapio = CardapioService.GetCardapio();
            lvCardapio.ItemsSource = _cardapio;
        }

        private async void lvCardapio_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;

            var cardapio = e.SelectedItem as Cardapio;
            if (cardapio.Title == "Pratos")
            {
                await Navigation.PushAsync(new PratosPage());
            }
            else
            {
                await Navigation.PushAsync(new BebidasPage());
            }

            //await Navigation.PushAsync(new CardapioService(cardapio));
            lvCardapio.SelectedItem = null;

        }
    }
}