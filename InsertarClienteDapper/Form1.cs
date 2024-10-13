using System;
using AccesoDatos;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsertarClienteDapper
{

    public partial class Form1 : Form
    {
        ProductosRepository productosR = new ProductosRepository();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnObtenerTodo_Click(object sender, EventArgs e)
        {
            var producto = productosR.ObtenerTodo();
            dgvProductos.DataSource = producto;
        }

        private void RellenarForm(Productos productos)
        {
            txbIDProducto.Text = productos.Id.ToString();
            txbNombre.Text = productos.Nombre;
            txbDescripcion.Text = productos.Descripcion;
            txbPrecio.Text = productos.Precio.ToString("F2");
            txbStock.Text = productos.Stock.ToString();
            txbMarca.Text = productos.Marca;
            txbCategoria.Text = productos.Categoria;


        }
        #region Insertar
        private void btnInsertarProducto_Click(object sender, EventArgs e)
        {
            var nuevoProducto = CrearProducto();
            var insertado = productosR.InsertarProducto(nuevoProducto);
            MessageBox.Show($"{insertado} registros insertados");
        }

        private Productos CrearProducto()
        {
            var nuevo = new Productos
            {
                Id = int.Parse(txbIDProducto.Text),
                Nombre = txbNombre.Text,
                Descripcion = txbDescripcion.Text,
                Precio = decimal.Parse(txbPrecio.Text), 
                Stock = int.Parse(txbStock.Text),
                Marca = txbMarca.Text,
                Categoria = txbCategoria.Text,  
            };
            return nuevo;
        }

        #endregion

        private void btnBuscarporID_Click(object sender, EventArgs e)
        {
            var producto = productosR.ObtenerPorId(Int32.Parse(txbBuscarporID.Text));
            dgvProductos.DataSource = new List<Productos> { producto };

            if (producto != null)
            {
                RellenarForm(producto);
            }
        }

        private void txbPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo dígitos, el punto decimal y el carácter de retroceso
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                // Si no es válido, cancela el carácter (evita que se ingrese)
                e.Handled = true;
            }
        }

        private void txbStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si el carácter ingresado no es un control (como Backspace) y no es un dígito
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Si no es válido, cancela el carácter (evita que se ingrese)
                e.Handled = true;
            }
        }
    }
}
