using System;


namespace Exercicios_logica_CSharp.Exercícios
{
    class Ex071
    {
        public static void Main(string[] args)
        {
            //Exercício 7.1

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

            ResultadoFinal(media);
            Console.ReadLine();

        }

        public static float MediaFinal(float num1, float num2, float num3, float num4)
        {

            float media = (num1 + num2 + num3 + num4) / 4;
            return media;

        }

        public static void ResultadoFinal(float media)
        {
            if (media < 5)
            {
                Console.WriteLine("O aluno está reprovado!");
            }
            else if (media <= 7)
            {
                Console.WriteLine("O aluno está de recuperação");
            }
            else
            {
                Console.WriteLine("O aluno está aprovado!");
            }
        }
    }
}