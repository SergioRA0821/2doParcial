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
