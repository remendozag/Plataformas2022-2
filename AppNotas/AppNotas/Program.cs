namespace Notas 
{
    class Program 
    {
        static void Main(string[] args) 
        {
            /*Se ingresan tres notas de un  alumno, 
             * si el promedio es  mayor o igual a tres 
             * mostrar  un mensaje "Promocionado".
            */
            float nota1, nota2, nota3, suma, promedio;
            Console.WriteLine("Programa de Notas");
            Console.WriteLine("Digite nota 1:");
            nota1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite nota 2:");
            nota2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite nota 3:");
            nota3 = float.Parse(Console.ReadLine());
            suma = nota1 + nota2 + nota3;
            promedio = suma / 3;
            if (promedio == 3)
            {
                Console.WriteLine("Promocionado");
            }
            else if(promedio>=4 && promedio <= 4.9)
            {
                Console.WriteLine("Bien");
            }
            else 
            {
                Console.WriteLine("No promocionado");
            }
            Console.ReadKey();
        }


        }
    }