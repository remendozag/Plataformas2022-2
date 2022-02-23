/*Escribir un programa que lea  n notas de un estudiante y nos  
 * informe cuántos tienen  notas mayores o iguales a 3  y 
 * cuántos menores. Utilizar vectores y forEach.
*/
int limite, mayores=0, menores=0;
float nota;
Console.WriteLine("Sentencia ForEach Notas");
Console.WriteLine("Digite limite de notas:");
limite = int.Parse(Console.ReadLine());
float[] notas=new float[limite];//instanciar notas
for (int conta = 1; conta <= limite; conta++) 
{
    Console.WriteLine("Digitar nota "+conta+":");
    nota = float.Parse(Console.ReadLine());
    notas[conta-1] = nota;
} ;
foreach (float nota2 in notas) 
{
    if (nota2 >= 3)
    {
        mayores += 1;
    }
    else
    {
        menores += 1;
    }
}
Console.WriteLine("Las notas mayores son:"+mayores);
Console.WriteLine("Las notas menores son:" + menores);
Console.ReadKey();


