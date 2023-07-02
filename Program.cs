//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

int ReadInt (string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

double [,] FillArray (int m, int n, int left, int rigth)
{
    double [,] massive = new double [m,n];
    Random rand = new Random();
    
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            massive[i, j] = rand.Next(left, rigth) + rand.NextDouble();
        }
    }
    return massive;
}

void PrintArray(double [,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write(Math.Round (arr[i, j], 2) + "\t");
        }
        System.Console.WriteLine();
    }
}

bool Check(int n, int m)
{
    if(n < 0 || m < 0)
    {
        System.Console.WriteLine("Значение числа строк и столбцов не может быть меньше 0");
        return false;
    }
    return true;
}

//-------------------------------------------------------------
int m = ReadInt ("Введите количество строк в массиве: ");
int n = ReadInt ("Введите количество столбцов в массиве: ");
int left = ReadInt ("Введите наименьшее возможное число в массиве: ");
int rigth = ReadInt ("Введите максимальное возможное число в массиве: ");
if(Check(n, m))
{
    double [,] array = FillArray (m, n, left, rigth);
    PrintArray(array);
}


//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет

int ReadInt (string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int [,] FillArray (int m, int n, int left, int rigth)
{
    int [,] massive = new int [m,n];
    Random rand = new Random();
    
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            massive[i, j] = rand.Next(left, rigth + 1);
        }
    }
    return massive;
}

void PrintArray(int [,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write(arr[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}
bool Proverka(int [,] array, int a, int b)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == a - 1  && j == b - 1)
            {
                System.Console.Write(array[i,j]);
                return true;
            }
        }
    }
    System.Console.WriteLine("Такого числа нет в массиве");
    return false;
}

bool Check(int n, int m, int a, int b)
{
    if(n < 0 || m < 0 || a < 0 || b < 0)
    {
        System.Console.WriteLine("Значение числа строк и столбцов не может быть меньше 0");
        return false;
    }
    return true;
}

//-------------------------------------------------------------
int m = ReadInt ("Введите количество строк в массиве: ");
int n = ReadInt ("Введите количество столбцов в массиве: ");
int left = ReadInt ("Введите наименьшее возможное число в массиве: ");
int rigth = ReadInt ("Введите максимальное возможное число в массиве: ");
int a = ReadInt ("Введите строку искомого числа в массиве: ");
int b = ReadInt ("Введите столбец искомого числа в массиве: ");

if(Check(n, m, a, b))
{
    int [,] array = FillArray (m, n, left, rigth);
    PrintArray(array);
    if (Proverka(array, a, b))
    {
        System.Console.WriteLine(" -> число с введенным индексом");
    }
}   


//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее 
//арифметическое элементов в каждом столбце.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3

int ReadInt (string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int [,] FillArray (int n, int m, int left, int rigth)
{
    int [,] arr = new int[n, m];
    Random rand = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = rand.Next(left, rigth + 1);
        }
    }
    return arr;
}

void PrintArray (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + "\t");
        }
    System.Console.WriteLine();
    }
}

int [] Resultat(int [,] array, int m, int n)
{
    int [] arrRes = new int[m];
    for (int k = 0; k < arrRes.Length; k++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (k == j)
                {
                    arrRes[k] += array[i,j];
                }
            }
        }
    }
    for (int k = 0; k < arrRes.Length; k++)
    {
        arrRes[k] /= n;
    }
    return arrRes;
}

void PrintResultat (int [] res)
{
    System.Console.Write("Среднее арифметическое каждого столбца -> ");
    System.Console.WriteLine(string.Join(", ", res));
}

bool Check(int n, int m)
{
    if(n < 0 || m < 0)
    {
        System.Console.WriteLine("Значение числа строк и столбцов не может быть меньше 0");
        return false;
    }
    return true;
}
//--------------------------------------------------------
int n = ReadInt("Введите количество строк в массиве: ");
int m = ReadInt("Введите количество столбцов в массиве: ");
int left = ReadInt("Введите наименьшее возможное число в массиве: ");
int rigth = ReadInt("Введите наибольшее возможное число в массиве: ");

if(Check(n, m))
{
    int [,] array = FillArray(n, m, left, rigth);
    PrintArray(array);
    int [] res = Resultat(array, m, n);
    PrintResultat(res);
}
