
namespace SVPresentacion.Utilidades
{
    static class PersonalizacionDataGridView
    {
        public static void ImplementarConfiguracion(this DataGridView dataGrid, string textoEnBoton = "")
        {
            dataGrid.AllowUserToAddRows = false;
            dataGrid.AllowUserToResizeRows = true;
            dataGrid.AllowUserToDeleteRows = false;
            dataGrid.AllowUserToOrderColumns = false;
            dataGrid.AllowUserToResizeColumns = true;

            dataGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dataGrid.MultiSelect = false;
            dataGrid.ReadOnly = true;
            dataGrid.RowHeadersVisible = false;

            dataGrid.BackgroundColor = Color.White;

            dataGrid.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.FromArgb(58, 49, 69),
                SelectionBackColor = Color.FromArgb(58, 49, 69),
                ForeColor = Color.FromArgb(255, 255, 255),
            };

            dataGrid.DefaultCellStyle = new DataGridViewCellStyle
            {
                SelectionBackColor = Color.FromArgb(58, 49, 69),
                SelectionForeColor = Color.FromArgb(255, 255, 255),
            };

            dataGrid.ColumnHeadersHeight = 40;
            dataGrid.EnableHeadersVisualStyles = false;
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;

            if(textoEnBoton != "")
            {
                var btnEditarColumn = new DataGridViewButtonColumn();
                btnEditarColumn.Name = "ColumnaAccion";
                btnEditarColumn.Text = textoEnBoton;
                btnEditarColumn.HeaderText = "";
                btnEditarColumn.UseColumnTextForButtonValue = true;
                btnEditarColumn.Width = 60;
                btnEditarColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dataGrid.Columns.Add(btnEditarColumn);
            }
        }
    }
}
