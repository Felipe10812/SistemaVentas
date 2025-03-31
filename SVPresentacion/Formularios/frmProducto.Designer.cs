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
            btnVolverEditar = new Button();
            cbbMedidaEditar = new ComboBox();
            lbMedidaEditar = new Label();
            txbEditar = new TextBox();
            lbNombreEditar = new Label();
            cbbHabilitadoEditar = new ComboBox();
            btnGuardarNuevo = new Button();
            VolverNuevo = new Button();
            cbbMedidaNuevo = new ComboBox();
            lbMedida = new Label();
            btnGuardarEditar = new Button();
            tabEditar = new TabPage();
            lbHabilitadoEditar = new Label();
            txbNombreNuevo = new TextBox();
            tabNuevo = new TabPage();
            lbNombre = new Label();
            dgvProductos = new DataGridView();
            btnBuscar = new Button();
            txtBuscar = new TextBox();
            btnNuevoLista = new Button();
            tabLista = new TabPage();
            tabControlMain = new TabControl();
            tabEditar.SuspendLayout();
            tabNuevo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            tabLista.SuspendLayout();
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
            // 
            // cbbMedidaEditar
            // 
            cbbMedidaEditar.Cursor = Cursors.Hand;
            cbbMedidaEditar.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbMedidaEditar.FormattingEnabled = true;
            cbbMedidaEditar.Location = new Point(94, 48);
            cbbMedidaEditar.Name = "cbbMedidaEditar";
            cbbMedidaEditar.Size = new Size(159, 23);
            cbbMedidaEditar.TabIndex = 13;
            // 
            // lbMedidaEditar
            // 
            lbMedidaEditar.AutoSize = true;
            lbMedidaEditar.Location = new Point(19, 54);
            lbMedidaEditar.Name = "lbMedidaEditar";
            lbMedidaEditar.Size = new Size(53, 15);
            lbMedidaEditar.TabIndex = 12;
            lbMedidaEditar.Text = "Medida: ";
            // 
            // txbEditar
            // 
            txbEditar.Location = new Point(94, 11);
            txbEditar.Name = "txbEditar";
            txbEditar.Size = new Size(159, 23);
            txbEditar.TabIndex = 11;
            // 
            // lbNombreEditar
            // 
            lbNombreEditar.AutoSize = true;
            lbNombreEditar.Location = new Point(19, 17);
            lbNombreEditar.Name = "lbNombreEditar";
            lbNombreEditar.Size = new Size(57, 15);
            lbNombreEditar.TabIndex = 10;
            lbNombreEditar.Text = "Nombre: ";
            // 
            // cbbHabilitadoEditar
            // 
            cbbHabilitadoEditar.Cursor = Cursors.Hand;
            cbbHabilitadoEditar.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbHabilitadoEditar.FormattingEnabled = true;
            cbbHabilitadoEditar.Location = new Point(94, 86);
            cbbHabilitadoEditar.Name = "cbbHabilitadoEditar";
            cbbHabilitadoEditar.Size = new Size(159, 23);
            cbbHabilitadoEditar.TabIndex = 9;
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
            // 
            // cbbMedidaNuevo
            // 
            cbbMedidaNuevo.Cursor = Cursors.Hand;
            cbbMedidaNuevo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbMedidaNuevo.FormattingEnabled = true;
            cbbMedidaNuevo.Location = new Point(94, 48);
            cbbMedidaNuevo.Name = "cbbMedidaNuevo";
            cbbMedidaNuevo.Size = new Size(159, 23);
            cbbMedidaNuevo.TabIndex = 3;
            // 
            // lbMedida
            // 
            lbMedida.AutoSize = true;
            lbMedida.Location = new Point(19, 54);
            lbMedida.Name = "lbMedida";
            lbMedida.Size = new Size(53, 15);
            lbMedida.TabIndex = 2;
            lbMedida.Text = "Medida: ";
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
            // 
            // tabEditar
            // 
            tabEditar.Controls.Add(btnGuardarEditar);
            tabEditar.Controls.Add(btnVolverEditar);
            tabEditar.Controls.Add(cbbMedidaEditar);
            tabEditar.Controls.Add(lbMedidaEditar);
            tabEditar.Controls.Add(txbEditar);
            tabEditar.Controls.Add(lbNombreEditar);
            tabEditar.Controls.Add(cbbHabilitadoEditar);
            tabEditar.Controls.Add(lbHabilitadoEditar);
            tabEditar.Location = new Point(4, 24);
            tabEditar.Name = "tabEditar";
            tabEditar.Padding = new Padding(3);
            tabEditar.Size = new Size(732, 316);
            tabEditar.TabIndex = 2;
            tabEditar.Text = "Editar";
            tabEditar.UseVisualStyleBackColor = true;
            // 
            // lbHabilitadoEditar
            // 
            lbHabilitadoEditar.AutoSize = true;
            lbHabilitadoEditar.Location = new Point(19, 92);
            lbHabilitadoEditar.Name = "lbHabilitadoEditar";
            lbHabilitadoEditar.Size = new Size(65, 15);
            lbHabilitadoEditar.TabIndex = 8;
            lbHabilitadoEditar.Text = "Habilitado:";
            // 
            // txbNombreNuevo
            // 
            txbNombreNuevo.Location = new Point(94, 11);
            txbNombreNuevo.Name = "txbNombreNuevo";
            txbNombreNuevo.Size = new Size(159, 23);
            txbNombreNuevo.TabIndex = 1;
            // 
            // tabNuevo
            // 
            tabNuevo.Controls.Add(btnGuardarNuevo);
            tabNuevo.Controls.Add(VolverNuevo);
            tabNuevo.Controls.Add(cbbMedidaNuevo);
            tabNuevo.Controls.Add(lbMedida);
            tabNuevo.Controls.Add(txbNombreNuevo);
            tabNuevo.Controls.Add(lbNombre);
            tabNuevo.Location = new Point(4, 24);
            tabNuevo.Name = "tabNuevo";
            tabNuevo.Padding = new Padding(3);
            tabNuevo.Size = new Size(732, 316);
            tabNuevo.TabIndex = 1;
            tabNuevo.Text = "Nuevo";
            tabNuevo.UseVisualStyleBackColor = true;
            // 
            // lbNombre
            // 
            lbNombre.AutoSize = true;
            lbNombre.Location = new Point(19, 17);
            lbNombre.Name = "lbNombre";
            lbNombre.Size = new Size(57, 15);
            lbNombre.TabIndex = 0;
            lbNombre.Text = "Nombre: ";
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
            tabEditar.ResumeLayout(false);
            tabEditar.PerformLayout();
            tabNuevo.ResumeLayout(false);
            tabNuevo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            tabLista.ResumeLayout(false);
            tabLista.PerformLayout();
            tabControlMain.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbProducto;
        private Button btnVolverEditar;
        private ComboBox cbbMedidaEditar;
        private Label lbMedidaEditar;
        private TextBox txbEditar;
        private Label lbNombreEditar;
        private ComboBox cbbHabilitadoEditar;
        private Button btnGuardarNuevo;
        private Button VolverNuevo;
        private ComboBox cbbMedidaNuevo;
        private Label lbMedida;
        private Button btnGuardarEditar;
        private TabPage tabEditar;
        private Label lbHabilitadoEditar;
        private TextBox txbNombreNuevo;
        private TabPage tabNuevo;
        private Label lbNombre;
        private DataGridView dgvProductos;
        private Button btnBuscar;
        private TextBox txtBuscar;
        private Button btnNuevoLista;
        private TabPage tabLista;
        private TabControl tabControlMain;
    }
}