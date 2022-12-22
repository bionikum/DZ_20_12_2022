//                             Транспонирование 

// Задана целочисленная матрица, состоящая из N строк и M столбцов. 
// Требуется транспонировать ее относительно горизонтали.

//                              Входные данные
// Первая строка входного файла INPUT.TXT содержит два натуральных числа N и M – 
// количество строк и столбцов матрицы. 
// В каждой из последующих N строк записаны M целых чисел – элементы матрицы. 
// Все числа во входных данных не превышают 100 по абсолютной величине.

//                              Выходные данные
// В выходной файл OUTPUT.TXT выведите матрицу, полученную 
// транспонированием исходной матрицы относительно горизонтали.

//                                  Пример
// №	INPUT.TXT	      OUTPUT.TXT
//  	3 4
//      5 9 2 6           1 2 8 7
// 1    6 2 4 3           6 2 4 3
//      1 2 8 7	          5 9 2 6




void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}



Console.Clear();
Console.WriteLine("Введите размеры матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];

InputMatrix(matrix);
Console.WriteLine();
Console.WriteLine();


int[,] trans = new int[size[0], size[1]];


for (int i = 0; i < matrix.GetLength(0); i++)
{

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int temp = 0;

        temp = trans[i, j];
        trans[i, j] = matrix[matrix.GetLength(0) - 1 - i, j];
        matrix[matrix.GetLength(0) - 1 - i, j] = temp;

        Console.Write($"{trans[i, j]}\t");
    }
    Console.WriteLine();
}








// void InputArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(1, 11); // [1, 10]
// }



// int[] ReleaseArray(int[] array)
// {
//     int[] result = new int[array.Length];

//     for (int i = 0; i < array.Length; i++)
//     {
//         int temp = result[i];
//         result[i] = array[array.Length - 1 - i];
//         array[array.Length - 1 - i] = temp;

//     }
//     Console.WriteLine($"Конечный массив: [{String.Join(", ", result)}]");
//     return result;

// }


// Console.Clear();
// Console.Write("Введите кол-во элементов массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// InputArray(array);
// Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
// // Console.WriteLine($"Конечный массив: [{string.Join(", ", ReleaseArray(array))}]");
// ReleaseArray(array);

