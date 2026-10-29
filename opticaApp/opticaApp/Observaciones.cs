using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace opticaApp
{
    public partial class Observaciones : Form
    {

        private int clienteId;
        public Observaciones(int id)
        {
            InitializeComponent();
            clienteId = id;
            CargarObservaciones();
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string conexion = "Server=localhost;Database=optica_test;Uid=root;Pwd=;";

            string sql = @"INSERT INTO observaciones
                   (cliente_id, molestias_actuales, antecedentes_generales,
                    antecedentes_oculares, notas_adicionales)
                   VALUES
                   (@clienteId, @molestias, @generales,
                    @oculares, @notas)";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(conexion))
                {
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@clienteId", clienteId);
                        cmd.Parameters.AddWithValue("@molestias", txtMolestias.Text.Trim());
                        cmd.Parameters.AddWithValue("@generales", txtAntecedentesGenerales.Text.Trim());
                        cmd.Parameters.AddWithValue("@oculares", txtAntecedentesOculares.Text.Trim());
                        cmd.Parameters.AddWithValue("@notas", txtNotasAdicionales.Text.Trim());

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Observaciones guardadas correctamente.",
                                "Éxito",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar las observaciones: " + ex.Message,
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }


        private void CargarObservaciones()
        {
            string conexion = "Server=localhost;Database=optica_test;Uid=root;Pwd=cagadamierda123;";

            string sql = @"SELECT molestias_actuales,
                          antecedentes_generales,
                          antecedentes_oculares,
                          notas_adicionales
                   FROM observaciones
                   WHERE cliente_id = @clienteId
                   ORDER BY fecha_registro DESC, observacion_id DESC
                   LIMIT 1";

            using (MySqlConnection conn = new MySqlConnection(conexion))
            {
                conn.Open();

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@clienteId", clienteId);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtMolestias.Text =
                                reader["molestias_actuales"].ToString();

                            txtAntecedentesGenerales.Text =
                                reader["antecedentes_generales"].ToString();

                            txtAntecedentesOculares.Text =
                                reader["antecedentes_oculares"].ToString();

                            txtNotasAdicionales.Text =
                                reader["notas_adicionales"].ToString();
                        }
                        else
                        {
                            // Si no hay observaciones, dejar los campos vacíos.
                            txtMolestias.Clear();
                            txtAntecedentesGenerales.Clear();
                            txtAntecedentesOculares.Clear();
                            txtNotasAdicionales.Clear();
                        }
                    }
                }
            }
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
