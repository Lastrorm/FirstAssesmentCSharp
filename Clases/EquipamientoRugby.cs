using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAssesmentCSharp.Clases
{
    class EquipamientoRugby : EquipamientoDeportivo
    {
        public double peso;

        public EquipamientoRugby(string nombre, double precio, double peso) : base(nombre, precio)
        {
            this.peso = peso;
        }

        public override string Descripcion()
        {
            return $"Equipamiento para {nombre} con peso de {peso}, precio: {precio}";
        }
    }
}
