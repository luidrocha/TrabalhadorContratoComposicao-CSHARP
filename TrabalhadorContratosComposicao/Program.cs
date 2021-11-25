using System;
using TrabalhadorContratosComposicao.Entities;
using TrabalhadorContratosComposicao.Entities.Enums;
using System.Globalization;

namespace TrabalhadorContratosComposicao
{
    class Program
    {
        static void Main(string[] args)
        {
            HourContract contracts = new HourContract();
            
            Console.Write("Entre com o Departamento do Funcionario: ");
            string dptoFunc = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Entre com os dados do Funcionario:");
            Console.WriteLine();

            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Nivel (Junior/Pleno/Senior: ");

            WorkLevel nivel = (WorkLevel) Enum.Parse(typeof(WorkLevel),Console.ReadLine());
            Console.Write("Salario Base: ");
            double salBase = double.Parse(Console.ReadLine());
            
            Console.WriteLine();

            Department department = new Department(dptoFunc);
            Worker objfunc = new Worker( nome,  department, nivel,  salBase);

            Console.Write("Quantos contratos para este Funcionarios ? :");
            int n = int.Parse(Console.ReadLine());

            for (int x = 1; x <= n; x++)
            {
                Console.Write($" Digite a data do Contrato #{x} :");
                DateTime dtContrato = DateTime.Parse(Console.ReadLine());

                Console.Write(" Digite o valor por hora do Contrato: ");
                double valHora = double.Parse(Console.ReadLine());

                Console.Write(" Digite o Total de Horas do Contrato: ");
                int totHorasContrato = int.Parse(Console.ReadLine());

                contracts = new HourContract(dtContrato, valHora, totHorasContrato);
                objfunc.AdContrato(contracts);
            }

            Console.Write("Digite a data para calcular o Recebimento: ");
            string databusca = Console.ReadLine();

            int mes = int.Parse(databusca.Substring(0, 2));
            int ano = int.Parse(databusca.Substring(3, 4));

            Console.WriteLine("Dados do Trabalhador: ");

            Console.WriteLine("Nome: " + objfunc.Nome);
            Console.WriteLine("Departmento: " + objfunc.Departamento.nomeDep);
            Console.WriteLine("Ganho para a data" + mes + "/" + ano + ": " 
            + objfunc.TotalReceber(mes,ano).ToString("F2",CultureInfo.InvariantCulture));
            

        }
    }
}
