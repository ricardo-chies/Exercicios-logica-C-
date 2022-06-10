using System;


namespace Exercicios_logica_CSharp.Exercícios
{
    class Ex02
    {
        public static void Main(string[] args)
        {
            //Exercício 2

            Console.WriteLine("Escreva duas palavras para serem concatenadas");
            Console.WriteLine("Palavra 1");
            string p1 = Console.ReadLine();

            Console.WriteLine("Palavra 2");
            string p2 = Console.ReadLine();

            string resultado = Concatenar(p1, p2);

            Console.WriteLine("A junção das duas palavras é: " + resultado);
            Console.ReadLine();
        }

        public static string Concatenar(string p1, string p2)
        {
            string resultado = p1 + p2;
            return resultado;
        }
    }
}