using System;

namespace Poo_static
{
    class Program
    {
        static void Main(string[] args)
        {
            // Classes estáticas não podem ser instânciadas

            // Em que momento usamos classes estáticas?

            // Quando precisamos de uma solução que pode servir
            // para qualquer tipo de aplicação

            // Em que momento não usamos classes estáticas?
            // Quando tivermos objetos/classes que são específicas de um tipo de aplicação

            string resposta;

            Console.Clear();
            Console.WriteLine("---- Sistema de conversão----");
            Console.WriteLine("Selecione uma das opções abaixo para realizar a conversão:");

            do
            {

                Console.WriteLine("");
                Console.WriteLine("[1] - converter Dólar para Real ");
                Console.WriteLine("[2] - converter Real para Dólar ");
                Console.WriteLine("[3] - converter Euro para Real  ");
                Console.WriteLine("[4] - converter Real para Euro  ");
                int escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1:

                        Console.WriteLine("Digite um valor para converter: ");

                        Conversor.valorUsuario = float.Parse(Console.ReadLine());

                        // Console.WriteLine(Math.Pow(2, 5));

                        Console.WriteLine(Conversor.ConverterDolarParaReal());


                        // default: resposta = Console.ReadLine();
                        break;

                    case 2:

                        Console.WriteLine("Digite um valor para converter: ");

                        Conversor.valorUsuario = float.Parse(Console.ReadLine());

                        Console.WriteLine(Conversor.ConverterRealParaDolar());

                        break;

                    case 3:

                        Console.WriteLine("Digite um valor para converter: ");

                        Conversor.valorUsuario = float.Parse(Console.ReadLine());

                        Console.WriteLine(Conversor.ConverterEuroParaReal());

                        break;

                    case 4:

                        Console.WriteLine("Digite um valor para converter: ");

                        Conversor.valorUsuario = float.Parse(Console.ReadLine());

                        Console.WriteLine(Conversor.ConverterRealParaEuro());

                        break;

                }

                Console.WriteLine("Deseja realizar outra conversão? s/n");
                resposta = (Console.ReadLine());

            } while (resposta == "s");

            Console.WriteLine("Programa encerrado!");

            // static void Testar()
            // este método tbm tem que ser static na sua declaração
            {

            }
        }
    }
}