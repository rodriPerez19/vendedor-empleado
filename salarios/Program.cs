using System;

namespace salarios
{
    class Program
    {
        static void Main(string[] args)
        {
            String tipo,nombre;
            double horas;

            Console.WriteLine("Ingrese el tipo de persona a consultar el salario \n e: empleado \n v: vendeedor");
            tipo = Console.ReadLine();

            if (tipo == "e")
            {
                Console.WriteLine("Ingrese el nombre de su empleado");
                nombre = Console.ReadLine();
                Console.WriteLine("Ingrese las horas trabajadas de " + nombre);
                horas = Convert.ToDouble(Console.ReadLine());

                Empleado empleado = new Empleado(nombre);

                empleado.CalcSalario(horas);

                Console.WriteLine("El salario de " + empleado.getName() + " es de " + empleado.getSalario());

            }
            else {
                Console.WriteLine("Ingrese el nombre de su vendedor");
                nombre = Console.ReadLine();
                Console.WriteLine("Ingrese las horas trabajadas de " + nombre);
                horas = Convert.ToDouble(Console.ReadLine());

                Vendedor vendedor = new Vendedor(nombre);

                vendedor.CalcSalario(horas);

                Console.WriteLine("El salario de " + vendedor.getName() + " es de " + vendedor.getSalario());
            }      
        }
    }
}
