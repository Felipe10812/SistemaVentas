namespace SVPresentacion.Formularios
{
    partial class frmCategoria
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
            tabControlMain = new TabControl();
            tabLista = new TabPage();
            dgvCategorias = new DataGridView();
            btnBuscar = new Button();
            txbBuscar = new TextBox();
            btnNuevo = new Button();
            tabNuevo = new TabPage();
            btnGuardarNuevo = new Button();
            VolverNuevo = new Button();
            cbbMedidaNuevo = new ComboBox();
            lbMedida = new Label();
            txbNombreNuevo = new TextBox();
            lbNombre = new Label();
            tabEditar = new TabPage();
            btnGuardarEditar = new Button();
            btnVolverEditar = new Button();
            cbbMedidaEditar = new ComboBox();
            lbMedidaEditar = new Label();
            tbxEditar = new TextBox();
            lbNombreEditar = new Label();
            cbbHabilitadoEditar = new ComboBox();
            lbHabilitadoEditar = new Label();
            label1 = new Label();
            tabControlMain.SuspendLayout();
            tabLista.SuspendLayout();
            this.Load += new System.EventHandler(this.frmCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).BeginInit();
            tabNuevo.SuspendLayout();
            tabEditar.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlMain
            // 
            tabControlMain.Controls.Add(tabLista);
            tabControlMain.Controls.Add(tabNuevo);
            tabControlMain.Controls.Add(tabEditar);
            tabControlMain.ItemSize = new Size(80, 20);
            tabControlMain.Location = new Point(3, 51);
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(740, 344);
            tabControlMain.SizeMode = TabSizeMode.Fixed;
            tabControlMain.TabIndex = 0;
            // 
            // tabLista
            // 
            tabLista.Controls.Add(dgvCategorias);
            tabLista.Controls.Add(btnBuscar);
            tabLista.Controls.Add(txbBuscar);
            tabLista.Controls.Add(btnNuevo);
            tabLista.Location = new Point(4, 24);
            tabLista.Name = "tabLista";
            tabLista.Padding = new Padding(3);
            tabLista.Size = new Size(732, 316);
            tabLista.TabIndex = 0;
            tabLista.Text = "Lista";
            tabLista.UseVisualStyleBackColor = true;
            // 
            // dgvCategorias
            // 
            dgvCategorias.BackgroundColor = Color.FromArgb(224, 224, 224);
            dgvCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategorias.GridColor = Color.FromArgb(224, 224, 224);
            dgvCategorias.Location = new Point(6, 56);
            dgvCategorias.Name = "dgvCategorias";
            dgvCategorias.Size = new Size(720, 254);
            dgvCategorias.TabIndex = 3;
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
            // txbBuscar
            // 
            txbBuscar.Location = new Point(482, 16);
            txbBuscar.Name = "txbBuscar";
            txbBuscar.Size = new Size(151, 23);
            txbBuscar.TabIndex = 1;
            // 
            // btnNuevo
            // 
            btnNuevo.Cursor = Cursors.Hand;
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.Location = new Point(5, 15);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(75, 23);
            btnNuevo.TabIndex = 0;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
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
            cbbMedidaNuevo.Location = new Point(94, 49);
            cbbMedidaNuevo.Name = "cbbMedidaNuevo";
            cbbMedidaNuevo.Size = new Size(159, 23);
            cbbMedidaNuevo.TabIndex = 3;
            // 
            // lbMedida
            // 
            lbMedida.AutoSize = true;
            lbMedida.Location = new Point(16, 52);
            lbMedida.Name = "lbMedida";
            lbMedida.Size = new Size(53, 15);
            lbMedida.TabIndex = 2;
            lbMedida.Text = "Medida: ";
            // 
            // txbNombreNuevo
            // 
            txbNombreNuevo.Location = new Point(94, 11);
            txbNombreNuevo.Name = "txbNombreNuevo";
            txbNombreNuevo.Size = new Size(159, 23);
            txbNombreNuevo.TabIndex = 1;
            // 
            // lbNombre
            // 
            lbNombre.AutoSize = true;
            lbNombre.Location = new Point(16, 14);
            lbNombre.Name = "lbNombre";
            lbNombre.Size = new Size(57, 15);
            lbNombre.TabIndex = 0;
            lbNombre.Text = "Nombre: ";
            // 
            // tabEditar
            // 
            tabEditar.Controls.Add(btnGuardarEditar);
            tabEditar.Controls.Add(btnVolverEditar);
            tabEditar.Controls.Add(cbbMedidaEditar);
            tabEditar.Controls.Add(lbMedidaEditar);
            tabEditar.Controls.Add(tbxEditar);
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
            lbMedidaEditar.Location = new Point(16, 51);
            lbMedidaEditar.Name = "lbMedidaEditar";
            lbMedidaEditar.Size = new Size(53, 15);
            lbMedidaEditar.TabIndex = 12;
            lbMedidaEditar.Text = "Medida: ";
            // 
            // tbxEditar
            // 
            tbxEditar.Location = new Point(94, 11);
            tbxEditar.Name = "tbxEditar";
            tbxEditar.Size = new Size(159, 23);
            tbxEditar.TabIndex = 11;
            // 
            // lbNombreEditar
            // 
            lbNombreEditar.AutoSize = true;
            lbNombreEditar.Location = new Point(16, 14);
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
            // lbHabilitadoEditar
            // 
            lbHabilitadoEditar.AutoSize = true;
            lbHabilitadoEditar.Location = new Point(16, 89);
            lbHabilitadoEditar.Name = "lbHabilitadoEditar";
            lbHabilitadoEditar.Size = new Size(65, 15);
            lbHabilitadoEditar.TabIndex = 8;
            lbHabilitadoEditar.Text = "Habilitado:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(122, 15);
            label1.TabIndex = 1;
            label1.Text = "Inventario / Categoria";
            // 
            // frmCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(746, 407);
            Controls.Add(label1);
            Controls.Add(tabControlMain);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCategoria";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmCategoria";
            tabControlMain.ResumeLayout(false);
            tabLista.ResumeLayout(false);
            tabLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).EndInit();
            tabNuevo.ResumeLayout(false);
            tabNuevo.PerformLayout();
            tabEditar.ResumeLayout(false);
            tabEditar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControlMain;
        private TabPage tabLista;
        private TabPage tabNuevo;
        private Label label1;
        private TabPage tabEditar;
        private DataGridView dgvCategorias;
        private Button btnBuscar;
        private TextBox txbBuscar;
        private Button btnNuevo;
        private Label lbNombre;
        private ComboBox cbbMedidaNuevo;
        private Label lbMedida;
        private TextBox txbNombreNuevo;
        private Button btnGuardarNuevo;
        private Button VolverNuevo;
        private Button btnGuardarEditar;
        private Button btnVolverEditar;
        private ComboBox cbbMedidaEditar;
        private Label lbMedidaEditar;
        private TextBox tbxEditar;
        private Label lbNombreEditar;
        private ComboBox cbbHabilitadoEditar;
        private Label lbHabilitadoEditar;
    }
}