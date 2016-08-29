 
// Type: Aptusoft.ClienteVO
 
 
// version 1.8.0

using System;

namespace Aptusoft
{
  public class ClienteVO
  {
    private int _codigo;
    private string _comuna;
    private string _ciudad;
    private string _razonSocial;
    private string _rut;
    private string _digito;
    private string _nomFantasia;
    private string _giro;
    private string _direccion;
    private string _telefono;
    private string _fax;
    private string _contacto;
    private string _email;
    private string _emailContacto;
    private string _fonoContacto;
    private string _observaciones;
    private DateTime _fechaCreacion;
    private string _fechaUltimaCompra;
    private string _diasPlazo;

    public Decimal CreditoAprobado { get; set; }

    public int Estado { get; set; }

    public int IdMedioPago { get; set; }

    public string MedioPago { get; set; }

    public string MotivoBloqueo { get; set; }

    public int ListaPrecio { get; set; }

    public DateTime InicioSoporte { get; set; }

    public int MesesSoporte { get; set; }

    public string Telefono2 { get; set; }

    public string Telefono3 { get; set; }

    public string Email2 { get; set; }

    public string Email3 { get; set; }

    public string Vendedor { get; set; }

    public string Procedencia { get; set; }

    public string TipoCliente { get; set; }

    public bool Activo { get; set; }

    public int Intentos { get; set; }

    public int Linea { get; set; }

    public string NombreRubro { get; set; }

    public int Codigo
    {
      get
      {
        return this._codigo;
      }
      set
      {
        this._codigo = value;
      }
    }

    public string Comuna
    {
      get
      {
        return this._comuna;
      }
      set
      {
        this._comuna = value;
      }
    }

    public string Ciudad
    {
      get
      {
        return this._ciudad;
      }
      set
      {
        this._ciudad = value;
      }
    }

    public string RazonSocial
    {
      get
      {
        return this._razonSocial;
      }
      set
      {
        this._razonSocial = value;
      }
    }

    public string Rut
    {
      get
      {
        return this._rut;
      }
      set
      {
        this._rut = value;
      }
    }

    public string Digito
    {
      get
      {
        return this._digito;
      }
      set
      {
        this._digito = value;
      }
    }

    public string NomFantasia
    {
      get
      {
        return this._nomFantasia;
      }
      set
      {
        this._nomFantasia = value;
      }
    }

    public string Giro
    {
      get
      {
        return this._giro;
      }
      set
      {
        this._giro = value;
      }
    }

    public string Direccion
    {
      get
      {
        return this._direccion;
      }
      set
      {
        this._direccion = value;
      }
    }

    public string Telefono
    {
      get
      {
        return this._telefono;
      }
      set
      {
        this._telefono = value;
      }
    }

    public string Fax
    {
      get
      {
        return this._fax;
      }
      set
      {
        this._fax = value;
      }
    }

    public string Contacto
    {
      get
      {
        return this._contacto;
      }
      set
      {
        this._contacto = value;
      }
    }

    public string Email
    {
      get
      {
        return this._email;
      }
      set
      {
        this._email = value;
      }
    }

    public string EmailContacto
    {
      get
      {
        return this._emailContacto;
      }
      set
      {
        this._emailContacto = value;
      }
    }

    public string FonoContacto
    {
      get
      {
        return this._fonoContacto;
      }
      set
      {
        this._fonoContacto = value;
      }
    }

    public string Observaciones
    {
      get
      {
        return this._observaciones;
      }
      set
      {
        this._observaciones = value;
      }
    }

    public DateTime FechaCreacion
    {
      get
      {
        return this._fechaCreacion;
      }
      set
      {
        this._fechaCreacion = value;
      }
    }

    public string FechaUltimaCompra
    {
      get
      {
        return this._fechaUltimaCompra;
      }
      set
      {
        this._fechaUltimaCompra = value;
      }
    }

    public string DiasPlazo
    {
      get
      {
        return this._diasPlazo;
      }
      set
      {
        this._diasPlazo = value;
      }
    }
  }
}
