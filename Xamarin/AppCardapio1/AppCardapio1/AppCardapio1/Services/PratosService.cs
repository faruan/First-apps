using AppCardapio1.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace AppCardapio1.Services
{
    public class PratosService
    {
        private static ObservableCollection<ItemsPratos> pratoLista { get; set; }
        public static ObservableCollection<ItemsPratos> GetPratoItens()
        {
            pratoLista = new ObservableCollection<ItemsPratos>();
            // Criando as paginas para navegação
            var pagina1 = new ItemsPratos()
            {
                Name = "Picanha na brasa",
                Image = "https://firebasestorage.googleapis.com/v0/b/fir-appcardapio.appspot.com/o/Pratos%2FPicanhabrasa.PNG?alt=media&token=d68660db-e76a-46a3-9027-ee9d94807479",
                Description = "Delicioso prato executivo acompanhado com arroz, farofa de ovo e fritas.",
                Price = "50"
            };
            var pagina2 = new ItemsPratos()
            {
                Name = "Strogonoff de carne",
                Image = "https://firebasestorage.googleapis.com/v0/b/fir-appcardapio.appspot.com/o/Pratos%2FStrogonoff.PNG?alt=media&token=a5b044a3-01b4-49e0-98b3-d5a8872d8299",
                Description = "Tradicional com arroz e batata palha.",
                Price = "20"
            };
            var pagina3 = new ItemsPratos()
            {
                Name = "Macarronada da casa",
                Image = "https://firebasestorage.googleapis.com/v0/b/fir-appcardapio.appspot.com/o/Pratos%2Fmacarrao.png?alt=media&token=cd92e8cc-5433-4db3-abfe-c3d648c4a26b",
                Description = "Espaguete, carne moida e molho de tomate tradicional.",
                Price = "18"
            };
            var pagina4 = new ItemsPratos()
            {
                Name = "Filet mignon á parmegiana",
                Image = "https://firebasestorage.googleapis.com/v0/b/fir-appcardapio.appspot.com/o/Pratos%2Ffilemignon.png?alt=media&token=306334ac-7d64-4cc4-bd29-0e714c1bac85",
                Description = "Acompanha arroz e fritas.",
                Price = "120"
            };
            var pagina5 = new ItemsPratos()
            {
                Name = "Tilápia ala grill",
                Image = "https://firebasestorage.googleapis.com/v0/b/fir-appcardapio.appspot.com/o/Pratos%2Ftilapia.png?alt=media&token=2db55130-a96f-4113-bbb8-2da2713426cd",
                Description = "Filé de tilápia levemente empanado e grelhado, com vinagrete de tomate cereja e manjericão.",
                Price = "54"
            };
            var pagina6 = new ItemsPratos()
            {
                Name = "Salada 10 light",
                Image = "https://firebasestorage.googleapis.com/v0/b/fir-appcardapio.appspot.com/o/Pratos%2Fsalada.png?alt=media&token=159be030-3d36-4146-a86d-1ee6b8715669",
                Description = "Prato light e vegano! Mix de salada com 10 opções de folhas, hortaliças e legumes.",
                Price = "13"
            };
            // Adicionando items no menuLista
            pratoLista.Add(pagina1);
            pratoLista.Add(pagina2);
            pratoLista.Add(pagina3);
            pratoLista.Add(pagina4);
            pratoLista.Add(pagina5);
            pratoLista.Add(pagina6);
            //retorna a lista de itens 
            return pratoLista;
        }

    }
}
