using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2doParcial
{
    internal class Acciones
    {
        public List<Telefonos> ListaTelefonos = new List<Telefonos>();
        Telefonos cel = new Telefonos();


        public void AgregarTelefono()
        {

            Console.WriteLine("Almacenamiento");
            cel.Almacenamiento = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Año");
            cel.Año = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Precio");
            cel.Precio = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Color");
            cel.Color = Console.ReadLine();
            Console.WriteLine("Número de cámaras traseras");
            cel.NumeroCamaras = Convert.ToInt32(Console.ReadLine());

            ListaTelefonos.Add(new Telefonos(cel.Almacenamiento, cel.Año, cel.Precio, cel.Color, cel.NumeroCamaras));
        }
        public void MostrarTelefonos()
        {
            foreach (var t in ListaTelefonos)
            {
                Console.WriteLine($"Almacenamiento en gb: {t.Almacenamiento}");
                Console.WriteLine($"Año: {t.Año}");
                Console.WriteLine($"Precio en pesos: {t.Precio}");
                Console.WriteLine($"Color: {t.Color}");
                Console.WriteLine($"Número de cámaras traseras: {t.NumeroCamaras}");
            }
        }
        public void ActualizarTelefono(string color)
        {
            var telefono = ListaTelefonos.FirstOrDefault(x => x.Color == color);

            if (telefono != null)
            {
                Console.WriteLine("Ingrese los nuevos datos del teléfono:");
                Console.WriteLine("Nuevo almacenamiento:");
                telefono.Almacenamiento = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Nuevo año:");
                telefono.Año = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Nuevo precio:");
                telefono.Precio = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Nuevo color:");
                telefono.Color = Console.ReadLine();
                Console.WriteLine("Nuevo número de cámaras traseras");
                telefono.NumeroCamaras = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("El teléfono se actualizó con éxito");

            }
            else
            {
                Console.WriteLine("No se encontró un teléfono de ese color.");
            }
        }
        public void EliminarTelefono(string color)
        {
            var telefono = ListaTelefonos.FirstOrDefault(x =>x.Color == color);
            if (telefono != null)
            {
                ListaTelefonos.Remove(telefono);
            }
            else
            {
                Console.WriteLine("No se encuentra ese color");
            }
        }
    }
}
