using System;

namespace Aula_2_referencias
{
    class Program
    {
        static void Demo1()
        {
            int a = 5;
            Adicionar20(ref a);
            Console.WriteLine($"Valor e {a}");
        }

        static void Demo2()
        {
            var nomes = new string []{"Jose", "Maria", "Ricardo", "Alice", "Pedro"};

            Console.WriteLine($@"A lista de nomes é: 
                {string.Join(", \n",nomes)}
            ");

            Console.WriteLine("Digite nome a ser subistituido:");
            var nome = Console.ReadLine();
            Console.WriteLine("Digite nome novo:");
            var nomeNovo = Console.ReadLine();

            AlterarNome(nomes, nome, nomeNovo);

            Console.WriteLine($@"A lista de nomes alteradas é: 
                {string.Join(",\n",nomes)}
            ");
        }
        static void Adicionar20(ref int a)
        {
            a += 20;
        }

        static void  AlterarNome(string[] nomes, string nome, string nomeNovo)
        {
            for(int i  = 0; i<nomes.Length; i++)
            {
                if(nomes[i] == nome)
                {
                    nomes[i] = nomeNovo;
                }
            }
        }

        static int LocalizarNome(string[]nomes,string nome)
        {
            for(int i = 0; i<nomes.Length;i++)
            {
                if(nomes[i] == nome);
                {
                    return i;
                }
            }
            return -1;
        }

        static void Main(string[] args)
        {
            var nomes = new string []{"Jose", "Maria", "Ricardo", "Alice", "Pedro"};

            Console.WriteLine($@"A lista de nomes é: 
                {string.Join(", \n",nomes)}
            ");

            Console.WriteLine("Digite nome a ser subistituido:");
            var nome = Console.ReadLine();
            Console.WriteLine("Digite nome novo:");
            var nomeNovo = Console.ReadLine();


            var  indice = LocalizarNome(nomes,nome);
            if(indice >= 0)
            {
                 nomes[indice] = nomeNovo;
                 
                Console.WriteLine($@"A lista de nomes alteradas é: 
                    {string.Join(",\n",nomes)}
                ");
            }
            else
            {
                Console.WriteLine("Nome não encontrado"); 
            }



        }
    }
}
