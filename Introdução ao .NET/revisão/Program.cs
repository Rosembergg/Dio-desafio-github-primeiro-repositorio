using System;

namespace revisão
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[5];
            var indiceAluno = 0; 
            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        //Adicionar um aluno
                        Console.WriteLine("Digite nome do aluno:");
                        var aluno = new Aluno();
                        aluno.Nome = Console.ReadLine();

                        Console.WriteLine("Informe a nota do aluno:");

                        if (decimal.TryParse(Console.ReadLine(), out decimal nota))
                        {
                            aluno.Nota = (int)nota;
                        }
                        else
                        {
                            throw new ArgumentException("Valor da nota deve ser decimal!!!");
                        }
                         
                        alunos[indiceAluno] = aluno;
                        indiceAluno++;

                        break;

                    case "2":
                        foreach(var lstAluno in alunos)
                        {   
                            if(!string.IsNullOrEmpty(lstAluno.Nome))
                            {
                            Console.WriteLine("Aluno: "+lstAluno.Nome+" Nota: "+lstAluno.Nota);
                            }
                        }

                        break;

                    case "3":
                        //Somar e retornar a media somada
                            var notaTotal = 0;
                            var nrAlunos = 0;
                            for(int i = 0 ;i < alunos.Length; i ++)
                            {
                                if(!string.IsNullOrEmpty(alunos[i].Nome))
                                {
                                    notaTotal = notaTotal + alunos[i].Nota;
                                    nrAlunos ++;
                                }
                                var mediaGeral = notaTotal/nrAlunos;
                                Console.WriteLine("Media geral: " + mediaGeral);
                            }
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                       
                }


                     opcaoUsuario = ObterOpcaoUsuario();
            }
        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine("1- Inserir novo aluno");
            Console.WriteLine("2- Listar alunos");
            Console.WriteLine("3- Calcular media geral");
            Console.WriteLine("X- Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}
