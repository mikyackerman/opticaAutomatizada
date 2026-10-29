using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace opticaApp
{
    public partial class DetallesCliente : Form
    {
        private int clienteId;

        public DetallesCliente(int id)
        {
            InitializeComponent();
            clienteId = id;
            CargarDatosCliente();
        }

        private void CargarDatosCliente()
        {
            string conexion = "Server=localhost;Database=optica_test;Uid=root;Pwd=;";

            using (MySqlConnection conn = new MySqlConnection(conexion))
            {
                conn.Open();

                string sql = @"SELECT nombre, apellido, telefono, correo
                       FROM clientes
                       WHERE cliente_id = @id";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", clienteId);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            lblDatos.Text = reader["nombre"].ToString()
                                           + " "
                                           + reader["apellido"].ToString() + " - " + reader["telefono"].ToString()
                                           + " - " + reader["correo"].ToString();


                        }
                        else
                        {
                            MessageBox.Show("No se encontró el paciente.");
                        }
                    }
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnVolverPacientes_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnVerObservaciones_Click(object sender, EventArgs e)
        {
            using (Observaciones formulario = new Observaciones(clienteId))
            {
                formulario.ShowDialog();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
