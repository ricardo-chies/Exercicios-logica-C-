using System;


namespace Exercicios_logica_CSharp.Exercícios
{
    class Ex01
    {
        public static void Main(string[] args)
        {
            //Exercício 1

            Console.WriteLine("Escreva duas palavras para serem concatenadas");
            Console.WriteLine("Palavra 1");
            string p1 = Console.ReadLine();

            Console.WriteLine("Palavra 2");
            string p2 = Console.ReadLine();

            Concatenar(p1, p2);
        }

        public static void Concatenar(string p1, string p2)
        {
            string resultado = p1 + p2;
            Console.WriteLine("O resultado é: " + resultado);
            Console.ReadLine();
        }
    }
}