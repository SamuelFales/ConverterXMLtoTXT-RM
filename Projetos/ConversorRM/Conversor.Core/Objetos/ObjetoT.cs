using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;

namespace Conversor.Core.Objetos
{
    public class MovimentoObjetoT
    {
        public string MarcaInicio { get; set; }
        public int NUMEROSEQUENCIAL { get; set; }
        public string CODTRB { get; set; }
        public double BASEDECALCULO { get; set; }
        public double ALIQUOTA { get; set; }
        public double VALOR { get; set; }
        public double FATORREDUCAO { get; set; }
        public double FATORSUBSTTRIBU { get; set; }
        public double VLRISENTO { get; set; }
        public string CODRETENCAO { get; set; }
        public string TIPORECOLHIMENTO { get; set; }
        public string CODTRBBASE { get; set; }
        public double BASEDECALCULOCALCULADA { get; set; }
        public int EDITADO { get; set; }
        public string MODALIDADEBC { get; set; }
        public string SITTRIBUTARIA { get; set; }
        public MovimentoObjetoT()
        {
            this.MarcaInicio = "T";
            this.NUMEROSEQUENCIAL = 1;
            this.CODTRB = string.Empty;
            this.BASEDECALCULO = 0;
            this.ALIQUOTA = 0;
            this.VALOR = 0;
            this.FATORREDUCAO = 0;
            this.FATORSUBSTTRIBU = 0;
            this.VLRISENTO = 0;
            this.CODRETENCAO = string.Empty;
            this.TIPORECOLHIMENTO = "1";
            this.CODTRBBASE = string.Empty;
            this.BASEDECALCULOCALCULADA = 0;
            this.EDITADO = 0;
            this.MODALIDADEBC = string.Empty;
            this.SITTRIBUTARIA = string.Empty;
        }
    }
}
