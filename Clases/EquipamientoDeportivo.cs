using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAssesmentCSharp.Clases
{
    abstract class EquipamientoDeportivo
    {
        public string nombre;
        public double precio;

        public EquipamientoDeportivo(string nombre, double precio)
        {
            this.nombre = nombre;
            this.precio = precio;
        }

        public abstract string Descripcion();
    }
}