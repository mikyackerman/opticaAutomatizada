namespace opticaApp
{
    partial class Observaciones
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnCancelar = new Button();
            btnGuardar = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtNotasAdicionales = new TextBox();
            txtAntecedentesOculares = new TextBox();
            txtAntecedentesGenerales = new TextBox();
            txtMolestias = new TextBox();
            panel2 = new Panel();
            label1 = new Label();
            label7 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(btnGuardar);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtNotasAdicionales);
            panel1.Controls.Add(txtAntecedentesOculares);
            panel1.Controls.Add(txtAntecedentesGenerales);
            panel1.Controls.Add(txtMolestias);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(68, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1028, 710);
            panel1.TabIndex = 0;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.White;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.Black;
            btnCancelar.Location = new Point(551, 649);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(195, 56);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(36, 81, 87);
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(804, 649);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(195, 56);
            btnGuardar.TabIndex = 10;
            btnGuardar.Text = "Guardar observaciones";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(30, 522);
            label5.Name = "label5";
            label5.Size = new Size(146, 21);
            label5.TabIndex = 9;
            label5.Text = "Notas adicionales";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(30, 396);
            label4.Name = "label4";
            label4.Size = new Size(234, 21);
            label4.TabIndex = 8;
            label4.Text = "Antecedentes de salud ocular";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(30, 267);
            label3.Name = "label3";
            label3.Size = new Size(244, 21);
            label3.TabIndex = 7;
            label3.Text = "Antecedentes de salud general";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(30, 140);
            label2.Name = "label2";
            label2.Size = new Size(294, 21);
            label2.TabIndex = 6;
            label2.Text = "Molestias oculares / visuales actuales";
            // 
            // txtNotasAdicionales
            // 
            txtNotasAdicionales.Location = new Point(30, 546);
            txtNotasAdicionales.Multiline = true;
            txtNotasAdicionales.Name = "txtNotasAdicionales";
            txtNotasAdicionales.PlaceholderText = "Comentarios relevantes para la atencion...";
            txtNotasAdicionales.Size = new Size(969, 90);
            txtNotasAdicionales.TabIndex = 5;
            // 
            // txtAntecedentesOculares
            // 
            txtAntecedentesOculares.Location = new Point(30, 420);
            txtAntecedentesOculares.Multiline = true;
            txtAntecedentesOculares.Name = "txtAntecedentesOculares";
            txtAntecedentesOculares.PlaceholderText = "Enfermedades oculares previas, cirugias, lesiones o tratamientos informados... ";
            txtAntecedentesOculares.Size = new Size(969, 90);
            txtAntecedentesOculares.TabIndex = 4;
            // 
            // txtAntecedentesGenerales
            // 
            txtAntecedentesGenerales.Location = new Point(30, 291);
            txtAntecedentesGenerales.Multiline = true;
            txtAntecedentesGenerales.Name = "txtAntecedentesGenerales";
            txtAntecedentesGenerales.PlaceholderText = "Antecedentes medicos relevantes, medicamentos y alergias que el cliente informe...";
            txtAntecedentesGenerales.Size = new Size(969, 90);
            txtAntecedentesGenerales.TabIndex = 3;
            // 
            // txtMolestias
            // 
            txtMolestias.Location = new Point(30, 167);
            txtMolestias.Multiline = true;
            txtMolestias.Name = "txtMolestias";
            txtMolestias.PlaceholderText = "Describe las molestias que refiere el cliente, desde cuando y que ojo, si corresponde...";
            txtMolestias.Size = new Size(969, 90);
            txtMolestias.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(36, 81, 87);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1028, 110);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(212, 67);
            label1.Name = "label1";
            label1.Size = new Size(460, 25);
            label1.TabIndex = 6;
            label1.Text = "Notas y antecedentes registrados durante la atencion";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(212, 21);
            label7.Name = "label7";
            label7.Size = new Size(367, 37);
            label7.TabIndex = 1;
            label7.Text = "Observaciones del Paciente";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Foto_perfil_Prisma_Vision;
            pictureBox1.Location = new Point(0, -44);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(206, 205);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Observaciones
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1161, 744);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "Observaciones";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Observaciones ";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label7;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textBox4;
        private TextBox txtAntecedentesOculares;
        private TextBox txtAntecedentesGenerales;

        private TextBox txtNotasAdicionales;

        private TextBox txtMolestias;
        private Button btnCancelar;
        private Button btnGuardar;
    }
}