using System;

namespace GestorEstoqueOOP_Console
{
    class Program
    {
        enum Menu { Listar = 1, Adicionar, Remover, Entrada, Saida, Sair }
        static void Main(string[] args)
        {
            bool escolheuSair = false;
            while (escolheuSair == false)
            {
                Console.WriteLine("Sistema de estoque");
                Console.WriteLine("1-Listar\n2-Adicionar\n3-Remover\n4-Registrar entrada\n5-Registrar saída\n6-Sair");
                string opStr = Console.ReadLine();
                int opInt = int.Parse(opStr);

                if (opInt > 0 && opInt < 7)
                {
                    Menu escolha = (Menu)opInt;

                    switch (escolha)
                    {
                        case Menu.Listar:
                            break;
                        case Menu.Adicionar:
                            break;
                        case Menu.Remover:
                            break;
                        case Menu.Entrada:
                            break;
                        case Menu.Saida:
                            break;
                        case Menu.Sair:
                            escolheuSair = true;
                            break;
                    }
                } 
                else
                {
                    escolheuSair = true;
                }
            }
        }
    }
}
