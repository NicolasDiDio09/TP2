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
        private Business.Logic.UsuarioLogic _UsuarioNegocio;
        public Business.Logic.UsuarioLogic UsuarioNegocio
        {
            get 
            { 
                return _UsuarioNegocio; 
            }
            set 
            { 
                _UsuarioNegocio = value; 
            }
        }

        public Usuarios()
        {
            UsuarioNegocio = new UsuarioLogic();
        }

        public void Menu()
        {
            
            Console.WriteLine("1– Listado General");
            Console.WriteLine("2– Consulta");
            Console.WriteLine("3– Agregar");
            Console.WriteLine("4- Modificar");
            Console.WriteLine("5- Eliminar");
            Console.WriteLine("6- Salir");

            ConsoleKeyInfo op = Console.ReadKey();

            switch (op.Key)
            {
                case ConsoleKey.D1:
                    ListadoGeneral();
                    break;
                case ConsoleKey.D2:
                    Consultar();
                    break;
                case ConsoleKey.D4:
                    Modificar();
                    break;
            }
            
        }

        public void Modificar()
        {
            try
            {
                Console.Clear();
                Console.Write("Ingrese la ID del usuario a modificar");
                int id = int.Parse(Console.ReadLine());
                Usuario user = UsuarioNegocio.GetOne(id);
                Console.Write("Ingrese Nombre:");
                user.Nombre = Console.ReadLine();
                Console.Write("Ingrese Apellido:");
                user.Apellido = Console.ReadLine();
                Console.Write("Ingrese Nombre de Usuario:");
                user.NombreUsuario = Console.ReadLine();
                Console.Write("Ingrese Clave:");
                user.Clave = Console.ReadLine();
                Console.Write("Ingrese Email:");
                user.Email = Console.ReadLine();
                Console.Write("Ingrese Habilitacion de Usuario (1-Si/otro- No):");
                user.Habilitado = (Console.ReadLine() == "1");
                user.State = BusinessEntity.States.Modified;
                UsuarioNegocio.Save(user);
            }
            catch(FormatException fe)
            {
                Console.WriteLine();
                Console.WriteLine("La ID ingresadad debe ser un numero");
            }
            catch(Exception e)
            {
                Console.WriteLine();
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Presione una tecla para continuar...");
                Console.ReadKey();
            }

        }

        public void ListadoGeneral()
        {
            Console.Clear();
            foreach (Usuario usr in UsuarioNegocio.GetAll())
            {
                MostrarDatos(usr);
            }
        }

        public void Consultar()
        {
            try
            {
                Console.Clear();
                Console.Write("Ingre el ID del usuario a consultar:");
                int ID = int.Parse(Console.ReadLine());
                this.MostrarDatos(UsuarioNegocio.GetOne(ID));
            }
            catch(FormatException fe)
            {
                Console.WriteLine();
                Console.WriteLine("La ID ingresada debe ser un numero");
            }
            catch(Exception e)
            {
                Console.WriteLine();
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Presione una tecla para continuar...");
                Console.ReadKey();
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
