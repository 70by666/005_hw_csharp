// не делал проверку, как в прошлом дз, потому что я же и так знаю, как сделать ее
// и в задаче не указано, что-то про аргументы


int[] set_arr(int len, int from, int to)
{
    int[] arr = new int[len];
    Random rnd = new Random();
    for (int i = 0; i < len; i++)
    {
        // я же правильно понимаю, что 100 включительно и до 1000 не включая 1000?
        arr[i] = rnd.Next(from, to); 
    }

    return arr;
}


// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
int Task34(int len, int from, int to)
{
    int[] arr = set_arr(len, from, to);
    System.Console.WriteLine($"task 34 [{string.Join(", ", arr)}]");

    int result = 0;
    foreach (int i in arr)
    {
        if (i % 2 == 0)
        result ++;
    }

    return result;
}


System.Console.WriteLine($"task 34 = {Task34(10, 100, 1000)}");


System.Console.WriteLine();


// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
int Task36(int len, int from, int to)
{
    int[] arr = set_arr(len, from, to);
    System.Console.WriteLine($"task 36 [{string.Join(", ", arr)}]");

    int result = 0;
    for (int i = 1; i < len; i += 2)
    {
        result += arr[i];
    }

    return result;
}


System.Console.WriteLine($"task 36 = {Task36(4, 0, 10)}");
System.Console.WriteLine($"task 36 = {Task36(10, -100, 100)}");


System.Console.WriteLine();


// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
int Task38(int len, int from, int to)
{
    int[] arr = set_arr(len, from, to);
    System.Console.WriteLine($"task 38 [{string.Join(", ", arr)}]");

    int min = arr[0];
    for (int i = 1; i < len; i++)
    {
        if (arr[i] < min)
        {
            min = arr[i];
        }
    }

    System.Console.WriteLine($"task 38 min = {min}");

    int max = arr[0];
    for (int i = 1; i < len; i++)
    {
        if (arr[i] > max)
        {
            max = arr[i];
        }
    }

    System.Console.WriteLine($"task 38 max = {max}");

    int result = max - min;

    return result;
}


System.Console.WriteLine($"task 38 = {Task38(4, 0, 10)}");
System.Console.WriteLine($"task 38 = {Task38(10, -100, 100)}");
