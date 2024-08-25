using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Conexion;
using Clases;


namespace tpIntegrador
{
    public partial class Form1 : Form
    {
        private List<Articulo> listaArticulos; 
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            cargar(); 
            //ElementoNegocio negocioMarca = new ElementoNegocio();
            //dgvMarcas.DataSource = negocioMarca.listar(); 
            //Lo comentado fue para probar clase AccesoDatos
        }

        private void dgvArticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void cargar()//Función para refrescar una vez al articulo haya sido agregado.
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                listaArticulos = negocio.listaTraer();
                dgvArticulos.DataSource = listaArticulos;
                dgvArticulos.Columns["Imagen"].Visible = false;
                dgvArticulos.Columns["Id"].Visible = false; 
                cargarImagen(listaArticulos[0].Imagen);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvArticulos.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.Imagen);
            }
        }
        private void cargarImagen(string imagen) //Función para capturar excepción en el 
                                                 //caso de no poder cargar imagen.
        {
            try
            {
                pcBoxArticulos.Load(imagen);
            }
            catch (Exception )
            {
                pcBoxArticulos.Load("https://archive.org/download/placeholder-image/placeholder-image.jpg");
               
            } 
        }

        private void btnAgregarArticulo_Click(object sender, EventArgs e)
        {
            frmAltaArticulo nuevo = new frmAltaArticulo();
            nuevo.ShowDialog();
            cargar(); 
        }

        private void btnModificarArticulo_Click(object sender, EventArgs e)
        {

            try
            {

                Articulo seleccionado;
                if (dgvArticulos.CurrentRow == null){
                    MessageBox.Show("No se ha seleccionado un articulo");
                    cargar();
                }
                else
                {
                seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

                frmAltaArticulo modificar = new frmAltaArticulo(seleccionado);
                modificar.ShowDialog();
                cargar();

                }
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnEliminarFisico_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo seleccionado; 
            try
            {
                DialogResult respuesta = MessageBox.Show("¿Seguro que queres eliminarlo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(respuesta == DialogResult.Yes)
                {
                    if (dgvArticulos.CurrentRow == null)
                    {
                        MessageBox.Show("Debe seleccionar un articulo");
                        cargar();
                    }
                    else
                    {

                        seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                        negocio.eliminarArticulo(seleccionado.Id);
                        MessageBox.Show("¡Eliminado correctamente!");
                        cargar();
                    
                    }
                }
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void lblFiltro_Click(object sender, EventArgs e)
        {

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Por ahora nada");
        }

        private void txtFiltrar_KeyPress(object sender, KeyPressEventArgs e)
        {
         
        }

        private void txtFiltrar_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;
            string Filtro = txtFiltrar.Text;

            if (Filtro != "")
            {
                listaFiltrada = listaArticulos.FindAll(x => x.NombreArticulo.ToUpper().Contains(Filtro.ToUpper()) ||  x.Marca.Descripcion.ToUpper().Contains(Filtro.ToUpper()) || x.Descripcion.ToUpper().Contains(Filtro.ToUpper()));
            }
            else
            {
                listaFiltrada = listaArticulos;
            }


            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = listaFiltrada;
            dgvArticulos.Columns["Id"].Visible = false;
        }
    }
}
