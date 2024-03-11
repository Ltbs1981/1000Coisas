using System;

namespace atacadoOuVarejo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Boas vindas a loja 1000Coisas!");
            Console.WriteLine("\n");
            Console.WriteLine("O que você gostaria de comprar?");
            Console.WriteLine("Martelo --R$ 37,00--.");
            Console.WriteLine("Caso queira comprar em grande quantidade, temos os seguintes descontos:");
            Console.WriteLine("Até 10 unidades: valor total ");
            Console.WriteLine("De 11 a 20 unidades: 10% de desconto");
            Console.WriteLine("De 21 a 50 unidades: 20% de desconto ");
            Console.WriteLine("Acima de 50 unidades: 25% de desconto");
            Console.WriteLine("Quantas unidades você vai querer?");
            int quantidade = int.Parse(Console.ReadLine());
            double preco = 10.00;
            double subTotal = quantidade * preco;
            double descontoDezPorcento = (subTotal / 100 * 20 );
            double vr10 = subTotal - descontoDezPorcento;
            Console.WriteLine(vr10);

            Console.WriteLine(subTotal);
            Console.WriteLine(descontoDezPorcento);

        }
    }
}
