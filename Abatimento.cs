using System;
using System.Collections.Generic;
using System.Text;

namespace atacadoOuVarejo
{
    class Abatimento
    {
        public static void CalcularCompra(string produto, int quantidade, double preco)
        {
            Console.WriteLine($"{produto}-{quantidade}R$ {preco}");

            double subTotal = quantidade * preco;
            double desconto = 0;

            if (quantidade > 10 && quantidade <= 20)
            {
                desconto = subTotal * 0.1;
            }
            else if (quantidade >= 21 && quantidade <= 50)
            {
                desconto = subTotal * 0.2;
            }
            else if (quantidade >= 51)
            {
                desconto = subTotal * 0.25;
            }

            double totalAPagar = subTotal - desconto;

            Console.WriteLine($"{produto} Quant: {quantidade} x {preco}");
            Console.WriteLine($"Sub-total R$: {subTotal}");
            Console.WriteLine($"Desconto: {desconto}");
            Console.WriteLine($"Valor total a pagar: {totalAPagar}");
            Console.WriteLine("Obigado e volte sempre...");
        }
    }
}