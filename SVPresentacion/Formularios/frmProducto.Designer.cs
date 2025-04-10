namespace SVPresentacion.Formularios
{
    partial class frmProducto
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
            lbProducto = new Label();
            tabEditar = new TabPage();
            cbbHabilitadoEditar = new ComboBox();
            label8 = new Label();
            txbCantidadEditar = new NumericUpDown();
            txbPrecioVentaEditar = new TextBox();
            label2 = new Label();
            txbPrecioCompraEditar = new TextBox();
            label3 = new Label();
            txbDescripcionEditar = new TextBox();
            label4 = new Label();
            label5 = new Label();
            cbbCategoriaEditar = new ComboBox();
            label6 = new Label();
            txbCodigoEditar = new TextBox();
            label7 = new Label();
            btnGuardarEditar = new Button();
            btnVolverEditar = new Button();
            tabNuevo = new TabPage();
            txbCantidadNuevo = new NumericUpDown();
            txbPrecioVentaNuevo = new TextBox();
            txbPrecioCompraNuevo = new TextBox();
            txbDescripcionNuevo = new TextBox();
            txbCodigoNuevo = new TextBox();
            lbPrecioVentaNuevo = new Label();
            lbPrecioCompraNuevo = new Label();
            lbDescripcionNuevo = new Label();
            label1 = new Label();
            btnGuardarNuevo = new Button();
            VolverNuevo = new Button();
            cbbCategoriaNuevo = new ComboBox();
            lbMedida = new Label();
            lbCodigo = new Label();
            tabLista = new TabPage();
            dgvProductos = new DataGridView();
            btnBuscar = new Button();
            txtBuscar = new TextBox();
            btnNuevoLista = new Button();
            tabControlMain = new TabControl();
            tabEditar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txbCantidadEditar).BeginInit();
            tabNuevo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txbCantidadNuevo).BeginInit();
            tabLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            tabControlMain.SuspendLayout();
            SuspendLayout();
            // 
            // lbProducto
            // 
            lbProducto.AutoSize = true;
            lbProducto.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbProducto.ForeColor = SystemColors.InactiveBorder;
            lbProducto.Location = new Point(16, 9);
            lbProducto.Name = "lbProducto";
            lbProducto.Size = new Size(174, 21);
            lbProducto.TabIndex = 3;
            lbProducto.Text = "Inventario / Producto";
            // 
            // tabEditar
            // 
            tabEditar.Controls.Add(cbbHabilitadoEditar);
            tabEditar.Controls.Add(label8);
            tabEditar.Controls.Add(txbCantidadEditar);
            tabEditar.Controls.Add(txbPrecioVentaEditar);
            tabEditar.Controls.Add(label2);
            tabEditar.Controls.Add(txbPrecioCompraEditar);
            tabEditar.Controls.Add(label3);
            tabEditar.Controls.Add(txbDescripcionEditar);
            tabEditar.Controls.Add(label4);
            tabEditar.Controls.Add(label5);
            tabEditar.Controls.Add(cbbCategoriaEditar);
            tabEditar.Controls.Add(label6);
            tabEditar.Controls.Add(txbCodigoEditar);
            tabEditar.Controls.Add(label7);
            tabEditar.Controls.Add(btnGuardarEditar);
            tabEditar.Controls.Add(btnVolverEditar);
            tabEditar.Location = new Point(4, 24);
            tabEditar.Name = "tabEditar";
            tabEditar.Padding = new Padding(3);
            tabEditar.Size = new Size(732, 316);
            tabEditar.TabIndex = 2;
            tabEditar.Text = "Editar";
            tabEditar.UseVisualStyleBackColor = true;
            // 
            // cbbHabilitadoEditar
            // 
            cbbHabilitadoEditar.Cursor = Cursors.Hand;
            cbbHabilitadoEditar.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbHabilitadoEditar.FormattingEnabled = true;
            cbbHabilitadoEditar.Location = new Point(491, 196);
            cbbHabilitadoEditar.Name = "cbbHabilitadoEditar";
            cbbHabilitadoEditar.Size = new Size(159, 23);
            cbbHabilitadoEditar.TabIndex = 29;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(407, 204);
            label8.Name = "label8";
            label8.Size = new Size(65, 15);
            label8.TabIndex = 28;
            label8.Text = "Habilitado:";
            // 
            // txbCantidadEditar
            // 
            txbCantidadEditar.Location = new Point(491, 151);
            txbCantidadEditar.Name = "txbCantidadEditar";
            txbCantidadEditar.Size = new Size(159, 23);
            txbCantidadEditar.TabIndex = 27;
            // 
            // txbPrecioVentaEditar
            // 
            txbPrecioVentaEditar.Location = new Point(491, 105);
            txbPrecioVentaEditar.Name = "txbPrecioVentaEditar";
            txbPrecioVentaEditar.Size = new Size(159, 23);
            txbPrecioVentaEditar.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(397, 108);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 25;
            label2.Text = "Precio Venta:";
            // 
            // txbPrecioCompraEditar
            // 
            txbPrecioCompraEditar.Location = new Point(491, 57);
            txbPrecioCompraEditar.Name = "txbPrecioCompraEditar";
            txbPrecioCompraEditar.Size = new Size(159, 23);
            txbPrecioCompraEditar.TabIndex = 24;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(383, 63);
            label3.Name = "label3";
            label3.Size = new Size(89, 15);
            label3.TabIndex = 23;
            label3.Text = "Precio Compra:";
            // 
            // txbDescripcionEditar
            // 
            txbDescripcionEditar.Location = new Point(136, 150);
            txbDescripcionEditar.Name = "txbDescripcionEditar";
            txbDescripcionEditar.Size = new Size(159, 23);
            txbDescripcionEditar.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 158);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 21;
            label4.Text = "Descripcion:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(421, 156);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 20;
            label5.Text = "Cantidad:";
            // 
            // cbbCategoriaEditar
            // 
            cbbCategoriaEditar.Cursor = Cursors.Hand;
            cbbCategoriaEditar.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbCategoriaEditar.FormattingEnabled = true;
            cbbCategoriaEditar.Location = new Point(136, 57);
            cbbCategoriaEditar.Name = "cbbCategoriaEditar";
            cbbCategoriaEditar.Size = new Size(159, 23);
            cbbCategoriaEditar.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(42, 63);
            label6.Name = "label6";
            label6.Size = new Size(64, 15);
            label6.TabIndex = 18;
            label6.Text = "Categoria: ";
            // 
            // txbCodigoEditar
            // 
            txbCodigoEditar.Location = new Point(136, 105);
            txbCodigoEditar.Name = "txbCodigoEditar";
            txbCodigoEditar.Size = new Size(159, 23);
            txbCodigoEditar.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(42, 113);
            label7.Name = "label7";
            label7.Size = new Size(49, 15);
            label7.TabIndex = 16;
            label7.Text = "Codigo:";
            // 
            // btnGuardarEditar
            // 
            btnGuardarEditar.Cursor = Cursors.Hand;
            btnGuardarEditar.FlatStyle = FlatStyle.Flat;
            btnGuardarEditar.ForeColor = Color.FromArgb(30, 90, 195);
            btnGuardarEditar.Location = new Point(647, 280);
            btnGuardarEditar.Name = "btnGuardarEditar";
            btnGuardarEditar.Size = new Size(75, 23);
            btnGuardarEditar.TabIndex = 15;
            btnGuardarEditar.Text = "Guardar";
            btnGuardarEditar.UseVisualStyleBackColor = true;
            btnGuardarEditar.Click += btnGuardarEditar_Click;
            // 
            // btnVolverEditar
            // 
            btnVolverEditar.Cursor = Cursors.Hand;
            btnVolverEditar.FlatStyle = FlatStyle.Flat;
            btnVolverEditar.Location = new Point(16, 280);
            btnVolverEditar.Name = "btnVolverEditar";
            btnVolverEditar.Size = new Size(75, 23);
            btnVolverEditar.TabIndex = 14;
            btnVolverEditar.Text = "Volver";
            btnVolverEditar.UseVisualStyleBackColor = true;
            btnVolverEditar.Click += btnVolverEditar_Click;
            // 
            // tabNuevo
            // 
            tabNuevo.Controls.Add(txbCantidadNuevo);
            tabNuevo.Controls.Add(txbPrecioVentaNuevo);
            tabNuevo.Controls.Add(txbPrecioCompraNuevo);
            tabNuevo.Controls.Add(txbDescripcionNuevo);
            tabNuevo.Controls.Add(txbCodigoNuevo);
            tabNuevo.Controls.Add(lbPrecioVentaNuevo);
            tabNuevo.Controls.Add(lbPrecioCompraNuevo);
            tabNuevo.Controls.Add(lbDescripcionNuevo);
            tabNuevo.Controls.Add(label1);
            tabNuevo.Controls.Add(btnGuardarNuevo);
            tabNuevo.Controls.Add(VolverNuevo);
            tabNuevo.Controls.Add(cbbCategoriaNuevo);
            tabNuevo.Controls.Add(lbMedida);
            tabNuevo.Controls.Add(lbCodigo);
            tabNuevo.Location = new Point(4, 24);
            tabNuevo.Name = "tabNuevo";
            tabNuevo.Padding = new Padding(3);
            tabNuevo.Size = new Size(732, 316);
            tabNuevo.TabIndex = 1;
            tabNuevo.Text = "Nuevo";
            tabNuevo.UseVisualStyleBackColor = true;
            // 
            // txbCantidadNuevo
            // 
            txbCantidadNuevo.Location = new Point(491, 151);
            txbCantidadNuevo.Name = "txbCantidadNuevo";
            txbCantidadNuevo.Size = new Size(159, 23);
            txbCantidadNuevo.TabIndex = 14;
            // 
            // txbPrecioVentaNuevo
            // 
            txbPrecioVentaNuevo.Location = new Point(491, 105);
            txbPrecioVentaNuevo.Name = "txbPrecioVentaNuevo";
            txbPrecioVentaNuevo.Size = new Size(159, 23);
            txbPrecioVentaNuevo.TabIndex = 13;
            // 
            // txbPrecioCompraNuevo
            // 
            txbPrecioCompraNuevo.Location = new Point(491, 57);
            txbPrecioCompraNuevo.Name = "txbPrecioCompraNuevo";
            txbPrecioCompraNuevo.Size = new Size(159, 23);
            txbPrecioCompraNuevo.TabIndex = 11;
            // 
            // txbDescripcionNuevo
            // 
            txbDescripcionNuevo.Location = new Point(136, 150);
            txbDescripcionNuevo.Name = "txbDescripcionNuevo";
            txbDescripcionNuevo.Size = new Size(159, 23);
            txbDescripcionNuevo.TabIndex = 9;
            // 
            // txbCodigoNuevo
            // 
            txbCodigoNuevo.Location = new Point(136, 105);
            txbCodigoNuevo.Name = "txbCodigoNuevo";
            txbCodigoNuevo.Size = new Size(159, 23);
            txbCodigoNuevo.TabIndex = 1;
            // 
            // lbPrecioVentaNuevo
            // 
            lbPrecioVentaNuevo.AutoSize = true;
            lbPrecioVentaNuevo.Location = new Point(397, 108);
            lbPrecioVentaNuevo.Name = "lbPrecioVentaNuevo";
            lbPrecioVentaNuevo.Size = new Size(75, 15);
            lbPrecioVentaNuevo.TabIndex = 12;
            lbPrecioVentaNuevo.Text = "Precio Venta:";
            // 
            // lbPrecioCompraNuevo
            // 
            lbPrecioCompraNuevo.AutoSize = true;
            lbPrecioCompraNuevo.Location = new Point(383, 63);
            lbPrecioCompraNuevo.Name = "lbPrecioCompraNuevo";
            lbPrecioCompraNuevo.Size = new Size(89, 15);
            lbPrecioCompraNuevo.TabIndex = 10;
            lbPrecioCompraNuevo.Text = "Precio Compra:";
            // 
            // lbDescripcionNuevo
            // 
            lbDescripcionNuevo.AutoSize = true;
            lbDescripcionNuevo.Location = new Point(42, 158);
            lbDescripcionNuevo.Name = "lbDescripcionNuevo";
            lbDescripcionNuevo.Size = new Size(72, 15);
            lbDescripcionNuevo.TabIndex = 8;
            lbDescripcionNuevo.Text = "Descripcion:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(421, 156);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 6;
            label1.Text = "Cantidad";
            // 
            // btnGuardarNuevo
            // 
            btnGuardarNuevo.Cursor = Cursors.Hand;
            btnGuardarNuevo.FlatStyle = FlatStyle.Flat;
            btnGuardarNuevo.ForeColor = Color.FromArgb(30, 90, 195);
            btnGuardarNuevo.Location = new Point(647, 280);
            btnGuardarNuevo.Name = "btnGuardarNuevo";
            btnGuardarNuevo.Size = new Size(75, 23);
            btnGuardarNuevo.TabIndex = 5;
            btnGuardarNuevo.Text = "Guardar";
            btnGuardarNuevo.UseVisualStyleBackColor = true;
            btnGuardarNuevo.Click += btnGuardarNuevo_Click;
            // 
            // VolverNuevo
            // 
            VolverNuevo.Cursor = Cursors.Hand;
            VolverNuevo.FlatStyle = FlatStyle.Flat;
            VolverNuevo.Location = new Point(16, 280);
            VolverNuevo.Name = "VolverNuevo";
            VolverNuevo.Size = new Size(75, 23);
            VolverNuevo.TabIndex = 4;
            VolverNuevo.Text = "Volver";
            VolverNuevo.UseVisualStyleBackColor = true;
            VolverNuevo.Click += VolverNuevo_Click;
            // 
            // cbbCategoriaNuevo
            // 
            cbbCategoriaNuevo.Cursor = Cursors.Hand;
            cbbCategoriaNuevo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbCategoriaNuevo.FormattingEnabled = true;
            cbbCategoriaNuevo.Location = new Point(136, 57);
            cbbCategoriaNuevo.Name = "cbbCategoriaNuevo";
            cbbCategoriaNuevo.Size = new Size(159, 23);
            cbbCategoriaNuevo.TabIndex = 3;
            // 
            // lbMedida
            // 
            lbMedida.AutoSize = true;
            lbMedida.Location = new Point(42, 63);
            lbMedida.Name = "lbMedida";
            lbMedida.Size = new Size(64, 15);
            lbMedida.TabIndex = 2;
            lbMedida.Text = "Categoria: ";
            // 
            // lbCodigo
            // 
            lbCodigo.AutoSize = true;
            lbCodigo.Location = new Point(42, 113);
            lbCodigo.Name = "lbCodigo";
            lbCodigo.Size = new Size(49, 15);
            lbCodigo.TabIndex = 0;
            lbCodigo.Text = "Codigo:";
            // 
            // tabLista
            // 
            tabLista.Controls.Add(dgvProductos);
            tabLista.Controls.Add(btnBuscar);
            tabLista.Controls.Add(txtBuscar);
            tabLista.Controls.Add(btnNuevoLista);
            tabLista.Location = new Point(4, 24);
            tabLista.Name = "tabLista";
            tabLista.Padding = new Padding(3);
            tabLista.Size = new Size(732, 316);
            tabLista.TabIndex = 0;
            tabLista.Text = "Lista";
            tabLista.UseVisualStyleBackColor = true;
            // 
            // dgvProductos
            // 
            dgvProductos.BackgroundColor = Color.FromArgb(224, 224, 224);
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.GridColor = Color.FromArgb(224, 224, 224);
            dgvProductos.Location = new Point(6, 56);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.Size = new Size(720, 254);
            dgvProductos.TabIndex = 3;
            dgvProductos.CellContentClick += dgvProductos_CellContentClick;
            // 
            // btnBuscar
            // 
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Location = new Point(651, 15);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(482, 16);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(151, 23);
            txtBuscar.TabIndex = 1;
            // 
            // btnNuevoLista
            // 
            btnNuevoLista.Cursor = Cursors.Hand;
            btnNuevoLista.FlatStyle = FlatStyle.Flat;
            btnNuevoLista.Location = new Point(5, 15);
            btnNuevoLista.Name = "btnNuevoLista";
            btnNuevoLista.Size = new Size(75, 23);
            btnNuevoLista.TabIndex = 0;
            btnNuevoLista.Text = "Nuevo";
            btnNuevoLista.UseVisualStyleBackColor = true;
            btnNuevoLista.Click += btnNuevoLista_Click;
            // 
            // tabControlMain
            // 
            tabControlMain.Controls.Add(tabLista);
            tabControlMain.Controls.Add(tabNuevo);
            tabControlMain.Controls.Add(tabEditar);
            tabControlMain.ItemSize = new Size(80, 20);
            tabControlMain.Location = new Point(12, 46);
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(740, 344);
            tabControlMain.SizeMode = TabSizeMode.Fixed;
            tabControlMain.TabIndex = 2;
            // 
            // frmProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(764, 407);
            Controls.Add(lbProducto);
            Controls.Add(tabControlMain);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmProducto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmProducto";
            Load += frmProducto_Load;
            tabEditar.ResumeLayout(false);
            tabEditar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txbCantidadEditar).EndInit();
            tabNuevo.ResumeLayout(false);
            tabNuevo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txbCantidadNuevo).EndInit();
            tabLista.ResumeLayout(false);
            tabLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            tabControlMain.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbProducto;
        private TabPage tabEditar;
        private NumericUpDown txbCantidadEditar;
        private TextBox txbPrecioVentaEditar;
        private Label label2;
        private TextBox txbPrecioCompraEditar;
        private Label label3;
        private TextBox txbDescripcionEditar;
        private Label label4;
        private Label label5;
        private ComboBox cbbCategoriaEditar;
        private Label label6;
        private TextBox txbCodigoEditar;
        private Label label7;
        private Button btnGuardarEditar;
        private Button btnVolverEditar;
        private TabPage tabNuevo;
        private NumericUpDown txbCantidadNuevo;
        private TextBox txbPrecioVentaNuevo;
        private TextBox txbPrecioCompraNuevo;
        private TextBox txbDescripcionNuevo;
        private TextBox txbCodigoNuevo;
        private Label lbPrecioVentaNuevo;
        private Label lbPrecioCompraNuevo;
        private Label lbDescripcionNuevo;
        private Label label1;
        private Button btnGuardarNuevo;
        private Button VolverNuevo;
        private ComboBox cbbCategoriaNuevo;
        private Label lbMedida;
        private Label lbCodigo;
        private TabPage tabLista;
        private DataGridView dgvProductos;
        private Button btnBuscar;
        private TextBox txtBuscar;
        private Button btnNuevoLista;
        private TabControl tabControlMain;
        private ComboBox cbbHabilitadoEditar;
        private Label label8;
    }
}