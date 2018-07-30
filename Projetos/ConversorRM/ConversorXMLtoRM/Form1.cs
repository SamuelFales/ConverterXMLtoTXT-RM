using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using Conversor.Core.Objetos;
using Conversor.Core;
using System.Collections;
using System.Xml.Serialization;

namespace ConversorXMLtoRM
{
    public partial class Form1 : Form
    {
        List<Nota> notas = new List<Nota>();
        string nomeArquivo = string.Empty;
        int contador = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCarregarArquivo_Click(object sender, EventArgs e)
        {
            //define as propriedades do controle 
            //OpenFileDialog
            this.ofd1.Multiselect = true;
            this.ofd1.Title = "Selecionar Arquivo XML";
            ofd1.InitialDirectory = @"C:\";
            //filtra para exibir somente arquivos de imagens
            ofd1.Filter = "XML files (*.xml)|*.xml";
            ofd1.CheckFileExists = true;
            ofd1.CheckPathExists = true;
            ofd1.FilterIndex = 2;
            ofd1.RestoreDirectory = true;
            ofd1.ReadOnlyChecked = true;
            ofd1.ShowReadOnly = true;

            Nota nota;
            string numero = null; 
            string serie = null;
            DateTime? dataEmissao = null; 
            string valorServico = null;
            string valorISS = null;
            int? aliquota = null;
            bool pegarProximoNo = false;
            bool identificacaoNfse = false;
            string nomeNoXML = string.Empty;


            Hashtable hashNfse = new Hashtable();
            
            
            hashNfse.Add("Serie", "Serie");
            hashNfse.Add("DataEmissao", "DataEmissao");
            hashNfse.Add("ValorServicos", "ValorServicos");
            hashNfse.Add("ValorIss", "ValorIss");
            hashNfse.Add("Aliquota", "Aliquota");

            DialogResult dr = this.ofd1.ShowDialog();

            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                // Le os arquivos selecionados 
                foreach (String arquivo in ofd1.FileNames)
                {
                    contador = 1;
                    notas.Clear();
                    txtArquivo.Text = arquivo;
                    try
                    {

                        XmlTextReader reader = new XmlTextReader(txtArquivo.Text);
                        
                        while (reader.Read())
                        {
                            if (pegarProximoNo)
                            {

                                switch (nomeNoXML)
                                {
                                    case "Numero":
                                        numero = reader.Value;
                                        break;
                                    case "Serie":
                                        serie = reader.Value;
                                        break;
                                    case "DataEmissao":
                                        dataEmissao = Convert.ToDateTime(reader.Value);
                                        break;
                                    case "ValorServicos":
                                        valorServico = reader.Value;
                                        break;
                                    case "ValorIss":
                                        valorISS = reader.Value;
                                        break;
                                    case "Aliquota":
                                        aliquota = Convert.ToInt32(reader.Value);
                                        break;
                                    default:
                                        break;
                                }
                            }


                            if (reader.NodeType == XmlNodeType.Element && reader.Name == "IdentificacaoNfse")
                                identificacaoNfse = true;
                            
                            if (reader.NodeType == XmlNodeType.EndElement && reader.Name == "IdentificacaoNfse")
                                identificacaoNfse = false;
                        

                            if (reader.NodeType == XmlNodeType.Element && hashNfse.ContainsValue(reader.Name))
                            {
                                pegarProximoNo = true;
                                nomeNoXML = reader.Name.ToString();

                            }
                            else if (reader.NodeType == XmlNodeType.Element && reader.Name == "Numero" && identificacaoNfse)
                            {
                                pegarProximoNo = true;
                                nomeNoXML = reader.Name.ToString();
                            }
                            else
                                pegarProximoNo = false;



                            if (reader.NodeType == XmlNodeType.EndElement && reader.Name == "Nfse")
                            {
                                nota = new Nota();
                                nota.Contador = contador++;
                                nota.Numero = numero;
                                nota.Serie = serie;
                                nota.DataEmissao = dataEmissao;
                                nota.ValorServico = valorServico;
                                nota.ValorISS = valorISS;
                                nota.Aliquota = aliquota;

                                notas.Add(nota);
                            }

                        }

                        gbNotasImportacao.Visible = true;
                        dgvDados.DataSource = null;
                        dgvDados.DataSource = notas;
                        label1.Visible = true;
                        label2.Visible = true;
                        label3.Visible = true;
                        label4.Visible = true;
                        btnGerarTXT.Visible = true;
                        
                        
                    }
                    catch (Exception ex)
                    {
                        // Não pode carregar a imagem (problemas de permissão)
                        MessageBox.Show("Não é possível carregar o arquivo." 
                                                   + " Ele pode estar corrompido.\n\nErro reportado : " + ex.Message);
                    }
                }
            }
        }
    
    

        //private void MontarObjetos(List<Nota> notas)
        //{
            
        //    MovimentoGeradorLinhas gerador = new MovimentoGeradorLinhas();
        //    string nomeArquivo = "arquivo_NFse_" + DateTime.Now.TimeOfDay.TotalMilliseconds.ToString();
        //    nomeArquivo = nomeArquivo.Replace(",","");

        //    foreach (var nota in notas)
        //    {
        //        MovimentoObjetoM objM = new MovimentoObjetoM();
        //        objM.CODCFO = nota.Numero;
        //        gerador.montaLinhaM(objM);
        //    }

        //    gerador.geraArquivo(nomeArquivo, "C:\\Users\\Samuel\\Documents");
            
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            nomeArquivo = "arquivo_NFse_" + DateTime.Now.TimeOfDay.TotalMilliseconds.ToString();
            nomeArquivo = nomeArquivo.Replace(",", "");


            sfd1.FileName = nomeArquivo;
            sfd1.ShowDialog();
            
        }

        private void sfd1_FileOk(object sender, CancelEventArgs e)
        {

            try
            {
            MovimentoGeradorLinhas gerador = new MovimentoGeradorLinhas();
            foreach (var nota in notas)
            {
                MovimentoObjetoM objM = new MovimentoObjetoM();
                objM.CODCFO = nota.Numero;
                gerador.montaLinhaM(objM);
            }

            gerador.geraArquivo(nomeArquivo, sfd1.FileName);

            MessageBox.Show("Arquivo gerado com sucesso."
                               + nomeArquivo + ".txt ");


            }
             catch (Exception ex)
            {
                MessageBox.Show("Não é possível gerar o arquivo."
                                       + " Verifique as permissões de acesso a pasta... " + ex.Message);
            
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Sobre sobre = new Sobre();
            sobre.Show();
        }
    }
}
