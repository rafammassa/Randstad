int numero = 5;

for (int i = 0; i <= 10; i++)
{
    Console.WriteLine($"{numero} x {i} = {numero * i}");
}

int numero2 = 8;
int c = 0;

while (c <=10)
{
   Console.WriteLine($"{numero2} x {c} = {numero2 * c}"); 
   c++;

   if (c == 5)
   {
    break;
   }
}

//int soma = 0, numero3 = 0;
 
//do
//{
//    Console.WriteLine("Digite um número: ");
//    numero3 = Convert.ToInt32(Console.ReadLine());

//    soma += numero3;
//} while (numero3 != 0);

//Console.WriteLine("A soma dos números digitados é: " + soma);

string opcao;
bool exibirMenu = true;

while (exibirMenu)
{
    Console.WriteLine("Digite a sua opção: ");
    Console.WriteLine("1 - Cadastrar Cliente");
    Console.WriteLine("2 - Buscar Cliente");
    Console.WriteLine("3 - Apagar Cliente");
    Console.WriteLine("4 - Encerrar");

    opcao = Console.ReadLine();

    Console.Clear();

    switch (opcao)
    {
        case "1":
            Console.WriteLine("Cadastro de cliente");
            break;

        case "2":
            Console.WriteLine("Busca de cliente");
            break;

        case "3":
            Console.WriteLine("Apagar cliente");
            break;

        case "4":
            Console.WriteLine("Encerrar");
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida");
            Environment.Exit(0);
            break;
    }
}

Console.WriteLine("O programa foi encerrado");