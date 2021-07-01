using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Business.Logic;

namespace UI.Consola
{
    public class Planes
    {
        public PlanLogic PlanNegocio { get; set; }

        public Planes()
        {
            PlanNegocio = new PlanLogic();
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
                Console.Write("Ingrese la ID del plan a modificar:");
                int id = int.Parse(Console.ReadLine());
                Plan p = PlanNegocio.GetOne(id);
                Console.Write("Ingrese descripcion del plan:");
                p.DescPlan = Console.ReadLine();
                Console.Write("Ingrese el id de la especialidad:");
                p.IDEspecialidad = int.Parse(Console.ReadLine());
                p.State = BusinessEntity.States.Modified;
                PlanNegocio.Save(p);
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

        public void ListadoGeneral()
        {

            foreach (Plan p in PlanNegocio.GetAll())
            {
                MostrarDatos(p);
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
                Console.Write("Ingre el ID de la materia a consultar:");
                int ID = int.Parse(Console.ReadLine());
                this.MostrarDatos(PlanNegocio.GetOne(ID));
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

        public void MostrarDatos(Plan p)
        {
            Console.WriteLine("Plan: {0}", p.ID);
            Console.WriteLine("\t\t Descripcion:{0}", p.DescPlan);
            Console.WriteLine("\t\t Id especialidad:{0}", p.IDEspecialidad);
            Console.WriteLine("");
            // "\t" ES UN TAB en un string
        }
        public void Agregar()
        {
            Plan p = new Plan();

            Console.Clear();
            Console.Write("Ingrese descripcion del plan: ");
            p.DescPlan = Console.ReadLine();
            Console.Write("Ingrese id especialidad: ");
            p.IDEspecialidad = int.Parse(Console.ReadLine());

            p.State = BusinessEntity.States.New;
            PlanNegocio.Save(p);
            Console.WriteLine();
            Console.WriteLine("ID: {0}", p.ID);

            Console.WriteLine("Pulse una tecla para continuar");
            Console.ReadKey();
            Console.Clear();

        }

        public void Eliminar()
        {
            try
            {
                Console.Clear();
                Console.Write("Ingrese el ID del plane a eliminar: ");
                int ID = int.Parse(Console.ReadLine());
                PlanNegocio.Delete(ID);
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
