Console.WriteLine("Sequência Fibonacci");

int numeroEscolhido = 49;
int quantidadeDeElementos = 50;

uint valorA = 0;
uint valorB = 1;
uint valorC = 0;
bool elementoEncontrado = false;


Console.WriteLine("=-=-=-=-=-=-=-=-=-=");
Console.Write($"{valorA} - ");
for (int i = 0; i < quantidadeDeElementos; i++)
{
    valorA = valorB;
    valorB = valorC;
    valorC = valorA + valorB;
    int ultimoElementoDaSequencia = quantidadeDeElementos - 1;

    if (i == ultimoElementoDaSequencia)
    {
        Console.WriteLine(valorC);
    }
    else
    {
        Console.Write($"{valorC} - ");
    }

    if (numeroEscolhido == 0 || numeroEscolhido == 1 || numeroEscolhido == i)
        elementoEncontrado = true;
}
Console.WriteLine("=-=-=-=-=-=-=-=-=-=");


if (elementoEncontrado)
{
    Console.WriteLine($"O número {numeroEscolhido} pertence a sequência de Fibonacci.");
}
else
{
    Console.WriteLine($"O número {numeroEscolhido} não pertence a sequência de Fibonacci.");
}

