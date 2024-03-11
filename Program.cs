using System;

namespace atacadoOuVarejo
{
    class Program
    {
        static void Main(string[] args)
        {
            string produto = "whisky Black Label";
            double preco = 100.00;
            
            Console.WriteLine("Boas vindas a loja 1000Coisas!");
            Console.WriteLine("O que você gostaria de comprar?");
            Console.WriteLine($"{produto}  R$ {preco}--.");
            Console.WriteLine("Caso queira comprar em grande quantidade, temos os seguintes descontos:");
            Console.WriteLine("Até 10 unidades: valor total ");
            Console.WriteLine("De 11 a 20 unidades: 10% de desconto");
            Console.WriteLine("De 21 a 50 unidades: 20% de desconto ");
            Console.WriteLine("Acima de 50 unidades: 25% de desconto");
            Console.WriteLine("Quantas unidades você vai querer?");
            int quantidade = int.Parse(Console.ReadLine());

            double subTotal = quantidade * preco;

            if (quantidade > 10 && quantidade <= 20)
            {
                double desconto = (subTotal / 100 * 10);
                double totalAPagar = subTotal - desconto;
                Console.WriteLine($"{produto} Quant: {quantidade} x {preco}");
                Console.WriteLine($"Sub-total R$: {subTotal}");
                                Console.WriteLine($"Desconto de 10%: {desconto}");
                Console.WriteLine($"Valor total a pagar: {totalAPagar}");
                
            }else if (quantidade >= 21 && quantidade <= 50)
            {
                double desconto = (subTotal / 100 * 20);
                double totalAPagar = subTotal - desconto;
                Console.WriteLine($"{produto} Quant: {quantidade} x {preco}");
                Console.WriteLine($"Sub-total R$: {subTotal}");
                Console.WriteLine($"Desconto de 20%: {desconto}");
                Console.WriteLine($"Valor total a pagar: {totalAPagar}");

            }
            else if (quantidade >= 51 )
            {
                double desconto = (subTotal / 100 * 25);
                double totalAPagar = subTotal - desconto;
                Console.WriteLine($"{produto} Quant: {quantidade} x {preco}");
                Console.WriteLine($"Sub-total R$: {subTotal}");
                Console.WriteLine($"Desconto de 25%: {desconto}");
                Console.WriteLine($"Valor total a pagar: {totalAPagar}");

            }else
            {
                Console.WriteLine($"{produto} Quant: {quantidade} x {preco}");
                Console.WriteLine($"Sub-total R$: {subTotal}");
                Console.WriteLine($"Valor total a pagar: {subTotal}");

            }
        }
    }
}
