using System;
using System.Windows.Forms;
using tarea.Controllers;
using tarea.Models;


namespace tarea
{
    public partial class Form1 : Form
    {
        private ClienteController clienteController = new ClienteController();

        public Form1()
        {
            InitializeComponent();
            InicializarDataGridView();
            btnagregar.Click += BtnAgregar_Click;
        }

        private void InicializarDataGridView()
        {
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = clienteController.ObtenerClientes();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            string rut = txtrut.Text;
            string nombre = txtnombre.Text;
            bool esEmpresa = rbt1.Checked;
            string telefono = txttelefono.Text;
            string direccion = txtdirecion.Text;
            DateTime fechaRegistro = dtpfecharegistro.Value;

            Cliente nuevoCliente = new Cliente
            {
                Rut = rut,
                Nombre = nombre,
                EsEmpresa = esEmpresa,
                Telefono = telefono,
                Direccion = direccion,
                FechaRegistro = fechaRegistro,
                CantidadFacturas = int.Parse(txtcantidadfacturas.Text),
                NumeroUltimaFactura = int.Parse(txtnumeroultimafactura.Text),
                MontoUltimaFactura = int.Parse(txtmontoultimafactura.Text)
            };

            clienteController.AgregarCliente(nuevoCliente);
            ActualizarDataGridView();
            LimpiarControles();
        }

        private void ActualizarDataGridView()
        {
            dataGridView1.DataSource = clienteController.ObtenerClientes();
        }

        private void LimpiarControles()
        {
            txtrut.Clear();
            txtnombre.Clear();
            txttelefono.Clear();
            txtdirecion.Clear();
            txtcantidadfacturas.Clear();
            txtnumeroultimafactura.Clear();
            txtmontoultimafactura.Clear();
            rbt1.Checked = false;
            rbt2.Checked = false;
            dtpfecharegistro.Value = DateTime.Now;
        }

        private void telefono_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtrut_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
