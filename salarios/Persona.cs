using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salarios
{
    public abstract class Persona: Isalario
    { 
        public String nombre { get; set; }

        public abstract void CalcSalario(double horas);
        
    }
}
