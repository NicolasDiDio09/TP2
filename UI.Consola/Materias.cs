using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Logic;
using Business.Entities;

namespace UI.Consola
{
    public class Materias
    {
        public MateriaLogic MateriaNegocio { get; set; }

        public Materias()
        {
            MateriaNegocio = new MateriaLogic();
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
                Materia mater = MateriaNegocio.GetOne(id);
                Console.Write("Ingrese descripcion de la materia:");
                mater.DescMateria = Console.ReadLine();
                Console.Write("Ingrese cantidad de horas semanales:");
                mater.HSSemanales = int.Parse(Console.ReadLine());
                Console.Write("Ingrese cantidad de horas totales:");
                mater.HSTotales = int.Parse(Console.ReadLine());
                Console.Write("Ingrese el id del plan:");
                mater.IDPlan = int.Parse(Console.ReadLine());
                mater.State = BusinessEntity.States.Modified;
                MateriaNegocio.Save(mater);
            }
            catch (FormatException fe)
            {
                Console.WriteLine();
                Console.WriteLine("La ID ingresadad debe ser un numero");
            }
            catch (Exception e)
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

            foreach (Materia mat in MateriaNegocio.GetAll())
            {
                MostrarDatos(mat);
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
                this.MostrarDatos(MateriaNegocio.GetOne(ID));
            }
            catch (FormatException fe)
            {
                Console.WriteLine();
                Console.WriteLine("La ID ingresada debe ser un numero");
            }
            catch (Exception e)
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

        public void MostrarDatos(Materia mat)
        {
            Console.WriteLine("Materia: {0}", mat.ID);
            Console.WriteLine("\t\t Descripcion:{0}", mat.DescMateria);
            Console.WriteLine("\t\t Horas semanales:{0}", mat.HSSemanales);
            Console.WriteLine("\t\t Horas totales:{0}", mat.HSTotales);
            Console.WriteLine("\t\t Id plan:{0}", mat.IDPlan);
            Console.WriteLine("");
            // "\t" ES UN TAB en un string
        }
        public void Agregar()
        {
            Materia mat = new Materia();

            Console.Clear();
            Console.Write("Ingrese descripcion de la materia: ");
            mat.DescMateria = Console.ReadLine();
            Console.Write("Ingrese cantidad de horas semanales: ");
            mat.HSSemanales = int.Parse(Console.ReadLine());
            Console.Write("Ingrese cantidad de horas totales: ");
            mat.HSTotales = int.Parse(Console.ReadLine());
            Console.Write("Ingrese id plan: ");
            mat.IDPlan = int.Parse(Console.ReadLine());

            mat.State = BusinessEntity.States.New;
            MateriaNegocio.Save(mat);
            Console.WriteLine();
            Console.WriteLine("ID: {0}", mat.ID);

            Console.WriteLine("Pulse una tecla para continuar");
            Console.ReadKey();
            Console.Clear();

        }

        public void Eliminar()
        {
            try
            {
                Console.Clear();
                Console.Write("Ingrese el ID de la materia a eliminar: ");
                int ID = int.Parse(Console.ReadLine());
                MateriaNegocio.Delete(ID);
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
