using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionario
{
    internal class Funcionario
    {
        public string Nome { get; set; }
        public string Cargo { get; set; }
        public double SalarioBruto { get; set; }
        public int HorasTrabalhadas { get; set; }

        public Funcionario(string nome, string cargo, double salarioBruto, int horasTrabalhadas)
        {
            Nome = nome;
            Cargo = cargo;
            SalarioBruto = salarioBruto;
            HorasTrabalhadas = horasTrabalhadas;
        }

        // Método para calcular salário líquido (desconto de 15%)
        public double CalcularSalarioLiquido()
        {
            return SalarioBruto * 0.85;
        }

        // Método para calcular hora extra (acima de 160h)
        public double CalcularHoraExtra(double valorHora)
        {
            if (HorasTrabalhadas > 160)
            {
                int horasExtras = HorasTrabalhadas - 160;
                return horasExtras * valorHora;
            }
            return 0;
        }

        public void DarAumento(double percentual)
        {
            SalarioBruto += SalarioBruto * (percentual / 100);
        }

        public void MostrarContracheque()
        {
            double salarioLiquido = CalcularSalarioLiquido();
            double horaExtra = CalcularHoraExtra(SalarioBruto / 160);

            Console.WriteLine("----- CONTRACHEQUE -----");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Cargo: {Cargo}");
            Console.WriteLine($"Salário Bruto: R$ {SalarioBruto:F2}");
            Console.WriteLine($"Horas Trabalhadas: {HorasTrabalhadas}");
            Console.WriteLine($"Hora Extra: R$ {horaExtra:F2}");
            Console.WriteLine($"Salário Líquido: R$ {salarioLiquido + horaExtra:F2}");
            Console.WriteLine("------------------------");
        }
    }
}
