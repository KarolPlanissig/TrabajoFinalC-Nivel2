using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel; 

namespace Clases
{
    public class Articulo
    {

        public int Id { get; set; }
        [DisplayName ("Código de articulo")]
        public string codigoArticulo { get; set; }
        [DisplayName ("Nombre de articulo")]
        public string NombreArticulo { get; set; }
        [DisplayName ("Descripción")]
        public string Descripcion { get; set; }
        [DisplayName ("Imagén")]
        public string Imagen { get; set; }
        public decimal Precio { get; set; }
        public Marcas Marca { get; set; }

        [DisplayName ("Categoría")]
        public Categorias Categoria { get; set; }
    }
}
