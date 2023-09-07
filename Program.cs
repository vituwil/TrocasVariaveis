string nome1, nome2, auxiliar;

Console.WriteLine(" Troca de Valores ");
Console.WriteLine();

Console.Write("Nome 1: ");
nome1 = Console.ReadLine()!;

Console.Write("Nome 2: ");
nome2 = Console.ReadLine()!;

Console.WriteLine();

auxiliar = nome1;
nome1 = nome2;
nome2 = auxiliar;

Console.WriteLine("Após trocar os valores temos:");
Console.WriteLine();

Console.WriteLine($"Nome 1 = {nome1}");
Console.WriteLine($"Nome 2 = {nome2}");