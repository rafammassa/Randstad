﻿int numero = 5;

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

int soma = 0, numero3 = 0;
 
do
{
    Console.WriteLine("Digite um número: ");
    numero3 = Convert.ToInt32(Console.ReadLine());

    soma += numero3;
} while (numero3 != 0);

Console.WriteLine("A soma dos números digitados é: " + soma);