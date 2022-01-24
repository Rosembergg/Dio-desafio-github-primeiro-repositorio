using System;
using static System.Console;

namespace Tipos_de_referencias
{
    class Program
    {

        static void TrocarNome(Pessoa p1, string nomeNovo)
        {
            p1.Nome = nomeNovo;
        }
        static int Adicionar20 (int x)
        {
            return x+20;
        }
        static void TrocarNome(string nome, string nomeNovo)
        {
            nome = nomeNovo;
        }
        static void MudarParaImpar(int[] impar)
        {
            for(int i =0; i <impar.Length; i ++)
            {
                impar[i] = impar[i] + 1;
            }
        }
        public static void Demo1()
        {
            int a = 2;
            a = Adicionar20(a);
            WriteLine($"O valor da variavel e {a}");
        }
        public static void Demo2()

        {
            Pessoa p1 =new Pessoa();
            p1.Nome = "Rosemberg";
            p1.Idade = 22;
            p1.Documento = "13568893606";
            TrocarNome(p1,"Rafael");

            WriteLine($"Novo nem é: {p1.Nome}");
        }
        public static void Demo3()
        {
            string nome = "Rafael";
            TrocarNome(nome, "Rosemberg");
            WriteLine($"Nome novo:{nome}");
        }
        public static void Demo4()
        {
            int[] pares = new int []{0,2,4,6,8};
            MudarParaImpar(pares);
            WriteLine($"Os impares {string.Join(",",pares)}");
        }

        static int EncontrarNumero(int[] numeros, int numero)
        {  
            for (int i = 0; i <numeros.Length; i++)
            {
                if(numeros[i] == numero)
                {  
                    return i;
                }
            }
            return -1;
        }

        public static void Main()
        {
            int [] numeros = new int [] {0,2,4,6,8};
            WriteLine($"Digite o número que gostaria de encontrar:");
            var numero = int.Parse (ReadLine());
            var idxEncontrado = EncontrarNumero(numeros,numero);

            
            //if(idxEncontrado == -1)
            //{
            //    WriteLine("Numero não existe");
            //}
                WriteLine($"O numero digitado esta na posição{idxEncontrado}");

           // else
            //{
            //    WriteLine("Numero não encontrado");                
            //}
        }
    }
}
