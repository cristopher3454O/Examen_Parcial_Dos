namespace ExamenDosRegistros
{
    partial class Form1
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
            label1 = new Label();
            cmbTaller = new ComboBox();
            label2 = new Label();
            txtResponsable = new TextBox();
            label3 = new Label();
            numCantidad = new NumericUpDown();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            lblLugaresDisponibles = new Label();
            groupBox3 = new GroupBox();
            chbMaterial = new CheckBox();
            rdbVespertino = new RadioButton();
            rdbMatutino = new RadioButton();
            label4 = new Label();
            btnReserva = new Button();
            btnCancelar = new Button();
            btnLimpiar = new Button();
            dgvDatos = new DataGridView();
            lblReservas = new Label();
            lblOcupados = new Label();
            ((System.ComponentModel.ISupportInitialize)numCantidad).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 31);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 0;
            label1.Text = "Taller";
            // 
            // cmbTaller
            // 
            cmbTaller.FormattingEnabled = true;
            cmbTaller.Location = new Point(25, 56);
            cmbTaller.Name = "cmbTaller";
            cmbTaller.Size = new Size(168, 23);
            cmbTaller.TabIndex = 1;
            cmbTaller.SelectedIndexChanged += cmbTaller_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 38);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 2;
            label2.Text = "Responsable";
            label2.Click += label2_Click;
            // 
            // txtResponsable
            // 
            txtResponsable.Location = new Point(21, 56);
            txtResponsable.Name = "txtResponsable";
            txtResponsable.Size = new Size(194, 23);
            txtResponsable.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 105);
            label3.Name = "label3";
            label3.Size = new Size(124, 15);
            label3.TabIndex = 4;
            label3.Text = "Cantidad de Lugares : ";
            // 
            // numCantidad
            // 
            numCantidad.Location = new Point(165, 105);
            numCantidad.Maximum = new decimal(new int[] { 3, 0, 0, 0 });
            numCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numCantidad.Name = "numCantidad";
            numCantidad.Size = new Size(50, 23);
            numCantidad.TabIndex = 5;
            numCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(numCantidad);
            groupBox1.Controls.Add(txtResponsable);
            groupBox1.Controls.Add(label3);
            groupBox1.ForeColor = SystemColors.ActiveCaptionText;
            groupBox1.Location = new Point(239, 29);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(253, 172);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "2.Datos de la Reserva";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblLugaresDisponibles);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(cmbTaller);
            groupBox2.Location = new Point(12, 29);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(215, 172);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "1. Selecione Taller";
            // 
            // lblLugaresDisponibles
            // 
            lblLugaresDisponibles.AutoSize = true;
            lblLugaresDisponibles.Location = new Point(26, 117);
            lblLugaresDisponibles.Name = "lblLugaresDisponibles";
            lblLugaresDisponibles.Size = new Size(38, 15);
            lblLugaresDisponibles.TabIndex = 2;
            lblLugaresDisponibles.Text = "label4";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(chbMaterial);
            groupBox3.Controls.Add(rdbVespertino);
            groupBox3.Controls.Add(rdbMatutino);
            groupBox3.Controls.Add(label4);
            groupBox3.Location = new Point(543, 32);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(291, 174);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "3. Preferncias";
            // 
            // chbMaterial
            // 
            chbMaterial.AutoSize = true;
            chbMaterial.Location = new Point(24, 124);
            chbMaterial.Name = "chbMaterial";
            chbMaterial.Size = new Size(118, 19);
            chbMaterial.TabIndex = 3;
            chbMaterial.Text = "Requiere Material";
            chbMaterial.UseVisualStyleBackColor = true;
            // 
            // rdbVespertino
            // 
            rdbVespertino.AutoSize = true;
            rdbVespertino.Location = new Point(160, 85);
            rdbVespertino.Name = "rdbVespertino";
            rdbVespertino.Size = new Size(80, 19);
            rdbVespertino.TabIndex = 2;
            rdbVespertino.Text = "Vespertino";
            rdbVespertino.UseVisualStyleBackColor = true;
            // 
            // rdbMatutino
            // 
            rdbMatutino.AutoSize = true;
            rdbMatutino.Checked = true;
            rdbMatutino.Location = new Point(24, 85);
            rdbMatutino.Name = "rdbMatutino";
            rdbMatutino.Size = new Size(74, 19);
            rdbMatutino.TabIndex = 1;
            rdbMatutino.TabStop = true;
            rdbMatutino.Text = "Matutino";
            rdbMatutino.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 37);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 0;
            label4.Text = "Turno";
            // 
            // btnReserva
            // 
            btnReserva.Location = new Point(23, 238);
            btnReserva.Name = "btnReserva";
            btnReserva.Size = new Size(188, 34);
            btnReserva.TabIndex = 9;
            btnReserva.Text = "Registrar Reserva";
            btnReserva.UseVisualStyleBackColor = true;
            btnReserva.Click += btnReserva_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(249, 238);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(188, 34);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar Selecionado";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(471, 238);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(188, 34);
            btnLimpiar.TabIndex = 11;
            btnLimpiar.Text = "LimpiarCaptura";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // dgvDatos
            // 
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Location = new Point(27, 314);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.Size = new Size(785, 104);
            dgvDatos.TabIndex = 12;
            // 
            // lblReservas
            // 
            lblReservas.AutoSize = true;
            lblReservas.Location = new Point(55, 452);
            lblReservas.Name = "lblReservas";
            lblReservas.Size = new Size(38, 15);
            lblReservas.TabIndex = 13;
            lblReservas.Text = "label5";
            // 
            // lblOcupados
            // 
            lblOcupados.AutoSize = true;
            lblOcupados.Location = new Point(551, 452);
            lblOcupados.Name = "lblOcupados";
            lblOcupados.Size = new Size(38, 15);
            lblOcupados.TabIndex = 14;
            lblOcupados.Text = "label5";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(961, 501);
            Controls.Add(lblOcupados);
            Controls.Add(lblReservas);
            Controls.Add(dgvDatos);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCancelar);
            Controls.Add(btnReserva);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numCantidad).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbTaller;
        private Label label2;
        private TextBox txtResponsable;
        private Label label3;
        private NumericUpDown numCantidad;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label lblLugaresDisponibles;
        private GroupBox groupBox3;
        private CheckBox chbMaterial;
        private RadioButton rdbVespertino;
        private RadioButton rdbMatutino;
        private Label label4;
        private Button btnReserva;
        private Button btnCancelar;
        private Button btnLimpiar;
        private DataGridView dgvDatos;
        private Label lblReservas;
        private Label lblOcupados;
    }
}
