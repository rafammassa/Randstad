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