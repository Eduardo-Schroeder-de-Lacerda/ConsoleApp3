using System;
namespace Projeto
{
    public class Calculadora
    {
        public static void Iniciar()
        {

            double valor1 = 0.0;
            double valor2 = 0.0;
            double resultado = 0.0;
            bool menu = true;
            int continuarOperando = 0;

            // Menu da C#LCUL#TOR
            while (menu == true)
            {

                Console.WriteLine("----------BEM VINDO À C#LCUL#TOR----------" +
                    "\n O que deseja?" +
                    "\n [1] Usar C#LCUL#TOR" +
                    "\n [0] Sair");
                int menuOperacao = int.Parse(Console.ReadLine());

                // Calculadora
                if (valor1 == 0 && menuOperacao == 1)
                {
                    Console.WriteLine("Digite um valor");
                    valor1 = double.Parse(Console.ReadLine());
                }
                // While para manter o resultado obtido e poder continuar operado-o
                bool menuValor1 = true;
                while (menuValor1 == true && menuOperacao == 1)
                {
                    Console.WriteLine("Que operação você deseja fazer?" +
                        "\n [+] Soma" +
                        "\n [-] Subtração" +
                        "\n [*] Multiplicação" +
                        "\n [/] Divisão" +
                        "\n [0] Sair");
                    string operador = Console.ReadLine();

                    switch (operador)
                    {
                        case "+":
                            OperacaoSoma(ref valor1, out valor2, out resultado, ref continuarOperando, ref menuValor1, operador);
                            break;
                        case "-":
                            OperacaoSubtracao(ref valor1, out valor2, out resultado, ref continuarOperando, ref menuValor1, operador);
                            break;
                        case "*":
                            OperacaoMultiplicacao(ref valor1, out valor2, out resultado, ref continuarOperando, ref menuValor1, operador);
                            break;
                        case "/":
                            OperacaoDivisao(ref valor1, out valor2, out resultado, ref continuarOperando, ref menuValor1, operador);
                            break;
                        case "0":
                            menuValor1 = false;
                            valor1 = 0;
                            break;
                        default:
                            Console.WriteLine("Digite uma opção válida");
                            Console.ReadLine();
                            break;
                    }
                }
                if (menuOperacao == 0)
                {
                    menu = false;
                    Console.WriteLine("----------OBRIGADO POR USAR C#LCUL#TOR----------");
                    Console.ReadLine();
                }
            }
        }

        private static void OperacaoDivisao(ref double valor1, out double valor2, out double resultado, ref int continuarOperando, ref bool menuValor1, string operador)
        {
            // Proíbido dividir por 0
            valor2 = 0;
            while (valor2 == 0)
            {
                Console.WriteLine("Por quanto você quer DIVIDIR? Este valor não pode ser 0");
                valor2 = double.Parse(Console.ReadLine());
            }

            resultado = (valor1 / valor2);

            Console.WriteLine("----------------------------\n" +
                valor1 + " " + operador + " " + valor2 + " = " + resultado +
                "\n----------------------------");
            Console.ReadLine();

            ContinuarOperacao(ref valor1, resultado, ref continuarOperando, ref menuValor1);
        }

        private static void OperacaoMultiplicacao(ref double valor1, out double valor2, out double resultado, ref int continuarOperando, ref bool menuValor1, string operador)
        {
            Console.WriteLine("Por quanto você quer MULTIPLICAR?");
            valor2 = double.Parse(Console.ReadLine());

            resultado = (valor1 * valor2);

            Console.WriteLine("----------------------------\n" +
                valor1 + " " + operador + " " + valor2 + " = " + resultado +
                "\n----------------------------");
            Console.ReadLine();

            ContinuarOperacao(ref valor1, resultado, ref continuarOperando, ref menuValor1);
        }

        private static void OperacaoSubtracao(ref double valor1, out double valor2, out double resultado, ref int continuarOperando, ref bool menuValor1, string operador)
        {
            Console.WriteLine("Por quanto você quer SUBTRAIR?");
            valor2 = double.Parse(Console.ReadLine());

            resultado = (valor1 - valor2);

            Console.WriteLine("----------------------------\n" +
                valor1 + " " + operador + " " + valor2 + " = " + resultado +
                "\n----------------------------");
            Console.ReadLine();

            ContinuarOperacao(ref valor1, resultado, ref continuarOperando, ref menuValor1);
        }

        private static void OperacaoSoma(ref double valor1, out double valor2, out double resultado, ref int continuarOperando, ref bool menuValor1, string operador)
        {
            Console.WriteLine("Por quanto você quer SOMAR?");
            valor2 = double.Parse(Console.ReadLine());

            resultado = (valor1 + valor2);

            Console.WriteLine("----------------------------\n" +
                valor1 + " " + operador + " " + valor2 + " = " + resultado +
                "\n----------------------------");
            Console.ReadLine();
            ContinuarOperacao(ref valor1, resultado, ref continuarOperando, ref menuValor1);
        }

        // Método para verificar se o usuário quer reutilizar o resultado da operação anterior
        private static void ContinuarOperacao(ref double valor1, double resultado, ref int continuarOperando, ref bool menuValor1)
        {
            bool manterOperacao = true;
            while (manterOperacao == true)
            {
                Console.WriteLine("Deseja continuar operando este resultado?" +
                "\n [1] Sim" +
                "\n [0] Não");
                continuarOperando = int.Parse(Console.ReadLine());

                if (continuarOperando == 1)
                {
                    valor1 = resultado;
                    manterOperacao = false;
                }
                if (continuarOperando == 0)
                {
                    manterOperacao = false;
                    menuValor1 = false;
                    valor1 = 0;
                }
            }
        }
    }
}