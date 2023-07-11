/*Напишите программу, которая на вход принимает два числа и выдаёт большее число.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/
/*Console.Write("Imput a first number ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Imput a second number ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1>num2) Console.WriteLine("Max: " + num1);
else Console.WriteLine("Max: " + num2);
*/
/*Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/
/*Console.Write("Imput a first number ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Imput a second number ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Imput a third number ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max;

if (num1>num2 & num1>num3)
{
    max = num1; 
    Console.WriteLine("Maximum: " + num1);
}
else 
{
    if(num2>num1 & num2>num3) 
    {
        max = num2; 
        Console.WriteLine("Maximum: " + num2);
    }
    else Console.WriteLine("Maximum: " + num3);
}
*/
/*Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/
/*Console.Write("Imput a number: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num % 2 == 0) Console.WriteLine("Yes");
else Console.WriteLine("No");
*/
/*Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/
Console.Write("Imput a number: ");
int num = Convert.ToInt32(Console.ReadLine());
int chet=1;
while(chet <= num)
{
    if(chet % 2 == 0)  Console.Write(chet + " ");
    chet++;
}