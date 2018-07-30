using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;

namespace Conversor.Core.Objetos
{
    public class MovimentoObjetoM
    {
        public string MarcaInicio { get; set; }
        public int CODFILIAL { get; set; }
        public string CODDEPARTAMENTO { get; set; }
        public string CODLOC { get; set; }
        public string CODLOCENTREGA { get; set; }
        public string CODLOCDESTINO { get; set; }
        public string CODCFO { get; set; }
        public string CODCFONATUREZA { get; set; }
        public string NUMEROMOV { get; set; }
        public string SERIE { get; set; }
        public string CODTMV { get; set; }
        public string TIPO { get; set; }
        public string STATUS { get; set; }
        public int MOVIMPRESSO { get; set; }
        public int DOCIMPRESSO { get; set; }
        public int FATIMPRESSA { get; set; }
        public DateTime DATAEMISSAO { get; set; }
        public DateTime DATASAIDA { get; set; }        
        public DateTime DATAEXTRA1 { get; set; }
        public DateTime DATAEXTRA2 { get; set; }
        public string CODRPR { get; set; }
        public double COMISSAOREPRES { get; set; }
        public string NORDEM { get; set; }
        public string CODCPG { get; set; }
        public int NUMEROTRIBUTOS { get; set; }
        public double VALORBRUTO { get; set; }
        public double VALORLIQUIDO { get; set; }
        public double VALOROUTROS { get; set; }
        public string OBSERVACAO { get; set; }
        public double PERCENTUALFRETE { get; set; }
        public double VALORFRETE { get; set; }
        public double PERCENTUALSEGURO { get; set; }
        public double VALORSEGURO { get; set; }
        public double PERCENTUALDESC { get; set; }
        public double VALORDESC { get; set; }
        public double PERCENTUALDESP { get; set; }
        public double VALORDESP { get; set; }
        public double PERCENTUALEXTRA1 { get; set; }
        public double VALOREXTRA1 { get; set; }
        public double PERCENTUALEXTRA2 { get; set; }
        public double VALOREXTRA2 { get; set; }
        public string CODVEN1 { get; set; }
        public double PERCCOMISSAO { get; set; }
        public string CODMEN { get; set; }
        public string CODMEN2 { get; set; }
        public string VIADETRANSPORTE { get; set; }
        public string PLACA { get; set; }
        public string CODETDPLACA { get; set; }
        public double PESOLIQUIDO { get; set; }
        public double PESOBRUTO { get; set; }
        public string MARCA { get; set; }
        public int NUMERO { get; set; }
        public int QUANTIDADE { get; set; }
        public string ESPECIE { get; set; }
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
        public string CAMPOLIVRE1 { get; set; }
        public string CAMPOLIVRE2 { get; set; }
        public string CAMPOLIVRE3 { get; set; }
        public string CODMOEVALORLIQUIDO { get; set; }
        public DateTime DATABASEMOV { get; set; }
        public DateTime DATAMOVIMENTO { get; set; }
        public int NUMEROLCTGERADO { get; set; }
        public int GEROUFATURA { get; set; }
        public int NUMEROLCTABERTO { get; set; }
        public string CODVEN2 { get; set; }
        public string CODUSUARIO { get; set; }
        public int FLAGEXPORTACAO { get; set; }
        public string EMITEBOLETA { get; set; }
        public string CODMENDESCONTO { get; set; }
        public string CODMENDESPESA { get; set; }
        public string CODMENFRETE { get; set; }
        public int FRETECIFOUFOB { get; set; }
        public int USADESPFINANC { get; set; }
        public int IDNAT { get; set; }
        public int FLAGEXPORFISC { get; set; }
        public int FLAGEXPORFAZENDA { get; set; }
        public string CODVEN3 { get; set; }
        public string CODVEN4 { get; set; }
        public double PERCCOMISSAOVEN2 { get; set; }
        public int IDNAT2 { get; set; }
        public double VALORADIANTAMENTO { get; set; }
        public string CODTRA { get; set; }
        public string CODTRA2 { get; set; }
        public int STATUSLIBERACAO { get; set; }
        public int ITENSAGRUPADOS { get; set; }
        public string FLAGIMPRESSAOFAT { get; set; }
        public DateTime DATACANCELAMENTOMOV { get; set; }
        public string SEGUNDONUMERO { get; set; }
        public string CODCCUSTO { get; set; }
        public int CODCOLCXA { get; set; }
        public string CODCXA { get; set; }
        public int CODFILIALDESTINO { get; set; }
        public string CODCCUSTODESTINO { get; set; }
        public int CODCOLCFO { get; set; }
        public int CODCOLCFONATUREZA { get; set; }
        public int IDMOVLCTFLUXUS { get; set; }
        public DateTime DATAENTREGA { get; set; }
        public int NUMEROCAIXA { get; set; }
        public int NUMEROCUPOM { get; set; }
        public DateTime HORARIOEMISSAO { get; set; }
        public int CODFILIALENTREGA { get; set; }
        public string CODNAT { get; set; }
        public string CODNAT2 { get; set; }
        public string CGCCFO { get; set; }
        public DateTime DATACONTABILIZACAO { get; set; }
        public string CODIGOSERVICO { get; set; }
        public string CODMUNSERVICO { get; set; }
        public string CODETDMUNSERVICO { get; set; }
        public string PONTOVENDA { get; set; }
        public int CODEVENTO { get; set; }
        public string CODTDO { get; set; }
        public string CODIGOIRRF { get; set; }
        public double DEDUCAOIRRF { get; set; }
        public double PERCBASEINSSEMPREGADO { get; set; }
        public double PERCENTBASEINSS { get; set; }
        public string CODPRJ { get; set; }
        public int REVISAO { get; set; }
        public string SUBSERIE { get; set; }
        public int IDCONTATOENTREGA { get; set; }
        public double INSSEMOUTRAEMPRESA { get; set; }
        public int APROPRIADO { get; set; }
        public DateTime DATALANCAMENTO { get; set; }
        public int CRO { get; set; }
        public int COO { get; set; }
        public int NUMEROREDUCAO { get; set; }
        public DateTime HORASAIDA { get; set; }
        public string CODENTREGA { get; set; }
        public string RECIBONFESTATUS { get; set; }
        public int RECIBONFETIPO { get; set; }
        public int RECIBONFESITUACAO { get; set; }
        public string NROAIDF { get; set; }
        public string CHAVEACESSONFE { get; set; }
        public int EXTENPORANEO { get; set; }

