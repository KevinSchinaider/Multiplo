﻿int n1, n2, resto;

Console.WriteLine("----------------");
Console.WriteLine("----Múltiplo----");
Console.WriteLine("----------------");

Console.WriteLine("Digite um número......: ");
n1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Avaliar se é múltiplo de...: ");
n2 = Convert.ToInt32(Console.ReadLine());

resto = n1 % n2;

if (resto == 0)
{
    Console.WriteLine($"{n1} é múltiplo de {n2}");
}
else
{
    Console.WriteLine($"{n1} não é múltiplo de {n2}");

}