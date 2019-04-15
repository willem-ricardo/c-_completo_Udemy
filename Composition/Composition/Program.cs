using System;
using System.Globalization;
using Composition.Entities;
using Composition.Entities.Enums;

namespace Composition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o nome do departamento: ");
            string departamento = Console.ReadLine();
            Console.WriteLine("\nInforme os dados do funcionário: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Nível (Junor/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Salário-base: ");
            double salario = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department department = new Department(departamento);
            Worker worker = new Worker(nome, level, salario, department);

            Console.Write("Quantos contratos tem o trabalhador? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Informe os dados do contrato #{i}:");
                Console.Write("Data (DD/MM/YYYY): ");
                DateTime data = DateTime.Parse(Console.ReadLine());
                Console.Write("Valor da hora trabalhada: ");
                double precoHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantidade de horas trabalhadas: ");
                int qtdeHoras = int.Parse(Console.ReadLine());

                HourContract contrato = new HourContract(data, precoHora, qtdeHoras);
                worker.Contracts.Add(contrato);
            }

            Console.WriteLine();
            Console.Write("Entre com o mês e o ano: ");
            string mesAno = Console.ReadLine();
            int mes = int.Parse(mesAno.Substring(0, 2));
            int ano = int.Parse(mesAno.Substring(3));

            Console.WriteLine();
            Console.WriteLine("Nome: " + worker.Name);
            Console.WriteLine("Departamento: " + worker.Department.Name);
            Console.WriteLine("Provimentos em " + mesAno + ": " + worker.Income(mes, ano));
        }
    }
}
