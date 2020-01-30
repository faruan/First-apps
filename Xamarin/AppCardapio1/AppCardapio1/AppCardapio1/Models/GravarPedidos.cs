using System;
using System.Collections.Generic;
using System.Text;

namespace AppCardapio1.Models
{
    public class GravarPedidos
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public string Qty { get; set; }
        public string Total { get; set; }
        public string Image { get; set; }
        public GravarPedidos()
        {
        }
    }
}
