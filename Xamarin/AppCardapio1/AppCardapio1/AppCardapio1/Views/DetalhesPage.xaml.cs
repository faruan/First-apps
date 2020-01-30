using AppCardapio1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppCardapio1.Models;
using AppCardapio1.Interface;
using System.Data;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppCardapio1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetalhesPage : ContentPage
    {
        string pimage;
        string pprice;
        public DetalhesPage(String image, String name, String description, String price)
        {
            this.Title = "Detalhes do Produto";
            InitializeComponent();
            Name.Text = name;
            Description.Text = description;
            Price.Text = "R$" + price;
            Image.Source = image;
            pimage = image;
            pprice = price;
        }
        public string txtSyslog { get; private set; }
        public void Add_btn_Clicked(object sender, EventArgs e)
        {

            GravarPedidos pd = new GravarPedidos();
            int qty = Convert.ToInt16(Qty.Text);
            int total = Convert.ToInt32(pprice);
            pd.Name = Name.Text;
            pd.Price = Price.Text;
            pd.Total = (qty * total).ToString();
            pd.Qty = qty + "";
            pd.Image = pimage;
            //Conexao c = new Conexao();
            //c.InsertDetails(pd);
            //MySqlConnection con = new MySqlConnection("Server=west1-phpmyadmin.dreamhost.com;Port=3306;database=dbevan;User Id=evandrox;Password=projetor2019");
            //try
            //{
            //    if (con.State == ConnectionState.Closed)
            //    {
            //        con.Open();
            //        txtSyslog = "Successfuly Connected";
            //    }
            //}
            //catch (MySqlException ex)
            //{
            //    txtSyslog = ex.ToString();
            //}
            //finally
            //{
            //    con.Close();
            //}
            Navigation.PushAsync(new CarrinhoPage());
        }
    }
}