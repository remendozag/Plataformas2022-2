namespace SentenciaIF
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Realizar un programa que lea por teclado dos
             * números, si el primero es mayor al segundo 
             * informar su suma y diferencia, en caso 
             * contrario informar el producto y la división 
             * del primero respecto al segundo.
             */
            double numero1, numero2, suma, diferencia, producto, division;
            Console.WriteLine("Programa Mayor o Menor de 2 números");
            Console.WriteLine("Digite número 1:");
            numero1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite número 2:");
            numero2 = double.Parse(Console.ReadLine());
            if (numero1 > numero2)
            {
                suma = numero1 + numero2;
                diferencia = numero1 - numero2;
                Console.WriteLine("La suma:"+suma);
                Console.WriteLine("La diferencia:" + diferencia);
            }
            else 
            {
                producto= numero1 * numero2;
                division= numero1 / numero2;
                Console.WriteLine("El producto:" + producto);
                Console.WriteLine("La división:" + division);
            }
            Console.ReadKey();
        }
    }
}
           