using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Conversor.Core.Objetos;
using System.IO;

namespace Conversor.Core
{
    public class MovimentoGeradorLinhas
    {        
        private StringBuilder sb;

        public MovimentoGeradorLinhas ()
        {
            this.sb = new StringBuilder();
        }    
        
        public void montaLinhaM(MovimentoObjetoM linhaM)
        {            
            sb.Append(linhaM.MarcaInicio.PadRight(1));
            sb.Append(linhaM.CODFILIAL.ToString().PadLeft(5,'0'));
            sb.Append(linhaM.CODDEPARTAMENTO.PadRight(30));
            sb.Append(linhaM.CODLOC.PadRight(15));
            sb.Append(linhaM.CODLOCENTREGA.PadRight(15));
            sb.Append(linhaM.CODLOCDESTINO.PadRight(15));
            sb.Append(linhaM.CODCFO.PadRight(25));
            sb.Append(linhaM.CODCFONATUREZA.PadRight(25));
            sb.Append(linhaM.NUMEROMOV.PadRight(35));
            sb.Append(linhaM.SERIE.PadRight(8));
            sb.Append(linhaM.CODTMV.PadRight(10));
            sb.Append(linhaM.TIPO.PadRight(1));
            sb.Append(linhaM.STATUS.PadRight(1));
            sb.Append(linhaM.MOVIMPRESSO.ToString().PadLeft(1,'0'));
            sb.Append(linhaM.DOCIMPRESSO.ToString().PadLeft(1,'0'));
            sb.Append(linhaM.FATIMPRESSA.ToString().PadLeft(1,'0'));
            sb.Append(linhaM.DATAEMISSAO.ToString("dd/MM/yyyy"));
            sb.Append(linhaM.DATASAIDA.ToString("dd/MM/yyyy"));
            sb.Append(linhaM.DATAEXTRA1.ToString("dd/MM/yyyy"));
            sb.Append(linhaM.DATAEXTRA2.ToString("dd/MM/yyyy"));
            sb.Append(linhaM.CODRPR.PadRight(15));
            sb.Append(linhaM.COMISSAOREPRES.ToString().PadLeft(20,'0'));
            sb.Append(linhaM.NORDEM.PadRight(20));
            sb.Append(linhaM.CODCPG.PadRight(5));
            sb.Append(linhaM.NUMEROTRIBUTOS.ToString().PadLeft(5,'0'));
            sb.Append(linhaM.VALORBRUTO.ToString(@"00000000000000000.00").Replace(',', '.'));
            sb.Append(linhaM.VALORLIQUIDO.ToString(@"00000000000000000.00").Replace(',', '.'));
            sb.Append(linhaM.VALOROUTROS.ToString(@"00000000000000000.00").Replace(',', '.'));
            sb.Append(linhaM.OBSERVACAO.PadRight(60));
            sb.Append(linhaM.PERCENTUALFRETE.ToString(@"00000000000000000.00").Replace(',', '.'));
            sb.Append(linhaM.VALORFRETE.ToString(@"00000000000000000.00").Replace(',', '.'));
            sb.Append(linhaM.PERCENTUALSEGURO.ToString(@"00000000000000000.00").Replace(',', '.'));
            sb.Append(linhaM.VALORSEGURO.ToString(@"00000000000000000.00").Replace(',', '.'));
            sb.Append(linhaM.PERCENTUALDESC.ToString(@"00000000000000000.00").Replace(',', '.'));
            sb.Append(linhaM.VALORDESC.ToString(@"00000000000000000.00").Replace(',', '.'));
            sb.Append(linhaM.PERCENTUALDESP.ToString(@"00000000000000000.00").Replace(',', '.'));
            sb.Append(linhaM.VALORDESP.ToString(@"00000000000000000.00").Replace(',', '.'));
            sb.Append(linhaM.PERCENTUALEXTRA1.ToString(@"00000000000000000.00").Replace(',', '.'));
            sb.Append(linhaM.VALOREXTRA1.ToString(@"00000000000000000.00").Replace(',', '.'));
            sb.Append(linhaM.PERCENTUALEXTRA2.ToString(@"00000000000000000.00").Replace(',', '.'));
            sb.Append(linhaM.VALOREXTRA2.ToString(@"00000000000000000.00").Replace(',', '.'));
            sb.Append(linhaM.CODVEN1.PadRight(16));
            sb.Append(linhaM.PERCCOMISSAO.ToString(@"00000000000000000.00").Replace(',', '.'));
            sb.Append(linhaM.CODMEN.PadRight(5));
            sb.Append(linhaM.CODMEN2.PadRight(5));
            sb.Append(linhaM.VIADETRANSPORTE.PadRight(15));
            sb.Append(linhaM.PLACA.PadRight(10));
            sb.Append(linhaM.CODETDPLACA.PadRight(2));
            sb.Append(linhaM.PESOLIQUIDO.ToString(@"00000000000000000.00").Replace(',', '.'));
            sb.Append(linhaM.PESOBRUTO.ToString(@"00000000000000000.00").Replace(',', '.'));
            sb.Append(linhaM.MARCA.PadRight(10));
            sb.Append(linhaM.NUMERO.ToString().PadLeft(10, '0'));
            sb.Append(linhaM.QUANTIDADE.ToString().PadLeft(10, '0'));
            sb.Append(linhaM.ESPECIE.PadRight(15));
            sb.Append(linhaM.CODTB1FAT.PadRight(10));
            sb.Append(linhaM.CODTB2FAT.PadRight(10));
            sb.Append(linhaM.CODTB3FAT.PadRight(10));
            sb.Append(linhaM.CODTB4FAT.PadRight(10));
            sb.Append(linhaM.CODTB5FAT.PadRight(10));
            sb.Append(linhaM.CODTB1FLX.PadRight(25));
            sb.Append(linhaM.CODTB2FLX.PadRight(25));
            sb.Append(linhaM.CODTB3FLX.PadRight(25));
            sb.Append(linhaM.CODTB4FLX.PadRight(25));
            sb.Append(linhaM.CODTB5FLX.PadRight(25));
            sb.Append(linhaM.CAMPOLIVRE1.PadRight(100));
            sb.Append(linhaM.CAMPOLIVRE2.PadRight(100));
            sb.Append(linhaM.CAMPOLIVRE3.PadRight(100));
            sb.Append(linhaM.CODMOEVALORLIQUIDO.PadRight(10));
            sb.Append(linhaM.DATABASEMOV.ToString("dd/MM/yyyy"));
            sb.Append(linhaM.DATAMOVIMENTO.ToString("dd/MM/yyyy"));
            sb.Append(linhaM.NUMEROLCTGERADO.ToString().PadLeft(5,'0'));
            sb.Append(linhaM.GEROUFATURA.ToString().PadLeft(5, '0'));
            sb.Append(linhaM.NUMEROLCTABERTO.ToString().PadLeft(5, '0'));
            sb.Append(linhaM.CODVEN2.PadRight(16));
            sb.Append(linhaM.CODUSUARIO.PadRight(20));
            sb.Append(linhaM.FLAGEXPORTACAO.ToString().PadLeft(5,'0'));
            sb.Append(linhaM.EMITEBOLETA.PadRight(1));
            sb.Append(linhaM.CODMENDESCONTO.PadRight(5));
            sb.Append(linhaM.CODMENDESPESA.PadRight(5));
            sb.Append(linhaM.CODMENFRETE.PadRight(5));
            sb.Append(linhaM.FRETECIFOUFOB.ToString().PadLeft(5,'0'));
            sb.Append(linhaM.USADESPFINANC.ToString().PadLeft(5,'0'));
            sb.Append(linhaM.IDNAT.ToString().PadLeft(5, '0'));
            sb.Append(linhaM.FLAGEXPORFISC.ToString().PadLeft(5,'0'));
            sb.Append(linhaM.FLAGEXPORFAZENDA.ToString().PadLeft(5,'0'));
            sb.Append(linhaM.CODVEN3.PadRight(16));
            sb.Append(linhaM.CODVEN4.PadRight(16));
            sb.Append(linhaM.PERCCOMISSAOVEN2.ToString(@"00000000000000000.00").Replace(',', '.'));
            sb.Append(linhaM.IDNAT2.ToString().PadLeft(5,'0'));
            sb.Append(linhaM.VALORADIANTAMENTO.ToString(@"00000000000000000.00").Replace(',', '.'));
            sb.Append(linhaM.CODTRA.PadRight(5));
            sb.Append(linhaM.CODTRA2.PadRight(5));
            sb.Append(linhaM.STATUSLIBERACAO.ToString().PadLeft(5,'0'));
            sb.Append(linhaM.ITENSAGRUPADOS.ToString().PadLeft(5,'0'));
            sb.Append(linhaM.FLAGIMPRESSAOFAT.PadRight(1));
            sb.Append(linhaM.DATACANCELAMENTOMOV == DateTime.MinValue ? string.Empty.PadRight(10) : linhaM.DATACANCELAMENTOMOV.ToString("dd/MM/yyyy"));
            sb.Append(linhaM.SEGUNDONUMERO.PadRight(20));
            sb.Append(linhaM.CODCCUSTO.PadRight(25));
            sb.Append(linhaM.CODCOLCXA.ToString().PadLeft(5,'0'));
            sb.Append(linhaM.CODCXA.PadRight(10));
            sb.Append(linhaM.CODFILIALDESTINO.ToString().PadLeft(5,'0'));
            sb.Append(linhaM.CODCCUSTODESTINO.PadRight(25));
            sb.Append(linhaM.CODCOLCFO.ToString().PadLeft(5,'0'));
            sb.Append(linhaM.CODCOLCFONATUREZA.ToString().PadLeft(5,'0'));
            sb.Append(linhaM.IDMOVLCTFLUXUS.ToString().PadLeft(10,'0'));
            sb.Append(linhaM.DATAENTREGA.ToString("dd/MM/yyyy"));
            sb.Append(linhaM.NUMEROCAIXA.ToString().PadLeft(10,'0'));
            sb.Append(linhaM.NUMEROCUPOM.ToString().PadLeft(10,'0'));
            sb.Append(linhaM.HORARIOEMISSAO.ToString("hh:mm:ss").PadRight(20));
            sb.Append(linhaM.CODFILIALENTREGA.ToString().PadLeft(5,'0'));
            sb.Append(linhaM.CODNAT.PadRight(20));
            sb.Append(linhaM.CODNAT2.PadRight(20));
            sb.Append(linhaM.CGCCFO.PadRight(20));
            sb.Append(linhaM.DATACONTABILIZACAO == DateTime.MinValue ? string.Empty.PadRight(10) : linhaM.DATACONTABILIZACAO.ToString("dd/MM/yyyy"));
            sb.Append(linhaM.CODIGOSERVICO.PadRight(15));
            sb.Append(linhaM.CODMUNSERVICO.PadRight(20));
            sb.Append(linhaM.CODETDMUNSERVICO.PadRight(2));
            sb.Append(linhaM.PONTOVENDA.PadRight(10));
            sb.Append(linhaM.CODEVENTO == 0? string.Empty.PadRight(10) : linhaM.CODEVENTO.ToString().PadLeft(10,'0'));
            sb.Append(linhaM.CODTDO.PadRight(10));
            sb.Append(linhaM.CODIGOIRRF.PadRight(10));
            sb.Append(linhaM.DEDUCAOIRRF.ToString(@"00000000000000000.00").Replace(',', '.'));
            sb.Append(linhaM.PERCBASEINSSEMPREGADO.ToString(@"00000000000000000.00").Replace(',', '.'));
            sb.Append(linhaM.PERCENTBASEINSS.ToString(@"00000000000000000.00").Replace(',', '.'));
            sb.Append(linhaM.CODPRJ.PadRight(24));
            sb.Append(linhaM.REVISAO.ToString().PadLeft(5,'0'));
            sb.Append(linhaM.SUBSERIE.PadRight(8));
            sb.Append(linhaM.IDCONTATOENTREGA > 0 ? linhaM.IDCONTATOENTREGA.ToString().PadLeft(10,'0') : string.Empty.PadRight(10));
            sb.Append(linhaM.INSSEMOUTRAEMPRESA.ToString(@"00000000000000000.00").Replace(',', '.'));
            sb.Append(linhaM.APROPRIADO.ToString().PadLeft(5,'0'));
            sb.Append(linhaM.DATALANCAMENTO.ToString("dd/MM/yyyy"));
            sb.Append(linhaM.CRO.ToString().PadLeft(10,'0'));
            sb.Append(linhaM.COO.ToString().PadLeft(10,'0'));
            sb.Append(linhaM.NUMEROREDUCAO.ToString().PadLeft(10,'0'));
            sb.Append(linhaM.HORASAIDA.ToString("hh:mm:ss").PadRight(20));
            sb.Append(linhaM.CODENTREGA.PadRight(15));
            sb.Append(linhaM.RECIBONFESTATUS.PadRight(1));
            sb.Append(linhaM.RECIBONFETIPO.ToString().PadLeft(5,'0'));
            sb.Append(linhaM.RECIBONFESITUACAO.ToString().PadLeft(5,'0'));
            sb.Append(linhaM.NROAIDF.PadRight(30));
            sb.Append(linhaM.CHAVEACESSONFE.PadRight(44));
            sb.Append(linhaM.EXTENPORANEO.ToString().PadLeft(5,'0'));            
            sb.AppendLine();
        }

