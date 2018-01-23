using AluraApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AluraApp.Views
{
	public partial class ListagemView : ContentPage
	{
        public List<Veiculo> veiculosList = new List<Veiculo>()
        {
            new Veiculo { Modelo = "Fiesta Sedan", Preco = 58900, PrecoStr="10000"},
            new Veiculo { Modelo = "Fiesta Hacth", Preco = 45000, PrecoStr="10000"},
            new Veiculo { Modelo = "Siena", Preco = 35000, PrecoStr="10000"},
            new Veiculo { Modelo = "Ford Ka", Preco = 47000, PrecoStr="10000"},
            new Veiculo { Modelo = "Azira", Preco = 85000, PrecoStr="10000"},
            new Veiculo { Modelo = "Hilux", Preco = 125000, PrecoStr="10000"}
        };

		public ListagemView()
		{
			InitializeComponent();
            this.BindingContext = this;
            listViewVeiculos.ItemsSource = veiculosList;
		}

        private void listViewVeiculos_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Navigation.PushAsync( new DetalheView( (Veiculo)e.Item ));
        }
    }
}
