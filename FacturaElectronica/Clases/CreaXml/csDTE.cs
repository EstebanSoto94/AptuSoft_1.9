 
// Type: Aptusoft.FacturaElectronica.Clases.CreaXml.csDTE
 
 
// version 1.8.0

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows;
using System.Xml;
using System.Xml.Serialization;

namespace Aptusoft.FacturaElectronica.Clases.CreaXml
{
  [XmlRoot(ElementName = "DTE")]
  public class csDTE
  {
    private string _rutaElectronica = "";
    private csDocumento _Documento = new csDocumento();

    public csDocumento Documento
    {
      get
      {
        return this._Documento;
      }
      set
      {
        this._Documento = value;
      }
    }

    [XmlAttribute("version")]
    public string version { get; set; }

    [XmlIgnore]
    public bool calcularMontos { get; set; }

    [XmlIgnore]
    public bool agregarNodoTED { get; set; }

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
        int num = (int) MessageBox.Show("Error al Cargar Ruta " + ex.Message);
      }
    }

    public string Serializar(string nombreArchivo, int tipoDocumento)
    {
      if (this._rutaElectronica.Length == 0)
        this.CargaRuta();
      this.NormalizarDocumento();
      if (this.calcularMontos)
        this.CalcularValoresTotalera();
      this.CalcularNodoTed();
      XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
      namespaces.Add(string.Empty, string.Empty);
      XmlWriterSettings settings = new XmlWriterSettings();
      settings.Encoding = Encoding.GetEncoding("ISO-8859-1");
      settings.Indent = true;
      XmlSerializer xmlSerializer = new XmlSerializer(this.GetType());
      string str = "";
      if (tipoDocumento == 33)
        str = this._rutaElectronica + "DTE\\E-Factura\\EFacturaXML\\";
      if (tipoDocumento == 34)
        str = this._rutaElectronica + "DTE\\E-FacturaExenta\\EFacturaExentaXML\\";
      if (tipoDocumento == 61)
        str = this._rutaElectronica + "DTE\\E-NotaCredito\\ENotaCreditoXML\\";
      if (tipoDocumento == 56)
        str = this._rutaElectronica + "DTE\\E-NotaDebito\\ENotaDebitoXML\\";
      if (tipoDocumento == 52)
        str = this._rutaElectronica + "DTE\\E-Guia\\EGuiaXML\\";
      if (tipoDocumento == 39)
        str = this._rutaElectronica + "DTE\\E-Boleta\\EBoletaXML\\";
      XmlWriter xmlWriter = XmlWriter.Create(str + nombreArchivo + ".XML", settings);
      xmlSerializer.Serialize(xmlWriter, (object) this, namespaces);
      xmlWriter.Close();
      return (string) null;
    }

    private void NormalizarDocumento()
    {
        try
        {
            if (string.IsNullOrEmpty(this.version))
                this.version = "1.0";
            DateTime now;
            if (string.IsNullOrEmpty(this.Documento.Encabezado.IdDoc.FchEmis))
            {
                csIdDoc idDoc = this.Documento.Encabezado.IdDoc;
                now = DateTime.Now;
                string str = now.ToString("yyyy-MM-dd");
                idDoc.FchEmis = str;
            }
            if (string.IsNullOrEmpty(this.Documento.TmstFirma))
            {
                csDocumento documento = this.Documento;
                now = DateTime.Now;
                string str = now.ToString("yyyy-MM-ddTHH:mm:ss");
                documento.TmstFirma = str;
            }
            if (string.IsNullOrEmpty(this.Documento.TED.DD.CAF))
                this.Documento.TED.DD.CAF = "Aqui debe agregarse el nodo CAF que se extrae del archivo CAF.";
            if (string.IsNullOrEmpty(this.Documento.TED.FRMT))
                this.Documento.TED.FRMT = "Agregar aqui el timbre del nodo Ted";
            if (string.IsNullOrEmpty(this.Documento.TED.DD.TSTED))
            {
                csDD dd = this.Documento.TED.DD;
                now = DateTime.Now;
                string str = now.ToString("yyyy-MM-ddTHH:mm:ss");
                dd.TSTED = str;
            }
            string format = "HEFESTO_DTE_T{0}_F{1}_R{2}";
            if (string.IsNullOrEmpty(this.Documento.ID))
                this.Documento.ID = string.Format(format, (object)this.Documento.Encabezado.IdDoc.TipoDTE, (object)this.Documento.Encabezado.IdDoc.Folio, (object)this.Documento.Encabezado.Emisor.RUTEmisor.Replace("-", "_"));
            if (!string.IsNullOrEmpty(this.Documento.TED.version))
                return;
            this.Documento.TED.version = "1.0";
        }
        catch (Exception ex)
        {
            MessageBox.Show("ha ocurrido un error:\n\r"+ex.Message);
        }
    }

    private void CalcularValoresTotalera()
    {
      try
      {
        Decimal num1 = Enumerable.Sum<csDetalle>(Enumerable.Where<csDetalle>((IEnumerable<csDetalle>) this.Documento.Detalles, (Func<csDetalle, bool>) (a => a.IndExe < 1)), (Func<csDetalle, Decimal>) (a => a.MontoItem));
        Decimal num2 = Enumerable.Sum<csDetalle>(Enumerable.Where<csDetalle>((IEnumerable<csDetalle>) this.Documento.Detalles, (Func<csDetalle, bool>) (a => a.IndExe == 1)), (Func<csDetalle, Decimal>) (a => a.MontoItem));
        Decimal num3 = Convert.ToDecimal("0.19");
        Decimal num4 = Math.Round(num1 * num3, MidpointRounding.AwayFromZero);
        Decimal num5 = num1 + num2 + num4;
        this.Documento.Encabezado.Totales.MntNeto = num1;
        this.Documento.Encabezado.Totales.MntExe = num2;
        this.Documento.Encabezado.Totales.IVA = Convert.ToDecimal(num4);
        this.Documento.Encabezado.Totales.MntTotal = Convert.ToDecimal(num5);
      }
      catch (Exception ex)
      {
      }
    }

    private void CalcularNodoTed()
    {
      this.Documento.TED.DD.RE = this.Documento.Encabezado.Emisor.RUTEmisor;
      this.Documento.TED.DD.TD = this.Documento.Encabezado.IdDoc.TipoDTE.ToString();
      this.Documento.TED.DD.F = this.Documento.Encabezado.IdDoc.Folio.ToString();
      this.Documento.TED.DD.FE = this.Documento.Encabezado.IdDoc.FchEmis;
      this.Documento.TED.DD.RR = this.Documento.Encabezado.Receptor.RUTRecep;
      if (this.Documento.Encabezado.Receptor.RznSocRecep.Length > 40)
        this.Documento.Encabezado.Receptor.RznSocRecep = this.Documento.Encabezado.Receptor.RznSocRecep.Substring(0, 39);
      this.Documento.TED.DD.RSR = this.Documento.Encabezado.Receptor.RznSocRecep;
      this.Documento.TED.DD.MNT = this.Documento.Encabezado.Totales.MntTotal.ToString();
      if (this.Documento.Detalles[0].NmbItem.Length > 40)
        this.Documento.TED.DD.IT1 = this.Documento.Detalles[0].NmbItem.Substring(0, 39);
      else
        this.Documento.TED.DD.IT1 = this.Documento.Detalles[0].NmbItem;
    }
  }
}
