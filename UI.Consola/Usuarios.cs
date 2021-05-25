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
            bool romperwhile = false;
            do
            {
                Console.WriteLine("1– Listado General");
                Console.WriteLine("2– Consulta");
                Console.WriteLine("3– Agregar");
                Console.WriteLine("4- Modificar");
                Console.WriteLine("5- Eliminar");
                Console.WriteLine("6- Salir");

                try
                {
                    ConsoleKeyInfo op = Console.ReadKey();
                    Console.Clear();
                    switch (op.Key)
                    {
                        case ConsoleKey.D1:
                            ListadoGeneral();
                            break;
                        case ConsoleKey.D2:
                            Consultar();
                            break;
                        case ConsoleKey.D3:
                            Agregar();
                            break;
                        case ConsoleKey.D4:
                            Modificar();
                            break;
                        case ConsoleKey.D5:
                            Eliminar();
                            break;
                        case ConsoleKey.D6:
                            romperwhile = true;
                            break;
                               // Para hacerlo con el numpad c:
                        case ConsoleKey.NumPad1:
                            ListadoGeneral();
                            break;
                        case ConsoleKey.NumPad2:
                            Consultar();
                            break;
                        case ConsoleKey.NumPad3:
                            Agregar();
                            break;
                        case ConsoleKey.NumPad4:
                            Modificar();
                            break;
                        case ConsoleKey.NumPad5:
                            Eliminar();
                            break;
                        case ConsoleKey.NumPad6:
                            romperwhile = true;
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("");
                    Console.WriteLine(e.Message);
                }

            } while (romperwhile == false);
        }

        public void Modificar()
        {
            try
            {
                Console.Clear();
                Console.Write("Ingrese la ID del usuario a modificar:");
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
                Console.Clear();
            }

        }

        public void ListadoGeneral()
        {
           
            foreach (Usuario usr in UsuarioNegocio.GetAll())
            {
                MostrarDatos(usr);
            }

            Console.WriteLine("Pulse una tecla para continuar");
            Console.ReadKey();
            Console.Clear();
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
                Console.Clear();
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
        public void Agregar()
        {
            Usuario usuario = new Usuario();

            Console.Clear();
            Console.Write("Ingrese Nombre: ");
            usuario.Nombre = Console.ReadLine();
            Console.Write("Ingrese Apellido: ");
            usuario.Apellido = Console.ReadLine();
            Console.Write("Ingrese Nombre de Usuario: ");
            usuario.NombreUsuario = Console.ReadLine();
            Console.Write("Ingrese Clave: ");
            usuario.Clave = Console.ReadLine();
            Console.Write("Ingrese Email: ");
            usuario.Email = Console.ReadLine();
            Console.Write("Ingrese Habilitacion de Usuario (1-Si/Otro-No): ");
            usuario.Habilitado = (Console.ReadLine()=="1");
            usuario.State = BusinessEntity.States.New;
            UsuarioNegocio.Save(usuario);
            Console.WriteLine();
            Console.WriteLine("ID: {0}",usuario.ID);

            Console.WriteLine("Pulse una tecla para continuar");
            Console.ReadKey();
            Console.Clear();

        }

        public void Eliminar()
        {
            try
            {
                Console.Clear();
                Console.Write("Ingrese el ID del usuario a eliminar: ");
                int ID = int.Parse(Console.ReadLine());
                UsuarioNegocio.Delete(ID);
            }
            catch (FormatException fe)
            {
                Console.WriteLine();
                Console.WriteLine("La ID ingresada debe ser un número entero ");
            }

            catch (Exception e)
            {
                Console.WriteLine();
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Presione una tecla para continuar");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
