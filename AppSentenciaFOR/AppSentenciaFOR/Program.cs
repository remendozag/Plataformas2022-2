/*
 * Escribir un programa que lea  10 notas de estudiantes y nos  
 * informe cuántos tienen  notas mayores o iguales a 3  y cuántos 
 * menores.Para resolver este problema  se requieren tres contadores
 */

float nota;
int cont2=0, cont3=0;
Console.WriteLine("Programa Sentencia FOR");
for (int cont1 = 1; cont1 <= 10; cont1++) 
{
    Console.WriteLine("Digite nota "+cont1+":");
    nota = float.Parse(Console.ReadLine());
    if (nota == 3 || nota >= 3)
    {
        cont2++;
    }
    else 
    {
        cont3++;
    }
};
Console.WriteLine("Las notas mayores o iguales a 3 son:"+cont2);
Console.WriteLine("Las notas menores que 3 son:" + cont3);
Console.ReadKey();



