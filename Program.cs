using System;

namespace Lista_de_Exercicios
{
    class Program
    {


        static void Main(string[] args)
        {

            // Exercicio 1

            int num1, num2, soma;

            Console.WriteLine(" escreva o primeiro valor a somar : ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine(" escreva o segundo  valor a somar : ");
            num2 = int.Parse(Console.ReadLine());

            soma = num1 + num2;

            Console.WriteLine(" o resultado da soma é: " + soma);

            //--------------------------------------------------------------------------------------

            // Exercicio 2


            double pi = 3.14159, r;

            Console.WriteLine(" digite o valor do raio para calcular a area: ");
            r = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Area = " + { (pi * (r * r)).ToString("0.0000")});


            //----------------------------------------------------------------------------------------

            // Exercicio 3

            int A, B, C, D, dif;


            Console.WriteLine("Digite o valor de A: ");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de B: ");
            B = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de C: ");
            C = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de D: ");
            D = int.Parse(Console.ReadLine());

            dif = (A * B - C * D);

            Console.WriteLine(" a diferenca é: " + dif);


            //----------------------------------------------------------------------------------------

            // Exercicio 4

            double NF, NH, HT;

            Console.WriteLine(" digite o número do funcionario: ");

            NF = int.Parse(Console.ReadLine());

            Console.WriteLine(" digite o número de horas trabalhadas : ");

            NH = int.Parse(Console.ReadLine());

            Console.WriteLine("digite o valor que  funcionario recebe por hora trabalhada: ");

            HT = double.Parse(Console.ReadLine());

            Console.WriteLine("número do funcionario:" + NF);
            Console.WriteLine("salário : R$ " + (NH * HT).ToString("0.00"));




            //----------------------------------------------------------------------------------------


            // Exercicio 5

            double A, B, C, pi = 3.14159;


            Console.WriteLine("digite o valor de A:");
            A = double.Parse(Console.ReadLine());

            Console.WriteLine("digite o valor de B:");
            B = double.Parse(Console.ReadLine());

            Console.WriteLine("digite o valor de C:");
            C = double.Parse(Console.ReadLine());



            Console.WriteLine("A área do triângulo retângulo é: " + ((A * C) / 2).ToString("0.000"));
            Console.WriteLine("A área do Circulo  é:" + (pi * (C * C)).ToString("0.000"));
            Console.WriteLine("A área do trapézio é:" + ((A + B) * C / 2).ToString("0.000"));
            Console.WriteLine("A área do quadrado é : " + (B * B).ToString("0.000"));
            Console.WriteLine("e área do retângulo é: " + (A * B).ToString("0.000")); // Exercicio 1

            int num1, num2, soma;

            Console.WriteLine(" escreva o primeiro valor a somar : ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine(" escreva o segundo  valor a somar : ");
            num2 = int.Parse(Console.ReadLine());

            soma = num1 + num2;

            Console.WriteLine(" o resultado da soma é: " + soma);

            //--------------------------------------------------------------------------------------

            // Exercicio 2


            double pi = 3.14159, r;

            Console.WriteLine(" digite o valor do raio para calcular a area: ");
            r = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Area = " + { (pi * (r * r)).ToString("0.0000")});


            //----------------------------------------------------------------------------------------

            // Exercicio 3

            int A, B, C, D, dif;


            Console.WriteLine("Digite o valor de A: ");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de B: ");
            B = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de C: ");
            C = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de D: ");
            D = int.Parse(Console.ReadLine());

            dif = (A * B - C * D);

            Console.WriteLine(" a diferenca é: " + dif);


            //----------------------------------------------------------------------------------------

            // Exercicio 4

            double NF, NH, HT;

            Console.WriteLine(" digite o número do funcionario: ");

            NF = int.Parse(Console.ReadLine());

            Console.WriteLine(" digite o número de horas trabalhadas : ");

            NH = int.Parse(Console.ReadLine());

            Console.WriteLine("digite o valor que  funcionario recebe por hora trabalhada: ");

            HT = double.Parse(Console.ReadLine());

            Console.WriteLine("número do funcionario:" + NF);
            Console.WriteLine("salário : R$ " + (NH * HT).ToString("0.00"));




            //----------------------------------------------------------------------------------------


            // Exercicio 5

            double A, B, C, pi = 3.14159;


            Console.WriteLine("digite o valor de A:");
            A = double.Parse(Console.ReadLine());

            Console.WriteLine("digite o valor de B:");
            B = double.Parse(Console.ReadLine());

            Console.WriteLine("digite o valor de C:");
            C = double.Parse(Console.ReadLine());



            Console.WriteLine("A área do triângulo retângulo é: " + ((A * C) / 2).ToString("0.000"));
            Console.WriteLine("A área do Circulo  é:" + (pi * (C * C)).ToString("0.000"));
            Console.WriteLine("A área do trapézio é:" + ((A + B) * C / 2).ToString("0.000"));
            Console.WriteLine("A área do quadrado é : " + (B * B).ToString("0.000"));
            Console.WriteLine("e área do retângulo é: " + (A * B).ToString("0.000"));




            //----------------------------------------------------------------------------------------
            //----------------------------------------------------------------------------------------







        }
    }
}
