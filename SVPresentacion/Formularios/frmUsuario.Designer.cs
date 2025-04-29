namespace SVPresentacion.Formularios
{
    partial class frmUsuario
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
            lbCategoria = new Label();
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
            dgvCategorias = new DataGridView();
            btnBuscar = new Button();
            txtBuscar = new TextBox();
            btnNuevoLista = new Button();
            tabControlMain = new TabControl();
            tabLista = new TabPage();
            tabEditar.SuspendLayout();
            tabNuevo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).BeginInit();
            tabControlMain.SuspendLayout();
            tabLista.SuspendLayout();
            SuspendLayout();
            // 
            // lbCategoria
            // 
            lbCategoria.AutoSize = true;
            lbCategoria.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbCategoria.ForeColor = SystemColors.InactiveBorder;
            lbCategoria.Location = new Point(17, 18);
            lbCategoria.Name = "lbCategoria";
            lbCategoria.Size = new Size(84, 28);
            lbCategoria.TabIndex = 3;
            lbCategoria.Text = "Usuario";
            // 
            // btnVolverEditar
            // 
            btnVolverEditar.Cursor = Cursors.Hand;
            btnVolverEditar.FlatStyle = FlatStyle.Flat;
            btnVolverEditar.Location = new Point(18, 373);
            btnVolverEditar.Margin = new Padding(3, 4, 3, 4);
            btnVolverEditar.Name = "btnVolverEditar";
            btnVolverEditar.Size = new Size(86, 31);
            btnVolverEditar.TabIndex = 14;
            btnVolverEditar.Text = "Volver";
            btnVolverEditar.UseVisualStyleBackColor = true;
            // 
            // cbbMedidaEditar
            // 
            cbbMedidaEditar.Cursor = Cursors.Hand;
            cbbMedidaEditar.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbMedidaEditar.FormattingEnabled = true;
            cbbMedidaEditar.Location = new Point(107, 64);
            cbbMedidaEditar.Margin = new Padding(3, 4, 3, 4);
            cbbMedidaEditar.Name = "cbbMedidaEditar";
            cbbMedidaEditar.Size = new Size(181, 28);
            cbbMedidaEditar.TabIndex = 13;
            // 
            // lbMedidaEditar
            // 
            lbMedidaEditar.AutoSize = true;
            lbMedidaEditar.Location = new Point(21, 72);
            lbMedidaEditar.Name = "lbMedidaEditar";
            lbMedidaEditar.Size = new Size(67, 20);
            lbMedidaEditar.TabIndex = 12;
            lbMedidaEditar.Text = "Medida: ";
            // 
            // txbEditar
            // 
            txbEditar.Location = new Point(107, 15);
            txbEditar.Margin = new Padding(3, 4, 3, 4);
            txbEditar.Name = "txbEditar";
            txbEditar.Size = new Size(181, 27);
            txbEditar.TabIndex = 11;
            // 
            // lbNombreEditar
            // 
            lbNombreEditar.AutoSize = true;
            lbNombreEditar.Location = new Point(21, 23);
            lbNombreEditar.Name = "lbNombreEditar";
            lbNombreEditar.Size = new Size(71, 20);
            lbNombreEditar.TabIndex = 10;
            lbNombreEditar.Text = "Nombre: ";
            // 
            // cbbHabilitadoEditar
            // 
            cbbHabilitadoEditar.Cursor = Cursors.Hand;
            cbbHabilitadoEditar.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbHabilitadoEditar.FormattingEnabled = true;
            cbbHabilitadoEditar.Location = new Point(107, 115);
            cbbHabilitadoEditar.Margin = new Padding(3, 4, 3, 4);
            cbbHabilitadoEditar.Name = "cbbHabilitadoEditar";
            cbbHabilitadoEditar.Size = new Size(181, 28);
            cbbHabilitadoEditar.TabIndex = 9;
            // 
            // btnGuardarNuevo
            // 
            btnGuardarNuevo.Cursor = Cursors.Hand;
            btnGuardarNuevo.FlatStyle = FlatStyle.Flat;
            btnGuardarNuevo.ForeColor = Color.FromArgb(30, 90, 195);
            btnGuardarNuevo.Location = new Point(739, 373);
            btnGuardarNuevo.Margin = new Padding(3, 4, 3, 4);
            btnGuardarNuevo.Name = "btnGuardarNuevo";
            btnGuardarNuevo.Size = new Size(86, 31);
            btnGuardarNuevo.TabIndex = 5;
            btnGuardarNuevo.Text = "Guardar";
            btnGuardarNuevo.UseVisualStyleBackColor = true;
            // 
            // VolverNuevo
            // 
            VolverNuevo.Cursor = Cursors.Hand;
            VolverNuevo.FlatStyle = FlatStyle.Flat;
            VolverNuevo.Location = new Point(18, 373);
            VolverNuevo.Margin = new Padding(3, 4, 3, 4);
            VolverNuevo.Name = "VolverNuevo";
            VolverNuevo.Size = new Size(86, 31);
            VolverNuevo.TabIndex = 4;
            VolverNuevo.Text = "Volver";
            VolverNuevo.UseVisualStyleBackColor = true;
            // 
            // cbbMedidaNuevo
            // 
            cbbMedidaNuevo.Cursor = Cursors.Hand;
            cbbMedidaNuevo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbMedidaNuevo.FormattingEnabled = true;
            cbbMedidaNuevo.Location = new Point(107, 64);
            cbbMedidaNuevo.Margin = new Padding(3, 4, 3, 4);
            cbbMedidaNuevo.Name = "cbbMedidaNuevo";
            cbbMedidaNuevo.Size = new Size(181, 28);
            cbbMedidaNuevo.TabIndex = 3;
            // 
            // lbMedida
            // 
            lbMedida.AutoSize = true;
            lbMedida.Location = new Point(21, 72);
            lbMedida.Name = "lbMedida";
            lbMedida.Size = new Size(67, 20);
            lbMedida.TabIndex = 2;
            lbMedida.Text = "Medida: ";
            // 
            // btnGuardarEditar
            // 
            btnGuardarEditar.Cursor = Cursors.Hand;
            btnGuardarEditar.FlatStyle = FlatStyle.Flat;
            btnGuardarEditar.ForeColor = Color.FromArgb(30, 90, 195);
            btnGuardarEditar.Location = new Point(739, 373);
            btnGuardarEditar.Margin = new Padding(3, 4, 3, 4);
            btnGuardarEditar.Name = "btnGuardarEditar";
            btnGuardarEditar.Size = new Size(86, 31);
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
            tabEditar.Margin = new Padding(3, 4, 3, 4);
            tabEditar.Name = "tabEditar";
            tabEditar.Padding = new Padding(3, 4, 3, 4);
            tabEditar.Size = new Size(838, 431);
            tabEditar.TabIndex = 2;
            tabEditar.Text = "Editar";
            tabEditar.UseVisualStyleBackColor = true;
            // 
            // lbHabilitadoEditar
            // 
            lbHabilitadoEditar.AutoSize = true;
            lbHabilitadoEditar.Location = new Point(21, 123);
            lbHabilitadoEditar.Name = "lbHabilitadoEditar";
            lbHabilitadoEditar.Size = new Size(83, 20);
            lbHabilitadoEditar.TabIndex = 8;
            lbHabilitadoEditar.Text = "Habilitado:";
            // 
            // txbNombreNuevo
            // 
            txbNombreNuevo.Location = new Point(107, 15);
            txbNombreNuevo.Margin = new Padding(3, 4, 3, 4);
            txbNombreNuevo.Name = "txbNombreNuevo";
            txbNombreNuevo.Size = new Size(181, 27);
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
            tabNuevo.Margin = new Padding(3, 4, 3, 4);
            tabNuevo.Name = "tabNuevo";
            tabNuevo.Padding = new Padding(3, 4, 3, 4);
            tabNuevo.Size = new Size(838, 431);
            tabNuevo.TabIndex = 1;
            tabNuevo.Text = "Nuevo";
            tabNuevo.UseVisualStyleBackColor = true;
            // 
            // lbNombre
            // 
            lbNombre.AutoSize = true;
            lbNombre.Location = new Point(21, 23);
            lbNombre.Name = "lbNombre";
            lbNombre.Size = new Size(71, 20);
            lbNombre.TabIndex = 0;
            lbNombre.Text = "Nombre: ";
            // 
            // dgvCategorias
            // 
            dgvCategorias.BackgroundColor = Color.FromArgb(224, 224, 224);
            dgvCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategorias.GridColor = Color.FromArgb(224, 224, 224);
            dgvCategorias.Location = new Point(7, 75);
            dgvCategorias.Margin = new Padding(3, 4, 3, 4);
            dgvCategorias.Name = "dgvCategorias";
            dgvCategorias.RowHeadersWidth = 51;
            dgvCategorias.Size = new Size(823, 339);
            dgvCategorias.TabIndex = 3;
            // 
            // btnBuscar
            // 
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Location = new Point(744, 20);
            btnBuscar.Margin = new Padding(3, 4, 3, 4);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(86, 31);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(551, 21);
            txtBuscar.Margin = new Padding(3, 4, 3, 4);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(172, 27);
            txtBuscar.TabIndex = 1;
            // 
            // btnNuevoLista
            // 
            btnNuevoLista.Cursor = Cursors.Hand;
            btnNuevoLista.FlatStyle = FlatStyle.Flat;
            btnNuevoLista.Location = new Point(6, 20);
            btnNuevoLista.Margin = new Padding(3, 4, 3, 4);
            btnNuevoLista.Name = "btnNuevoLista";
            btnNuevoLista.Size = new Size(86, 31);
            btnNuevoLista.TabIndex = 0;
            btnNuevoLista.Text = "Nuevo";
            btnNuevoLista.UseVisualStyleBackColor = true;
            // 
            // tabControlMain
            // 
            tabControlMain.Controls.Add(tabLista);
            tabControlMain.Controls.Add(tabNuevo);
            tabControlMain.Controls.Add(tabEditar);
            tabControlMain.ItemSize = new Size(80, 20);
            tabControlMain.Location = new Point(13, 66);
            tabControlMain.Margin = new Padding(3, 4, 3, 4);
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(846, 459);
            tabControlMain.SizeMode = TabSizeMode.Fixed;
            tabControlMain.TabIndex = 2;
            // 
            // tabLista
            // 
            tabLista.Controls.Add(dgvCategorias);
            tabLista.Controls.Add(btnBuscar);
            tabLista.Controls.Add(txtBuscar);
            tabLista.Controls.Add(btnNuevoLista);
            tabLista.Location = new Point(4, 24);
            tabLista.Margin = new Padding(3, 4, 3, 4);
            tabLista.Name = "tabLista";
            tabLista.Padding = new Padding(3, 4, 3, 4);
            tabLista.Size = new Size(838, 431);
            tabLista.TabIndex = 0;
            tabLista.Text = "Lista";
            tabLista.UseVisualStyleBackColor = true;
            // 
            // frmUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(873, 543);
            Controls.Add(lbCategoria);
            Controls.Add(tabControlMain);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmUsuario";
            tabEditar.ResumeLayout(false);
            tabEditar.PerformLayout();
            tabNuevo.ResumeLayout(false);
            tabNuevo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).EndInit();
            tabControlMain.ResumeLayout(false);
            tabLista.ResumeLayout(false);
            tabLista.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbCategoria;
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
        private DataGridView dgvCategorias;
        private Button btnBuscar;
        private TextBox txtBuscar;
        private Button btnNuevoLista;
        private TabControl tabControlMain;
        private TabPage tabLista;
    }
}