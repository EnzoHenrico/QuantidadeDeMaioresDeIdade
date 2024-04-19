// Faça um programa que receba a idade de 10 pessoas e mostre a quantidade de maiores e menores de idade.
int currentPersonAge = 0, minorCount = 0, majorCount = 0;

do
{
    Console.Write($"Diga a idade da pessoa {(minorCount + majorCount) + 1}: ");
    currentPersonAge =  int.Parse(Console.ReadLine());
    
    if (currentPersonAge < 0)
    {
        Console.WriteLine("\n-> Idade não pode ser negativa, tente novamente.\n");
    }
    else if (currentPersonAge < 18)
    {
        minorCount++;
    }
    else
    {
        majorCount++;
    }
}
while (minorCount + majorCount < 10);

Console.WriteLine($"\nExistem {minorCount} menores de idade e {majorCount} maiores de idade.");