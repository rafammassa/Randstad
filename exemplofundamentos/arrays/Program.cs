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

int[] arrayInteirosDobrado = new int[arrayInteiros.Length * 2];
Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);

List<string> listaString = new List<string>();
listaString.Add("SP");
listaString.Add("BA");
listaString.Add("MG");

for (int i = 0; i < listaString.Count; i++)
{
    Console.WriteLine($"Posição nº {i} - {listaString[i]}");
}

Console.WriteLine($"Itens da minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

listaString.Remove("BA");

Console.WriteLine($"Itens da minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

