using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;


namespace opticaApp
{
    public partial class RegistroClientes : Form
    {
        private string conexion = "Server=localhost;Database=optica_test;Uid=root;Pwd=cagadamierda123;";
        private int? clienteId = null;

        public RegistroClientes()
        {
            InitializeComponent();
        }

        public RegistroClientes(int id)
        {
            InitializeComponent();
            clienteId = id;
            CargarDatosCliente();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validar campos obligatorios
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtCorreo.Text))
            {
                MessageBox.Show(
                    "Completa el nombre, apellido y correo electrónico.",
                    "Campos obligatorios",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(conexion))
                {
                    conn.Open();

                    string sql;

                    if (clienteId == null)
                    {
                        // Registrar un cliente nuevo
                        sql = @"INSERT INTO clientes
                                (nombre, apellido, fecha_nacimiento, correo, telefono)
                                VALUES
                                (@nombre, @apellido, @fecha, @correo, @telefono)";
                    }
                    else
                    {
                        // Modificar un cliente existente
                        sql = @"UPDATE clientes
                                SET nombre = @nombre,
                                apellido = @apellido,
                                fecha_nacimiento = @fecha,
                                correo = @correo,
                                telefono = @telefono
                                WHERE cliente_id = @id";
                    }

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@nombre", txtNombre.Text.Trim());
                        cmd.Parameters.AddWithValue("@apellido", txtApellido.Text.Trim());
                        cmd.Parameters.AddWithValue("@fecha", dateTimePicker1.Value.Date);
                        cmd.Parameters.AddWithValue("@correo", txtCorreo.Text.Trim());
                        cmd.Parameters.AddWithValue("@telefono", txtTelefono.Text.Trim());

                        if (clienteId != null)
                        {
                            cmd.Parameters.AddWithValue("@id", clienteId.Value);
                        }

                        cmd.ExecuteNonQuery();
                    }
                }

                string mensaje = clienteId == null
                ? "¡Cliente registrado correctamente!"
                : "¡Cliente modificado correctamente!";

                MessageBox.Show(
                     mensaje,
                     "Éxito",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Information
                        );

                // Si estamos modificando un cliente
                if (clienteId != null)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    // Si es un cliente nuevo, limpiar los campos
                    txtNombre.Clear();
                    txtApellido.Clear();
                    txtCorreo.Clear();
                    txtTelefono.Clear();
                    dateTimePicker1.Value = DateTime.Today;
                }
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1062)
                {
                    MessageBox.Show(
                        "Ese correo electrónico ya está registrado.",
                        "Correo duplicado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
                else
                {
                    MessageBox.Show(
                        "Error de MySQL: " + ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void CargarDatosCliente()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(conexion))
                {
                    conn.Open();

                    string sql = @"SELECT nombre, apellido, fecha_nacimiento,
                                  correo, telefono
                           FROM clientes
                           WHERE cliente_id = @id";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", clienteId);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtNombre.Text = reader["nombre"].ToString();
                                txtApellido.Text = reader["apellido"].ToString();
                                txtCorreo.Text = reader["correo"].ToString();
                                txtTelefono.Text = reader["telefono"].ToString();

                                if (reader["fecha_nacimiento"] != DBNull.Value)
                                {
                                    dateTimePicker1.Value =
                                        Convert.ToDateTime(reader["fecha_nacimiento"]);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el cliente: " + ex.Message);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
