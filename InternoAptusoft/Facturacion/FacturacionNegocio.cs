 
// Type: Aptusoft.InternoAptusoft.Facturacion.FacturacionNegocio
 
 
// version 1.8.0

using Aptusoft;
using Aptusoft.FacturaElectronica.Clases;
using Aptusoft.FacturaElectronica.Clases.CreaXml;
using Aptusoft.FacturaElectronica.Clases.PDF417;
using Aptusoft.InternoAptusoft.Contratacion;
using Aptusoft.Lotes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace Aptusoft.InternoAptusoft.Facturacion
{
  public class FacturacionNegocio
  {
    private string _rutaElectronica = "";

    public bool BuscaContratoFacturado(int idContrato, DateTime fechaFacturacion)
    {
      return new FacturacionDato().BuscaContratoFacturado(idContrato, fechaFacturacion);
    }

    public bool BuscaContratoFacturadoAlgunaVez(int idContrato)
    {
      return new FacturacionDato().BuscaContratoFacturadoAlgunaVez(idContrato);
    }

    public int CreaFacturaElectronica(ContratoVO con, DateTime fechaFacturacion)
    {
      int num1 = this.obtieneFolioFacturaDisponible();
      if (num1 > 0)
      {
        Venta venta1 = new Venta();
        venta1.Caja = frmMenuPrincipal.listaUsuario[0].IdCaja;
        DateTime dateTime1 =DateTime.Now;
        // ISSUE: explicit reference operation
        // ISSUE: variable of a reference type
        DateTime local1 = dateTime1;
        int year1 = fechaFacturacion.Year;
        int month1 = fechaFacturacion.Month;
        int day1 = fechaFacturacion.Day;
        TimeSpan timeOfDay = DateTime.Now.TimeOfDay;
        int hours1 = timeOfDay.Hours;
        DateTime now1 = DateTime.Now;
        timeOfDay = now1.TimeOfDay;
        int minutes1 = timeOfDay.Minutes;
        now1 = DateTime.Now;
        timeOfDay = now1.TimeOfDay;
        int seconds1 = timeOfDay.Seconds;
        // ISSUE: explicit reference operation
        local1 = new DateTime(year1, month1, day1, hours1, minutes1, seconds1);
        DateTime dateTime2=DateTime.Now;
        // ISSUE: explicit reference operation
        // ISSUE: variable of a reference type
        DateTime local2 = @dateTime2;
        int year2 = fechaFacturacion.Year;
        int month2 = fechaFacturacion.Month;
        int day2 = fechaFacturacion.Day;
        now1 = DateTime.Now;
        timeOfDay = now1.TimeOfDay;
        int hours2 = timeOfDay.Hours;
        DateTime now2 = DateTime.Now;
        timeOfDay = now2.TimeOfDay;
        int minutes2 = timeOfDay.Minutes;
        now2 = DateTime.Now;
        timeOfDay = now2.TimeOfDay;
        int seconds2 = timeOfDay.Seconds;
        // ISSUE: explicit reference operation
        local2 = new DateTime(year2, month2, day2, hours2, minutes2, seconds2);
        dateTime2.AddDays(6.0);
        venta1.FechaEmision = dateTime1;
        venta1.FechaVencimiento = dateTime2;
        venta1.IdCliente = con.IdCliente;
        ClienteVO clienteVo = new Cliente().buscaCodigoCliente(con.IdCliente);
        venta1.Rut = clienteVo.Rut;
        venta1.Digito = clienteVo.Digito;
        venta1.RazonSocial = clienteVo.RazonSocial;
        venta1.Direccion = clienteVo.Direccion;
        venta1.Comuna = clienteVo.Comuna;
        venta1.Ciudad = clienteVo.Ciudad;
        venta1.Giro = clienteVo.Giro;
        venta1.Fono = clienteVo.Telefono;
        venta1.Fax = clienteVo.Fax;
        venta1.Contacto = clienteVo.Contacto;
        venta1.DiasPlazo = clienteVo.DiasPlazo.Length > 0 ? Convert.ToInt32(clienteVo.DiasPlazo) : 0;
        venta1.IdMedioPago = 7;
        venta1.MedioPago = "TRANSFERENCIA ELECTRONICA";
        venta1.IdVendedor = 57;
        venta1.Vendedor = "NICOLE PEREZ";
        venta1.IdCentroCosto = 7;
        venta1.CentroCosto = "CLIENTE ACTIVO";
        venta1.OrdenCompra = "";
        venta1.SubTotal = con.SubTotal;
        venta1.PorcentajeDescuento = con.DescuentoOferta;
        venta1.Descuento = con.Descuento;
        venta1.PorcentajeIva = new Decimal(19);
        Venta venta2 = venta1;
        Decimal num2 = con.Total;
        Decimal num3 = Convert.ToDecimal(num2.ToString("N0"));
        venta2.Neto = num3;
        Venta venta3 = venta1;
        num2 = venta1.Neto * new Decimal(19, 0, 0, false, (byte) 2);
        Decimal num4 = Convert.ToDecimal(num2.ToString("N0"));
        venta3.Iva = num4;
        venta1.TotalExento = new Decimal(0);
        venta1.Total = Convert.ToDecimal((venta1.Neto + venta1.Iva).ToString("N0"));
        NumeroaLetra numeroaLetra = new NumeroaLetra();
        venta1.TotalPalabras = numeroaLetra.enletras(venta1.Total.ToString("N0"));
        venta1.FolioGuias = "";
        venta1.Observaciones = "";
        venta1.FolioTicket = 0;
        venta1.IdTicket = 0;
        venta1.FolioCotizacion = 0;
        venta1.IdCotizacion = 0;
        venta1.FolioNotaVenta = 0;
        venta1.IdNotaVenta = 0;
        venta1.FolioOT = 0;
        venta1.Impuesto1 = new Decimal(0);
        venta1.PorcentajeImpuesto1 = new Decimal(0);
        venta1.Impuesto2 = new Decimal(0);
        venta1.PorcentajeImpuesto2 = new Decimal(0);
        venta1.Impuesto3 = new Decimal(0);
        venta1.PorcentajeImpuesto3 = new Decimal(0);
        venta1.Impuesto4 = new Decimal(0);
        venta1.PorcentajeImpuesto4 = new Decimal(0);
        venta1.Impuesto5 = new Decimal(0);
        venta1.PorcentajeImpuesto5 = new Decimal(0);
        venta1.EstadoPago = "PENDIENTE";
        venta1.TotalPagado = new Decimal(0);
        venta1.TotalDocumentado = new Decimal(0);
        venta1.TotalPendiente = venta1.Total;
        venta1.EstadoDocumento = "EMITIDA";
        EFactura efactura = new EFactura();
        venta1.Folio = num1;
        List<DatosVentaVO> list = new List<DatosVentaVO>();
        list.Add(this.AgregaLineaLista(con.Codigo, con.Descripcion, con.SubTotal));
        for (int index = 0; index < list.Count; ++index)
        {
          if (index == 0)
            venta1.IT1 = list[index].Descripcion;
          list[index].FolioFactura = venta1.Folio;
          list[index].FechaIngreso = venta1.FechaEmision;
          list[index].Usuario = frmMenuPrincipal.listaUsuario[0].NombreUsuario;
        }
        efactura.agregaFactura(venta1);
        List<LoteVO> listaLote = new List<LoteVO>();
        efactura.agregaDetalleFactura(list, listaLote);
        this.creaXML(venta1, list);
        this.creaPDF(venta1.Folio);
        this.GuardaFacturacion(new FacturacionVO()
        {
          IdContrato = con.IdContrato,
          IdCliente = con.IdCliente,
          IdDocumentoVenta = new EFactura().RetornaIdFactura(venta1.Folio),
          FolioDocumentoVenta = venta1.Folio
        });
      }
      return num1;
    }

    public void GuardaFacturacion(FacturacionVO fa)
    {
      new FacturacionDato().GuardaFacturacion(fa);
    }

    private void CargaRuta()
    {
      try
      {
        DataSet dataSet = new DataSet("datos");
        int num = (int) dataSet.ReadXml("C:\\AptuSoft\\xml\\config.xml");
        string filterExpression = "principal=1";
        DataRow[] dataRowArray = dataSet.Tables["conexion"].Select(filterExpression);
        string str = "";
        for (int index = 0; index < dataRowArray.Length; ++index)
          str = dataRowArray[index]["rutaElectronica"].ToString();
        this._rutaElectronica = str.Replace("\\", "\\\\") + "\\\\";
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error al Cargar Ruta " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private bool compruebaExisteArchivoCaf(string archivoCaf)
    {
      this.CargaRuta();
      bool flag = false;
      if (File.Exists(this._rutaElectronica + "CAF\\E-Factura\\" + archivoCaf))
        flag = true;
      return flag;
    }

    private int obtieneFolioFacturaDisponible()
    {
      int folio = new EFactura().numeroFactura(frmMenuPrincipal.listaUsuario[0].IdCaja);
      string archivoCaf = new Caf().archivoCaf(33, folio);
      if (this.compruebaExisteArchivoCaf(archivoCaf))
      {
        if (archivoCaf.Length == 0)
        {
          int num = (int) MessageBox.Show("No hay folios CAF disponibles, debe solicitar a SII y cargar en sistema", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          folio = 0;
        }
      }
      else
      {
        int num = (int) MessageBox.Show("No Existe Archivo CAF en este PC, Debe solicitarlo al Administrador del Sistema, sin este archivo No podra Emitir documentos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        folio = 0;
      }
      return folio;
    }

    private DatosVentaVO AgregaLineaLista(string codigo, string descripcion, Decimal neto)
    {
      return new DatosVentaVO()
      {
        Codigo = codigo,
        Descripcion = descripcion,
        IdImpuesto = 0,
        NetoLinea = neto,
        DescuentaInventario = true,
        ValorCompra = new Decimal(0),
        ValorVenta = neto,
        Cantidad = new Decimal(1),
        Descuento = new Decimal(0),
        PorcDescuento = new Decimal(0),
        TotalLinea = neto,
        SubTotalLinea = neto,
        TipoDescuento = 0,
        ListaPrecio = 1,
        Bodega = 1,
        FolioFactura = 0,
        Exento = false
      };
    }

    private void creaXML(Venta ve, List<DatosVentaVO> listaDetalle)
    {
      ve.Fe_TipoDTE = 33;
      ve.Fe_FchEmis = ve.FechaEmision.ToString("yyyy-MM-dd");
      GeneradorXML generadorXml = new GeneradorXML();
      int tipoDescuento = 0;
      if (ve.PorcentajeDescuento > new Decimal(0))
        tipoDescuento = 2;
      else if (ve.Descuento > new Decimal(0))
        tipoDescuento = 3;
      List<ReferenicaVO> listaReferencia = new List<ReferenicaVO>();
      generadorXml.armaXML(ve, listaDetalle, listaReferencia, tipoDescuento);
      this.armaCodigoPDF417("EFactura_" + ve.Folio.ToString("##"), ve.Folio);
    }

    private void armaCodigoPDF417(string documento, int folio)
    {
      try
      {
        this.CargaRuta();
        XDocument xdocument = XDocument.Load(this._rutaElectronica + "DTE\\E-Factura\\EFacturaXML\\" + documento + ".XML", LoadOptions.PreserveWhitespace);
        xdocument.Declaration.Encoding = "ISO-8859-1";
        new XmlNamespaceManager((XmlNameTable) new NameTable()).AddNamespace("sii", "http://www.sii.cl/SiiDte");
        XElement xelement = System.Xml.XPath.Extensions.XPathSelectElement((XNode) xdocument, "DTE/Documento/TED");
        string str1 = xelement.ToString().Replace(Environment.NewLine, "");
        if (xelement != null)
        {
          string str2 = str1;
          CodigoPDF417 codigoPdF417 = new CodigoPDF417();
          new ImagenPdf417().agregaImagenPdf417(new ImagenPdf417VO()
          {
            Imagen = codigoPdF417.creaPdf417(str2.Trim()),
            FolioDte = folio,
            TipoDte = 33
          });
        }
        else
        {
          int num = (int) MessageBox.Show("Error al armar PDF417", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Error PDF417" + ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void creaPDF(int folioFactura)
    {
      csCreaPDF csCreaPdf = new csCreaPDF();
      string archivoRpt1;
      string archivoRpt2;
      if (frmMenuPrincipal._MultiEmpresa)
      {
        ArrayList arrayList = new ArrayList();
        string str = new LeeXml().cargarDatosMultiEmpresa("factura")[1].ToString();
        archivoRpt1 = "FacturaElectronica_" + str + ".rpt";
        archivoRpt2 = "FacturaElectronicaCedible_" + str + ".rpt";
      }
      else
      {
        archivoRpt1 = "FacturaElectronica.rpt";
        archivoRpt2 = "FacturaElectronicaCedible.rpt";
      }
      string nombre_archivo1 = "EFactura_" + folioFactura.ToString();
      int tipoDoc = 33;
      DataTable dt = new EFactura().muestraFacturaFolio(folioFactura);
      csCreaPdf.creaPDF(archivoRpt1, nombre_archivo1, tipoDoc, dt);
      string nombre_archivo2 = "EFacturaCedible_" + folioFactura.ToString();
      csCreaPdf.creaPDF(archivoRpt2, nombre_archivo2, tipoDoc, dt);
    }

    public List<FacturacionVO> BuscaFacturacionIdCliente(int idCliente)
    {
      return new FacturacionDato().BuscaFacturacionIdCliente(idCliente);
    }
  }
}
