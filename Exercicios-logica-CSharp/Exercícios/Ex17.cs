using System;


namespace Exercicios_logica_CSharp.Exercícios
{
    class Ex17
    {
        public //Exercício 17
        static void Main(string[] args)
        {
            Console.WriteLine("Iniciando programa");

            Console.WriteLine("Digite seu código de usuário:");
            int codigoUsuario = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite seu ano de nascimento:");
            int anoNascimento = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite seu ano de ingresso na empresa:");
            int anoIngresso = Convert.ToInt32(Console.ReadLine());

            Aposentadoria(codigoUsuario, anoNascimento, anoIngresso);
            Console.ReadKey();

        }

        public static void Aposentadoria(int codigoUsuario, int anoNascimento, int AnoIngresso)
        {
            int idade = 2022 - anoNascimento;
            int tempoTrabalho = 2022 - AnoIngresso;

            if ((idade >= 65) || (tempoTrabalho >= 30))
            {
                Console.WriteLine("Usuário: {0}, Idade: {1}, Tempo de trabalho:{2}, Requerer Aposentadoria"
                    , codigoUsuario, idade, tempoTrabalho);
            }
            else if ((idade >= 60) && (tempoTrabalho >= 25))
            {
                Console.WriteLine("Usuário: {0}, Idade: {1}, Tempo de trabalho:{2}, Requerer Aposentadoria"
                    , codigoUsuario, idade, tempoTrabalho);
            }
            else
            {
                Console.WriteLine("Usuário: {0}, Idade: {1}, Tempo de trabalho:{2}, Não Requerer"
                    , codigoUsuario, idade, tempoTrabalho);
            }

        }
    }
}