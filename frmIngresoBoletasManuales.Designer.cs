namespace Aptusoft.FacturaElectronica.Formularios
{
    partial class frmInger
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInger));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.subtotal = new System.Windows.Forms.TextBox();
            this.TxtNeto = new System.Windows.Forms.TextBox();
            this.txtExento = new System.Windows.Forms.TextBox();
            this.TxtIva = new System.Windows.Forms.TextBox();
            this.TxtValorIva = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.fecha = new System.Windows.Forms.DateTimePicker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarRegistroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnmodifica = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.aux_iva = new System.Windows.Forms.Label();
            this.aux_neto = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Boleta",
            "Voucher"});
            this.comboBox1.Location = new System.Drawing.Point(63, 124);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(239, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Neto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "exento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "iva";
            // 
            // subtotal
            // 
            this.subtotal.Location = new System.Drawing.Point(63, 151);
            this.subtotal.Name = "subtotal";
            this.subtotal.Size = new System.Drawing.Size(247, 20);
            this.subtotal.TabIndex = 5;
            this.subtotal.TextAlignChanged += new System.EventHandler(this.TxtTotal_TextAlignChanged);
            this.subtotal.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.subtotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTotal_KeyPress);
            // 
            // TxtNeto
            // 
            this.TxtNeto.Location = new System.Drawing.Point(63, 182);
            this.TxtNeto.Name = "TxtNeto";
            this.TxtNeto.ReadOnly = true;
            this.TxtNeto.Size = new System.Drawing.Size(247, 20);
            this.TxtNeto.TabIndex = 6;
            // 
            // txtExento
            // 
            this.txtExento.Location = new System.Drawing.Point(63, 234);
            this.txtExento.Name = "txtExento";
            this.txtExento.Size = new System.Drawing.Size(247, 20);
            this.txtExento.TabIndex = 7;
            this.txtExento.TextChanged += new System.EventHandler(this.txtExento_TextChanged);
            this.txtExento.Enter += new System.EventHandler(this.txtExento_Enter);
            this.txtExento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtExento_KeyPress);
            // 
            // TxtIva
            // 
            this.TxtIva.Location = new System.Drawing.Point(63, 208);
            this.TxtIva.Name = "TxtIva";
            this.TxtIva.ReadOnly = true;
            this.TxtIva.Size = new System.Drawing.Size(186, 20);
            this.TxtIva.TabIndex = 8;
            // 
            // TxtValorIva
            // 
            this.TxtValorIva.Location = new System.Drawing.Point(255, 208);
            this.TxtValorIva.Name = "TxtValorIva";
            this.TxtValorIva.ReadOnly = true;
            this.TxtValorIva.Size = new System.Drawing.Size(55, 20);
            this.TxtValorIva.TabIndex = 9;
            this.TxtValorIva.Text = "19";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.btnAgregar.Image = global::Aptusoft.Properties.Resources.disquetes_excepto_icono_7120_48;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAgregar.Location = new System.Drawing.Point(26, 309);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 74);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Guardar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.button2.Image = global::Aptusoft.Properties.Resources.cambio_de_cepillo_de_escoba_de_barrer_claro_icono_5768_48;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(269, 309);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 74);
            this.button2.TabIndex = 11;
            this.button2.Text = "Limpiar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Fecha  Ingreso";
            // 
            // fecha
            // 
            this.fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fecha.Location = new System.Drawing.Point(107, 60);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(87, 20);
            this.fecha.TabIndex = 13;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(66, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Tipo Documento";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(368, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarRegistroToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // buscarRegistroToolStripMenuItem
            // 
            this.buscarRegistroToolStripMenuItem.Name = "buscarRegistroToolStripMenuItem";
            this.buscarRegistroToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.buscarRegistroToolStripMenuItem.Text = "Buscar Registro";
            this.buscarRegistroToolStripMenuItem.Click += new System.EventHandler(this.buscarRegistroToolStripMenuItem_Click);
            // 
            // btnmodifica
            // 
            this.btnmodifica.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnmodifica.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnmodifica.Image = global::Aptusoft.Properties.Resources.modificar_48;
            this.btnmodifica.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnmodifica.Location = new System.Drawing.Point(107, 309);
            this.btnmodifica.Name = "btnmodifica";
            this.btnmodifica.Size = new System.Drawing.Size(75, 74);
            this.btnmodifica.TabIndex = 16;
            this.btnmodifica.Text = "Modificar";
            this.btnmodifica.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnmodifica.UseVisualStyleBackColor = true;
            this.btnmodifica.Visible = false;
            this.btnmodifica.Click += new System.EventHandler(this.btnmodifica_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btneliminar.Image = global::Aptusoft.Properties.Resources.mark_correo_basura_icono_3897_48;
            this.btneliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btneliminar.Location = new System.Drawing.Point(188, 309);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(75, 74);
            this.btneliminar.TabIndex = 17;
            this.btneliminar.Text = "Eiminar";
            this.btneliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Visible = false;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(180, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "N° Ingreso";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(235, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(33, 20);
            this.textBox1.TabIndex = 19;
            this.textBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Aquamarine;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtBuscar);
            this.panel1.Location = new System.Drawing.Point(91, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(158, 94);
            this.panel1.TabIndex = 20;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(128, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(25, 23);
            this.button6.TabIndex = 3;
            this.button6.Text = "X";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Visible = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(36, 61);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(81, 22);
            this.button5.TabIndex = 2;
            this.button5.Text = "Buscar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 18);
            this.label8.TabIndex = 1;
            this.label8.Text = "Buscar Ingreso:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(28, 35);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(100, 20);
            this.txtBuscar.TabIndex = 0;
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_KeyPress);
            // 
            // aux_iva
            // 
            this.aux_iva.AutoSize = true;
            this.aux_iva.Location = new System.Drawing.Point(327, 122);
            this.aux_iva.Name = "aux_iva";
            this.aux_iva.Size = new System.Drawing.Size(35, 13);
            this.aux_iva.TabIndex = 21;
            this.aux_iva.Text = "label9";
            this.aux_iva.Visible = false;
            // 
            // aux_neto
            // 
            this.aux_neto.AutoSize = true;
            this.aux_neto.Location = new System.Drawing.Point(329, 164);
            this.aux_neto.Name = "aux_neto";
            this.aux_neto.Size = new System.Drawing.Size(41, 13);
            this.aux_neto.TabIndex = 22;
            this.aux_neto.Text = "label10";
            this.aux_neto.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 154);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "SubTotal";
            // 
            // total
            // 
            this.total.Location = new System.Drawing.Point(63, 267);
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Size = new System.Drawing.Size(247, 20);
            this.total.TabIndex = 24;
            // 
            // frmInger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(368, 395);
            this.Controls.Add(this.total);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.aux_neto);
            this.Controls.Add(this.aux_iva);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnmodifica);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtNeto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtExento);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.subtotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtIva);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtValorIva);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmInger";
            this.Text = "ingresos manuales";
            this.Load += new System.EventHandler(this.frmInger_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox subtotal;
        private System.Windows.Forms.TextBox TxtNeto;
        private System.Windows.Forms.TextBox txtExento;
        private System.Windows.Forms.TextBox TxtIva;
        private System.Windows.Forms.TextBox TxtValorIva;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker fecha;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnmodifica;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarRegistroToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label aux_neto;
        private System.Windows.Forms.Label aux_iva;
        private System.Windows.Forms.TextBox total;
        private System.Windows.Forms.Label label9;
    }
}