//operador de atribuição
int a = 10;
int b = 20;

int c = a + b;

//c = c + 5;
c += 5;

//c = c - 6;
c -= 6;
Console.WriteLine(c);

//Cast - Casting
int d = Convert.ToInt32("5");
Console.WriteLine(d);

int e = int.Parse("6");
Console.WriteLine(e);

//Covert x Parse
e = Convert.ToInt32(null); //retorna 0
Console.WriteLine(e);

//e = int.Parse(null); EXCEPTION

//Convertendo para String
int inteiro = 9658;
string f = inteiro.ToString();
Console.WriteLine(f);

//Cast Implícito
int g = 7;
double h = g;
Console.WriteLine(h); //Um inteiro cabe dentro de um double, converte automaticamente

//TryParse
string i = "15-";
int j = 27;

int.TryParse(i, out j);
Console.WriteLine(j);
Console.WriteLine("Conversão realizada com sucesso!");

//----- OPERADORES CONDICIONAIS -----

int quantidadeEmEstoque = 10;
int quantidadeCompra = 4;
bool possivelVenda = quantidadeEmEstoque > 0 && quantidadeEmEstoque >= quantidadeCompra;

if (quantidadeEmEstoque == 0){
    Console.WriteLine("Venda inválida!");
} else if (quantidadeEmEstoque >= quantidadeCompra){
    Console.WriteLine("Venda realizada!");
} else {
    Console.WriteLine("Desculpe, não temos a quantidade desejada em estoque!");
}

Console.WriteLine("Venda possível? " + possivelVenda);

//SWITCH CASE

Console.WriteLine("Digite uma letra: ");
string letra = Console.ReadLine();

switch (letra){
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
        Console.WriteLine("VOGAL");
        break;
    default:
        Console.WriteLine("CONSOANTE");
        break;
}

// ----- OPERADOR LÓGICO ----- 
//OR

bool maiorIdade = true;
bool autorizacaoResponsavel = false;
 if (maiorIdade || autorizacaoResponsavel){
    Console.WriteLine("Entrada liberada!");
 } else {
    Console.WriteLine("Entrada proibida");
 }

 //AND

 bool presencaMinima = true;
 double media = 7.5;

 if (presencaMinima && media >= 7){
    Console.WriteLine("Aprovado");
 } else {
    Console.WriteLine("Reprovado");
 }