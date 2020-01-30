using AppCardapio1.Models;
using AppCardapio1.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace AppCardapio1.Services
{
    public class ItemService
    {
        private static ObservableCollection<MasterPageItem> menuLista { get; set; }
        public static ObservableCollection<MasterPageItem> GetMenuItens()
        {
            menuLista = new ObservableCollection<MasterPageItem>();
            // Criando as paginas para navegação
            var pagina1 = new MasterPageItem() { Title = "Home", Icon = "home.png", TargetType = typeof(HomePage) };
            var pagina2 = new MasterPageItem() { Title = "Cardápio", Icon = "restaurant.png", TargetType = typeof(CardapioPage) };
            var pagina3 = new MasterPageItem() { Title = "Sobre Nós", Icon = "us.png", TargetType = typeof(AboutPage) };
            var pagina4 = new MasterPageItem() { Title = "Minha Conta", Icon = "payment.png", TargetType = typeof(MinhaContaPage) };
            // Adicionando items no menuLista
            menuLista.Add(pagina1);
            menuLista.Add(pagina2);
            menuLista.Add(pagina3);
            menuLista.Add(pagina4);
            //retorna a lista de itens 
            return menuLista;
        }
    }
}
