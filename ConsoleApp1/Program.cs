using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*

            // questão 01 - Conversão de Celsius p/ Fahrenheit.

            double celsius,
                   fahrenheit;

            Console.WriteLine("Por favor, digite a temperatura em Celsius");
            celsius = Double.Parse(Console.ReadLine());

            fahrenheit = (celsius * 1.8) + 32;

            Console.WriteLine("A temperatura em Fahrenheit é de: " + fahrenheit + " ºF");
            Console.ReadKey();


            // questão 02 - Salário Líquido de um professor.

            double valorHoraAula,
                   numeroDeHorasAula,
                   descontoInss,
                   salarioBruto,
                   salarioLiquido;

            Console.WriteLine("Por favor, digite o valor da hora/aula: ");
            valorHoraAula = Double.Parse(Console.ReadLine());

            Console.WriteLine("Por favor, digite o número de horas de aula ministradas: ");
            numeroDeHorasAula = Double.Parse(Console.ReadLine());

            Console.WriteLine("Por favor, digite a porcentagem de desconto do INSS: ");
            descontoInss = Double.Parse(Console.ReadLine());

            salarioBruto = valorHoraAula * numeroDeHorasAula;
            salarioLiquido = salarioBruto - (salarioBruto * (descontoInss / 100));

            Console.WriteLine("O salário líquido do professor é: {0}", salarioLiquido);
            Console.ReadKey();


            // questão 03 - Número positivo, Raiz. Número negativo, Quadrado.

            double numero,
                   raizQuadrada,
                   quadradoDoNumero;


            Console.WriteLine("Por favor, digite um número inteiro (Negativo ou positivo): ");
            numero = Double.Parse(Console.ReadLine());

            if (numero >= 0)
            {
                raizQuadrada = Math.Sqrt(numero);
                Console.WriteLine("A raiz quadrado do número digitado é: {0}", raizQuadrada);
            }
            else
            {
                quadradoDoNumero = Math.Pow(numero, 2);
                Console.WriteLine("O quadrado do número digitado é: {0}", quadradoDoNumero);
            }

            Console.ReadKey();


            // questão 04 - Área de um círculo.

            const double pi = 3.1415;
            double raio,
                   area;

            Console.WriteLine("Digite, por favor, o valor do raio: ");
            raio = Double.Parse(Console.ReadLine());

            area = pi * Math.Pow(raio, 2);

            Console.WriteLine("A área do círculo de raio " + raio + " é = " + area);
            Console.ReadKey();


            // questão 05 - Idade do usuário

            int anoNascimento,
                anoAtual,
                idadeAtual,
                idade2022;

            Console.WriteLine("Digite seu ano de nascimento: ");
            anoNascimento = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o ano atual: ");
            anoAtual = int.Parse(Console.ReadLine());

            idadeAtual = anoAtual - anoNascimento;
            idade2022 = 2022 - anoNascimento;

            Console.WriteLine("A sua idade atual é {0}", idadeAtual);
            Console.WriteLine("A sua idade em 2022 será {0}", idade2022);

            Console.ReadKey();


            // questão 06 - Preço final de um veículo.

            double precoFabrica,
                   lucroDistribuidor,
                   percentualImposto,
                   precoFinal;

            Console.WriteLine("Preço de Fábrica do veículo: ");
            precoFabrica = Double.Parse(Console.ReadLine());

            Console.WriteLine("Percentual de Lucro do distribuidor (%): ");
            lucroDistribuidor = Double.Parse(Console.ReadLine());

            Console.WriteLine("Percentual de Imposto (%): ");
            percentualImposto = Double.Parse(Console.ReadLine());

            lucroDistribuidor = (precoFabrica * lucroDistribuidor) / 100;
            percentualImposto = (precoFabrica * percentualImposto) / 100;
            precoFinal        = (precoFabrica + lucroDistribuidor + percentualImposto);

            Console.WriteLine("a) Valor do lucro do distribuidor: {0}", lucroDistribuidor);
            Console.WriteLine("b) Valor do imposto aplicado: {0}", percentualImposto);
            Console.WriteLine("c) Preço Final do veículo: {0}", precoFinal);

            Console.ReadKey();

            // questão 07 - Quantidade de degraus a subir

            double alturaDegrau,
                   alturaTotal,
                   quantidadeDegraus;

            Console.WriteLine("Digite a altura de cada degrau, em centímetros: ");
            alturaDegrau = Double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a altura total que deseja alcançar, em centímetros: ");
            alturaTotal = Double.Parse(Console.ReadLine());

            quantidadeDegraus = alturaTotal / alturaDegrau;

            Console.WriteLine("Você deverá subir " + quantidadeDegraus + " para alcançar a altura desejada");

            Console.ReadKey();


            // questão 08 - Salário a receber, a apartir das regras de cálculo

            double numeroHorasTrabalhadas,
                   salarioMinimo,
                   valorHoraTrabalhada,
                   salarioBruto,
                   salarioReceber;

            Console.WriteLine("Digite o número de horas trabalhadas: ");
            numeroHorasTrabalhadas = Double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do salário mínimo: ");
            salarioMinimo = Double.Parse(Console.ReadLine());

            valorHoraTrabalhada = salarioMinimo / (30 * 8);

            salarioBruto = numeroHorasTrabalhadas * valorHoraTrabalhada;

            salarioReceber = salarioBruto - ((salarioBruto * 3) / 100);

            Console.WriteLine("O salário a receber é de: " + Math.Round(salarioReceber, 2).ToString());

            Console.ReadKey();


            // questão 09 - Ganhando um brinde no sorteio

            Random sorteio = new Random();
            int resultado = sorteio.Next(1, 4);

            switch (resultado)
            {
                case 1:
                    Console.WriteLine("Parabéns! Você ganhou um notebook Lenovo T14");
                    break;
                case 2:
                    Console.WriteLine("Parabéns! Você ganhou uma bicicleta Caloi Aro 29");
                    break;
                case 3:
                    Console.WriteLine("Parabéns! Você ganhou um PS4!");
                    break;
                case 4:
                    Console.WriteLine("Parabéns! Você ganhou um Moto G60s");
                    break;
            }

            */
        }
    }
}//
