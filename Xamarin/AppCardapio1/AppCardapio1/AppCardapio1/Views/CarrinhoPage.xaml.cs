using AppCardapio1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppCardapio1.Views
{
    public partial class CarrinhoPage : ContentPage
    {
        public List<GravarPedidos> detalhes = new List<GravarPedidos>();
        public CarrinhoPage()
        {
            InitializeComponent();
            this.Title = "Carrinho";
            //ConsultaCarrinho c = new ConsultaCarrinho();

            detalhes.Add(pd);
            cart.ItemsSource = detalhes;
            //total.Text = c.GetTotal() + "";
        }

        public GravarPedidos pd { get; }

        public void Finish_btn_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Confirmado", "Pedido Realizado com Sucesso.", "OK");
            Navigation.PushAsync(new MinhaContaPage());
        }
    }
}