        public MovimentoObjetoM ()
        {
            this.MarcaInicio = "M";
            this.CODFILIAL = 0;
            this.CODDEPARTAMENTO = string.Empty;
            this.CODLOC = string.Empty;
            this.CODLOCENTREGA = string.Empty;
            this.CODLOCDESTINO = string.Empty;
            this.CODCFO = string.Empty;
            this.CODCFONATUREZA = string.Empty;
            this.NUMEROMOV = string.Empty;
            this.SERIE = string.Empty;
            this.CODTMV = string.Empty;
            this.TIPO = "S";
            this.STATUS = "A";
            this.MOVIMPRESSO = 0;
            this.DOCIMPRESSO = 0;
            this.FATIMPRESSA = 0;
            this.DATAEMISSAO = DateTime.Now;
            this.DATASAIDA = DateTime.Now;
            this.DATAEXTRA1 = DateTime.Now;
            this.DATAEXTRA2 = DateTime.Now;
            this.CODRPR = string.Empty;
            this.COMISSAOREPRES = 0;
            this.NORDEM = string.Empty;
            this.CODCPG = "C001";
            this.NUMEROTRIBUTOS = 0;
            this.VALORBRUTO = 0;
            this.VALORLIQUIDO = 0;
            this.VALOROUTROS = 0;
            this.OBSERVACAO = string.Empty;
            this.PERCENTUALFRETE = 0;
            this.VALORFRETE = 0;
            this.PERCENTUALSEGURO = 0;
            this.VALORSEGURO = 0;
            this.PERCENTUALDESC = 0;
            this.VALORDESC = 0;
            this.PERCENTUALDESP = 0;
            this.VALORDESP = 0;
            this.PERCENTUALEXTRA1 = 0;
            this.VALOREXTRA1 = 0;
            this.PERCENTUALEXTRA2 = 0;
            this.VALOREXTRA2 = 0;
            this.CODVEN1 = string.Empty;
            this.PERCCOMISSAO = 0;
            this.CODMEN = string.Empty;
            this.CODMEN2 = string.Empty;
            this.VIADETRANSPORTE = string.Empty;
            this.PLACA = string.Empty;
            this.CODETDPLACA = string.Empty;
            this.PESOLIQUIDO = 0;
            this.PESOBRUTO = 0;
            this.MARCA = string.Empty;
            this.NUMERO = 0;
            this.QUANTIDADE = 0;
            this.ESPECIE = string.Empty;
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
            this.CAMPOLIVRE1 = string.Empty;
            this.CAMPOLIVRE2 = string.Empty;
            this.CAMPOLIVRE3 = string.Empty;
            this.CODMOEVALORLIQUIDO = "R$";
            this.DATABASEMOV = DateTime.Now;
            this.DATAMOVIMENTO = DateTime.Now;
            this.NUMEROLCTGERADO = 0;
            this.GEROUFATURA = 0;
            this.NUMEROLCTABERTO = 0;
            this.CODVEN2 = string.Empty;
            this.CODUSUARIO = string.Empty;
            this.FLAGEXPORTACAO = 0;
            this.EMITEBOLETA = string.Empty;
            this.CODMENDESCONTO = string.Empty;
            this.CODMENDESPESA = string.Empty;
            this.CODMENFRETE = string.Empty;
            this.FRETECIFOUFOB = 0;
            this.USADESPFINANC = 0;
            this.IDNAT = 0;
            this.FLAGEXPORFISC = 0;
            this.FLAGEXPORFAZENDA = 0;
            this.CODVEN3 = string.Empty;
            this.CODVEN4 = string.Empty;
            this.PERCCOMISSAOVEN2 = 0;
            this.IDNAT2 = 0;
            this.VALORADIANTAMENTO = 0;
            this.CODTRA = string.Empty;
            this.CODTRA2 = string.Empty;
            this.STATUSLIBERACAO = 0;
            this.ITENSAGRUPADOS = 0;
            this.FLAGIMPRESSAOFAT = string.Empty;
            this.DATACANCELAMENTOMOV = DateTime.MinValue;
            this.SEGUNDONUMERO = string.Empty;
            this.CODCCUSTO = string.Empty;
            this.CODCOLCXA = 0;
            this.CODCXA = string.Empty;
            this.CODFILIALDESTINO = 0;
            this.CODCCUSTODESTINO = string.Empty;
            this.CODCOLCFO = 0;
            this.CODCOLCFONATUREZA = 0;
            this.IDMOVLCTFLUXUS = 0;
            this.DATAENTREGA = DateTime.Now;
            this.NUMEROCAIXA = 0;
            this.NUMEROCUPOM = 0;
            this.HORARIOEMISSAO = DateTime.Now;
            this.CODFILIALENTREGA = 0;
            this.CODNAT = string.Empty;
            this.CODNAT2 = string.Empty;
            this.CGCCFO = string.Empty;
            this.DATACONTABILIZACAO = DateTime.MinValue;
            this.CODIGOSERVICO = string.Empty;
            this.CODMUNSERVICO = string.Empty;
            this.CODETDMUNSERVICO = string.Empty;
            this.PONTOVENDA = string.Empty;
            this.CODEVENTO = 0;
            this.CODTDO = "001";
            this.CODIGOIRRF = string.Empty;
            this.DEDUCAOIRRF = 0;
            this.PERCBASEINSSEMPREGADO = 0;
            this.PERCENTBASEINSS = 0;
            this.CODPRJ = string.Empty;
            this.REVISAO = 0;
            this.SUBSERIE = string.Empty;
            this.IDCONTATOENTREGA = 0;
            this.INSSEMOUTRAEMPRESA = 0;
            this.APROPRIADO = 0;
            this.DATALANCAMENTO = DateTime.Now;
            this.CRO = 0;
            this.COO = 0;
            this.NUMEROREDUCAO = 0;
            this.HORASAIDA = DateTime.MinValue;
            this.CODENTREGA = string.Empty;
            this.RECIBONFESTATUS = string.Empty;
            this.RECIBONFETIPO = 0;
            this.RECIBONFESITUACAO = 0;
            this.NROAIDF = string.Empty;
            this.CHAVEACESSONFE = string.Empty;
            this.EXTENPORANEO = 0;
        }
    }
}