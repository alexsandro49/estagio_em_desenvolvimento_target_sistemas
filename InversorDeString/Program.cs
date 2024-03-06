Console.WriteLine("Inversor de Strings");
Console.Write("Por favor, informe uma string: ");
string? stringOriginal = Console.ReadLine();
string stringInvertida = "";

if (!(stringOriginal is null))
{
    for (int i = stringOriginal.Length - 1; i >= 0; i--)
    {
        stringInvertida += stringOriginal[i];
    }
}


Console.WriteLine("=-=-=-=-=-=-=-=-=-=");
Console.WriteLine($"STRING ORIGINAL: {stringOriginal}\nSTRING INVERTIDA: {stringInvertida}");
Console.WriteLine("=-=-=-=-=-=-=-=-=-=");

