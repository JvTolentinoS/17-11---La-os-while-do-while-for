using System;

namespace _17_11___La_os_while_do_while_for
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Menu de Opções");
            Console.WriteLine("Escolha um opção de bebida abaixo");
            Console.WriteLine("1 - Coca Cola");
            Console.WriteLine("2 - Pepsi");
            Console.WriteLine("3 - Fanta");
            Console.WriteLine("4 - Água");
            int resposta = int.Parse(Console.ReadLine());


            switch(resposta)
            {
                case 1:
                Console.WriteLine("Você gostaria com gelo? Sim ou Não");
                string gelo = Console.ReadLine();
                if(gelo == "sim"){
                    Console.WriteLine("Será enviado uma COCA-COLA para sua mesa com gelo");
                }else{
                    Console.WriteLine("Será enviada uma COCA-COLA para sua mesa sem cubos de gelos.");
                }
                break;

                case 2:
                Console.WriteLine("Será enviado uma PEPSI para sua mesa");
                break;

                case 3:
                Console.WriteLine("Será enviado uma Fanta para sua mesa");
                break;

                case 4:
                Console.WriteLine("Será enviado uma Água para sua mesa");
                break;

                default:
                Console.WriteLine("Opção Inválida");
                break;
            }
        }
    }
}
