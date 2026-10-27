namespace opticaApp
{
    partial class RegistroClientes
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnGuardar = new Button();
            txtCorreo = new TextBox();
            txtTelefono = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnGuardar);
            panel1.Controls.Add(txtCorreo);
            panel1.Controls.Add(txtTelefono);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(txtApellido);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(79, 189);
            panel1.Name = "panel1";
            panel1.Size = new Size(927, 459);
            panel1.TabIndex = 0;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(36, 99, 211);
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(661, 389);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(142, 42);
            btnGuardar.TabIndex = 10;
            btnGuardar.Text = "Guardar Cliente";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(88, 360);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(715, 23);
            txtCorreo.TabIndex = 9;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(519, 252);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(269, 23);
            txtTelefono.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(83, 249);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 7;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(519, 95);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(269, 23);
            txtApellido.TabIndex = 6;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(75, 95);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(279, 23);
            txtNombre.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(88, 324);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 4;
            label5.Text = "Correo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(557, 210);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 3;
            label4.Text = "Telefono";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(79, 203);
            label3.Name = "label3";
            label3.Size = new Size(117, 15);
            label3.TabIndex = 2;
            label3.Text = "Fecha de nacimiento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(568, 52);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Apellido";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 53);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(32, 78, 128);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Location = new Point(79, 92);
            panel2.Name = "panel2";
            panel2.Size = new Size(927, 100);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // RegistroClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1115, 703);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "RegistroClientes";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtCorreo;
        private TextBox txtTelefono;
        private DateTimePicker dateTimePicker1;
        private Button btnGuardar;
    }
}
