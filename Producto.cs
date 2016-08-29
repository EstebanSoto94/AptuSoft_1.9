 
// Type: Aptusoft.Producto
 
 
// version 1.8.0

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.IO;

namespace Aptusoft
{
  internal class Producto
  {
    private Conexion conexion = Conexion.getConecta();

    public void guardaProducto(ProductoVO _productoVO)
    {
      this.agregaProducto(_productoVO);
      if (_productoVO.RutaImg1.Length <= 0 && _productoVO.RutaImg2.Length <= 0 && _productoVO.RutaImg3.Length <= 0)
        return;
      this.agregaImagenProducto(_productoVO);
    }

    public void agregaProducto(ProductoVO _productoVO)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "INSERT INTO productos (\r\n                                    Codigo, CodigoAlternativo, Descripcion, ResumenDescripcion, Marca, Activo, Pesable, Exento,Kit,\r\n                                    ValorVenta1, ValorVenta2,ValorVenta3, ValorVenta4, ValorVenta5,ValorCompra, \r\n                                    PorcRentabilidad1, PorcRentabilidad2, PorcRentabilidad3, PorcRentabilidad4,PorcRentabilidad5,StockMinimo, \r\n                                    Bodega1, Bodega2, Bodega3, Bodega4,Bodega5, Bodega6, Bodega7,Bodega8,\r\n                                    Bodega9, Bodega10, CodCategoria, Categoria, CodUnidadMedida, UnidadMedida, FechaCreacion, IdImpuesto, NombreImpuesto, idSubCategoria, SubCategoria,\r\n                                    Bodega11, Bodega12, Bodega13, Bodega14,Bodega15, Bodega16, Bodega17,Bodega18,Bodega19, Bodega20) \r\n                                VALUES(\r\n                                    @Codigo, @CodigoAlternativo, @Descripcion, @ResumenDescripcion, @Marca, @Activo, @Pesable, @Exento, @Kit,\r\n                                    @ValorVenta1, @ValorVenta2, @ValorVenta3, @ValorVenta4, @ValorVenta5, @ValorCompra,\r\n                                    @PorcRentabilidad1, @PorcRentabilidad2, @PorcRentabilidad3, @PorcRentabilidad4, @PorcRentabilidad5, @StockMinimo,\r\n                                    @Bodega1,@Bodega2, @Bodega3, @Bodega4, @Bodega5, @Bodega6, @Bodega7,@Bodega8,\r\n                                    @Bodega9, @Bodega10, @CodCategoria, @Categoria, @CodUnidadMedida, @UnidadMedida, @FechaCreacion, @IdImpuesto, @NombreImpuesto, @idSubCategoria, @SubCategoria,\r\n                                    @Bodega11, @Bodega12, @Bodega13, @Bodega14, @Bodega15, @Bodega16, @Bodega17, @Bodega18, @Bodega19, @Bodega20)";
      command.Parameters.AddWithValue("@Codigo", (object) _productoVO.Codigo);
      command.Parameters.AddWithValue("@CodigoAlternativo", (object) _productoVO.CodigoAlternativo);
      command.Parameters.AddWithValue("@Descripcion", (object) _productoVO.Descripcion);
      command.Parameters.AddWithValue("@ResumenDescripcion", (object) _productoVO.ResumenDescripcion);
      command.Parameters.AddWithValue("@Marca", (object) _productoVO.Marca);
      command.Parameters.AddWithValue("@Activo", (_productoVO.Activo ? 1 : 0));
      command.Parameters.AddWithValue("@Pesable", (_productoVO.Pesable ? 1 : 0));
      command.Parameters.AddWithValue("@Exento", (_productoVO.Exento ? 1 : 0));
      command.Parameters.AddWithValue("@Kit", (_productoVO.Kit ? 1 : 0));
      command.Parameters.AddWithValue("@ValorVenta1", (object) _productoVO.ValorVenta1);
      command.Parameters.AddWithValue("@ValorVenta2", (object) _productoVO.ValorVenta2);
      command.Parameters.AddWithValue("@ValorVenta3", (object) _productoVO.ValorVenta3);
      command.Parameters.AddWithValue("@ValorVenta4", (object) _productoVO.ValorVenta4);
      command.Parameters.AddWithValue("@ValorVenta5", (object) _productoVO.ValorVenta5);
      command.Parameters.AddWithValue("@ValorCompra", (object) _productoVO.ValorCompra);
      command.Parameters.AddWithValue("@PorcRentabilidad1", (object) _productoVO.PorcRentabilidad1);
      command.Parameters.AddWithValue("@PorcRentabilidad2", (object) _productoVO.PorcRentabilidad2);
      command.Parameters.AddWithValue("@PorcRentabilidad3", (object) _productoVO.PorcRentabilidad3);
      command.Parameters.AddWithValue("@PorcRentabilidad4", (object) _productoVO.PorcRentabilidad4);
      command.Parameters.AddWithValue("@PorcRentabilidad5", (object) _productoVO.PorcRentabilidad5);
      command.Parameters.AddWithValue("@StockMinimo", (object) _productoVO.StockMinimo);
      command.Parameters.AddWithValue("@Bodega1", (object) _productoVO.Bodega1);
      command.Parameters.AddWithValue("@Bodega2", (object) _productoVO.Bodega2);
      command.Parameters.AddWithValue("@Bodega3", (object) _productoVO.Bodega3);
      command.Parameters.AddWithValue("@Bodega4", (object) _productoVO.Bodega4);
      command.Parameters.AddWithValue("@Bodega5", (object) _productoVO.Bodega5);
      command.Parameters.AddWithValue("@Bodega6", (object) _productoVO.Bodega6);
      command.Parameters.AddWithValue("@Bodega7", (object) _productoVO.Bodega7);
      command.Parameters.AddWithValue("@Bodega8", (object) _productoVO.Bodega8);
      command.Parameters.AddWithValue("@Bodega9", (object) _productoVO.Bodega9);
      command.Parameters.AddWithValue("@Bodega10", (object) _productoVO.Bodega10);
      command.Parameters.AddWithValue("@CodCategoria", (object) _productoVO.CodCategoria);
      command.Parameters.AddWithValue("@Categoria", (object) _productoVO.Categoria);
      command.Parameters.AddWithValue("@CodUnidadMedida", (object) _productoVO.CodUnidadMedida);
      command.Parameters.AddWithValue("@UnidadMedida", (object) _productoVO.UnidadMedida);
      command.Parameters.AddWithValue("@FechaCreacion", (object) _productoVO.FechaCreacion);
      command.Parameters.AddWithValue("@IdImpuesto", (object) _productoVO.IdImpuesto);
      command.Parameters.AddWithValue("@NombreImpuesto", (object) _productoVO.NombreImpuesto);
      command.Parameters.AddWithValue("@idSubCategoria", (object) _productoVO.IdSubCategoria);
      command.Parameters.AddWithValue("@SubCategoria", (object) _productoVO.SubCategoria);
      command.Parameters.AddWithValue("@Bodega11", (object) _productoVO.Bodega11);
      command.Parameters.AddWithValue("@Bodega12", (object) _productoVO.Bodega12);
      command.Parameters.AddWithValue("@Bodega13", (object) _productoVO.Bodega13);
      command.Parameters.AddWithValue("@Bodega14", (object) _productoVO.Bodega14);
      command.Parameters.AddWithValue("@Bodega15", (object) _productoVO.Bodega15);
      command.Parameters.AddWithValue("@Bodega16", (object) _productoVO.Bodega16);
      command.Parameters.AddWithValue("@Bodega17", (object) _productoVO.Bodega17);
      command.Parameters.AddWithValue("@Bodega18", (object) _productoVO.Bodega18);
      command.Parameters.AddWithValue("@Bodega19", (object) _productoVO.Bodega19);
      command.Parameters.AddWithValue("@Bodega20", (object) _productoVO.Bodega20);
      ((DbCommand) command).ExecuteNonQuery();
    }

