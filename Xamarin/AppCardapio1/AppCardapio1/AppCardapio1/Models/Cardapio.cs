using System;
using System.Collections.Generic;
using System.Text;

namespace AppCardapio1.Models
{
    public class Cardapio
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Icon { get; set; }
        public Type TargetType { get; set; }
    }
}
