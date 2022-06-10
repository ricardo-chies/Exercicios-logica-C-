using System;


namespace Exercicios_logica_CSharp.Exercícios
{
    class Ex04
    {
        public static void Main(string[] args)
        {
            //Exercício 4

            Console.WriteLine("Vamos realizar a média de um aluno a partir de 4 notas");
            Console.WriteLine("Informe a nota 1");
            float num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe a nota 2");
            float num2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe a nota 3");
            float num3 = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe a nota 4");
            float num4 = float.Parse(Console.ReadLine());

            float media = MediaFinal(num1, num2, num3, num4);

            Console.WriteLine("A média final é: " + media);
            Console.ReadLine();

        }

        public static float MediaFinal(float num1, float num2, float num3, float num4)
        {


            float media = (num1 + num2 + num3 + num4) / 4;
            return media;

        }
    }
}