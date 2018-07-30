using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;

namespace Conversor.Core.Objetos
{
    public class MovimentoObjetoI
    {
        public string MarcaInicio { get; set; }
        public string CODIGOPRD { get; set; }
        public int NUMEROSEQUENCIAL { get; set; }
        public string CODTIP { get; set; }
        public double QUANTIDADE { get; set; }
        public double PRECOUNITARIO { get; set; }
        public double PRECOTABELA { get; set; }
        public double PERCENTUALDESC { get; set; }
        public double VALORDESC { get; set; }
        public double PERCENTUALDESP { get; set; }
        public double VALORDESP { get; set; }
        public DateTime DATAEMISSAO { get; set; }
        public string CODMEN { get; set; }
        public int NUMEROTRIBUTOS { get; set; }
        public string CODTB1FAT { get; set; }
        public string CODTB2FAT { get; set; }
        public string CODTB3FAT { get; set; }
        public string CODTB4FAT { get; set; }
        public string CODTB5FAT { get; set; }
        public string CODTB1FLX { get; set; }
        public string CODTB2FLX { get; set; }
        public string CODTB3FLX { get; set; }
        public string CODTB4FLX { get; set; }
        public string CODTB5FLX { get; set; }
        public string CAMPOLIVRE { get; set; }
        public string CODUND { get; set; }
        public double QUANTIDADEARECEBER { get; set; }
        public int IDNAT { get; set; }
        public string CODCPG { get; set; }
        public DateTime DATAENTREGA { get; set; }
        public string PRATELEIRA { get; set; }
        public int IDCNT { get; set; }
        public int NSEQITMCNT { get; set; }
        public double VALORTOTALITEM { get; set; }
        public string CODCCUSTO { get; set; }
        public string CODNAT { get; set; }
        public string CODRPR { get; set; }
        public string IDPRDCOMPOSTO { get; set; }
        public string CODDEPARTAMENTO { get; set; }
        public string TRIBUTACAOECF { get; set; }
        public double VALORESCRITURACAO { get; set; }
        public string VALORCODIGOPRD { get; set; }
        public int TIPOCODIGOPRD { get; set; }
        public string CST { get; set; }
        public string CODTRF { get; set; }
        public string CODTBORCAMENTO { get; set; }
        public double VALOROPRFM1 { get; set; }
        public double VALOROPRFM2 { get; set; }
        public string CANCELADO { get; set; }
        public double VALORUNTORCAMENTO { get; set; }
        public DateTime DATAORCAMENTO { get; set; }
        public double COMISSAOREPRES { get; set; }
        public double QTDUNDPEDIDO { get; set; }
        public int CODFILIAL { get; set; }
        public string CODLOCAL { get; set; }
        public double VALORLIQUIDO { get; set; }
        public string CODVEN1 { get; set; }
        public double PERCENTCOMISSAO { get; set; }
        public string  CODIGOSERVICO  { get; set; } 
        public string CODMUNSERVICO { get; set; }                             
        public string CODETDMUNSERV { get; set; }                                  
        public double VALORDESCCONDICONALITM { get; set; }
        public double VALORDESPCONDICIONALITM { get; set; }       

        public MovimentoObjetoI()
        {
            this.MarcaInicio = "I";
            this.CODIGOPRD = string.Empty;
            this.NUMEROSEQUENCIAL = 1;
            this.CODTIP = string.Empty;
            this.QUANTIDADE = 1;
            this.PRECOUNITARIO = 0;
            this.PRECOTABELA = 0;
            this.PERCENTUALDESC = 0;
            this.VALORDESC = 0;
            this.PERCENTUALDESP = 0;
            this.VALORDESP = 0;
            this.DATAEMISSAO = DateTime.MinValue;
            this.CODMEN = string.Empty;
            this.NUMEROTRIBUTOS = 0;
            this.CODTB1FAT = string.Empty;
            this.CODTB2FAT = string.Empty;
            this.CODTB3FAT = string.Empty;
            this.CODTB4FAT = string.Empty;
            this.CODTB5FAT = string.Empty;
            this.CODTB1FLX = string.Empty;
            this.CODTB2FLX = string.Empty;
            this.CODTB3FLX = string.Empty;
            this.CODTB4FLX = string.Empty;
            this.CODTB5FLX = string.Empty;
            this.CAMPOLIVRE = string.Empty;
            this.CODUND = "US";
            this.QUANTIDADEARECEBER = 1;
            this.IDNAT = 0;
            this.CODCPG = "C001";
            this.DATAENTREGA = DateTime.MinValue;
            this.PRATELEIRA = string.Empty;
            this.IDCNT = 0;
            this.NSEQITMCNT = 0;
            this.VALORTOTALITEM = 0;
            this.CODCCUSTO = string.Empty;
            this.CODNAT = string.Empty;
            this.CODRPR = string.Empty;
            this.IDPRDCOMPOSTO = string.Empty;
            this.CODDEPARTAMENTO = string.Empty;
            this.TRIBUTACAOECF = string.Empty;
            this.VALORESCRITURACAO = 0;
            this.VALORCODIGOPRD = string.Empty;
            this.TIPOCODIGOPRD = 0;
            this.CST = string.Empty;
            this.CODTRF = string.Empty;
            this.CODTBORCAMENTO = string.Empty;
            this.VALOROPRFM1 = 0;
            this.VALOROPRFM2 = 0;
            this.CANCELADO = string.Empty;
            this.VALORUNTORCAMENTO = 0;
            this.DATAORCAMENTO = DateTime.MinValue;
            this.COMISSAOREPRES = 0;
            this.QTDUNDPEDIDO = 0;
            this.CODFILIAL = 0;
            this.CODLOCAL = string.Empty;
            this.VALORLIQUIDO = 0;
            this.CODVEN1 = string.Empty;
            this.PERCENTCOMISSAO = 0;
            this.CODIGOSERVICO = string.Empty; 
            this.CODMUNSERVICO = string.Empty;
            this.CODETDMUNSERV = string.Empty;
            this.VALORDESCCONDICONALITM = 0;
            this.VALORDESPCONDICIONALITM = 0;
        }
    }
}
