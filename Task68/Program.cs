// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29 (возможно что в примере m и n перепутаны местами)

Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
            
int Ackerman(int m, int n)
    {
        if (m == 0) 
        {
            return n + 1;
        }
        if (m > 0 && n == 0) 
        {
            return Ackerman(m - 1, 1);
        }
        if (m > 0 && n > 0) 
        {
            return Ackerman(m - 1, Ackerman(m, n - 1));
        }
        return Ackerman(m, n);
    }
Console.WriteLine($"Ackerman({m}, {n}) = {Ackerman(m, n)}");