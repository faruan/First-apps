using AppCardapio1.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace AppCardapio1.Services
{
    public class BebidasService
    {
        private static ObservableCollection<ItemsBebidas> bebidaLista { get; set; }
        public static ObservableCollection<ItemsBebidas> GetBebidasItens()
        {
            bebidaLista = new ObservableCollection<ItemsBebidas>();
            // Criando as paginas para navegação
            var pagina1 = new ItemsBebidas()
            {
                Name = "Coca Cola",
                Image = "https://firebasestorage.googleapis.com/v0/b/fir-appcardapio.appspot.com/o/Bebidas%2Fcoca.png?alt=media&token=dc116329-72ec-4535-ba54-88dcb14308b0",
                Description = "Lata 350ml",
                Price = "4"
            };
            var pagina2 = new ItemsBebidas()
            {
                Name = "Suco de laranja",
                Image = "https://firebasestorage.googleapis.com/v0/b/fir-appcardapio.appspot.com/o/Bebidas%2Fsuco.png?alt=media&token=ea4567c1-b012-44d1-bc1e-cc94b7c3c973",
                Description = "Jarra de 750ml",
                Price = "9"
            };
            var pagina3 = new ItemsBebidas()
            {
                Name = "Água Mineral",
                Image = "https://firebasestorage.googleapis.com/v0/b/fir-appcardapio.appspot.com/o/Bebidas%2Fagua.PNG?alt=media&token=33692c71-ab5c-4baf-8941-237777a7536d",
                Description = "Sem Gás 500ml",
                Price = "3"
            };
            var pagina4 = new ItemsBebidas()
            {
                Name = "Coca Cola Zero",
                Image = "https://firebasestorage.googleapis.com/v0/b/fir-appcardapio.appspot.com/o/Bebidas%2Fcocazero.PNG?alt=media&token=b83a1e12-d9da-4f88-b6a5-16769c19c280",
                Description = "Lata 350ml",
                Price = "4"
            };
            var pagina5 = new ItemsBebidas()
            {
                Name = "Fanta",
                Image = "https://firebasestorage.googleapis.com/v0/b/fir-appcardapio.appspot.com/o/Bebidas%2Ffanta.PNG?alt=media&token=8dc6b3e5-6528-48f5-83ba-a4099094bf8c",
                Description = "Lata 350ml",
                Price = "4"
            };
            var pagina6 = new ItemsBebidas()
            {
                Name = "Guaraná Antarctica",
                Image = "https://firebasestorage.googleapis.com/v0/b/fir-appcardapio.appspot.com/o/Bebidas%2Fguarana.PNG?alt=media&token=6e628f9e-690b-4c0f-ad54-9ef6ece988b3",
                Description = "Lata 350ml",
                Price = "4"
            };
            var pagina7 = new ItemsBebidas()
            {
                Name = "Cerveja Skol",
                Image = "https://firebasestorage.googleapis.com/v0/b/fir-appcardapio.appspot.com/o/Bebidas%2Fskol.PNG?alt=media&token=d8092c13-f315-4258-aa84-000e1b7b82c3",
                Description = "Garafa 600ml",
                Price = "8"
            };
            var pagina8 = new ItemsBebidas()
            {
                Name = "Cerveja SubZero",
                Image = "https://firebasestorage.googleapis.com/v0/b/fir-appcardapio.appspot.com/o/Bebidas%2Fsubzero.PNG?alt=media&token=60d097bd-826a-42c7-bfcd-0615f3be7572",
                Description = "Garafa 600ml",
                Price = "8"
            };
            var pagina9 = new ItemsBebidas()
            {
                Name = "Caipirinha",
                Image = "https://firebasestorage.googleapis.com/v0/b/fir-appcardapio.appspot.com/o/Bebidas%2Fcaipirinha.PNG?alt=media&token=c1941980-0db9-47bb-9ab0-ffd424bea92c",
                Description = "Copo 300ml, batido com gelo, cachaça e limão",
                Price = "6"
            };
            // Adicionando items no menuLista
            bebidaLista.Add(pagina1);
            bebidaLista.Add(pagina2);
            bebidaLista.Add(pagina3);
            bebidaLista.Add(pagina4);
            bebidaLista.Add(pagina5);
            bebidaLista.Add(pagina6);
            bebidaLista.Add(pagina7);
            bebidaLista.Add(pagina8);
            bebidaLista.Add(pagina9);
            //retorna a lista de itens 
            return bebidaLista;
        }

    }
}
