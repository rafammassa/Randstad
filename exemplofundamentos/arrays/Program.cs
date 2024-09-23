int[] arrayInteiros = new int[3];
arrayInteiros[0] = 72;
arrayInteiros[1] = 64;
arrayInteiros[2] = 50;

for (int i = 0; i < arrayInteiros.Length; i++)
{
    Console.WriteLine($"Posição n°{i} - {arrayInteiros[i]}");
}

Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);

foreach (int valor in arrayInteiros)
{
    Console.WriteLine(valor);
}