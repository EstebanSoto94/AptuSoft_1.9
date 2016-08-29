 
// Type: Aptusoft.Correo
 
 
// version 1.8.0

using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Aptusoft.FacturaElectronica;

namespace Aptusoft
{
    public class Correo : Form
    {
        private IContainer components = (IContainer)null;
        private string smtp;
        private string usuario;
        private string clave;
        private string mail;
        private OrdenAtencionVO at;
        private Venta venta;
        private string mensaje;
        private Label label4;
        private TextBox txtObservaciones;
        private Button btnSalir;
        private Button btnEnviar;
        private TextBox txtMensaje;
        private TextBox txtAsunto;
        private Label label3;
        private TextBox txtPara;
        private Label label2;
        private TextBox txtDesde;
        private TextBox txtAadjunto;
        private Button btnAdjuntar;
        private Label label1;
        private DataGridView dgvAdjunto;
        private Label label5;
        private Attachment adjunto;
        private int num = 0;
        SmtpClient smtpClient = new SmtpClient();
        MailMessage msg = new MailMessage();
        CorreoClase correoClase = new CorreoClase();
        CorreoVO correoVO = new CorreoVO();
        string firmaCorreo = "<br><br><br><i><small><center>Env&iacute;o proporcionado por AptuSoft Consultores LTDA<center></small></i><br><i><small><center>Visitenos en <a href='http://www.aptusoft.cl'>www.aptusoft.cl</a><center></small></i>";

        public Correo()
        {
            this.InitializeComponent();
            this.cargaForm();
        }

        public Correo(OrdenAtencionVO ate)
        {
            this.InitializeComponent();
            this.cargaForm();
            this.at = ate;
            this.txtPara.Text = this.at.Email;
            this.txtAsunto.Text = "Orden de Atención Aptusoft";
            this.mensaje = "CLIENTE:\r\n";
            Correo correo1 = this;
            string str1 = correo1.mensaje + this.at.RazonSocial + "\r\n";
            correo1.mensaje = str1;
            this.mensaje += "\r\n";
            this.mensaje += "SOLICITADO:\r\n";
            Correo correo2 = this;
            string str2 = correo2.mensaje + this.at.FechaIngreso.ToString() + "\r\n";
            correo2.mensaje = str2;
            this.mensaje += "\r\n";
            this.mensaje += "ATENCION:\r\n";
            Correo correo3 = this;
            string str3 = correo3.mensaje + this.at.FechaAtencion.ToString() + "\r\n";
            correo3.mensaje = str3;
            this.mensaje += "\r\n";
            this.mensaje += "CONTACTO:\r\n";
            Correo correo4 = this;
            string str4 = correo4.mensaje + this.at.Contacto + "\r\n";
            correo4.mensaje = str4;
            this.mensaje += "\r\n";
            this.mensaje += "REQUERIMIENTO:\r\n";
            Correo correo5 = this;
            string str5 = correo5.mensaje + this.at.Requerimiento + "\r\n";
            correo5.mensaje = str5;
            this.mensaje += "\r\n";
            this.mensaje += "SOLUCION: \r\n";
            Correo correo6 = this;
            string str6 = correo6.mensaje + this.at.Solucion + "\r\n";
            correo6.mensaje = str6;
            this.mensaje += "\r\n";
            this.mensaje += "TECNICO: \r\n";
            Correo correo7 = this;
            string str7 = correo7.mensaje + this.at.Tecnico + "\r\n";
            correo7.mensaje = str7;
            this.mensaje += "\r\n";
            this.mensaje += "ESTADO DE ORDEN DE ATENCION   :\r\n";
            Correo correo8 = this;
            string str8 = correo8.mensaje + this.at.Estado.ToUpper() + "\r\n";
            correo8.mensaje = str8;
            this.mensaje += "\r\n";
            this.txtMensaje.Text = this.mensaje;

            msg.To.Add(txtPara.Text);
            msg.Subject = txtAsunto.Text;
            msg.IsBodyHtml = true;
            msg.Body = mensaje;

            msg.From = new MailAddress(usuario);
        }

