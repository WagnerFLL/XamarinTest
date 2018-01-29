using System;
using System.Collections.Generic;
using System.Text;

namespace AluraApp.Models
{
    public class Veiculo
    {
        public decimal Preco { get; set; }
        public string Modelo { get; set; }
        public decimal FreioABSValue { get; set; }
        public decimal MP3PlayerValue { get; set; }
        public decimal ArCondicionadoValue { get; set; }
        public string ArCondicionado
        {
            get
            {
                return String.Format("Ar Condicionado - R$ {0}", this.ArCondicionadoValue);
            }
        }
        public string FreioABS
        {
            get
            {
                return String.Format("Ar Condicionado - R$ {0}", this.FreioABSValue);
            }
        }
        public string MP3Player
        {
            get
            {
                return String.Format("MP3Player - R$ {0}", this.MP3PlayerValue);
            }
        }
        public string PrecoStr
        {
            get
            {
                return String.Format("R$ {0}",Convert.ToString(Preco));
            }
        }
        public override string ToString()
        {
            return this.Modelo;
        }

        public Veiculo()
        {
            this.FreioABSValue = 1200;
            this.MP3PlayerValue = 785;
            this.ArCondicionadoValue = 2300;
        }

    }
}
