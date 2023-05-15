using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAssesmentCSharp.Clases
{
    class EquipamientoFutbol : EquipamientoDeportivo
    {
        public string talla;

        public EquipamientoFutbol(string nombre, double precio, string talla) : base(nombre, precio)
        {
            this.talla = talla;
        }

        public override string Descripcion()
        {
            return $"Equipamiento para {nombre}, talla {talla}, precio: {precio}";
        }
    }
}
