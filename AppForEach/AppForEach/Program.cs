/*Almacenar	los	sueldos  operarios en un vector, imprimir	
 * los elementos  recorriendo el	vector	con	la 
 * estructura repetitiva foreach.
*/
int[] sueldos=new int[5];
Console.WriteLine("Programa Sentencia ForEach");
for(int contador=0; contador < 5; contador++) 
{
    Console.WriteLine("Digite sueldo:");
    sueldos[contador] = int.Parse(Console.ReadLine());
}
for (int contador = 0; contador < 5; contador++)
{
    Console.WriteLine(sueldos[contador]);
}
foreach(int sueldo in sueldos) 
{
    Console.WriteLine("El sueldo es:");
    Console.WriteLine(sueldo);
}
//Console.WriteLine(sueldos[4]);

