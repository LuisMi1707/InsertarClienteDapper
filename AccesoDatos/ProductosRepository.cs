using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class ProductosRepository
    {
        public List<Productos> ObtenerTodo()
        {
            using (var conexion =
                DataBase.GetSqlConnection())
            {
                String ObtenerTodo = "";
                ObtenerTodo = ObtenerTodo + "SELECT [Id] " + "\n";
                ObtenerTodo = ObtenerTodo + "      ,[Nombre] " + "\n";
                ObtenerTodo = ObtenerTodo + "      ,[Descripcion] " + "\n";
                ObtenerTodo = ObtenerTodo + "      ,[Precio] " + "\n";
                ObtenerTodo = ObtenerTodo + "      ,[Stock] " + "\n";
                ObtenerTodo = ObtenerTodo + "      ,[Marca] " + "\n";
                ObtenerTodo = ObtenerTodo + "      ,[Categoria] " + "\n";
                ObtenerTodo = ObtenerTodo + "  FROM [dbo].[Productos]";

                var cliente = conexion.Query<Productos>(ObtenerTodo).ToList();
                return cliente;


            }

        }
        public int InsertarProducto(Productos producto)
        {
            using (var conexion = DataBase.GetSqlConnection())
            {
                String Insertar = "";
                Insertar = Insertar + "INSERT INTO [dbo].[Productos] " + "\n";
                Insertar = Insertar + "           ([Id] " + "\n";
                Insertar = Insertar + "           ,[Nombre] " + "\n";
                Insertar = Insertar + "           ,[Descripcion] " + "\n";
                Insertar = Insertar + "           ,[Precio] " + "\n";
                Insertar = Insertar + "           ,[Stock] " + "\n";
                Insertar = Insertar + "           ,[Marca] " + "\n";
                Insertar = Insertar + "           ,[Categoria]) " + "\n";
                Insertar = Insertar + "     VALUES " + "\n";
                Insertar = Insertar + "           (@Id " + "\n";
                Insertar = Insertar + "           ,@Nombre " + "\n";
                Insertar = Insertar + "           ,@Descripcion " + "\n";
                Insertar = Insertar + "           ,@Precio " + "\n";
                Insertar = Insertar + "           ,@Stock " + "\n";
                Insertar = Insertar + "           ,@Marca " + "\n";
                Insertar = Insertar + "           ,@Categoria)";
                var insertadas = conexion.Execute(Insertar, new
                {
                    id = producto.Id,
                    nombre = producto.Nombre,
                    descripcion = producto.Descripcion,
                    precio = producto.Precio,
                    stock = producto.Stock,
                    marca = producto.Marca,
                    categoria = producto.Categoria,
                });
                return insertadas;
            }


        }
        public Productos ObtenerPorId(int id)
        {
            using (var conexion = DataBase.GetSqlConnection())
            {
                String SelectForId = "";
                SelectForId = SelectForId + "SELECT [Id] " + "\n";
                SelectForId = SelectForId + "      ,[Nombre] " + "\n";
                SelectForId = SelectForId + "      ,[Descripcion] " + "\n";
                SelectForId = SelectForId + "      ,[Precio] " + "\n";
                SelectForId = SelectForId + "      ,[Stock] " + "\n";
                SelectForId = SelectForId + "      ,[Marca] " + "\n";
                SelectForId = SelectForId + "      ,[Categoria] " + "\n";
                SelectForId = SelectForId + "  FROM [dbo].[Productos] " + "\n";
                SelectForId = SelectForId + "  WHERE Id = @Id";

                var IdProduct = conexion.QueryFirstOrDefault<Productos>(SelectForId, new Productos { Id = id });
                return IdProduct;
            }

        }

    }
}
