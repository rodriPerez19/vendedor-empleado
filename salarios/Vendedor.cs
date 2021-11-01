using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salarios
{
    class Vendedor : Persona
    {
        public double salario { get; set; }

        public double comision { get; set; }

        public Vendedor(string nombre)
        {
            this.nombre = nombre;
        }

        public override void CalcSalario(double horas )
        {
            comision=Comision.calcComision(horas);
            this.salario = (horas * 400) + comision;
        }
        public string getName() { return this.nombre; }

        public double getSalario() { return this.salario; }
    }
}
