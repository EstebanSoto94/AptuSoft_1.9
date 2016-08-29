 
// Type: Aptusoft.CalculosConexion
 
 
// version 1.8.0

using MySql.Data.MySqlClient;
using System;
using System.Data.Common;

namespace Aptusoft
{
  public class CalculosConexion
  {
    private Conexion conexion = Conexion.getConecta();

    public Decimal Iva { get; set; }

    public bool ValoresConIva { get; set; }

    public bool VerificaCredito { get; set; }

    public bool ImpedirVentasSinCredito { get; set; }

    public bool VerificaFactura { get; set; }

    public bool VerificaFacturaExenta { get; set; }

    public bool VerificaBoleta { get; set; }

    public bool VerificaGuiaSinFacturar { get; set; }

    public Decimal Impuesto1 { get; set; }

    public Decimal Impuesto2 { get; set; }

    public Decimal Impuesto3 { get; set; }

    public Decimal Impuesto4 { get; set; }

    public Decimal Impuesto5 { get; set; }

    public CalculosConexion()
    {
      this.rescataOpcionesGenerales();
      this.rescataImpuestosEspeciales();
    }

    public void rescataOpcionesGenerales()
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT \r\n                                            porcentajeIva,\r\n                                            valoresVentaConIva,\r\n                                            verificaCredito,\r\n                                            impedirVentasSinCredito,\r\n                                            verificaFactura,\r\n                                            verificaFacturaExenta,\r\n                                            verificaBoleta,\r\n                                            verificaGuiaSinFacturar,\r\n                                            codigoPesable\r\n                            FROM opcionesgenerales";
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
      {
        this.Iva = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["porcentajeIva"]);
        this.ValoresConIva = ((DbDataReader) mySqlDataReader)["valoresVentaConIva"].Equals((object) "1");
        this.VerificaCredito = Convert.ToBoolean(((DbDataReader) mySqlDataReader)["verificaCredito"].ToString());
        frmMenuPrincipal._codigoPesable = ((DbDataReader) mySqlDataReader)["codigoPesable"].ToString();
        if (this.VerificaCredito)
        {
          this.ImpedirVentasSinCredito = Convert.ToBoolean(((DbDataReader) mySqlDataReader)["impedirVentasSinCredito"].ToString());
          this.VerificaFactura = Convert.ToBoolean(((DbDataReader) mySqlDataReader)["verificaFactura"].ToString());
          this.VerificaFacturaExenta = Convert.ToBoolean(((DbDataReader) mySqlDataReader)["verificaFacturaExenta"].ToString());
          this.VerificaBoleta = Convert.ToBoolean(((DbDataReader) mySqlDataReader)["verificaBoleta"].ToString());
          this.VerificaGuiaSinFacturar = Convert.ToBoolean(((DbDataReader) mySqlDataReader)["verificaGuiaSinFacturar"].ToString());
        }
      }
      ((DbDataReader) mySqlDataReader).Close();
    }

    public void rescataImpuestosEspeciales()
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT idImpuesto, porcentajeImpuesto FROM impuestos";
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
      {
        if (((DbDataReader) mySqlDataReader)["idImpuesto"].ToString().Equals("1"))
          this.Impuesto1 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["porcentajeImpuesto"]);
        if (((DbDataReader) mySqlDataReader)["idImpuesto"].ToString().Equals("2"))
          this.Impuesto2 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["porcentajeImpuesto"]);
        if (((DbDataReader) mySqlDataReader)["idImpuesto"].ToString().Equals("3"))
          this.Impuesto3 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["porcentajeImpuesto"]);
        if (((DbDataReader) mySqlDataReader)["idImpuesto"].ToString().Equals("4"))
          this.Impuesto4 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["porcentajeImpuesto"]);
        if (((DbDataReader) mySqlDataReader)["idImpuesto"].ToString().Equals("5"))
          this.Impuesto5 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["porcentajeImpuesto"]);
      }
      ((DbDataReader) mySqlDataReader).Close();
    }
  }
}