    public void agregaImagenProducto(ProductoVO pro)
    {
      byte[] buffer1 = (byte[]) null;
      byte[] buffer2 = (byte[]) null;
      byte[] buffer3 = (byte[]) null;
      if (pro.RutaImg1.Length > 1)
      {
        FileStream fileStream = new FileStream(pro.RutaImg1, FileMode.Open, FileAccess.Read);
        buffer1 = new byte[fileStream.Length];
        int count = Convert.ToInt32(fileStream.Length);
        fileStream.Read(buffer1, 0, count);
      }
      if (pro.RutaImg2.Length > 1)
      {
        FileStream fileStream = new FileStream(pro.RutaImg2, FileMode.Open, FileAccess.Read);
        buffer2 = new byte[fileStream.Length];
        int count = Convert.ToInt32(fileStream.Length);
        fileStream.Read(buffer2, 0, count);
      }
      if (pro.RutaImg3.Length > 1)
      {
        FileStream fileStream = new FileStream(pro.RutaImg3, FileMode.Open, FileAccess.Read);
        buffer3 = new byte[fileStream.Length];
        int count = Convert.ToInt32(fileStream.Length);
        fileStream.Read(buffer3, 0, count);
      }
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "INSERT INTO imagenes (codigoProducto, imagen1, imagen2, imagen3) VALUES (@codigoProducto, @imagen1, @imagen2, @imagen3)";
      command.Parameters.AddWithValue("@codigoProducto", (object) pro.Codigo);
      command.Parameters.AddWithValue("@imagen1", (object) buffer1);
      command.Parameters.AddWithValue("@imagen2", (object) buffer2);
      command.Parameters.AddWithValue("@imagen3", (object) buffer3);
      ((DbCommand) command).ExecuteNonQuery();
    }

