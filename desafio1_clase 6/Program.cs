using System;

namespace Totito
{
    class Program
    {
        static void Main()
        {
            char[,] tablero = new char[3, 3]; 
            int jugador = 1;
            bool perdiste = false;

     
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    tablero[i, j] = ' ';
                }
            }

           
            while (!perdiste)
            {
               
                Console.WriteLine("  1 2 3");
                for (int i = 0; i < 3; i++)
                {
                    Console.Write((i + 1) + " ");
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write(tablero[i, j] + " ");
                    }
                    Console.WriteLine();
                }

               
                Console.WriteLine("Jugador " + jugador + ", seleccione una casilla (fila,columna): ");
                string input = Console.ReadLine();
                int fila = int.Parse(input.Substring(0, 1)) - 1;
                int columna = int.Parse(input.Substring(2, 1)) - 1;

              
                if (tablero[fila, columna] != ' ')
                {
                    Console.WriteLine("Casilla ocupada, intente de nuevo.");
                    continue;
                }

                
                if (jugador == 1)
                {
                    tablero[fila, columna] = 'X';
                    jugador = 2;
                }
                else
                {
                    tablero[fila, columna] = 'O';
                    jugador = 1;
                }

                
                for (int i = 0; i < 3; i++)
                {
                    if (tablero[i, 0] == tablero[i, 1] && tablero[i, 1] == tablero[i, 2] && tablero[i, 0] != ' ')
                    {
                        Console.WriteLine("¡Jugador " + (tablero[i, 0] == 'X' ? "1" : "2") + " ha ganado!");
                        perdiste = true;
                    }
                    if (tablero[0, i] == tablero[1, i] && tablero[1, i] == tablero[2, i] && tablero[0, i] != ' ')
                    {
                        Console.WriteLine("¡Jugador " + (tablero[0, i] == 'X' ? "1" : "2") + " ha ganado!");
                        perdiste = true;
                    }
                }
                if (tablero[0, 0] == tablero[1, 1] && tablero[1, 1] == tablero[2, 2] && tablero[0, 0] != ' ')
                {
                    Console.WriteLine("¡Jugador " + (tablero[0, 0] == 'X' ? "1" : "2") + " ha ganado");
                        }
            }
        }
    }
}