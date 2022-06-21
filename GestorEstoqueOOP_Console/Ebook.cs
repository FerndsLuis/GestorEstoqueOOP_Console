using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorEstoqueOOP_Console
{
    [System.Serializable]
    class Ebook : Produto, IEstoque
    {
        public string autor;
        private int vendas;

        public Ebook(string nome, float preco, string autor)
        {
            this.nome = nome;
            this.preco = preco;
            this.autor = autor;
        }

        public void AdicionarEntrada()
        {
            Console.WriteLine("Não é possível dar entrada por ser um produto digital.");
            Console.ReadLine();
           
        }

        public void AdicionarSaida()
        {
            Console.WriteLine($"Adicionar vendas no ebook {nome}");
            Console.WriteLine("Digite a quantidade de vendas que quer dar entrada: ");
            int entrada = int.Parse(Console.ReadLine());

            vendas = vendas + entrada;

            Console.WriteLine("Venda Registrada");
            Console.ReadLine();
        }

        public void Exibir()
        {
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Autor: {autor}");
            Console.WriteLine($"Preço: {preco}");
            Console.WriteLine($"Vendas: {vendas}");
            Console.WriteLine("===========================");
        }
    }
}
