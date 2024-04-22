int currentPersonAge = 0, minorCount = 0, majorCount = 0;

do
{
    Console.Write($"Diga a idade da pessoa {(minorCount + majorCount) + 1}: ");
    currentPersonAge =  int.Parse(Console.ReadLine());

    switch (currentPersonAge)
    {
        case < 0:
            Console.WriteLine("\n-> Idade não pode ser negativa, tente novamente.\n");
            break;
        case > 100:
            Console.WriteLine("\n-> Idade inválida, tente novamente.\n");
            break;
        case < 18:
            minorCount++;
            break;
        case > 18:
            majorCount++;
            break;
        default:
            Console.WriteLine("\n-> Entrada inválida, tente novamente.");
            break;
    }
}
while (minorCount + majorCount < 10);

Console.WriteLine($"\nExistem {minorCount} menores de idade e {majorCount} maiores de idade.");