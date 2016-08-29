
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Aptusoft.Maquinaria
{
    class Maquinaria
    {
        private Conexion conn = Conexion.getConecta();

        public void guardaMaquinaria(MaquinariaVO maVO)
        {
            this.agregaMaquinaria(maVO);
        }

        public void agregaMaquinaria(MaquinariaVO maVO)
        {
            MySqlCommand command = this.conn.ConexionMySql.CreateCommand();
            ((DbCommand)command).CommandText = "INSERT INTO maquinaria (codigo, nombre, descripcion, valor, idEstado, estado, bod_1,  bod_2,  bod_3, bod_4, bod_5, bod_6, bod_7, bod_8, bod_9, bod_10) VALUES(@codigo, @nombre, @descripcion, @valor, @idEstado, @estado, @bod_1, bod_2, bod_3, bod_4, bod_5, bod_6, bod_7, bod_8, bod_9, bod_10)";
            command.Parameters.AddWithValue("@codigo", (object)maVO.codigo);
            command.Parameters.AddWithValue("@nombre", (object)maVO.nombre);
            command.Parameters.AddWithValue("@descripcion", (object)maVO.descripcion);
            command.Parameters.AddWithValue("@valor", (object)maVO.valor);
            command.Parameters.AddWithValue("@idEstado", (object)maVO.idEstado);
            command.Parameters.AddWithValue("@estado", (object)maVO.estado);
            command.Parameters.AddWithValue("@bod_1", (object)maVO.bod_1);
            command.Parameters.AddWithValue("@bod_2", (object)maVO.bod_2);
            command.Parameters.AddWithValue("@bod_3", (object)maVO.bod_3);
            command.Parameters.AddWithValue("@bod_4", (object)maVO.bod_4);
            command.Parameters.AddWithValue("@bod_5", (object)maVO.bod_5);
            command.Parameters.AddWithValue("@bod_6", (object)maVO.bod_6);
            command.Parameters.AddWithValue("@bod_7", (object)maVO.bod_7);
            command.Parameters.AddWithValue("@bod_8", (object)maVO.bod_8);
            command.Parameters.AddWithValue("@bod_9", (object)maVO.bod_9);
            command.Parameters.AddWithValue("@bod_10", (object)maVO.bod_10);
            ((DbCommand)command).ExecuteNonQuery();
        }

        //public void agregaImagenProducto(MaquinariaVO maVO)
        //{
        //    byte[] buffer1 = (byte[])null;
        //    byte[] buffer2 = (byte[])null;
        //    byte[] buffer3 = (byte[])null;
        //    if (pro.RutaImg1.Length > 1)
        //    {
        //        FileStream fileStream = new FileStream(pro.RutaImg1, FileMode.Open, FileAccess.Read);
        //        buffer1 = new byte[fileStream.Length];
        //        int count = Convert.ToInt32(fileStream.Length);
        //        fileStream.Read(buffer1, 0, count);
        //    }
        //    if (pro.RutaImg2.Length > 1)
        //    {
        //        FileStream fileStream = new FileStream(pro.RutaImg2, FileMode.Open, FileAccess.Read);
        //        buffer2 = new byte[fileStream.Length];
        //        int count = Convert.ToInt32(fileStream.Length);
        //        fileStream.Read(buffer2, 0, count);
        //    }
        //    if (pro.RutaImg3.Length > 1)
        //    {
        //        FileStream fileStream = new FileStream(pro.RutaImg3, FileMode.Open, FileAccess.Read);
        //        buffer3 = new byte[fileStream.Length];
        //        int count = Convert.ToInt32(fileStream.Length);
        //        fileStream.Read(buffer3, 0, count);
        //    }
        //    MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
        //    ((DbCommand)command).CommandText = "INSERT INTO imagenes (codigoProducto, imagen1, imagen2, imagen3) VALUES (@codigoProducto, @imagen1, @imagen2, @imagen3)";
        //    command.Parameters.AddWithValue("@codigoProducto", (object)pro.Codigo);
        //    command.Parameters.AddWithValue("@imagen1", (object)buffer1);
        //    command.Parameters.AddWithValue("@imagen2", (object)buffer2);
        //    command.Parameters.AddWithValue("@imagen3", (object)buffer3);
        //    ((DbCommand)command).ExecuteNonQuery();
        //}

        public void modificaMaquinaria(MaquinariaVO maVO)
        {
            MySqlCommand command = this.conn.ConexionMySql.CreateCommand();
            ((DbCommand)command).CommandText = "UPDATE maquinaria SET nombre = @nombre, descripcion = @descripcion, valor=@valor, idEstado = @idEstado, estado = @estado, bod_1 = @bod_1, bod_2 = @bod_2, bod_3 = @bod_3, bod_4 = @bod_4, bod_5 = @bod_5, bod_6 = @bod_6, bod_7 = @bod_7, bod_8 = @bod_8, bod_9 = @bod_9, bod_10 = @bod_10 WHERE codigo = @codigo";
            command.Parameters.AddWithValue("@Codigo", (object)maVO.codigo);
            command.Parameters.AddWithValue("@nombre", (object)maVO.nombre);
            command.Parameters.AddWithValue("@descripcion", (object)maVO.descripcion);
            command.Parameters.AddWithValue("@valor", (object)maVO.valor);
            command.Parameters.AddWithValue("@idEstado", (object)maVO.idEstado);
            command.Parameters.AddWithValue("@estado", (object)maVO.estado);
            command.Parameters.AddWithValue("@bod_1", (object)maVO.bod_1);
            command.Parameters.AddWithValue("@bod_2", (object)maVO.bod_2);
            command.Parameters.AddWithValue("@bod_3", (object)maVO.bod_3);
            command.Parameters.AddWithValue("@bod_4", (object)maVO.bod_4);
            command.Parameters.AddWithValue("@bod_5", (object)maVO.bod_5);
            command.Parameters.AddWithValue("@bod_6", (object)maVO.bod_6);
            command.Parameters.AddWithValue("@bod_7", (object)maVO.bod_7);
            command.Parameters.AddWithValue("@bod_8", (object)maVO.bod_8);
            command.Parameters.AddWithValue("@bod_9", (object)maVO.bod_9);
            command.Parameters.AddWithValue("@bod_10", (object)maVO.bod_10);
            ((DbCommand)command).ExecuteNonQuery();
            //if (maVO.RutaImg1.Length <= 0 && maVO.RutaImg2.Length <= 0 && maVO.RutaImg3.Length <= 0)
            //    return;
            //this.modificaImagenProducto(maVO);
        }

        //public void modificaImagenProducto(ProductoVO pro)
        //{
        //    int num = 0;
        //    MySqlCommand command = this.conexion.ConexionMySql.CreateCommand();
        //    if (pro.RutaImg1.Length > 0)
        //    {
        //        byte[] buffer;
        //        if (pro.RutaImg1.Equals("1"))
        //        {
        //            buffer = (byte[])null;
        //        }
        //        else
        //        {
        //            FileStream fileStream = new FileStream(pro.RutaImg1, FileMode.Open, FileAccess.Read);
        //            buffer = new byte[fileStream.Length];
        //            int count = Convert.ToInt32(fileStream.Length);
        //            fileStream.Read(buffer, 0, count);
        //        }
        //        ((DbCommand)command).CommandText = "UPDATE imagenes SET imagen1=@img1 WHERE codigoProducto = @Cod1";
        //        command.Parameters.AddWithValue("@img1", (object)buffer);
        //        command.Parameters.AddWithValue("@Cod1", (object)pro.Codigo);
        //        num = ((DbCommand)command).ExecuteNonQuery();
        //    }
        //    if (pro.RutaImg2.Length > 0)
        //    {
        //        byte[] buffer;
        //        if (pro.RutaImg2.Equals("1"))
        //        {
        //            buffer = (byte[])null;
        //        }
        //        else
        //        {
        //            FileStream fileStream = new FileStream(pro.RutaImg2, FileMode.Open, FileAccess.Read);
        //            buffer = new byte[fileStream.Length];
        //            int count = Convert.ToInt32(fileStream.Length);
        //            fileStream.Read(buffer, 0, count);
        //        }
        //        ((DbCommand)command).CommandText = "UPDATE imagenes SET imagen2=@img2 WHERE codigoProducto = @Cod2";
        //        command.Parameters.AddWithValue("@img2", (object)buffer);
        //        command.Parameters.AddWithValue("@Cod2", (object)pro.Codigo);
        //        num = ((DbCommand)command).ExecuteNonQuery();
        //    }
        //    if (pro.RutaImg3.Length > 0)
        //    {
        //        byte[] buffer;
        //        if (pro.RutaImg3.Equals("1"))
        //        {
        //            buffer = (byte[])null;
        //        }
        //        else
        //        {
        //            FileStream fileStream = new FileStream(pro.RutaImg3, FileMode.Open, FileAccess.Read);
        //            buffer = new byte[fileStream.Length];
        //            int count = Convert.ToInt32(fileStream.Length);
        //            fileStream.Read(buffer, 0, count);
        //        }
        //        ((DbCommand)command).CommandText = "UPDATE imagenes SET imagen3=@img3 WHERE codigoProducto = @Cod3";
        //        command.Parameters.AddWithValue("@img3", (object)buffer);
        //        command.Parameters.AddWithValue("@Cod3", (object)pro.Codigo);
        //        num = ((DbCommand)command).ExecuteNonQuery();
        //    }
        //    if (num != 0)
        //        return;
        //    this.agregaImagenProducto(pro);
        //}

        public void eliminaMaquinaria(string cod)
        {
            MySqlCommand command = this.conn.ConexionMySql.CreateCommand();
            ((DbCommand)command).CommandText = "DELETE FROM maquinaria WHERE codigo = @codigo";
            command.Parameters.AddWithValue("@codigo", (object)cod);
            ((DbCommand)command).ExecuteNonQuery();
            //((DbCommand)command).CommandText = "DELETE FROM imagenes WHERE codigoProducto = @CodigoImg";
            //command.Parameters.AddWithValue("@CodigoImg", (object)cod);
            //((DbCommand)command).ExecuteNonQuery();
        }

        public MaquinariaVO buscaCodigoMaquinaria(string _codigo)
        {
            MaquinariaVO maVO = new MaquinariaVO();
            MySqlCommand command = this.conn.ConexionMySql.CreateCommand();
            ((DbCommand)command).CommandText = "SELECT codigo, nombre, descripcion, valor, idEstado, estado, bod_1, bod_2, bod_3, bod_4, bod_5, bod_6, bod_7, bod_8, bod_9, bod_10 FROM maquinaria WHERE codigo = @codigo";
            command.Parameters.AddWithValue("@codigo", (object)_codigo);
            MySqlDataReader mySqlDataReader = command.ExecuteReader();
            bool flag = false;
            while (((DbDataReader)mySqlDataReader).Read())
            {
                flag = true;
                maVO.codigo = ((DbDataReader)mySqlDataReader)["Codigo"].ToString();
                maVO.nombre = ((DbDataReader)mySqlDataReader)["nombre"].ToString();
                maVO.descripcion = ((DbDataReader)mySqlDataReader)["descripcion"].ToString();
                maVO.valor = Convert.ToDecimal(((DbDataReader)mySqlDataReader)["valor"].ToString());
                maVO.idEstado = Convert.ToInt32(((DbDataReader)mySqlDataReader)["idEstado"].ToString());
                maVO.estado = ((DbDataReader)mySqlDataReader)["estado"].ToString();
                maVO.bod_1 = Convert.ToDecimal(((DbDataReader)mySqlDataReader)["bod_1"].ToString());
                maVO.bod_2 = Convert.ToDecimal(((DbDataReader)mySqlDataReader)["bod_2"].ToString());
                maVO.bod_3 = Convert.ToDecimal(((DbDataReader)mySqlDataReader)["bod_3"].ToString());
                maVO.bod_4 = Convert.ToDecimal(((DbDataReader)mySqlDataReader)["bod_4"].ToString());
                maVO.bod_5 = Convert.ToDecimal(((DbDataReader)mySqlDataReader)["bod_5"].ToString());
                maVO.bod_6 = Convert.ToDecimal(((DbDataReader)mySqlDataReader)["bod_6"].ToString());
                maVO.bod_7 = Convert.ToDecimal(((DbDataReader)mySqlDataReader)["bod_7"].ToString());
                maVO.bod_8 = Convert.ToDecimal(((DbDataReader)mySqlDataReader)["bod_8"].ToString());
                maVO.bod_9 = Convert.ToDecimal(((DbDataReader)mySqlDataReader)["bod_9"].ToString());
                maVO.bod_10 = Convert.ToDecimal(((DbDataReader)mySqlDataReader)["bod_10"].ToString());
            }
            ((DbDataReader)mySqlDataReader).Close();
            //if (!flag && _codigo.Length > 0)
            //    maVO = this.buscaCodigoAlternativoProducto(_codigo);
            return maVO;
        }

        //public ProductoVO buscaCodigoAlternativoProducto(string _codigoAlternativo)
        //{
        //    ProductoVO productoVo1 = new ProductoVO();
        //    MySqlCommand command = this.conn.ConexionMySql.CreateCommand();
        //    ((DbCommand)command).CommandText = "SELECT \r\n                                        Codigo,\r\n                                        CodigoAlternativo,\r\n                                        Descripcion,\r\n                                        ResumenDescripcion,\r\n                                        Marca, \r\n                                        Activo,\r\n                                        Pesable,\r\n                                        Exento,\r\n                                        Kit,\r\n                                        ValorVenta1,\r\n                                        ValorVenta2,\r\n                                        ValorVenta3, \r\n                                        ValorVenta4, \r\n                                        ValorVenta5, \r\n                                        ValorCompra,\r\n                                        PorcRentabilidad1,\r\n                                        PorcRentabilidad2,\r\n                                        PorcRentabilidad3,\r\n                                        PorcRentabilidad4,\r\n                                        PorcRentabilidad5,\r\n                                        StockMinimo,\r\n                                        Bodega1,\r\n                                        Bodega2, \r\n                                        Bodega3,\r\n                                        Bodega4,\r\n                                        Bodega5,\r\n                                        Bodega6,\r\n                                        Bodega7,\r\n                                        Bodega8,\r\n                                        Bodega9,\r\n                                        Bodega10, \r\n                                        CodCategoria,\r\n                                        Categoria,\r\n                                        CodUnidadMedida, \r\n                                        UnidadMedida,\r\n                                        FechaCreacion,\r\n                                        FechaModificacion,\r\n                                        IdImpuesto,\r\n                                        NombreImpuesto,\r\n                                        IdSubCategoria,\r\n                                        SubCategoria,\r\n                                        Bodega11,\r\n                                        Bodega12, \r\n                                        Bodega13,\r\n                                        Bodega14,\r\n                                        Bodega15,\r\n                                        Bodega16,\r\n                                        Bodega17,\r\n                                        Bodega18,\r\n                                        Bodega19,\r\n                                        Bodega20 \r\n                               FROM productos WHERE CodigoAlternativo = @CodigoAlternativo";
        //    command.Parameters.AddWithValue("@CodigoAlternativo", (object)_codigoAlternativo);
        //    MySqlDataReader mySqlDataReader = command.ExecuteReader();
        //    while (((DbDataReader)mySqlDataReader).Read())
        //    {
        //        productoVo1.Codigo = ((DbDataReader)mySqlDataReader)["Codigo"].ToString();
        //        productoVo1.CodigoAlternativo = ((DbDataReader)mySqlDataReader)["CodigoAlternativo"].ToString();
        //        productoVo1.Descripcion = ((DbDataReader)mySqlDataReader)["Descripcion"].ToString();
        //        productoVo1.ResumenDescripcion = ((DbDataReader)mySqlDataReader)["ResumenDescripcion"].ToString();
        //        productoVo1.Marca = ((DbDataReader)mySqlDataReader)["Marca"].ToString();
        //        productoVo1.CodCategoria = Convert.ToInt32(((DbDataReader)mySqlDataReader)["CodCategoria"].ToString());
        //        productoVo1.Categoria = ((DbDataReader)mySqlDataReader)["Categoria"].ToString();
        //        productoVo1.CodUnidadMedida = Convert.ToInt32(((DbDataReader)mySqlDataReader)["CodUnidadMedida"].ToString());
        //        productoVo1.UnidadMedida = ((DbDataReader)mySqlDataReader)["UnidadMedida"].ToString();
        //        productoVo1.Kit = Convert.ToBoolean(((DbDataReader)mySqlDataReader)["Kit"]);
        //        productoVo1.Exento = Convert.ToBoolean(((DbDataReader)mySqlDataReader)["Exento"]);
        //        productoVo1.Pesable = Convert.ToBoolean(((DbDataReader)mySqlDataReader)["Pesable"]);
        //        productoVo1.Activo = Convert.ToBoolean(((DbDataReader)mySqlDataReader)["Activo"]);
        //        productoVo1.ValorCompra = Convert.ToDecimal(((DbDataReader)mySqlDataReader)["ValorCompra"].ToString());
        //        productoVo1.ValorVenta1 = Convert.ToDecimal(((DbDataReader)mySqlDataReader)["ValorVenta1"].ToString());
        //        productoVo1.ValorVenta2 = Convert.ToDecimal(((DbDataReader)mySqlDataReader)["ValorVenta2"].ToString());
        //        productoVo1.ValorVenta3 = Convert.ToDecimal(((DbDataReader)mySqlDataReader)["ValorVenta3"].ToString());
        //        productoVo1.ValorVenta4 = Convert.ToDecimal(((DbDataReader)mySqlDataReader)["ValorVenta4"].ToString());
        //        productoVo1.ValorVenta5 = Convert.ToDecimal(((DbDataReader)mySqlDataReader)["ValorVenta5"].ToString());
        //        productoVo1.PorcRentabilidad1 = Convert.ToDecimal(((DbDataReader)mySqlDataReader)["PorcRentabilidad1"].ToString());
        //        productoVo1.PorcRentabilidad2 = Convert.ToDecimal(((DbDataReader)mySqlDataReader)["PorcRentabilidad2"].ToString());
        //        productoVo1.PorcRentabilidad3 = Convert.ToDecimal(((DbDataReader)mySqlDataReader)["PorcRentabilidad3"].ToString());
        //        productoVo1.PorcRentabilidad4 = Convert.ToDecimal(((DbDataReader)mySqlDataReader)["PorcRentabilidad4"].ToString());
        //        productoVo1.PorcRentabilidad5 = Convert.ToDecimal(((DbDataReader)mySqlDataReader)["PorcRentabilidad5"].ToString());
        //        productoVo1.StockMinimo = Convert.ToDecimal(((DbDataReader)mySqlDataReader)["StockMinimo"].ToString());
        //        productoVo1.Bodega1 = Convert.ToDecimal(((DbDataReader)mySqlDataReader)["Bodega1"].ToString());
        //        productoVo1.Bodega2 = Convert.ToDecimal(((DbDataReader)mySqlDataReader)["Bodega2"].ToString());
        //        productoVo1.Bodega3 = Convert.ToDecimal(((DbDataReader)mySqlDataReader)["Bodega3"].ToString());
        //        productoVo1.Bodega4 = Convert.ToDecimal(((DbDataReader)mySqlDataReader)["Bodega4"].ToString());
        //        productoVo1.Bodega5 = Convert.ToDecimal(((DbDataReader)mySqlDataReader)["Bodega5"].ToString());
        //        productoVo1.Bodega6 = Convert.ToDecimal(((DbDataReader)mySqlDataReader)["Bodega6"].ToString());
        //        productoVo1.Bodega7 = Convert.ToDecimal(((DbDataReader)mySqlDataReader)["Bodega7"].ToString());
        //        productoVo1.Bodega8 = Convert.ToDecimal(((DbDataReader)mySqlDataReader)["Bodega8"].ToString());
        //        productoVo1.Bodega9 = Convert.ToDecimal(((DbDataReader)mySqlDataReader)["Bodega9"].ToString());
        //        productoVo1.Bodega10 = Convert.ToDecimal(((DbDataReader)mySqlDataReader)["Bodega10"].ToString());
        //        productoVo1.IdImpuesto = Convert.ToInt32(((DbDataReader)mySqlDataReader)["IdImpuesto"].ToString());
        //        productoVo1.NombreImpuesto = ((DbDataReader)mySqlDataReader)["NombreImpuesto"].ToString();
        //        productoVo1.IdSubCategoria = Convert.ToInt32(((DbDataReader)mySqlDataReader)["IdSubCategoria"].ToString());
        //        productoVo1.SubCategoria = ((DbDataReader)mySqlDataReader)["SubCategoria"].ToString();
        //        productoVo1.Bodega11 = Convert.ToDecimal(((DbDataReader)mySqlDataReader)["Bodega11"].ToString());
        //        productoVo1.Bodega12 = Convert.ToDecimal(((DbDataReader)mySqlDataReader)["Bodega12"].ToString());
        //        productoVo1.Bodega13 = Convert.ToDecimal(((DbDataReader)mySqlDataReader)["Bodega13"].ToString());
        //        productoVo1.Bodega14 = Convert.ToDecimal(((DbDataReader)mySqlDataReader)["Bodega14"].ToString());
        //        productoVo1.Bodega15 = Convert.ToDecimal(((DbDataReader)mySqlDataReader)["Bodega15"].ToString());
        //        productoVo1.Bodega16 = Convert.ToDecimal(((DbDataReader)mySqlDataReader)["Bodega16"].ToString());
        //        productoVo1.Bodega17 = Convert.ToDecimal(((DbDataReader)mySqlDataReader)["Bodega17"].ToString());
        //        productoVo1.Bodega18 = Convert.ToDecimal(((DbDataReader)mySqlDataReader)["Bodega18"].ToString());
        //        productoVo1.Bodega19 = Convert.ToDecimal(((DbDataReader)mySqlDataReader)["Bodega19"].ToString());
        //        productoVo1.Bodega20 = Convert.ToDecimal(((DbDataReader)mySqlDataReader)["Bodega20"].ToString());
        //    }
        //    ((DbDataReader)mySqlDataReader).Close();
        //    ProductoVO productoVo2 = this.buscaImagenProducto(productoVo1.Codigo);
        //    productoVo1.Img1 = productoVo2.Img1;
        //    productoVo1.Img2 = productoVo2.Img2;
        //    productoVo1.Img3 = productoVo2.Img3;
        //    return productoVo1;
        //}

        //public ProductoVO buscaImagenProducto(string _codigo)
        //{
        //    ProductoVO productoVo = new ProductoVO();
        //    MySqlCommand command = this.conn.ConexionMySql.CreateCommand();
        //    ((DbCommand)command).CommandText = "SELECT imagen1, imagen2, imagen3 FROM imagenes WHERE codigoProducto = @Codigo";
        //    command.Parameters.AddWithValue("@Codigo", (object)_codigo);
        //    MySqlDataReader mySqlDataReader = command.ExecuteReader();
        //    while (((DbDataReader)mySqlDataReader).Read())
        //    {
        //        if (((DbDataReader)mySqlDataReader)["imagen1"].ToString().Length > 0)
        //        {
        //            MemoryStream memoryStream = new MemoryStream((byte[])((DbDataReader)mySqlDataReader)["imagen1"]);
        //            productoVo.Img1 = new Bitmap((Stream)memoryStream);
        //        }
        //        if (((DbDataReader)mySqlDataReader)["imagen2"].ToString().Length > 0)
        //        {
        //            MemoryStream memoryStream = new MemoryStream((byte[])((DbDataReader)mySqlDataReader)["imagen2"]);
        //            productoVo.Img2 = new Bitmap((Stream)memoryStream);
        //        }
        //        if (((DbDataReader)mySqlDataReader)["imagen3"].ToString().Length > 0)
        //        {
        //            MemoryStream memoryStream = new MemoryStream((byte[])((DbDataReader)mySqlDataReader)["imagen3"]);
        //            productoVo.Img3 = new Bitmap((Stream)memoryStream);
        //        }
        //    }
        //    ((DbDataReader)mySqlDataReader).Close();
        //    return productoVo;
        //}

        public DataSet listaMaquinaria()
        {
            DataSet dataSet = new DataSet();
            ((DataAdapter)new MySqlDataAdapter("SELECT codigo, nombre, descripcion, valor, idEstado, estado, bod_1, bod_2, bod_3, bod_4, bod_5, bod_6, bod_7, bod_8, bod_9, bod_10 FROM maquinaria ORDER BY nombre", this.conn.ConexionMySql)).Fill(dataSet);
            return dataSet;
        }

        public DataSet listaMaquinariaDescripcion(int campo, string busqueda, string bodega, string estado)
        {
            DataSet dataSet = new DataSet();
            MySqlCommand command = this.conn.ConexionMySql.CreateCommand();
            if (campo == 1)
                ((DbCommand)command).CommandText = "SELECT Codigo, CodigoAlternativo, Descripcion, Marca, ValorCompra, ValorVenta1, " + bodega + " FROM productos WHERE Descripcion like @Busqueda " + estado;
            if (campo == 2)
                ((DbCommand)command).CommandText = "SELECT Codigo, CodigoAlternativo, Descripcion, Marca, ValorCompra, ValorVenta1, " + bodega + " FROM productos WHERE Marca like @Busqueda " + estado;
            if (campo == 3)
                ((DbCommand)command).CommandText = "SELECT Codigo, CodigoAlternativo, Descripcion, Marca, ValorCompra, ValorVenta1, " + bodega + " FROM productos WHERE Codigo like @Busqueda " + estado;
            if (campo == 4)
                ((DbCommand)command).CommandText = "SELECT Codigo, CodigoAlternativo, Descripcion, Marca, ValorCompra, ValorVenta1, " + bodega + " FROM productos WHERE CodigoAlternativo like @Busqueda " + estado;
            command.Parameters.AddWithValue("@Busqueda", (object)("%" + busqueda + "%"));
            ((DataAdapter)new MySqlDataAdapter(command)).Fill(dataSet);
            return dataSet;
        }

        public DataSet listaMaquinariaEstado(string est)
        {
            DataSet dataSet = new DataSet();
            MySqlCommand command = this.conn.ConexionMySql.CreateCommand();
            ((DbCommand)command).CommandText = "SELECT codigo, nombre, Descripcion, valor, bod_1 FROM maquinaria WHERE estado = @est";
            command.Parameters.AddWithValue("@est", (object)est);
            ((DataAdapter)new MySqlDataAdapter(command)).Fill(dataSet);
            return dataSet;
        }

        //public bool tieneKit(string cod)
        //{
        //    bool flag = false;
        //    MySqlCommand command = this.conn.ConexionMySql.CreateCommand();
        //    ((DbCommand)command).CommandText = "SELECT kit FROM productos WHERE codigo=@cod";
        //    command.Parameters.AddWithValue("@cod", (object)cod);
        //    MySqlDataReader mySqlDataReader = command.ExecuteReader();
        //    while (((DbDataReader)mySqlDataReader).Read())
        //    {
        //        if (Convert.ToBoolean(((DbDataReader)mySqlDataReader)["kit"]))
        //            flag = true;
        //    }
        //    ((DbDataReader)mySqlDataReader).Close();
        //    return flag;
        //}

        //public void cambiaEstadoKit(string codigo, bool tieneKit)
        //{
        //    MySqlCommand command = this.conn.ConexionMySql.CreateCommand();
        //    ((DbCommand)command).CommandText = "UPDATE productos SET Kit = @Kit WHERE Codigo = @Codigo";
        //    command.Parameters.AddWithValue("@Codigo", (object)codigo);
        //    command.Parameters.AddWithValue("@Kit", (tieneKit ? 1 : 0));
        //    ((DbCommand)command).ExecuteNonQuery();
        //}

        public DataTable productoInforme(string filtro, string bod)
        {
            string str = "SELECT codigo, nombre, descripcion, valor, idEstado, estado, bod_1, bod_2, bod_3, bod_4, bod_5, bod_6, bod_7, bod_8, bod_9, bod_10 FROM maquinaria WHERE " + filtro;
            DataTable dataTable = new DataTable();
            MySqlCommand command = this.conn.ConexionMySql.CreateCommand();
            ((DbCommand)command).CommandText = str;
            ((DbDataAdapter)new MySqlDataAdapter(command)).Fill(dataTable);
            return dataTable;
        }

        //public List<ProductoVO> listaPLU()
        //{
        //    List<ProductoVO> list = new List<ProductoVO>();
        //    MySqlCommand command = this.conn.ConexionMySql.CreateCommand();
        //    ((DbCommand)command).CommandText = "SELECT Codigo, Descripcion, ValorVenta1 FROM productos WHERE pesable=1";
        //    MySqlDataReader mySqlDataReader = command.ExecuteReader();
        //    while (((DbDataReader)mySqlDataReader).Read())
        //        list.Add(new ProductoVO()
        //        {
        //            Codigo = ((DbDataReader)mySqlDataReader)["Codigo"].ToString(),
        //            Descripcion = ((DbDataReader)mySqlDataReader)["Descripcion"].ToString(),
        //            ValorVenta1 = Convert.ToDecimal(((DbDataReader)mySqlDataReader)["ValorVenta1"].ToString())
        //        });
        //    ((DbDataReader)mySqlDataReader).Close();
        //    return list;
        //}

        public List<MaquinariaVO> listaMaquinariaNombreMantenedor(int campo, string busqueda, string estado)
        {
            List<MaquinariaVO> list = new List<MaquinariaVO>();
            MySqlCommand command = this.conn.ConexionMySql.CreateCommand();
            if (campo == 1)
                ((DbCommand)command).CommandText = "SELECT codigo, nombre, descripcion, valor FROM productos WHERE nombre like @Busqueda " + estado;
            if (campo == 3)
                ((DbCommand)command).CommandText = "SELECT codigo, nombre, descripcion, valor FROM productos WHERE codigo like @Busqueda " + estado;
            command.Parameters.AddWithValue("@Busqueda", (object)("%" + busqueda + "%"));
            MySqlDataReader mySqlDataReader = command.ExecuteReader();
            while (((DbDataReader)mySqlDataReader).Read())
                list.Add(new MaquinariaVO()
                {
                    codigo = ((DbDataReader)mySqlDataReader)["codigo"].ToString(),
                    nombre = ((DbDataReader)mySqlDataReader)["nombre"].ToString(),
                    descripcion = ((DbDataReader)mySqlDataReader)["descripcion"].ToString(),
                    valor = Convert.ToDecimal(((DbDataReader)mySqlDataReader)["valor"].ToString())
                });
            ((DbDataReader)mySqlDataReader).Close();
            return list;
        }

        public void modificaPrecioMaquinaria(MaquinariaVO maVO)
        {
            MySqlCommand command = this.conn.ConexionMySql.CreateCommand();
            ((DbCommand)command).CommandText = "UPDATE maquinaria SET valor = @valor WHERE codigo = @codigo";
            command.Parameters.AddWithValue("@codigo", (object)maVO.codigo);
            command.Parameters.AddWithValue("@valor", (object)maVO.valor);
            ((DbCommand)command).ExecuteNonQuery();
        }

        //public void modificaStockBodega(string bod)
        //{
        //    foreach (ProductoVO pr in this.listaMantenedorProductos("Bodega" + bod))
        //        this.comparaStockActualiza(pr);
        //    MySqlCommand command = this.conn.ConexionMySql.CreateCommand();
        //    ((DbCommand)command).CommandText = "UPDATE productos SET Bodega" + bod + "=0 ";
        //    ((DbCommand)command).ExecuteNonQuery();
        //}

        //public List<ProductoVO> listaMantenedorProductos(string bodega)
        //{
        //    List<ProductoVO> list = new List<ProductoVO>();
        //    MySqlCommand command = this.conn.ConexionMySql.CreateCommand();
        //    ((DbCommand)command).CommandText = "SELECT Codigo, Descripcion, " + bodega + " FROM productos";
        //    MySqlDataReader mySqlDataReader = command.ExecuteReader();
        //    while (((DbDataReader)mySqlDataReader).Read())
        //        list.Add(new ProductoVO()
        //        {
        //            Codigo = ((DbDataReader)mySqlDataReader)["Codigo"].ToString(),
        //            Descripcion = ((DbDataReader)mySqlDataReader)["Descripcion"].ToString(),
        //            Bodega1 = Convert.ToDecimal(((DbDataReader)mySqlDataReader)[bodega ?? ""].ToString())
        //        });
        //    ((DbDataReader)mySqlDataReader).Close();
        //    return list;
        //}

        //private void comparaStockActualiza(ProductoVO pr)
        //{
        //    new ControlProducto().agregaControlProducto(new ControlProductoVO()
        //    {
        //        CodigoProducto = pr.Codigo,
        //        DescripcionProducto = pr.Descripcion,
        //        Usuario = frmMenuPrincipal.listaUsuario[0].NombreUsuario,
        //        Movimiento = "DEJA STOCK EN CERO",
        //        Bodega = 1,
        //        CantidadAnterior = pr.Bodega1,
        //        CantidadActual = new Decimal(0)
        //    });
        //}

        public List<MaquinariaVO> listaMaquinariaIdEstado(int idEstado)
        {
            List<MaquinariaVO> list = new List<MaquinariaVO>();
            MySqlCommand command = this.conn.ConexionMySql.CreateCommand();
            ((DbCommand)command).CommandText = "SELECT codigo, nombre FROM maquinaria WHERE idEstado = @idEstado ORDER BY nombre";
            command.Parameters.AddWithValue("@idEstado", (object)idEstado);
            MySqlDataReader mySqlDataReader = command.ExecuteReader();
            while (((DbDataReader)mySqlDataReader).Read())
                list.Add(new MaquinariaVO()
                {
                    codigo = ((DbDataReader)mySqlDataReader)["codigo"].ToString(),
                    nombre = ((DbDataReader)mySqlDataReader)["nombre"].ToString()
                });
            ((DbDataReader)mySqlDataReader).Close();
            return list;
        }

        public List<MaquinariaVO> buscaMaquinariaPorEstado(string estado)
        {
            estado = !(estado != "[TODAS]") ? "" : "WHERE estado='" + estado + "'";
            List<MaquinariaVO> list = new List<MaquinariaVO>();
            //MaquinariaVO productoVo = new MaquinariaVO();
            MySqlCommand command = this.conn.ConexionMySql.CreateCommand();
            ((DbCommand)command).CommandText = "SELECT codigo, nombre, descripcion, valor, idEstado, estado, bod_1, bod_2, bod_3, bod_4, bod_5, bod_6, bod_7, bod_8, bod_9, bod_10 FROM maquinaria " + estado + " ORDER BY nombre";
            MySqlDataReader mySqlDataReader = command.ExecuteReader();
            while (((DbDataReader)mySqlDataReader).Read())
                list.Add(new MaquinariaVO()
                {
                    codigo = ((DbDataReader)mySqlDataReader)["codigo"].ToString(),
                    nombre = ((DbDataReader)mySqlDataReader)["nombre"].ToString(),
                    descripcion = ((DbDataReader)mySqlDataReader)["descripcion"].ToString(),
                    valor = Convert.ToDecimal(((DbDataReader)mySqlDataReader)["valor"].ToString()),
                    idEstado = Convert.ToInt32(((DbDataReader)mySqlDataReader)["idEstado"].ToString()),
                    estado = ((DbDataReader)mySqlDataReader)["estado"].ToString(),
                    bod_1 = Convert.ToDecimal(((DbDataReader)mySqlDataReader)["bod_1"].ToString()),
                    bod_2 = Convert.ToDecimal(((DbDataReader)mySqlDataReader)["bod_2"].ToString()),
                    bod_3 = Convert.ToDecimal(((DbDataReader)mySqlDataReader)["bod_3"].ToString()),
                    bod_4 = Convert.ToDecimal(((DbDataReader)mySqlDataReader)["bod_4"].ToString()),
                    bod_5 = Convert.ToDecimal(((DbDataReader)mySqlDataReader)["bod_5"].ToString()),
                    bod_6 = Convert.ToDecimal(((DbDataReader)mySqlDataReader)["bod_6"].ToString()),
                    bod_7 = Convert.ToDecimal(((DbDataReader)mySqlDataReader)["bod_7"].ToString()),
                    bod_8 = Convert.ToDecimal(((DbDataReader)mySqlDataReader)["bod_8"].ToString()),
                    bod_9 = Convert.ToDecimal(((DbDataReader)mySqlDataReader)["bod_9"].ToString()),
                    bod_10 = Convert.ToDecimal(((DbDataReader)mySqlDataReader)["bod_10"].ToString())
                });
            ((DbDataReader)mySqlDataReader).Close();
            return list;
        }
    }
}
