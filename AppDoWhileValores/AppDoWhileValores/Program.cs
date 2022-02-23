namespace AppDoWhileValores 
{
    class Program 
    {
        static void Main(string[] args) 
        {
            /*Realizar un  programa que acumule (sume)	valores
            ingresados por teclado hasta  ingresar el 9999 
            (no sumar dicho  valor, indica que ha finalizado la  
            carga). Imprimir el valor  acumulado e informar si dicho
            valor es cero, mayor a cero o  menor a cero.*/
            int numero, suma=0, contador=0;
            Console.WriteLine("Programa Valores Acumulados");
            do
            {
                Console.WriteLine("Digite valor:");
                numero = int.Parse(Console.ReadLine());
                if (numero != 9999) 
                {
                    suma += numero;
                }
                contador += 1;
            }
            while (numero!=9999);
            if (suma == 0)
            {
                Console.WriteLine("La suma es igual a 0:" + suma);
            }
            else if (suma <= 0)
            {
                Console.WriteLine("La suma es menor que 0:" + suma);
            }
            else 
            {
                Console.WriteLine("La suma es mayor que 0:" + suma);
            }
            Console.ReadKey();

        }
    }
}
