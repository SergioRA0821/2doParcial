using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2doParcial
{
    internal class Program
    {
        //Sergio Reyes Alfaro

        public enum Menu
        {
            AgregarTel = 1, MostrarTel, ActualizarTel, EliminarTel, Salir
        }
        static void Main(string[] args)
        {
            Acciones acc = new Acciones();
            while (true)
            {
                switch (menu())
                {
                    case Menu.AgregarTel:
                        acc.AgregarTelefono();
                        break;
                    case Menu.MostrarTel:
                        acc.MostrarTelefonos();
                        break;
                    case Menu.ActualizarTel:
                        Console.WriteLine("De qué color es el teléfono que desea actualizar?");
                        string color = Console.ReadLine();
                        acc.ActualizarTelefono(color);
                        break;
                    case Menu.EliminarTel:
                        Console.WriteLine("De qué color es el teléfono que deseas eliminar?");
                        string color2 = Console.ReadLine();
                        acc.EliminarTelefono(color2);
                        break;
                    case Menu.Salir:
                        Environment.Exit(1);
                        break;
                    default:
                        Console.WriteLine("Número incorrecto...intenta con otro.");
                        break;
                }
            }
        }
        static Menu menu()
        {
            Console.WriteLine("Escoge la opción que quieras hacer:");
            Console.WriteLine("1) Agregar teléfono");
            Console.WriteLine("2) Mostrar teléfono");
            Console.WriteLine("3) Actualizar teléfono");
            Console.WriteLine("4) Eliminar teléfono");
            Console.WriteLine("5) Salir");

            Menu opc = (Menu)Convert.ToInt32(Console.ReadLine());
            return opc;
        }
    }
}
