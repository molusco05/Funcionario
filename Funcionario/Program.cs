using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionario
{
     class Program
    {
        static void Main(string[] args)
        {
            
            Funcionario f = new Funcionario("João", "Desenvolvedor", 3000, 170);

            f.DarAumento(10);

            double salarioLiquido = f.CalcularSalarioLiquido();

            f.MostrarContracheque();
        }
    }
}