    public void modificaProducto(ProductoVO _productoVO)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "UPDATE productos SET CodigoAlternativo = @CodigoAlternativo, Descripcion = @Descripcion, ResumenDescripcion=@ResumenDescripcion, Marca = @Marca, Activo = @Activo, Pesable = @Pesable, Exento = @Exento ,Kit = @Kit, ValorVenta1 = @ValorVenta1, ValorVenta2 = @ValorVenta2,ValorVenta3 = @ValorVenta3, ValorVenta4 = @ValorVenta4,ValorVenta5 = @ValorVenta5,ValorCompra = @ValorCompra, PorcRentabilidad1 = @PorcRentabilidad1, PorcRentabilidad2 = @PorcRentabilidad2, PorcRentabilidad3 = @PorcRentabilidad3, PorcRentabilidad4 = @PorcRentabilidad4, PorcRentabilidad5 = @PorcRentabilidad5,StockMinimo = @StockMinimo, Bodega1 = @Bodega1, Bodega2 = @Bodega2, Bodega3 = @Bodega3, Bodega4 = @Bodega4, Bodega5 = @Bodega5, Bodega6 = @Bodega6, Bodega7 = @Bodega7, Bodega8 = @Bodega8, Bodega9 = @Bodega9, Bodega10 = @Bodega10, CodCategoria = @CodCategoria, Categoria = @Categoria, CodUnidadMedida = @CodUnidadMedida, UnidadMedida = @UnidadMedida, FechaModificacion=@FechaModificacion, IdImpuesto=@IdImpuesto, NombreImpuesto=@NombreImpuesto, idSubCategoria=@idSubCategoria, SubCategoria=@SubCategoria, Bodega11 = @Bodega11, Bodega12 = @Bodega12, Bodega13 = @Bodega13, Bodega14 = @Bodega14, Bodega15 = @Bodega15, Bodega16 = @Bodega16, Bodega17 = @Bodega17, Bodega18 = @Bodega18, Bodega19 = @Bodega19, Bodega20 = @Bodega20 WHERE Codigo = @Codigo";
      command.Parameters.AddWithValue("@Codigo", (object) _productoVO.Codigo);
      command.Parameters.AddWithValue("@CodigoAlternativo", (object) _productoVO.CodigoAlternativo);
      command.Parameters.AddWithValue("@Descripcion", (object) _productoVO.Descripcion);
      command.Parameters.AddWithValue("@ResumenDescripcion", (object) _productoVO.ResumenDescripcion);
      command.Parameters.AddWithValue("@Marca", (object) _productoVO.Marca);
      command.Parameters.AddWithValue("@Activo", (_productoVO.Activo ? 1 : 0));
      command.Parameters.AddWithValue("@Pesable", (_productoVO.Pesable ? 1 : 0));
      command.Parameters.AddWithValue("@Exento", (_productoVO.Exento ? 1 : 0));
      command.Parameters.AddWithValue("@Kit", (_productoVO.Kit ? 1 : 0));
      command.Parameters.AddWithValue("@ValorVenta1", (object) _productoVO.ValorVenta1);
      command.Parameters.AddWithValue("@ValorVenta2", (object) _productoVO.ValorVenta2);
      command.Parameters.AddWithValue("@ValorVenta3", (object) _productoVO.ValorVenta3);
      command.Parameters.AddWithValue("@ValorVenta4", (object) _productoVO.ValorVenta4);
      command.Parameters.AddWithValue("@ValorVenta5", (object) _productoVO.ValorVenta5);
      command.Parameters.AddWithValue("@ValorCompra", (object) _productoVO.ValorCompra);
      command.Parameters.AddWithValue("@PorcRentabilidad1", (object) _productoVO.PorcRentabilidad1);
      command.Parameters.AddWithValue("@PorcRentabilidad2", (object) _productoVO.PorcRentabilidad2);
      command.Parameters.AddWithValue("@PorcRentabilidad3", (object) _productoVO.PorcRentabilidad3);
      command.Parameters.AddWithValue("@PorcRentabilidad4", (object) _productoVO.PorcRentabilidad4);
      command.Parameters.AddWithValue("@PorcRentabilidad5", (object) _productoVO.PorcRentabilidad5);
      command.Parameters.AddWithValue("@StockMinimo", (object) _productoVO.StockMinimo);
      command.Parameters.AddWithValue("@Bodega1", (object) _productoVO.Bodega1);
      command.Parameters.AddWithValue("@Bodega2", (object) _productoVO.Bodega2);
      command.Parameters.AddWithValue("@Bodega3", (object) _productoVO.Bodega3);
      command.Parameters.AddWithValue("@Bodega4", (object) _productoVO.Bodega4);
      command.Parameters.AddWithValue("@Bodega5", (object) _productoVO.Bodega5);
      command.Parameters.AddWithValue("@Bodega6", (object) _productoVO.Bodega6);
      command.Parameters.AddWithValue("@Bodega7", (object) _productoVO.Bodega7);
      command.Parameters.AddWithValue("@Bodega8", (object) _productoVO.Bodega8);
      command.Parameters.AddWithValue("@Bodega9", (object) _productoVO.Bodega9);
      command.Parameters.AddWithValue("@Bodega10", (object) _productoVO.Bodega10);
      command.Parameters.AddWithValue("@CodCategoria", (object) _productoVO.CodCategoria);
      command.Parameters.AddWithValue("@Categoria", (object) _productoVO.Categoria);
      command.Parameters.AddWithValue("@CodUnidadMedida", (object) _productoVO.CodUnidadMedida);
      command.Parameters.AddWithValue("@UnidadMedida", (object) _productoVO.UnidadMedida);
      command.Parameters.AddWithValue("@FechaModificacion", (object) DateTime.Now);
      command.Parameters.AddWithValue("@IdImpuesto", (object) _productoVO.IdImpuesto);
      command.Parameters.AddWithValue("@NombreImpuesto", (object) _productoVO.NombreImpuesto);
      command.Parameters.AddWithValue("@idSubCategoria", (object) _productoVO.IdSubCategoria);
      command.Parameters.AddWithValue("@SubCategoria", (object) _productoVO.SubCategoria);
      command.Parameters.AddWithValue("@Bodega11", (object) _productoVO.Bodega11);
      command.Parameters.AddWithValue("@Bodega12", (object) _productoVO.Bodega12);
      command.Parameters.AddWithValue("@Bodega13", (object) _productoVO.Bodega13);
      command.Parameters.AddWithValue("@Bodega14", (object) _productoVO.Bodega14);
      command.Parameters.AddWithValue("@Bodega15", (object) _productoVO.Bodega15);
      command.Parameters.AddWithValue("@Bodega16", (object) _productoVO.Bodega16);
      command.Parameters.AddWithValue("@Bodega17", (object) _productoVO.Bodega17);
      command.Parameters.AddWithValue("@Bodega18", (object) _productoVO.Bodega18);
      command.Parameters.AddWithValue("@Bodega19", (object) _productoVO.Bodega19);
      command.Parameters.AddWithValue("@Bodega20", (object) _productoVO.Bodega20);
      ((DbCommand) command).ExecuteNonQuery();
      if (_productoVO.RutaImg1.Length <= 0 && _productoVO.RutaImg2.Length <= 0 && _productoVO.RutaImg3.Length <= 0)
        return;
      this.modificaImagenProducto(_productoVO);
    }

    public void modificaImagenProducto(ProductoVO pro)
    {
      int num = 0;
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      if (pro.RutaImg1.Length > 0)
      {
        byte[] buffer;
        if (pro.RutaImg1.Equals("1"))
        {
          buffer = (byte[]) null;
        }
        else
        {
          FileStream fileStream = new FileStream(pro.RutaImg1, FileMode.Open, FileAccess.Read);
          buffer = new byte[fileStream.Length];
          int count = Convert.ToInt32(fileStream.Length);
          fileStream.Read(buffer, 0, count);
        }
        ((DbCommand) command).CommandText = "UPDATE imagenes SET imagen1=@img1 WHERE codigoProducto = @Cod1";
        command.Parameters.AddWithValue("@img1", (object) buffer);
        command.Parameters.AddWithValue("@Cod1", (object) pro.Codigo);
        num = ((DbCommand) command).ExecuteNonQuery();
      }
      if (pro.RutaImg2.Length > 0)
      {
        byte[] buffer;
        if (pro.RutaImg2.Equals("1"))
        {
          buffer = (byte[]) null;
        }
        else
        {
          FileStream fileStream = new FileStream(pro.RutaImg2, FileMode.Open, FileAccess.Read);
          buffer = new byte[fileStream.Length];
          int count = Convert.ToInt32(fileStream.Length);
          fileStream.Read(buffer, 0, count);
        }
        ((DbCommand) command).CommandText = "UPDATE imagenes SET imagen2=@img2 WHERE codigoProducto = @Cod2";
        command.Parameters.AddWithValue("@img2", (object) buffer);
        command.Parameters.AddWithValue("@Cod2", (object) pro.Codigo);
        num = ((DbCommand) command).ExecuteNonQuery();
      }
      if (pro.RutaImg3.Length > 0)
      {
        byte[] buffer;
        if (pro.RutaImg3.Equals("1"))
        {
          buffer = (byte[]) null;
        }
        else
        {
          FileStream fileStream = new FileStream(pro.RutaImg3, FileMode.Open, FileAccess.Read);
          buffer = new byte[fileStream.Length];
          int count = Convert.ToInt32(fileStream.Length);
          fileStream.Read(buffer, 0, count);
        }
        ((DbCommand) command).CommandText = "UPDATE imagenes SET imagen3=@img3 WHERE codigoProducto = @Cod3";
        command.Parameters.AddWithValue("@img3", (object) buffer);
        command.Parameters.AddWithValue("@Cod3", (object) pro.Codigo);
        num = ((DbCommand) command).ExecuteNonQuery();
      }
      if (num != 0)
        return;
      this.agregaImagenProducto(pro);
    }

    public void eliminaProducto(string cod)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "DELETE FROM productos WHERE Codigo = @Codigo";
      command.Parameters.AddWithValue("@Codigo", (object) cod);
      ((DbCommand) command).ExecuteNonQuery();
      ((DbCommand) command).CommandText = "DELETE FROM imagenes WHERE codigoProducto = @CodigoImg";
      command.Parameters.AddWithValue("@CodigoImg", (object) cod);
      ((DbCommand) command).ExecuteNonQuery();
    }

    public ProductoVO buscaCodigoProducto(string _codigo)
    {
      ProductoVO productoVo = new ProductoVO();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT \r\n                                        Codigo,\r\n                                        CodigoAlternativo,\r\n                                        Descripcion,\r\n                                        ResumenDescripcion,\r\n                                        Marca, \r\n                                        Activo,\r\n                                        Pesable,\r\n                                        Exento,\r\n                                        Kit,\r\n                                        ValorVenta1,\r\n                                        ValorVenta2,\r\n                                        ValorVenta3, \r\n                                        ValorVenta4, \r\n                                        ValorVenta5, \r\n                                        ValorCompra,\r\n                                        PorcRentabilidad1,\r\n                                        PorcRentabilidad2,\r\n                                        PorcRentabilidad3,\r\n                                        PorcRentabilidad4,\r\n                                        PorcRentabilidad5,\r\n                                        StockMinimo,\r\n                                        Bodega1,\r\n                                        Bodega2, \r\n                                        Bodega3,\r\n                                        Bodega4,\r\n                                        Bodega5,\r\n                                        Bodega6,\r\n                                        Bodega7,\r\n                                        Bodega8,\r\n                                        Bodega9,\r\n                                        Bodega10, \r\n                                        CodCategoria,\r\n                                        Categoria,\r\n                                        CodUnidadMedida, \r\n                                        UnidadMedida,\r\n                                        FechaCreacion,\r\n                                        FechaModificacion,\r\n                                        IdImpuesto,\r\n                                        NombreImpuesto,\r\n                                        IdSubCategoria,\r\n                                        SubCategoria,\r\n                                        Bodega11,\r\n                                        Bodega12, \r\n                                        Bodega13,\r\n                                        Bodega14,\r\n                                        Bodega15,\r\n                                        Bodega16,\r\n                                        Bodega17,\r\n                                        Bodega18,\r\n                                        Bodega19,\r\n                                        Bodega20\r\n                               FROM productos WHERE Codigo = @Codigo";
      command.Parameters.AddWithValue("@Codigo", (object) _codigo);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      bool flag = false;
      while (((DbDataReader) mySqlDataReader).Read())
      {
        flag = true;
        productoVo.Codigo = ((DbDataReader) mySqlDataReader)["Codigo"].ToString();
        productoVo.CodigoAlternativo = ((DbDataReader) mySqlDataReader)["CodigoAlternativo"].ToString();
        productoVo.Descripcion = ((DbDataReader) mySqlDataReader)["Descripcion"].ToString();
        productoVo.ResumenDescripcion = ((DbDataReader) mySqlDataReader)["ResumenDescripcion"].ToString();
        productoVo.Marca = ((DbDataReader) mySqlDataReader)["Marca"].ToString();
        productoVo.CodCategoria = Convert.ToInt32(((DbDataReader) mySqlDataReader)["CodCategoria"].ToString());
        productoVo.Categoria = ((DbDataReader) mySqlDataReader)["Categoria"].ToString();
        productoVo.CodUnidadMedida = Convert.ToInt32(((DbDataReader) mySqlDataReader)["CodUnidadMedida"].ToString());
        productoVo.UnidadMedida = ((DbDataReader) mySqlDataReader)["UnidadMedida"].ToString();
        productoVo.Kit = Convert.ToBoolean(((DbDataReader) mySqlDataReader)["Kit"]);
        productoVo.Exento = Convert.ToBoolean(((DbDataReader) mySqlDataReader)["Exento"]);
        productoVo.Pesable = Convert.ToBoolean(((DbDataReader) mySqlDataReader)["Pesable"]);
        productoVo.Activo = Convert.ToBoolean(((DbDataReader) mySqlDataReader)["Activo"]);
        productoVo.ValorCompra = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["ValorCompra"].ToString());
        productoVo.ValorVenta1 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["ValorVenta1"].ToString());
        productoVo.ValorVenta2 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["ValorVenta2"].ToString());
        productoVo.ValorVenta3 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["ValorVenta3"].ToString());
        productoVo.ValorVenta4 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["ValorVenta4"].ToString());
        productoVo.ValorVenta5 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["ValorVenta5"].ToString());
        productoVo.PorcRentabilidad1 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["PorcRentabilidad1"].ToString());
        productoVo.PorcRentabilidad2 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["PorcRentabilidad2"].ToString());
        productoVo.PorcRentabilidad3 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["PorcRentabilidad3"].ToString());
        productoVo.PorcRentabilidad4 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["PorcRentabilidad4"].ToString());
        productoVo.PorcRentabilidad5 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["PorcRentabilidad5"].ToString());
        productoVo.StockMinimo = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["StockMinimo"].ToString());
        productoVo.Bodega1 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["Bodega1"].ToString());
        productoVo.Bodega2 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["Bodega2"].ToString());
        productoVo.Bodega3 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["Bodega3"].ToString());
        productoVo.Bodega4 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["Bodega4"].ToString());
        productoVo.Bodega5 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["Bodega5"].ToString());
        productoVo.Bodega6 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["Bodega6"].ToString());
        productoVo.Bodega7 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["Bodega7"].ToString());
        productoVo.Bodega8 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["Bodega8"].ToString());
        productoVo.Bodega9 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["Bodega9"].ToString());
        productoVo.Bodega10 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["Bodega10"].ToString());
        productoVo.IdImpuesto = Convert.ToInt32(((DbDataReader) mySqlDataReader)["IdImpuesto"].ToString());
        productoVo.NombreImpuesto = ((DbDataReader) mySqlDataReader)["NombreImpuesto"].ToString();
        productoVo.IdSubCategoria = Convert.ToInt32(((DbDataReader) mySqlDataReader)["IdSubCategoria"].ToString());
        productoVo.SubCategoria = ((DbDataReader) mySqlDataReader)["SubCategoria"].ToString();
        productoVo.Bodega11 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["Bodega11"].ToString());
        productoVo.Bodega12 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["Bodega12"].ToString());
        productoVo.Bodega13 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["Bodega13"].ToString());
        productoVo.Bodega14 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["Bodega14"].ToString());
        productoVo.Bodega15 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["Bodega15"].ToString());
        productoVo.Bodega16 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["Bodega16"].ToString());
        productoVo.Bodega17 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["Bodega17"].ToString());
        productoVo.Bodega18 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["Bodega18"].ToString());
        productoVo.Bodega19 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["Bodega19"].ToString());
        productoVo.Bodega20 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["Bodega20"].ToString());
      }
      ((DbDataReader) mySqlDataReader).Close();
      if (!flag && _codigo.Length > 0)
        productoVo = this.buscaCodigoAlternativoProducto(_codigo);
      return productoVo;
    }

    public ProductoVO buscaCodigoAlternativoProducto(string _codigoAlternativo)
    {
      ProductoVO productoVo1 = new ProductoVO();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT \r\n                                        Codigo,\r\n                                        CodigoAlternativo,\r\n                                        Descripcion,\r\n                                        ResumenDescripcion,\r\n                                        Marca, \r\n                                        Activo,\r\n                                        Pesable,\r\n                                        Exento,\r\n                                        Kit,\r\n                                        ValorVenta1,\r\n                                        ValorVenta2,\r\n                                        ValorVenta3, \r\n                                        ValorVenta4, \r\n                                        ValorVenta5, \r\n                                        ValorCompra,\r\n                                        PorcRentabilidad1,\r\n                                        PorcRentabilidad2,\r\n                                        PorcRentabilidad3,\r\n                                        PorcRentabilidad4,\r\n                                        PorcRentabilidad5,\r\n                                        StockMinimo,\r\n                                        Bodega1,\r\n                                        Bodega2, \r\n                                        Bodega3,\r\n                                        Bodega4,\r\n                                        Bodega5,\r\n                                        Bodega6,\r\n                                        Bodega7,\r\n                                        Bodega8,\r\n                                        Bodega9,\r\n                                        Bodega10, \r\n                                        CodCategoria,\r\n                                        Categoria,\r\n                                        CodUnidadMedida, \r\n                                        UnidadMedida,\r\n                                        FechaCreacion,\r\n                                        FechaModificacion,\r\n                                        IdImpuesto,\r\n                                        NombreImpuesto,\r\n                                        IdSubCategoria,\r\n                                        SubCategoria,\r\n                                        Bodega11,\r\n                                        Bodega12, \r\n                                        Bodega13,\r\n                                        Bodega14,\r\n                                        Bodega15,\r\n                                        Bodega16,\r\n                                        Bodega17,\r\n                                        Bodega18,\r\n                                        Bodega19,\r\n                                        Bodega20 \r\n                               FROM productos WHERE CodigoAlternativo = @CodigoAlternativo";
      command.Parameters.AddWithValue("@CodigoAlternativo", (object) _codigoAlternativo);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
      {
        productoVo1.Codigo = ((DbDataReader) mySqlDataReader)["Codigo"].ToString();
        productoVo1.CodigoAlternativo = ((DbDataReader) mySqlDataReader)["CodigoAlternativo"].ToString();
        productoVo1.Descripcion = ((DbDataReader) mySqlDataReader)["Descripcion"].ToString();
        productoVo1.ResumenDescripcion = ((DbDataReader) mySqlDataReader)["ResumenDescripcion"].ToString();
        productoVo1.Marca = ((DbDataReader) mySqlDataReader)["Marca"].ToString();
        productoVo1.CodCategoria = Convert.ToInt32(((DbDataReader) mySqlDataReader)["CodCategoria"].ToString());
        productoVo1.Categoria = ((DbDataReader) mySqlDataReader)["Categoria"].ToString();
        productoVo1.CodUnidadMedida = Convert.ToInt32(((DbDataReader) mySqlDataReader)["CodUnidadMedida"].ToString());
        productoVo1.UnidadMedida = ((DbDataReader) mySqlDataReader)["UnidadMedida"].ToString();
        productoVo1.Kit = Convert.ToBoolean(((DbDataReader) mySqlDataReader)["Kit"]);
        productoVo1.Exento = Convert.ToBoolean(((DbDataReader) mySqlDataReader)["Exento"]);
        productoVo1.Pesable = Convert.ToBoolean(((DbDataReader) mySqlDataReader)["Pesable"]);
        productoVo1.Activo = Convert.ToBoolean(((DbDataReader) mySqlDataReader)["Activo"]);
        productoVo1.ValorCompra = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["ValorCompra"].ToString());
        productoVo1.ValorVenta1 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["ValorVenta1"].ToString());
        productoVo1.ValorVenta2 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["ValorVenta2"].ToString());
        productoVo1.ValorVenta3 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["ValorVenta3"].ToString());
        productoVo1.ValorVenta4 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["ValorVenta4"].ToString());
        productoVo1.ValorVenta5 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["ValorVenta5"].ToString());
        productoVo1.PorcRentabilidad1 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["PorcRentabilidad1"].ToString());
        productoVo1.PorcRentabilidad2 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["PorcRentabilidad2"].ToString());
        productoVo1.PorcRentabilidad3 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["PorcRentabilidad3"].ToString());
        productoVo1.PorcRentabilidad4 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["PorcRentabilidad4"].ToString());
        productoVo1.PorcRentabilidad5 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["PorcRentabilidad5"].ToString());
        productoVo1.StockMinimo = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["StockMinimo"].ToString());
        productoVo1.Bodega1 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["Bodega1"].ToString());
        productoVo1.Bodega2 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["Bodega2"].ToString());
        productoVo1.Bodega3 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["Bodega3"].ToString());
        productoVo1.Bodega4 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["Bodega4"].ToString());
        productoVo1.Bodega5 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["Bodega5"].ToString());
        productoVo1.Bodega6 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["Bodega6"].ToString());
        productoVo1.Bodega7 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["Bodega7"].ToString());
        productoVo1.Bodega8 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["Bodega8"].ToString());
        productoVo1.Bodega9 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["Bodega9"].ToString());
        productoVo1.Bodega10 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["Bodega10"].ToString());
        productoVo1.IdImpuesto = Convert.ToInt32(((DbDataReader) mySqlDataReader)["IdImpuesto"].ToString());
        productoVo1.NombreImpuesto = ((DbDataReader) mySqlDataReader)["NombreImpuesto"].ToString();
        productoVo1.IdSubCategoria = Convert.ToInt32(((DbDataReader) mySqlDataReader)["IdSubCategoria"].ToString());
        productoVo1.SubCategoria = ((DbDataReader) mySqlDataReader)["SubCategoria"].ToString();
        productoVo1.Bodega11 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["Bodega11"].ToString());
        productoVo1.Bodega12 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["Bodega12"].ToString());
        productoVo1.Bodega13 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["Bodega13"].ToString());
        productoVo1.Bodega14 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["Bodega14"].ToString());
        productoVo1.Bodega15 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["Bodega15"].ToString());
        productoVo1.Bodega16 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["Bodega16"].ToString());
        productoVo1.Bodega17 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["Bodega17"].ToString());
        productoVo1.Bodega18 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["Bodega18"].ToString());
        productoVo1.Bodega19 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["Bodega19"].ToString());
        productoVo1.Bodega20 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["Bodega20"].ToString());
      }
      ((DbDataReader) mySqlDataReader).Close();
      ProductoVO productoVo2 = this.buscaImagenProducto(productoVo1.Codigo);
      productoVo1.Img1 = productoVo2.Img1;
      productoVo1.Img2 = productoVo2.Img2;
      productoVo1.Img3 = productoVo2.Img3;
      return productoVo1;
    }

    public ProductoVO buscaImagenProducto(string _codigo)
    {
      ProductoVO productoVo = new ProductoVO();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT imagen1, imagen2, imagen3 FROM imagenes WHERE codigoProducto = @Codigo";
      command.Parameters.AddWithValue("@Codigo", (object) _codigo);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
      {
        if (((DbDataReader) mySqlDataReader)["imagen1"].ToString().Length > 0)
        {
          MemoryStream memoryStream = new MemoryStream((byte[]) ((DbDataReader) mySqlDataReader)["imagen1"]);
          productoVo.Img1 = new Bitmap((Stream) memoryStream);
        }
        if (((DbDataReader) mySqlDataReader)["imagen2"].ToString().Length > 0)
        {
          MemoryStream memoryStream = new MemoryStream((byte[]) ((DbDataReader) mySqlDataReader)["imagen2"]);
          productoVo.Img2 = new Bitmap((Stream) memoryStream);
        }
        if (((DbDataReader) mySqlDataReader)["imagen3"].ToString().Length > 0)
        {
          MemoryStream memoryStream = new MemoryStream((byte[]) ((DbDataReader) mySqlDataReader)["imagen3"]);
          productoVo.Img3 = new Bitmap((Stream) memoryStream);
        }
      }
      ((DbDataReader) mySqlDataReader).Close();
      return productoVo;
    }

    public DataSet listaProductos()
    {
      DataSet dataSet = new DataSet();
      ((DataAdapter) new MySqlDataAdapter("SELECT Codigo, Descripcion, ValorCompra, ValorVenta1, Bodega1 FROM productos ORDER BY Descripcion", this.conexion.ConexionMySql)).Fill(dataSet);
      return dataSet;
    }

    public DataSet listaProductosDescripcion(int campo, string busqueda, string bodega, string categoria)
    {
      DataSet dataSet = new DataSet();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      if (campo == 1)
        ((DbCommand) command).CommandText = "SELECT Codigo, CodigoAlternativo, Descripcion, Marca, ValorCompra, ValorVenta1, " + bodega + " FROM productos WHERE Descripcion like @Busqueda " + categoria;
      if (campo == 2)
        ((DbCommand) command).CommandText = "SELECT Codigo, CodigoAlternativo, Descripcion, Marca, ValorCompra, ValorVenta1, " + bodega + " FROM productos WHERE Marca like @Busqueda " + categoria;
      if (campo == 3)
        ((DbCommand) command).CommandText = "SELECT Codigo, CodigoAlternativo, Descripcion, Marca, ValorCompra, ValorVenta1, " + bodega + " FROM productos WHERE Codigo like @Busqueda " + categoria;
      if (campo == 4)
        ((DbCommand) command).CommandText = "SELECT Codigo, CodigoAlternativo, Descripcion, Marca, ValorCompra, ValorVenta1, " + bodega + " FROM productos WHERE CodigoAlternativo like @Busqueda " + categoria;
      command.Parameters.AddWithValue("@Busqueda", (object) ("%" + busqueda + "%"));
      ((DataAdapter) new MySqlDataAdapter(command)).Fill(dataSet);
      return dataSet;
    }

    public DataSet listaProductosCategoria(string cat)
    {
      DataSet dataSet = new DataSet();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT Codigo, Descripcion, ValorCompra, ValorVenta1, Bodega1 FROM productos WHERE Categoria = @cat";
      command.Parameters.AddWithValue("@cat", (object) cat);
      ((DataAdapter) new MySqlDataAdapter(command)).Fill(dataSet);
      return dataSet;
    }

    public bool tieneKit(string cod)
    {
      bool flag = false;
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT kit FROM productos WHERE codigo=@cod";
      command.Parameters.AddWithValue("@cod", (object) cod);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
      {
        if (Convert.ToBoolean(((DbDataReader) mySqlDataReader)["kit"]))
          flag = true;
      }
      ((DbDataReader) mySqlDataReader).Close();
      return flag;
    }

    public void cambiaEstadoKit(string codigo, bool tieneKit)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "UPDATE productos SET Kit = @Kit WHERE Codigo = @Codigo";
      command.Parameters.AddWithValue("@Codigo", (object) codigo);
      command.Parameters.AddWithValue("@Kit", (tieneKit ? 1 : 0));
      ((DbCommand) command).ExecuteNonQuery();
    }

    public DataTable productoInforme(string filtro, string bod)
    {
      string str = "SELECT \r\n                                        Codigo,\r\n                                        CodigoAlternativo,\r\n                                        Descripcion,\r\n                                        ResumenDescripcion,\r\n                                        Marca,\r\n                                        Activo,\r\n                                        Pesable,\r\n                                        Exento,\r\n                                        Kit,\r\n                                        ValorVenta1,\r\n                                        ValorVenta2,\r\n                                        ValorVenta3,\r\n                                        ValorVenta4,\r\n                                        ValorVenta5,\r\n                                        ValorCompra,\r\n                                        PorcRentabilidad1,\r\n                                        PorcRentabilidad2,\r\n                                        PorcRentabilidad3,\r\n                                        PorcRentabilidad4,  \r\n                                        PorcRentabilidad5,\r\n                                        StockMinimo,\r\n                                        Bodega1,\r\n                                        Bodega2,\r\n                                        Bodega3,\r\n                                        Bodega4,\r\n                                        Bodega5,\r\n                                        Bodega6,\r\n                                        Bodega7,\r\n                                        Bodega8,\r\n                                        Bodega9,\r\n                                        Bodega10,\r\n                                        CodCategoria,\r\n                                        Categoria,\r\n                                        CodUnidadMedida,\r\n                                        UnidadMedida,\r\n                                        FechaCreacion,\r\n                                        IdImpuesto,\r\n                                        NombreImpuesto,\r\n                                        IdSubCategoria,\r\n                                        SubCategoria,\r\n                                        Bodega11,\r\n                                        Bodega12,\r\n                                        Bodega13,\r\n                                        Bodega14,\r\n                                        Bodega15,\r\n                                        Bodega16,\r\n                                        Bodega17,\r\n                                        Bodega18,\r\n                                        Bodega19,\r\n                                        Bodega20,\r\n                                        " + bod + " as 'BodegaSeleccionada',\r\n                                        " + bod + " as 'NombreBodega'\r\n                                FROM productos                             \r\n                                WHERE " + filtro;
      DataTable dataTable = new DataTable();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = str;
      ((DbDataAdapter) new MySqlDataAdapter(command)).Fill(dataTable);
      return dataTable;
    }

    public List<ProductoVO> listaPLU()
    {
      List<ProductoVO> list = new List<ProductoVO>();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT Codigo, Descripcion, ValorVenta1 FROM productos WHERE pesable=1";
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        list.Add(new ProductoVO()
        {
          Codigo = ((DbDataReader) mySqlDataReader)["Codigo"].ToString(),
          Descripcion = ((DbDataReader) mySqlDataReader)["Descripcion"].ToString(),
          ValorVenta1 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["ValorVenta1"].ToString())
        });
      ((DbDataReader) mySqlDataReader).Close();
      return list;
    }

    public List<ProductoVO> listaProductosDescripcionMantenedor(int campo, string busqueda, string categoria)
    {
      List<ProductoVO> list = new List<ProductoVO>();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      if (campo == 1)
        ((DbCommand) command).CommandText = "SELECT Codigo, Descripcion, ValorCompra, ValorVenta1, PorcRentabilidad1, Exento FROM productos WHERE Descripcion like @Busqueda " + categoria;
      if (campo == 3)
        ((DbCommand) command).CommandText = "SELECT Codigo, Descripcion, ValorCompra, ValorVenta1, PorcRentabilidad1, Exento FROM productos WHERE Codigo like @Busqueda " + categoria;
      command.Parameters.AddWithValue("@Busqueda", (object) ("%" + busqueda + "%"));
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        list.Add(new ProductoVO()
        {
          Codigo = ((DbDataReader) mySqlDataReader)["Codigo"].ToString(),
          Descripcion = ((DbDataReader) mySqlDataReader)["Descripcion"].ToString(),
          ValorCompra = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["ValorCompra"].ToString()),
          ValorVenta1 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["ValorVenta1"].ToString()),
          PorcRentabilidad1 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["PorcRentabilidad1"].ToString()),
          Exento = Convert.ToBoolean(((DbDataReader) mySqlDataReader)["Exento"])
        });
      ((DbDataReader) mySqlDataReader).Close();
      return list;
    }

    public void modificaPrecioProducto(ProductoVO _productoVO)
    {
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "UPDATE productos SET\r\n                                    ValorVenta1 = @ValorVenta1, PorcRentabilidad1 = @PorcRentabilidad1 WHERE Codigo = @Codigo";
      command.Parameters.AddWithValue("@Codigo", (object) _productoVO.Codigo);
      command.Parameters.AddWithValue("@ValorVenta1", (object) _productoVO.ValorVenta1);
      command.Parameters.AddWithValue("@PorcRentabilidad1", (object) _productoVO.PorcRentabilidad1);
      ((DbCommand) command).ExecuteNonQuery();
    }

    public void modificaStockBodega(string bod)
    {
      foreach (ProductoVO pr in this.listaMantenedorProductos("Bodega" + bod))
        this.comparaStockActualiza(pr);
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "UPDATE productos SET Bodega" + bod + "=0 ";
      ((DbCommand) command).ExecuteNonQuery();
    }

    public List<ProductoVO> listaMantenedorProductos(string bodega)
    {
      List<ProductoVO> list = new List<ProductoVO>();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT Codigo, Descripcion, " + bodega + " FROM productos";
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        list.Add(new ProductoVO()
        {
          Codigo = ((DbDataReader) mySqlDataReader)["Codigo"].ToString(),
          Descripcion = ((DbDataReader) mySqlDataReader)["Descripcion"].ToString(),
          Bodega1 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)[bodega ?? ""].ToString())
        });
      ((DbDataReader) mySqlDataReader).Close();
      return list;
    }

    private void comparaStockActualiza(ProductoVO pr)
    {
      new ControlProducto().agregaControlProducto(new ControlProductoVO()
      {
        CodigoProducto = pr.Codigo,
        DescripcionProducto = pr.Descripcion,
        Usuario = frmMenuPrincipal.listaUsuario[0].NombreUsuario,
        Movimiento = "DEJA STOCK EN CERO",
        Bodega = 1,
        CantidadAnterior = pr.Bodega1,
        CantidadActual = new Decimal(0)
      });
    }

    public List<ProductoVO> listaProductosIdCategoria(int idCategoria)
    {
      List<ProductoVO> list = new List<ProductoVO>();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT Codigo, Descripcion FROM productos WHERE CodCategoria = @idCategoria ORDER BY Descripcion";
      command.Parameters.AddWithValue("@idCategoria", (object) idCategoria);
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        list.Add(new ProductoVO()
        {
          Codigo = ((DbDataReader) mySqlDataReader)["Codigo"].ToString(),
          Descripcion = ((DbDataReader) mySqlDataReader)["Descripcion"].ToString()
        });
      ((DbDataReader) mySqlDataReader).Close();
      return list;
    }

    public List<ProductoVO> buscaProductoPorCategoria(string _categoria)
    {
        if (_categoria != "")
        {
            _categoria = !(_categoria != "[TODAS]") ? "" : "WHERE Categoria='" + _categoria + "'";
        }

      List<ProductoVO> list = new List<ProductoVO>();
      ProductoVO productoVo = new ProductoVO();
      MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
      ((DbCommand) command).CommandText = "SELECT \r\n                                        Codigo,\r\n                                        CodigoAlternativo,\r\n                                        Descripcion,\r\n                                        Marca, \r\n                                        Activo,\r\n                                        Pesable,\r\n                                        Exento,\r\n                                        Kit,\r\n                                        ValorVenta1,\r\n                                        ValorVenta2,\r\n                                        ValorVenta3, \r\n                                        ValorVenta4, \r\n                                        ValorVenta5, \r\n                                        ValorCompra,\r\n                                        PorcRentabilidad1,\r\n                                        PorcRentabilidad2,\r\n                                        PorcRentabilidad3,\r\n                                        PorcRentabilidad4,\r\n                                        PorcRentabilidad5,\r\n                                        StockMinimo,\r\n                                        Bodega1,\r\n                                        Bodega2, \r\n                                        Bodega3,\r\n                                        Bodega4,\r\n                                        Bodega5,\r\n                                        Bodega6,\r\n                                        Bodega7,\r\n                                        Bodega8,\r\n                                        Bodega9,\r\n                                        Bodega10, \r\n                                        CodCategoria,\r\n                                        Categoria,\r\n                                        CodUnidadMedida, \r\n                                        UnidadMedida,\r\n                                        FechaCreacion,\r\n                                        FechaModificacion,\r\n                                        IdImpuesto,\r\n                                        NombreImpuesto,\r\n                                        Bodega11,\r\n                                        Bodega12, \r\n                                        Bodega13,\r\n                                        Bodega14,\r\n                                        Bodega15,\r\n                                        Bodega16,\r\n                                        Bodega17,\r\n                                        Bodega18,\r\n                                        Bodega19,\r\n                                        Bodega20 \r\n                               FROM productos " + _categoria + " ORDER BY Descripcion";
      MySqlDataReader mySqlDataReader = command.ExecuteReader();
      while (((DbDataReader) mySqlDataReader).Read())
        list.Add(new ProductoVO()
        {
          Codigo = ((DbDataReader) mySqlDataReader)["Codigo"].ToString(),
          CodigoAlternativo = ((DbDataReader) mySqlDataReader)["CodigoAlternativo"].ToString(),
          Descripcion = ((DbDataReader) mySqlDataReader)["Descripcion"].ToString(),
          Marca = ((DbDataReader) mySqlDataReader)["Marca"].ToString(),
          CodCategoria = Convert.ToInt32(((DbDataReader) mySqlDataReader)["CodCategoria"].ToString()),
          Categoria = ((DbDataReader) mySqlDataReader)["Categoria"].ToString(),
          CodUnidadMedida = Convert.ToInt32(((DbDataReader) mySqlDataReader)["CodUnidadMedida"].ToString()),
          UnidadMedida = ((DbDataReader) mySqlDataReader)["UnidadMedida"].ToString(),
          Kit = Convert.ToBoolean(((DbDataReader) mySqlDataReader)["Kit"]),
          Exento = Convert.ToBoolean(((DbDataReader) mySqlDataReader)["Exento"]),
          Pesable = Convert.ToBoolean(((DbDataReader) mySqlDataReader)["Pesable"]),
          Activo = Convert.ToBoolean(((DbDataReader) mySqlDataReader)["Activo"]),
          ValorCompra = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["ValorCompra"].ToString()),
          ValorVenta1 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["ValorVenta1"].ToString()),
          ValorVenta2 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["ValorVenta2"].ToString()),
          ValorVenta3 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["ValorVenta3"].ToString()),
          ValorVenta4 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["ValorVenta4"].ToString()),
          ValorVenta5 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["ValorVenta5"].ToString()),
          PorcRentabilidad1 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["PorcRentabilidad1"].ToString()),
          PorcRentabilidad2 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["PorcRentabilidad2"].ToString()),
          PorcRentabilidad3 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["PorcRentabilidad3"].ToString()),
          PorcRentabilidad4 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["PorcRentabilidad4"].ToString()),
          PorcRentabilidad5 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["PorcRentabilidad5"].ToString()),
          StockMinimo = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["StockMinimo"].ToString()),
          Bodega1 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["Bodega1"].ToString()),
          Bodega2 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["Bodega2"].ToString()),
          Bodega3 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["Bodega3"].ToString()),
          Bodega4 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["Bodega4"].ToString()),
          Bodega5 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["Bodega5"].ToString()),
          Bodega6 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["Bodega6"].ToString()),
          Bodega7 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["Bodega7"].ToString()),
          Bodega8 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["Bodega8"].ToString()),
          Bodega9 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["Bodega9"].ToString()),
          Bodega10 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["Bodega10"].ToString()),
          IdImpuesto = Convert.ToInt32(((DbDataReader) mySqlDataReader)["IdImpuesto"].ToString()),
          NombreImpuesto = ((DbDataReader) mySqlDataReader)["NombreImpuesto"].ToString(),
          Bodega11 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["Bodega11"].ToString()),
          Bodega12 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["Bodega12"].ToString()),
          Bodega13 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["Bodega13"].ToString()),
          Bodega14 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["Bodega14"].ToString()),
          Bodega15 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["Bodega15"].ToString()),
          Bodega16 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["Bodega16"].ToString()),
          Bodega17 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["Bodega17"].ToString()),
          Bodega18 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["Bodega18"].ToString()),
          Bodega19 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["Bodega19"].ToString()),
          Bodega20 = Convert.ToDecimal(((DbDataReader) mySqlDataReader)["Bodega20"].ToString())
        });
      ((DbDataReader) mySqlDataReader).Close();
      return list;
    }
  }
}
