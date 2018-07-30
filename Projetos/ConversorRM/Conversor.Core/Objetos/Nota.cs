using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


//[16:00:43] Lucas Mesquita: a grosso modo é isso
//[16:00:44] Lucas Mesquita: Linha M
//<IdentificacaoNfse> 
// <Numero>122</Numero>
// <Serie>NF</Serie>
//</IdentificacaoNfse> 
// <DataEmissao>2016-03-04T14:37:07.901-03:00</DataEmissao>
// <ValorServicos>36</ValorServicos>

//Linha I
//<ValorServicos>36</ValorServicos>


//Linha T
//<ValorServicos>36</ValorServicos>
//<ValorIss>1.8</ValorIss>
//<Aliquota>5</Aliquota>

namespace Conversor.Core.Objetos
{
    public class Nota
    {
            public int Contador { get; set; }
            public string Numero { get; set; }
            public string Serie { get; set; }
            public DateTime? DataEmissao { get; set; }
            public string ValorServico { get; set; }
            public string ValorISS { get; set; }
            public int? Aliquota { get; set; }
    }
}
