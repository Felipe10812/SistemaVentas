namespace SVPresentacion.Formularios
{
    partial class frmNegocio
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
            label1 = new Label();
            lbCategoria = new Label();
            txbRazonSocial = new TextBox();
            lbNombre = new Label();
            txbRFC = new TextBox();
            RFC = new Label();
            label3 = new Label();
            label4 = new Label();
            txbSimboloMoneda = new TextBox();
            label6 = new Label();
            txbDireccion = new TextBox();
            label7 = new Label();
            txbCelular = new TextBox();
            txbCorreo = new TextBox();
            txbRutaImagen = new TextBox();
            label10 = new Label();
            btnBuscar = new Button();
            pbLogo = new PictureBox();
            btnGuardar = new Button();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Location = new Point(12, 61);
            label1.Name = "label1";
            label1.Size = new Size(849, 473);
            label1.TabIndex = 0;
            // 
            // lbCategoria
            // 
            lbCategoria.AutoSize = true;
            lbCategoria.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbCategoria.ForeColor = SystemColors.InactiveBorder;
            lbCategoria.Location = new Point(12, 9);
            lbCategoria.Name = "lbCategoria";
            lbCategoria.Size = new Size(145, 28);
            lbCategoria.TabIndex = 2;
            lbCategoria.Text = "Configuración";
            // 
            // txbRazonSocial
            // 
            txbRazonSocial.BackColor = Color.White;
            txbRazonSocial.Location = new Point(170, 83);
            txbRazonSocial.Margin = new Padding(3, 4, 3, 4);
            txbRazonSocial.Name = "txbRazonSocial";
            txbRazonSocial.Size = new Size(181, 27);
            txbRazonSocial.TabIndex = 4;
            // 
            // lbNombre
            // 
            lbNombre.AutoSize = true;
            lbNombre.BackColor = Color.White;
            lbNombre.Location = new Point(69, 87);
            lbNombre.Name = "lbNombre";
            lbNombre.Size = new Size(97, 20);
            lbNombre.TabIndex = 3;
            lbNombre.Text = "Razón Social:";
            // 
            // txbRFC
            // 
            txbRFC.BackColor = Color.White;
            txbRFC.Location = new Point(170, 141);
            txbRFC.Margin = new Padding(3, 4, 3, 4);
            txbRFC.Name = "txbRFC";
            txbRFC.Size = new Size(181, 27);
            txbRFC.TabIndex = 6;
            // 
            // RFC
            // 
            RFC.AutoSize = true;
            RFC.BackColor = Color.White;
            RFC.Location = new Point(69, 145);
            RFC.Name = "RFC";
            RFC.Size = new Size(37, 20);
            RFC.TabIndex = 5;
            RFC.Text = "RFC:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Location = new Point(69, 199);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 7;
            label3.Text = "Dirección:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Location = new Point(69, 309);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 11;
            label4.Text = "Correo:";
            // 
            // txbSimboloMoneda
            // 
            txbSimboloMoneda.BackColor = Color.White;
            txbSimboloMoneda.Location = new Point(581, 80);
            txbSimboloMoneda.Margin = new Padding(3, 4, 3, 4);
            txbSimboloMoneda.Name = "txbSimboloMoneda";
            txbSimboloMoneda.Size = new Size(181, 27);
            txbSimboloMoneda.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Location = new Point(447, 87);
            label6.Name = "label6";
            label6.Size = new Size(127, 20);
            label6.TabIndex = 13;
            label6.Text = "Simbolo Moneda:";
            // 
            // txbDireccion
            // 
            txbDireccion.BackColor = Color.White;
            txbDireccion.Location = new Point(170, 199);
            txbDireccion.Margin = new Padding(3, 4, 3, 4);
            txbDireccion.Name = "txbDireccion";
            txbDireccion.Size = new Size(181, 27);
            txbDireccion.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Location = new Point(69, 259);
            label7.Name = "label7";
            label7.Size = new Size(58, 20);
            label7.TabIndex = 9;
            label7.Text = "Celular:";
            // 
            // txbCelular
            // 
            txbCelular.BackColor = Color.White;
            txbCelular.Location = new Point(170, 255);
            txbCelular.Margin = new Padding(3, 4, 3, 4);
            txbCelular.Name = "txbCelular";
            txbCelular.Size = new Size(181, 27);
            txbCelular.TabIndex = 10;
            // 
            // txbCorreo
            // 
            txbCorreo.BackColor = Color.White;
            txbCorreo.Location = new Point(170, 309);
            txbCorreo.Margin = new Padding(3, 4, 3, 4);
            txbCorreo.Name = "txbCorreo";
            txbCorreo.Size = new Size(181, 27);
            txbCorreo.TabIndex = 12;
            // 
            // txbRutaImagen
            // 
            txbRutaImagen.BackColor = Color.White;
            txbRutaImagen.Location = new Point(581, 138);
            txbRutaImagen.Margin = new Padding(3, 4, 3, 4);
            txbRutaImagen.Name = "txbRutaImagen";
            txbRutaImagen.ReadOnly = true;
            txbRutaImagen.Size = new Size(112, 27);
            txbRutaImagen.TabIndex = 15;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.White;
            label10.Location = new Point(447, 145);
            label10.Name = "label10";
            label10.Size = new Size(46, 20);
            label10.TabIndex = 19;
            label10.Text = "Logo:";
            // 
            // btnBuscar
            // 
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Location = new Point(699, 134);
            btnBuscar.Margin = new Padding(3, 4, 3, 4);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(63, 31);
            btnBuscar.TabIndex = 23;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // pbLogo
            // 
            pbLogo.Location = new Point(447, 199);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(315, 137);
            pbLogo.TabIndex = 24;
            pbLogo.TabStop = false;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.White;
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.ForeColor = Color.FromArgb(30, 90, 195);
            btnGuardar.Location = new Point(699, 463);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(86, 31);
            btnGuardar.TabIndex = 25;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // frmNegocio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(873, 543);
            Controls.Add(btnGuardar);
            Controls.Add(pbLogo);
            Controls.Add(btnBuscar);
            Controls.Add(label10);
            Controls.Add(txbRutaImagen);
            Controls.Add(txbSimboloMoneda);
            Controls.Add(label6);
            Controls.Add(txbCorreo);
            Controls.Add(txbCelular);
            Controls.Add(label4);
            Controls.Add(label7);
            Controls.Add(txbDireccion);
            Controls.Add(label3);
            Controls.Add(txbRFC);
            Controls.Add(RFC);
            Controls.Add(txbRazonSocial);
            Controls.Add(lbNombre);
            Controls.Add(lbCategoria);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmNegocio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmNegocio";
            Load += frmNegocio_Load;
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lbCategoria;
        private TextBox txbRazonSocial;
        private Label lbNombre;
        private TextBox txbRFC;
        private Label RFC;
        private Label label3;
        private Label label4;
        private TextBox txbSimboloMoneda;
        private Label label6;
        private TextBox txbDireccion;
        private Label label7;
        private TextBox txbCelular;
        private TextBox txbCorreo;
        private TextBox txbRutaImagen;
        private Label label10;
        private Button btnBuscar;
        private PictureBox pbLogo;
        private Button btnGuardar;
    }
}