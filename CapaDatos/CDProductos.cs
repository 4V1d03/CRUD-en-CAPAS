using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    //esta clase hace las condultas a la tabla productos
    public class CDProductos
    {
        private ConexionBD conexion = new ConexionBD(); //intancia de la clase conexion, y de manera privada para encapsular la variable

        SqlDataReader leerfilas;
        DataTable tabla = new DataTable(); //almacen las lecturas que hara leerfilas
        SqlCommand comando = new SqlCommand();//ejecuta las consultas sql o procedimientos almacenados

        //Querry SQL
        public DataTable mostrar()
        {   
            comando.Connection = conexion.abrir();
            comando.CommandText = "MostrarProductos";
            comando.CommandType = CommandType.StoredProcedure;
            leerfilas = comando.ExecuteReader();//devuelve filas
            tabla.Load(leerfilas);
            conexion.cerrar();
            
            return tabla;  
        }

        //Procedimiento Almacenado
        public void Insertar(string nombre, string descripcion, string marca, double precio, int stock)
        {
            comando.Connection = conexion.abrir();
            comando.CommandText = "InsertarProductos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@desc", descripcion);
            comando.Parameters.AddWithValue("@marca", marca);
            comando.Parameters.AddWithValue("@precio", precio);
            comando.Parameters.AddWithValue("@stock", stock);
            comando.ExecuteNonQuery();//ExecuteNonQuery() solo es para ejecutar instrucciones insert,delet,update. y devuelve filas
            comando.Parameters.Clear();//limpia los parametros cada ves despues de hacer una consulta
        }

        public void Editar(string nombre, string descripcion, string marca, double precio, int stock, int id)
        {
            comando.Connection = conexion.abrir();
            comando.CommandText = "EditarProductos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@desc", descripcion);
            comando.Parameters.AddWithValue("@marca", marca);
            comando.Parameters.AddWithValue("@precio", precio);
            comando.Parameters.AddWithValue("@stock", stock);
            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public void eliminar(int id)
        {
            comando.Connection = conexion.abrir();
            comando.CommandText = "eliminarProcducto";
            comando.CommandType= CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();

        }













    }
}
