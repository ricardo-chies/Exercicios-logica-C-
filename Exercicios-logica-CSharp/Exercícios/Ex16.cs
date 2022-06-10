using System;


namespace Exercicios_logica_CSharp.Exercícios
{
    class Ex16
    {
        public //Exercício 16
        static void Main(string[] args)
        {
            Console.WriteLine("Iniciando programa");

            Console.WriteLine("Digite seu código de usuário:");
            int codigo = Convert.ToInt32(Console.ReadLine());

            Login(codigo);
            Console.ReadKey();

        }

        public static void Login(int codigo)
        {
            if (codigo == 1234)
            {
                Console.WriteLine("Digite sua senha:");
                int senha = Convert.ToInt32(Console.ReadLine());

                if (senha == 9999)
                {
                    Console.WriteLine("Acesso permitido, Seja bem vindo!");
                }
                else
                {
                    Console.WriteLine("Senha incorreta!");
                }
            }
            else
            {
                Console.WriteLine("Usuário inválido!");
            }

        }
    }
}