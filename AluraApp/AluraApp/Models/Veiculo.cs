using System;
using System.Collections.Generic;
using System.Text;

namespace AluraApp.Models
{
    public class Veiculo
    {
        public decimal Preco;
        public string Modelo;
        public string PrecoStr;

        public override string ToString()
        {
            return this.Modelo;
        }
        
    }
}
