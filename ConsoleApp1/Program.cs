using System;

namespace Course { 
    class Program { 
    
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();

            Console.WriteLine("dados da primeira pessoa:");
            Console.Write("nome: ");
            p1.nome = Console.ReadLine();
            Console.Write("idade: ");
            p1.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("dados da segunda pessoa:");
            Console.Write("nome: ");
            p2.nome = Console.ReadLine();
            Console.Write("idade: ");
            p2.idade = int.Parse(Console.ReadLine());

            if (p1.idade > p2.idade)
            {
                Console.WriteLine("pessoa mais velha: " + p1.nome);
            }
            else
            {
                Console.WriteLine("pessoa mais velha: " + p2.nome);
            }
        }
        
    }
}
