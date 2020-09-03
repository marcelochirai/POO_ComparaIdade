using System;

namespace ComparaIdadePessoas
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1, p2;  //Declaração das variáveis.
            
            p1 =new Pessoa();   //Atribuição de classe.
            p2 =new Pessoa();
            
            Console.Write("Informe o nome da primeira pessoa: ");
            p1.Nome = Console.ReadLine();
            Console.Write("Informe a idade: ");
            p1.Idade = int.Parse(Console.ReadLine());
            Console.Write("Informe o nome da segunda pessoa: ");
            p2.Nome = Console.ReadLine();
            Console.Write("Informe a idade: ");
            p2.Idade = int.Parse(Console.ReadLine());

            if (p1.Idade > p2.Idade)
            {
                Console.WriteLine("A pessoa mais velha é " + p1.Nome);
            }
            else if (p1.Idade<p2.Idade)
            {
                Console.WriteLine("A pessoa mais velha é " + p2.Nome);
            }
            else
            {
                Console.WriteLine("Ambas têm a mesma idade");
            }
            Console.ReadKey();
        }
    }
}
