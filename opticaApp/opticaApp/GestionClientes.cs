using System;

using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
    

namespace opticaApp
{
    public partial class GestionClientes : Form
    {
        private DataTable tablaClientes;

        string conexion = "Server=localhost;Database=optica_test;Uid=root;Pwd=;";
        public GestionClientes()
        {
            InitializeComponent();
            CargarClientes();
        }

        private void CargarClientes()
        {
            using (MySqlConnection conn = new MySqlConnection(conexion))
            {
                conn.Open();

                string sql = @"SELECT cliente_id, nombre, apellido,
                              fecha_nacimiento, correo, telefono
                       FROM clientes
                       ORDER BY fecha_registro DESC";

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn))
                {
                    tablaClientes = new DataTable();

                    adapter.Fill(tablaClientes);

                    dgvClientes.DataSource = tablaClientes;
                    CrearColumnasAcciones();

                    foreach (DataGridViewColumn columna in dgvClientes.Columns)
                    {
                        columna.SortMode = DataGridViewColumnSortMode.NotSortable;
                    }
                }
            }

            dgvClientes.Columns["cliente_id"].Visible = false;

            dgvClientes.Columns["nombre"].HeaderText = "Nombre";
            dgvClientes.Columns["apellido"].HeaderText = "Apellido";
            dgvClientes.Columns["fecha_nacimiento"].HeaderText = "Fecha de nacimiento";
            dgvClientes.Columns["correo"].HeaderText = "Correo electrónico";
            dgvClientes.Columns["telefono"].HeaderText = "Teléfono";



        }

        private void CrearColumnasAcciones()
        {

            // Evitar crear las columnas más de una vez
            if (dgvClientes.Columns["colModificar"] != null)
                return;

            DataGridViewButtonColumn modificar = new DataGridViewButtonColumn();
            modificar.Name = "colModificar";
            modificar.HeaderText = "Modificar";
            modificar.Text = "✏️";
            modificar.UseColumnTextForButtonValue = true;
            modificar.FlatStyle = FlatStyle.Flat;
            modificar.DefaultCellStyle.BackColor = Color.White;
            dgvClientes.Columns.Add(modificar);

            DataGridViewButtonColumn eliminar = new DataGridViewButtonColumn();
            eliminar.Name = "colEliminar";
            eliminar.HeaderText = "Eliminar";
            eliminar.Text = "🗑️";
            eliminar.UseColumnTextForButtonValue = true;
            eliminar.FlatStyle = FlatStyle.Flat;
            eliminar.DefaultCellStyle.BackColor = Color.White;
            dgvClientes.Columns.Add(eliminar);

            dgvClientes.Columns["colModificar"].Width = 50;
            dgvClientes.Columns["colEliminar"].Width = 50;

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (tablaClientes == null)
                return;

            string busqueda = txtBuscar.Text.Trim().Replace("'", "''");

            tablaClientes.DefaultView.RowFilter =
              $"nombre LIKE '%{busqueda}%' OR " +
              $"apellido LIKE '%{busqueda}%'";
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            RegistroClientes formulario = new RegistroClientes();

            formulario.ShowDialog();

            CargarClientes();
        }

    }
}
