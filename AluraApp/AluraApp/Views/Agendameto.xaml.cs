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
	public partial class Agendameto : ContentPage
	{
        public Veiculo Veiculo { get; set; }

		public Agendameto (Veiculo veiculo)
		{
			InitializeComponent ();
            this.Veiculo = veiculo;
            this.BindingContext = this;
        }
	}
}