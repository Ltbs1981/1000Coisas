using System;

namespace atacadoOuVarejo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Boas vindas a loja 1000Coisas!");
            Console.WriteLine("Aqui na 1000Coisas, você pode escolher qualquer produto, quantidade e qualquer preço que você quiser pagar.");
            Console.WriteLine("Temos tudo o que você possa imaginar, basta escolher seu produto, quantidade e preço.\n Boas compras!");
            Console.WriteLine("O que você deseja?");
            string produto = Console.ReadLine();

            Console.WriteLine("Caso queira comprar em grande quantidade, temos os seguintes descontos:");
            Console.WriteLine("Até 10 unidades: valor total ");
            Console.WriteLine("De 11 a 20 unidades: 10% de desconto");
            Console.WriteLine("De 21 a 50 unidades: 20% de desconto ");
            Console.WriteLine("Acima de 50 unidades: 25% de desconto");
            Console.WriteLine($"Qual a quantidade de {produto}, você vai levar?");
            int quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine($"Aqui não é Casas Bahias, mas vor te perguntar, Vai querer pagar quanto em cada {produto}? R$:");
            double preco = double.Parse(Console.ReadLine());

            Abatimento.CalcularCompra(produto, quantidade, preco);
        }
    }
}
