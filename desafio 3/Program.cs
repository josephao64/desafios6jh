using System;
namespace primerdesafi0
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declarar arreglo bidimensional de montos de las últimas 5 compras de 5 clientes
            int[,] compras = new int[5, 5] {
                { 50, 75, 80, 95, 100 },
                { 120, 130, 140, 150, 160 },
                { 200, 300, 400, 500, 600 },
                { 800, 900, 1000, 1100, 1200 },
                { 1500, 1600, 1700, 1800, 1900 }
            };

            // Llamar al método que calcula los descuentos y muestra los resultados
            CalcularDescuentos(compras);
        }

        static void CalcularDescuentos(int[,] compras)
        {
            for (int i = 0; i < compras.GetLength(0); i++)
            {
                int totalCompras = 0;
                for (int j = 0; j < compras.GetLength(1); j++)
                {
                    totalCompras += compras[i, j];
                }

                double descuento = 0;
                if (totalCompras >= 100 && totalCompras <= 1000)
                {
                    descuento = 0.1;
                }
                else if (totalCompras > 1000)
                {
                    descuento = 0.2;
                }

                Console.WriteLine("Cliente {0}: Total compras = {1:C}, Descuento = {2:P}, Total con descuento = {3:C}", i + 1, totalCompras, descuento, totalCompras * (1 - descuento));
            }
        }
    }
}