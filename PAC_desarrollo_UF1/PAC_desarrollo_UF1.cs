using System;

namespace PAC_desarrollo_UF1
{
    class Program
    {
        static void Main(string[] args)
        {
            int filas1, columnas1;
            int filas2, columnas2;

            Console.WriteLine("Introduce el número de filas de la primera matriz:");
            filas1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce el número de columnas de la primera matriz:");
            columnas1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nIntroduce el número de filas de la segunda matriz:");
            filas2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce el número de columnas de la segunda matriz:");
            columnas2 = Convert.ToInt32(Console.ReadLine());

            int[,] matriz1 = new int[filas1, columnas1];
            int[,] matriz2 = new int[filas2, columnas2];

            Console.WriteLine("----------------------------------------------------------\n");

            for (int i = 0; i < matriz1.GetLength(0); i++)
            {
                for (int j = 0; j < matriz1.GetLength(1); j++)
                {
                    Console.WriteLine("Introduce el elemento en la posición " +
                        "( {0} {1} ) de la primera matriz:", (i+1),(j+1));
                    matriz1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < matriz2.GetLength(0); i++)
            {
                for (int j = 0; j < matriz2.GetLength(1); j++)
                {
                    Console.WriteLine("Introduce el elemento en la posición " +
                        "( {0} {1} ) de la segunda matriz:", (i + 1), (j + 1));
                    matriz2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }


            Console.WriteLine("\n----------------------------------------------------------");
            Console.WriteLine("El contenido de la primera matriz es:");
            for (int i = 0; i < matriz1.GetLength(0); i++)
            {
                Console.Write("( ");
                for (int j = 0; j < matriz1.GetLength(1); j++)
                {

                    Console.Write("  {0}  ",matriz1[i,j]);
                }
                Console.WriteLine(" )");
            }

            Console.WriteLine("\nEl contenido de la segunda matriz es:");
            for (int i = 0; i < matriz2.GetLength(0); i++)
            {
                Console.Write("( ");
                for (int j = 0; j < matriz2.GetLength(1); j++)
                {

                    Console.Write("  {0}  ", matriz2[i, j]);
                }
                Console.Write(" )\n");
            }

            Console.WriteLine("\n----------------------------------------------------------");
            /*Comparar matrices (comprobar si ambas matrices poseen las mismas dimensiones
             * y si da verdadero, comprobar si los valores de ambas son iguales*/
            //Declarar una variable de tipo booleano llamada "comparar":

            bool comparar = true;

            if (filas1 == filas2 && columnas1 == columnas2)
            {
                Console.WriteLine("Las matrices pueden ser comparadas");

                for (int i = 0; i < filas1; i++)
                {
                    for (int j = 0; j < columnas1; j++)
                    {
                        if (matriz1[i,j] != matriz2[i,j])
                        {
                            comparar = false;
                        }
                    }

                }

                if (comparar  == true)
                {
                    Console.WriteLine("Las matrices son iguales");
                }
                else
                {
                    Console.WriteLine("Las matrices no son iguales");
                }
            }

            else
            {
                Console.WriteLine("Las matrices no pueden ser comparadas");
            }

            Console.WriteLine("\n------------Pulsa cualquier tecla para finalizar-----------");
            Console.ReadKey();
        }
    }
}
