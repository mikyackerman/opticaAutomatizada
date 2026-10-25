using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace opticaApp
{
    public partial class GestionClientes : Form
    {
        private DataTable tablaClientes;

        string conexion = "Server=localhost;Database=optica_test;Uid=root;Pwd=cagadamierda123;";
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
                       FROM clientes";

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn))
                {
                    tablaClientes = new DataTable();

                    adapter.Fill(tablaClientes);

                    dgvClientes.DataSource = tablaClientes;

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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
