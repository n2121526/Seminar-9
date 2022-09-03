/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/
Console.Write("Введите неотрицательное число M: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите неотрицательное число N: ");
int n = int.Parse(Console.ReadLine());

int AckFunc(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return AckFunc(m - 1, 1);
  else return AckFunc(m - 1, AckFunc(m, n - 1));
}

Console.WriteLine($"A({m},{n}) = {AckFunc(m, n)}");