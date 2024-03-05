using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace salarioLiquido
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            
            
           
            

            Console.WriteLine("Informe seu salário bruto: ");
            int salario = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor do vale alimentação: ");
            int aliment = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o número de filhos: ");
            int filhos = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor recebido por cada filho: ");
            int ValorFilhos = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantidade de horas feitas: ");
            int HrExtra = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor recebido por cada hora extra trabalhada: ");
            int ValorhrExtra = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor do INSS: ");
            int INSS = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor do IRPF: ");
            int IRPF = int.Parse(Console.ReadLine());

            salario = salario + aliment;
            filhos = filhos * ValorFilhos;
            HrExtra = HrExtra * ValorhrExtra;
            salario = salario + HrExtra;
            salario = salario + filhos;
            salario = salario - INSS;
            salario = salario - IRPF;

           

            Console.WriteLine("o Seu salario liquido é de " + salario);
            Console.ReadKey();





        }
    }
}
