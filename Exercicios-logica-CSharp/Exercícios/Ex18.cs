using System;


namespace Exercicios_logica_CSharp.Exercícios
{
    class Ex18
    {
        public //Exercício 18
        static void Main(string[] args)
        {
            Console.WriteLine("Iniciando programa");

            Console.WriteLine("Digite um número para saber o valor de sua tabuada:");
            float n = float.Parse(Console.ReadLine());

            Tabuada(n);
            Console.ReadKey();

        }

        public static void Tabuada(float n)
        {
            for (int tabuada = 0; tabuada <= 10; tabuada++)
            {
                float resultado = n * tabuada;
                Console.WriteLine("{0} x {1} = {2}", n, tabuada, resultado);
            }
        }
    }
}