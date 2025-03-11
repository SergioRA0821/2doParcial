using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2doParcial
{
    internal class Telefonos
    {
        public Telefonos(int almacenamiento, int año, double precio, string color, int numeroCamaras)
        {
            Almacenamiento = almacenamiento;
            Año = año;
            Precio = precio;
            Color = color;
            NumeroCamaras = numeroCamaras;
        }
        public Telefonos() { }

        public int Almacenamiento { get; set; }
        public int Año { get; set; }
        public double Precio { get; set; }
        public string Color { get; set; }
        public int NumeroCamaras { get; set; }
    }
}
