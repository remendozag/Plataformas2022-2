namespace AppDoWhilePromedio
{
    class Program 
    {
        static void Main(string[] args) 
        {
            /*Escribir un programa que solicite  la carga de números 
             * por teclado,  obtener su promedio. Finalizar la  carga
             * de valores cuando se  cargue el valor 0.*/
            int numero, suma=0, contador=0;
            float promedio;
            Console.WriteLine("Programa Promedio sentencia Do While");
            do
            {
                Console.WriteLine("Digite Número");
                numero = int.Parse(Console.ReadLine());
                suma += numero;
                contador +=1;
            } while (numero != 0);
            promedio = suma / (contador-1);
            //Console.WriteLine("Suma:"+suma);
            //Console.WriteLine("Contador:" + contador);
            Console.WriteLine("Promedio:"+promedio);
            Console.ReadKey();
        }
    }
}
