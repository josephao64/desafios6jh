using System;

class Program
{
    static void Main(string[] args)
    {
        // función DescuentosPorCliente
        decimal[,] comprasClientes = new decimal[,] {
            { 200, 300, 1000, 500, 150 },
            { 50, 150, 70, 80, 90 },
            { 1200, 800, 1500, 900, 600 },
            { 90, 80, 70, 60, 50 },
            { 800, 900, 1100, 1300, 1500 }
        };

        decimal[] descuentos = DescuentosPorCliente(comprasClientes);

        Console.WriteLine("Descuentos por cliente:");
        for (int i = 0; i < descuentos.Length; i++)
        {
            Console.WriteLine($"Cliente {i + 1}: {descuentos[i]:C}");
        }
    }

    static decimal[] DescuentosPorCliente(decimal[,] comprasClientes)
    {
        decimal[] descuentos = new decimal[comprasClientes.GetLength(0)];

        for (int i = 0; i < comprasClientes.GetLength(0); i++)
        {
            decimal totalCompras = 0;

            for (int j = 0; j < comprasClientes.GetLength(1); j++)
            {
                totalCompras += comprasClientes[i, j];
            }

            if (totalCompras >= 100 && totalCompras <= 1000)
            {
                descuentos[i] = totalCompras * 0.1m;
            }
            else if (totalCompras > 1000)
            {
                descuentos[i] = totalCompras * 0.2m;
            }
        }

        return descuentos;
    }
}