        public void montaLinhaT(MovimentoObjetoT linhaT)
        {            
            sb.Append(linhaT.MarcaInicio.PadRight(1));
            sb.Append(linhaT.NUMEROSEQUENCIAL.ToString().PadLeft(5,'0'));
            sb.Append(linhaT.CODTRB.PadRight(10));
            sb.Append(linhaT.BASEDECALCULO.ToString(@"00000000000000000.00").Replace(',', '.'));
            sb.Append(linhaT.ALIQUOTA.ToString(@"00000000000000000.00").Replace(',', '.'));
            sb.Append(linhaT.VALOR.ToString(@"00000000000000000.00").Replace(',', '.'));
            sb.Append(linhaT.FATORREDUCAO.ToString(@"00000000000000000.00").Replace(',', '.'));
            sb.Append(linhaT.FATORSUBSTTRIBU.ToString(@"00000000000000000.00").Replace(',', '.'));
            sb.Append(linhaT.VLRISENTO.ToString(@"00000000000000000.00").Replace(',', '.'));
            sb.Append(linhaT.CODRETENCAO.PadRight(5));
            sb.Append(linhaT.TIPORECOLHIMENTO.PadRight(5));
            sb.Append(linhaT.CODTRBBASE.PadRight(10));
            sb.Append(linhaT.BASEDECALCULOCALCULADA.ToString(@"00000000000000000.00").Replace(',', '.'));
            sb.Append(linhaT.EDITADO.ToString().PadLeft(5, '0'));
            sb.Append(linhaT.MODALIDADEBC.PadRight(1));
            sb.Append(linhaT.SITTRIBUTARIA.PadRight(2));
            sb.AppendLine();
        }

