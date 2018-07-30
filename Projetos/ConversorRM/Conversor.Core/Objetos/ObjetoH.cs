using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;

namespace Conversor.Core.Objetos
{
    public class MovimentoObjetoH
    {
        public string MarcaInicio { get; set; }
        public string HISTORICO { get; set; }
        public MovimentoObjetoH()
        {
            this.MarcaInicio = "H";
            this.HISTORICO = string.Empty;
        }
    }
}
