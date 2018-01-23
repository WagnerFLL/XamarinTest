using AluraApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AluraApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DetalheView : ContentPage
	{
        Veiculo choice;
		public DetalheView (Veiculo veiculo)
		{
			InitializeComponent ();
            this.choice = veiculo;
		}
	}
}