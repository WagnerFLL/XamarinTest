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

        bool temFreio;
        public bool TemFreio
        {
            get
            {
                return temFreio;
            }
            set
            {
                temFreio = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(PrecoStr));
            }
        }

        bool temAr;
        public bool TemArCondicionado
        {
            get
            {
                return temAr;
            }
            set
            {
                temAr = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(PrecoStr));
            }
        }

        bool temMP3;
        public bool TemMP3Player
        {
            get
            {
                return temMP3;
            }
            set
            {
                temMP3 = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(PrecoStr));
            }
        }
        public string PrecoStr
        {
            get
            {
                return String.Format("Total: R$ {0}",this.Choice.Preco +
                    (temAr ? Choice.ArCondicionadoValue : 0) +
                    (temFreio ? Choice.FreioABSValue : 0) + 
                    (temMP3 ? Choice.MP3PlayerValue : 0));
            }
        }
        
        public DetalheView (Veiculo veiculo)
		{
			InitializeComponent ();
            this.Choice = veiculo;
            this.BindingContext = this;
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Agendameto(this.Choice));
        }
    }
}