 
// Type: Aptusoft.FacturaElectronica.frmEnviosSII
 
 
// version 1.8.0

using Aptusoft;
using Aptusoft.FacturaElectronica.Clases;
using Aptusoft.FacturaElectronica.Clases.EnviosSII;
using Aptusoft.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;
using MySql.Data.MySqlClient;
using System.Data.Common;
using System.Data;

namespace Aptusoft.FacturaElectronica
{
    public class frmEnviosSII : Form
    {
        private List<Venta> _listaDTEEnviar = new List<Venta>();
        private string _envioOLibro = "";
        private IContainer components = (IContainer)null;
        private static EmisorVO _emi;
        private static char _ambiente;
        private static RespuestaToken _token;
        private static string _rutaArchivo;
        private TabControl tabControlConsulta;
        private TabPage tabPage1;
        private DataGridView dgvRespuesta;
        private DataGridViewTextBoxColumn Tipo_Docto;
        private DataGridViewTextBoxColumn Informados;
        private DataGridViewTextBoxColumn Aceptados;
        private DataGridViewTextBoxColumn Rechazados;
        private DataGridViewTextBoxColumn Reparos;
        private Panel panelConsulta;
        private Label label2;
        private Panel panel3;
        private TextBox txtEstado;
        private TextBox txtTrackId;
        private TextBox txtGlosa;
        private Label label5;
        private Label label4;
        private Button btnConsultaEnvio;
        private Panel panel1;
        private TextBox txtErrCode;
        private TextBox txtSvrCode;
        private Label label6;
        private TextBox txtSQLCode;
        private Label label7;
        private Label label8;
        private TabPage tabPage2;
        private Panel panel2;
        private TextBox txtNumAtencionConsultaDte;
        private TextBox txtErrCodeConsultaDte;
        private TextBox txtEstadoConsultaDte;
        private Label label17;
        private Label label15;
        private Label label13;
        private Button btnConsultarDte;
        private TextBox txtTotal;
        private TextBox txtFolioDte;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Button btnSalir;
        private Button btnEnviarDocumento;
        private Panel pnlEnvioNOOK;
        private Panel pnlSemillaNOOK;
        private Panel pnlEnvioOK;
        private Label label1;
        private Panel pnlSemillaOK;
        private Label label3;
        private Panel panel4;
        private TextBox txtFechaDte;
        private ComboBox cmbDocumentos;
        private Button btnBuscaDte;
        private Label label14;
        private TextBox txtRazonSocial;
        private TextBox txtRutCliente;
        private ToolTip toolTip1;
        private TextBox txtArchivo;
        private Label label16;
        private Label lblConectando;
        private Button button1;
        private Label lblmos;
        private Label lblServidor;

        public frmEnviosSII()
        {
            this.InitializeComponent();
            this.cargaDatosEmisor();
            this.cargaDocumentos();
            this.btnEnviarDocumento.Enabled = false;
            this.iniciaConsultaEnvio();
            this.iniciaConsultaDte();
            this.lblConectando.Visible = false;
            this.txtTrackId.Enabled = true;
        }

        public frmEnviosSII(string archivo, string ruta, List<Venta> listaEnviar, string envioOlibro)
        {
            this.InitializeComponent();
            this.cargaDatosEmisor();
            this.cargaDocumentos();
            this.iniciaFormulario();
            this.txtArchivo.Text = archivo;
            frmEnviosSII._rutaArchivo = ruta;
            this.lblConectando.Visible = false;
            this._listaDTEEnviar.Clear();
            this._listaDTEEnviar = listaEnviar;
            this._envioOLibro = envioOlibro;
        }

        private void cargaDatosEmisor()
        {
            frmEnviosSII._emi = new Emisor().buscaEmisor();
            if (frmEnviosSII._emi.Simulacion)
            {
                frmEnviosSII._ambiente = 'M';
                this.lblServidor.Text = "SERVIDOR DE CERTIFICACION";
            }
            else
            {
                frmEnviosSII._ambiente = 'P';
                this.lblServidor.Text = "SERVIDOR DE PRODUCCION";
            }
        }

        private void cargaDocumentos()
        {
            this.cmbDocumentos.DataSource = (object)new CargaMaestrosElectronica().listaDocumentosVenta();
            this.cmbDocumentos.ValueMember = "Numero";
            this.cmbDocumentos.DisplayMember = "Nombre";
            this.cmbDocumentos.SelectedValue = (object)33;
        }

        private void iniciaFormulario()
        {
            this.btnConsultarDte.Visible = true;
            this.pnlEnvioOK.Visible = false;
            this.pnlSemillaOK.Visible = false;
            this.pnlEnvioNOOK.Visible = false;
            this.pnlSemillaNOOK.Visible = false;
            this.tabControlConsulta.Enabled = false;
            this.iniciaConsultaEnvio();
            this.iniciaConsultaDte();
            this.txtArchivo.Clear();
            this.lblConectando.Visible = true;
        }

        private void iniciaConsultaEnvio()
        {
            this.txtTrackId.Clear();
            this.txtTrackId.Enabled = true;
            this.txtEstado.Clear();
            this.txtGlosa.Clear();
            this.txtErrCode.Clear();
            this.txtSQLCode.Clear();
            this.txtSvrCode.Clear();
        }

