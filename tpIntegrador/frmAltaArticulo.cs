using Clases;
using Conexion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Configuration; 

namespace tpIntegrador
{
    public partial class frmAltaArticulo : Form
    {
        private Articulo articulo = null;
        private OpenFileDialog archivo = null; 
        public frmAltaArticulo()
        {
            InitializeComponent();
        }
        public frmAltaArticulo(Articulo modificar)
        {
            InitializeComponent();
            this.articulo = modificar;
            Text = "Modificar articulo"; 
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close(); 
        }
        private bool validarInfo()
        {
            if (string.IsNullOrEmpty(txtCodigoNuevo.Text))
            {
                MessageBox.Show("Cargue el código del articulo, por favor");
                return true;
            }

            if (string.IsNullOrEmpty(txtNombreNuevo.Text))
            {
                MessageBox.Show("Cargue el nombre del articulo, por favor");
                return true;
            }
            if (string.IsNullOrEmpty(txtDescipcionNuevo.Text))
            {
                MessageBox.Show("Cargue la descripción del articulo, por favor");
                return true;
            }
            if (string.IsNullOrEmpty(txtPrecioNuevo.Text))
            {
                MessageBox.Show("Cargue el precio del articulo, por favor");
                return true; 
            }
            return false; 
        }
       

        private void btnAgregarNuevo_Click(object sender, EventArgs e)
        {
            //Articulo articulo = new Articulo();
            ArticuloNegocio negocioNuevo = new ArticuloNegocio();
            try
            {
                if(articulo == null)
                    articulo = new Articulo();

                if (validarInfo())
                    return; 
               
                articulo.codigoArticulo = txtCodigoNuevo.Text;
                articulo.NombreArticulo = txtNombreNuevo.Text;
                articulo.Descripcion = txtDescipcionNuevo.Text;
                articulo.Imagen = txtImagenNuevo.Text;
                articulo.Precio = decimal.Parse(txtPrecioNuevo.Text);
                articulo.Marca = (Marcas)cmboxMarca.SelectedItem;
                articulo.Categoria = (Categorias)cmboxCategoria.SelectedItem;
                
                if(articulo.Id != 0)
                {
                    negocioNuevo.modificarArticulo(articulo);
                    MessageBox.Show("¡Modificado exitosamente!");
                }
                else
                {
                    negocioNuevo.agregarArticulo(articulo);
                    MessageBox.Show("¡Agregado exitosamente!");
                }

                if (archivo != null && !(txtImagenNuevo.Text.ToUpper().Contains("HTTP"))) //Si la url contiene HTTP, quiere decir
                                                                                          // que no estamos levantando una imagen local.
                {
                    File.Copy(archivo.FileName, ConfigurationManager.AppSettings["articulosApp"] + archivo.SafeFileName);
                }
                
                Close(); 

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString()); 
            }
        }

        private void lblPrecioNuevo_Click(object sender, EventArgs e)
        {

        }
        private void frmAltaArticulo_Load(object sender, EventArgs e)
        {
            ElementoNegocio cargar = new ElementoNegocio();
        
            try
            {
                cmboxMarca.DataSource = cargar.listarMarcas();
                cmboxMarca.ValueMember = "Id";
                cmboxMarca.DisplayMember = "Descripcion";
                cmboxCategoria.DataSource = cargar.listarCategoria();
                cmboxCategoria.ValueMember = "Id";
                cmboxCategoria.DisplayMember = "Descripcion"; 

                if(articulo != null)
                {
                    txtCodigoNuevo.Text = articulo.codigoArticulo;
                    txtNombreNuevo.Text = articulo.NombreArticulo; 
                    txtDescipcionNuevo.Text = articulo.Descripcion;
                    cargarImagen(articulo.Imagen);
                    txtPrecioNuevo.Text = articulo.Precio.ToString();
                    cmboxCategoria.SelectedValue = articulo.Categoria.Id;
                    cmboxMarca.SelectedValue = articulo.Marca.Id; 
                }
            }
            catch (Exception ex)
            {
        
                MessageBox.Show(ex.ToString());
            }
        }
        private void cargarImagen(string imagen) //Función para capturar excepción en el 
                                                 //caso de no poder cargar imagen.
        {
            try
            {
                pcBoxArticulo.Load(imagen);
            }
            catch (Exception)
            {
                pcBoxArticulo.Load("https://archive.org/download/placeholder-image/placeholder-image.jpg");

            }
        }
        private void txtImagenNuevo_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtImagenNuevo.Text);
        }

        private void pcBoxArticulo_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog(); //Genera una ventana de dialogo.
            archivo.Filter = "JPEG|*.JPEG";
            archivo.ShowDialog(); 
            if (archivo.ShowDialog() == DialogResult.OK)
            {
                txtImagenNuevo.Text = archivo.FileName;
                cargarImagen(archivo.FileName);

                //Ahora guardo la imagen
                //File.Copy(archivo.FileName, ConfigurationManager.AppSettings["articulosApp"]+ archivo.SafeFileName); 
            }
        }

        private void txtPrecioNuevo_KeyPress(object sender, KeyPressEventArgs e) 
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8) //Validación que hace que solo admita números. 
                e.Handled = true;
        }
    }
}
