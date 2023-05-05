using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoExemplar.Entities
{
    public class Menu
    {
        public static void ShowMenu()
        {
            int option;
            do
            {
                Console.WriteLine("--- SELECIONE UMA OPÇÃO --- \n");
                Console.WriteLine("===> 1 | CADASTRAR");
                Console.WriteLine("===> 2 | EDITAR");
                Console.WriteLine("===> 3 | LISTAR");
                Console.WriteLine("===> 4 | EXCLUIR");
                Console.WriteLine("===> 5 | SAIR");

                try
                {
                    option = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Entrada inválida. Tente novamente.");
                    option = 0;
                }

                switch (option)
                {
                    case 1:
                        Console.WriteLine("Opção 1 selecionada");
                        break;
                    case 2:
                        Console.WriteLine("Opção 2 selecionada");
                        break;
                    case 3:
                        Console.WriteLine("Opção 3 selecionada");
                        break;
                    case 4:
                        Console.WriteLine("Opção 4 selecionada");
                        break;
                    case 5:
                       System.Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Entrada inválida. Tente novamente.");
                        break;
                }
            }
            while (option != 5);
        }
    }
}
