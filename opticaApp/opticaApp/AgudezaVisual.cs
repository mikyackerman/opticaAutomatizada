using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Windows.Forms;

namespace opticaApp
{
    public partial class AgudezaVisual : Form
    {
        private int clienteId;


        public AgudezaVisual()
        {
            InitializeComponent();
        }

        public AgudezaVisual(int id) : this()
        {
            clienteId = id;
            CargarNombrePaciente();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AgudezaVisual_Load(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rfSpOi_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rfSpOd_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void diagnostico_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string conexion = "Server=localhost;Database=optica_test;Uid=root;Pwd=";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(conexion))
                {
                    conn.Open();

                    string sql = @"INSERT INTO agudezas_visuales
            (
                cliente_id,
                fecha_examen,
                rf_sp_od,
                rf_ci_od,
                rf_eje_od,
                rf_sp_oi,
                rf_ci_oi,
                rf_eje_oi,
                rx_sp_od,
                rx_ci_od,
                rx_eje_od,
                rx_sp_oi,
                rx_ci_oi,
                rx_eje_oi,
                rxf_sp_od,
                rxf_ci_od,
                rxf_eje_od,
                rxf_add_od,
                rxf_sp_oi,
                rxf_ci_oi,
                rxf_eje_oi,
                rxf_add_oi,
                dip,
                diagnostico
            )
            VALUES
            (
                @cliente_id,
                @fecha_examen,
                @rf_sp_od,
                @rf_ci_od,
                @rf_eje_od,
                @rf_sp_oi,
                @rf_ci_oi,
                @rf_eje_oi,
                @rx_sp_od,
                @rx_ci_od,
                @rx_eje_od,
                @rx_sp_oi,
                @rx_ci_oi,
                @rx_eje_oi,
                @rxf_sp_od,
                @rxf_ci_od,
                @rxf_eje_od,
                @rxf_add_od,
                @rxf_sp_oi,
                @rxf_ci_oi,
                @rxf_eje_oi,
                @rxf_add_oi,
                @dip,
                @diagnostico
            )";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@cliente_id", clienteId);
                        cmd.Parameters.AddWithValue("@fecha_examen", dtpAgudeza.Value.Date);

                        cmd.Parameters.AddWithValue("@rf_sp_od", ObtenerDecimal(rfSpOd));
                        cmd.Parameters.AddWithValue("@rf_ci_od", ObtenerDecimal(rfCiOd));
                        cmd.Parameters.AddWithValue("@rf_eje_od", ObtenerDecimal(rfEjeOd));
                        cmd.Parameters.AddWithValue("@rf_sp_oi", ObtenerDecimal(rfSpOi));
                        cmd.Parameters.AddWithValue("@rf_ci_oi", ObtenerDecimal(rfCiOi));
                        cmd.Parameters.AddWithValue("@rf_eje_oi", ObtenerDecimal(rfEjeOi));

                        cmd.Parameters.AddWithValue("@rx_sp_od", ObtenerDecimal(rxSpOd));
                        cmd.Parameters.AddWithValue("@rx_ci_od", ObtenerDecimal(rxCiOd));
                        cmd.Parameters.AddWithValue("@rx_eje_od", ObtenerDecimal(rxEjeOd));
                        cmd.Parameters.AddWithValue("@rx_sp_oi", ObtenerDecimal(rxSpOi));
                        cmd.Parameters.AddWithValue("@rx_ci_oi", ObtenerDecimal(rxCiOi));
                        cmd.Parameters.AddWithValue("@rx_eje_oi", ObtenerDecimal(rxEjeOi));

                        cmd.Parameters.AddWithValue("@rxf_sp_od", ObtenerDecimal(rfxSpOd));
                        cmd.Parameters.AddWithValue("@rxf_ci_od", ObtenerDecimal(rfxCiOd));
                        cmd.Parameters.AddWithValue("@rxf_eje_od", ObtenerDecimal(rfxEjeOd));
                        cmd.Parameters.AddWithValue("@rxf_add_od", ObtenerDecimal(rfxAddOd));
                        cmd.Parameters.AddWithValue("@rxf_sp_oi", ObtenerDecimal(rfxSpOi));
                        cmd.Parameters.AddWithValue("@rxf_ci_oi", ObtenerDecimal(rfxCiOi));
                        cmd.Parameters.AddWithValue("@rxf_eje_oi", ObtenerDecimal(rfxEjeOi));
                        cmd.Parameters.AddWithValue("@rxf_add_oi", ObtenerDecimal(rfxAddOi));

                        cmd.Parameters.AddWithValue("@dip", ObtenerDecimal(dip));
                        cmd.Parameters.AddWithValue("@diagnostico",
                            string.IsNullOrWhiteSpace(diagnostico.Text)
                            ? DBNull.Value
                            : diagnostico.Text.Trim());

                        int resultado = cmd.ExecuteNonQuery();

                        if (resultado > 0)
                        {
                            MessageBox.Show("Examen guardado correctamente.");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo guardar el examen.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el examen: " + ex.Message);
            }
        }

        private object ObtenerDecimal(TextBox campo)
        {
            if (string.IsNullOrWhiteSpace(campo.Text))
            {
                return DBNull.Value;
            }

            if (decimal.TryParse(
                campo.Text.Trim(),
                System.Globalization.NumberStyles.Number,
                System.Globalization.CultureInfo.CurrentCulture,
                out decimal valor))
            {
                return valor;
            }

            throw new Exception("El valor '" + campo.Text + "' no es un número válido.");
        }

        private void CargarNombrePaciente()
        {
            string conexion = "Server=localhost;Database=optica_test;Uid=root;Pwd=cagadamierda123;";

            using (MySqlConnection conn = new MySqlConnection(conexion))
            {
                conn.Open();

                string sql = @"SELECT nombre, apellido
                       FROM clientes
                       WHERE cliente_id = @id";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", clienteId);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            datosPaciente.Text =
                                reader["nombre"].ToString() + " " +
                                reader["apellido"].ToString();
                        }
                        else
                        {
                            datosPaciente.Text = "Paciente no encontrado";
                        }
                    }
                }
            }
        }

        private void rfxAddOd_TextChanged(object sender, EventArgs e)
        {

        }

        private void dpi_TextChanged(object sender, EventArgs e)
        {

        }

        private void rfSpOi_TextChanged(object sender, EventArgs e)
        {

        }

        private void rfCiOi_TextChanged(object sender, EventArgs e)
        {

        }

        private void datosPaciente_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
