 
// Type: Aptusoft.frmPermisoInforme
 
 
// version 1.8.0

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Aptusoft
{
  public class frmPermisoInforme : Form
  {
    private IContainer components = (IContainer) null;
    private List<InformeVO> listaInformes = new List<InformeVO>();
    private List<InformeVO> listaInformesFiltro = new List<InformeVO>();
    private List<InformeVO> listaInformeUsuario = new List<InformeVO>();
    private int idTipoUsuario = 0;
    private Button btnSalir;
    private Button btnGuardar;
    private DataGridView dgvPermisos;
    private CheckBox chkSeleccionar;
    private ComboBox cmbModulo;
    private Label label1;
    private Button btnFiltro;
    private Label lblTipoUsuario;
    private Label label2;

    public frmPermisoInforme(string tu, int id)
    {
      this.InitializeComponent();
      this.cargaModulos();
      this.lblTipoUsuario.Text = tu;
      this.idTipoUsuario = id;
      this.buscaPermisosTipousuario();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dgvPermisos = new System.Windows.Forms.DataGridView();
            this.chkSeleccionar = new System.Windows.Forms.CheckBox();
            this.cmbModulo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFiltro = new System.Windows.Forms.Button();
            this.lblTipoUsuario = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermisos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(758, 496);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 42);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(12, 496);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 42);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dgvPermisos
            // 
            this.dgvPermisos.AllowUserToAddRows = false;
            this.dgvPermisos.AllowUserToDeleteRows = false;
            this.dgvPermisos.AllowUserToResizeColumns = false;
            this.dgvPermisos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Lavender;
            this.dgvPermisos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPermisos.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvPermisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPermisos.Location = new System.Drawing.Point(12, 55);
            this.dgvPermisos.MultiSelect = false;
            this.dgvPermisos.Name = "dgvPermisos";
            this.dgvPermisos.RowHeadersVisible = false;
            this.dgvPermisos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPermisos.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPermisos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPermisos.Size = new System.Drawing.Size(821, 394);
            this.dgvPermisos.TabIndex = 12;
            // 
            // chkSeleccionar
            // 
            this.chkSeleccionar.AutoSize = true;
            this.chkSeleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSeleccionar.Location = new System.Drawing.Point(682, 455);
            this.chkSeleccionar.Name = "chkSeleccionar";
            this.chkSeleccionar.Size = new System.Drawing.Size(151, 17);
            this.chkSeleccionar.TabIndex = 0;
            this.chkSeleccionar.Text = "SELECCIONAR TODO";
            this.chkSeleccionar.UseVisualStyleBackColor = true;
            this.chkSeleccionar.CheckedChanged += new System.EventHandler(this.chkSeleccionar_CheckedChanged);
            // 
            // cmbModulo
            // 
            this.cmbModulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModulo.FormattingEnabled = true;
            this.cmbModulo.Location = new System.Drawing.Point(72, 23);
            this.cmbModulo.Name = "cmbModulo";
            this.cmbModulo.Size = new System.Drawing.Size(249, 21);
            this.cmbModulo.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "MODULO";
            // 
            // btnFiltro
            // 
            this.btnFiltro.Location = new System.Drawing.Point(327, 23);
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Size = new System.Drawing.Size(75, 23);
            this.btnFiltro.TabIndex = 15;
            this.btnFiltro.Text = "Filtrar";
            this.btnFiltro.UseVisualStyleBackColor = true;
            this.btnFiltro.Click += new System.EventHandler(this.btnFiltro_Click);
            // 
            // lblTipoUsuario
            // 
            this.lblTipoUsuario.AutoSize = true;
            this.lblTipoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoUsuario.Location = new System.Drawing.Point(551, 26);
            this.lblTipoUsuario.Name = "lblTipoUsuario";
            this.lblTipoUsuario.Size = new System.Drawing.Size(107, 15);
            this.lblTipoUsuario.TabIndex = 16;
            this.lblTipoUsuario.Text = "TIPO USUARIO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(442, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "TIPO USUARIO:";
            // 
            // frmPermisoInforme
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(841, 550);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTipoUsuario);
            this.Controls.Add(this.btnFiltro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbModulo);
            this.Controls.Add(this.chkSeleccionar);
            this.Controls.Add(this.dgvPermisos);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnSalir);
            this.Name = "frmPermisoInforme";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Permisos de Informes";
            this.Load += new System.EventHandler(this.frmPermisoInforme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermisos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    private void creaColumnasPermisos()
    {
      this.dgvPermisos.AutoGenerateColumns = false;
      this.dgvPermisos.Columns.Add("Linea", "");
      this.dgvPermisos.Columns[0].DataPropertyName = "Linea";
      this.dgvPermisos.Columns[0].Width = 30;
      this.dgvPermisos.Columns[0].Resizable = DataGridViewTriState.False;
      this.dgvPermisos.Columns[0].Visible = true;
      this.dgvPermisos.Columns.Add("IdDetalleInforme", "IdDetalleInforme");
      this.dgvPermisos.Columns[1].DataPropertyName = "IdDetalleInforme";
      this.dgvPermisos.Columns[1].Width = 20;
      this.dgvPermisos.Columns[1].Resizable = DataGridViewTriState.False;
      this.dgvPermisos.Columns[1].Visible = false;
      this.dgvPermisos.Columns.Add("IdTipoUsuario", "IdTipoUsuario");
      this.dgvPermisos.Columns[2].DataPropertyName = "IdTipoUsuario";
      this.dgvPermisos.Columns[2].Width = 20;
      this.dgvPermisos.Columns[2].Resizable = DataGridViewTriState.False;
      this.dgvPermisos.Columns[2].Visible = false;
      this.dgvPermisos.Columns.Add("Modulo", "Modulo");
      this.dgvPermisos.Columns[3].DataPropertyName = "Modulo";
      this.dgvPermisos.Columns[3].Width = 150;
      this.dgvPermisos.Columns[3].Resizable = DataGridViewTriState.False;
      this.dgvPermisos.Columns[3].ReadOnly = true;
      this.dgvPermisos.Columns[3].Visible = true;
      this.dgvPermisos.Columns.Add("Informe", "Informe");
      this.dgvPermisos.Columns[4].DataPropertyName = "Informe";
      this.dgvPermisos.Columns[4].Width = 550;
      this.dgvPermisos.Columns[4].Resizable = DataGridViewTriState.False;
      this.dgvPermisos.Columns[4].ReadOnly = true;
      this.dgvPermisos.Columns.Add("CodigoInforme", "CodigoInforme");
      this.dgvPermisos.Columns[5].DataPropertyName = "CodigoInforme";
      this.dgvPermisos.Columns[5].Width = 100;
      this.dgvPermisos.Columns[5].Resizable = DataGridViewTriState.False;
      this.dgvPermisos.Columns[5].ReadOnly = true;
      this.dgvPermisos.Columns[5].Visible = false;
      DataGridViewCheckBoxColumn viewCheckBoxColumn = new DataGridViewCheckBoxColumn();
      viewCheckBoxColumn.Name = "Ingresar";
      viewCheckBoxColumn.HeaderText = "Ingresar";
      viewCheckBoxColumn.DataPropertyName = "Ingresar";
      viewCheckBoxColumn.Width = 70;
      viewCheckBoxColumn.DisplayIndex = 6;
      viewCheckBoxColumn.FalseValue = (object) 0;
      viewCheckBoxColumn.TrueValue = (object) 1;
      this.dgvPermisos.Columns.Add((DataGridViewColumn) viewCheckBoxColumn);
    }

    private void buscaPermisosTipousuario()
    {
      this.dgvPermisos.Columns.Clear();
      this.creaColumnasPermisos();
      this.cmbModulo.Enabled = true;
      this.cmbModulo.SelectedValue = (object) 0;
      this.dgvPermisos.DataSource = (object) null;
      this.listaInformes.Clear();
      this.listaInformesFiltro.Clear();
      this.listaInformeUsuario = new PermisoInforme().listaPermisosInforme(this.lblTipoUsuario.Text);
      this.cargaColumasSinPermiso2();
      for (int index1 = 0; index1 < this.listaInformes.Count; ++index1)
      {
        string codigoInforme = this.listaInformes[index1].CodigoInforme;
        bool flag = false;
        InformeVO informeVo = new InformeVO();
        for (int index2 = 0; index2 < this.listaInformeUsuario.Count; ++index2)
        {
          if (this.listaInformeUsuario[index2].CodigoInforme.Equals(codigoInforme))
          {
            index2 = this.listaInformeUsuario.Count;
            flag = true;
          }
        }
        if (!flag)
          this.listaInformeUsuario.Add(new InformeVO()
          {
            Modulo = this.listaInformes[index1].Modulo,
            Informe = this.listaInformes[index1].Informe,
            CodigoInforme = this.listaInformes[index1].CodigoInforme,
            Ingresar = false
          });
      }
      if (this.listaInformeUsuario.Count > 0)
      {
        for (int index = 0; index < this.listaInformeUsuario.Count; ++index)
          this.listaInformeUsuario[index].Linea = index + 1;
        this.dgvPermisos.DataSource = (object) this.listaInformeUsuario;
      }
      else
        this.cargaColumasSinPermiso();
    }

    private void cargaModulos()
    {
      List<BodegaVO> list = new List<BodegaVO>();
      list.Add(new BodegaVO()
      {
        IdBodega = 0,
        nombreBodega = "TODOS"
      });
      list.Add(new BodegaVO()
      {
        IdBodega = 1,
        nombreBodega = "FACTURA"
      });
      list.Add(new BodegaVO()
      {
        IdBodega = 2,
        nombreBodega = "FACTURA EXENTA"
      });
      list.Add(new BodegaVO()
      {
        IdBodega = 3,
        nombreBodega = "BOLETA"
      });
      list.Add(new BodegaVO()
      {
        IdBodega = 4,
        nombreBodega = "GUIA"
      });
      list.Add(new BodegaVO()
      {
        IdBodega = 5,
        nombreBodega = "NOTA CREDITO"
      });
      list.Add(new BodegaVO()
      {
        IdBodega = 6,
        nombreBodega = "COTIZACION"
      });
      list.Add(new BodegaVO()
      {
        IdBodega = 7,
        nombreBodega = "TICKET"
      });
      list.Add(new BodegaVO()
      {
        IdBodega = 8,
        nombreBodega = "NOTA VENTA"
      });
      list.Add(new BodegaVO()
      {
        IdBodega = 9,
        nombreBodega = "CONTROL CAJA"
      });
      list.Add(new BodegaVO()
      {
        IdBodega = 10,
        nombreBodega = "VENTA GENERAL"
      });
      list.Add(new BodegaVO()
      {
        IdBodega = 11,
        nombreBodega = "PAGOS VENTAS"
      });
      list.Add(new BodegaVO()
      {
        IdBodega = 12,
        nombreBodega = "COMPRAS"
      });
      list.Add(new BodegaVO()
      {
        IdBodega = 13,
        nombreBodega = "ORDEN COMPRA"
      });
      list.Add(new BodegaVO()
      {
        IdBodega = 14,
        nombreBodega = "PAGOS COMPRAS"
      });
      list.Add(new BodegaVO()
      {
        IdBodega = 15,
        nombreBodega = "INVENTARIO"
      });
      list.Add(new BodegaVO()
      {
        IdBodega = 16,
        nombreBodega = "KIT"
      });
      list.Add(new BodegaVO()
      {
        IdBodega = 17,
        nombreBodega = "ORDEN TRABAJO"
      });
      list.Add(new BodegaVO()
      {
        IdBodega = 18,
        nombreBodega = "FACTURA ELECTRONICA"
      });
      list.Add(new BodegaVO()
      {
        IdBodega = 19,
        nombreBodega = "NOTA CREDITO ELECTRONICA"
      });
      list.Add(new BodegaVO()
      {
        IdBodega = 20,
        nombreBodega = "NOTA DEBITO ELECTRONICA"
      });
      list.Add(new BodegaVO()
      {
        IdBodega = 21,
        nombreBodega = "GUIA ELECTRONICA"
      });
      list.Add(new BodegaVO()
      {
        IdBodega = 22,
        nombreBodega = "BOLETA ELECTRONICA"
      });
      list.Add(new BodegaVO()
      {
        IdBodega = 23,
        nombreBodega = "BOLETA EXENTA ELECTRONICA"
      });
      list.Sort((Comparison<BodegaVO>) ((b1, b2) => b1.nombreBodega.CompareTo(b2.nombreBodega)));
      this.cmbModulo.DataSource = (object) list;
      this.cmbModulo.ValueMember = "IdBodega";
      this.cmbModulo.DisplayMember = "nombreBodega";
      this.cmbModulo.SelectedValue = (object) 0;
    }

    private void cargaColumnasInformes()
    {
      this.dgvPermisos.DataSource = (object) null;
      this.listaInformesFiltro.Clear();
      if (this.cmbModulo.Text.Equals("COTIZACION") || this.cmbModulo.SelectedValue.ToString() == "0")
      {
        foreach (InformeVO informeVo in this.listaInformeUsuario)
        {
          if (informeVo.Modulo.Equals("COTIZACION"))
            this.listaInformesFiltro.Add(informeVo);
        }
      }
      if (this.cmbModulo.Text.Equals("FACTURA") || this.cmbModulo.SelectedValue.ToString() == "0")
      {
        foreach (InformeVO informeVo in this.listaInformeUsuario)
        {
          if (informeVo.Modulo.Equals("FACTURA"))
            this.listaInformesFiltro.Add(informeVo);
        }
      }
      if (this.cmbModulo.Text.Equals("FACTURA EXENTA") || this.cmbModulo.SelectedValue.ToString() == "0")
      {
        foreach (InformeVO informeVo in this.listaInformeUsuario)
        {
          if (informeVo.Modulo.Equals("FACTURA EXENTA"))
            this.listaInformesFiltro.Add(informeVo);
        }
      }
      if (this.cmbModulo.Text.Equals("BOLETA") || this.cmbModulo.SelectedValue.ToString() == "0")
      {
        foreach (InformeVO informeVo in this.listaInformeUsuario)
        {
          if (informeVo.Modulo.Equals("BOLETA"))
            this.listaInformesFiltro.Add(informeVo);
        }
      }
      if (this.cmbModulo.Text.Equals("GUIA") || this.cmbModulo.SelectedValue.ToString() == "0")
      {
        foreach (InformeVO informeVo in this.listaInformeUsuario)
        {
          if (informeVo.Modulo.Equals("GUIA"))
            this.listaInformesFiltro.Add(informeVo);
        }
      }
      if (this.cmbModulo.Text.Equals("NOTA CREDITO") || this.cmbModulo.SelectedValue.ToString() == "0")
      {
        foreach (InformeVO informeVo in this.listaInformeUsuario)
        {
          if (informeVo.Modulo.Equals("NOTA CREDITO"))
            this.listaInformesFiltro.Add(informeVo);
        }
      }
      if (this.cmbModulo.Text.Equals("TICKET") || this.cmbModulo.SelectedValue.ToString() == "0")
      {
        foreach (InformeVO informeVo in this.listaInformeUsuario)
        {
          if (informeVo.Modulo.Equals("TICKET"))
            this.listaInformesFiltro.Add(informeVo);
        }
      }
      if (this.cmbModulo.Text.Equals("NOTA VENTA") || this.cmbModulo.SelectedValue.ToString() == "0")
      {
        foreach (InformeVO informeVo in this.listaInformeUsuario)
        {
          if (informeVo.Modulo.Equals("NOTA VENTA"))
            this.listaInformesFiltro.Add(informeVo);
        }
      }
      if (this.cmbModulo.Text.Equals("CONTROL CAJA") || this.cmbModulo.SelectedValue.ToString() == "0")
      {
        foreach (InformeVO informeVo in this.listaInformeUsuario)
        {
          if (informeVo.Modulo.Equals("CONTROL CAJA"))
            this.listaInformesFiltro.Add(informeVo);
        }
      }
      if (this.cmbModulo.Text.Equals("VENTA GENERAL") || this.cmbModulo.SelectedValue.ToString() == "0")
      {
        foreach (InformeVO informeVo in this.listaInformeUsuario)
        {
          if (informeVo.Modulo.Equals("VENTA GENERAL"))
            this.listaInformesFiltro.Add(informeVo);
        }
      }
      if (this.cmbModulo.Text.Equals("PAGOS VENTAS") || this.cmbModulo.SelectedValue.ToString() == "0")
      {
        foreach (InformeVO informeVo in this.listaInformeUsuario)
        {
          if (informeVo.Modulo.Equals("PAGOS VENTAS"))
            this.listaInformesFiltro.Add(informeVo);
        }
      }
      if (this.cmbModulo.Text.Equals("COMPRAS") || this.cmbModulo.SelectedValue.ToString() == "0")
      {
        foreach (InformeVO informeVo in this.listaInformeUsuario)
        {
          if (informeVo.Modulo.Equals("COMPRAS"))
            this.listaInformesFiltro.Add(informeVo);
        }
      }
      if (this.cmbModulo.Text.Equals("ORDEN COMPRA") || this.cmbModulo.SelectedValue.ToString() == "0")
      {
        foreach (InformeVO informeVo in this.listaInformeUsuario)
        {
          if (informeVo.Modulo.Equals("ORDEN COMPRA"))
            this.listaInformesFiltro.Add(informeVo);
        }
      }
      if (this.cmbModulo.Text.Equals("PAGOS COMPRAS") || this.cmbModulo.SelectedValue.ToString() == "0")
      {
        foreach (InformeVO informeVo in this.listaInformeUsuario)
        {
          if (informeVo.Modulo.Equals("PAGOS COMPRAS"))
            this.listaInformesFiltro.Add(informeVo);
        }
      }
      if (this.cmbModulo.Text.Equals("INVENTARIO") || this.cmbModulo.SelectedValue.ToString() == "0")
      {
        foreach (InformeVO informeVo in this.listaInformeUsuario)
        {
          if (informeVo.Modulo.Equals("INVENTARIO"))
            this.listaInformesFiltro.Add(informeVo);
        }
      }
      if (this.cmbModulo.Text.Equals("KIT") || this.cmbModulo.SelectedValue.ToString() == "0")
      {
        foreach (InformeVO informeVo in this.listaInformeUsuario)
        {
          if (informeVo.Modulo.Equals("KIT"))
            this.listaInformesFiltro.Add(informeVo);
        }
      }
      if (this.cmbModulo.Text.Equals("ORDEN TRABAJO") || this.cmbModulo.SelectedValue.ToString() == "0")
      {
        foreach (InformeVO informeVo in this.listaInformeUsuario)
        {
          if (informeVo.Modulo.Equals("ORDEN TRABAJO"))
            this.listaInformesFiltro.Add(informeVo);
        }
      }
      if (this.cmbModulo.Text.Equals("FACTURA ELECTRONICA") || this.cmbModulo.SelectedValue.ToString() == "0")
      {
        foreach (InformeVO informeVo in this.listaInformeUsuario)
        {
          if (informeVo.Modulo.Equals("FACTURA ELECTRONICA"))
            this.listaInformesFiltro.Add(informeVo);
        }
      }
      if (this.cmbModulo.Text.Equals("FACTURA EXENTA ELECTRONICA") || this.cmbModulo.SelectedValue.ToString() == "0")
      {
        foreach (InformeVO informeVo in this.listaInformeUsuario)
        {
          if (informeVo.Modulo.Equals("FACTURA EXENTA ELECTRONICA"))
            this.listaInformesFiltro.Add(informeVo);
        }
      }
      if (this.cmbModulo.Text.Equals("NOTA CREDITO ELECTRONICA") || this.cmbModulo.SelectedValue.ToString() == "0")
      {
        foreach (InformeVO informeVo in this.listaInformeUsuario)
        {
          if (informeVo.Modulo.Equals("NOTA CREDITO ELECTRONICA"))
            this.listaInformesFiltro.Add(informeVo);
        }
      }
      if (this.cmbModulo.Text.Equals("NOTA DEBITO ELECTRONICA") || this.cmbModulo.SelectedValue.ToString() == "0")
      {
        foreach (InformeVO informeVo in this.listaInformeUsuario)
        {
          if (informeVo.Modulo.Equals("NOTA DEBITO ELECTRONICA"))
            this.listaInformesFiltro.Add(informeVo);
        }
      }
      if (this.cmbModulo.Text.Equals("GUIA ELECTRONICA") || this.cmbModulo.SelectedValue.ToString() == "0")
      {
        foreach (InformeVO informeVo in this.listaInformeUsuario)
        {
          if (informeVo.Modulo.Equals("GUIA ELECTRONICA"))
            this.listaInformesFiltro.Add(informeVo);
        }
      }
      if (this.cmbModulo.Text.Equals("BOLETA ELECTRONICA") || this.cmbModulo.SelectedValue.ToString() == "0")
      {
        foreach (InformeVO informeVo in this.listaInformeUsuario)
        {
          if (informeVo.Modulo.Equals("BOLETA ELECTRONICA"))
            this.listaInformesFiltro.Add(informeVo);
        }
      }
      if (this.cmbModulo.Text.Equals("BOLETA EXENTA ELECTRONICA") || this.cmbModulo.SelectedValue.ToString() == "0")
      {
        foreach (InformeVO informeVo in this.listaInformeUsuario)
        {
          if (informeVo.Modulo.Equals("BOLETA EXENTA ELECTRONICA"))
            this.listaInformesFiltro.Add(informeVo);
        }
      }
      for (int index = 0; index < this.listaInformesFiltro.Count; ++index)
        this.listaInformesFiltro[index].Linea = index + 1;
      this.dgvPermisos.DataSource = (object) this.listaInformesFiltro;
    }

    private void cargaColumasSinPermiso()
    {
      this.cmbModulo.Enabled = false;
      this.dgvPermisos.DataSource = (object) null;
      this.listaInformes.Clear();
      InformeVO informeVo = new InformeVO();
      if (this.cmbModulo.Text.Equals("BOLETA") || this.cmbModulo.SelectedValue.ToString() == "0")
      {
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "BOLETA",
          Informe = "LISTADO DE BOLETAS, SEGÚN FECHA",
          CodigoInforme = "BOLETA001"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "BOLETA",
          Informe = "LISTADO DE BOLETAS POR CLIENTE, SEGÚN FECHA",
          CodigoInforme = "BOLETA002"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "BOLETA",
          Informe = "LISTADO DE BOLETAS POR VENDEDOR, SEGÚN FECHA",
          CodigoInforme = "BOLETA003"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "BOLETA",
          Informe = "LISTADO DE BOLETAS POR CENTRO DE COSTO, SEGÚN FECHA",
          CodigoInforme = "BOLETA004"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "BOLETA",
          Informe = "LISTADO DE BOLETAS ANULADAS, SEGÚN FECHA",
          CodigoInforme = "BOLETA005"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "BOLETA",
          Informe = "RESUMEN DE ARTICULOS VENDIDOS CON BOLETAS, SEGÚN FECHA",
          CodigoInforme = "BOLETA006"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "BOLETA",
          Informe = "RESUMEN DE ARTICULOS VENDIDOS CON BOLETAS, SEGÚN FECHA",
          CodigoInforme = "BOLETA007"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "BOLETA",
          Informe = "LISTADO DE ARTICULOS VENDIDOS CON BOLETAS Y SU RENTABILIDAD, SEGÚN FECHA",
          CodigoInforme = "BOLETA008"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "BOLETA",
          Informe = "VISUALIZAR BOLETA",
          CodigoInforme = "BOLETA009"
        });
      }
      if (this.cmbModulo.Text.Equals("COMPRAS") || this.cmbModulo.SelectedValue.ToString() == "0")
      {
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "COMPRAS",
          Informe = "LISTADO DE COMPRAS, SEGÚN FECHA",
          CodigoInforme = "COMPRA001"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "COMPRAS",
          Informe = "LISTADO DE COMPRAS POR PROVEEDOR, SEGÚN FECHA",
          CodigoInforme = "COMPRA002"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "COMPRAS",
          Informe = "LISTADO DE COMPRAS POR CENTRO DE COSTO, SEGÚN FECHA",
          CodigoInforme = "COMPRA003"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "COMPRAS",
          Informe = "LISTADO DE FACTURAS DE COMPRAS PENDIENTES DE PAGOS, SEGÚN FECHA",
          CodigoInforme = "COMPRA004"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "COMPRAS",
          Informe = "LISTADO DE FACTURAS DE COMPRAS PENDIENTES DE PAGOS POR PROVEEDOR, SEGÚN FECHA",
          CodigoInforme = "COMPRA005"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "COMPRAS",
          Informe = "VISUALIZAR DOCUMENTO DE COMPRA, SEGÚN FECHA",
          CodigoInforme = "COMPRA006"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "COMPRAS",
          Informe = "LIBRO DE COMPRAS",
          CodigoInforme = "COMPRA007"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "COMPRAS",
          Informe = "LISTADO DE PROVEEDORES",
          CodigoInforme = "COMPRA008"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "COMPRAS",
          Informe = "LISTADO DE GASTOS DE SERVICIOS, SEGÚN FECHA",
          CodigoInforme = "SERVICIO001"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "COMPRAS",
          Informe = "LIBRO DE COMPRAS, SEGÚN PERIODO",
          CodigoInforme = "COMPRA009"
        });
      }
      if (this.cmbModulo.Text.Equals("CONTROL CAJA") || this.cmbModulo.SelectedValue.ToString() == "0")
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "CONTROL CAJA",
          Informe = "LISTADO DE MOVIMIENTOS DE CAJA, SEGÚN FECHA",
          CodigoInforme = "CONTROLCAJA001"
        });
      if (this.cmbModulo.Text.Equals("COTIZACION") || this.cmbModulo.SelectedValue.ToString() == "0")
      {
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "COTIZACION",
          Informe = "LISTADO DE COTIZACIONES, SEGÚN FECHA",
          CodigoInforme = "COTIZACION001"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "COTIZACION",
          Informe = "LISTADO DE COTIZACIONES POR CLIENTE, SEGÚN FECHA",
          CodigoInforme = "COTIZACION002"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "COTIZACION",
          Informe = "LISTADO DE COTIZACIONES POR VENDEDOR, SEGÚN FECHA",
          CodigoInforme = "COTIZACION003"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "COTIZACION",
          Informe = "DETALLE DE ARTICULOS COTIZADOS, SEGÚN FECHA",
          CodigoInforme = "COTIZACION004"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "COTIZACION",
          Informe = "VISUALIZAR COTIZACION",
          CodigoInforme = "COTIZACION005"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "COTIZACION",
          Informe = "DETALLE DE COTIZACIONES SIN FACTURAR",
          CodigoInforme = "COTIZACION006"
        });
      }
      if (this.cmbModulo.Text.Equals("FACTURA") || this.cmbModulo.SelectedValue.ToString() == "0")
      {
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "FACTURA",
          Informe = "LISTADO DE FACTURAS SEGÚN FECHA",
          CodigoInforme = "FACTURA001"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "FACTURA",
          Informe = "LISTADO DE FACTURAS POR CLIENTE, SEGÚN FECHA",
          CodigoInforme = "FACTURA002"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "FACTURA",
          Informe = "LISTADO DE FACTURAS POR VENDEDOR, SEGÚN FECHA",
          CodigoInforme = "FACTURA003"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "FACTURA",
          Informe = "LISTADO DE FACTURAS POR CENTRO DE COSTO, SEGÚN FECHA",
          CodigoInforme = "FACTURA004"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "FACTURA",
          Informe = "LISTADO DE FACTURAS PENDIENTES DE PAGO, SEGÚN FECHA",
          CodigoInforme = "FACTURA005"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "FACTURA",
          Informe = "LISTADO DE FACTURAS PENDIENTES DE PAGO, POR CLIENTE, SEGÚN FECHA",
          CodigoInforme = "FACTURA006"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "FACTURA",
          Informe = "LISTADO DE FACTURAS ANULADAS, SEGÚN FECHA",
          CodigoInforme = "FACTURA007"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "FACTURA",
          Informe = "LISTADO DE FACTURAS, SEGÚN FECHA DE VENCIMIENTO",
          CodigoInforme = "FACTURA008"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "FACTURA",
          Informe = "DETALLE DE ARTICULOS VENDIDOS CON FACTURA, SEGÚN FECHA",
          CodigoInforme = "FACTURA009"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "FACTURA",
          Informe = "DETALLE DE ARTICULOS VENDIDOS CON FACTURA, POR CLIENTE, SEGÚN FECHA",
          CodigoInforme = "FACTURA010"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "FACTURA",
          Informe = "RESUMEN DE ARTICULOS VENDIDOS CON FACTURA, SEGÚN FECHA",
          CodigoInforme = "FACTURA011"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "FACTURA",
          Informe = "RESUMEN DE ARTICULOS VENDIDOS CON FACTURA, POR CLIENTE, SEGÚN FECHA",
          CodigoInforme = "FACTURA012"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "FACTURA",
          Informe = "LISTADO DE ARTICULOS VENDIDOS CON FACTURA Y SU RENTABILIDAD, SEGÚN FECHA",
          CodigoInforme = "FACTURA013"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "FACTURA",
          Informe = "VISUALIZAR FACTURA",
          CodigoInforme = "FACTURA014"
        });
      }
      if (this.cmbModulo.Text.Equals("FACTURA EXENTA") || this.cmbModulo.SelectedValue.ToString() == "0")
      {
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "FACTURA EXENTA",
          Informe = "LISTADO DE FACTURAS EXENTAS,  SEGÚN FECHA",
          CodigoInforme = "FACTURAEXENTA001"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "FACTURA EXENTA",
          Informe = "LISTADO DE FACTURAS EXENTAS POR CLIENTE,  SEGÚN FECHA",
          CodigoInforme = "FACTURAEXENTA002"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "FACTURA EXENTA",
          Informe = "LISTADO DE FACTURAS EXENTAS POR VENDEDOR,  SEGÚN FECHA",
          CodigoInforme = "FACTURAEXENTA003"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "FACTURA EXENTA",
          Informe = "LISTADO DE FACTURAS EXENTAS PENDIENTES DE PAGOS,  SEGÚN FECHA",
          CodigoInforme = "FACTURAEXENTA004"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "FACTURA EXENTA",
          Informe = "LISTADO DE FACTURAS EXENTAS PENDIENTES DE PAGOS POR CLIENTES,  SEGÚN FECHA",
          CodigoInforme = "FACTURAEXENTA005"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "FACTURA EXENTA",
          Informe = "DETALLE DE ARTICULOS VENDIDOS CON FACTURAS EXENTAS, SEGÚN FECHA",
          CodigoInforme = "FACTURAEXENTA006"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "FACTURA EXENTA",
          Informe = "RESUMEN DE ARTICULOS VENDIDOS CON FACTURAS EXENTAS, SEGÚN FECHA",
          CodigoInforme = "FACTURAEXENTA007"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "FACTURA EXENTA",
          Informe = "VISUALIZAR FACTURA EXENTA",
          CodigoInforme = "FACTURAEXENTA008"
        });
      }
      if (this.cmbModulo.Text.Equals("GUIA") || this.cmbModulo.SelectedValue.ToString() == "0")
      {
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "GUIA",
          Informe = "LISTADO DE GUIAS, SEGÚN FECHA",
          CodigoInforme = "GUIA001"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "GUIA",
          Informe = "LISTADO DE GUIAS POR CLIENTES, SEGÚN FECHA",
          CodigoInforme = "GUIA002"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "GUIA",
          Informe = "LISTADO DE GUIAS POR VENDEDOR, SEGÚN FECHA",
          CodigoInforme = "GUIA003"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "GUIA",
          Informe = "LISTADO DE GUIAS POR CENTRO DE COSTO, SEGÚN FECHA",
          CodigoInforme = "GUIA004"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "GUIA",
          Informe = "LISTADO DE GUIAS ANULADAS, SEGÚN FECHA",
          CodigoInforme = "GUIA005"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "GUIA",
          Informe = "LISTADO DE GUIAS NO FACTURADAS, SEGÚN FECHA",
          CodigoInforme = "GUIA006"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "GUIA",
          Informe = "LISTADO DE GUIAS NO FACTURADAS POR CLIENTE, SEGÚN FECHA",
          CodigoInforme = "GUIA007"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "GUIA",
          Informe = "DETALLE DE ARTICULOS VENDIDOS CON GUIAS, SEGÚN FECHA",
          CodigoInforme = "GUIA008"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "GUIA",
          Informe = "VISUALIZAR GUIA",
          CodigoInforme = "GUIA009"
        });
      }
      if (this.cmbModulo.Text.Equals("INVENTARIO") || this.cmbModulo.SelectedValue.ToString() == "0")
      {
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "INVENTARIO",
          Informe = "EXISTENCIAS POR BODEGA",
          CodigoInforme = "INVENTARIO001"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "INVENTARIO",
          Informe = "LISTADO GENERAL DE PRECIOS",
          CodigoInforme = "INVENTARIO012"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "INVENTARIO",
          Informe = "LISTADO GENERAL DE PRECIOS Y SU RENTABILIDAD",
          CodigoInforme = "INVENTARIO013"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "INVENTARIO",
          Informe = "LISTADO DE ARTICULOS BAJO STOCK MINIMO",
          CodigoInforme = "INVENTARIO014"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "INVENTARIO",
          Informe = "LISTADO DE ARTICULOS PARA TOMA DE INVENTARIO",
          CodigoInforme = "INVENTARIO025"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "INVENTARIO",
          Informe = "MOVIMIENTO DE PRODUCTOS",
          CodigoInforme = "MOVIMIENTO001"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "INVENTARIO",
          Informe = "RANKING DE PRODUCTOS MAS VENDIDOS",
          CodigoInforme = "MOVIMIENTO002"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "INVENTARIO",
          Informe = "DETALLE DE VENTAS POR PRODUCTO",
          CodigoInforme = "MOVIMIENTO003"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "INVENTARIO",
          Informe = "DETALLE DE COMPRAS POR PRODUCTO",
          CodigoInforme = "MOVIMIENTO004"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "INVENTARIO",
          Informe = "DETALLE DE COMPRAS POR PROVEEDOR",
          CodigoInforme = "MOVIMIENTO005"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "INVENTARIO",
          Informe = "KARDEX POR PRODUCTO",
          CodigoInforme = "MOVIMIENTO009"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "INVENTARIO",
          Informe = "ENTRADA DE PRODUCTOS A BODEGA",
          CodigoInforme = "MOVIMIENTO010"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "INVENTARIO",
          Informe = "LISTADO DE TRASPASOS, SEGÚN FECHA",
          CodigoInforme = "TraspasoInterno001"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "INVENTARIO",
          Informe = "DETALLE DE TRASPASOS, SEGÚN FECHA",
          CodigoInforme = "TraspasoInterno002"
        });
      }
      if (this.cmbModulo.Text.Equals("CONTROL CAJA") || this.cmbModulo.SelectedValue.ToString() == "0")
      {
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "KIT",
          Informe = "VISUALIZAR FORMULA DE KIT",
          CodigoInforme = "KIT001"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "KIT",
          Informe = "DETALLE DE KIT ARMADOS, SEGÚN FECHA",
          CodigoInforme = "KIT002"
        });
      }
      if (this.cmbModulo.Text.Equals("NOTA CREDITO") || this.cmbModulo.SelectedValue.ToString() == "0")
      {
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "NOTA CREDITO",
          Informe = "LISTADO DE NOTAS DE CREDITO, SEGÚN FECHA",
          CodigoInforme = "NOTACREDITO001"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "NOTA CREDITO",
          Informe = "LISTADO DE NOTAS DE CREDITO POR CLIENTE, SEGÚN FECHA",
          CodigoInforme = "NOTACREDITO002"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "NOTA CREDITO",
          Informe = "LISTADO DE NOTAS DE CREDITO POR VENDEDOR, SEGÚN FECHA",
          CodigoInforme = "NOTACREDITO003"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "NOTA CREDITO",
          Informe = "LISTADO DE NOTAS DE CREDITO POR CENTRO DE COSTO, SEGÚN FECHA",
          CodigoInforme = "NOTACREDITO004"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "NOTA CREDITO",
          Informe = "VISUALIZAR NOTA DE CREDITO",
          CodigoInforme = "NOTACREDITO005"
        });
      }
      if (this.cmbModulo.Text.Equals("NOTA CREDITO") || this.cmbModulo.SelectedValue.ToString() == "0")
      {
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "NOTA VENTA",
          Informe = "LISTADO DE NOTAS DE VENTA, SEGÚN FECHA",
          CodigoInforme = "NOTAVENTA001"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "NOTA VENTA",
          Informe = "LISTADO DE NOTAS DE VENTA POR CLIENTE, SEGÚN FECHA",
          CodigoInforme = "NOTAVENTA002"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "NOTA VENTA",
          Informe = "LISTADO DE NOTAS DE VENTA POR VENDEDOR, SEGÚN FECHA",
          CodigoInforme = "NOTAVENTA003"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "NOTA VENTA",
          Informe = "LISTADO DE NOTAS DE VENTA POR CENTRO DE COSTO, SEGÚN FECHA",
          CodigoInforme = "NOTAVENTA004"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "NOTA VENTA",
          Informe = "LISTADO DE NOTAS DE VENTA ANULADAS, SEGÚN FECHA",
          CodigoInforme = "NOTAVENTA005"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "NOTA VENTA",
          Informe = "LISTADO DE NOTAS DE VENTA NO FACTURADAS, SEGÚN FECHA",
          CodigoInforme = "NOTAVENTA006"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "NOTA VENTA",
          Informe = "LISTADO DE NOTAS DE VENTA NO FACTURADAS POR CLIENTE, SEGÚN FECHA",
          CodigoInforme = "NOTAVENTA007"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "NOTA VENTA",
          Informe = "DETALLE DE ARTICULOS VENDIDOS CON NOTA DE VENTA, SEGÚN FECHA",
          CodigoInforme = "NOTAVENTA008"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "NOTA VENTA",
          Informe = "RESUMEN DE ARTICULOS VENDIDOS CON NOTA DE VENTA, SEGÚN FECHA",
          CodigoInforme = "NOTAVENTA009"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "NOTA VENTA",
          Informe = "RESUMEN DE ARTICULOS VENDIDOS CON NOTA DE VENTA POR CLIENTE, SEGÚN FECHA",
          CodigoInforme = "NOTAVENTA010"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "NOTA VENTA",
          Informe = "VISUALIZAR NOTA DE VENTA",
          CodigoInforme = "NOTAVENTA011"
        });
      }
      if (this.cmbModulo.Text.Equals("ORDEN COMPRA") || this.cmbModulo.SelectedValue.ToString() == "0")
      {
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "ORDEN COMPRA",
          Informe = "LISTADO DE ORDENES DE COMPRA, SEGÚN FECHA",
          CodigoInforme = "ORDENCOMP001"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "ORDEN COMPRA",
          Informe = "LISTADO DE ORDENES DE COMPRA POR PROVEEDOR, SEGÚN FECHA",
          CodigoInforme = "ORDENCOMP002"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "ORDEN COMPRA",
          Informe = "LISTADO DE ORDENES DE COMPRA POR CENTRO DE COSTO, SEGÚN FECHA",
          CodigoInforme = "ORDENCOMP003"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "ORDEN COMPRA",
          Informe = "VISUALIZAR ORDEN DE COMPRA",
          CodigoInforme = "ORDENCOMP004"
        });
      }
      if (this.cmbModulo.Text.Equals("PAGOS COMPRAS") || this.cmbModulo.SelectedValue.ToString() == "0")
      {
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "PAGOS COMPRAS",
          Informe = "DOCUMENTOS POR PAGAR, SEGÚN FECHA",
          CodigoInforme = "PAGOCOMPRA001"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "PAGOS COMPRAS",
          Informe = "DETALLE DE PAGOS DE COMPRA, SEGÚN FECHA",
          CodigoInforme = "PAGOCOMPRA002"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "PAGOS COMPRAS",
          Informe = "DETALLE DE PAGOS DE COMPRA POR PROVEEDOR, SEGÚN FECHA",
          CodigoInforme = "PAGOCOMPRA003"
        });
      }
      if (this.cmbModulo.Text.Equals("PAGOS VENTAS") || this.cmbModulo.SelectedValue.ToString() == "0")
      {
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "PAGOS VENTAS",
          Informe = "DOCUMENTOS DE VENTA POR COBRAR, SEGÚN FECHA",
          CodigoInforme = "PAGOVENTA001"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "PAGOS VENTAS",
          Informe = "DETALLE DE PAGOS DE VENTAS, SEGÚN FECHA DE COBRO",
          CodigoInforme = "PAGOVENTA002"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "PAGOS VENTAS",
          Informe = "DETALLE DE PAGOS DE VENTAS POR CLIENTE, SEGÚN FECHA DE COBRO",
          CodigoInforme = "PAGOVENTA003"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "PAGOS VENTAS",
          Informe = "DETALLE DE CLIENTES MOROSOS",
          CodigoInforme = "PAGOVENTA004"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "PAGOS VENTAS",
          Informe = "LISTADO DE VENTAS POR ESTADO DE DOCUMENTO, SEGÚN FECHA",
          CodigoInforme = "PAGOVENTA005"
        });
      }
      if (this.cmbModulo.Text.Equals("TICKET") || this.cmbModulo.SelectedValue.ToString() == "0")
      {
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "TICKET",
          Informe = "LISTADO DE TICKETS, SEGÚN FECHA",
          CodigoInforme = "TICKET001"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "TICKET",
          Informe = "LISTADO DE TICKETS POR VENDEDOR, SEGÚN FECHA",
          CodigoInforme = "TICKET002"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "TICKET",
          Informe = "LISTADO DE TICKETS POR CLIENTE, SEGÚN FECHA",
          CodigoInforme = "TICKET003"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "TICKET",
          Informe = "LISTADO DE TICKETS ANULADOS, SEGÚN FECHA",
          CodigoInforme = "TICKET004"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "TICKET",
          Informe = "VISUALIZAR TICKET",
          CodigoInforme = "TICKET005"
        });
      }
      if (this.cmbModulo.Text.Equals("VENTA GENERAL") || this.cmbModulo.SelectedValue.ToString() == "0")
      {
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "VENTA GENERAL",
          Informe = "RESUMEN DE VENTAS DIARIAS",
          CodigoInforme = "VENTA001"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "VENTA GENERAL",
          Informe = "LIBRO DE VENTAS",
          CodigoInforme = "VENTA002"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "VENTA GENERAL",
          Informe = "LIBRO DE VENTAS CON BOLETAS",
          CodigoInforme = "VENTA003"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "VENTA GENERAL",
          Informe = "LISTADO DE CLIENTES",
          CodigoInforme = "VENTA004"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "VENTA GENERAL",
          Informe = "LISTADO DE ARTICULOS VENDIDOS CON FACTURA Y BOLETAS Y SU RENTABILIDAD, SEGÚN FECHA",
          CodigoInforme = "VENTA005"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "VENTA GENERAL",
          Informe = "RESUMEN DE ARTICULOS VENDIDOS CON FACTURAS Y BOLETAS AGRUPADOS POR CATEGORIA, SEGÚN FECHA",
          CodigoInforme = "VENTA006"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "VENTA GENERAL",
          Informe = "LISTADO DE FACTURAS Y BOLETAS POR VENDEDOR, SEGÚN FECHA",
          CodigoInforme = "VENTA007"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "VENTA GENERAL",
          Informe = "LISTADO DE DOCUMENTOS DE VENTA PENDIENTES DE PAGO, SEGÚN FECHA",
          CodigoInforme = "VENTA010"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "VENTA GENERAL",
          Informe = "RESUMEN DE VENTAS, SEGÚN FECHA",
          CodigoInforme = "VENTA011"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "VENTA GENERAL",
          Informe = "DETALLE DE COMISIONES POR VENDEDOR, SEGUN FECHA",
          CodigoInforme = "VENTA013"
        });
      }
      if (this.cmbModulo.Text.Equals("ORDEN TRABAJO") || this.cmbModulo.SelectedValue.ToString() == "0")
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "ORDEN TRABAJO",
          Informe = "LISTADO DE OT, SEGÚN FECHA",
          CodigoInforme = "ORDENTRABAJO001"
        });
      if (this.cmbModulo.Text.Equals("FACTURA") || this.cmbModulo.SelectedValue.ToString() == "0")
      {
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "FACTURA ELECTRONICA",
          Informe = "LISTADO DE FACTURAS ELECTRONICA SEGÚN FECHA",
          CodigoInforme = "FACTURAELECTRONICA001"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "FACTURA ELECTRONICA",
          Informe = "LISTADO DE FACTURAS ELECTRONICAS POR CLIENTE, SEGÚN FECHA",
          CodigoInforme = "FACTURAELECTRONICA002"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "FACTURA ELECTRONICA",
          Informe = "LISTADO DE FACTURAS ELECTRONICAS POR VENDEDOR, SEGÚN FECHA",
          CodigoInforme = "FACTURAELECTRONICA003"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "FACTURA ELECTRONICA",
          Informe = "LISTADO DE FACTURAS ELECTRONICAS POR CENTRO DE COSTO, SEGÚN FECHA",
          CodigoInforme = "FACTURAELECTRONICA004"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "FACTURA ELECTRONICA",
          Informe = "LISTADO DE FACTURAS ELECTRONICA PENDIENTES DE PAGO, SEGÚN FECHA",
          CodigoInforme = "FACTURAELECTRONICA005"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "FACTURA ELECTRONICA",
          Informe = "LISTADO DE PRODUCTOS VENDIDOS POR FECHA, AGRUPADOS POR CATEGORIA",
          CodigoInforme = "FACTURAELECTRONICA006"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "FACTURA ELECTRONICA",
          Informe = "VISUALIZAR FACTURA ELECTRONICA",
          CodigoInforme = "FACTURAELECTRONICA014"
        });
      }
      if (this.cmbModulo.Text.Equals("FACTURA EXENTA ELECTRONICA") || this.cmbModulo.SelectedValue.ToString() == "0")
      {
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "FACTURA EXENTA ELECTRONICA",
          Informe = "LISTADO DE FACTURAS EXENTAS ELECTRONICA SEGÚN FECHA",
          CodigoInforme = "FACTURAEXENTAELECTRONICA001"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "FACTURA EXENTA ELECTRONICA",
          Informe = "LISTADO DE FACTURAS EXENTAS ELECTRONICAS POR CLIENTE, SEGÚN FECHA",
          CodigoInforme = "FACTURAEXENTAELECTRONICA002"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "FACTURA EXENTA ELECTRONICA",
          Informe = "LISTADO DE FACTURAS EXENTAS ELECTRONICAS POR VENDEDOR, SEGÚN FECHA",
          CodigoInforme = "FACTURAEXENTAELECTRONICA003"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "FACTURA EXENTA ELECTRONICA",
          Informe = "LISTADO DE FACTURAS EXENTAS ELECTRONICAS POR CENTRO DE COSTO, SEGÚN FECHA",
          CodigoInforme = "FACTURAEXENTAELECTRONICA004"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "FACTURA EXENTA ELECTRONICA",
          Informe = "LISTADO DE FACTURAS EXENTAS ELECTRONICA PENDIENTES DE PAGO, SEGÚN FECHA",
          CodigoInforme = "FACTURAEXENTAELECTRONICA005"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "FACTURA EXENTA ELECTRONICA",
          Informe = "LISTADO DE PRODUCTOS VENDIDOS POR FECHA, AGRUPADOS POR CATEGORIA",
          CodigoInforme = "FACTURAEXENTAELECTRONICA006"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "FACTURA EXENTA ELECTRONICA",
          Informe = "VISUALIZAR FACTURA EXENTA ELECTRONICA",
          CodigoInforme = "FACTURAEXENTAELECTRONICA014"
        });
      }
      if (this.cmbModulo.Text.Equals("NOTA CREDITO") || this.cmbModulo.SelectedValue.ToString() == "0")
      {
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "NOTA CREDITO ELECTRONICA",
          Informe = "LISTADO DE NOTAS CREDITO ELECTRONICAS SEGÚN FECHA",
          CodigoInforme = "NOTACREDITOELECTRONICA001"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "NOTA CREDITO ELECTRONICA",
          Informe = "LISTADO DE NOTAS CREDITO ELECTRONICAS POR CLIENTE, SEGÚN FECHA",
          CodigoInforme = "NOTACREDITOELECTRONICA002"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "NOTA CREDITO ELECTRONICA",
          Informe = "LISTADO DE NOTAS CREDITO ELECTRONICAS POR VENDEDOR, SEGÚN FECHA",
          CodigoInforme = "NOTACREDITOELECTRONICA003"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "NOTA CREDITO ELECTRONICA",
          Informe = "LISTADO DE NOTAS CREDITO ELECTRONICAS POR CENTRO DE COSTO, SEGÚN FECHA",
          CodigoInforme = "NOTACREDITOELECTRONICA004"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "NOTA CREDITO ELECTRONICA",
          Informe = "VISUALIZAR NOTA CREDITO ELECTRONICA",
          CodigoInforme = "NOTACREDITOELECTRONICA005"
        });
      }
      if (this.cmbModulo.Text.Equals("NOTA DEBITO") || this.cmbModulo.SelectedValue.ToString() == "0")
      {
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "NOTA DEBITO ELECTRONICA",
          Informe = "LISTADO DE NOTAS DEBITO ELECTRONICAS SEGÚN FECHA",
          CodigoInforme = "NOTADEBITOELECTRONICA001"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "NOTA DEBITO ELECTRONICA",
          Informe = "LISTADO DE NOTAS DEBITO ELECTRONICAS POR CLIENTE, SEGÚN FECHA",
          CodigoInforme = "NOTADEBITOELECTRONICA002"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "NOTA DEBITO ELECTRONICA",
          Informe = "LISTADO DE NOTAS DEBITO ELECTRONICAS POR VENDEDOR, SEGÚN FECHA",
          CodigoInforme = "NOTADEBITOELECTRONICA003"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "NOTA DEBITO ELECTRONICA",
          Informe = "LISTADO DE NOTAS DEBITO ELECTRONICAS POR CENTRO DE COSTO, SEGÚN FECHA",
          CodigoInforme = "NOTADEBITOELECTRONICA004"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "NOTA DEBITO ELECTRONICA",
          Informe = "VISUALIZAR NOTA DEBITO ELECTRONICA",
          CodigoInforme = "NOTADEBITOELECTRONICA005"
        });
      }
      if (this.cmbModulo.Text.Equals("GUIA ELECTRONICA") || this.cmbModulo.SelectedValue.ToString() == "0")
      {
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "GUIA ELECTRONICA",
          Informe = "LISTADO DE GUIAS ELECTRONICA SEGÚN FECHA",
          CodigoInforme = "GUIAELECTRONICA001"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "GUIA ELECTRONICA",
          Informe = "LISTADO DE GUIAS ELECTRONICAS POR CLIENTE, SEGÚN FECHA",
          CodigoInforme = "GUIAELECTRONICA002"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "GUIA ELECTRONICA",
          Informe = "LISTADO DE GUIAS ELECTRONICAS POR VENDEDOR, SEGÚN FECHA",
          CodigoInforme = "GUIAELECTRONICA003"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "GUIA ELECTRONICA",
          Informe = "LISTADO DE GUIAS ELECTRONICAS POR CENTRO DE COSTO, SEGÚN FECHA",
          CodigoInforme = "GUIAELECTRONICA004"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "GUIA ELECTRONICA",
          Informe = "GUIAS ELECTRONICAS NO FACTURADAS",
          CodigoInforme = "GUIAELECTRONICA005"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "GUIA ELECTRONICA",
          Informe = "VISUALIZAR GUIAS ELECTRONICA",
          CodigoInforme = "GUIAELECTRONICA014"
        });
      }
      if (this.cmbModulo.Text.Equals("BOLETA ELECTRONICA") || this.cmbModulo.SelectedValue.ToString() == "0")
      {
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "BOLETA ELECTRONICA",
          Informe = "LISTADO DE BOLETAS, SEGÚN FECHA",
          CodigoInforme = "BOLETAELECTRONICA001"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "BOLETA ELECTRONICA",
          Informe = "LISTADO DE BOLETAS POR CLIENTE, SEGÚN FECHA",
          CodigoInforme = "BOLETAELECTRONICA002"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "BOLETA ELECTRONICA",
          Informe = "LISTADO DE BOLETAS POR VENDEDOR, SEGÚN FECHA",
          CodigoInforme = "BOLETAELECTRONICA003"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "BOLETA ELECTRONICA",
          Informe = "LISTADO DE BOLETAS POR CENTRO DE COSTO, SEGÚN FECHA",
          CodigoInforme = "BOLETAELECTRONICA004"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "BOLETA ELECTRONICA",
          Informe = "LISTADO DE BOLETAS ANULADAS, SEGÚN FECHA",
          CodigoInforme = "BOLETAELECTRONICA005"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "BOLETA ELECTRONICA",
          Informe = "RESUMEN DE ARTICULOS VENDIDOS CON BOLETAS, SEGÚN FECHA",
          CodigoInforme = "BOLETAELECTRONICA006"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "BOLETA ELECTRONICA",
          Informe = "RESUMEN DE ARTICULOS VENDIDOS CON BOLETAS, SEGÚN FECHA",
          CodigoInforme = "BOLETAELECTRONICA007"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "BOLETA ELECTRONICA",
          Informe = "LISTADO DE ARTICULOS VENDIDOS CON BOLETAS Y SU RENTABILIDAD, SEGÚN FECHA",
          CodigoInforme = "BOLETAELECTRONICA008"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "BOLETA ELECTRONICA",
          Informe = "VISUALIZAR BOLETA",
          CodigoInforme = "BOLETAELECTRONICA009"
        });
      }
      if (this.cmbModulo.Text.Equals("BOLETA ELECTRONICA") || this.cmbModulo.SelectedValue.ToString() == "0")
      {
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "BOLETA EXENTA ELECTRONICA",
          Informe = "LISTADO DE BOLETAS, SEGÚN FECHA",
          CodigoInforme = "BOLETAEXENTAELECTRONICA001"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "BOLETA EXENTA ELECTRONICA",
          Informe = "LISTADO DE BOLETAS POR CLIENTE, SEGÚN FECHA",
          CodigoInforme = "BOLETAEXENTAELECTRONICA002"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "BOLETA EXENTA ELECTRONICA",
          Informe = "LISTADO DE BOLETAS POR VENDEDOR, SEGÚN FECHA",
          CodigoInforme = "BOLETAEXENTAELECTRONICA003"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "BOLETA EXENTA ELECTRONICA",
          Informe = "LISTADO DE BOLETAS POR CENTRO DE COSTO, SEGÚN FECHA",
          CodigoInforme = "BOLETAEXENTAELECTRONICA004"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "BOLETA EXENTA ELECTRONICA",
          Informe = "LISTADO DE BOLETAS ANULADAS, SEGÚN FECHA",
          CodigoInforme = "BOLETAEXENTAELECTRONICA005"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "BOLETA EXENTA ELECTRONICA",
          Informe = "RESUMEN DE ARTICULOS VENDIDOS CON BOLETAS, SEGÚN FECHA",
          CodigoInforme = "BOLETAEXENTAELECTRONICA006"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "BOLETA EXENTA ELECTRONICA",
          Informe = "RESUMEN DE ARTICULOS VENDIDOS CON BOLETAS, SEGÚN FECHA",
          CodigoInforme = "BOLETAEXENTAELECTRONICA007"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "BOLETA EXENTA ELECTRONICA",
          Informe = "LISTADO DE ARTICULOS VENDIDOS CON BOLETAS Y SU RENTABILIDAD, SEGÚN FECHA",
          CodigoInforme = "BOLETAEXENTAELECTRONICA008"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "BOLETA EXENTA ELECTRONICA",
          Informe = "VISUALIZAR BOLETA",
          CodigoInforme = "BOLETAEXENTAELECTRONICA009"
        });
      }
      for (int index = 0; index < this.listaInformes.Count; ++index)
        this.listaInformes[index].Linea = index + 1;
      this.dgvPermisos.DataSource = (object) this.listaInformes;
    }

    private void cargaColumasSinPermiso2()
    {
      this.listaInformes.Clear();
      InformeVO informeVo = new InformeVO();
      if (this.cmbModulo.Text.Equals("BOLETA") || this.cmbModulo.SelectedValue.ToString() == "0")
      {
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "BOLETA",
          Informe = "LISTADO DE BOLETAS, SEGÚN FECHA",
          CodigoInforme = "BOLETA001"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "BOLETA",
          Informe = "LISTADO DE BOLETAS POR CLIENTE, SEGÚN FECHA",
          CodigoInforme = "BOLETA002"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "BOLETA",
          Informe = "LISTADO DE BOLETAS POR VENDEDOR, SEGÚN FECHA",
          CodigoInforme = "BOLETA003"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "BOLETA",
          Informe = "LISTADO DE BOLETAS POR CENTRO DE COSTO, SEGÚN FECHA",
          CodigoInforme = "BOLETA004"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "BOLETA",
          Informe = "LISTADO DE BOLETAS ANULADAS, SEGÚN FECHA",
          CodigoInforme = "BOLETA005"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "BOLETA",
          Informe = "RESUMEN DE ARTICULOS VENDIDOS CON BOLETAS, SEGÚN FECHA",
          CodigoInforme = "BOLETA006"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "BOLETA",
          Informe = "RESUMEN DE ARTICULOS VENDIDOS CON BOLETAS, SEGÚN FECHA",
          CodigoInforme = "BOLETA007"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "BOLETA",
          Informe = "LISTADO DE ARTICULOS VENDIDOS CON BOLETAS Y SU RENTABILIDAD, SEGÚN FECHA",
          CodigoInforme = "BOLETA008"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "BOLETA",
          Informe = "VISUALIZAR BOLETA",
          CodigoInforme = "BOLETA009"
        });
      }
      if (this.cmbModulo.Text.Equals("COMPRAS") || this.cmbModulo.SelectedValue.ToString() == "0")
      {
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "COMPRAS",
          Informe = "LISTADO DE COMPRAS, SEGÚN FECHA",
          CodigoInforme = "COMPRA001"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "COMPRAS",
          Informe = "LISTADO DE COMPRAS POR PROVEEDOR, SEGÚN FECHA",
          CodigoInforme = "COMPRA002"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "COMPRAS",
          Informe = "LISTADO DE COMPRAS POR CENTRO DE COSTO, SEGÚN FECHA",
          CodigoInforme = "COMPRA003"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "COMPRAS",
          Informe = "LISTADO DE FACTURAS DE COMPRAS PENDIENTES DE PAGOS, SEGÚN FECHA",
          CodigoInforme = "COMPRA004"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "COMPRAS",
          Informe = "LISTADO DE FACTURAS DE COMPRAS PENDIENTES DE PAGOS POR PROVEEDOR, SEGÚN FECHA",
          CodigoInforme = "COMPRA005"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "COMPRAS",
          Informe = "VISUALIZAR DOCUMENTO DE COMPRA, SEGÚN FECHA",
          CodigoInforme = "COMPRA006"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "COMPRAS",
          Informe = "LIBRO DE COMPRAS",
          CodigoInforme = "COMPRA007"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "COMPRAS",
          Informe = "LISTADO DE PROVEEDORES",
          CodigoInforme = "COMPRA008"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "COMPRAS",
          Informe = "LISTADO DE GASTOS DE SERVICIOS, SEGÚN FECHA",
          CodigoInforme = "SERVICIO001"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "COMPRAS",
          Informe = "LIBRO DE COMPRAS, SEGÚN PERIODO",
          CodigoInforme = "COMPRA009"
        });
      }
      if (this.cmbModulo.Text.Equals("CONTROL CAJA") || this.cmbModulo.SelectedValue.ToString() == "0")
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "CONTROL CAJA",
          Informe = "LISTADO DE MOVIMIENTOS DE CAJA, SEGÚN FECHA",
          CodigoInforme = "CONTROLCAJA001"
        });
      if (this.cmbModulo.Text.Equals("COTIZACION") || this.cmbModulo.SelectedValue.ToString() == "0")
      {
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "COTIZACION",
          Informe = "LISTADO DE COTIZACIONES, SEGÚN FECHA",
          CodigoInforme = "COTIZACION001"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "COTIZACION",
          Informe = "LISTADO DE COTIZACIONES POR CLIENTE, SEGÚN FECHA",
          CodigoInforme = "COTIZACION002"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "COTIZACION",
          Informe = "LISTADO DE COTIZACIONES POR VENDEDOR, SEGÚN FECHA",
          CodigoInforme = "COTIZACION003"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "COTIZACION",
          Informe = "DETALLE DE ARTICULOS COTIZADOS, SEGÚN FECHA",
          CodigoInforme = "COTIZACION004"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "COTIZACION",
          Informe = "VISUALIZAR COTIZACION",
          CodigoInforme = "COTIZACION005"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "COTIZACION",
          Informe = "DETALLE DE COTIZACIONES SIN FACTURAR",
          CodigoInforme = "COTIZACION006"
        });
      }
      if (this.cmbModulo.Text.Equals("FACTURA") || this.cmbModulo.SelectedValue.ToString() == "0")
      {
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "FACTURA",
          Informe = "LISTADO DE FACTURAS SEGÚN FECHA",
          CodigoInforme = "FACTURA001"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "FACTURA",
          Informe = "LISTADO DE FACTURAS POR CLIENTE, SEGÚN FECHA",
          CodigoInforme = "FACTURA002"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "FACTURA",
          Informe = "LISTADO DE FACTURAS POR VENDEDOR, SEGÚN FECHA",
          CodigoInforme = "FACTURA003"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "FACTURA",
          Informe = "LISTADO DE FACTURAS POR CENTRO DE COSTO, SEGÚN FECHA",
          CodigoInforme = "FACTURA004"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "FACTURA",
          Informe = "LISTADO DE FACTURAS PENDIENTES DE PAGO, SEGÚN FECHA",
          CodigoInforme = "FACTURA005"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "FACTURA",
          Informe = "LISTADO DE FACTURAS PENDIENTES DE PAGO, POR CLIENTE, SEGÚN FECHA",
          CodigoInforme = "FACTURA006"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "FACTURA",
          Informe = "LISTADO DE FACTURAS ANULADAS, SEGÚN FECHA",
          CodigoInforme = "FACTURA007"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "FACTURA",
          Informe = "LISTADO DE FACTURAS, SEGÚN FECHA DE VENCIMIENTO",
          CodigoInforme = "FACTURA008"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "FACTURA",
          Informe = "DETALLE DE ARTICULOS VENDIDOS CON FACTURA, SEGÚN FECHA",
          CodigoInforme = "FACTURA009"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "FACTURA",
          Informe = "DETALLE DE ARTICULOS VENDIDOS CON FACTURA, POR CLIENTE, SEGÚN FECHA",
          CodigoInforme = "FACTURA010"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "FACTURA",
          Informe = "RESUMEN DE ARTICULOS VENDIDOS CON FACTURA, SEGÚN FECHA",
          CodigoInforme = "FACTURA011"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "FACTURA",
          Informe = "RESUMEN DE ARTICULOS VENDIDOS CON FACTURA, POR CLIENTE, SEGÚN FECHA",
          CodigoInforme = "FACTURA012"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "FACTURA",
          Informe = "LISTADO DE ARTICULOS VENDIDOS CON FACTURA Y SU RENTABILIDAD, SEGÚN FECHA",
          CodigoInforme = "FACTURA013"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "FACTURA",
          Informe = "VISUALIZAR FACTURA",
          CodigoInforme = "FACTURA014"
        });
      }
      if (this.cmbModulo.Text.Equals("FACTURA EXENTA") || this.cmbModulo.SelectedValue.ToString() == "0")
      {
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "FACTURA EXENTA",
          Informe = "LISTADO DE FACTURAS EXENTAS,  SEGÚN FECHA",
          CodigoInforme = "FACTURAEXENTA001"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "FACTURA EXENTA",
          Informe = "LISTADO DE FACTURAS EXENTAS POR CLIENTE,  SEGÚN FECHA",
          CodigoInforme = "FACTURAEXENTA002"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "FACTURA EXENTA",
          Informe = "LISTADO DE FACTURAS EXENTAS POR VENDEDOR,  SEGÚN FECHA",
          CodigoInforme = "FACTURAEXENTA003"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "FACTURA EXENTA",
          Informe = "LISTADO DE FACTURAS EXENTAS PENDIENTES DE PAGOS,  SEGÚN FECHA",
          CodigoInforme = "FACTURAEXENTA004"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "FACTURA EXENTA",
          Informe = "LISTADO DE FACTURAS EXENTAS PENDIENTES DE PAGOS POR CLIENTES,  SEGÚN FECHA",
          CodigoInforme = "FACTURAEXENTA005"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "FACTURA EXENTA",
          Informe = "DETALLE DE ARTICULOS VENDIDOS CON FACTURAS EXENTAS, SEGÚN FECHA",
          CodigoInforme = "FACTURAEXENTA006"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "FACTURA EXENTA",
          Informe = "RESUMEN DE ARTICULOS VENDIDOS CON FACTURAS EXENTAS, SEGÚN FECHA",
          CodigoInforme = "FACTURAEXENTA007"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "FACTURA EXENTA",
          Informe = "VISUALIZAR FACTURA EXENTA",
          CodigoInforme = "FACTURAEXENTA008"
        });
      }
      if (this.cmbModulo.Text.Equals("GUIA") || this.cmbModulo.SelectedValue.ToString() == "0")
      {
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "GUIA",
          Informe = "LISTADO DE GUIAS, SEGÚN FECHA",
          CodigoInforme = "GUIA001"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "GUIA",
          Informe = "LISTADO DE GUIAS POR CLIENTES, SEGÚN FECHA",
          CodigoInforme = "GUIA002"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "GUIA",
          Informe = "LISTADO DE GUIAS POR VENDEDOR, SEGÚN FECHA",
          CodigoInforme = "GUIA003"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "GUIA",
          Informe = "LISTADO DE GUIAS POR CENTRO DE COSTO, SEGÚN FECHA",
          CodigoInforme = "GUIA004"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "GUIA",
          Informe = "LISTADO DE GUIAS ANULADAS, SEGÚN FECHA",
          CodigoInforme = "GUIA005"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "GUIA",
          Informe = "LISTADO DE GUIAS NO FACTURADAS, SEGÚN FECHA",
          CodigoInforme = "GUIA006"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "GUIA",
          Informe = "LISTADO DE GUIAS NO FACTURADAS POR CLIENTE, SEGÚN FECHA",
          CodigoInforme = "GUIA007"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "GUIA",
          Informe = "DETALLE DE ARTICULOS VENDIDOS CON GUIAS, SEGÚN FECHA",
          CodigoInforme = "GUIA008"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "GUIA",
          Informe = "VISUALIZAR GUIA",
          CodigoInforme = "GUIA009"
        });
      }
      if (this.cmbModulo.Text.Equals("INVENTARIO") || this.cmbModulo.SelectedValue.ToString() == "0")
      {
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "INVENTARIO",
          Informe = "EXISTENCIAS POR BODEGA",
          CodigoInforme = "INVENTARIO001"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "INVENTARIO",
          Informe = "LISTADO GENERAL DE PRECIOS",
          CodigoInforme = "INVENTARIO012"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "INVENTARIO",
          Informe = "LISTADO GENERAL DE PRECIOS Y SU RENTABILIDAD",
          CodigoInforme = "INVENTARIO013"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "INVENTARIO",
          Informe = "LISTADO DE ARTICULOS BAJO STOCK MINIMO",
          CodigoInforme = "INVENTARIO014"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "INVENTARIO",
          Informe = "LISTADO DE ARTICULOS PARA TOMA DE INVENTARIO",
          CodigoInforme = "INVENTARIO025"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "INVENTARIO",
          Informe = "MOVIMIENTO DE PRODUCTOS",
          CodigoInforme = "MOVIMIENTO001"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "INVENTARIO",
          Informe = "RANKING DE PRODUCTOS MAS VENDIDOS",
          CodigoInforme = "MOVIMIENTO002"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "INVENTARIO",
          Informe = "DETALLE DE VENTAS POR PRODUCTO",
          CodigoInforme = "MOVIMIENTO003"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "INVENTARIO",
          Informe = "DETALLE DE COMPRAS POR PRODUCTO",
          CodigoInforme = "MOVIMIENTO004"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "INVENTARIO",
          Informe = "DETALLE DE COMPRAS POR PROVEEDOR",
          CodigoInforme = "MOVIMIENTO005"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "INVENTARIO",
          Informe = "KARDEX POR PRODUCTO",
          CodigoInforme = "MOVIMIENTO009"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "INVENTARIO",
          Informe = "ENTRADA DE PRODUCTOS A BODEGA",
          CodigoInforme = "MOVIMIENTO010"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "INVENTARIO",
          Informe = "LISTADO DE TRASPASOS, SEGÚN FECHA",
          CodigoInforme = "TraspasoInterno001"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "INVENTARIO",
          Informe = "DETALLE DE TRASPASOS, SEGÚN FECHA",
          CodigoInforme = "TraspasoInterno002"
        });
      }
      if (this.cmbModulo.Text.Equals("CONTROL CAJA") || this.cmbModulo.SelectedValue.ToString() == "0")
      {
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "KIT",
          Informe = "VISUALIZAR FORMULA DE KIT",
          CodigoInforme = "KIT001"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "KIT",
          Informe = "DETALLE DE KIT ARMADOS, SEGÚN FECHA",
          CodigoInforme = "KIT002"
        });
      }
      if (this.cmbModulo.Text.Equals("NOTA CREDITO") || this.cmbModulo.SelectedValue.ToString() == "0")
      {
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "NOTA CREDITO",
          Informe = "LISTADO DE NOTAS DE CREDITO, SEGÚN FECHA",
          CodigoInforme = "NOTACREDITO001"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "NOTA CREDITO",
          Informe = "LISTADO DE NOTAS DE CREDITO POR CLIENTE, SEGÚN FECHA",
          CodigoInforme = "NOTACREDITO002"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "NOTA CREDITO",
          Informe = "LISTADO DE NOTAS DE CREDITO POR VENDEDOR, SEGÚN FECHA",
          CodigoInforme = "NOTACREDITO003"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "NOTA CREDITO",
          Informe = "LISTADO DE NOTAS DE CREDITO POR CENTRO DE COSTO, SEGÚN FECHA",
          CodigoInforme = "NOTACREDITO004"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "NOTA CREDITO",
          Informe = "VISUALIZAR NOTA DE CREDITO",
          CodigoInforme = "NOTACREDITO005"
        });
      }
      if (this.cmbModulo.Text.Equals("NOTA CREDITO") || this.cmbModulo.SelectedValue.ToString() == "0")
      {
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "NOTA VENTA",
          Informe = "LISTADO DE NOTAS DE VENTA, SEGÚN FECHA",
          CodigoInforme = "NOTAVENTA001"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "NOTA VENTA",
          Informe = "LISTADO DE NOTAS DE VENTA POR CLIENTE, SEGÚN FECHA",
          CodigoInforme = "NOTAVENTA002"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "NOTA VENTA",
          Informe = "LISTADO DE NOTAS DE VENTA POR VENDEDOR, SEGÚN FECHA",
          CodigoInforme = "NOTAVENTA003"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "NOTA VENTA",
          Informe = "LISTADO DE NOTAS DE VENTA POR CENTRO DE COSTO, SEGÚN FECHA",
          CodigoInforme = "NOTAVENTA004"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "NOTA VENTA",
          Informe = "LISTADO DE NOTAS DE VENTA ANULADAS, SEGÚN FECHA",
          CodigoInforme = "NOTAVENTA005"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "NOTA VENTA",
          Informe = "LISTADO DE NOTAS DE VENTA NO FACTURADAS, SEGÚN FECHA",
          CodigoInforme = "NOTAVENTA006"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "NOTA VENTA",
          Informe = "LISTADO DE NOTAS DE VENTA NO FACTURADAS POR CLIENTE, SEGÚN FECHA",
          CodigoInforme = "NOTAVENTA007"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "NOTA VENTA",
          Informe = "DETALLE DE ARTICULOS VENDIDOS CON NOTA DE VENTA, SEGÚN FECHA",
          CodigoInforme = "NOTAVENTA008"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "NOTA VENTA",
          Informe = "RESUMEN DE ARTICULOS VENDIDOS CON NOTA DE VENTA, SEGÚN FECHA",
          CodigoInforme = "NOTAVENTA009"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "NOTA VENTA",
          Informe = "RESUMEN DE ARTICULOS VENDIDOS CON NOTA DE VENTA POR CLIENTE, SEGÚN FECHA",
          CodigoInforme = "NOTAVENTA010"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "NOTA VENTA",
          Informe = "VISUALIZAR NOTA DE VENTA",
          CodigoInforme = "NOTAVENTA011"
        });
      }
      if (this.cmbModulo.Text.Equals("ORDEN COMPRA") || this.cmbModulo.SelectedValue.ToString() == "0")
      {
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "ORDEN COMPRA",
          Informe = "LISTADO DE ORDENES DE COMPRA, SEGÚN FECHA",
          CodigoInforme = "ORDENCOMP001"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "ORDEN COMPRA",
          Informe = "LISTADO DE ORDENES DE COMPRA POR PROVEEDOR, SEGÚN FECHA",
          CodigoInforme = "ORDENCOMP002"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "ORDEN COMPRA",
          Informe = "LISTADO DE ORDENES DE COMPRA POR CENTRO DE COSTO, SEGÚN FECHA",
          CodigoInforme = "ORDENCOMP003"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "ORDEN COMPRA",
          Informe = "VISUALIZAR ORDEN DE COMPRA",
          CodigoInforme = "ORDENCOMP004"
        });
      }
      if (this.cmbModulo.Text.Equals("PAGOS COMPRAS") || this.cmbModulo.SelectedValue.ToString() == "0")
      {
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "PAGOS COMPRAS",
          Informe = "DOCUMENTOS POR PAGAR, SEGÚN FECHA",
          CodigoInforme = "PAGOCOMPRA001"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "PAGOS COMPRAS",
          Informe = "DETALLE DE PAGOS DE COMPRA, SEGÚN FECHA",
          CodigoInforme = "PAGOCOMPRA002"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "PAGOS COMPRAS",
          Informe = "DETALLE DE PAGOS DE COMPRA POR PROVEEDOR, SEGÚN FECHA",
          CodigoInforme = "PAGOCOMPRA003"
        });
      }
      if (this.cmbModulo.Text.Equals("PAGOS VENTAS") || this.cmbModulo.SelectedValue.ToString() == "0")
      {
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "PAGOS VENTAS",
          Informe = "DOCUMENTOS DE VENTA POR COBRAR, SEGÚN FECHA",
          CodigoInforme = "PAGOVENTA001"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "PAGOS VENTAS",
          Informe = "DETALLE DE PAGOS DE VENTAS, SEGÚN FECHA DE COBRO",
          CodigoInforme = "PAGOVENTA002"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "PAGOS VENTAS",
          Informe = "DETALLE DE PAGOS DE VENTAS POR CLIENTE, SEGÚN FECHA DE COBRO",
          CodigoInforme = "PAGOVENTA003"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "PAGOS VENTAS",
          Informe = "DETALLE DE CLIENTES MOROSOS",
          CodigoInforme = "PAGOVENTA004"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "PAGOS VENTAS",
          Informe = "LISTADO DE VENTAS POR ESTADO DE DOCUMENTO, SEGÚN FECHA",
          CodigoInforme = "PAGOVENTA005"
        });
      }
      if (this.cmbModulo.Text.Equals("TICKET") || this.cmbModulo.SelectedValue.ToString() == "0")
      {
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "TICKET",
          Informe = "LISTADO DE TICKETS, SEGÚN FECHA",
          CodigoInforme = "TICKET001"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "TICKET",
          Informe = "LISTADO DE TICKETS POR VENDEDOR, SEGÚN FECHA",
          CodigoInforme = "TICKET002"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "TICKET",
          Informe = "LISTADO DE TICKETS POR CLIENTE, SEGÚN FECHA",
          CodigoInforme = "TICKET003"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "TICKET",
          Informe = "LISTADO DE TICKETS ANULADOS, SEGÚN FECHA",
          CodigoInforme = "TICKET004"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "TICKET",
          Informe = "VISUALIZAR TICKET",
          CodigoInforme = "TICKET005"
        });
      }
      if (this.cmbModulo.Text.Equals("VENTA GENERAL") || this.cmbModulo.SelectedValue.ToString() == "0")
      {
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "VENTA GENERAL",
          Informe = "RESUMEN DE VENTAS DIARIAS",
          CodigoInforme = "VENTA001"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "VENTA GENERAL",
          Informe = "LIBRO DE VENTAS",
          CodigoInforme = "VENTA002"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "VENTA GENERAL",
          Informe = "LIBRO DE VENTAS CON BOLETAS",
          CodigoInforme = "VENTA003"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "VENTA GENERAL",
          Informe = "LISTADO DE CLIENTES",
          CodigoInforme = "VENTA004"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "VENTA GENERAL",
          Informe = "LISTADO DE ARTICULOS VENDIDOS CON FACTURA Y BOLETAS Y SU RENTABILIDAD, SEGÚN FECHA",
          CodigoInforme = "VENTA005"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "VENTA GENERAL",
          Informe = "RESUMEN DE ARTICULOS VENDIDOS CON FACTURAS Y BOLETAS AGRUPADOS POR CATEGORIA, SEGÚN FECHA",
          CodigoInforme = "VENTA006"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "VENTA GENERAL",
          Informe = "LISTADO DE FACTURAS Y BOLETAS POR VENDEDOR, SEGÚN FECHA",
          CodigoInforme = "VENTA007"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "VENTA GENERAL",
          Informe = "LISTADO DE DOCUMENTOS DE VENTA PENDIENTES DE PAGO, SEGÚN FECHA",
          CodigoInforme = "VENTA010"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "VENTA GENERAL",
          Informe = "RESUMEN DE VENTAS, SEGÚN FECHA",
          CodigoInforme = "VENTA011"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "VENTA GENERAL",
          Informe = "DETALLE DE COMISIONES POR VENDEDOR, SEGUN FECHA",
          CodigoInforme = "VENTA013"
        });
      }
      if (this.cmbModulo.Text.Equals("ORDEN TRABAJO") || this.cmbModulo.SelectedValue.ToString() == "0")
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "ORDEN TRABAJO",
          Informe = "LISTADO DE OT, SEGÚN FECHA",
          CodigoInforme = "ORDENTRABAJO001"
        });
      if (this.cmbModulo.Text.Equals("FACTURA") || this.cmbModulo.SelectedValue.ToString() == "0")
      {
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "FACTURA ELECTRONICA",
          Informe = "LISTADO DE FACTURAS ELECTRONICA SEGÚN FECHA",
          CodigoInforme = "FACTURAELECTRONICA001"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "FACTURA ELECTRONICA",
          Informe = "LISTADO DE FACTURAS ELECTRONICAS POR CLIENTE, SEGÚN FECHA",
          CodigoInforme = "FACTURAELECTRONICA002"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "FACTURA ELECTRONICA",
          Informe = "LISTADO DE FACTURAS ELECTRONICAS POR VENDEDOR, SEGÚN FECHA",
          CodigoInforme = "FACTURAELECTRONICA003"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "FACTURA ELECTRONICA",
          Informe = "LISTADO DE FACTURAS ELECTRONICAS POR CENTRO DE COSTO, SEGÚN FECHA",
          CodigoInforme = "FACTURAELECTRONICA004"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "FACTURA ELECTRONICA",
          Informe = "LISTADO DE FACTURAS ELECTRONICA PENDIENTES DE PAGO, SEGÚN FECHA",
          CodigoInforme = "FACTURAELECTRONICA005"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "FACTURA ELECTRONICA",
          Informe = "LISTADO DE PRODUCTOS VENDIDOS POR FECHA, AGRUPADOS POR CATEGORIA",
          CodigoInforme = "FACTURAELECTRONICA006"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "FACTURA ELECTRONICA",
          Informe = "VISUALIZAR FACTURA ELECTRONICA",
          CodigoInforme = "FACTURAELECTRONICA014"
        });
      }
      if (this.cmbModulo.Text.Equals("FACTURA EXENTA ELECTRONICA") || this.cmbModulo.SelectedValue.ToString() == "0")
      {
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "FACTURA EXENTA ELECTRONICA",
          Informe = "LISTADO DE FACTURAS EXENTAS ELECTRONICA SEGÚN FECHA",
          CodigoInforme = "FACTURAEXENTAELECTRONICA001"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "FACTURA EXENTA ELECTRONICA",
          Informe = "LISTADO DE FACTURAS EXENTAS ELECTRONICAS POR CLIENTE, SEGÚN FECHA",
          CodigoInforme = "FACTURAEXENTAELECTRONICA002"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "FACTURA EXENTA ELECTRONICA",
          Informe = "LISTADO DE FACTURAS EXENTAS ELECTRONICAS POR VENDEDOR, SEGÚN FECHA",
          CodigoInforme = "FACTURAEXENTAELECTRONICA003"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "FACTURA EXENTA ELECTRONICA",
          Informe = "LISTADO DE FACTURAS EXENTAS ELECTRONICAS POR CENTRO DE COSTO, SEGÚN FECHA",
          CodigoInforme = "FACTURAEXENTAELECTRONICA004"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "FACTURA EXENTA ELECTRONICA",
          Informe = "LISTADO DE FACTURAS EXENTAS ELECTRONICA PENDIENTES DE PAGO, SEGÚN FECHA",
          CodigoInforme = "FACTURAEXENTAELECTRONICA005"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "FACTURA EXENTA ELECTRONICA",
          Informe = "LISTADO DE PRODUCTOS VENDIDOS POR FECHA, AGRUPADOS POR CATEGORIA",
          CodigoInforme = "FACTURAEXENTAELECTRONICA006"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "FACTURA EXENTA ELECTRONICA",
          Informe = "VISUALIZAR FACTURA EXENTA ELECTRONICA",
          CodigoInforme = "FACTURAEXENTAELECTRONICA014"
        });
      }
      if (this.cmbModulo.Text.Equals("NOTA CREDITO") || this.cmbModulo.SelectedValue.ToString() == "0")
      {
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "NOTA CREDITO ELECTRONICA",
          Informe = "LISTADO DE NOTAS CREDITO ELECTRONICAS SEGÚN FECHA",
          CodigoInforme = "NOTACREDITOELECTRONICA001"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "NOTA CREDITO ELECTRONICA",
          Informe = "LISTADO DE NOTAS CREDITO ELECTRONICAS POR CLIENTE, SEGÚN FECHA",
          CodigoInforme = "NOTACREDITOELECTRONICA002"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "NOTA CREDITO ELECTRONICA",
          Informe = "LISTADO DE NOTAS CREDITO ELECTRONICAS POR VENDEDOR, SEGÚN FECHA",
          CodigoInforme = "NOTACREDITOELECTRONICA003"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "NOTA CREDITO ELECTRONICA",
          Informe = "LISTADO DE NOTAS CREDITO ELECTRONICAS POR CENTRO DE COSTO, SEGÚN FECHA",
          CodigoInforme = "NOTACREDITOELECTRONICA004"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "NOTA CREDITO ELECTRONICA",
          Informe = "VISUALIZAR NOTA CREDITO ELECTRONICA",
          CodigoInforme = "NOTACREDITOELECTRONICA005"
        });
      }
      if (this.cmbModulo.Text.Equals("NOTA DEBITO") || this.cmbModulo.SelectedValue.ToString() == "0")
      {
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "NOTA DEBITO ELECTRONICA",
          Informe = "LISTADO DE NOTAS DEBITO ELECTRONICAS SEGÚN FECHA",
          CodigoInforme = "NOTADEBITOELECTRONICA001"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "NOTA DEBITO ELECTRONICA",
          Informe = "LISTADO DE NOTAS DEBITO ELECTRONICAS POR CLIENTE, SEGÚN FECHA",
          CodigoInforme = "NOTADEBITOELECTRONICA002"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "NOTA DEBITO ELECTRONICA",
          Informe = "LISTADO DE NOTAS DEBITO ELECTRONICAS POR VENDEDOR, SEGÚN FECHA",
          CodigoInforme = "NOTADEBITOELECTRONICA003"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "NOTA DEBITO ELECTRONICA",
          Informe = "LISTADO DE NOTAS DEBITO ELECTRONICAS POR CENTRO DE COSTO, SEGÚN FECHA",
          CodigoInforme = "NOTADEBITOELECTRONICA004"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "NOTA DEBITO ELECTRONICA",
          Informe = "VISUALIZAR NOTA DEBITO ELECTRONICA",
          CodigoInforme = "NOTADEBITOELECTRONICA005"
        });
      }
      if (this.cmbModulo.Text.Equals("GUIA ELECTRONICA") || this.cmbModulo.SelectedValue.ToString() == "0")
      {
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "GUIA ELECTRONICA",
          Informe = "LISTADO DE GUIAS ELECTRONICA SEGÚN FECHA",
          CodigoInforme = "GUIAELECTRONICA001"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "GUIA ELECTRONICA",
          Informe = "LISTADO DE GUIAS ELECTRONICAS POR CLIENTE, SEGÚN FECHA",
          CodigoInforme = "GUIAELECTRONICA002"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "GUIA ELECTRONICA",
          Informe = "LISTADO DE GUIAS ELECTRONICAS POR VENDEDOR, SEGÚN FECHA",
          CodigoInforme = "GUIAELECTRONICA003"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "GUIA ELECTRONICA",
          Informe = "LISTADO DE GUIAS ELECTRONICAS POR CENTRO DE COSTO, SEGÚN FECHA",
          CodigoInforme = "GUIAELECTRONICA004"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "GUIA ELECTRONICA",
          Informe = "GUIAS ELECTRONICAS NO FACTURADAS",
          CodigoInforme = "GUIAELECTRONICA005"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "GUIA ELECTRONICA",
          Informe = "VISUALIZAR GUIAS ELECTRONICA",
          CodigoInforme = "GUIAELECTRONICA014"
        });
      }
      if (this.cmbModulo.Text.Equals("BOLETA ELECTRONICA") || this.cmbModulo.SelectedValue.ToString() == "0")
      {
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "BOLETA ELECTRONICA",
          Informe = "LISTADO DE BOLETAS, SEGÚN FECHA",
          CodigoInforme = "BOLETAELECTRONICA001"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "BOLETA ELECTRONICA",
          Informe = "LISTADO DE BOLETAS POR CLIENTE, SEGÚN FECHA",
          CodigoInforme = "BOLETAELECTRONICA002"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "BOLETA ELECTRONICA",
          Informe = "LISTADO DE BOLETAS POR VENDEDOR, SEGÚN FECHA",
          CodigoInforme = "BOLETAELECTRONICA003"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "BOLETA ELECTRONICA",
          Informe = "LISTADO DE BOLETAS POR CENTRO DE COSTO, SEGÚN FECHA",
          CodigoInforme = "BOLETAELECTRONICA004"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "BOLETA ELECTRONICA",
          Informe = "LISTADO DE BOLETAS ANULADAS, SEGÚN FECHA",
          CodigoInforme = "BOLETAELECTRONICA005"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "BOLETA ELECTRONICA",
          Informe = "RESUMEN DE ARTICULOS VENDIDOS CON BOLETAS, SEGÚN FECHA",
          CodigoInforme = "BOLETAELECTRONICA006"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "BOLETA ELECTRONICA",
          Informe = "RESUMEN DE ARTICULOS VENDIDOS CON BOLETAS, SEGÚN FECHA",
          CodigoInforme = "BOLETAELECTRONICA007"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "BOLETA ELECTRONICA",
          Informe = "LISTADO DE ARTICULOS VENDIDOS CON BOLETAS Y SU RENTABILIDAD, SEGÚN FECHA",
          CodigoInforme = "BOLETAELECTRONICA008"
        });
        this.listaInformes.Add(new InformeVO()
        {
          Modulo = "BOLETA ELECTRONICA",
          Informe = "VISUALIZAR BOLETA",
          CodigoInforme = "BOLETAELECTRONICA009"
        });
      }
      if (!this.cmbModulo.Text.Equals("BOLETA ELECTRONICA") && !(this.cmbModulo.SelectedValue.ToString() == "0"))
        return;
      this.listaInformes.Add(new InformeVO()
      {
        Modulo = "BOLETA EXENTA ELECTRONICA",
        Informe = "LISTADO DE BOLETAS, SEGÚN FECHA",
        CodigoInforme = "BOLETAEXENTAELECTRONICA001"
      });
      this.listaInformes.Add(new InformeVO()
      {
        Modulo = "BOLETA EXENTA ELECTRONICA",
        Informe = "LISTADO DE BOLETAS POR CLIENTE, SEGÚN FECHA",
        CodigoInforme = "BOLETAEXENTAELECTRONICA002"
      });
      this.listaInformes.Add(new InformeVO()
      {
        Modulo = "BOLETA EXENTA ELECTRONICA",
        Informe = "LISTADO DE BOLETAS POR VENDEDOR, SEGÚN FECHA",
        CodigoInforme = "BOLETAEXENTAELECTRONICA003"
      });
      this.listaInformes.Add(new InformeVO()
      {
        Modulo = "BOLETA EXENTA ELECTRONICA",
        Informe = "LISTADO DE BOLETAS POR CENTRO DE COSTO, SEGÚN FECHA",
        CodigoInforme = "BOLETAEXENTAELECTRONICA004"
      });
      this.listaInformes.Add(new InformeVO()
      {
        Modulo = "BOLETA EXENTA ELECTRONICA",
        Informe = "LISTADO DE BOLETAS ANULADAS, SEGÚN FECHA",
        CodigoInforme = "BOLETAEXENTAELECTRONICA005"
      });
      this.listaInformes.Add(new InformeVO()
      {
        Modulo = "BOLETA EXENTA ELECTRONICA",
        Informe = "RESUMEN DE ARTICULOS VENDIDOS CON BOLETAS, SEGÚN FECHA",
        CodigoInforme = "BOLETAEXENTAELECTRONICA006"
      });
      this.listaInformes.Add(new InformeVO()
      {
        Modulo = "BOLETA EXENTA ELECTRONICA",
        Informe = "RESUMEN DE ARTICULOS VENDIDOS CON BOLETAS, SEGÚN FECHA",
        CodigoInforme = "BOLETAEXENTAELECTRONICA007"
      });
      this.listaInformes.Add(new InformeVO()
      {
        Modulo = "BOLETA EXENTA ELECTRONICA",
        Informe = "LISTADO DE ARTICULOS VENDIDOS CON BOLETAS Y SU RENTABILIDAD, SEGÚN FECHA",
        CodigoInforme = "BOLETAEXENTAELECTRONICA008"
      });
      this.listaInformes.Add(new InformeVO()
      {
        Modulo = "BOLETA EXENTA ELECTRONICA",
        Informe = "VISUALIZAR BOLETA",
        CodigoInforme = "BOLETAEXENTAELECTRONICA009"
      });
    }

    private void chkSeleccionar_CheckedChanged(object sender, EventArgs e)
    {
      if (this.chkSeleccionar.Checked)
      {
        foreach (DataGridViewRow dataGridViewRow in (IEnumerable) this.dgvPermisos.Rows)
          dataGridViewRow.Cells["Ingresar"].Value = (object) true;
      }
      else
      {
        foreach (DataGridViewRow dataGridViewRow in (IEnumerable) this.dgvPermisos.Rows)
          dataGridViewRow.Cells["Ingresar"].Value = (object) false;
      }
    }

    private void btnFiltro_Click(object sender, EventArgs e)
    {
      this.cargaColumnasInformes();
    }

    private void btnGuardar_Click(object sender, EventArgs e)
    {
      this.guardaPermiso();
    }

    private void guardaPermiso()
    {
      List<InformeVO> lista = new List<InformeVO>();
      InformeVO informeVo = new InformeVO();
      foreach (DataGridViewRow dataGridViewRow in (IEnumerable) this.dgvPermisos.Rows)
        lista.Add(new InformeVO()
        {
          IdTipoUsuario = this.idTipoUsuario,
          TipoUsuario = this.lblTipoUsuario.Text,
          IdDetalleInforme = Convert.ToInt32(dataGridViewRow.Cells["IdDetalleInforme"].Value.ToString()),
          Modulo = dataGridViewRow.Cells["Modulo"].Value.ToString(),
          Informe = dataGridViewRow.Cells["Informe"].Value.ToString(),
          CodigoInforme = dataGridViewRow.Cells["CodigoInforme"].Value.ToString(),
          Ingresar = Convert.ToBoolean(dataGridViewRow.Cells["Ingresar"].Value)
        });
      PermisoInforme permisoInforme = new PermisoInforme();
      try
      {
        permisoInforme.guardaPermisoInforme(lista);
        int num = (int) MessageBox.Show("Permisos Modificados", "Permisos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        this.listaInformes.Clear();
        this.buscaPermisosTipousuario();
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("error al guardar : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void btnSalir_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void frmPermisoInforme_Load(object sender, EventArgs e)
    {

    }
  }
}
