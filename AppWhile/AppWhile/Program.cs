﻿namespace AppPiezas
{
    class Program
    {
        static void Main(string[] args) 
        
        {
            /*Una planta que fabrica perfiles de  hierro posee un 
             * lote de n piezas.  Confeccionar un programa que  pida
             * ingresar por teclado la  cantidad de piezas a procesar
             * y  luego ingrese la longitud de cada  perfil; sabiendo
             * que la pieza cuya  longitud esté comprendida en el  
             * rango de 1,20 y 1,30 son aptas.  Imprimir por pantalla
             * la cantidad  de piezas aptas que hay en el  lote.*/
            int piezas, aptas=0, contador;
            float longitud;
            Console.WriteLine("Programa Piezas");
            Console.WriteLine("Digite número de piezas;");
            piezas = int.Parse(Console.ReadLine());
            contador = 0;
            while (contador<piezas) 
            {
                Console.WriteLine("Digite longitud:");
                longitud = float.Parse(Console.ReadLine());
                if (longitud >=1.2 && longitud <= 1.3) 
                {
                    aptas += 1;
                }
                contador++;
            }
            Console.WriteLine("Son aptas"+aptas);
            Console.ReadKey();

        }
    }
}
