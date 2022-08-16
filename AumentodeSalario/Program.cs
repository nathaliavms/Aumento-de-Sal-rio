using System;
using System.Globalization;

namespace AumentodeSalario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o seu salário: ");
            var salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            SalarioReajustado calculo = new SalarioReajustado(salario);
 
            Console.WriteLine(calculo.ImprimirSalario());
            Console.WriteLine(calculo.ImprimirReajuste());
            Console.WriteLine(calculo.ImprimirPercentual());
        }
    }
}