        private void iniciaConsultaDte()
        {
            this.btnConsultarDte.Enabled = true;
            this.txtFolioDte.Clear();
            this.txtRutCliente.Clear();
            this.txtRazonSocial.Clear();
            this.txtFechaDte.Clear();
            this.txtTotal.Clear();
            this.txtEstadoConsultaDte.Clear();
            this.txtErrCodeConsultaDte.Clear();
            this.txtNumAtencionConsultaDte.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool solicitarToken()
        {
            try
            {
                frmEnviosSII._token = Token.SolicitarToken(frmEnviosSII._ambiente, frmEnviosSII._emi.CertificadoDigital);
                this.pnlSemillaOK.Visible = true;
                return true;
            }
            catch (Exception ex)
            {
                int num = (int)MessageBox.Show("Error al Autenticar en SII " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.pnlSemillaNOOK.Visible = true;
                return false;
            }
        }

        private void btnEnviarDocumento_Click(object sender, EventArgs e)
        {
            this.btnEnviarDocumento.Enabled = false;
            this.lblConectando.Visible = true;
            this.Refresh();
            if (this.solicitarToken())
            {
                Upload upload = new Upload();
                string rutCertificado = frmEnviosSII._emi.RutCertificado;
                string rutEmisior = frmEnviosSII._emi.RutEmisior;
                string text = this.txtArchivo.Text;
                string uri = frmEnviosSII._rutaArchivo + this.txtArchivo.Text;
                try
                {
                    string xml = upload.CreaUpload(frmEnviosSII._ambiente, rutCertificado, rutEmisior, text, uri, frmEnviosSII._token.Token);
                    XmlDocument xmlDocument = new XmlDocument();
                    xmlDocument.LoadXml(xml);
                    if (xmlDocument != null)
                    {
                        RespuestaEnvioSII respuestaEnvioSii = new RespuestaEnvioSII();
                        respuestaEnvioSii.RutSender = xmlDocument.SelectNodes("//RUTSENDER").Item(0).InnerXml;
                        respuestaEnvioSii.RutCompany = xmlDocument.SelectNodes("//RUTCOMPANY").Item(0).InnerXml;
                        respuestaEnvioSii.File = xmlDocument.SelectNodes("//FILE").Item(0).InnerXml;
                        respuestaEnvioSii.TimeStamp = xmlDocument.SelectSingleNode("//TIMESTAMP") == null ? "" : xmlDocument.SelectNodes("//TIMESTAMP").Item(0).InnerXml;
                        respuestaEnvioSii.Status = xmlDocument.SelectSingleNode("//STATUS") == null ? "" : xmlDocument.SelectNodes("//STATUS").Item(0).InnerXml;
                        respuestaEnvioSii.TrackID = xmlDocument.SelectSingleNode("//TRACKID") == null ? "" : xmlDocument.SelectNodes("//TRACKID").Item(0).InnerXml;
                        respuestaEnvioSii.Error = xmlDocument.SelectSingleNode("//ERROR") == null ? "" : xmlDocument.SelectNodes("//ERROR").Item(0).InnerXml;
                        string str1 = xmlDocument.SelectSingleNode("//DETAIL") == null ? "" : xmlDocument.SelectNodes("//DETAIL").Item(0).InnerXml;
                        if (respuestaEnvioSii.Status.Equals("0"))
                        {
                            int num = (int)MessageBox.Show(respuestaEnvioSii.Status + " Numero de Envio:" + respuestaEnvioSii.TrackID, "Envio Correcto", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            this.txtTrackId.Text = respuestaEnvioSii.TrackID;
                            this.pnlEnvioOK.Visible = true;
                            this.tabControlConsulta.Enabled = true;
                            for (int index = 0; index < this._listaDTEEnviar.Count; ++index)
                                this._listaDTEEnviar[index].TrackIDEnvio = respuestaEnvioSii.TrackID;
                            if (this._listaDTEEnviar.Count > 0)
                            {
                                if (this._envioOLibro.Equals("ENVIO"))
                                    new GeneraEnvios().actualizaestadoEnvioDTE(this._listaDTEEnviar);
                                if (this._envioOLibro.Equals("CONSUMO_FOLIOS"))
                                    new GeneraEnvios().actualizaestadoEnvioConsumoFolios(this._listaDTEEnviar);
                                if (this._envioOLibro.Equals("LIBRO"))
                                    new GeneraEnvios().actualizaEstadoLibroDTE(this._listaDTEEnviar);
                            }
                        }
                        else
                        {
                            string str2 = this.estadosDeEnvio(Convert.ToChar(respuestaEnvioSii.Status));
                            int num = (int)MessageBox.Show("Estado:" + respuestaEnvioSii.Status + " - " + str2 + " " + respuestaEnvioSii.Error + " " + str1, "Error de Envio", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        }
                    }
                }
                catch (Exception ex)
                {
                    int num = (int)MessageBox.Show("Problema al enviar archivo " + ex.Message, "Error al Conectar con sii", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    this.pnlEnvioNOOK.Visible = true;
                    this.btnEnviarDocumento.Enabled = true;
                }
            }
            this.btnEnviarDocumento.Enabled = true;
            this.lblConectando.Visible = false;
        }

        private string estadosDeEnvio(char estado)
        {
            string str;
            switch (estado)
            {
                case '0':
                    str = "Upload OK";
                    break;
                case '1':
                    str = "El Sender no tiene permiso para enviar";
                    break;
                case '2':
                    str = "Error en tamaño del archivo (muy grande o muy chico)";
                    break;
                case '3':
                    str = "Archivo cortado (tamaño <> al parámetro size)";
                    break;
                case '5':
                    str = "No está autenticado";
                    break;
                case '6':
                    str = "Empresa no autorizada a enviar archivos";
                    break;
                case '7':
                    str = "Esquema Invalido";
                    break;
                case '8':
                    str = "Firma del Documento";
                    break;
                case '9':
                    str = "Sistema Bloqueado";
                    break;
                default:
                    str = "Error Interno";
                    break;
            }
            return str;
        }

        private void btnConsultaEnvio_Click(object sender, EventArgs e)
        {
            string str = "";
            str = this.ConsultaEnvio();
        }

        private string ConsultaEnvio()
        {
            this.lblConectando.Visible = true;
            this.btnConsultaEnvio.Enabled = false;
            this.pnlEnvioOK.Visible = false;
            this.pnlSemillaOK.Visible = false;
            this.pnlEnvioNOOK.Visible = false;
            this.pnlSemillaNOOK.Visible = false;
            this.txtEstado.Clear();
            this.txtGlosa.Clear();
            this.txtErrCode.Clear();
            this.txtSQLCode.Clear();
            this.txtSvrCode.Clear();
            this.Refresh();
            try
            {
                if (!this.solicitarToken())
                    return "ERROR";
                string text = this.txtTrackId.Text;
                List<RespuestaConsultaEnvioDTE> list = ConsultaEnvioDTE.ConsultaDTE(frmEnviosSII._ambiente, frmEnviosSII._emi.RutEmisior, text, frmEnviosSII._emi.CertificadoDigital, frmEnviosSII._token.Token);
                this.txtEstado.Text = list[0].Estado;
                this.txtGlosa.Text = list[0].Glosa;
                if (list.Count > 0)
                    this.dgvRespuesta.DataSource = (object)list;
                this.txtErrCode.Text = list[0].ERR_CODE;
                this.txtSQLCode.Text = list[0].SQL_CODE;
                this.txtSvrCode.Text = list[0].SRV_CODE;
                this.pnlEnvioOK.Visible = true;
                string str = this.txtEstado.Text.Trim();
                this.btnConsultaEnvio.Enabled = true;
                this.lblConectando.Visible = false;
                this.Refresh();
                return str;
            }
            catch (Exception ex)
            {
                this.pnlEnvioNOOK.Visible = true;
                int num = (int)MessageBox.Show("Error al enviar " + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                string str = "ERROR";
                this.btnConsultaEnvio.Enabled = true;
                this.lblConectando.Visible = false;
                return str;
            }
        }


        public int co, con;
        private Conexion conexion = Conexion.getConecta();
        public string P;
        public int j=0;


        // Consulta DTE Avanzado
        private void btnConsultarDte_Click(object sender, EventArgs e)
        {

            if (this.txtRutCliente.Text != "" && this.txtRutCliente.Text != null && this.txtFechaDte.Text != "" && this.txtFechaDte.Text != null && this.txtTotal.Text != "" && this.txtTotal.Text != null)
            {
                List<int> fol = new List<int>();
                List<Venta> list = new List<Venta>();
                List<string> ingre = new List<string>();
                List<string> estado = new List<string>();

                MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
                //command.Connection.Open();
                command.CommandText = "SELECT folio FROM electronica_factura order by folio";
                MySqlDataReader mySqlDataReader = command.ExecuteReader();


                while ((mySqlDataReader).Read())
                {
                    string text1 = this.txtRutCliente.Text;
                    string tipoDte = Convert.ToString("33");
                    string text2 = Convert.ToString((mySqlDataReader)["folio"]);
                    string fecha = Convert.ToDateTime(this.txtFechaDte.Text).ToString("ddMMyyyy");
                    string text3 = this.txtTotal.Text;

                    if (this.solicitarToken())
                    {
                        RespuestaConsultaEstadoDTE consultaEstadoDte = ConsultaEstadoDTE.ConsultaDTE(frmEnviosSII._ambiente, frmEnviosSII._emi.RutCertificado, frmEnviosSII._emi.RutEmisior, text1, tipoDte, text2, fecha, text3, frmEnviosSII._emi.CertificadoDigital, frmEnviosSII._token.Token);
                        consultaEstadoDte.GlosaErr = consultaEstadoDte.GlosaErr.Replace(Environment.NewLine, " ");
                        consultaEstadoDte.GlosaErr = consultaEstadoDte.GlosaErr.Replace("           ", " ");
                        this.txtEstadoConsultaDte.Text = consultaEstadoDte.Estado + " - " + consultaEstadoDte.Glosa;
                        this.txtErrCodeConsultaDte.Text = consultaEstadoDte.ERR_CODE + " - " + consultaEstadoDte.GlosaErr;
                        this.txtNumAtencionConsultaDte.Text = consultaEstadoDte.NumeroAtencion;


                        try
                        {
                            fol.Add(Convert.ToInt32(((DbDataReader)mySqlDataReader)["folio"]));
                            ingre.Add("Doc Consultado: " + Convert.ToInt32(((DbDataReader)mySqlDataReader)["folio"]) + " " + " Estado dte: " + consultaEstadoDte.Estado + " " + consultaEstadoDte.Glosa + " Numero de atencion: " + consultaEstadoDte.NumeroAtencion);
                            estado.Add(consultaEstadoDte.Estado);

                            //   MessageBox.Show("Doc Consultado: " + Convert.ToInt32(((DbDataReader)mySqlDataReader)["folio"]) + " " + " Estado dte: " + consultaEstadoDte.Estado + " " + consultaEstadoDte.Glosa + " Numero de atencion: " + consultaEstadoDte.NumeroAtencion);
                        }
                        catch
                        {
                            fol.Add(Convert.ToInt32(((DbDataReader)mySqlDataReader)["folio"]));
                            ingre.Add("Doc Consultado: " + Convert.ToInt32(((DbDataReader)mySqlDataReader)["folio"]) + " " + " Estado dte: " + consultaEstadoDte.Estado + " " + consultaEstadoDte.Glosa + " Numero de atencion: " + consultaEstadoDte.NumeroAtencion);
                            estado.Add(consultaEstadoDte.Estado);

                            //MessageBox.Show("Doc Consultado: " + Convert.ToInt32(((DbDataReader)mySqlDataReader)["folio"]) + " " + " Estado dte: " + consultaEstadoDte.Estado + " " + consultaEstadoDte.Glosa + " Numero de atencion: " + consultaEstadoDte.NumeroAtencion);
                        }
                        co++;
                    }
                    if (co == 10)
                    {
                        con = con + co;
                        for (int bj = 0; bj < ingre.Count; bj++)
                        {

                            MySqlCommand cmd = this.conexion.ConexionMySql.CreateCommand();
                            //  string pon = ingre[bj];
                            cmd.CommandText = "UPDATE electronica_factura SET totalPalabras=@totalPalabras, centroCosto=@est WHERE folio=@f";
                            cmd.Parameters.AddWithValue("@totalPalabras", ingre[bj]);
                            cmd.Parameters.AddWithValue("@est", estado[bj]);
                            cmd.Parameters.AddWithValue("@f", fol[bj]);
                            ((MySqlCommand)cmd).ExecuteNonQuery();

                        }

                        co = 0;
                    }
                }

                MessageBox.Show("...::: Proceso finalizado :::...");
                ((DbDataReader)mySqlDataReader).Close();





                /* for (int bj = 0; bj < ingre.Count; bj++)
                      {

                          MySqlCommand cmd = this.conexion.ConexionMySql.CreateCommand();
                          //  string pon = ingre[bj];
                          cmd.CommandText = "UPDATE electronica_factura SET totalPalabras=@totalPalabras, centroCosto=@est WHERE folio=@f";
                          cmd.Parameters.AddWithValue("@totalPalabras", ingre[bj]);
                          cmd.Parameters.AddWithValue("@est", estado[bj]);
                          cmd.Parameters.AddWithValue("@f", fol[bj]);
                          ((DbCommand)cmd).ExecuteNonQuery();

                      }
                this.lblConectando.Visible = true;
                string text1 = this.txtRutCliente.Text;
                string tipoDte = this.cmbDocumentos.SelectedValue.ToString();
                string text2 = this.txtFolioDte.Text;
                string fecha = Convert.ToDateTime(this.txtFechaDte.Text).ToString("ddMMyyyy");
                string text3 = this.txtTotal.Text;
                if (this.solicitarToken())
                {
                    RespuestaConsultaEstadoDTE consultaEstadoDte = ConsultaEstadoDTE.ConsultaDTE(frmEnviosSII._ambiente, frmEnviosSII._emi.RutCertificado, frmEnviosSII._emi.RutEmisior, text1, tipoDte, text2, fecha, text3, frmEnviosSII._emi.CertificadoDigital, frmEnviosSII._token.Token);
                    consultaEstadoDte.GlosaErr = consultaEstadoDte.GlosaErr.Replace(Environment.NewLine, " ");
                    consultaEstadoDte.GlosaErr = consultaEstadoDte.GlosaErr.Replace("           ", " ");
                    this.txtEstadoConsultaDte.Text = consultaEstadoDte.Estado + " - " + consultaEstadoDte.Glosa;
                    this.txtErrCodeConsultaDte.Text = consultaEstadoDte.ERR_CODE + " - " + consultaEstadoDte.GlosaErr;
                    this.txtNumAtencionConsultaDte.Text = consultaEstadoDte.NumeroAtencion;
                }
                this.lblConectando.Visible = false;
                 */
            }
    }

        private void buscaFacturaFolio()
        {
            Venta venta = new EFactura().buscaFacturaFolio(Convert.ToInt32(this.txtFolioDte.Text.Trim()));
            if (venta.IdFactura != 0)
            {
                this.txtFechaDte.Text = venta.FechaEmision.ToShortDateString();
                this.txtRutCliente.Text = venta.Rut + "-" + venta.Digito;
                this.txtRazonSocial.Text = venta.RazonSocial;
                this.txtTotal.Text = venta.Total.ToString("##");
                this.btnConsultarDte.Enabled = true;
            }
            else
            {
                int num = (int)MessageBox.Show("No Existe Factura Electronica Consultada!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.txtFolioDte.Focus();
            }
        }

        private void buscaNotaCreditoFolio()
        {
            Venta venta = new ENotaCredito().buscaNotaCreditoFolio(Convert.ToInt32(this.txtFolioDte.Text.Trim()));
            if (venta.IdFactura != 0)
            {
                this.txtFechaDte.Text = venta.FechaEmision.ToShortDateString();
                this.txtRutCliente.Text = venta.Rut + "-" + venta.Digito;
                this.txtRazonSocial.Text = venta.RazonSocial;
                this.txtTotal.Text = venta.Total.ToString("##");
                this.btnConsultarDte.Enabled = true;
            }
            else
            {
                int num = (int)MessageBox.Show("No Existe Nota de Credito Electronica Consultada!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.txtFolioDte.Focus();
            }
        }

        private void buscaNotaDebitoFolio()
        {
            Venta venta = new ENotaDebito().buscaNotaDebitoFolio(Convert.ToInt32(this.txtFolioDte.Text.Trim()));
            if (venta.IdFactura != 0)
            {
                this.txtFechaDte.Text = venta.FechaEmision.ToShortDateString();
                this.txtRutCliente.Text = venta.Rut + "-" + venta.Digito;
                this.txtRazonSocial.Text = venta.RazonSocial;
                this.txtTotal.Text = venta.Total.ToString("##");
                this.btnConsultarDte.Enabled = true;
            }
            else
            {
                int num = (int)MessageBox.Show("No Existe Nota de Debito Electronica Consultada!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.txtFolioDte.Focus();
            }
        }

        private void buscaFacturaExentaFolio()
        {
            Venta venta = new EFacturaExenta().buscaFacturaFolio(Convert.ToInt32(this.txtFolioDte.Text.Trim()));
            if (venta.IdFactura != 0)
            {
                this.txtFechaDte.Text = venta.FechaEmision.ToShortDateString();
                this.txtRutCliente.Text = venta.Rut + "-" + venta.Digito;
                this.txtRazonSocial.Text = venta.RazonSocial;
                this.txtTotal.Text = venta.Total.ToString("##");
                this.btnConsultarDte.Enabled = true;
            }
            else
            {
                int num = (int)MessageBox.Show("No Existe Factura Exenta Electronica Consultada!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.txtFolioDte.Focus();
            }
        }

        private void btnBuscaDte_Click(object sender, EventArgs e)
        {
            if (this.cmbDocumentos.SelectedValue.ToString() == "33")
                this.buscaFacturaFolio();
            if (this.cmbDocumentos.SelectedValue.ToString() == "34")
                this.buscaFacturaExentaFolio();
            if (this.cmbDocumentos.SelectedValue.ToString() == "56")
                this.buscaNotaDebitoFolio();
            if (this.cmbDocumentos.SelectedValue.ToString() == "61")
                this.buscaNotaCreditoFolio();
            this.pnlEnvioOK.Visible = false;
            this.pnlSemillaOK.Visible = false;
            this.pnlEnvioNOOK.Visible = false;
            this.pnlSemillaNOOK.Visible = false;
            this.txtEstadoConsultaDte.Clear();
            this.txtErrCodeConsultaDte.Clear();
            this.txtNumAtencionConsultaDte.Clear();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && this.components != null)
                this.components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControlConsulta = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvRespuesta = new System.Windows.Forms.DataGridView();
            this.Tipo_Docto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Informados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aceptados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rechazados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reparos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelConsulta = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtTrackId = new System.Windows.Forms.TextBox();
            this.txtGlosa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnConsultaEnvio = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.txtRutCliente = new System.Windows.Forms.TextBox();
            this.lblConectando = new System.Windows.Forms.Label();
            this.btnBuscaDte = new System.Windows.Forms.Button();
            this.cmbDocumentos = new System.Windows.Forms.ComboBox();
            this.txtFechaDte = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnConsultarDte = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtFolioDte = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtNumAtencionConsultaDte = new System.Windows.Forms.TextBox();
            this.txtErrCodeConsultaDte = new System.Windows.Forms.TextBox();
            this.txtEstadoConsultaDte = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtErrCode = new System.Windows.Forms.TextBox();
            this.txtSvrCode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSQLCode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pnlEnvioNOOK = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEnviarDocumento = new System.Windows.Forms.Button();
            this.pnlSemillaNOOK = new System.Windows.Forms.Panel();
            this.pnlEnvioOK = new System.Windows.Forms.Panel();
            this.pnlSemillaOK = new System.Windows.Forms.Panel();
            this.txtArchivo = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.lblServidor = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblmos = new System.Windows.Forms.Label();
            this.tabControlConsulta.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRespuesta)).BeginInit();
            this.panelConsulta.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlConsulta
            // 
            this.tabControlConsulta.Controls.Add(this.tabPage1);
            this.tabControlConsulta.Controls.Add(this.tabPage2);
            this.tabControlConsulta.Location = new System.Drawing.Point(12, 125);
            this.tabControlConsulta.Name = "tabControlConsulta";
            this.tabControlConsulta.SelectedIndex = 0;
            this.tabControlConsulta.Size = new System.Drawing.Size(420, 369);
            this.tabControlConsulta.TabIndex = 35;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvRespuesta);
            this.tabPage1.Controls.Add(this.panelConsulta);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(412, 343);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Consulta por Numero de Envio";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvRespuesta
            // 
            this.dgvRespuesta.AllowUserToAddRows = false;
            this.dgvRespuesta.AllowUserToDeleteRows = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            this.dgvRespuesta.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvRespuesta.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(245)))));
            this.dgvRespuesta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRespuesta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRespuesta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tipo_Docto,
            this.Informados,
            this.Aceptados,
            this.Rechazados,
            this.Reparos});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRespuesta.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgvRespuesta.Enabled = false;
            this.dgvRespuesta.Location = new System.Drawing.Point(6, 107);
            this.dgvRespuesta.Name = "dgvRespuesta";
            this.dgvRespuesta.ReadOnly = true;
            this.dgvRespuesta.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvRespuesta.RowHeadersVisible = false;
            this.dgvRespuesta.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRespuesta.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvRespuesta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRespuesta.Size = new System.Drawing.Size(401, 230);
            this.dgvRespuesta.TabIndex = 10;
            // 
            // Tipo_Docto
            // 
            this.Tipo_Docto.DataPropertyName = "Tipo_Docto";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Tipo_Docto.DefaultCellStyle = dataGridViewCellStyle9;
            this.Tipo_Docto.HeaderText = "Tipo_Docto";
            this.Tipo_Docto.Name = "Tipo_Docto";
            this.Tipo_Docto.ReadOnly = true;
            this.Tipo_Docto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Tipo_Docto.Width = 80;
            // 
            // Informados
            // 
            this.Informados.DataPropertyName = "Informados";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Informados.DefaultCellStyle = dataGridViewCellStyle10;
            this.Informados.HeaderText = "Informados";
            this.Informados.Name = "Informados";
            this.Informados.ReadOnly = true;
            this.Informados.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Informados.Width = 80;
            // 
            // Aceptados
            // 
            this.Aceptados.DataPropertyName = "Aceptados";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Aceptados.DefaultCellStyle = dataGridViewCellStyle11;
            this.Aceptados.HeaderText = "Aceptados";
            this.Aceptados.Name = "Aceptados";
            this.Aceptados.ReadOnly = true;
            this.Aceptados.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Aceptados.Width = 80;
            // 
            // Rechazados
            // 
            this.Rechazados.DataPropertyName = "Rechazados";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Rechazados.DefaultCellStyle = dataGridViewCellStyle12;
            this.Rechazados.HeaderText = "Rechazados";
            this.Rechazados.Name = "Rechazados";
            this.Rechazados.ReadOnly = true;
            this.Rechazados.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Rechazados.Width = 80;
            // 
            // Reparos
            // 
            this.Reparos.DataPropertyName = "Reparos";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Reparos.DefaultCellStyle = dataGridViewCellStyle13;
            this.Reparos.HeaderText = "Reparos ";
            this.Reparos.Name = "Reparos";
            this.Reparos.ReadOnly = true;
            this.Reparos.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Reparos.Width = 80;
            // 
            // panelConsulta
            // 
            this.panelConsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.panelConsulta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelConsulta.Controls.Add(this.label2);
            this.panelConsulta.Controls.Add(this.panel3);
            this.panelConsulta.Controls.Add(this.txtEstado);
            this.panelConsulta.Controls.Add(this.txtTrackId);
            this.panelConsulta.Controls.Add(this.txtGlosa);
            this.panelConsulta.Controls.Add(this.label5);
            this.panelConsulta.Controls.Add(this.label4);
            this.panelConsulta.Controls.Add(this.btnConsultaEnvio);
            this.panelConsulta.Location = new System.Drawing.Point(7, 7);
            this.panelConsulta.Name = "panelConsulta";
            this.panelConsulta.Size = new System.Drawing.Size(400, 96);
            this.panelConsulta.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(8, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Estado";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Location = new System.Drawing.Point(6, 39);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(276, 4);
            this.panel3.TabIndex = 17;
            // 
            // txtEstado
            // 
            this.txtEstado.BackColor = System.Drawing.Color.White;
            this.txtEstado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEstado.Enabled = false;
            this.txtEstado.Location = new System.Drawing.Point(8, 72);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(47, 13);
            this.txtEstado.TabIndex = 12;
            this.txtEstado.TabStop = false;
            // 
            // txtTrackId
            // 
            this.txtTrackId.BackColor = System.Drawing.Color.White;
            this.txtTrackId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrackId.ForeColor = System.Drawing.Color.Black;
            this.txtTrackId.Location = new System.Drawing.Point(130, 12);
            this.txtTrackId.Name = "txtTrackId";
            this.txtTrackId.Size = new System.Drawing.Size(152, 22);
            this.txtTrackId.TabIndex = 1;
            // 
            // txtGlosa
            // 
            this.txtGlosa.BackColor = System.Drawing.Color.White;
            this.txtGlosa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGlosa.Enabled = false;
            this.txtGlosa.Location = new System.Drawing.Point(58, 72);
            this.txtGlosa.Name = "txtGlosa";
            this.txtGlosa.Size = new System.Drawing.Size(224, 13);
            this.txtGlosa.TabIndex = 11;
            this.txtGlosa.TabStop = false;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label5.Location = new System.Drawing.Point(5, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 23);
            this.label5.TabIndex = 15;
            this.label5.Text = "NUMERO DE ENVIO";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(58, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Glosa";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnConsultaEnvio
            // 
            this.btnConsultaEnvio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(245)))));
            this.btnConsultaEnvio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultaEnvio.Image = global::Aptusoft.Properties.Resources.comprobar_la_lista_de_tareas_icono_7647_48;
            this.btnConsultaEnvio.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnConsultaEnvio.Location = new System.Drawing.Point(288, 6);
            this.btnConsultaEnvio.Name = "btnConsultaEnvio";
            this.btnConsultaEnvio.Size = new System.Drawing.Size(108, 82);
            this.btnConsultaEnvio.TabIndex = 2;
            this.btnConsultaEnvio.Text = "Consultar Estado de Envio";
            this.btnConsultaEnvio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnConsultaEnvio.UseVisualStyleBackColor = false;
            this.btnConsultaEnvio.Click += new System.EventHandler(this.btnConsultaEnvio_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(412, 343);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consulta por DTE";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.txtRazonSocial);
            this.panel4.Controls.Add(this.txtRutCliente);
            this.panel4.Controls.Add(this.lblConectando);
            this.panel4.Controls.Add(this.btnBuscaDte);
            this.panel4.Controls.Add(this.cmbDocumentos);
            this.panel4.Controls.Add(this.txtFechaDte);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.btnConsultarDte);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.txtTotal);
            this.panel4.Controls.Add(this.txtFolioDte);
            this.panel4.Location = new System.Drawing.Point(6, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(400, 172);
            this.panel4.TabIndex = 10;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 115);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 13);
            this.label14.TabIndex = 39;
            this.label14.Text = "Cliente";
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.BackColor = System.Drawing.Color.White;
            this.txtRazonSocial.Enabled = false;
            this.txtRazonSocial.Location = new System.Drawing.Point(143, 111);
            this.txtRazonSocial.Multiline = true;
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(241, 44);
            this.txtRazonSocial.TabIndex = 38;
            // 
            // txtRutCliente
            // 
            this.txtRutCliente.BackColor = System.Drawing.Color.White;
            this.txtRutCliente.Enabled = false;
            this.txtRutCliente.Location = new System.Drawing.Point(52, 111);
            this.txtRutCliente.Name = "txtRutCliente";
            this.txtRutCliente.Size = new System.Drawing.Size(85, 20);
            this.txtRutCliente.TabIndex = 37;
            // 
            // lblConectando
            // 
            this.lblConectando.AutoSize = true;
            this.lblConectando.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblConectando.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConectando.Location = new System.Drawing.Point(21, 76);
            this.lblConectando.Name = "lblConectando";
            this.lblConectando.Size = new System.Drawing.Size(414, 39);
            this.lblConectando.TabIndex = 26;
            this.lblConectando.Text = "CONECTANDO CON SII..";
            // 
            // btnBuscaDte
            // 
            this.btnBuscaDte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(245)))));
            this.btnBuscaDte.BackgroundImage = global::Aptusoft.Properties.Resources.check_yes_ok_icone_7166_32;
            this.btnBuscaDte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscaDte.Location = new System.Drawing.Point(174, 36);
            this.btnBuscaDte.Name = "btnBuscaDte";
            this.btnBuscaDte.Size = new System.Drawing.Size(30, 30);
            this.btnBuscaDte.TabIndex = 36;
            this.btnBuscaDte.UseVisualStyleBackColor = false;
            this.btnBuscaDte.Click += new System.EventHandler(this.btnBuscaDte_Click);
            // 
            // cmbDocumentos
            // 
            this.cmbDocumentos.BackColor = System.Drawing.Color.White;
            this.cmbDocumentos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDocumentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbDocumentos.FormattingEnabled = true;
            this.cmbDocumentos.Location = new System.Drawing.Point(73, 10);
            this.cmbDocumentos.Name = "cmbDocumentos";
            this.cmbDocumentos.Size = new System.Drawing.Size(198, 21);
            this.cmbDocumentos.TabIndex = 36;
            // 
            // txtFechaDte
            // 
            this.txtFechaDte.BackColor = System.Drawing.Color.White;
            this.txtFechaDte.Enabled = false;
            this.txtFechaDte.Location = new System.Drawing.Point(52, 87);
            this.txtFechaDte.Name = "txtFechaDte";
            this.txtFechaDte.Size = new System.Drawing.Size(129, 20);
            this.txtFechaDte.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Tipo DTE";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Folio DTE";
            // 
            // btnConsultarDte
            // 
            this.btnConsultarDte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(245)))));
            this.btnConsultarDte.Enabled = false;
            this.btnConsultarDte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarDte.Image = global::Aptusoft.Properties.Resources.buscar_documento_48;
            this.btnConsultarDte.Location = new System.Drawing.Point(277, 4);
            this.btnConsultarDte.Name = "btnConsultarDte";
            this.btnConsultarDte.Size = new System.Drawing.Size(108, 82);
            this.btnConsultarDte.TabIndex = 8;
            this.btnConsultarDte.Text = "Consultar Dte";
            this.btnConsultarDte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnConsultarDte.UseVisualStyleBackColor = false;
            this.btnConsultarDte.Click += new System.EventHandler(this.btnConsultarDte_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 91);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Emision";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 139);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.White;
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(52, 135);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(85, 20);
            this.txtTotal.TabIndex = 6;
            // 
            // txtFolioDte
            // 
            this.txtFolioDte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFolioDte.Location = new System.Drawing.Point(73, 40);
            this.txtFolioDte.Name = "txtFolioDte";
            this.txtFolioDte.Size = new System.Drawing.Size(100, 22);
            this.txtFolioDte.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(245)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtNumAtencionConsultaDte);
            this.panel2.Controls.Add(this.txtErrCodeConsultaDte);
            this.panel2.Controls.Add(this.txtEstadoConsultaDte);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Location = new System.Drawing.Point(6, 184);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 151);
            this.panel2.TabIndex = 9;
            // 
            // txtNumAtencionConsultaDte
            // 
            this.txtNumAtencionConsultaDte.BackColor = System.Drawing.Color.White;
            this.txtNumAtencionConsultaDte.Enabled = false;
            this.txtNumAtencionConsultaDte.Location = new System.Drawing.Point(73, 110);
            this.txtNumAtencionConsultaDte.Name = "txtNumAtencionConsultaDte";
            this.txtNumAtencionConsultaDte.Size = new System.Drawing.Size(311, 20);
            this.txtNumAtencionConsultaDte.TabIndex = 9;
            // 
            // txtErrCodeConsultaDte
            // 
            this.txtErrCodeConsultaDte.BackColor = System.Drawing.Color.White;
            this.txtErrCodeConsultaDte.Enabled = false;
            this.txtErrCodeConsultaDte.Location = new System.Drawing.Point(73, 36);
            this.txtErrCodeConsultaDte.Multiline = true;
            this.txtErrCodeConsultaDte.Name = "txtErrCodeConsultaDte";
            this.txtErrCodeConsultaDte.Size = new System.Drawing.Size(311, 68);
            this.txtErrCodeConsultaDte.TabIndex = 7;
            // 
            // txtEstadoConsultaDte
            // 
            this.txtEstadoConsultaDte.BackColor = System.Drawing.Color.White;
            this.txtEstadoConsultaDte.Enabled = false;
            this.txtEstadoConsultaDte.Location = new System.Drawing.Point(73, 10);
            this.txtEstadoConsultaDte.Name = "txtEstadoConsultaDte";
            this.txtEstadoConsultaDte.Size = new System.Drawing.Size(311, 20);
            this.txtEstadoConsultaDte.TabIndex = 5;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(5, 114);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(64, 13);
            this.label17.TabIndex = 4;
            this.label17.Text = "N° Atencion";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(7, 40);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 13);
            this.label15.TabIndex = 2;
            this.label15.Text = "Glosa";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 14);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Estado";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(245)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtErrCode);
            this.panel1.Controls.Add(this.txtSvrCode);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtSQLCode);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(438, 296);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(61, 74);
            this.panel1.TabIndex = 24;
            this.panel1.Visible = false;
            // 
            // txtErrCode
            // 
            this.txtErrCode.BackColor = System.Drawing.Color.White;
            this.txtErrCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtErrCode.Location = new System.Drawing.Point(79, 13);
            this.txtErrCode.Name = "txtErrCode";
            this.txtErrCode.ReadOnly = true;
            this.txtErrCode.Size = new System.Drawing.Size(240, 13);
            this.txtErrCode.TabIndex = 21;
            this.txtErrCode.TabStop = false;
            // 
            // txtSvrCode
            // 
            this.txtSvrCode.BackColor = System.Drawing.Color.White;
            this.txtSvrCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSvrCode.Location = new System.Drawing.Point(79, 49);
            this.txtSvrCode.Name = "txtSvrCode";
            this.txtSvrCode.ReadOnly = true;
            this.txtSvrCode.Size = new System.Drawing.Size(240, 13);
            this.txtSvrCode.TabIndex = 23;
            this.txtSvrCode.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "ERR_CODE";
            // 
            // txtSQLCode
            // 
            this.txtSQLCode.BackColor = System.Drawing.Color.White;
            this.txtSQLCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSQLCode.Location = new System.Drawing.Point(79, 31);
            this.txtSQLCode.Name = "txtSQLCode";
            this.txtSQLCode.ReadOnly = true;
            this.txtSQLCode.Size = new System.Drawing.Size(240, 13);
            this.txtSQLCode.TabIndex = 22;
            this.txtSQLCode.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "SQL_CODE";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "SRV_CODE";
            // 
            // pnlEnvioNOOK
            // 
            this.pnlEnvioNOOK.BackgroundImage = global::Aptusoft.Properties.Resources.remove_from_office_icone_7567_32;
            this.pnlEnvioNOOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlEnvioNOOK.Location = new System.Drawing.Point(479, 41);
            this.pnlEnvioNOOK.Name = "pnlEnvioNOOK";
            this.pnlEnvioNOOK.Size = new System.Drawing.Size(20, 20);
            this.pnlEnvioNOOK.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(388, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Autenticacion SII";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(388, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Envio Terminado";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(245)))));
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = global::Aptusoft.Properties.Resources.salir_de_mi_perfil_icono_3964_32;
            this.btnSalir.Location = new System.Drawing.Point(433, 418);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(69, 74);
            this.btnSalir.TabIndex = 34;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEnviarDocumento
            // 
            this.btnEnviarDocumento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(245)))));
            this.btnEnviarDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviarDocumento.Image = global::Aptusoft.Properties.Resources.send_mail_icone_9097_48;
            this.btnEnviarDocumento.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEnviarDocumento.Location = new System.Drawing.Point(12, 12);
            this.btnEnviarDocumento.Name = "btnEnviarDocumento";
            this.btnEnviarDocumento.Size = new System.Drawing.Size(124, 84);
            this.btnEnviarDocumento.TabIndex = 27;
            this.btnEnviarDocumento.Text = "Enviar Documentos Elect.";
            this.btnEnviarDocumento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEnviarDocumento.UseVisualStyleBackColor = false;
            this.btnEnviarDocumento.Click += new System.EventHandler(this.btnEnviarDocumento_Click);
            // 
            // pnlSemillaNOOK
            // 
            this.pnlSemillaNOOK.BackgroundImage = global::Aptusoft.Properties.Resources.remove_from_office_icone_7567_32;
            this.pnlSemillaNOOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlSemillaNOOK.Location = new System.Drawing.Point(479, 17);
            this.pnlSemillaNOOK.Name = "pnlSemillaNOOK";
            this.pnlSemillaNOOK.Size = new System.Drawing.Size(20, 20);
            this.pnlSemillaNOOK.TabIndex = 31;
            // 
            // pnlEnvioOK
            // 
            this.pnlEnvioOK.BackgroundImage = global::Aptusoft.Properties.Resources.check_yes_ok_icone_7166_32;
            this.pnlEnvioOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlEnvioOK.Location = new System.Drawing.Point(479, 41);
            this.pnlEnvioOK.Name = "pnlEnvioOK";
            this.pnlEnvioOK.Size = new System.Drawing.Size(20, 20);
            this.pnlEnvioOK.TabIndex = 32;
            // 
            // pnlSemillaOK
            // 
            this.pnlSemillaOK.BackgroundImage = global::Aptusoft.Properties.Resources.check_yes_ok_icone_7166_32;
            this.pnlSemillaOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlSemillaOK.Location = new System.Drawing.Point(479, 17);
            this.pnlSemillaOK.Name = "pnlSemillaOK";
            this.pnlSemillaOK.Size = new System.Drawing.Size(20, 20);
            this.pnlSemillaOK.TabIndex = 30;
            // 
            // txtArchivo
            // 
            this.txtArchivo.BackColor = System.Drawing.Color.White;
            this.txtArchivo.Enabled = false;
            this.txtArchivo.Location = new System.Drawing.Point(143, 76);
            this.txtArchivo.Name = "txtArchivo";
            this.txtArchivo.Size = new System.Drawing.Size(356, 20);
            this.txtArchivo.TabIndex = 36;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(142, 60);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(85, 13);
            this.label16.TabIndex = 37;
            this.label16.Text = "Archivo a Enviar";
            // 
            // lblServidor
            // 
            this.lblServidor.AutoSize = true;
            this.lblServidor.Location = new System.Drawing.Point(13, 497);
            this.lblServidor.Name = "lblServidor";
            this.lblServidor.Size = new System.Drawing.Size(44, 13);
            this.lblServidor.TabIndex = 38;
            this.lblServidor.Text = "servidor";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(438, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 30);
            this.button1.TabIndex = 39;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblmos
            // 
            this.lblmos.AutoSize = true;
            this.lblmos.Location = new System.Drawing.Point(308, 109);
            this.lblmos.Name = "lblmos";
            this.lblmos.Size = new System.Drawing.Size(36, 13);
            this.lblmos.TabIndex = 40;
            this.lblmos.Text = "lblmos";
            this.lblmos.Visible = false;
            // 
            // frmEnviosSII
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(505, 512);
            this.Controls.Add(this.lblmos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblServidor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtArchivo);
            this.Controls.Add(this.pnlSemillaOK);
            this.Controls.Add(this.pnlEnvioOK);
            this.Controls.Add(this.tabControlConsulta);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEnviarDocumento);
            this.Controls.Add(this.pnlEnvioNOOK);
            this.Controls.Add(this.pnlSemillaNOOK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEnviosSII";
            this.Text = " ";
            this.tabControlConsulta.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRespuesta)).EndInit();
            this.panelConsulta.ResumeLayout(false);
            this.panelConsulta.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        private void button1_Click(object sender, EventArgs e)
        {



        }

    }
}
