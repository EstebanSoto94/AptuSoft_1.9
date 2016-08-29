 
// Type: Aptusoft.frmArmaKit
 
 
// version 1.8.0

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Aptusoft
{
  public class frmArmaKit : Form
  {
    private List<KitVO> lista = new List<KitVO>();
    private int idKit = 0;
    private IContainer components = (IContainer) null;
    private TextBox txtDescripcionKit;
    private TextBox txtCodigoKit;
    private Label label2;
    private Label label1;
    private GroupBox groupBox2;
    private Label label4;
    private ComboBox cmbBodega;
    private Label label3;
    private DataGridView dgvDatosVenta;
    private Button btnGuardar;
    private Button btnModificar;
    private Button btnEliminar;
    private Button btnLimpiar;
    private Button btnSalir;
    private Label lblFolio;
    private Label label5;
    private GroupBox gpbBuscaFolio;
    private Button btnCerrarBusca;
    private Button btnBuscar;
    private TextBox txtFolioBuscar;
    private Label label6;
    private TextBox txtCantidad;

    public frmArmaKit()
    {
      this.InitializeComponent();
      this.iniciaFormulario();
      this.creaColumnasDetalle();
    }

    private void iniciaFormulario()
    {
      this.cargaBodega();
      this.lblFolio.Text = new ArmaKit().folioKit().ToString();
      this.gpbBuscaFolio.Visible = false;
      this.txtFolioBuscar.Clear();
      this.txtCantidad.Clear();
      this.txtDescripcionKit.Clear();
      this.txtCodigoKit.Clear();
      this.dgvDatosVenta.DataSource = (object) null;
      this.lista.Clear();
      this.btnGuardar.Enabled = true;
      this.btnModificar.Enabled = false;
      this.btnEliminar.Enabled = false;
      this.txtCodigoKit.Focus();
    }

    private void limpiaFormulario()
    {
      this.iniciaFormulario();
      for (int index = 0; index < this.lista.Count; ++index)
        this.lista[index].CantidadUsada = new Decimal(0);
      this.cargaGrilla();
    }

    private void cargaGrilla()
    {
      for (int index = 0; index < this.lista.Count; ++index)
      {
        this.lista[index].Linea = index + 1;
        this.lista[index].Bodega = "1";
      }
      this.dgvDatosVenta.DataSource = (object) null;
      this.dgvDatosVenta.DataSource = (object) this.lista;
    }

    private void creaColumnasDetalle()
    {
      CargaMaestros cargaMaestros = new CargaMaestros();
      this.dgvDatosVenta.AutoGenerateColumns = false;
      this.dgvDatosVenta.Columns.Add("Linea", "");
      this.dgvDatosVenta.Columns[0].DataPropertyName = "Linea";
      this.dgvDatosVenta.Columns[0].Width = 20;
      this.dgvDatosVenta.Columns[0].Resizable = DataGridViewTriState.False;
      this.dgvDatosVenta.Columns[0].DefaultCellStyle.BackColor = Color.DarkGray;
      this.dgvDatosVenta.Columns[0].ReadOnly = true;
      this.dgvDatosVenta.Columns.Add("Codigo", "Codigo");
      this.dgvDatosVenta.Columns[1].DataPropertyName = "CodigoProductoDetalle";
      this.dgvDatosVenta.Columns[1].Width = 100;
      this.dgvDatosVenta.Columns[1].Resizable = DataGridViewTriState.False;
      this.dgvDatosVenta.Columns[1].ReadOnly = true;
      this.dgvDatosVenta.Columns.Add("Descripcion", "Descripcion");
      this.dgvDatosVenta.Columns[2].DataPropertyName = "Descripcion";
      this.dgvDatosVenta.Columns[2].Width = 200;
      this.dgvDatosVenta.Columns[2].Resizable = DataGridViewTriState.False;
      this.dgvDatosVenta.Columns[2].ReadOnly = true;
      this.dgvDatosVenta.Columns.Add("Cantidad", "Cantidad C/U");
      this.dgvDatosVenta.Columns[3].DataPropertyName = "Cantidad";
      this.dgvDatosVenta.Columns[3].Width = 100;
      this.dgvDatosVenta.Columns[3].DefaultCellStyle.Format = "N4";
      this.dgvDatosVenta.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.dgvDatosVenta.Columns[3].Resizable = DataGridViewTriState.False;
      this.dgvDatosVenta.Columns[3].ReadOnly = true;
      this.dgvDatosVenta.Columns.Add("CantidadUsada", "Cantidad a Usar");
      this.dgvDatosVenta.Columns[4].DataPropertyName = "CantidadUsada";
      this.dgvDatosVenta.Columns[4].Width = 130;
      this.dgvDatosVenta.Columns[4].DefaultCellStyle.Format = "N4";
      this.dgvDatosVenta.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
      this.dgvDatosVenta.Columns[4].Resizable = DataGridViewTriState.False;
      this.dgvDatosVenta.Columns[4].ReadOnly = true;
      DataGridViewComboBoxColumn viewComboBoxColumn = new DataGridViewComboBoxColumn();
      viewComboBoxColumn.Name = "Bodega";
      viewComboBoxColumn.DataPropertyName = "Bodega";
      viewComboBoxColumn.HeaderText = "Bodega Origen";
      viewComboBoxColumn.DataSource = (object) cargaMaestros.cargaBodega();
      viewComboBoxColumn.ValueMember = "codigo";
      viewComboBoxColumn.DisplayMember = "descripcion";
      viewComboBoxColumn.Width = 150;
      viewComboBoxColumn.DisplayIndex = 5;
      viewComboBoxColumn.ReadOnly = false;
      this.dgvDatosVenta.Columns.Add((DataGridViewColumn) viewComboBoxColumn);
      this.dgvDatosVenta.Columns.Add("IdKit", "IdKit");
      this.dgvDatosVenta.Columns[6].DataPropertyName = "IdKit";
      this.dgvDatosVenta.Columns[6].Width = 80;
      this.dgvDatosVenta.Columns[6].Resizable = DataGridViewTriState.False;
      this.dgvDatosVenta.Columns[6].Visible = false;
      this.dgvDatosVenta.Columns[6].ReadOnly = true;
      this.dgvDatosVenta.Columns.Add("FolioKit", "FolioKit");
      this.dgvDatosVenta.Columns[7].DataPropertyName = "FolioKit";
      this.dgvDatosVenta.Columns[7].Width = 80;
      this.dgvDatosVenta.Columns[7].Resizable = DataGridViewTriState.False;
      this.dgvDatosVenta.Columns[7].Visible = false;
      this.dgvDatosVenta.Columns[7].ReadOnly = true;
    }

    private void cargaBodega()
    {
      this.cmbBodega.DataSource = (object) new CargaMaestros().cargaBodega();
      this.cmbBodega.ValueMember = "codigo";
      this.cmbBodega.DisplayMember = "descripcion";
      this.cmbBodega.Enabled = true;
      this.cmbBodega.SelectedValue = (object) 1;
    }

    private void calculaCantidad()
    {
      Decimal num1 = Convert.ToDecimal(this.txtCantidad.Text.Trim());
      foreach (DataGridViewRow dataGridViewRow in (IEnumerable) this.dgvDatosVenta.Rows)
      {
        Decimal num2 = Convert.ToDecimal(dataGridViewRow.Cells["Cantidad"].Value.ToString()) * num1;
        dataGridViewRow.Cells["CantidadUsada"].Value = (object) num2.ToString();
      }
    }

    private void txtCantidad_TextChanged(object sender, EventArgs e)
    {
      if (this.txtCantidad.Text.Trim().Length <= 0)
        return;
      this.calculaCantidad();
    }

    private void soloNumeros(KeyPressEventArgs e, TextBox caja)
    {
      if ((int) e.KeyChar == 46)
        e.KeyChar = ',';
      if (caja.Text.Trim().Length == 0 && (int) e.KeyChar == 44)
        e.KeyChar = '0';
      if ((int) e.KeyChar == 8)
      {
        e.Handled = false;
      }
      else
      {
        bool flag = false;
        int num = 0;
        for (int index = 0; index < caja.Text.Length; ++index)
        {
          if ((int) caja.Text[index] == 44)
            flag = true;
          if (flag && num++ >= 4)
          {
            e.Handled = true;
            return;
          }
        }
        if ((int) e.KeyChar >= 48 && (int) e.KeyChar <= 57)
          e.Handled = false;
        else if ((int) e.KeyChar == 44)
          e.Handled = flag;
        else
          e.Handled = true;
      }
    }

    private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
    {
    }

    private void btnSalir_Click(object sender, EventArgs e)
    {
      this.Close();
      this.Dispose();
    }

    private bool valida()
    {
      if (this.lista[0].CantidadUsada == new Decimal(0))
      {
        int num = (int) MessageBox.Show("Debe Ingesar Cantidad de Kit!!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        this.txtCantidad.Focus();
        return false;
      }
      if (this.txtCantidad.Text.Trim().Length != 0)
        return true;
      int num1 = (int) MessageBox.Show("Debe Ingesar Cantidad de Kit!!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      this.txtCantidad.Focus();
      return false;
    }

    private void btnGuardar_Click(object sender, EventArgs e)
    {
      if (!this.valida())
        return;
      KitVO kv = new KitVO();
      List<KitVO> lista = new List<KitVO>();
      kv.FolioKit = Convert.ToInt32(this.lblFolio.Text.Trim());
      kv.FechaIngresoKit = DateTime.Now;
      kv.CodigoProductoKit = this.txtCodigoKit.Text;
      kv.Descripcion = this.txtDescripcionKit.Text;
      kv.Cantidad = Convert.ToDecimal(this.txtCantidad.Text.Trim());
      kv.Bodega = this.cmbBodega.SelectedValue.ToString();
      kv.Usuario = frmMenuPrincipal.listaUsuario[0].NombreUsuario;
      KitVO kitVo = new KitVO();
      foreach (DataGridViewRow dataGridViewRow in (IEnumerable) this.dgvDatosVenta.Rows)
        lista.Add(new KitVO()
        {
          FolioKit = Convert.ToInt32(this.lblFolio.Text.Trim()),
          CodigoProductoDetalle = dataGridViewRow.Cells["Codigo"].Value.ToString(),
          Descripcion = dataGridViewRow.Cells["Descripcion"].Value.ToString(),
          CantidadCU = Convert.ToDecimal(dataGridViewRow.Cells["Cantidad"].Value.ToString()),
          CantidadUsada = Convert.ToDecimal(dataGridViewRow.Cells["CantidadUsada"].Value.ToString()),
          BodegaOrigen = dataGridViewRow.Cells["Bodega"].Value.ToString()
        });
      ArmaKit armaKit = new ArmaKit();
      for (int index = 0; index < lista.Count; ++index)
        lista[index].Usuario = frmMenuPrincipal.listaUsuario[0].NombreUsuario;
      try
      {
        armaKit.guardaArmaKit(kv, lista);
        int num = (int) MessageBox.Show("Kit Ingresado a Inventario", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        this.iniciaFormulario();
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error al guardar " + ex.Message);
      }
    }

    private void txtFolioBuscar_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.soloNumeros(e, this.txtFolioBuscar);
      if ((int) e.KeyChar != 13)
        return;
      e.Handled = false;
      if (this.txtFolioBuscar.Text.Trim().Length > 0)
        this.llamaKitArmado();
    }

    private void lblFolio_DoubleClick(object sender, EventArgs e)
    {
    }

    private void btnCerrarBusca_Click(object sender, EventArgs e)
    {
      this.gpbBuscaFolio.Visible = false;
    }

    private void btnBuscar_Click(object sender, EventArgs e)
    {
      this.llamaKitArmado();
    }

    private void llamaKitArmado()
    {
      ArmaKit armaKit = new ArmaKit();
      KitVO kitVo = armaKit.buscaKitFolio(Convert.ToInt32(this.txtFolioBuscar.Text.Trim()));
      if (kitVo.IdKit > 0)
      {
        this.idKit = kitVo.IdKit;
        this.lblFolio.Text = kitVo.FolioKit.ToString();
        this.txtCodigoKit.Text = kitVo.CodigoProductoKit;
        this.txtDescripcionKit.Text = kitVo.Descripcion;
        this.txtCantidad.Text = this.verificaDecimales(kitVo.Cantidad.ToString());
        this.cmbBodega.SelectedValue = (object) kitVo.Bodega;
        this.lista = armaKit.buscaDetalleKitFolio(Convert.ToInt32(this.txtFolioBuscar.Text.Trim()));
        for (int index = 0; index < this.lista.Count; ++index)
          this.lista[index].Linea = index + 1;
        this.dgvDatosVenta.DataSource = (object) null;
        this.dgvDatosVenta.DataSource = (object) this.lista;
        this.btnGuardar.Enabled = false;
        this.btnModificar.Enabled = true;
        this.btnEliminar.Enabled = true;
        this.gpbBuscaFolio.Visible = false;
      }
      else
      {
        int num = (int) MessageBox.Show("No existe Folio Consultado");
      }
    }

    private void btnModificar_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("Esta seguro de Modificar este Kit", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
      {
        if (!this.valida())
          return;
        KitVO kv = new KitVO();
        List<KitVO> lista = new List<KitVO>();
        kv.FolioKit = Convert.ToInt32(this.lblFolio.Text.Trim());
        kv.FechaIngresoKit = DateTime.Now;
        kv.CodigoProductoKit = this.txtCodigoKit.Text;
        kv.Descripcion = this.txtDescripcionKit.Text;
        kv.Cantidad = Convert.ToDecimal(this.txtCantidad.Text.Trim());
        kv.Bodega = this.cmbBodega.SelectedValue.ToString();
        kv.Usuario = frmMenuPrincipal.listaUsuario[0].NombreUsuario;
        KitVO kitVo = new KitVO();
        foreach (DataGridViewRow dataGridViewRow in (IEnumerable) this.dgvDatosVenta.Rows)
          lista.Add(new KitVO()
          {
            FolioKit = Convert.ToInt32(this.lblFolio.Text.Trim()),
            CodigoProductoDetalle = dataGridViewRow.Cells["Codigo"].Value.ToString(),
            Descripcion = dataGridViewRow.Cells["Descripcion"].Value.ToString(),
            CantidadCU = Convert.ToDecimal(dataGridViewRow.Cells["Cantidad"].Value.ToString()),
            CantidadUsada = Convert.ToDecimal(dataGridViewRow.Cells["CantidadUsada"].Value.ToString()),
            BodegaOrigen = dataGridViewRow.Cells["Bodega"].Value.ToString()
          });
        for (int index = 0; index < lista.Count; ++index)
          lista[index].Usuario = frmMenuPrincipal.listaUsuario[0].NombreUsuario;
        ArmaKit armaKit = new ArmaKit();
        try
        {
          armaKit.modificaArmaKit(kv, lista);
          int num = (int) MessageBox.Show("Kit Modificado Correctamente", "Modifica", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          this.iniciaFormulario();
        }
        catch (Exception ex)
        {
          int num = (int) MessageBox.Show("Error al Modificar " + ex.Message);
        }
      }
      else
      {
        int num1 = (int) MessageBox.Show("el Kit NO fue Modificado", "Modifica", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
    }

    private void btnEliminar_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("Esta seguro de Eliminar este Kit", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
      {
        new ArmaKit().eliminaKidCompleto(Convert.ToInt32(this.lblFolio.Text));
        int num = (int) MessageBox.Show("Kit Armado Eliminado", "Elimina Kit", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        this.iniciaFormulario();
      }
      else
      {
        int num1 = (int) MessageBox.Show("El Kit NO fue Eliminado");
      }
    }

    private void btnLimpiar_Click(object sender, EventArgs e)
    {
      this.iniciaFormulario();
    }

    private void txtCodigoKit_KeyPress(object sender, KeyPressEventArgs e)
    {
      if ((int) e.KeyChar != 13)
        return;
      e.Handled = false;
      if (this.txtCodigoKit.Text.Trim().Length > 0)
        this.llamaProductoCodigo(this.txtCodigoKit.Text.Trim());
    }

    public void llamaProductoCodigo(string cod)
    {
      ProductoVO productoVo = new Producto().buscaCodigoProducto(cod);
      if (productoVo.Codigo == null)
      {
        int num = (int) MessageBox.Show("El Producto No Existe");
        this.txtCodigoKit.Focus();
      }
      else if (productoVo.Kit)
      {
        this.txtCodigoKit.Text = productoVo.Codigo;
        this.txtDescripcionKit.Text = productoVo.Descripcion;
        this.buscaKid(this.txtCodigoKit.Text.Trim());
        this.txtCantidad.Focus();
      }
      else
      {
        int num = (int) MessageBox.Show("El Producto No Tiene un Kit Creado.");
        this.txtCodigoKit.Focus();
      }
    }

    private void buscaKid(string cod)
    {
      this.lista = new Kit().buscaKitCodigoKit(cod);
      if (this.lista.Count <= 0)
        return;
      this.btnGuardar.Enabled = true;
      this.btnModificar.Enabled = false;
      this.btnEliminar.Enabled = false;
      this.cargaGrilla();
      this.txtCantidad.Focus();
    }

    private void frmArmaKit_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.F6)
        return;
      this.gpbBuscaFolio.Visible = true;
      this.txtFolioBuscar.Clear();
      this.txtFolioBuscar.Focus();
    }

    private string verificaDecimales(string cantidad)
    {
      int num = cantidad.ToString().IndexOf(',');
      string str = cantidad;
      if (num != -1)
      {
        string[] strArray = cantidad.Split(',');
        str = Convert.ToInt32(strArray[1]) <= 0 ? strArray[0] : cantidad;
      }
      return str;
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
            this.txtDescripcionKit = new System.Windows.Forms.TextBox();
            this.txtCodigoKit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.cmbBodega = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvDatosVenta = new System.Windows.Forms.DataGridView();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblFolio = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gpbBuscaFolio = new System.Windows.Forms.GroupBox();
            this.btnCerrarBusca = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtFolioBuscar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosVenta)).BeginInit();
            this.gpbBuscaFolio.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDescripcionKit
            // 
            this.txtDescripcionKit.BackColor = System.Drawing.Color.White;
            this.txtDescripcionKit.Location = new System.Drawing.Point(107, 34);
            this.txtDescripcionKit.Name = "txtDescripcionKit";
            this.txtDescripcionKit.Size = new System.Drawing.Size(341, 20);
            this.txtDescripcionKit.TabIndex = 3;
            // 
            // txtCodigoKit
            // 
            this.txtCodigoKit.BackColor = System.Drawing.Color.White;
            this.txtCodigoKit.Location = new System.Drawing.Point(6, 34);
            this.txtCodigoKit.Name = "txtCodigoKit";
            this.txtCodigoKit.Size = new System.Drawing.Size(93, 20);
            this.txtCodigoKit.TabIndex = 1;
            this.txtCodigoKit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoKit_KeyPress);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(107, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(341, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripción";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCantidad);
            this.groupBox2.Controls.Add(this.cmbBodega);
            this.groupBox2.Controls.Add(this.txtDescripcionKit);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtCodigoKit);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(6, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(740, 63);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(456, 34);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 2;
            this.txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // cmbBodega
            // 
            this.cmbBodega.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBodega.FormattingEnabled = true;
            this.cmbBodega.Location = new System.Drawing.Point(564, 34);
            this.cmbBodega.Name = "cmbBodega";
            this.cmbBodega.Size = new System.Drawing.Size(169, 21);
            this.cmbBodega.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(564, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Bodega Destino";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(456, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cantidad";
            // 
            // dgvDatosVenta
            // 
            this.dgvDatosVenta.AllowUserToAddRows = false;
            this.dgvDatosVenta.AllowUserToDeleteRows = false;
            this.dgvDatosVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosVenta.Location = new System.Drawing.Point(8, 90);
            this.dgvDatosVenta.Name = "dgvDatosVenta";
            this.dgvDatosVenta.RowHeadersVisible = false;
            this.dgvDatosVenta.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDatosVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvDatosVenta.Size = new System.Drawing.Size(738, 212);
            this.dgvDatosVenta.TabIndex = 3;
            this.dgvDatosVenta.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvDatosVenta_DataError);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(6, 308);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 32);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(91, 308);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 32);
            this.btnModificar.TabIndex = 5;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(176, 308);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 32);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(261, 308);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 32);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(671, 308);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 32);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblFolio
            // 
            this.lblFolio.AutoSize = true;
            this.lblFolio.Location = new System.Drawing.Point(717, 9);
            this.lblFolio.Name = "lblFolio";
            this.lblFolio.Size = new System.Drawing.Size(26, 13);
            this.lblFolio.TabIndex = 9;
            this.lblFolio.Text = "folio";
            this.lblFolio.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblFolio.DoubleClick += new System.EventHandler(this.lblFolio_DoubleClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(635, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "FOLIO";
            // 
            // gpbBuscaFolio
            // 
            this.gpbBuscaFolio.Controls.Add(this.btnCerrarBusca);
            this.gpbBuscaFolio.Controls.Add(this.btnBuscar);
            this.gpbBuscaFolio.Controls.Add(this.txtFolioBuscar);
            this.gpbBuscaFolio.Controls.Add(this.label6);
            this.gpbBuscaFolio.Location = new System.Drawing.Point(548, 32);
            this.gpbBuscaFolio.Name = "gpbBuscaFolio";
            this.gpbBuscaFolio.Size = new System.Drawing.Size(200, 97);
            this.gpbBuscaFolio.TabIndex = 11;
            this.gpbBuscaFolio.TabStop = false;
            // 
            // btnCerrarBusca
            // 
            this.btnCerrarBusca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarBusca.Location = new System.Drawing.Point(162, 11);
            this.btnCerrarBusca.Name = "btnCerrarBusca";
            this.btnCerrarBusca.Size = new System.Drawing.Size(33, 23);
            this.btnCerrarBusca.TabIndex = 3;
            this.btnCerrarBusca.Text = "X";
            this.btnCerrarBusca.UseVisualStyleBackColor = true;
            this.btnCerrarBusca.Click += new System.EventHandler(this.btnCerrarBusca_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(57, 68);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtFolioBuscar
            // 
            this.txtFolioBuscar.Location = new System.Drawing.Point(45, 45);
            this.txtFolioBuscar.Name = "txtFolioBuscar";
            this.txtFolioBuscar.Size = new System.Drawing.Size(100, 20);
            this.txtFolioBuscar.TabIndex = 1;
            this.txtFolioBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFolioBuscar_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(45, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Folio a Buscar";
            // 
            // frmArmaKit
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(758, 352);
            this.Controls.Add(this.gpbBuscaFolio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblFolio);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dgvDatosVenta);
            this.Controls.Add(this.groupBox2);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmArmaKit";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Modulo Arma Kit";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmArmaKit_KeyDown);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosVenta)).EndInit();
            this.gpbBuscaFolio.ResumeLayout(false);
            this.gpbBuscaFolio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    private void dgvDatosVenta_DataError(object sender, DataGridViewDataErrorEventArgs e)
    {
        try
        {
            //MessageBox.Show(e.Exception.Message);
        }
        catch (Exception ex)
        {
           
        }
    }
  }
}
