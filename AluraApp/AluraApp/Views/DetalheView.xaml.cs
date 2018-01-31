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
        public Veiculo Choice { get; set; }
        public bool TemFreio;
        public bool TemAr;
        public bool TemMP3;
        
        public decimal PrecoT
        {
            get
            {
                decimal preco = Choice.Preco;
                if (TemAr) preco += Choice.ArCondicionadoValue;
                if (TemFreio) preco += Choice.FreioABSValue;
                if (TemMP3) preco += Choice.MP3PlayerValue;
                return preco;
            }

            set
            {
                PrecoT = value;
            }
        }
        public string PrecoStr
        {
            get
            {
                return String.Format("Total: R$ {0}",this.PrecoT);
            }
        }
        
        public DetalheView (Veiculo veiculo)
		{
			InitializeComponent ();
            this.Choice = veiculo;
            this.PrecoT = Choice.Preco;
            this.BindingContext = this;
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Agendameto(this.Choice));
        }
    }
}