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


        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ignorar encabezados y clics que no corresponden a una fila
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            // Obtener el nombre de la columna pulsada
            string columna = dgvClientes.Columns[e.ColumnIndex].Name;

            // MODIFICAR CLIENTE
            if (columna == "colModificar")
            {
                int clienteId = Convert.ToInt32(
                    dgvClientes.Rows[e.RowIndex].Cells["cliente_id"].Value
                );

                RegistroClientes formulario = new RegistroClientes(clienteId);
                formulario.ShowDialog();

                CargarClientes();
            }

            // ELIMINAR CLIENTE
            else if (columna == "colEliminar")
            {
                int clienteId = Convert.ToInt32(
                    dgvClientes.Rows[e.RowIndex].Cells["cliente_id"].Value
                );

                DialogResult respuesta = MessageBox.Show(
                    "¿Estás seguro de que deseas eliminar este cliente?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (respuesta == DialogResult.Yes)
                {
                    try
                    {
                        using (MySqlConnection conn = new MySqlConnection(conexion))
                        {
                            conn.Open();

                            string sql = @"DELETE FROM clientes
                                   WHERE cliente_id = @id";

                            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                            {
                                cmd.Parameters.AddWithValue("@id", clienteId);

                                int filasEliminadas = cmd.ExecuteNonQuery();

                                if (filasEliminadas > 0)
                                {
                                    MessageBox.Show(
                                        "Cliente eliminado correctamente."
                                    );
                                }
                                else
                                {
                                    MessageBox.Show(
                                        "No se encontró el cliente para eliminar."
                                    );
                                }
                            }
                        }

                        CargarClientes();
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(
                            "No se pudo eliminar el cliente. Puede que existan " +
                            "registros relacionados con él.\n\n" + ex.Message,
                            "Error de base de datos",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(
                            "Ocurrió un error: " + ex.Message,
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                    }
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dgvClientes_CellDoubleClick(
            object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            int clienteId = Convert.ToInt32(
                dgvClientes.Rows[e.RowIndex].Cells["cliente_id"].Value
            );

            using (DetallesCliente formulario = new DetallesCliente(clienteId))
            {
                formulario.ShowDialog();
            }
        }
    }
}
