using AppCardapio1.Models;
using AppCardapio1.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace AppCardapio1.Services
{
    public class CardapioService
    {
        private static ObservableCollection<Cardapio> cardapioLista { get; set; }
        public static ObservableCollection<Cardapio> GetCardapio()
        {
            cardapioLista = new ObservableCollection<Cardapio>();

            var pagina1 = new Cardapio() { Id = 1, Title = "Pratos", Icon = "dinner.png", TargetType = typeof(PratosPage) };
            var pagina2 = new Cardapio() { Id = 2, Title = "Bebidas", Icon = "drinks.png", TargetType = typeof(BebidasPage) };

            // Adicionando items no menuLista
            cardapioLista.Add(pagina1);
            cardapioLista.Add(pagina2);

            //retorna a lista de itens 

            return cardapioLista;
        }

    }
}
