string numero;
Console.WriteLine("Programa Sentencia Switch");
Console.WriteLine("Digite Número en texto:");
numero = Console.ReadLine();
switch (numero.ToUpper())
{
    case "UNO": Console.WriteLine("1");
        break;
    case "DOS":
        Console.WriteLine("2");
        break;
    case "TRES":
        Console.WriteLine("3");
        break;
    case "CUATRO":
        Console.WriteLine("4");
        break;
    case "CINCO":
        Console.WriteLine("5");
        break;
    default:
        Console.WriteLine("FUERA DEL RANGO");
        break;
}
Console.ReadKey();