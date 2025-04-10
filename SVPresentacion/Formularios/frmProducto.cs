using SVPresentacion.Utilidades;
using SVPresentacion.Utilidades.Objetos;
using SVPresentacion.ViewModels;
using SVRespositorio.Entities;
using SVServices.Interfaces;

namespace SVPresentacion.Formularios
{
    public partial class frmProducto : Form
    {
        private readonly IProductoService _productoService;
        private readonly ICategoriaService _categoriaService;

        public frmProducto(ICategoriaService categoriaService, IProductoService productoService)
        {
            InitializeComponent();
            _categoriaService = categoriaService;
            _productoService = productoService;
        }

        // Método para mostrar las pestañas
        public void MostrarTab(string tabName)
        {
            var tabMenu = new TabPage[]
            {
                tabLista, tabNuevo, tabEditar
            };

            foreach (var tab in tabMenu)
            {
                if (tab.Name != tabName)
                {
                    tab.Parent = null;
                }
                else
                {
                    tab.Parent = tabControlMain;
                }
            }
        }

        private async Task MostrarProductos(string buscar = "")
        {
            try
            {
                var listaproductos = await _productoService.Lista(buscar);

                var listaVM = listaproductos.Select(x => new ProductosVM
                {
                    IdProducto = x.IdProducto,
                    Codigo = x.Codigo,
                    Descripcion = x.Descripcion,
                    IdCategoria = x.RefIdCategoria.IdCategoria,
                    Categoria = x.RefIdCategoria.Nombre,
                    PrecioCompra = x.PrecioCompra.ToString("0.00"),
                    PrecioVenta = x.PrecioVenta.ToString("0.00"),
                    Cantidad = x.Cantidad,
                    Activo = x.Activo,
                    Habilitado = x.Activo ? "Si" : "No"

                }).ToList();

                dgvProductos.DataSource = listaVM;

                dgvProductos.Columns["IdProducto"].Visible = false;
                dgvProductos.Columns["IdCategoria"].Visible = false;
                dgvProductos.Columns["Activo"].Visible = false;
                dgvProductos.Columns["Descripcion"].Width = 200;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las categorias" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void frmProducto_Load(object sender, EventArgs e)
        {
            this.BackColor = AppColors.AzulMedio;
            MostrarTab(tabLista.Name);
            await CargarDatos();
        }

        private async Task CargarDatos()
        {
            try
            {
                await MostrarProductos();
                dgvProductos.ImplementarConfiguracion("Editar");

                txbPrecioCompraNuevo.ValidarNumero();
                txbPrecioCompraEditar.ValidarNumero();

                txbPrecioVentaEditar.ValidarNumero();
                txbPrecioVentaNuevo.ValidarNumero();

                dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                OpcionCombo[] itemHabilitado = new OpcionCombo[]
                {
                    new OpcionCombo { Texto = "Si", Valor = 1 },
                    new OpcionCombo { Texto = "No", Valor = 0 }
                };

                var listaCategoria = await _categoriaService.Lista();

                var items = listaCategoria
                    .Where(x => x.Activo == true)
                    .Select(item => new OpcionCombo
                    {
                        Texto = item.Nombre,
                        Valor = item.IdCategoria
                    }).ToArray();

                cbbCategoriaNuevo.InsertarItems(items);
                cbbCategoriaEditar.InsertarItems(items);
                cbbHabilitadoEditar.InsertarItems(itemHabilitado);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las categorias" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Boton Buscar
        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            await MostrarProductos(txtBuscar.Text);
        }

        // Boton Guardar 
        private async void btnGuardarNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                // Validación: Codigo no puede estar vacío
                if (string.IsNullOrWhiteSpace(txbCodigoNuevo.Text))
                {
                    MessageBox.Show("Por favor, ingrese un código para el producto.",
                                    "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validación: Descripción no puede estar vacía
                if (string.IsNullOrWhiteSpace(txbDescripcionNuevo.Text))
                {
                    MessageBox.Show("Por favor, ingrese una descripción para el producto.",
                                    "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validación: categoria
                if (cbbCategoriaNuevo.SelectedItem is not OpcionCombo opcionSeleccionada)
                {
                    MessageBox.Show("Debe seleccionar una categoría.",
                                    "Selección requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validación: Precio de compra
                if (string.IsNullOrWhiteSpace(txbPrecioCompraNuevo.Text))
                {
                    MessageBox.Show("Por favor, ingrese un precio de compra.",
                                    "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validación: Precio de venta
                if (string.IsNullOrWhiteSpace(txbPrecioVentaNuevo.Text))
                {
                    MessageBox.Show("Por favor, ingrese un precio de venta.",
                                    "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validación: Cantidad
                if (txbCantidadNuevo.Value <= 0)
                {
                    MessageBox.Show("La cantidad debe ser mayor a cero.",
                                    "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Creación del objeto categoría
                var item = (OpcionCombo)cbbCategoriaNuevo.SelectedItem;

                var objeto = new Producto
                {
                    RefIdCategoria = new Categoria { IdCategoria = item.Valor },
                    Codigo = txbCodigoNuevo.Text.Trim(),
                    Descripcion = txbDescripcionNuevo.Text.Trim(),
                    PrecioCompra = decimal.Parse(txbPrecioCompraNuevo.Text),
                    PrecioVenta = decimal.Parse(txbPrecioVentaNuevo.Text),
                    Cantidad = txbCantidadNuevo.Value,
                };

                // Llamada al servicio
                var respuesta = await _productoService.Crear(objeto);

                if (!string.IsNullOrEmpty(respuesta))
                {
                    MessageBox.Show($"No se pudo guardar el producto: {respuesta}",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Producto guardado correctamente.",
                                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await MostrarProductos();
                    MostrarTab(tabLista.Name);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrió un error inesperado al guardar el producto. Intente nuevamente.",
                                "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProductos.Columns[e.ColumnIndex].Name == "ColumnaAccion")
            {
                var productoSeleccionado = (ProductosVM)dgvProductos.CurrentRow.DataBoundItem;
                txbCodigoEditar.Text = productoSeleccionado.Codigo.ToString();
                txbDescripcionEditar.Text = productoSeleccionado.Descripcion.ToString();
                txbPrecioCompraEditar.Text = productoSeleccionado.PrecioCompra.ToString();
                txbPrecioVentaEditar.Text = productoSeleccionado.PrecioVenta.ToString();
                txbCantidadEditar.Value = productoSeleccionado.Cantidad;
                cbbCategoriaEditar.EstablecerValor(productoSeleccionado.IdCategoria);
                cbbHabilitadoEditar.EstablecerValor(productoSeleccionado.Activo ? 1 : 0);

                MostrarTab(tabEditar.Name);
            }
        }

        //Boton Guardar ubicado en la vista de editar
        private async void btnGuardarEditar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validación: Codigo no puede estar vacío
                if (string.IsNullOrWhiteSpace(txbCodigoEditar.Text))
                {
                    MessageBox.Show("Por favor, ingrese un código para el producto.",
                                    "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validación: Descripción no puede estar vacía
                if (string.IsNullOrWhiteSpace(txbDescripcionEditar.Text))
                {
                    MessageBox.Show("Por favor, ingrese una descripción para el producto.",
                                    "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validación: categoria
                if (cbbCategoriaEditar.SelectedItem is not OpcionCombo opcionSeleccionada)
                {
                    MessageBox.Show("Debe seleccionar una categoría.",
                                    "Selección requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validación: Precio de compra
                if (string.IsNullOrWhiteSpace(txbPrecioCompraEditar.Text))
                {
                    MessageBox.Show("Por favor, ingrese un precio de compra.",
                                    "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validación: Precio de venta
                if (string.IsNullOrWhiteSpace(txbPrecioVentaEditar.Text))
                {
                    MessageBox.Show("Por favor, ingrese un precio de venta.",
                                    "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validación: Cantidad
                if (txbCantidadEditar.Value <= 0)
                {
                    MessageBox.Show("La cantidad debe ser mayor a cero.",
                                    "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Creación del objeto productos
                var productoSeleccionado = (ProductosVM)dgvProductos.CurrentRow.DataBoundItem;
                var item = (OpcionCombo)cbbCategoriaEditar.SelectedItem;
                var objeto = new Producto
                {
                    IdProducto = productoSeleccionado.IdProducto,
                    RefIdCategoria = new Categoria { IdCategoria = item.Valor },
                    Codigo = txbCodigoEditar.Text.Trim(),
                    Descripcion = txbDescripcionEditar.Text.Trim(),
                    PrecioCompra = decimal.Parse(txbPrecioCompraEditar.Text),
                    PrecioVenta = decimal.Parse(txbPrecioVentaEditar.Text),
                    Cantidad = txbCantidadEditar.Value,
                    Activo = (cbbHabilitadoEditar.SelectedItem as OpcionCombo)!.Valor == 1
                };


                // Llamada al servicio
                var respuesta = await _productoService.Editar(objeto);

                if (!string.IsNullOrEmpty(respuesta))
                {
                    MessageBox.Show($"No se pudieron guardar los cambios: {respuesta}",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Cambios guardados correctamente.",
                                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await MostrarProductos();
                    MostrarTab(tabLista.Name);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrió un error inesperado al guardar los cambios. Intente nuevamente.",
                                "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Boton Volver
        private void VolverNuevo_Click(object sender, EventArgs e)
        {
            MostrarTab(tabLista.Name);
        }

        // Boton Volver ubicado en la vista de editar
        private void btnVolverEditar_Click(object sender, EventArgs e)
        {
            MostrarTab(tabLista.Name);
        }

        // Boton nuevo
        private void btnNuevoLista_Click(object sender, EventArgs e)
        {
            MostrarTab(tabNuevo.Name);
            // Limpiar campos
            cbbCategoriaNuevo.SelectedIndex = 0;
            txbCodigoNuevo.Text = string.Empty;
            txbDescripcionNuevo.Text = string.Empty;
            txbPrecioCompraNuevo.Text = string.Empty;
            txbPrecioVentaNuevo.Text = string.Empty;
            txbCantidadNuevo.Value = 0;
            cbbCategoriaNuevo.Select();
        }
    }
}