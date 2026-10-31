using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace opticaApp
{
    public partial class HistorialPaciente : Form
    {
        private int clienteId;
        public HistorialPaciente(int id)
        {
            InitializeComponent();
            clienteId = id;
        }
        private Panel CrearTarjetaObservacion(
            int observacionId,
            string fecha,
            string molestias,
            string antecedentesGenerales,
            string antecedentesOculares,
            string notas)
        {
            Panel tarjeta = new Panel();

            tarjeta.Width = flpHistorialObservaciones.ClientSize.Width - 30;
            tarjeta.Height = 260;
            tarjeta.BackColor = Color.White;
            tarjeta.BorderStyle = BorderStyle.FixedSingle;
            tarjeta.Margin = new Padding(5);
            tarjeta.Padding = new Padding(15);

            tarjeta.Tag = observacionId;

            // Fecha de registro
            Label lblFecha = new Label();
            lblFecha.Text = "Fecha: " + fecha;
            lblFecha.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblFecha.Location = new Point(15, 15);
            lblFecha.AutoSize = true;
            tarjeta.Controls.Add(lblFecha);

            // Molestias actuales
            Label lblMolestias = new Label();
            lblMolestias.Text = "Molestias actuales:\n" + molestias;
            lblMolestias.Location = new Point(15, 45);
            lblMolestias.Size = new Size(500, 40);
            tarjeta.Controls.Add(lblMolestias);

            // Antecedentes generales
            Label lblGenerales = new Label();
            lblGenerales.Text = "Antecedentes generales:\n" + antecedentesGenerales;
            lblGenerales.Location = new Point(15, 90);
            lblGenerales.Size = new Size(500, 40);
            tarjeta.Controls.Add(lblGenerales);

            // Antecedentes oculares
            Label lblOculares = new Label();
            lblOculares.Text = "Antecedentes oculares:\n" + antecedentesOculares;
            lblOculares.Location = new Point(15, 135);
            lblOculares.Size = new Size(500, 40);
            tarjeta.Controls.Add(lblOculares);

            // Notas adicionales
            Label lblNotas = new Label();
            lblNotas.Text = "Notas adicionales:\n" + notas;
            lblNotas.Location = new Point(15, 180);
            lblNotas.Size = new Size(500, 50);
            tarjeta.Controls.Add(lblNotas);

            return tarjeta;
        }

        private void CargarHistorialObservaciones()
        {
            flpHistorialObservaciones.Controls.Clear();

            string consulta = @"
        SELECT observacion_id,
               fecha_registro,
               molestias_actuales,
               antecedentes_generales,
               antecedentes_oculares,
               notas_adicionales
        FROM observaciones
        WHERE cliente_id = @clienteId
        ORDER BY fecha_registro DESC, observacion_id DESC";

            using (MySqlConnection conexion = new MySqlConnection("Server=localhost;Database=optica_test;Uid=root;Pwd=;"))
            {
                conexion.Open();

                using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@clienteId", clienteId);

                    using (MySqlDataReader lector = comando.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            Panel tarjeta = CrearTarjetaObservacion(
                                Convert.ToInt32(lector["observacion_id"]),
                                Convert.ToDateTime(lector["fecha_registro"]).ToString("dd/MM/yyyy HH:mm"),
                                lector["molestias_actuales"].ToString(),
                                lector["antecedentes_generales"].ToString(),
                                lector["antecedentes_oculares"].ToString(),
                                lector["notas_adicionales"].ToString()
                            );

                            flpHistorialObservaciones.Controls.Add(tarjeta);
                        }
                    }
                }
            }
        }

        private void HistorialPaciente_Load(object sender, EventArgs e)
        {
            CargarHistorialObservaciones();
            CargarHistorialAgudezaVisual();
        }

        private void dgvHistorialObservaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CargarHistorialAgudezaVisual()
        {
            flpHistorialAgudezaVisual.Controls.Clear();

            string conexion = "Server=localhost;Database=optica_test;Uid=root;Pwd=;";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(conexion))
                {
                    conn.Open();

                    string sql = @"
                SELECT *
                FROM agudezas_visuales
                WHERE cliente_id = @clienteId
                ORDER BY fecha_examen DESC, agudeza_id DESC";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@clienteId", clienteId);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                CrearTarjetaAgudezaVisual(reader);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el historial: " + ex.Message);
            }
        }

        private void CrearTarjetaAgudezaVisual(MySqlDataReader reader)
        {
            Panel tarjeta = new Panel();

            tarjeta.Width = flpHistorialAgudezaVisual.ClientSize.Width - 70;
            tarjeta.Height = 430;
            tarjeta.BackColor = Color.White;
            tarjeta.BorderStyle = BorderStyle.FixedSingle;
            tarjeta.Margin = new Padding(5);
            tarjeta.Padding = new Padding(15);

            tarjeta.Tag = Convert.ToInt32(reader["agudeza_id"]);

            int y = 15;

            void AgregarTexto(string titulo, string contenido, bool negrita = false)
            {
                Label label = new Label();

                label.Text = titulo + contenido;
                label.Location = new Point(15, y);
                label.AutoSize = true;
                label.MaximumSize = new Size(tarjeta.Width - 40, 0);
                label.Font = new Font(
                    "Segoe UI",
                    9,
                    negrita ? FontStyle.Bold : FontStyle.Regular
                );

                tarjeta.Controls.Add(label);
                y += label.Height + 5;
            }

            string Valor(string columna)
            {
                return reader[columna] == DBNull.Value
                    ? "-"
                    : reader[columna].ToString();
            }

            AgregarTexto("FECHA: ",
                Convert.ToDateTime(reader["fecha_examen"]).ToString("dd/MM/yyyy"), true);

            y += 5;

            AgregarTexto("REFRACCIÓN (RF)", "", true);
            AgregarTexto("OD: ", $"{Valor("rf_sp_od")} / {Valor("rf_ci_od")} / {Valor("rf_eje_od")}");
            AgregarTexto("OI: ", $"{Valor("rf_sp_oi")} / {Valor("rf_ci_oi")} / {Valor("rf_eje_oi")}");

            y += 5;

            AgregarTexto("REFRACCIÓN (RX)", "", true);
            AgregarTexto("OD: ", $"{Valor("rx_sp_od")} / {Valor("rx_ci_od")} / {Valor("rx_eje_od")}");
            AgregarTexto("OI: ", $"{Valor("rx_sp_oi")} / {Valor("rx_ci_oi")} / {Valor("rx_eje_oi")}");

            y += 5;

            AgregarTexto("GRADUACION FINAL (RXF)", "", true);
            AgregarTexto("OD: ", $"{Valor("rxf_sp_od")} / {Valor("rxf_ci_od")} / {Valor("rxf_eje_od")} / {Valor("rxf_add_od")}");
            AgregarTexto("OI: ", $"{Valor("rxf_sp_oi")} / {Valor("rxf_ci_oi")} / {Valor("rxf_eje_oi")} / {Valor("rxf_add_oi")}");

            y += 5;

            AgregarTexto("DIP: ", Valor("dip"), true);

            y += 5;

            AgregarTexto("DIAGNÓSTICO: \n", Valor("diagnostico"), true);

            tarjeta.Height = y + 15;

            flpHistorialAgudezaVisual.Controls.Add(tarjeta);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
