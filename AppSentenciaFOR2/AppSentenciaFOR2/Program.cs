/*Escribir un programa que lea n números enteros y calcule  
 * la cantidad de valores mayores o iguales a 1000.
*/
int limite, numero=0, mayores=0, menores=0;
Console.WriteLine("Programa Sentencia FOR");
Console.WriteLine("Digite limite de números:");
limite = int.Parse(Console.ReadLine());
for (int contador = 0; contador < limite; contador++) 
{
    Console.WriteLine("Digite número:");
    numero = int.Parse(Console.ReadLine());
    if (numero >= 1000)
    {
        mayores += 1;
    }
    else 
    {
        menores += 1;
    }
}
Console.WriteLine("Los números mayores son:" + mayores);
Console.WriteLine("Los números menores son:" + menores);
Console.ReadKey();