        public Correo(Attachment xml, Attachment pdf, string ruta_pdf, string ruta_xml, Venta venta)
        {
            this.InitializeComponent();
            this.cargaForm();
            this.txtObservaciones.Visible = false;
            this.txtAadjunto.Visible = false;
            this.btnAdjuntar.Visible = false;
            this.label4.Visible = false;
            this.llenarDgvEnvioContribuyente();
            this.venta = venta;
            this.txtPara.Text = this.venta.Fax;
            this.txtAsunto.Text = "Envio DTE a: " + venta.Rut + "-" + venta.Digito;
            this.mensaje = "ESTIMADO CLIENTE\r\n";
            Correo correo1 = this;
            string str1 = correo1.mensaje + this.venta.RazonSocial + ":\r\n";
            correo1.mensaje = str1;
            this.mensaje += "\r\n";
            this.mensaje += "SE ADJUNTA XML Y PDF DE FACTURA N° " + venta.Folio + "\r\n";
            this.mensaje += "\r\n";
            this.txtMensaje.Text = this.mensaje;

            try
            {
                msg.IsBodyHtml = true;
                msg.Attachments.Add(xml);
                msg.From = new MailAddress(usuario);
                msg.Attachments.Add(pdf);

                dgvAdjunto.Rows.Add(ruta_xml, "xml");
                dgvAdjunto.Rows.Add(ruta_pdf, "pdf");
            }
            catch (Exception ex)
            {
                string exce = "Error al intentar abrir el envío de correo: " + ex.ToString();
                MessageBox.Show(exce, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        public Correo(Attachment xml, string ruta_xml, int num, string rutRecibo)
        {
            this.InitializeComponent();
            this.cargaForm();
            this.txtObservaciones.Visible = false;
            this.txtAadjunto.Visible = false;
            this.btnAdjuntar.Visible = false;
            this.label4.Visible = false;
            this.llenarDgvEnvioContribuyente();

            if (num == 1)
            {
                this.txtAsunto.Text = "Envío Acuse de Recibo";
            }
            else if (num == 2)
            {
                this.txtAsunto.Text = "Envío Recibo de Mercadería o Servicio";
            }
            else
            {
                this.txtAsunto.Text = "Envío Aceptación o Rechazo de los DTE";
            }

            this.mensaje = "ESTIMADO CLIENTE RUT: " + rutRecibo + "\r\n";
            Correo correo1 = this;
            this.mensaje += "\r\n";
            this.mensaje += "SE ADJUNTA XML DE RESPUESTA \r\n";
            this.mensaje += "\r\n";
            this.txtMensaje.Text = this.mensaje;

            msg.Subject = txtAsunto.Text;
            msg.IsBodyHtml = true;
            msg.Attachments.Add(xml);
            msg.From = new MailAddress(usuario);

            dgvAdjunto.Rows.Add(ruta_xml, "xml");
        }

        private void cargaForm()
        {
            try
            {
                DataTable Datos = correoClase.opcionesCorreo();

                DataRow row = Datos.Rows[0];
                txtDesde.Text = row["correo"].ToString();
                usuario = txtDesde.Text;
                clave = row["contrasena"].ToString();
                this.smtp = row["servidor_correo"].ToString();
                this.txtDesde.Enabled = false;
            }
            catch (Exception ex)
            {
                int num = (int)MessageBox.Show("No hay registros, Ingrese Datos de Cuenta. " + ex.Message);
            }
        }

        private void btnEnviar_Click_1(object sender, EventArgs e)
        {
            if (emailValido(txtPara.Text) && emailValido(txtDesde.Text))
            {
                enviar(msg);
            }
            else
            {
                MessageBox.Show("El e-Mail es inválido");
            }

        }

        public void enviar(MailMessage msg)
        {
            SmtpClient smtpClient = new SmtpClient(this.smtp);
            smtpClient.Credentials = (ICredentialsByHost)new NetworkCredential(this.usuario, this.clave);
            smtpClient.EnableSsl = true;
            try
            {
                msg.To.Add(txtPara.Text);
                msg.Body = txtMensaje.Text;
                msg.Subject = txtAsunto.Text;
                msg.Body += firmaCorreo;
                smtpClient.Send(msg);
                MessageBox.Show("El Correo Fue enviado a : " + msg.To.ToString(), "Correo Enviado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo enviar al correo: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private Boolean emailValido(String email)
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            if (op.ShowDialog() == DialogResult.OK)
            {
                txtAadjunto.Text = op.FileName;
            }
        }

        private void llenarDgvEnvioContribuyente()
        {
            DataGridViewTextBoxColumn c1 = new DataGridViewTextBoxColumn();
            c1.HeaderText = "Ruta de Archivo";
            c1.Width = 350;
            c1.ReadOnly = true;

            DataGridViewTextBoxColumn c2 = new DataGridViewTextBoxColumn();
            c2.HeaderText = "Tipo de Archivo";
            c2.Width = 68;
            c2.ReadOnly = true;

            dgvAdjunto.AllowUserToAddRows = false;

            dgvAdjunto.Columns.Add(c1);
            dgvAdjunto.Columns.Add(c2);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && this.components != null)
                this.components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.txtAsunto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPara = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDesde = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAadjunto = new System.Windows.Forms.TextBox();
            this.btnAdjuntar = new System.Windows.Forms.Button();
            this.dgvAdjunto = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdjunto)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 347);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 14);
            this.label4.TabIndex = 21;
            this.label4.Text = "Observaciones:";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(12, 364);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(421, 109);
            this.txtObservaciones.TabIndex = 20;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(358, 510);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 19;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.Location = new System.Drawing.Point(12, 510);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(121, 23);
            this.btnEnviar.TabIndex = 18;
            this.btnEnviar.Text = "Enviar Correo";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click_1);
            // 
            // txtMensaje
            // 
            this.txtMensaje.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMensaje.Location = new System.Drawing.Point(12, 86);
            this.txtMensaje.Multiline = true;
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMensaje.Size = new System.Drawing.Size(421, 86);
            this.txtMensaje.TabIndex = 17;
            // 
            // txtAsunto
            // 
            this.txtAsunto.Location = new System.Drawing.Point(75, 60);
            this.txtAsunto.Name = "txtAsunto";
            this.txtAsunto.Size = new System.Drawing.Size(358, 20);
            this.txtAsunto.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 14);
            this.label3.TabIndex = 15;
            this.label3.Text = "Asunto:";
            // 
            // txtPara
            // 
            this.txtPara.Location = new System.Drawing.Point(75, 34);
            this.txtPara.Name = "txtPara";
            this.txtPara.Size = new System.Drawing.Size(358, 20);
            this.txtPara.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 14);
            this.label2.TabIndex = 13;
            this.label2.Text = "Para:";
            // 
            // txtDesde
            // 
            this.txtDesde.Location = new System.Drawing.Point(75, 8);
            this.txtDesde.Name = "txtDesde";
            this.txtDesde.Size = new System.Drawing.Size(358, 20);
            this.txtDesde.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 14);
            this.label1.TabIndex = 11;
            this.label1.Text = "De:";
            // 
            // txtAadjunto
            // 
            this.txtAadjunto.Location = new System.Drawing.Point(12, 479);
            this.txtAadjunto.Name = "txtAadjunto";
            this.txtAadjunto.ReadOnly = true;
            this.txtAadjunto.Size = new System.Drawing.Size(340, 20);
            this.txtAadjunto.TabIndex = 22;
            // 
            // btnAdjuntar
            // 
            this.btnAdjuntar.Location = new System.Drawing.Point(357, 479);
            this.btnAdjuntar.Name = "btnAdjuntar";
            this.btnAdjuntar.Size = new System.Drawing.Size(76, 25);
            this.btnAdjuntar.TabIndex = 23;
            this.btnAdjuntar.Text = "adjuntar";
            this.btnAdjuntar.UseVisualStyleBackColor = true;
            this.btnAdjuntar.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvAdjunto
            // 
            this.dgvAdjunto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdjunto.Location = new System.Drawing.Point(15, 197);
            this.dgvAdjunto.Name = "dgvAdjunto";
            this.dgvAdjunto.Size = new System.Drawing.Size(418, 147);
            this.dgvAdjunto.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 14);
            this.label5.TabIndex = 26;
            this.label5.Text = "Adjunto:";
            // 
            // Correo
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(458, 545);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvAdjunto);
            this.Controls.Add(this.btnAdjuntar);
            this.Controls.Add(this.txtAadjunto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtMensaje);
            this.Controls.Add(this.txtAsunto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPara);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDesde);
            this.Controls.Add(this.label1);
            this.Name = "Correo";
            this.ShowIcon = false;
            this.Text = "Correo";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdjunto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
