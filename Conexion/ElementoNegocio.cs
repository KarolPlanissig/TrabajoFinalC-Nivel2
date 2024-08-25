using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Clases;

namespace Conexion
{
    public class ElementoNegocio
    {
        public int Id { get; set; }

        public List<Marcas> listarMarcas()
        {
            List<Marcas> listaMarcas = new List<Marcas>();
            AccesoDatos datos = new AccesoDatos(); //Nace con objetos ya que la clase
                                                   // tiene un constructor.
            try
            {
                datos.setearConsulta("Select Id, Descripcion From MARCAS");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Marcas aux = new Marcas();

                    aux.Id = (int)datos.Lector["Id"];
                   
                        
             
                    aux.Descripcion = (string)datos.Lector["Descripcion"];

                    listaMarcas.Add(aux); 
                
                }

                return listaMarcas; 
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion(); 
            }
           
        }

        public List <Categorias> listarCategoria()
        {
            List<Categorias> listaCategoria = new List<Categorias>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Select Id, Descripcion FROM CATEGORIAS");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Categorias aux = new Categorias();

                    aux.Id = (int)datos.Lector["Id"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];

                    listaCategoria.Add(aux);

                }
                return listaCategoria;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
                
            }
        }
    }
}
