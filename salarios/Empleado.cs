using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salarios
{
    class Empleado : Persona, Isalario
    {
        public double salario { get; set; }
        public Empleado(string nombre) {
            this.nombre = nombre;  
        }

        public override void CalcSalario(double horas)
        {
            this.salario = horas * 350;
        }

        public String getName() { return this.nombre; }
        public double getSalario() { return this.salario; }


    }
}
