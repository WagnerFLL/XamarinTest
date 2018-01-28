﻿using AluraApp.Models;
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