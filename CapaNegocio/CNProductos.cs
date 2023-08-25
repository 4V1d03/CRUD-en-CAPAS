using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaDatos;//Ensamblaje de la Capa de Datos
using System.Runtime.InteropServices;

namespace CapaNegocio
{
    public class CNProductos
    {
        private CDProductos CDproducto = new CDProductos();

        public DataTable MostrarProductos()
        {
            DataTable tabla = new DataTable();
            tabla = CDproducto.mostrar();
            return tabla;
        }

        public void insertar (string nombre, string descripcion, string marca, string precio, string stock) //aqui los parametros son de tipo string por que en los txt los captura de esa manera
        {
            CDproducto.Insertar(nombre, descripcion, marca,Convert.ToDouble(precio),Convert.ToInt32(stock));//es aqui donde se validan los datos antes de ser enviados a la capa de datos
            
        }

        public void editar(string nombre, string descripcion, string marca, string precio, string stock, string id)
        {
            CDproducto.Editar(nombre, descripcion, marca, Convert.ToDouble(precio), Convert.ToInt32(stock), Convert.ToInt32(id));
        }

        public void eliminar(string id)
        {
            CDproducto.eliminar(Convert.ToInt32(id));
        }






    }
}
