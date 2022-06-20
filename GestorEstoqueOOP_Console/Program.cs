using System;
using System.Collections.Generic;

namespace GestorEstoqueOOP_Console
{
    class Program
    {
        static List<IEstoque> produtos = new List<IEstoque>();
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
                            Cadastro();
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
                Console.Clear();
            }
        }

        static void Cadastro()
        {
            Console.WriteLine("Cadastro de produtos");
            Console.WriteLine("1- produto Fisico\n2- Produto Ebook\n3- Curso");
            String opStr = Console.ReadLine();

            int escolhaInt = int.Parse(opStr);
            switch (escolhaInt)
            {
                case 1:
                    CadastrarPFisico();
                    break;
                case 2:
                    CadastrarEbook();
                    break;
                case 3:
                    CadastrarCurso();
                    break;
            }
        }

        static void CadastrarPFisico()
        {
            Console.WriteLine("Cadastrando produto físico: ");
           
            Console.WriteLine("Nome: ");
            string nome = Console.ReadLine();
           
            Console.WriteLine("Preço: ");
            float preco = float.Parse(Console.ReadLine());

            Console.WriteLine("Frete: ");
            float frete = float.Parse(Console.ReadLine());

            ProdutoFisico pf = new ProdutoFisico(nome, preco, frete);
            produtos.Add(pf);
        }

        static void CadastrarEbook()
        {
            Console.WriteLine("Cadastrando ebook: ");

            Console.WriteLine("Nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Autor: ");
            string autor = Console.ReadLine();

            Console.WriteLine("Preço: ");
            float preco = float.Parse(Console.ReadLine());


            Ebook eb = new Ebook(nome, preco, autor);
            produtos.Add(eb);
        }

        static void CadastrarCurso()
        {
            Console.WriteLine("Cadastrando Curso: ");

            Console.WriteLine("Nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Autor: ");
            string autor = Console.ReadLine();

            Console.WriteLine("Preço: ");
            float preco = float.Parse(Console.ReadLine());


            Curso cs = new Curso(nome, preco, autor);
            produtos.Add(cs);
        }
    }
}
