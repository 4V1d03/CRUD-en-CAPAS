using CapaNegocio;

namespace CapaPresentacion
{
    public partial class Form1 : Form
    {
        CNProductos CNProducto = new CNProductos();
        private string idProducto = null;
        private bool editar = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Mostrarproductos();
        }

        private void Mostrarproductos()
        {
            CNProductos CNobjeto = new CNProductos();
            dataGridView1.DataSource = CNobjeto.MostrarProductos();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            //Guardar
            if (editar == false)
            {
                try
                {
                    CNProducto.insertar(txtnombre.Text, txtdesc.Text, txtmarca.Text, txtprecio.Text, txtstock.Text);
                    MessageBox.Show("Se Guardo Correctamente");
                    Mostrarproductos();
                    limpiar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se Guardaron los datos por: " + ex);
                }
            }
            //Editar
            if (editar == true)
            {
                try
                {
                    CNProducto.editar(txtnombre.Text, txtdesc.Text, txtmarca.Text, txtprecio.Text, txtstock.Text, idProducto);
                    MessageBox.Show("Se Edito Correctamente");
                    Mostrarproductos();
                    limpiar();
                    editar = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("no se puedo editar los datos por: " + ex);

                }
            }

        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            //envia los valores de la fila a los txt correspondientes
            if (dataGridView1.SelectedRows.Count > 0)
            {
                editar = true;
                txtnombre.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();// la cell debe de estar escrita igual que en la BD
                txtdesc.Text = dataGridView1.CurrentRow.Cells["Descripcion"].Value.ToString();
                txtmarca.Text = dataGridView1.CurrentRow.Cells["Marca"].Value.ToString();
                txtprecio.Text = dataGridView1.CurrentRow.Cells["Precio"].Value.ToString();
                txtstock.Text = dataGridView1.CurrentRow.Cells["Stock"].Value.ToString();
                idProducto = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
            }

            else
            {
                MessageBox.Show("seleccione una fila por favor");
            }
        }

        private void limpiar()
        {
            txtnombre.Clear();
            txtmarca.Clear();
            txtprecio.Clear();
            txtstock.Text = "";
            txtdesc.Clear();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                idProducto = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
                CNProducto.eliminar(idProducto);
                MessageBox.Show("Eliminado Correctamente");
                Mostrarproductos();
            }
            else
            {
                MessageBox.Show("seleccione una fila por favor");
            }
        }

    }
}