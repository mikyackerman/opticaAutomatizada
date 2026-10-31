namespace opticaApp
{
    partial class AgudezaVisual
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
            lblNombre = new Panel();
            datosPaciente = new Label();
            dtpAgudeza = new DateTimePicker();
            btnCancelar = new Button();
            btnGuardar = new Button();
            panel7 = new Panel();
            diagnostico = new TextBox();
            label34 = new Label();
            panel6 = new Panel();
            dip = new TextBox();
            label35 = new Label();
            label33 = new Label();
            panel5 = new Panel();
            rfxAddOi = new TextBox();
            rfxEjeOi = new TextBox();
            rfxCiOi = new TextBox();
            rfxSpOi = new TextBox();
            rfxAddOd = new TextBox();
            rfxEjeOd = new TextBox();
            rfxCiOd = new TextBox();
            rfxSpOd = new TextBox();
            label29 = new Label();
            label20 = new Label();
            label30 = new Label();
            label31 = new Label();
            label15 = new Label();
            label32 = new Label();
            label19 = new Label();
            label16 = new Label();
            label18 = new Label();
            label17 = new Label();
            panel4 = new Panel();
            rxSpOd = new TextBox();
            rxEjeOi = new TextBox();
            label10 = new Label();
            rxCiOi = new TextBox();
            label14 = new Label();
            rxSpOi = new TextBox();
            label11 = new Label();
            rxEjeOd = new TextBox();
            label13 = new Label();
            rxCiOd = new TextBox();
            label12 = new Label();
            label25 = new Label();
            label28 = new Label();
            label26 = new Label();
            label27 = new Label();
            panel3 = new Panel();
            rfEjeOd = new TextBox();
            rfEjeOi = new TextBox();
            rfCiOi = new TextBox();
            rfSpOi = new TextBox();
            rfCiOd = new TextBox();
            rfSpOd = new TextBox();
            label22 = new Label();
            label21 = new Label();
            label9 = new Label();
            label8 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            label7 = new Label();
            pictureBox1 = new PictureBox();
            lblNombre.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.BorderStyle = BorderStyle.FixedSingle;
            lblNombre.Controls.Add(datosPaciente);
            lblNombre.Controls.Add(dtpAgudeza);
            lblNombre.Controls.Add(btnCancelar);
            lblNombre.Controls.Add(btnGuardar);
            lblNombre.Controls.Add(panel7);
            lblNombre.Controls.Add(panel6);
            lblNombre.Controls.Add(panel5);
            lblNombre.Controls.Add(panel4);
            lblNombre.Controls.Add(panel3);
            lblNombre.Controls.Add(label3);
            lblNombre.Controls.Add(label1);
            lblNombre.Location = new Point(68, 12);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(1028, 710);
            lblNombre.TabIndex = 0;
            lblNombre.Paint += panel1_Paint;
            // 
            // datosPaciente
            // 
            datosPaciente.AutoSize = true;
            datosPaciente.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            datosPaciente.Location = new Point(110, 119);
            datosPaciente.Name = "datosPaciente";
            datosPaciente.Size = new Size(0, 21);
            datosPaciente.TabIndex = 9;
            datosPaciente.Click += datosPaciente_Click;
            // 
            // dtpAgudeza
            // 
            dtpAgudeza.Location = new Point(791, 116);
            dtpAgudeza.Name = "dtpAgudeza";
            dtpAgudeza.Size = new Size(211, 23);
            dtpAgudeza.TabIndex = 8;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(699, 653);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(119, 44);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(36, 81, 87);
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(883, 653);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(119, 44);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // panel7
            // 
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(diagnostico);
            panel7.Controls.Add(label34);
            panel7.Location = new Point(364, 540);
            panel7.Name = "panel7";
            panel7.Size = new Size(638, 107);
            panel7.TabIndex = 5;
            // 
            // diagnostico
            // 
            diagnostico.Location = new Point(12, 33);
            diagnostico.Multiline = true;
            diagnostico.Name = "diagnostico";
            diagnostico.Size = new Size(610, 68);
            diagnostico.TabIndex = 42;
            diagnostico.TextChanged += diagnostico_TextChanged;
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label34.Location = new Point(12, 9);
            label34.Name = "label34";
            label34.Size = new Size(119, 21);
            label34.TabIndex = 11;
            label34.Text = "5. Diagnostico";
            // 
            // panel6
            // 
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(dip);
            panel6.Controls.Add(label35);
            panel6.Controls.Add(label33);
            panel6.Location = new Point(24, 539);
            panel6.Name = "panel6";
            panel6.Size = new Size(324, 108);
            panel6.TabIndex = 4;
            panel6.Paint += panel6_Paint;
            // 
            // dip
            // 
            dip.Location = new Point(15, 57);
            dip.Name = "dip";
            dip.Size = new Size(287, 23);
            dip.TabIndex = 41;
            dip.TextChanged += dpi_TextChanged;
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.Location = new Point(12, 34);
            label35.Name = "label35";
            label35.Size = new Size(119, 15);
            label35.TabIndex = 21;
            label35.Text = "Distancia interpupilar";
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label33.Location = new Point(12, 10);
            label33.Name = "label33";
            label33.Size = new Size(54, 21);
            label33.TabIndex = 29;
            label33.Text = "4. DIP";
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(rfxAddOi);
            panel5.Controls.Add(rfxEjeOi);
            panel5.Controls.Add(rfxCiOi);
            panel5.Controls.Add(rfxSpOi);
            panel5.Controls.Add(rfxAddOd);
            panel5.Controls.Add(rfxEjeOd);
            panel5.Controls.Add(rfxCiOd);
            panel5.Controls.Add(rfxSpOd);
            panel5.Controls.Add(label29);
            panel5.Controls.Add(label20);
            panel5.Controls.Add(label30);
            panel5.Controls.Add(label31);
            panel5.Controls.Add(label15);
            panel5.Controls.Add(label32);
            panel5.Controls.Add(label19);
            panel5.Controls.Add(label16);
            panel5.Controls.Add(label18);
            panel5.Controls.Add(label17);
            panel5.Location = new Point(24, 407);
            panel5.Name = "panel5";
            panel5.Size = new Size(978, 126);
            panel5.TabIndex = 3;
            panel5.Paint += panel5_Paint;
            // 
            // rfxAddOi
            // 
            rfxAddOi.Location = new Point(775, 89);
            rfxAddOi.Name = "rfxAddOi";
            rfxAddOi.Size = new Size(178, 23);
            rfxAddOi.TabIndex = 40;
            // 
            // rfxEjeOi
            // 
            rfxEjeOi.Location = new Point(583, 89);
            rfxEjeOi.Name = "rfxEjeOi";
            rfxEjeOi.Size = new Size(174, 23);
            rfxEjeOi.TabIndex = 39;
            // 
            // rfxCiOi
            // 
            rfxCiOi.Location = new Point(389, 89);
            rfxCiOi.Name = "rfxCiOi";
            rfxCiOi.Size = new Size(178, 23);
            rfxCiOi.TabIndex = 38;
            // 
            // rfxSpOi
            // 
            rfxSpOi.Location = new Point(197, 89);
            rfxSpOi.Name = "rfxSpOi";
            rfxSpOi.Size = new Size(174, 23);
            rfxSpOi.TabIndex = 37;
            // 
            // rfxAddOd
            // 
            rfxAddOd.Location = new Point(775, 59);
            rfxAddOd.Name = "rfxAddOd";
            rfxAddOd.Size = new Size(178, 23);
            rfxAddOd.TabIndex = 36;
            rfxAddOd.TextChanged += rfxAddOd_TextChanged;
            // 
            // rfxEjeOd
            // 
            rfxEjeOd.Location = new Point(583, 59);
            rfxEjeOd.Name = "rfxEjeOd";
            rfxEjeOd.Size = new Size(174, 23);
            rfxEjeOd.TabIndex = 35;
            // 
            // rfxCiOd
            // 
            rfxCiOd.Location = new Point(389, 59);
            rfxCiOd.Name = "rfxCiOd";
            rfxCiOd.Size = new Size(178, 23);
            rfxCiOd.TabIndex = 34;
            // 
            // rfxSpOd
            // 
            rfxSpOd.Location = new Point(197, 59);
            rfxSpOd.Name = "rfxSpOd";
            rfxSpOd.Size = new Size(174, 23);
            rfxSpOd.TabIndex = 33;
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Location = new Point(53, 92);
            label29.Name = "label29";
            label29.Size = new Size(86, 15);
            label29.TabIndex = 28;
            label29.Text = "(Ojo Izquierdo)";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label20.Location = new Point(775, 36);
            label20.Name = "label20";
            label20.Size = new Size(35, 16);
            label20.TabIndex = 15;
            label20.Text = "Add";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label30.Location = new Point(27, 66);
            label30.Name = "label30";
            label30.Size = new Size(25, 15);
            label30.TabIndex = 25;
            label30.Text = "OD";
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Location = new Point(53, 66);
            label31.Name = "label31";
            label31.Size = new Size(81, 15);
            label31.TabIndex = 27;
            label31.Text = "(Ojo Derecho)";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label15.Location = new Point(583, 36);
            label15.Name = "label15";
            label15.Size = new Size(30, 16);
            label15.TabIndex = 14;
            label15.Text = "Eje";
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label32.Location = new Point(27, 92);
            label32.Name = "label32";
            label32.Size = new Size(20, 15);
            label32.TabIndex = 26;
            label32.Text = "OI";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.Location = new Point(12, 11);
            label19.Name = "label19";
            label19.Size = new Size(88, 21);
            label19.TabIndex = 10;
            label19.Text = "3. RX Final";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label16.Location = new Point(389, 36);
            label16.Name = "label16";
            label16.Size = new Size(60, 16);
            label16.TabIndex = 13;
            label16.Text = "Cilindro";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label18.Location = new Point(12, 36);
            label18.Name = "label18";
            label18.Size = new Size(31, 16);
            label18.TabIndex = 11;
            label18.Text = "Ojo";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label17.Location = new Point(197, 36);
            label17.Name = "label17";
            label17.Size = new Size(52, 16);
            label17.TabIndex = 12;
            label17.Text = "Esfera";
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(rxSpOd);
            panel4.Controls.Add(rxEjeOi);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(rxCiOi);
            panel4.Controls.Add(label14);
            panel4.Controls.Add(rxSpOi);
            panel4.Controls.Add(label11);
            panel4.Controls.Add(rxEjeOd);
            panel4.Controls.Add(label13);
            panel4.Controls.Add(rxCiOd);
            panel4.Controls.Add(label12);
            panel4.Controls.Add(label25);
            panel4.Controls.Add(label28);
            panel4.Controls.Add(label26);
            panel4.Controls.Add(label27);
            panel4.Location = new Point(24, 275);
            panel4.Name = "panel4";
            panel4.Size = new Size(978, 126);
            panel4.TabIndex = 2;
            // 
            // rxSpOd
            // 
            rxSpOd.Location = new Point(250, 54);
            rxSpOd.Name = "rxSpOd";
            rxSpOd.Size = new Size(215, 23);
            rxSpOd.TabIndex = 27;
            // 
            // rxEjeOi
            // 
            rxEjeOi.Location = new Point(712, 87);
            rxEjeOi.Name = "rxEjeOi";
            rxEjeOi.Size = new Size(215, 23);
            rxEjeOi.TabIndex = 32;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label10.Location = new Point(716, 35);
            label10.Name = "label10";
            label10.Size = new Size(30, 16);
            label10.TabIndex = 9;
            label10.Text = "Eje";
            // 
            // rxCiOi
            // 
            rxCiOi.Location = new Point(482, 86);
            rxCiOi.Name = "rxCiOi";
            rxCiOi.Size = new Size(215, 23);
            rxCiOi.TabIndex = 31;
            rxCiOi.TextChanged += textBox7_TextChanged_1;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(12, 10);
            label14.Name = "label14";
            label14.Size = new Size(123, 21);
            label14.TabIndex = 5;
            label14.Text = "2. RX Subjetiva";
            // 
            // rxSpOi
            // 
            rxSpOi.Location = new Point(250, 86);
            rxSpOi.Name = "rxSpOi";
            rxSpOi.Size = new Size(215, 23);
            rxSpOi.TabIndex = 30;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label11.Location = new Point(482, 35);
            label11.Name = "label11";
            label11.Size = new Size(60, 16);
            label11.TabIndex = 8;
            label11.Text = "Cilindro";
            // 
            // rxEjeOd
            // 
            rxEjeOd.Location = new Point(712, 55);
            rxEjeOd.Name = "rxEjeOd";
            rxEjeOd.Size = new Size(215, 23);
            rxEjeOd.TabIndex = 29;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label13.Location = new Point(12, 35);
            label13.Name = "label13";
            label13.Size = new Size(31, 16);
            label13.TabIndex = 6;
            label13.Text = "Ojo";
            // 
            // rxCiOd
            // 
            rxCiOd.Location = new Point(482, 54);
            rxCiOd.Name = "rxCiOd";
            rxCiOd.Size = new Size(215, 23);
            rxCiOd.TabIndex = 28;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label12.Location = new Point(250, 35);
            label12.Name = "label12";
            label12.Size = new Size(52, 16);
            label12.TabIndex = 7;
            label12.Text = "Esfera";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(53, 88);
            label25.Name = "label25";
            label25.Size = new Size(86, 15);
            label25.TabIndex = 18;
            label25.Text = "(Ojo Izquierdo)";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label28.Location = new Point(27, 62);
            label28.Name = "label28";
            label28.Size = new Size(25, 15);
            label28.TabIndex = 15;
            label28.Text = "OD";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(53, 62);
            label26.Name = "label26";
            label26.Size = new Size(81, 15);
            label26.TabIndex = 17;
            label26.Text = "(Ojo Derecho)";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label27.Location = new Point(27, 88);
            label27.Name = "label27";
            label27.Size = new Size(20, 15);
            label27.TabIndex = 16;
            label27.Text = "OI";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(rfEjeOd);
            panel3.Controls.Add(rfEjeOi);
            panel3.Controls.Add(rfCiOi);
            panel3.Controls.Add(rfSpOi);
            panel3.Controls.Add(rfCiOd);
            panel3.Controls.Add(rfSpOd);
            panel3.Controls.Add(label22);
            panel3.Controls.Add(label21);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(24, 143);
            panel3.Name = "panel3";
            panel3.Size = new Size(978, 126);
            panel3.TabIndex = 1;
            panel3.Paint += panel3_Paint;
            // 
            // rfEjeOd
            // 
            rfEjeOd.Location = new Point(712, 54);
            rfEjeOd.Name = "rfEjeOd";
            rfEjeOd.Size = new Size(215, 23);
            rfEjeOd.TabIndex = 23;
            // 
            // rfEjeOi
            // 
            rfEjeOi.Location = new Point(712, 86);
            rfEjeOi.Name = "rfEjeOi";
            rfEjeOi.Size = new Size(215, 23);
            rfEjeOi.TabIndex = 26;
            // 
            // rfCiOi
            // 
            rfCiOi.Location = new Point(482, 85);
            rfCiOi.Name = "rfCiOi";
            rfCiOi.Size = new Size(215, 23);
            rfCiOi.TabIndex = 25;
            rfCiOi.TextChanged += rfCiOi_TextChanged;
            // 
            // rfSpOi
            // 
            rfSpOi.Location = new Point(250, 85);
            rfSpOi.Name = "rfSpOi";
            rfSpOi.Size = new Size(215, 23);
            rfSpOi.TabIndex = 24;
            rfSpOi.TextChanged += rfSpOi_TextChanged;
            // 
            // rfCiOd
            // 
            rfCiOd.Location = new Point(482, 53);
            rfCiOd.Name = "rfCiOd";
            rfCiOd.Size = new Size(215, 23);
            rfCiOd.TabIndex = 22;
            // 
            // rfSpOd
            // 
            rfSpOd.Location = new Point(250, 53);
            rfSpOd.Name = "rfSpOd";
            rfSpOd.Size = new Size(215, 23);
            rfSpOd.TabIndex = 21;
            rfSpOd.TextChanged += rfSpOd_TextChanged;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label22.Location = new Point(27, 88);
            label22.Name = "label22";
            label22.Size = new Size(20, 15);
            label22.TabIndex = 6;
            label22.Text = "OI";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label21.Location = new Point(27, 62);
            label21.Name = "label21";
            label21.Size = new Size(25, 15);
            label21.TabIndex = 5;
            label21.Text = "OD";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label9.Location = new Point(712, 35);
            label9.Name = "label9";
            label9.Size = new Size(30, 16);
            label9.TabIndex = 4;
            label9.Text = "Eje";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label8.Location = new Point(482, 34);
            label8.Name = "label8";
            label8.Size = new Size(60, 16);
            label8.TabIndex = 3;
            label8.Text = "Cilindro";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label6.Location = new Point(250, 34);
            label6.Name = "label6";
            label6.Size = new Size(52, 16);
            label6.TabIndex = 2;
            label6.Text = "Esfera";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label5.Location = new Point(12, 34);
            label5.Name = "label5";
            label5.Size = new Size(31, 16);
            label5.TabIndex = 1;
            label5.Text = "Ojo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 9);
            label4.Name = "label4";
            label4.Size = new Size(108, 21);
            label4.TabIndex = 0;
            label4.Text = "1. Refraccion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(639, 118);
            label3.Name = "label3";
            label3.Size = new Size(146, 21);
            label3.TabIndex = 1;
            label3.Text = "Fecha de examen:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(24, 119);
            label1.Name = "label1";
            label1.Size = new Size(80, 21);
            label1.TabIndex = 0;
            label1.Text = "Paciente:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(36, 81, 87);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(68, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(1028, 110);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(212, 67);
            label2.Name = "label2";
            label2.Size = new Size(492, 25);
            label2.TabIndex = 2;
            label2.Text = "Registro de la graduacion optica y resultados del examen";
            label2.Click += label2_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(212, 19);
            label7.Name = "label7";
            label7.Size = new Size(327, 37);
            label7.TabIndex = 1;
            label7.Text = "Graduacion del Paciente";
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
            // AgudezaVisual
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1161, 744);
            Controls.Add(panel2);
            Controls.Add(lblNombre);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AgudezaVisual";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agudeza Visual";
            Load += AgudezaVisual_Load;
            lblNombre.ResumeLayout(false);
            lblNombre.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel lblNombre;
        private Panel panel2;
        private Label label7;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private Label label3;
        private Button btnCancelar;
        private Button btnGuardar;
        private Panel panel7;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private Label label9;
        private Label label8;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label20;
        private Label label15;
        private Label label19;
        private Label label16;
        private Label label18;
        private Label label17;
        private Label label10;
        private Label label14;
        private Label label11;
        private Label label13;
        private Label label12;
        private Label label22;
        private Label label21;
        private Label label29;
        private Label label30;
        private Label label31;
        private Label label32;
        private Label label25;
        private Label label28;
        private Label label26;
        private Label label27;
        private Label label34;
        private Label label35;
        private Label label33;
        private DateTimePicker dtpAgudeza;
        private TextBox diagnostico;
        private TextBox dip;
        private TextBox rfxAddOi;
        private TextBox rfxEjeOi;
        private TextBox rfxCiOi;
        private TextBox rfxSpOi;
        private TextBox rfxAddOd;
        private TextBox rfxEjeOd;
        private TextBox rfxCiOd;
        private TextBox rfxSpOd;
        private TextBox rxEjeOi;
        private TextBox rxCiOi;
        private TextBox rxSpOi;
        private TextBox rxEjeOd;
        private TextBox rxSpOd;
        private TextBox rxCiOd;
        private TextBox rfEjeOi;
        private TextBox rfCiOi;
        private TextBox rfSpOi;
        private TextBox rfSpOd;
        private TextBox rfCiOd;
        private TextBox rfEjeOd;
        private Label datosPaciente;
    }
}