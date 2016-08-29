 
// Type: Aptusoft.FacturaElectronica.Clases.CreaXml.GeneradorXML
 
 
// version 1.8.0

using Aptusoft;
using Aptusoft.FacturaElectronica.Clases;
using Aptusoft.FacturaElectronica.Clases.FirmaTimbreXML;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Collections;

namespace Aptusoft.FacturaElectronica.Clases.CreaXml
{
  public class GeneradorXML
  {
    private string _rutaElectronica = "";
    private string multi = new LeeXml().cargarDatosMultiEmpresa("factura")[1].ToString();
    private string impresora = new LeeXml().cargarDatosMultiEmpresa("factura")[0].ToString();

    public void armaXML(Venta ve, List<DatosVentaVO> lista, List<ReferenicaVO> listaReferencia, int tipoDescuento)
    {
      this.CargaRuta();
      this.creaXML(ve, lista, listaReferencia, tipoDescuento);
        this.creaXMLcontribuyente(ve, lista, listaReferencia, tipoDescuento);
    }

    public void armaXMLCliente(Venta ve, List<DatosVentaVO> lista, List<ReferenicaVO> listaReferencia, int tipoDescuento)
    {
        this.CargaRuta();
        this.creaXMLcontribuyente(ve, lista, listaReferencia, tipoDescuento);
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

    private void creaXML(Venta ve, List<DatosVentaVO> lista, List<ReferenicaVO> listaReferencia, int tipoDescuento)
    {
        string str = new LeeXml().cargarDatosMultiEmpresa("factura")[1].ToString();
      csDTE csDte = new csDTE();
      EmisorVO emisorVo = new Emisor().buscaEmisor();
      csDte.Documento.Encabezado.IdDoc.TipoDTE = ve.Fe_TipoDTE;
      csDte.Documento.Encabezado.IdDoc.Folio = ve.Folio;
      csDte.Documento.Encabezado.IdDoc.FchEmis = ve.Fe_FchEmis;
      csDte.Documento.Encabezado.IdDoc.IndServicio = ve.Fe_IndServicio <= 0 ? 0 : ve.Fe_IndServicio;
      if (ve.FE_codigoTrasladadaPor > 0)
        csDte.Documento.Encabezado.IdDoc.TipoDespacho = ve.FE_codigoTrasladadaPor;
      if (ve.FE_codigoTipoGuia > 0)
        csDte.Documento.Encabezado.IdDoc.IndTraslado = ve.FE_codigoTipoGuia;
      if (emisorVo.ValoresConIva)
        csDte.Documento.Encabezado.IdDoc.MntBruto = 1;
      csDte.Documento.Encabezado.Emisor.RUTEmisor = emisorVo.RutEmisior;
      csDte.Documento.Encabezado.Emisor.RznSoc = emisorVo.RazonSocial;
      csDte.Documento.Encabezado.Emisor.RznSocEmisor = "";
      csDte.Documento.Encabezado.Emisor.GiroEmis = emisorVo.Giro;
      csDte.Documento.Encabezado.Emisor.GiroEmisor = "";
      csDte.Documento.Encabezado.Emisor.Acteco = Convert.ToInt32(emisorVo.CodActCome);
      csDte.Documento.Encabezado.Emisor.CdgSIISucur = Convert.ToInt32(emisorVo.CodSucursal);
      csDte.Documento.Encabezado.Emisor.DirOrigen = emisorVo.Direccion;
      csDte.Documento.Encabezado.Emisor.CmnaOrigen = emisorVo.Comuna;
      csDte.Documento.Encabezado.Emisor.CiudadOrigen = emisorVo.Ciudad;
      if (ve.Digito.Equals("k"))
        ve.Digito = "K";
      csDte.Documento.Encabezado.Receptor.RUTRecep = ve.Rut + "-" + ve.Digito;
      if (ve.RazonSocial.Length > 99)
        ve.RazonSocial = ve.RazonSocial.Substring(0, 99);
      csDte.Documento.Encabezado.Receptor.RznSocRecep = ve.RazonSocial;
      if (ve.Giro.Length > 39)
        ve.Giro = ve.Giro.Substring(0, 39);
      csDte.Documento.Encabezado.Receptor.GiroRecep = ve.Giro;
      csDte.Documento.Encabezado.Receptor.DirRecep = ve.Direccion;
      csDte.Documento.Encabezado.Receptor.CmnaRecep = ve.Comuna;
      csDte.Documento.Encabezado.Receptor.CiudadRecep = ve.Ciudad;
      csDte.Documento.Encabezado.Totales.MntNeto = ve.Neto;
      if (ve.TotalExento > new Decimal(0))
        csDte.Documento.Encabezado.Totales.MntExe = ve.TotalExento;
      csDte.Documento.Encabezado.Totales.TasaIVA = Convert.ToInt32(ve.PorcentajeIva);
      csDte.Documento.Encabezado.Totales.IVA = ve.Iva;
      if (ve.Impuesto1 > new Decimal(0) || ve.Impuesto2 > new Decimal(0) || (ve.Impuesto3 > new Decimal(0) || ve.Impuesto4 > new Decimal(0)) || ve.Impuesto4 > new Decimal(0))
      {
        csDte.Documento.Encabezado.Totales.ImptoReten = new List<csImpuestos>();
        csImpuestos csImpuestos = new csImpuestos();
        if (ve.Impuesto1 > new Decimal(0))
          csDte.Documento.Encabezado.Totales.ImptoReten.Add(new csImpuestos()
          {
            TipoImp = ve.CodImpuesto1,
            TasaImp = ve.PorcentajeImpuesto1,
            MontoImp = ve.Impuesto1
          });
        if (ve.Impuesto2 > new Decimal(0))
          csDte.Documento.Encabezado.Totales.ImptoReten.Add(new csImpuestos()
          {
            TipoImp = ve.CodImpuesto2,
            TasaImp = ve.PorcentajeImpuesto2,
            MontoImp = ve.Impuesto2
          });
        if (ve.Impuesto3 > new Decimal(0))
          csDte.Documento.Encabezado.Totales.ImptoReten.Add(new csImpuestos()
          {
            TipoImp = ve.CodImpuesto3,
            TasaImp = ve.PorcentajeImpuesto3,
            MontoImp = ve.Impuesto3
          });
        if (ve.Impuesto4 > new Decimal(0))
          csDte.Documento.Encabezado.Totales.ImptoReten.Add(new csImpuestos()
          {
            TipoImp = ve.CodImpuesto4,
            TasaImp = ve.PorcentajeImpuesto4,
            MontoImp = ve.Impuesto4
          });
        if (ve.Impuesto5 > new Decimal(0))
          csDte.Documento.Encabezado.Totales.ImptoReten.Add(new csImpuestos()
          {
            TipoImp = ve.CodImpuesto5,
            TasaImp = ve.PorcentajeImpuesto5,
            MontoImp = ve.Impuesto5
          });
      }
      csDte.Documento.Encabezado.Totales.MntTotal = ve.Total;
      csDte.Documento.Detalles = new List<csDetalle>();
      csDetalle csDetalle1 = new csDetalle();
      int num1 = 1;
      foreach (DatosVentaVO datosVentaVo in lista)
      {
        csDetalle csDetalle2 = new csDetalle();
        csDetalle2.NroLinDet = num1;
        csDetalle2.CdgItem.TpoCodigo = "INT1";
        csDetalle2.CdgItem.VlrCodigo = datosVentaVo.Codigo;
        if (datosVentaVo.Exento)
          csDetalle2.IndExe = 1;
        if (ve.Fe_TipoDTE == 34)
          csDetalle2.IndExe = 1;
        csDetalle2.NmbItem = datosVentaVo.Descripcion;
        csDetalle2.DscItem = ve.Fe_TipoDTE == 34 ? "PRODUCTO EXENTO" : "PRODUCTO AFECTO";
        if (ve.Fe_TipoDTE == 34)
        {
          csDetalle2.UnmdItem = ve.Observaciones.Length <= 0 ? "" : ve.Observaciones;
        }
        else
        csDetalle2.UnmdItem = "UNID";
        csDetalle2.QtyItem = datosVentaVo.Cantidad;
        csDetalle2.PrcItem = Convert.ToDecimal(datosVentaVo.ValorVenta.ToString("N0"));
        if (datosVentaVo.PorcDescuento != new Decimal(0))
          csDetalle2.DescuentoPct = Convert.ToInt32(datosVentaVo.PorcDescuento);
        if (datosVentaVo.Descuento > new Decimal(0))
          csDetalle2.DescuentoMonto = Convert.ToDecimal(datosVentaVo.Descuento.ToString("N0"));
        if (datosVentaVo.IdImpuesto > 0)
          csDetalle2.CodImpAdic = datosVentaVo.CodigoImpuesto;
        csDetalle2.MontoItem = Convert.ToDecimal(datosVentaVo.TotalLinea.ToString("N0"));
        csDte.Documento.Detalles.Add(csDetalle2);
        ++num1;
      }
      if (tipoDescuento == 2)
      {
        csDte.Documento.DscRcgGlobal = new List<csDscRcgGlobal>();
        csDscRcgGlobal csDscRcgGlobal = new csDscRcgGlobal();
        int num2 = 1;
        csDscRcgGlobal.NroLinDR = num2;
        csDscRcgGlobal.TpoMov = "D";
        csDscRcgGlobal.TpoValor = "%";
        csDscRcgGlobal.ValorDR = Convert.ToInt32(ve.PorcentajeDescuento);
        csDte.Documento.DscRcgGlobal.Add(csDscRcgGlobal);
      }
      if (tipoDescuento == 3)
      {
        csDte.Documento.DscRcgGlobal = new List<csDscRcgGlobal>();
        csDscRcgGlobal csDscRcgGlobal = new csDscRcgGlobal();
        int num2 = 1;
        csDscRcgGlobal.NroLinDR = num2;
        csDscRcgGlobal.TpoMov = "D";
        csDscRcgGlobal.TpoValor = "$";
        csDscRcgGlobal.ValorDR = Convert.ToInt32(ve.Descuento);
        csDte.Documento.DscRcgGlobal.Add(csDscRcgGlobal);
      }
      if (listaReferencia.Count > 0)
      {
        csDte.Documento.Referencias = new List<csReferencia>();
        csReferencia csReferencia1 = new csReferencia();
        int num2 = 1;
        foreach (ReferenicaVO referenicaVo in listaReferencia)
        {
          csReferencia csReferencia2 = new csReferencia();
          csReferencia2.NroLinRef = num2;
          csReferencia2.TpoDocRef = referenicaVo.TipoDocumento != 0 ? referenicaVo.TipoDocumento.ToString() : referenicaVo.TipoDocumentoNombre;
          if (referenicaVo.IndGlobal > 0)
            csReferencia2.IndGlobal = 1;
          csReferencia2.FolioRef = referenicaVo.FolioDocumentoReferencia;
          csReferencia2.FchRef = referenicaVo.FechaDocumentoReferencia.ToString("yyyy-MM-dd");
          if (referenicaVo.TipoAccion > 0 && referenicaVo.TipoAccion < 4)
            csReferencia2.CodRef = referenicaVo.TipoAccion;
          csReferencia2.RazonRef = referenicaVo.RazonReferencia;
          csDte.Documento.Referencias.Add(csReferencia2);
          ++num2;
        }
      }
      csDte.calcularMontos = false;
      string nombreArchivo = "";
      if (ve.Fe_TipoDTE == 33)
        nombreArchivo = "EFactura_" + (object) ve.Folio+"_"+str;
      if (ve.Fe_TipoDTE == 34)
          nombreArchivo = "EFacturaExenta_" + (object)ve.Folio + "_" + str;
      if (ve.Fe_TipoDTE == 61)
          nombreArchivo = "ENotaCredito_" + (object)ve.Folio + "_" + str;
      if (ve.Fe_TipoDTE == 56)
          nombreArchivo = "ENotaDebito_" + (object)ve.Folio + "_" + str;
      if (ve.Fe_TipoDTE == 52)
          nombreArchivo = "EGuia_" + (object)ve.Folio + "_" + str;
      csDte.Serializar(nombreArchivo, ve.Fe_TipoDTE);
      string archivoCaf = new Caf().archivoCaf(ve.Fe_TipoDTE, ve.Folio);
      this.agregaCaf(nombreArchivo, ve.Fe_TipoDTE, ve.Folio, archivoCaf);
      Boolean esContribuyente = false;
      this.timbrarDTE(emisorVo.CertificadoDigital, ve.Fe_TipoDTE, nombreArchivo, archivoCaf, ve.Rut + "-" + ve.Digito, esContribuyente);
    }

    private void creaXMLcontribuyente(Venta ve, List<DatosVentaVO> lista, List<ReferenicaVO> listaReferencia, int tipoDescuento)
    {
        string str = new LeeXml().cargarDatosMultiEmpresa("factura")[1].ToString();
        csDTE csDte = new csDTE();
        EmisorVO emisorVo = new Emisor().buscaEmisor();
        csDte.Documento.Encabezado.IdDoc.TipoDTE = ve.Fe_TipoDTE;
        csDte.Documento.Encabezado.IdDoc.Folio = ve.Folio;
        csDte.Documento.Encabezado.IdDoc.FchEmis = ve.Fe_FchEmis;
        csDte.Documento.Encabezado.IdDoc.IndServicio = ve.Fe_IndServicio <= 0 ? 0 : ve.Fe_IndServicio;
        if (ve.FE_codigoTrasladadaPor > 0)
            csDte.Documento.Encabezado.IdDoc.TipoDespacho = ve.FE_codigoTrasladadaPor;
        if (ve.FE_codigoTipoGuia > 0)
            csDte.Documento.Encabezado.IdDoc.IndTraslado = ve.FE_codigoTipoGuia;
        if (emisorVo.ValoresConIva)
            csDte.Documento.Encabezado.IdDoc.MntBruto = 1;
        csDte.Documento.Encabezado.Emisor.RUTEmisor = emisorVo.RutEmisior;
        csDte.Documento.Encabezado.Emisor.RznSoc = emisorVo.RazonSocial;
        csDte.Documento.Encabezado.Emisor.RznSocEmisor = "";
        csDte.Documento.Encabezado.Emisor.GiroEmis = emisorVo.Giro;
        csDte.Documento.Encabezado.Emisor.GiroEmisor = "";
        csDte.Documento.Encabezado.Emisor.Acteco = Convert.ToInt32(emisorVo.CodActCome);
        csDte.Documento.Encabezado.Emisor.CdgSIISucur = Convert.ToInt32(emisorVo.CodSucursal);
        csDte.Documento.Encabezado.Emisor.DirOrigen = emisorVo.Direccion;
        csDte.Documento.Encabezado.Emisor.CmnaOrigen = emisorVo.Comuna;
        csDte.Documento.Encabezado.Emisor.CiudadOrigen = emisorVo.Ciudad;
        if (ve.Digito.Equals("k"))
            ve.Digito = "K";
        csDte.Documento.Encabezado.Receptor.RUTRecep = ve.Rut + "-" + ve.Digito;
        if (ve.RazonSocial.Length > 99)
            ve.RazonSocial = ve.RazonSocial.Substring(0, 99);
        csDte.Documento.Encabezado.Receptor.RznSocRecep = ve.RazonSocial;
        if (ve.Giro.Length > 39)
            ve.Giro = ve.Giro.Substring(0, 39);
        csDte.Documento.Encabezado.Receptor.GiroRecep = ve.Giro;
        csDte.Documento.Encabezado.Receptor.DirRecep = ve.Direccion;
        csDte.Documento.Encabezado.Receptor.CmnaRecep = ve.Comuna;
        csDte.Documento.Encabezado.Receptor.CiudadRecep = ve.Ciudad;
        csDte.Documento.Encabezado.Totales.MntNeto = ve.Neto;
        if (ve.TotalExento > new Decimal(0))
            csDte.Documento.Encabezado.Totales.MntExe = ve.TotalExento;
        csDte.Documento.Encabezado.Totales.TasaIVA = Convert.ToInt32(ve.PorcentajeIva);
        csDte.Documento.Encabezado.Totales.IVA = ve.Iva;
        if (ve.Impuesto1 > new Decimal(0) || ve.Impuesto2 > new Decimal(0) || (ve.Impuesto3 > new Decimal(0) || ve.Impuesto4 > new Decimal(0)) || ve.Impuesto4 > new Decimal(0))
        {
            csDte.Documento.Encabezado.Totales.ImptoReten = new List<csImpuestos>();
            csImpuestos csImpuestos = new csImpuestos();
            if (ve.Impuesto1 > new Decimal(0))
                csDte.Documento.Encabezado.Totales.ImptoReten.Add(new csImpuestos()
                {
                    TipoImp = ve.CodImpuesto1,
                    TasaImp = ve.PorcentajeImpuesto1,
                    MontoImp = ve.Impuesto1
                });
            if (ve.Impuesto2 > new Decimal(0))
                csDte.Documento.Encabezado.Totales.ImptoReten.Add(new csImpuestos()
                {
                    TipoImp = ve.CodImpuesto2,
                    TasaImp = ve.PorcentajeImpuesto2,
                    MontoImp = ve.Impuesto2
                });
            if (ve.Impuesto3 > new Decimal(0))
                csDte.Documento.Encabezado.Totales.ImptoReten.Add(new csImpuestos()
                {
                    TipoImp = ve.CodImpuesto3,
                    TasaImp = ve.PorcentajeImpuesto3,
                    MontoImp = ve.Impuesto3
                });
            if (ve.Impuesto4 > new Decimal(0))
                csDte.Documento.Encabezado.Totales.ImptoReten.Add(new csImpuestos()
                {
                    TipoImp = ve.CodImpuesto4,
                    TasaImp = ve.PorcentajeImpuesto4,
                    MontoImp = ve.Impuesto4
                });
            if (ve.Impuesto5 > new Decimal(0))
                csDte.Documento.Encabezado.Totales.ImptoReten.Add(new csImpuestos()
                {
                    TipoImp = ve.CodImpuesto5,
                    TasaImp = ve.PorcentajeImpuesto5,
                    MontoImp = ve.Impuesto5
                });
        }
        csDte.Documento.Encabezado.Totales.MntTotal = ve.Total;
        csDte.Documento.Detalles = new List<csDetalle>();
        csDetalle csDetalle1 = new csDetalle();
        int num1 = 1;
        foreach (DatosVentaVO datosVentaVo in lista)
        {
            csDetalle csDetalle2 = new csDetalle();
            csDetalle2.NroLinDet = num1;
            csDetalle2.CdgItem.TpoCodigo = "INT1";
            csDetalle2.CdgItem.VlrCodigo = datosVentaVo.Codigo;
            if (datosVentaVo.Exento)
                csDetalle2.IndExe = 1;
            if (ve.Fe_TipoDTE == 34)
                csDetalle2.IndExe = 1;
            csDetalle2.NmbItem = datosVentaVo.Descripcion;
            csDetalle2.DscItem = ve.Fe_TipoDTE == 34 ? "PRODUCTO EXENTO" : "PRODUCTO AFECTO";
            if (ve.Fe_TipoDTE == 34)
            {
                csDetalle2.UnmdItem = ve.Observaciones.Length <= 0 ? "" : ve.Observaciones;
            }
            else
                csDetalle2.UnmdItem = "UNID";
            csDetalle2.QtyItem = datosVentaVo.Cantidad;
            csDetalle2.PrcItem = Convert.ToDecimal(datosVentaVo.ValorVenta.ToString("N0"));
            if (datosVentaVo.PorcDescuento != new Decimal(0))
                csDetalle2.DescuentoPct = Convert.ToInt32(datosVentaVo.PorcDescuento);
            if (datosVentaVo.Descuento > new Decimal(0))
                csDetalle2.DescuentoMonto = Convert.ToDecimal(datosVentaVo.Descuento.ToString("N0"));
            if (datosVentaVo.IdImpuesto > 0)
                csDetalle2.CodImpAdic = datosVentaVo.CodigoImpuesto;
            csDetalle2.MontoItem = Convert.ToDecimal(datosVentaVo.TotalLinea.ToString("N0"));
            csDte.Documento.Detalles.Add(csDetalle2);
            ++num1;
        }
        if (tipoDescuento == 2)
        {
            csDte.Documento.DscRcgGlobal = new List<csDscRcgGlobal>();
            csDscRcgGlobal csDscRcgGlobal = new csDscRcgGlobal();
            int num2 = 1;
            csDscRcgGlobal.NroLinDR = num2;
            csDscRcgGlobal.TpoMov = "D";
            csDscRcgGlobal.TpoValor = "%";
            csDscRcgGlobal.ValorDR = Convert.ToInt32(ve.PorcentajeDescuento);
            csDte.Documento.DscRcgGlobal.Add(csDscRcgGlobal);
        }
        if (tipoDescuento == 3)
        {
            csDte.Documento.DscRcgGlobal = new List<csDscRcgGlobal>();
            csDscRcgGlobal csDscRcgGlobal = new csDscRcgGlobal();
            int num2 = 1;
            csDscRcgGlobal.NroLinDR = num2;
            csDscRcgGlobal.TpoMov = "D";
            csDscRcgGlobal.TpoValor = "$";
            csDscRcgGlobal.ValorDR = Convert.ToInt32(ve.Descuento);
            csDte.Documento.DscRcgGlobal.Add(csDscRcgGlobal);
        }
        if (listaReferencia.Count > 0)
        {
            csDte.Documento.Referencias = new List<csReferencia>();
            csReferencia csReferencia1 = new csReferencia();
            int num2 = 1;
            foreach (ReferenicaVO referenicaVo in listaReferencia)
            {
                csReferencia csReferencia2 = new csReferencia();
                csReferencia2.NroLinRef = num2;
                csReferencia2.TpoDocRef = referenicaVo.TipoDocumento != 0 ? referenicaVo.TipoDocumento.ToString() : referenicaVo.TipoDocumentoNombre;
                if (referenicaVo.IndGlobal > 0)
                    csReferencia2.IndGlobal = 1;
                csReferencia2.FolioRef = referenicaVo.FolioDocumentoReferencia;
                csReferencia2.FchRef = referenicaVo.FechaDocumentoReferencia.ToString("yyyy-MM-dd");
                if (referenicaVo.TipoAccion > 0 && referenicaVo.TipoAccion < 4)
                    csReferencia2.CodRef = referenicaVo.TipoAccion;
                csReferencia2.RazonRef = referenicaVo.RazonReferencia;
                csDte.Documento.Referencias.Add(csReferencia2);
                ++num2;
            }
        }
        csDte.calcularMontos = false;
        string nombreArchivo = "";
        if (ve.Fe_TipoDTE == 33)
            nombreArchivo = "EFactura_" + (object)ve.Folio + "_" + str + "_envio_Contribuyente";
        if (ve.Fe_TipoDTE == 34)
            nombreArchivo = "EFacturaExenta_" + (object)ve.Folio + "_" + str + "_envio_Contribuyente";
        if (ve.Fe_TipoDTE == 61)
            nombreArchivo = "ENotaCredito_" + (object)ve.Folio + "_" + str + "_envio_Contribuyente";
        if (ve.Fe_TipoDTE == 56)
            nombreArchivo = "ENotaDebito_" + (object)ve.Folio + "_" + str + "_envio_Contribuyente";
        if (ve.Fe_TipoDTE == 52)
            nombreArchivo = "EGuia_" + (object)ve.Folio + str + "_" + "_envio_Contribuyente";
        csDte.Serializar(nombreArchivo, ve.Fe_TipoDTE);
        string archivoCaf = new Caf().archivoCaf(ve.Fe_TipoDTE, ve.Folio);
        this.agregaCaf(nombreArchivo, ve.Fe_TipoDTE, ve.Folio, archivoCaf);
        Boolean esContribuyente = true;
        this.timbrarDTE(emisorVo.CertificadoDigital, ve.Fe_TipoDTE, nombreArchivo, archivoCaf, ve.Rut + "-" + ve.Digito, esContribuyente);
    }

    private void agregaCaf(string nombreArchivo, int tipoDocumento, int folio, string archivoCaf)
    {
        string str = new LeeXml().cargarDatosMultiEmpresa("factura")[1].ToString();
      string str1 = "";
      string str2 = "";
      if (tipoDocumento == 33)
      {
        str1 = this._rutaElectronica + "DTE\\E-Factura\\EFacturaXML\\";
        str2 = this._rutaElectronica + "CAF\\E-Factura\\" + archivoCaf;
      }
      if (tipoDocumento == 34)
      {
        str1 = this._rutaElectronica + "DTE\\E-FacturaExenta\\EFacturaExentaXML\\";
        str2 = this._rutaElectronica + "CAF\\E-FacturaExenta\\" + archivoCaf;
      }
      if (tipoDocumento == 61)
      {
        str1 = this._rutaElectronica + "DTE\\E-NotaCredito\\ENotaCreditoXML\\";
        str2 = this._rutaElectronica + "CAF\\E-NotaCredito\\" + archivoCaf;
      }
      if (tipoDocumento == 56)
      {
        str1 = this._rutaElectronica + "DTE\\E-NotaDebito\\ENotaDebitoXML\\";
        str2 = this._rutaElectronica + "CAF\\E-NotaDebito\\" + archivoCaf;
      }
      if (tipoDocumento == 52)
      {
        str1 = this._rutaElectronica + "DTE\\E-Guia\\EGuiaXML\\";
        str2 = this._rutaElectronica + "CAF\\E-Guia\\" + archivoCaf;
      }
      string str3 = str1 + nombreArchivo + ".XML";
      string uri = str2;
      XDocument xdocument = XDocument.Load(str3);
      xdocument.Declaration.Encoding = "ISO-8859-1";
      XElement xelement1 = System.Xml.XPath.Extensions.XPathSelectElement((XNode) XDocument.Load(uri, LoadOptions.PreserveWhitespace), "AUTORIZACION/CAF");
      XElement xelement2 = System.Xml.XPath.Extensions.XPathSelectElement((XNode) xdocument, "DTE/Documento/TED/DD/CAF");
      if (xelement2 == null)
        System.Xml.XPath.Extensions.XPathSelectElement((XNode) xdocument, "DTE/Documento/TED/DD/IT1").AddAfterSelf((object) xelement1);
      else
        xelement2.ReplaceWith((object) xelement1);
      xdocument.Declaration = new XDeclaration("1.0", "ISO-8859-1", (string) null);
      xdocument.Save(str3);
    }

    private void timbrarDTE(string nombreCertificado, int td, string nombreArchivo, string archivoCaf, string rutReceptor, Boolean contribuyente)
    {
        
      string CN = nombreCertificado;
      string str1 = string.Empty;
      string str2 = "";
      if (td == 33)
        str2 = this._rutaElectronica + "DTE\\E-Factura\\EFacturaXML\\" + nombreArchivo + ".XML";
      if (td == 34)
          str2 = this._rutaElectronica + "DTE\\E-FacturaExenta\\EFacturaExentaXML\\" + nombreArchivo  + ".XML";
      if (td == 61)
          str2 = this._rutaElectronica + "DTE\\E-NotaCredito\\ENotaCreditoXML\\" + nombreArchivo  + ".XML";
      if (td == 56)
          str2 = this._rutaElectronica + "DTE\\E-NotaDebito\\ENotaDebitoXML\\" + nombreArchivo + ".XML";
      if (td == 52)
          str2 = this._rutaElectronica + "DTE\\E-Guia\\EGuiaXML\\" + nombreArchivo + ".XML";
      string str3 = str2;
      string uri = "";
      if (td == 33)
        uri = this._rutaElectronica + "CAF\\E-Factura\\" + archivoCaf;
      if (td == 34)
        uri = this._rutaElectronica + "CAF\\E-FacturaExenta\\" + archivoCaf;
      if (td == 61)
        uri = this._rutaElectronica + "CAF\\E-NotaCredito\\" + archivoCaf;
      if (td == 56)
        uri = this._rutaElectronica + "CAF\\E-NotaDebito\\" + archivoCaf;
      if (td == 52)
        uri = this._rutaElectronica + "CAF\\E-Guia\\" + archivoCaf;
      string uriSchema1 = this._rutaElectronica + "Archivos\\Schemas\\DTE_v10_Sf.xsd";
      string uriSchema2 = this._rutaElectronica + "Archivos\\Schemas\\DTE_v10.xsd";
      List<string> list1 = FuncionesComunes.ValidarSchema(str2, uriSchema1);
      if (list1.Count > 0)
      {
        int num1;
        list1.ForEach((Action<string>) (es => num1 = (int) MessageBox.Show("Error en validacion de schema" + es, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)));
        int num2 = (int) MessageBox.Show("Antes de continuar debe solucionar los problemas del documento xml", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
      try
      {
        XDocument xdocument1 = XDocument.Load(str2);
        XDocument xdocument2 = XDocument.Load(uri, LoadOptions.PreserveWhitespace);
        X509Certificate2 certificado = FuncionesComunes.RecuperarCertificado(CN);
        if (certificado == null)
        {
          int num1 = (int) MessageBox.Show("No se encuentra el certificado para poder firmar los documentos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
        System.Xml.Linq.Extensions.Remove(Enumerable.Where<XAttribute>(xdocument1.Root.Attributes(), (Func<XAttribute, bool>) (y => y.IsNamespaceDeclaration)));
        System.Xml.Linq.Extensions.Remove(xdocument1.Root.Attributes());
        foreach (XElement xelement in xdocument1.Descendants())
          xelement.Name = (XName) xelement.Name.LocalName;
        xdocument1.Root.Add((object) new XAttribute((XName) "version", (object) "1.0"));
        string str4 = string.Empty;
        string str5 = string.Empty;
        string str6 = string.Empty;
        string str7 = string.Empty;
        string str8 = string.Empty;
        string str9 = string.Empty;
        string str10 = string.Empty;
        string str11 = string.Empty;
        string str12 = System.Xml.XPath.Extensions.XPathSelectElement((XNode) xdocument1, "DTE/Documento/Encabezado/IdDoc/TipoDTE").Value;
        string str13 = System.Xml.XPath.Extensions.XPathSelectElement((XNode) xdocument1, "DTE/Documento/Encabezado/IdDoc/Folio").Value;
        string str14 = System.Xml.XPath.Extensions.XPathSelectElement((XNode) xdocument1, "DTE/Documento/Encabezado/IdDoc/FchEmis").Value;
        string str15 = System.Xml.XPath.Extensions.XPathSelectElement((XNode) xdocument1, "DTE/Documento/Encabezado/Emisor/RUTEmisor").Value;
        string str16 = System.Xml.XPath.Extensions.XPathSelectElement((XNode) xdocument1, "DTE/Documento/Encabezado/Receptor/RUTRecep").Value;
        string str17 = System.Xml.XPath.Extensions.XPathSelectElement((XNode) xdocument1, "DTE/Documento/Encabezado/Receptor/RznSocRecep").Value;
        string str18 = System.Xml.XPath.Extensions.XPathSelectElement((XNode) xdocument1, "DTE/Documento/Encabezado/Totales/MntTotal").Value;
        string str19 = System.Xml.XPath.Extensions.XPathSelectElement((XNode) xdocument1, "DTE/Documento/Detalle/NmbItem[1]").Value;
        if (str19.Length > 40)
          str19 = str19.Substring(0, 39);
        XElement xelement1 = System.Xml.XPath.Extensions.XPathSelectElement((XNode) xdocument1, "DTE/Documento/TED/DD/CAF");
        if (xelement1 != null)
          xelement1.Remove();
        string str20 = string.Format("R{0}F{1}T{2}", (object) str15.Replace("-", string.Empty), (object) str13, (object) str12);
        System.Xml.XPath.Extensions.XPathSelectElement((XNode) xdocument1, "DTE/Documento").SetAttributeValue((XName) "ID", (object) str20);
        XElement xelement2 = System.Xml.XPath.Extensions.XPathSelectElement((XNode) xdocument1, "DTE/Documento/TED/DD/TSTED");
        if (xelement2 != null)
          xelement2.Value = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss");
        XElement xelement3 = System.Xml.XPath.Extensions.XPathSelectElement((XNode) xdocument1, "DTE/Documento/TmstFirma");
        if (xelement3 != null)
          xelement3.Value = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss");
        XElement xelement4 = System.Xml.XPath.Extensions.XPathSelectElement((XNode) xdocument1, "DTE/Documento/TED/FRMT");
        if (xelement4 != null)
        {
          xelement4.Value = string.Empty;
          xelement4.SetAttributeValue((XName) "algoritmo", (object) "SHA1withRSA");
        }
        XElement xelement5 = System.Xml.XPath.Extensions.XPathSelectElement((XNode) xdocument1, "DTE/Documento/TED/DD/RE");
        if (xelement5 != null)
          xelement5.Value = str15;
        XElement xelement6 = System.Xml.XPath.Extensions.XPathSelectElement((XNode) xdocument1, "DTE/Documento/TED/DD/TD");
        if (xelement6 != null)
          xelement6.Value = str12;
        XElement xelement7 = System.Xml.XPath.Extensions.XPathSelectElement((XNode) xdocument1, "DTE/Documento/TED/DD/F");
        if (xelement7 != null)
          xelement7.Value = str13;
        XElement xelement8 = System.Xml.XPath.Extensions.XPathSelectElement((XNode) xdocument1, "DTE/Documento/TED/DD/FE");
        if (xelement8 != null)
          xelement8.Value = str14;
        XElement xelement9 = System.Xml.XPath.Extensions.XPathSelectElement((XNode) xdocument1, "DTE/Documento/TED/DD/RR");
        if (xelement9 != null)
          xelement9.Value = str16;
        XElement xelement10 = System.Xml.XPath.Extensions.XPathSelectElement((XNode) xdocument1, "DTE/Documento/TED/DD/RSR");
        if (xelement10 != null)
          xelement10.Value = str17;
        XElement xelement11 = System.Xml.XPath.Extensions.XPathSelectElement((XNode) xdocument1, "DTE/Documento/TED/DD/MNT");
        if (xelement11 != null)
          xelement11.Value = str18;
        XElement xelement12 = System.Xml.XPath.Extensions.XPathSelectElement((XNode) xdocument1, "DTE/Documento/TED/DD/IT1");
        if (xelement12 != null)
          xelement12.Value = str19;
        string[] strArray = xdocument1.ToString().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
        for (int index = 0; index <= strArray.Length - 1; ++index)
          strArray[index] = strArray[index].TrimStart();
        XDocument xdocument3 = XDocument.Parse(string.Join("\r\n", strArray), LoadOptions.PreserveWhitespace);
        xdocument3.Declaration = new XDeclaration("1.0", "ISO-8859-1", (string) null);
        xdocument3.Save(str3);
        string base64 = System.Xml.XPath.Extensions.XPathSelectElement((XNode) xdocument2, "AUTORIZACION/RSASK").Value;
        XElement xelement13 = System.Xml.XPath.Extensions.XPathSelectElement((XNode) xdocument2, "AUTORIZACION/CAF");
        XElement xelement14 = System.Xml.XPath.Extensions.XPathSelectElement((XNode) xdocument3, "DTE/Documento/TED/DD/CAF");
        if (xelement14 == null)
          System.Xml.XPath.Extensions.XPathSelectElement((XNode) xdocument3, "DTE/Documento/TED/DD/IT1").AddAfterSelf((object) xelement13);
        else
          xelement14.ReplaceWith((object) xelement13);
        xdocument3.Declaration = new XDeclaration("1.0", "ISO-8859-1", (string) null);
        xdocument3.Save(str3);
        XmlDocument xmlDocument = new XmlDocument();
        xmlDocument.PreserveWhitespace = true;
        xmlDocument.Load(str3);
        XmlElement xmlElement = (XmlElement) xmlDocument.SelectSingleNode("DTE/Documento/TED/DD");
        if (xmlElement == null)
          throw new Exception("No se encuentra el nodo DD");
        byte[] hash = new SHA1CryptoServiceProvider().ComputeHash(Encoding.GetEncoding("ISO-8859-1").GetBytes(xmlElement.OuterXml.Replace("\t", string.Empty).Replace("\r\n", string.Empty).Replace("\n", string.Empty)));
        string str21 = Convert.ToBase64String(FuncionesComunes.crearRsaDesdePEM(base64).SignHash(hash, "SHA1"));
        xmlDocument.SelectSingleNode("DTE/Documento/TED/FRMT").InnerText = str21;
        xmlDocument.Save(str3);
        XmlDocument xmldocument = new XmlDocument();
        xmldocument.PreserveWhitespace = true;
        xmldocument.Load(str3);
        string referenciaUri = string.Format("#{0}", (object) str20);
        FuncionesComunes.firmarDocumentoXml(ref xmldocument, certificado, referenciaUri);
        xmldocument.Save(str3);
        list1.Clear();
        List<string> list2 = FuncionesComunes.ValidarSchema(str3, uriSchema2);
        if (list2.Count > 0)
        {
          int num2;
          list2.ForEach((Action<string>) (es => num2 = (int) MessageBox.Show("Error en validacion de schema " + es, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)));
          int num3 = (int) MessageBox.Show("Antes de continuar debe solucionar los problemas del documento xml.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
      }
      catch (Exception ex)
      {
        int num1 = (int) MessageBox.Show("Error al procesar el documento DTE", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        int num2 = (int) MessageBox.Show(ex.Message);
      }

      if (contribuyente)
      {
          this.agregSetDte_contibuyente(nombreCertificado, td, nombreArchivo, rutReceptor); //firma a tercero
      }
      else
      {
          this.agregSetDte(nombreCertificado, td, nombreArchivo, rutReceptor);
      }
    }

    public void agregSetDte(string nombreCertificado, int td, string nombreArchivo, string rutReceptor)
    {
        string str = new LeeXml().cargarDatosMultiEmpresa("factura")[1].ToString();
      string str1 = "";
      if (td == 33)
        str1 = this._rutaElectronica + "DTE\\E-Factura\\" + nombreArchivo + "_envio.XML";
      if (td == 34)
        str1 = this._rutaElectronica + "DTE\\E-FacturaExenta\\" + nombreArchivo + "_envio.XML";
      if (td == 61)
        str1 = this._rutaElectronica + "DTE\\E-NotaCredito\\" + nombreArchivo +"_envio.XML";
      if (td == 56)
        str1 = this._rutaElectronica + "DTE\\E-NotaDebito\\" + nombreArchivo + "_envio.XML";
      if (td == 52)
        str1 = this._rutaElectronica + "DTE\\E-Guia\\" + nombreArchivo + "_envio.XML";
      ArrayList arrayList = new ArrayList();
      String archivo = new LeeXml().cargarDatosMultiEmpresa("factura")[1].ToString();
      string filename1 = this._rutaElectronica + "Archivos\\SETDTE_"+archivo+".XML";
      string uriSchema = this._rutaElectronica + "Archivos\\Schemas\\EnvioDTE_v10.xsd";
      string filename2 = "";
      if (td == 33)
        filename2 = this._rutaElectronica + "DTE\\E-Factura\\EFacturaXML\\" + nombreArchivo  + ".XML";
      if (td == 34)
        filename2 = this._rutaElectronica + "DTE\\E-FacturaExenta\\EFacturaExentaXML\\" + nombreArchivo  + ".XML";
      if (td == 61)
        filename2 = this._rutaElectronica + "DTE\\E-NotaCredito\\ENotaCreditoXML\\" + nombreArchivo+ ".XML";
      if (td == 56)
        filename2 = this._rutaElectronica + "DTE\\E-NotaDebito\\ENotaDebitoXML\\" + nombreArchivo+ ".XML";
      if (td == 52)
        filename2 = this._rutaElectronica + "DTE\\E-Guia\\EGuiaXML\\" + nombreArchivo+ ".XML";
      string str2 = str1;
      string CN = nombreCertificado;
      List<string> list1 = new List<string>();
      XmlDocument xmlDocument = new XmlDocument();
      xmlDocument.PreserveWhitespace = true;
      xmlDocument.Load(filename2);
      string str3 = "SetDoc";
      XmlDocument xmldocument = new XmlDocument();
      xmldocument.PreserveWhitespace = true;
      xmldocument.Load(filename1);
      xmldocument.SelectSingleNode("EnvioDTE/SetDTE/Caratula/RutReceptor").InnerText = "60803000-K";//aqui va el rut de del contribuyente
        xmldocument.SelectSingleNode("EnvioDTE/SetDTE/Caratula/SubTotDTE/TpoDTE").InnerText = td.ToString();
      XmlElement xmlElement = (XmlElement) xmldocument.SelectSingleNode("EnvioDTE/SetDTE/Caratula/TmstFirmaEnv");
      if (xmlElement == null)
        throw new Exception("No se encuentra el nodo Folio");
      xmlElement.InnerText = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss");
      xmldocument.SelectSingleNode("EnvioDTE/SetDTE").AppendChild(xmldocument.ImportNode((XmlNode) xmlDocument.DocumentElement, true));
      xmldocument.Save(str2);
      xmldocument.DocumentElement.SetAttribute("xmlns", "http://www.sii.cl/SiiDte");
      xmldocument.DocumentElement.SetAttribute("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance");
      xmldocument.DocumentElement.SetAttribute("schemaLocation", "http://www.w3.org/2001/XMLSchema-instance", "http://www.sii.cl/SiiDte EnvioDTE_v10.xsd");
      xmldocument.Save(str2);
      xmldocument.PreserveWhitespace = true;
      xmldocument.Load(str2);
      X509Certificate2 certificado = FuncionesComunes.RecuperarCertificado(CN);
      if (certificado == null)
      {
        int num1 = (int) MessageBox.Show("No se encuentra el certificado para poder firmar los documentos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
      string referenciaUri = string.Format("#{0}", (object) str3);
      FuncionesComunes.firmarDocumentoXml(ref xmldocument, certificado, referenciaUri);
      xmldocument.Save(str2);
      list1.Clear();
      List<string> list2 = FuncionesComunes.ValidarSchema(str2, uriSchema);
      if (list2.Count <= 0)
        return;
      int num2;
      list2.ForEach((Action<string>) (es => num2 = (int) MessageBox.Show("Error en validacion de schema " + es, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)));
      int num3 = (int) MessageBox.Show("Antes de continuar debe solucionar los problemas del documento xml", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
    }

    public void agregSetDte_contibuyente(string nombreCertificado, int td, string nombreArchivo, string rutReceptor)
    {
        string str = new LeeXml().cargarDatosMultiEmpresa("factura")[1].ToString();
        string str1 = "";
        if (td == 33)
            str1 = this._rutaElectronica + "DTE\\E-Factura\\" + nombreArchivo + ".XML";
        if (td == 34)
            str1 = this._rutaElectronica + "DTE\\E-FacturaExenta\\" + nombreArchivo + ".XML";
        if (td == 61)
            str1 = this._rutaElectronica + "DTE\\E-NotaCredito\\" + nombreArchivo + ".XML";
        if (td == 56)
            str1 = this._rutaElectronica + "DTE\\E-NotaDebito\\" + nombreArchivo + ".XML";
        if (td == 52)
            str1 = this._rutaElectronica + "DTE\\E-Guia\\" + nombreArchivo + ".XML";
        ArrayList arrayList = new ArrayList();
        String archivo = new LeeXml().cargarDatosMultiEmpresa("factura")[1].ToString();
        string filename1 = this._rutaElectronica + "Archivos\\SETDTE_" + archivo + ".XML";
        string uriSchema = this._rutaElectronica + "Archivos\\Schemas\\EnvioDTE_v10.xsd";
        string filename2 = "";
        if (td == 33)
            filename2 = this._rutaElectronica + "DTE\\E-Factura\\EFacturaXML\\" + nombreArchivo + ".XML";
        if (td == 34)
            filename2 = this._rutaElectronica + "DTE\\E-FacturaExenta\\EFacturaExentaXML\\" + nombreArchivo + ".XML";
        if (td == 61)
            filename2 = this._rutaElectronica + "DTE\\E-NotaCredito\\ENotaCreditoXML\\" + nombreArchivo + ".XML";
        if (td == 56)
            filename2 = this._rutaElectronica + "DTE\\E-NotaDebito\\ENotaDebitoXML\\" + nombreArchivo + ".XML";
        if (td == 52)
            filename2 = this._rutaElectronica + "DTE\\E-Guia\\EGuiaXML\\" + nombreArchivo + ".XML";
        string str2 = str1;
        string CN = nombreCertificado;
        List<string> list1 = new List<string>();
        XmlDocument xmlDocument = new XmlDocument();
        xmlDocument.PreserveWhitespace = true;
        xmlDocument.Load(filename2);
        string str3 = "SetDoc";
        XmlDocument xmldocument = new XmlDocument();
        xmldocument.PreserveWhitespace = true;
        xmldocument.Load(filename1);
        xmldocument.SelectSingleNode("EnvioDTE/SetDTE/Caratula/RutReceptor").InnerText = rutReceptor;//aqui va el rut de del contribuyente
        xmldocument.SelectSingleNode("EnvioDTE/SetDTE/Caratula/SubTotDTE/TpoDTE").InnerText = td.ToString();
        XmlElement xmlElement = (XmlElement)xmldocument.SelectSingleNode("EnvioDTE/SetDTE/Caratula/TmstFirmaEnv");
        if (xmlElement == null)
            throw new Exception("No se encuentra el nodo Folio");
        xmlElement.InnerText = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss");
        xmldocument.SelectSingleNode("EnvioDTE/SetDTE").AppendChild(xmldocument.ImportNode((XmlNode)xmlDocument.DocumentElement, true));
        xmldocument.Save(str2);
        xmldocument.DocumentElement.SetAttribute("xmlns", "http://www.sii.cl/SiiDte");
        xmldocument.DocumentElement.SetAttribute("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance");
        xmldocument.DocumentElement.SetAttribute("schemaLocation", "http://www.w3.org/2001/XMLSchema-instance", "http://www.sii.cl/SiiDte EnvioDTE_v10.xsd");
        xmldocument.Save(str2);
        xmldocument.PreserveWhitespace = true;
        xmldocument.Load(str2);
        X509Certificate2 certificado = FuncionesComunes.RecuperarCertificado(CN);
        if (certificado == null)
        {
            int num1 = (int)MessageBox.Show("No se encuentra el certificado para poder firmar los documentos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
        string referenciaUri = string.Format("#{0}", (object)str3);
        FuncionesComunes.firmarDocumentoXml(ref xmldocument, certificado, referenciaUri);
        xmldocument.Save(str2);
        list1.Clear();
        List<string> list2 = FuncionesComunes.ValidarSchema(str2, uriSchema);
        if (list2.Count <= 0)
            return;
        int num2;
        list2.ForEach((Action<string>)(es => num2 = (int)MessageBox.Show("Error en validacion de schema " + es, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)));
        int num3 = (int)MessageBox.Show("Antes de continuar debe solucionar los problemas del documento xml", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
    }

    public string agregaListadoDteASetDte(List<Venta> lista)
    {
      if (this._rutaElectronica.Length == 0)
        this.CargaRuta();
      string certificadoDigital = new Emisor().buscaEmisor().CertificadoDigital;
      int num1 = 0;
      int num2 = 0;
      int num3 = 0;
      int num4 = 0;
      int num5 = 0;
      foreach (Venta venta in lista)
      {
        if (venta.Fe_TipoDTE == 33)
          ++num1;
        if (venta.Fe_TipoDTE == 34)
          ++num2;
        if (venta.Fe_TipoDTE == 61)
          ++num3;
        if (venta.Fe_TipoDTE == 56)
          ++num4;
        if (venta.Fe_TipoDTE == 52)
          ++num5;
      }
      string filename1 = this._rutaElectronica + "Archivos\\SETDTE_ENVIO_"+multi+".XML";
      string uriSchema = this._rutaElectronica + "Archivos\\Schemas\\EnvioDTE_v10.xsd";
      DateTime now = DateTime.Now;
      string str1 = "Envio_" + now.ToString().Replace("/", "-").Replace(":", "_") + ".XML";
      string str2 = this._rutaElectronica + "DTE\\Envios\\" + str1;
      string CN = certificadoDigital;
      List<string> list1 = new List<string>();
      string str3 = "SetDoc";
      XmlDocument xmldocument = new XmlDocument();
      xmldocument.PreserveWhitespace = true;
      xmldocument.Load(filename1);
      xmldocument.SelectSingleNode("EnvioDTE/SetDTE/Caratula/RutReceptor").InnerText = "60803000-K";
      if (num1 > 0)
      {
        XmlElement element1 = xmldocument.CreateElement("SubTotDTE");
        XmlElement element2 = xmldocument.CreateElement("TpoDTE");
        XmlElement element3 = xmldocument.CreateElement("NroDTE");
        element2.InnerText = "33";
        element3.InnerText = num1.ToString();
        element1.AppendChild((XmlNode) element2);
        element1.AppendChild((XmlNode) element3);
        xmldocument.SelectSingleNode("EnvioDTE/SetDTE/Caratula").AppendChild((XmlNode) element1);
      }
      if (num2 > 0)
      {
        XmlElement element1 = xmldocument.CreateElement("SubTotDTE");
        XmlElement element2 = xmldocument.CreateElement("TpoDTE");
        XmlElement element3 = xmldocument.CreateElement("NroDTE");
        element2.InnerText = "34";
        element3.InnerText = num2.ToString();
        element1.AppendChild((XmlNode) element2);
        element1.AppendChild((XmlNode) element3);
        xmldocument.SelectSingleNode("EnvioDTE/SetDTE/Caratula").AppendChild((XmlNode) element1);
      }
      if (num3 > 0)
      {
        XmlElement element1 = xmldocument.CreateElement("SubTotDTE");
        XmlElement element2 = xmldocument.CreateElement("TpoDTE");
        XmlElement element3 = xmldocument.CreateElement("NroDTE");
        element2.InnerText = "61";
        element3.InnerText = num3.ToString();
        element1.AppendChild((XmlNode) element2);
        element1.AppendChild((XmlNode) element3);
        xmldocument.SelectSingleNode("EnvioDTE/SetDTE/Caratula").AppendChild((XmlNode) element1);
      }
      if (num4 > 0)
      {
        XmlElement element1 = xmldocument.CreateElement("SubTotDTE");
        XmlElement element2 = xmldocument.CreateElement("TpoDTE");
        XmlElement element3 = xmldocument.CreateElement("NroDTE");
        element2.InnerText = "56";
        element3.InnerText = num4.ToString();
        element1.AppendChild((XmlNode) element2);
        element1.AppendChild((XmlNode) element3);
        xmldocument.SelectSingleNode("EnvioDTE/SetDTE/Caratula").AppendChild((XmlNode) element1);
      }
      if (num5 > 0)
      {
        XmlElement element1 = xmldocument.CreateElement("SubTotDTE");
        XmlElement element2 = xmldocument.CreateElement("TpoDTE");
        XmlElement element3 = xmldocument.CreateElement("NroDTE");
        element2.InnerText = "52";
        element3.InnerText = num5.ToString();
        element1.AppendChild((XmlNode) element2);
        element1.AppendChild((XmlNode) element3);
        xmldocument.SelectSingleNode("EnvioDTE/SetDTE/Caratula").AppendChild((XmlNode) element1);
      }
      XmlElement xmlElement1 = (XmlElement) xmldocument.SelectSingleNode("EnvioDTE/SetDTE/Caratula/TmstFirmaEnv");
      if (xmlElement1 == null)
        throw new Exception("No se encuentra el nodo Folio");
      XmlElement xmlElement2 = xmlElement1;
      now = DateTime.Now;
      string str4 = now.ToString("yyyy-MM-ddTHH:mm:ss");
      xmlElement2.InnerText = str4;
      XmlDocument xmlDocument1 = new XmlDocument();
      foreach (Venta venta in lista)
      {
        string filename2 = "";
        string str5 = venta.Folio.ToString("##");
        int feTipoDte = venta.Fe_TipoDTE;
        if (feTipoDte == 33)
          filename2 = this._rutaElectronica + "DTE\\E-Factura\\EFacturaXML\\EFactura_" + str5 +"_"+multi+ ".XML";
        if (feTipoDte == 34)
            filename2 = this._rutaElectronica + "DTE\\E-FacturaExenta\\EFacturaExentaXML\\EFacturaExenta_" + str5 + "_" + multi + ".XML";
        if (feTipoDte == 61)
            filename2 = this._rutaElectronica + "DTE\\E-NotaCredito\\ENotaCreditoXML\\ENotaCredito_" + str5 + "_" + multi + ".XML";
        if (feTipoDte == 56)
            filename2 = this._rutaElectronica + "DTE\\E-NotaDebito\\ENotaDebitoXML\\ENotaDebito_" + str5 + "_" + multi + ".XML";
        if (feTipoDte == 52)
            filename2 = this._rutaElectronica + "DTE\\E-Guia\\EGuiaXML\\EGuia_" + str5 + "_" + multi + ".XML";
        XmlDocument xmlDocument2 = new XmlDocument();
        xmlDocument2.PreserveWhitespace = true;
        xmlDocument2.Load(filename2);
        xmldocument.SelectSingleNode("EnvioDTE/SetDTE").AppendChild(xmldocument.ImportNode((XmlNode) xmlDocument2.DocumentElement, true));
        xmldocument.Save(str2);
      }
      xmldocument.DocumentElement.SetAttribute("xmlns", "http://www.sii.cl/SiiDte");
      xmldocument.DocumentElement.SetAttribute("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance");
      xmldocument.DocumentElement.SetAttribute("schemaLocation", "http://www.w3.org/2001/XMLSchema-instance", "http://www.sii.cl/SiiDte EnvioDTE_v10.xsd");
      xmldocument.Save(str2);
      xmldocument.PreserveWhitespace = true;
      xmldocument.Load(str2);
      X509Certificate2 certificado = FuncionesComunes.RecuperarCertificado(CN);
      if (certificado == null)
        throw new Exception("No se encuentra el certificado para poder firmar ls documentos");
      string referenciaUri = string.Format("#{0}", (object) str3);
      FuncionesComunes.firmarDocumentoXml(ref xmldocument, certificado, referenciaUri);
      xmldocument.Save(str2);
      list1.Clear();
      List<string> list2 = FuncionesComunes.ValidarSchema(str2, uriSchema);
      if (list2.Count > 0)
      {
        int num6 = (int) MessageBox.Show("Error en validacion de schema del SII sobre documento xml (DTE)");
        int num7;
        list2.ForEach((Action<string>) (es => num7 = (int) MessageBox.Show(es)));
        throw new Exception("Antes de continuar debe solucionar los problemas del documento xml.");
      }
      return str1;
    }

    public void agregaListadoDteASetDte_RESPALDOooo(List<Venta> lista)
    {
      string certificadoDigital = new Emisor().buscaEmisor().CertificadoDigital;
      int num1 = 0;
      int num2 = 0;
      int num3 = 0;
      foreach (Venta venta in lista)
      {
        if (venta.Fe_TipoDTE == 33)
          ++num1;
        if (venta.Fe_TipoDTE == 61)
          ++num2;
        if (venta.Fe_TipoDTE == 56)
          ++num3;
      }
      ArrayList arrayList = new ArrayList();
      String archivo = new LeeXml().cargarDatosMultiEmpresa("factura")[1].ToString();
      string filename1 = this._rutaElectronica + "Archivos\\SETDTE_ENVIO_"+archivo+".XML";
      string uriSchema = this._rutaElectronica + "Archivos\\Schemas\\EnvioDTE_v10.xsd";
      DateTime now = DateTime.Now;
      string str1 = this._rutaElectronica + "DTE\\Envios\\Envio_" + now.ToString().Replace("/", "-").Replace(":", "_") +"_"+archivo+ ".XML";
      string CN = certificadoDigital;
      List<string> list1 = new List<string>();
      string str2 = "SetDoc";
      XmlDocument xmldocument = new XmlDocument();
      xmldocument.PreserveWhitespace = true;
      xmldocument.Load(filename1);
      xmldocument.SelectSingleNode("EnvioDTE/SetDTE/Caratula/RutReceptor").InnerText = "60803000-K";
      if (num1 > 0)
      {
        XmlElement element1 = xmldocument.CreateElement("SubTotDTE");
        XmlElement element2 = xmldocument.CreateElement("TpoDTE");
        XmlElement element3 = xmldocument.CreateElement("NroDTE");
        element2.InnerText = "33";
        element3.InnerText = num1.ToString();
        element1.AppendChild((XmlNode) element2);
        element1.AppendChild((XmlNode) element3);
        xmldocument.SelectSingleNode("EnvioDTE/SetDTE/Caratula").AppendChild((XmlNode) element1);
      }
      if (num2 > 0)
      {
        XmlElement element1 = xmldocument.CreateElement("SubTotDTE");
        XmlElement element2 = xmldocument.CreateElement("TpoDTE");
        XmlElement element3 = xmldocument.CreateElement("NroDTE");
        element2.InnerText = "61";
        element3.InnerText = num2.ToString();
        element1.AppendChild((XmlNode) element2);
        element1.AppendChild((XmlNode) element3);
        xmldocument.SelectSingleNode("EnvioDTE/SetDTE/Caratula").AppendChild((XmlNode) element1);
      }
      if (num3 > 0)
      {
        XmlElement element1 = xmldocument.CreateElement("SubTotDTE");
        XmlElement element2 = xmldocument.CreateElement("TpoDTE");
        XmlElement element3 = xmldocument.CreateElement("NroDTE");
        element2.InnerText = "56";
        element3.InnerText = num3.ToString();
        element1.AppendChild((XmlNode) element2);
        element1.AppendChild((XmlNode) element3);
        xmldocument.SelectSingleNode("EnvioDTE/SetDTE/Caratula").AppendChild((XmlNode) element1);
      }
      XmlElement xmlElement1 = (XmlElement) xmldocument.SelectSingleNode("EnvioDTE/SetDTE/Caratula/TmstFirmaEnv");
      if (xmlElement1 == null)
        throw new Exception("No se encuentra el nodo Folio");
      XmlElement xmlElement2 = xmlElement1;
      now = DateTime.Now;
      string str3 = now.ToString("yyyy-MM-ddTHH:mm:ss");
      xmlElement2.InnerText = str3;
      XmlDocument xmlDocument1 = new XmlDocument();
      foreach (Venta venta in lista)
      {
        string filename2 = "";
        string str4 = venta.Folio.ToString("##");
        int feTipoDte = venta.Fe_TipoDTE;
        if (feTipoDte == 33)
            filename2 = this._rutaElectronica + "DTE\\E-Factura\\EFactura_" + str4 + "_" + multi + ".XML";
        if (feTipoDte == 61)
            filename2 = this._rutaElectronica + "DTE\\E-NotaCredito\\ENotaCredito_" + str4 + "_" + multi + ".XML";
        if (feTipoDte == 56)
            filename2 = this._rutaElectronica + "DTE\\E-NotaDebito\\ENotaDebito_" + str4 + "_" + multi + ".XML";
        XmlDocument xmlDocument2 = new XmlDocument();
        xmlDocument2.PreserveWhitespace = true;
        xmlDocument2.Load(filename2);
        xmldocument.SelectSingleNode("EnvioDTE/SetDTE").AppendChild(xmldocument.ImportNode((XmlNode) xmlDocument2.DocumentElement, true));
        xmldocument.Save(str1);
      }
      xmldocument.DocumentElement.SetAttribute("xmlns", "http://www.sii.cl/SiiDte");
      xmldocument.DocumentElement.SetAttribute("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance");
      xmldocument.DocumentElement.SetAttribute("schemaLocation", "http://www.w3.org/2001/XMLSchema-instance", "http://www.sii.cl/SiiDte EnvioDTE_v10.xsd");
      xmldocument.Save(str1);
      xmldocument.PreserveWhitespace = true;
      xmldocument.Load(str1);
      X509Certificate2 certificado = FuncionesComunes.RecuperarCertificado(CN);
      if (certificado == null)
        throw new Exception("No se encuentra el certificado para poder firmar ls documentos");
      string referenciaUri = string.Format("#{0}", (object) str2);
      FuncionesComunes.firmarDocumentoXml(ref xmldocument, certificado, referenciaUri);
      xmldocument.Save(str1);
      list1.Clear();
      List<string> list2 = FuncionesComunes.ValidarSchema(str1, uriSchema);
      if (list2.Count > 0)
      {
        int num4 = (int) MessageBox.Show("Error en validacion de schema del SII sobre documento xml (DTE)");
        int num5;
        list2.ForEach((Action<string>) (es => num5 = (int) MessageBox.Show(es)));
        throw new Exception("Antes de continuar debe solucionar los problemas del documento xml.");
      }
    }
  }
}
