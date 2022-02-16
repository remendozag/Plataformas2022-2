namespace  SentenciaIF
{
    class Program 
    { 
        static void Main(string[] args) 
        {
            /*Se ingresa por teclado un número positivo 
             * de uno o dos dígitos (1..99) mostrar un mensaje
             * indicando si el número tiene uno o dos dígitos
             * (Tener en cuenta que condición debe cumplirse 
             * para tener dos dígitos, un número entero)
             */
            int numero;
            Console.WriteLine("Digite número (1-99):");
            numero = int.Parse(Console.ReadLine());
            if (numero < 10)
            {
                Console.WriteLine("El numero tiene un dígito");
            }
            else if (numero <= 99)
            {
                Console.WriteLine("El número tiene dos dígitos");
            }
            else 
            {
                Console.WriteLine("El número tiene más de dos dígitos");
            }
            Console.ReadKey();
        }
    }

}
