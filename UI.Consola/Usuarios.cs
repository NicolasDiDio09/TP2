using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Logic;
using Business.Entities;

namespace UI.Consola
{
    public class Usuarios
    {
        private UsuarioLogic _usuarioNegocio;


        public UsuarioLogic UsuarioNegocio
        {
            get
            {
                return _usuarioNegocio;
            }
            set
            {
                _usuarioNegocio = value;
            }
        }

        public Usuarios()
        {
            
       
        }
        public void Menu()
        {
            Console.WriteLine("1– Listado General");
            Console.WriteLine("2– Consulta");
            Console.WriteLine("3– Agregar");
            Console.WriteLine("4 - Modificar");
            Console.WriteLine("5 - Eliminar");
            Console.WriteLine("6 - Salir");
            





        }

        public void ListadoGeneral()
        {
            Console.Clear();
            List<Usuario> lista = UsuarioNegocio.GetAll();
            foreach (Usuario usr in lista)
            {
                MostrarDatos(usr);
            }
                
            
            
        }

        
        public void MostrarDatos(Usuario usr)
        {
            Console.WriteLine("usuario: {0}", usr.ID);
            Console.WriteLine("\t\t nombre:{0}", usr.Nombre);
            Console.WriteLine("\t\t apellido:{0}", usr.Apellido);
            Console.WriteLine("\t\t nombre de usuario:{0}", usr.NombreUsuario);
            Console.WriteLine("\t\t clave:{0}", usr.Clave);
            Console.WriteLine("\t\t email:{0}", usr.Email);
            Console.WriteLine("\t\t habilitado:{0}", usr.Habilitado);
            Console.WriteLine("");
            // "\t" ES UN TAB en un string
             

        }









    }
}
