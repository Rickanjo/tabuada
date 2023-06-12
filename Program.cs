Console.Write("Digite um número inteiro: ");
int numero = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Tabuada do número: {numero}\n");

for (int i = 0; i <= 10; i++)
{
    int resultado = numero * i;
    Console.WriteLine($"{numero} x {i} = {resultado}");
}

