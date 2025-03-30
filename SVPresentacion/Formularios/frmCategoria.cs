using SVPresentacion.Utilidades;
using SVPresentacion.Utilidades.Objetos;
using SVPresentacion.ViewModels;
using SVRespositorio.Entities;
using SVServices.Interfaces;
using System.Xml.Schema;

namespace SVPresentacion.Formularios
{
    public partial class frmCategoria : Form
    {
        private readonly IMedidaService _medidaService;
        private readonly ICategoriaService _categoriaService;

        public frmCategoria(ICategoriaService categoriaService, IMedidaService medidaService)
        {
            InitializeComponent();
            _categoriaService = categoriaService;
            _medidaService = medidaService;
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

        private async Task MostrarCategorias(string buscar = "")
        {
            try
            {
                var listacategoria = await _categoriaService.Lista(buscar);

                var listaVM = listacategoria.Select(x => new CategoriaVM
                {
                    IdCategoria = x.IdCategoria,
                    Nombre = x.Nombre,
                    IdMedida = x.RefIdMedida.IdMedida,
                    Medida = x.RefIdMedida.Nombre,
                    Activo = x.Activo,
                    Habilitado = x.Activo ? "Si" : "No"

                }).ToList();

                dgvCategorias.DataSource = listaVM;

                dgvCategorias.Columns["IdCategoria"].Visible = false;
                dgvCategorias.Columns["IdMedida"].Visible = false;
                dgvCategorias.Columns["Activo"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las categorias" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void frmCategoria_Load(object sender, EventArgs e)
        {
            MostrarTab(tabLista.Name);
            await CargarDatos();
        }

        private async Task CargarDatos()
        {
            try
            {
                await MostrarCategorias();
                dgvCategorias.ImplementarConfiguracion("Editar");
                dgvCategorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                OpcionCombo[] itemHabilitado = new OpcionCombo[]
                {
                    new OpcionCombo { Texto = "Si", Valor = 1 },
                    new OpcionCombo { Texto = "No", Valor = 0 }
                };

                var listaMedida = await _medidaService.Lista();

                var items = listaMedida.Select(item => new OpcionCombo
                {
                    Texto = item.Nombre,
                    Valor = item.IdMedida
                }).ToArray();

                cbbMedidaNuevo.InsertarItems(items);
                cbbMedidaEditar.InsertarItems(items);
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
            await MostrarCategorias(txtBuscar.Text);
        }

        // Boton Nuevo 
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txbNombreNuevo.Text = "";
            cbbMedidaNuevo.SelectedIndex = 0;
            txbNombreNuevo.Select();

            MostrarTab(tabNuevo.Name);
        }

        // Boton Guardar 
        private async void btnGuardarNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                // Validación: Nombre no puede estar vacío
                if (string.IsNullOrWhiteSpace(txbNombreNuevo.Text))
                {
                    MessageBox.Show("Por favor, ingrese un nombre para la categoría.",
                                    "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validación: Selección de medida
                if (cbbMedidaNuevo.SelectedItem is not OpcionCombo opcionSeleccionada)
                {
                    MessageBox.Show("Debe seleccionar una unidad de medida.",
                                    "Selección requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Creación del objeto categoría
                var item = (OpcionCombo)cbbMedidaNuevo.SelectedItem;
                var objeto = new Categoria
                {
                    Nombre = txbNombreNuevo.Text.Trim(),
                    RefIdMedida = new Medida { IdMedida = item.Valor }
                };

                // Llamada al servicio
                var respuesta = await _categoriaService.Crear(objeto);

                if (!string.IsNullOrEmpty(respuesta))
                {
                    MessageBox.Show($"No se pudo guardar la categoría: {respuesta}",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Categoría guardada correctamente.",
                                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await MostrarCategorias();
                    MostrarTab(tabLista.Name);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrió un error inesperado al guardar la categoría. Intente nuevamente.",
                                "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCategorias.Columns[e.ColumnIndex].Name == "ColumnaAccion")
            {
                var categoriaSeleccionada = (CategoriaVM)dgvCategorias.CurrentRow.DataBoundItem;
                txbEditar.Text = categoriaSeleccionada.Nombre.ToString();

                cbbMedidaEditar.EstablecerValor(categoriaSeleccionada.IdMedida);
                cbbHabilitadoEditar.EstablecerValor(categoriaSeleccionada.Activo ? 1 : 0);
                MostrarTab(tabEditar.Name);
                txbEditar.Select();
            }
        }

        // Boton Guardar ubicado en la vista de editar
        private async void btnGuardarEditar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validación: Nombre no puede estar vacío
                if (string.IsNullOrWhiteSpace(txbEditar.Text))
                {
                    MessageBox.Show("Por favor, ingrese un nombre para la categoría.",
                                    "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validación: Selección de medida
                if (cbbMedidaEditar.SelectedItem is not OpcionCombo opcionSeleccionada)
                {
                    MessageBox.Show("Debe seleccionar una unidad de medida.",
                                    "Selección requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Creación del objeto categoría
                var categoriaSeleccionada = (CategoriaVM)dgvCategorias.CurrentRow.DataBoundItem;
                var item = (OpcionCombo)cbbMedidaEditar.SelectedItem;
                var objeto = new Categoria
                {
                    IdCategoria = categoriaSeleccionada.IdCategoria,
                    Nombre = txbEditar.Text.Trim(),
                    RefIdMedida = new Medida { IdMedida = item.Valor },
                    Activo = (cbbHabilitadoEditar.SelectedItem as OpcionCombo)!.Valor == 1
                };

                // Llamada al servicio
                var respuesta = await _categoriaService.Editar(objeto);

                if (!string.IsNullOrEmpty(respuesta))
                {
                    MessageBox.Show($"No se pudieron guardar los cambios: {respuesta}",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Cambios guardados correctamente.",
                                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await MostrarCategorias();
                    MostrarTab(tabLista.Name);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrió un error inesperado al guardar los cambios. Intente nuevamente.",
                                "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Boton Volver 
        private void VolverNuevo_Click(object sender, EventArgs e)
        {
            MostrarTab(tabLista.Name);
        }

        // Boton Volver ubicado en la vista de edtiar 
        private void btnVolverEditar_Click(object sender, EventArgs e)
        {
            MostrarTab(tabLista.Name);
        }
    }
}