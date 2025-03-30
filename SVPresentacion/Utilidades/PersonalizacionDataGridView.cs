
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
                BackColor = AppColors.RojoOscuro,
                SelectionBackColor = AppColors.RojoOscuro,
                ForeColor = Color.White,
            };

            dataGrid.DefaultCellStyle = new DataGridViewCellStyle
            {
                SelectionBackColor = AppColors.RojoMedio,
                SelectionForeColor = Color.White,
            };

            dataGrid.ColumnHeadersHeight = 40;
            dataGrid.EnableHeadersVisualStyles = false;
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;

            if (!dataGrid.Columns.Contains("ColumnaAccion"))
            {
                var btnEditarColumn = new DataGridViewButtonColumn
                {
                    Name = "ColumnaAccion",
                    Text = textoEnBoton,
                    HeaderText = "",
                    UseColumnTextForButtonValue = true,
                    Width = 60,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells,
                    DefaultCellStyle = new DataGridViewCellStyle
                    {
                        BackColor = AppColors.RojoOscuro,
                        SelectionBackColor = AppColors.RojoOscuro,
                        ForeColor = Color.White,
                    }
                };
                dataGrid.Columns.Add(btnEditarColumn);
            }
        }
    }
}