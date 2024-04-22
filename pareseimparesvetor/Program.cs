/*
1 - Faça um programa que leia dez números inteiros e imprima os seguintes itens: 
A) Somente os valores pares 
B) Somente os valores impares
C) Somente a primeira e a última posição
*/

int[] numbers = new int[10];

for (int i = 0; i < 10; i++)
{
    Console.Write($"Digite o valor para a {i + 1}ª posição: ");
    numbers[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("\nValores pares: ");

for (int i = 0; i < 10; i++)
{
    if (numbers[i] % 2 == 0)
        Console.Write($"{numbers[i]} ");
}

Console.WriteLine("\n\nValores ímpares: ");

for (int i = 0; i < 10; i++)
{
    if (!(numbers[i] % 2 == 0))
        Console.Write($"{numbers[i]} ");
}

Console.WriteLine($"\n\nPrimeira posição: {numbers[0]}\nÚltima posição: {numbers[9]}");