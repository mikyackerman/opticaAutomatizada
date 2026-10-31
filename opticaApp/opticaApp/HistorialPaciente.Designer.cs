namespace opticaApp
{
    partial class HistorialPaciente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistorialPaciente));
            panel1 = new Panel();
            tabControl1 = new TabControl();
            tabObservaciones = new TabPage();
            flpHistorialObservaciones = new FlowLayoutPanel();
            label4 = new Label();
            tabAgudeza = new TabPage();
            label3 = new Label();
            tabCompras = new TabPage();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            flpHistorialAgudezaVisual = new FlowLayoutPanel();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabObservaciones.SuspendLayout();
            tabAgudeza.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(tabControl1);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(68, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1028, 710);
            panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabObservaciones);
            tabControl1.Controls.Add(tabAgudeza);
            tabControl1.Controls.Add(tabCompras);
            tabControl1.Location = new Point(32, 131);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(965, 566);
            tabControl1.TabIndex = 3;
            // 
            // tabObservaciones
            // 
            tabObservaciones.Controls.Add(flpHistorialObservaciones);
            tabObservaciones.Controls.Add(label4);
            tabObservaciones.Location = new Point(4, 24);
            tabObservaciones.Name = "tabObservaciones";
            tabObservaciones.Padding = new Padding(3);
            tabObservaciones.Size = new Size(957, 538);
            tabObservaciones.TabIndex = 0;
            tabObservaciones.Text = "Observaciones";
            tabObservaciones.UseVisualStyleBackColor = true;
            // 
            // flpHistorialObservaciones
            // 
            flpHistorialObservaciones.AutoScroll = true;
            flpHistorialObservaciones.FlowDirection = FlowDirection.TopDown;
            flpHistorialObservaciones.Location = new Point(21, 62);
            flpHistorialObservaciones.Name = "flpHistorialObservaciones";
            flpHistorialObservaciones.Padding = new Padding(10);
            flpHistorialObservaciones.Size = new Size(912, 458);
            flpHistorialObservaciones.TabIndex = 1;
            flpHistorialObservaciones.WrapContents = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 22);
            label4.Name = "label4";
            label4.Size = new Size(147, 15);
            label4.TabIndex = 0;
            label4.Text = "Historial de Observaciones";
            // 
            // tabAgudeza
            // 
            tabAgudeza.Controls.Add(flpHistorialAgudezaVisual);
            tabAgudeza.Controls.Add(label3);
            tabAgudeza.Location = new Point(4, 24);
            tabAgudeza.Name = "tabAgudeza";
            tabAgudeza.Padding = new Padding(3);
            tabAgudeza.Size = new Size(957, 538);
            tabAgudeza.TabIndex = 1;
            tabAgudeza.Text = "Agudeza Visual";
            tabAgudeza.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 36);
            label3.Name = "label3";
            label3.Size = new Size(150, 15);
            label3.TabIndex = 0;
            label3.Text = "Historial de Agudeza Visual";
            label3.Click += label3_Click;
            // 
            // tabCompras
            // 
            tabCompras.Location = new Point(4, 24);
            tabCompras.Name = "tabCompras";
            tabCompras.Size = new Size(957, 538);
            tabCompras.TabIndex = 2;
            tabCompras.Text = "Compras";
            tabCompras.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(36, 81, 87);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1028, 110);
            panel2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, -44);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(206, 205);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(202, 61);
            label2.Name = "label2";
            label2.Size = new Size(471, 25);
            label2.TabIndex = 1;
            label2.Text = "Consulta examenes, diagnosticos y compras anteriores";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(202, 13);
            label1.Name = "label1";
            label1.Size = new Size(292, 37);
            label1.TabIndex = 0;
            label1.Text = "Historial del paciente";
            // 
            // flpHistorialAgudezaVisual
            // 
            flpHistorialAgudezaVisual.AutoScroll = true;
            flpHistorialAgudezaVisual.FlowDirection = FlowDirection.TopDown;
            flpHistorialAgudezaVisual.Location = new Point(39, 69);
            flpHistorialAgudezaVisual.Name = "flpHistorialAgudezaVisual";
            flpHistorialAgudezaVisual.Padding = new Padding(10);
            flpHistorialAgudezaVisual.Size = new Size(891, 452);
            flpHistorialAgudezaVisual.TabIndex = 1;
            flpHistorialAgudezaVisual.WrapContents = false;
            // 
            // HistorialPaciente
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1161, 744);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "HistorialPaciente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Historial del paciente";
            Load += HistorialPaciente_Load;
            panel1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabObservaciones.ResumeLayout(false);
            tabObservaciones.PerformLayout();
            tabAgudeza.ResumeLayout(false);
            tabAgudeza.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabObservaciones;
        private TabPage tabPage1;
        private TabPage tabAgudeza;
        private TabPage tabCompras;
        private Label label4;
        private Label label3;
        private FlowLayoutPanel flpHistorialObservaciones;
        private FlowLayoutPanel flpHistorialAgudezaVisual;
    }
}