        public void montaLinhaI(MovimentoObjetoI linhaI)
        {            
            sb.Append(linhaI.MarcaInicio.PadRight(1));
            sb.Append(linhaI.CODIGOPRD.PadRight(30));
            sb.Append(linhaI.NUMEROSEQUENCIAL.ToString().PadLeft(5,'0'));
            sb.Append(linhaI.CODTIP.PadRight(10));
            sb.Append(linhaI.QUANTIDADE.ToString(@"00000000000000000.00").Replace(',', '.'));
            sb.Append(linhaI.PRECOUNITARIO.ToString(@"00000000000000000.00").Replace(',', '.'));
            sb.Append(linhaI.PRECOTABELA.ToString(@"00000000000000000.00").Replace(',', '.'));
            sb.Append(linhaI.PERCENTUALDESC.ToString(@"00000000000000000.00").Replace(',', '.'));
            sb.Append(linhaI.VALORDESC.ToString(@"00000000000000000.00").Replace(',', '.'));
            sb.Append(linhaI.PERCENTUALDESP.ToString(@"00000000000000000.00").Replace(',', '.'));
            sb.Append(linhaI.VALORDESP.ToString(@"00000000000000000.00").Replace(',', '.'));
            sb.Append(linhaI.DATAEMISSAO == DateTime.MinValue ? string.Empty.PadRight(10) : linhaI.DATAEMISSAO.ToString("dd/MM/yyyy"));
            sb.Append(linhaI.CODMEN.PadRight(5));
            sb.Append(linhaI.NUMEROTRIBUTOS.ToString().PadLeft(5, '0'));
            sb.Append(linhaI.CODTB1FAT.PadRight(10));
            sb.Append(linhaI.CODTB2FAT.PadRight(10));
            sb.Append(linhaI.CODTB3FAT.PadRight(10));
            sb.Append(linhaI.CODTB4FAT.PadRight(10));
            sb.Append(linhaI.CODTB5FAT.PadRight(10));
            sb.Append(linhaI.CODTB1FLX.PadRight(25));
            sb.Append(linhaI.CODTB2FLX.PadRight(25));
            sb.Append(linhaI.CODTB3FLX.PadRight(25));
            sb.Append(linhaI.CODTB4FLX.PadRight(25));
            sb.Append(linhaI.CODTB5FLX.PadRight(25));
            sb.Append(linhaI.CAMPOLIVRE.PadRight(15));
            sb.Append(linhaI.CODUND.PadRight(5));
            sb.Append(linhaI.QUANTIDADEARECEBER.ToString(@"00000000000000000.00").Replace(',', '.'));
            sb.Append(linhaI.IDNAT.ToString().PadLeft(5, '0'));
            sb.Append(linhaI.CODCPG.PadRight(5));
            sb.Append(linhaI.DATAENTREGA == DateTime.MinValue ? string.Empty.PadRight(10) : linhaI.DATAENTREGA.ToString("dd/MM/yyyy"));
            sb.Append(linhaI.PRATELEIRA.PadRight(15));            
            sb.Append(linhaI.IDCNT == 0 ? string.Empty.PadRight(10) : linhaI.IDCNT.ToString().PadLeft(10,'0'));
            sb.Append(linhaI.NSEQITMCNT.ToString().PadLeft(5, '0'));
            sb.Append(linhaI.VALORTOTALITEM.ToString(@"00000000000000000.00").Replace(',', '.'));
            sb.Append(linhaI.CODCCUSTO.PadRight(25));
            sb.Append(linhaI.CODNAT.PadRight(20));
            sb.Append(linhaI.CODRPR.PadRight(15));
            sb.Append(linhaI.IDPRDCOMPOSTO.PadRight(30));
            sb.Append(linhaI.CODDEPARTAMENTO.PadRight(25));
            sb.Append(linhaI.TRIBUTACAOECF.PadRight(10));
            sb.Append(linhaI.VALORESCRITURACAO.ToString(@"00000000000000000.00").Replace(',', '.'));
            sb.Append(linhaI.VALORCODIGOPRD.PadRight(60));
            sb.Append(linhaI.TIPOCODIGOPRD.ToString().PadLeft(5, '0'));
            sb.Append(linhaI.CST.PadRight(3));
            sb.Append(linhaI.CODTRF.PadRight(60));
            sb.Append(linhaI.CODTBORCAMENTO.PadRight(40));
            sb.Append(linhaI.VALOROPRFM1.ToString(@"00000000000000000.00").Replace(',', '.'));
            sb.Append(linhaI.VALOROPRFM2.ToString(@"00000000000000000.00").Replace(',', '.'));
            sb.Append(linhaI.CANCELADO.PadRight(1));
            sb.Append(linhaI.VALORUNTORCAMENTO.ToString(@"00000000000000000.00").Replace(',', '.'));
            sb.Append(linhaI.DATAORCAMENTO == DateTime.MinValue ? string.Empty.PadRight(10) : linhaI.DATAORCAMENTO.ToString("dd/MM/yyyy"));
            sb.Append(linhaI.COMISSAOREPRES.ToString(@"00000000000000000.00").Replace(',', '.'));
            sb.Append(linhaI.QTDUNDPEDIDO.ToString(@"00000000000000000.00").Replace(',', '.'));
            sb.Append(linhaI.CODFILIAL.ToString().PadLeft(5, '0'));
            sb.Append(linhaI.CODLOCAL.PadRight(15));
            sb.Append(linhaI.VALORLIQUIDO.ToString(@"00000000000000000.00").Replace(',', '.'));
            sb.Append(linhaI.CODVEN1.PadRight(16));
            sb.Append(linhaI.PERCENTCOMISSAO.ToString(@"00000000000000000.00").Replace(',', '.'));
            sb.Append(linhaI.CODIGOSERVICO.PadRight(15));
            sb.Append(linhaI.CODMUNSERVICO.PadRight(20));
            sb.Append(linhaI.CODETDMUNSERV.PadRight(2));
            sb.Append(linhaI.VALORDESCCONDICONALITM.ToString(@"00000000000000000.00").Replace(',', '.'));
            sb.Append(linhaI.VALORDESPCONDICIONALITM.ToString(@"00000000000000000.00").Replace(',', '.'));

            sb.AppendLine();
        }

        public void montaLinhaH(MovimentoObjetoH linhaH)
        {            
            sb.Append(linhaH.MarcaInicio.PadRight(1));
            sb.Append(linhaH.HISTORICO.PadRight(255));
            sb.AppendLine();
        }

        public void geraArquivo(string nomeArquivo, string pathArquivo)
        {
            sb.Length = sb.Length - 2;
            salvarArquivo(nomeArquivo, pathArquivo, sb.ToString());
        }
        
        private void salvarArquivo(string nomeArquivo, string pathArquivo, string dados)
        {
            /*Salva o arquivo.*/
            string nomeArq = nomeArquivo;
            string pathArq = pathArquivo;

            string pathComp = pathArq + ".txt";

            try
            {
                //Se o arquivo existir
                if (File.Exists(pathComp))
                {
                    File.Delete(pathComp);
                }

                StreamWriter sw = File.AppendText(pathComp);
                sw.WriteLine(dados);
                sw.Close();
            }
            catch (Exception e)
            {
                
            }

             
        }
    }
}
