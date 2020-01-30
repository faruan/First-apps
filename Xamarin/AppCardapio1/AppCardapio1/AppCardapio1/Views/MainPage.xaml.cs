﻿using AppCardapio1.Models;
using AppCardapio1.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppCardapio1.Views
{
    [DesignTimeVisible(false)]
    public partial class MainPage : MasterDetailPage
    {
        //private ObservableCollection<Conta> _contas;
        private ObservableCollection<MasterPageItem> _menuLista;
        public MainPage()
        {
            InitializeComponent();
            //_contas = ContaService.GetContas();
            //lvContas.ItemsSource = _contas;
            _menuLista = ItemService.GetMenuItens();
            navigationDrawerList.ItemsSource = _menuLista;
            // Define a propriedade ItemSource da pagina MainPage.xaml
            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(HomePage)));
        }
        private void lvContas_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            //var conta = e.SelectedItem as Conta;
            ////await Navigation.PushAsync(new ContaDetalhesPage(conta));
            //Detail = new ContaDetalhesPage(conta);
            ////para exibir a pagina de detalhes
            //IsPresented = false;
        }

        private void OnMenuItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = (MasterPageItem)e.SelectedItem;
            //obtem o tipo de objeto 
            Type pagina = item.TargetType;

            //abre a pagina correspondente ao item selecionado
            /*Cria uma instância do tipo especificado usando o construtor
            que melhor se adequa ao parametro informado*/
            Detail = new NavigationPage((Page)Activator.CreateInstance(pagina));
            IsPresented = false;
        }
    }
}