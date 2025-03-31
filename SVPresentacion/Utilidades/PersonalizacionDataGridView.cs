namespace SVPresentacion.Utilidades
{
    static class PersonalizacionDataGridView
    {
        public static void ImplementarConfiguracion(this DataGridView dataGrid, string textoEnBoton = "")
        {
            if (dataGrid == null)
            {
                throw new ArgumentNullException(nameof(dataGrid));
            }

            // Configuración básica del DataGridView
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
            dataGrid.EnableHeadersVisualStyles = false;
            dataGrid.ColumnHeadersHeight = 40;
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            // Configuración de estilos
            dataGrid.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = AppColors.AzulOscuro,
                SelectionBackColor = AppColors.AzulMedio,
                ForeColor = Color.White,
            };

            dataGrid.DefaultCellStyle = new DataGridViewCellStyle
            {
                SelectionBackColor = AppColors.AzulMedio,
                SelectionForeColor = Color.White,
            };

            // Configuración específica para la columna de botón
            if (!dataGrid.Columns.Contains("ColumnaAccion"))
            {
                var btnEditarColumn = new DataGridViewButtonColumn
                {
                    Name = "ColumnaAccion",
                    Text = textoEnBoton,
                    HeaderText = "",
                    UseColumnTextForButtonValue = true,
                    Width = 80,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                    FlatStyle = FlatStyle.Flat,
                    DefaultCellStyle = new DataGridViewCellStyle
                    {
                        BackColor = AppColors.AzulOscuro,
                        ForeColor = Color.White,
                        Alignment = DataGridViewContentAlignment.MiddleCenter,
                        SelectionBackColor = AppColors.AzulOscuro,
                        SelectionForeColor = Color.White,
                        Padding = new Padding(3)
                    }
                };

                dataGrid.Columns.Add(btnEditarColumn);

                // Manejadores de eventos con comprobación de nulidad
                dataGrid.CellPainting += (sender, e) =>
                {
                    if (e.ColumnIndex >= 0 && e.RowIndex >= 0 &&
                        dataGrid.Columns.Count > e.ColumnIndex &&
                        dataGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn buttonColumn &&
                        buttonColumn.Name == "ColumnaAccion")
                    {
                        e.Paint(e.CellBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.Border);

                        if (e.CellStyle != null && e.Graphics != null)
                        {
                            Color backColor = e.CellStyle.BackColor.IsEmpty ? Color.White : e.CellStyle.BackColor;
                            Color foreColor = e.CellStyle.ForeColor.IsEmpty ? Color.Black : e.CellStyle.ForeColor;

                            using (var backBrush = new SolidBrush(backColor))
                            using (var foreBrush = new SolidBrush(foreColor))
                            {
                                // Validación adicional para garantizar que e.CellBounds sea válido
                                if (!e.CellBounds.IsEmpty)
                                {
                                    e.Graphics.FillRectangle(backBrush, e.CellBounds);

                                    var text = dataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].FormattedValue?.ToString();
                                    if (!string.IsNullOrEmpty(text))
                                    {
                                        var format = new StringFormat
                                        {
                                            Alignment = StringAlignment.Center,
                                            LineAlignment = StringAlignment.Center
                                        };
                                        e.Graphics.DrawString(text, e.CellStyle.Font ?? SystemFonts.DefaultFont, foreBrush, e.CellBounds, format);
                                    }

                                    var cursorPos = dataGrid.PointToClient(Cursor.Position);
                                    if (e.CellBounds.Contains(cursorPos))
                                    {
                                        using (var pen = new Pen(AppColors.AzulMedio, 2))
                                        {
                                            var rect = e.CellBounds;
                                            rect.Inflate(-2, -2);
                                            e.Graphics.DrawRectangle(pen, rect);
                                        }
                                    }
                                }
                            }
                        }
                        e.Handled = true;
                    }
                };

                dataGrid.CellMouseEnter += (sender, e) =>
                {
                    if (e.ColumnIndex >= 0 && e.RowIndex >= 0 &&
                        dataGrid.Columns.Count > e.ColumnIndex &&
                        dataGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn buttonColumn &&
                        buttonColumn.Name == "ColumnaAccion")
                    {
                        dataGrid.Cursor = Cursors.Hand;
                        dataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = AppColors.AzulMedio;
                        dataGrid.InvalidateCell(e.ColumnIndex, e.RowIndex);
                    }
                };

                dataGrid.CellMouseLeave += (sender, e) =>
                {
                    if (e.ColumnIndex >= 0 && e.RowIndex >= 0 &&
                        dataGrid.Columns.Count > e.ColumnIndex &&
                        dataGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn buttonColumn &&
                        buttonColumn.Name == "ColumnaAccion")
                    {
                        dataGrid.Cursor = Cursors.Default;
                        dataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = AppColors.AzulOscuro;
                        dataGrid.InvalidateCell(e.ColumnIndex, e.RowIndex);
                    }
                };
            }
        }
    }
}