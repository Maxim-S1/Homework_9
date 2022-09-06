// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.Write("Введите значение М: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение N: ");
int N = Convert.ToInt32(Console.ReadLine());

// int NumbersSum(int M, int N)
// {
//     int result = 0;
//     for (int i = M; i <= N; i++) 
//     result += i;
//     return result;
       
// }



int NumbersSum(int M, int N)
{
    if(M > N) return 0;
    else return M + NumbersSum(M + 1, N);
    
}

Console.WriteLine(NumbersSum(M, N));