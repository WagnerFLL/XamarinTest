using System;
using System.Collections.Generic;
using System.Text;

namespace AluraApp.Models
{
    public class Veiculo
    {
        public decimal Preco { get; set; }
        public string Modelo { get; set; }
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
    }
}
