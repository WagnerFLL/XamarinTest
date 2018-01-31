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
        public List<Veiculo> VeiculosList { get; set; }
        

		public ListagemView()
		{
			InitializeComponent();
            VeiculosList = new List<Veiculo>(){
                new Veiculo { Modelo = "Fiesta Sedan", Preco = 58900 },
                new Veiculo { Modelo = "Fiesta Hacth", Preco = 45000 },
                new Veiculo { Modelo = "Siena", Preco = 35000 },
                new Veiculo { Modelo = "Ford Ka", Preco = 47000 },
                new Veiculo { Modelo = "Azira", Preco = 85000 },
                new Veiculo { Modelo = "Hilux", Preco = 125000 }
        };
            this.BindingContext = this;
		}

        private void listViewVeiculos_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Navigation.PushAsync(new DetalheView((Veiculo)e.Item));   
        }
    }
}
