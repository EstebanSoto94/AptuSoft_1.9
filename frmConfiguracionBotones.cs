 
// Type: Aptusoft.frmConfiguracionBotones
 
 
// version 1.8.0

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Aptusoft
{
  public class frmConfiguracionBotones : Form
  {
    private IContainer components = (IContainer) null;
    private GroupBox groupBox1;
    private Button btnCat6;
    private Button btnCat5;
    private Button btnCat4;
    private Button btnCat3;
    private Button btnCat2;
    private Button btnCat1;
    private Button btnGuardar;
    private ComboBox cmbC2;
    private ComboBox cmbC1;
    private ComboBox cmbC6;
    private ComboBox cmbC5;
    private ComboBox cmbC4;
    private ComboBox cmbC3;
    private ComboBox cmbC9;
    private Button btnCat9;
    private ComboBox cmbC8;
    private Button btnCat8;
    private ComboBox cmbC7;
    private Button btnCat7;

    public frmConfiguracionBotones()
    {
      this.InitializeComponent();
      this.cargaCategorias();
      this.cargaBotones();
    }

    private void cargaCategorias()
    {
      Categoria categoria = new Categoria();
      categoria.listaCategorias();
      this.cmbC1.DataSource = (object) categoria.listaCategorias();
      this.cmbC1.DisplayMember = "Descripcion";
      this.cmbC1.ValueMember = "IdCategoria";
      this.cmbC2.DataSource = (object) categoria.listaCategorias();
      this.cmbC2.DisplayMember = "Descripcion";
      this.cmbC2.ValueMember = "IdCategoria";
      this.cmbC3.DataSource = (object) categoria.listaCategorias();
      this.cmbC3.DisplayMember = "Descripcion";
      this.cmbC3.ValueMember = "IdCategoria";
      this.cmbC4.DataSource = (object) categoria.listaCategorias();
      this.cmbC4.DisplayMember = "Descripcion";
      this.cmbC4.ValueMember = "IdCategoria";
      this.cmbC5.DataSource = (object) categoria.listaCategorias();
      this.cmbC5.DisplayMember = "Descripcion";
      this.cmbC5.ValueMember = "IdCategoria";
      this.cmbC6.DataSource = (object) categoria.listaCategorias();
      this.cmbC6.DisplayMember = "Descripcion";
      this.cmbC6.ValueMember = "IdCategoria";
      this.cmbC7.DataSource = (object) categoria.listaCategorias();
      this.cmbC7.DisplayMember = "Descripcion";
      this.cmbC7.ValueMember = "IdCategoria";
      this.cmbC8.DataSource = (object) categoria.listaCategorias();
      this.cmbC8.DisplayMember = "Descripcion";
      this.cmbC8.ValueMember = "IdCategoria";
      this.cmbC9.DataSource = (object) categoria.listaCategorias();
      this.cmbC9.DisplayMember = "Descripcion";
      this.cmbC9.ValueMember = "IdCategoria";
    }

    private void cargaBotones()
    {
      List<BotonVO> list = new Boton().listaBotones("");
      if (list.Count > 0)
      {
        foreach (BotonVO botonVo in list)
        {
          if (botonVo.Nombre.Equals("btnCat1"))
          {
            this.btnCat1.Text = botonVo.TextoBoton;
            this.cmbC1.SelectedValue = (object) botonVo.IdTexto;
          }
          if (botonVo.Nombre.Equals("btnCat2"))
          {
            this.btnCat2.Text = botonVo.TextoBoton;
            this.cmbC2.SelectedValue = (object) botonVo.IdTexto;
          }
          if (botonVo.Nombre.Equals("btnCat3"))
          {
            this.btnCat3.Text = botonVo.TextoBoton;
            this.cmbC3.SelectedValue = (object) botonVo.IdTexto;
          }
          if (botonVo.Nombre.Equals("btnCat4"))
          {
            this.btnCat4.Text = botonVo.TextoBoton;
            this.cmbC4.SelectedValue = (object) botonVo.IdTexto;
          }
          if (botonVo.Nombre.Equals("btnCat5"))
          {
            this.btnCat5.Text = botonVo.TextoBoton;
            this.cmbC5.SelectedValue = (object) botonVo.IdTexto;
          }
          if (botonVo.Nombre.Equals("btnCat6"))
          {
            this.btnCat6.Text = botonVo.TextoBoton;
            this.cmbC6.SelectedValue = (object) botonVo.IdTexto;
          }
          if (botonVo.Nombre.Equals("btnCat7"))
          {
            this.btnCat7.Text = botonVo.TextoBoton;
            this.cmbC7.SelectedValue = (object) botonVo.IdTexto;
          }
          if (botonVo.Nombre.Equals("btnCat8"))
          {
            this.btnCat8.Text = botonVo.TextoBoton;
            this.cmbC8.SelectedValue = (object) botonVo.IdTexto;
          }
          if (botonVo.Nombre.Equals("btnCat9"))
          {
            this.btnCat9.Text = botonVo.TextoBoton;
            this.cmbC9.SelectedValue = (object) botonVo.IdTexto;
          }
        }
      }
      else
      {
        this.cmbC1.SelectedValue = (object) 0;
        this.cmbC2.SelectedValue = (object) 0;
        this.cmbC3.SelectedValue = (object) 0;
        this.cmbC4.SelectedValue = (object) 0;
        this.cmbC5.SelectedValue = (object) 0;
        this.cmbC6.SelectedValue = (object) 0;
        this.cmbC7.SelectedValue = (object) 0;
        this.cmbC8.SelectedValue = (object) 0;
        this.cmbC9.SelectedValue = (object) 0;
      }
    }

    private void cmbC1_SelectionChangeCommitted(object sender, EventArgs e)
    {
      this.btnCat1.Text = this.cmbC1.Text;
    }

    private void cmbC2_SelectionChangeCommitted(object sender, EventArgs e)
    {
      this.btnCat2.Text = this.cmbC2.Text;
    }

    private void cmbC3_SelectionChangeCommitted(object sender, EventArgs e)
    {
      this.btnCat3.Text = this.cmbC3.Text;
    }

    private void cmbC4_SelectionChangeCommitted(object sender, EventArgs e)
    {
      this.btnCat4.Text = this.cmbC4.Text;
    }

    private void cmbC5_SelectionChangeCommitted(object sender, EventArgs e)
    {
      this.btnCat5.Text = this.cmbC5.Text;
    }

    private void cmbC6_SelectionChangeCommitted(object sender, EventArgs e)
    {
      this.btnCat6.Text = this.cmbC6.Text;
    }

    private void btnGuardar_Click(object sender, EventArgs e)//botones comanda //guardar conf comanda
    {
      BotonVO botonVo = new BotonVO();
      List<BotonVO> lista = new List<BotonVO>();
      botonVo.Nombre = "btnCat1";
      botonVo.IdTexto = Convert.ToInt32(this.cmbC1.SelectedValue.ToString());
      botonVo.TextoBoton = this.cmbC1.Text;
      lista.Add(botonVo);
      lista.Add(new BotonVO()
      {
        Nombre = "btnCat2",
        IdTexto = Convert.ToInt32(this.cmbC2.SelectedValue.ToString()),
        TextoBoton = this.cmbC2.Text
      });
      lista.Add(new BotonVO()
      {
        Nombre = "btnCat3",
        IdTexto = Convert.ToInt32(this.cmbC3.SelectedValue.ToString()),
        TextoBoton = this.cmbC3.Text
      });
      lista.Add(new BotonVO()
      {
        Nombre = "btnCat4",
        IdTexto = Convert.ToInt32(this.cmbC4.SelectedValue.ToString()),
        TextoBoton = this.cmbC4.Text
      });
      lista.Add(new BotonVO()
      {
        Nombre = "btnCat5",
        IdTexto = Convert.ToInt32(this.cmbC5.SelectedValue.ToString()),
        TextoBoton = this.cmbC5.Text
      });
      lista.Add(new BotonVO()
      {
        Nombre = "btnCat6",
        IdTexto = Convert.ToInt32(this.cmbC6.SelectedValue.ToString()),
        TextoBoton = this.cmbC6.Text
      });
      lista.Add(new BotonVO()
      {
        Nombre = "btnCat7",
        IdTexto = Convert.ToInt32(this.cmbC7.SelectedValue.ToString()),
        TextoBoton = this.cmbC7.Text
      });
      lista.Add(new BotonVO()
      {
        Nombre = "btnCat8",
        IdTexto = Convert.ToInt32(this.cmbC8.SelectedValue.ToString()),
        TextoBoton = this.cmbC8.Text
      });
      lista.Add(new BotonVO()
      {
        Nombre = "btnCat9",
        IdTexto = Convert.ToInt32(this.cmbC9.SelectedValue.ToString()),
        TextoBoton = this.cmbC9.Text
      });
      try
      {
        new Boton().registraBotones(lista);
        int num = (int) MessageBox.Show("Botones Registrados", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error: " + ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void cmbC7_SelectionChangeCommitted(object sender, EventArgs e)
    {
      this.btnCat7.Text = this.cmbC7.Text;
    }

    private void cmbC8_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.btnCat8.Text = this.cmbC8.Text;
    }

    private void cmbC9_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.btnCat9.Text = this.cmbC9.Text;
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.groupBox1 = new GroupBox();
      this.cmbC9 = new ComboBox();
      this.btnCat9 = new Button();
      this.cmbC8 = new ComboBox();
      this.btnCat8 = new Button();
      this.cmbC7 = new ComboBox();
      this.btnCat7 = new Button();
      this.cmbC6 = new ComboBox();
      this.cmbC5 = new ComboBox();
      this.cmbC4 = new ComboBox();
      this.cmbC3 = new ComboBox();
      this.cmbC2 = new ComboBox();
      this.cmbC1 = new ComboBox();
      this.btnCat6 = new Button();
      this.btnCat5 = new Button();
      this.btnCat4 = new Button();
      this.btnCat3 = new Button();
      this.btnCat2 = new Button();
      this.btnCat1 = new Button();
      this.btnGuardar = new Button();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      this.groupBox1.Controls.Add((Control) this.cmbC9);
      this.groupBox1.Controls.Add((Control) this.btnCat9);
      this.groupBox1.Controls.Add((Control) this.cmbC8);
      this.groupBox1.Controls.Add((Control) this.btnCat8);
      this.groupBox1.Controls.Add((Control) this.cmbC7);
      this.groupBox1.Controls.Add((Control) this.btnCat7);
      this.groupBox1.Controls.Add((Control) this.cmbC6);
      this.groupBox1.Controls.Add((Control) this.cmbC5);
      this.groupBox1.Controls.Add((Control) this.cmbC4);
      this.groupBox1.Controls.Add((Control) this.cmbC3);
      this.groupBox1.Controls.Add((Control) this.cmbC2);
      this.groupBox1.Controls.Add((Control) this.cmbC1);
      this.groupBox1.Controls.Add((Control) this.btnCat6);
      this.groupBox1.Controls.Add((Control) this.btnCat5);
      this.groupBox1.Controls.Add((Control) this.btnCat4);
      this.groupBox1.Controls.Add((Control) this.btnCat3);
      this.groupBox1.Controls.Add((Control) this.btnCat2);
      this.groupBox1.Controls.Add((Control) this.btnCat1);
      this.groupBox1.Location = new Point(12, 12);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new Size(781, 280);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Asigne una categoria a cada Boton";
      this.cmbC9.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbC9.FormattingEnabled = true;
      this.cmbC9.Location = new Point(599, 216);
      this.cmbC9.Name = "cmbC9";
      this.cmbC9.Size = new Size(168, 21);
      this.cmbC9.TabIndex = 18;
      this.cmbC9.SelectedIndexChanged += new EventHandler(this.cmbC9_SelectedIndexChanged);
      this.btnCat9.Location = new Point(525, 195);
      this.btnCat9.Name = "btnCat9";
      this.btnCat9.Size = new Size(70, 60);
      this.btnCat9.TabIndex = 17;
      this.btnCat9.Text = "c9";
      this.btnCat9.UseVisualStyleBackColor = true;
      this.cmbC8.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbC8.FormattingEnabled = true;
      this.cmbC8.Location = new Point(347, 216);
      this.cmbC8.Name = "cmbC8";
      this.cmbC8.Size = new Size(168, 21);
      this.cmbC8.TabIndex = 16;
      this.cmbC8.SelectedIndexChanged += new EventHandler(this.cmbC8_SelectedIndexChanged);
      this.btnCat8.Location = new Point(273, 195);
      this.btnCat8.Name = "btnCat8";
      this.btnCat8.Size = new Size(70, 60);
      this.btnCat8.TabIndex = 15;
      this.btnCat8.Text = "c8";
      this.btnCat8.UseVisualStyleBackColor = true;
      this.cmbC7.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbC7.FormattingEnabled = true;
      this.cmbC7.Location = new Point(80, 216);
      this.cmbC7.Name = "cmbC7";
      this.cmbC7.Size = new Size(168, 21);
      this.cmbC7.TabIndex = 14;
      this.cmbC7.SelectionChangeCommitted += new EventHandler(this.cmbC7_SelectionChangeCommitted);
      this.btnCat7.Location = new Point(6, 195);
      this.btnCat7.Name = "btnCat7";
      this.btnCat7.Size = new Size(70, 60);
      this.btnCat7.TabIndex = 13;
      this.btnCat7.Text = "c7";
      this.btnCat7.UseVisualStyleBackColor = true;
      this.cmbC6.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbC6.FormattingEnabled = true;
      this.cmbC6.Location = new Point(599, 138);
      this.cmbC6.Name = "cmbC6";
      this.cmbC6.Size = new Size(168, 21);
      this.cmbC6.TabIndex = 12;
      this.cmbC6.SelectionChangeCommitted += new EventHandler(this.cmbC6_SelectionChangeCommitted);
      this.cmbC5.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbC5.FormattingEnabled = true;
      this.cmbC5.Location = new Point(347, 138);
      this.cmbC5.Name = "cmbC5";
      this.cmbC5.Size = new Size(168, 21);
      this.cmbC5.TabIndex = 11;
      this.cmbC5.SelectionChangeCommitted += new EventHandler(this.cmbC5_SelectionChangeCommitted);
      this.cmbC4.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbC4.FormattingEnabled = true;
      this.cmbC4.Location = new Point(80, 138);
      this.cmbC4.Name = "cmbC4";
      this.cmbC4.Size = new Size(168, 21);
      this.cmbC4.TabIndex = 10;
      this.cmbC4.SelectionChangeCommitted += new EventHandler(this.cmbC4_SelectionChangeCommitted);
      this.cmbC3.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbC3.FormattingEnabled = true;
      this.cmbC3.Location = new Point(599, 60);
      this.cmbC3.Name = "cmbC3";
      this.cmbC3.Size = new Size(168, 21);
      this.cmbC3.TabIndex = 9;
      this.cmbC3.SelectionChangeCommitted += new EventHandler(this.cmbC3_SelectionChangeCommitted);
      this.cmbC2.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbC2.FormattingEnabled = true;
      this.cmbC2.Location = new Point(347, 60);
      this.cmbC2.Name = "cmbC2";
      this.cmbC2.Size = new Size(168, 21);
      this.cmbC2.TabIndex = 8;
      this.cmbC2.SelectionChangeCommitted += new EventHandler(this.cmbC2_SelectionChangeCommitted);
      this.cmbC1.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbC1.FormattingEnabled = true;
      this.cmbC1.Location = new Point(80, 60);
      this.cmbC1.Name = "cmbC1";
      this.cmbC1.Size = new Size(168, 21);
      this.cmbC1.TabIndex = 7;
      this.cmbC1.SelectionChangeCommitted += new EventHandler(this.cmbC1_SelectionChangeCommitted);
      this.btnCat6.Location = new Point(525, 117);
      this.btnCat6.Name = "btnCat6";
      this.btnCat6.Size = new Size(70, 60);
      this.btnCat6.TabIndex = 6;
      this.btnCat6.Text = "c6";
      this.btnCat6.UseVisualStyleBackColor = true;
      this.btnCat5.Location = new Point(273, 117);
      this.btnCat5.Name = "btnCat5";
      this.btnCat5.Size = new Size(70, 60);
      this.btnCat5.TabIndex = 5;
      this.btnCat5.Text = "c5";
      this.btnCat5.UseVisualStyleBackColor = true;
      this.btnCat4.Location = new Point(6, 117);
      this.btnCat4.Name = "btnCat4";
      this.btnCat4.Size = new Size(70, 60);
      this.btnCat4.TabIndex = 4;
      this.btnCat4.Text = "c4";
      this.btnCat4.UseVisualStyleBackColor = true;
      this.btnCat3.Location = new Point(525, 44);
      this.btnCat3.Name = "btnCat3";
      this.btnCat3.Size = new Size(70, 60);
      this.btnCat3.TabIndex = 3;
      this.btnCat3.Text = "c3";
      this.btnCat3.UseVisualStyleBackColor = true;
      this.btnCat2.Location = new Point(273, 44);
      this.btnCat2.Name = "btnCat2";
      this.btnCat2.Size = new Size(70, 60);
      this.btnCat2.TabIndex = 2;
      this.btnCat2.Text = "c2";
      this.btnCat2.UseVisualStyleBackColor = true;
      this.btnCat1.Location = new Point(6, 44);
      this.btnCat1.Name = "btnCat1";
      this.btnCat1.Size = new Size(70, 60);
      this.btnCat1.TabIndex = 1;
      this.btnCat1.Text = "c1";
      this.btnCat1.UseVisualStyleBackColor = true;
      this.btnGuardar.Location = new Point(12, 298);
      this.btnGuardar.Name = "btnGuardar";
      this.btnGuardar.Size = new Size(108, 45);
      this.btnGuardar.TabIndex = 1;
      this.btnGuardar.Text = "GUARDAR";
      this.btnGuardar.UseVisualStyleBackColor = true;
      this.btnGuardar.Click += new EventHandler(this.btnGuardar_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
//      this.AutoScaleMode = Auto//ScaleMode.Font;
      this.BackColor = Color.FromArgb(223, 233, 245);
      this.ClientSize = new Size(799, 351);
      this.Controls.Add((Control) this.btnGuardar);
      this.Controls.Add((Control) this.groupBox1);
//      this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
      this.Name = "frmConfiguracionBotones";
      this.Text = "Configuracion Botones Comanda";
      this.groupBox1.ResumeLayout(false);
      this.ResumeLayout(false);
    }
  }
}
