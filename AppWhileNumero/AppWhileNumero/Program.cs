// See https://aka.ms/new-console-template for more information
namespace AppWhileNumero 
{
    class Program 
    {
        static void Main(string[] args) 
        {
            /*
             * Escribir un programa que solicite la  carga de un 
             * valor positivo y nos  muestre desde 1 hasta el valor
             * ingresado de uno en uno.  Ejemplo: Si ingresamos 30 
             * se debe  mostrar en pantalla los números del  1 al 30.
             */
            int numero, contador=0;
            Console.WriteLine("Programa Incremento Número:");
            Console.WriteLine("Digite Número:");
            numero = Math.Abs(int.Parse(Console.ReadLine()));
            while (contador < numero) 
            {
                contador++;
                Console.Write(contador+" - ");
            }
            Console.ReadKey();
        }
    }

}
