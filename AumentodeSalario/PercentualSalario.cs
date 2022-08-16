using System;
using System.Globalization;

namespace AumentodeSalario
{
    class SalarioReajustado
    {
        public double Salario { get; set; }
        public double Reajuste { get; set; }
        public double Percentual { get; set; }

        public SalarioReajustado(double salario)
        {
            Salario = salario;
        }

        public double CalculoSalario()
        {
            if (Salario <= 400.00)
            {
                Reajuste = Salario * 15 / 100;
                Salario += Reajuste;
                Percentual = 15;
                return Salario;
            }
            else if (Salario < 800.01)
            {
                Reajuste = Salario * 12 / 100;
                Salario += Reajuste;
                Percentual = 12;
                return Salario;
            }
            else if (Salario < 1200.01)
            {
                Reajuste = Salario * 10 / 100;
                Salario += Reajuste;
                Percentual = 10;
                return Salario;
            }
            else if (Salario < 2000.01)
            {
                Reajuste = Salario * 7 / 100;
                Salario += Reajuste;
                Percentual = 7;
                return Salario;
            }
            else
            {
                Reajuste = Salario * 4 / 100;
                Salario += Reajuste;
                Percentual = 4;
                return Salario;
            }
        }

        public string ImprimirSalario()
        {
            return "Novo salario: "
                + CalculoSalario().ToString("F2", CultureInfo.InvariantCulture);
        }

        public string ImprimirReajuste()
        {
            return "Reajuste ganho: "
                + Reajuste.ToString("F2", CultureInfo.InvariantCulture);
        }

        public string ImprimirPercentual()
        {
            return "Em percentual: "
                + Percentual
                + " %";
        }

    }
}
