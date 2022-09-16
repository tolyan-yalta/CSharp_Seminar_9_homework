// Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.

void BubbleSort(int[,] matrix, int index)      // Пузырьковая сортировка
{
    int columns = matrix.GetLength(1);
    int temp;
    for(int i = matrix.GetLength(1) - 1; i > 0; i--)
    {
        for(int j = 0; j < columns - 1; j++)
        {
            if(matrix[index, j] < matrix[index, j + 1])
            {
                temp = matrix[index, j + 1];
                matrix[index, j + 1] = matrix[index, j];
                matrix[index, j] = temp;
            }
        }
        columns -= 1;
    }
}

int EnteringRows()
{
    Console.Write("Введите количество строк в массиве: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    return rows;
}

int EnteringColumns()
{
    Console.Write("Введите количество столбцов в массиве: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    return columns;
}

int rows = EnteringRows();
int columns = EnteringColumns();

bool checkInputData1 = false;
bool checkInputData2 = false;
while(checkInputData1 != true || checkInputData2 != true)
{
    if(rows <= 0)
    {
        Console.WriteLine("Количество строк в матрице не может быть равно 0");
        rows = EnteringRows();
        columns = EnteringColumns();
    }
    else
    {
        checkInputData1 = true;
    }
    if(columns < 2)
    {
        Console.WriteLine("Количество элементов в строке меньше 2, этого мало для сортировки");
        rows = EnteringRows();
        columns = EnteringColumns();
    }
    else
    {
        checkInputData2 = true;
    }
}

Console.WriteLine("Задайте минимальное и максимальное значение для генерации чисел: ");
int min = Convert.ToInt32(Console.ReadLine());
int max = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\tСгенерирован массив:");
int[,] matrix = new int[rows, columns];

for(int i = 0; i < rows; i++)
{
    for(int j = 0; j < columns; j++)
    {
        matrix[i, j] = new Random().Next(min, max);
        Console.Write($"\t{matrix[i, j]} ");
    }
    Console.WriteLine();
}

for(int i = 0; i < rows; i++)
{
    BubbleSort(matrix, i);
}

Console.WriteLine("\tМассив полученный после сортировки:");
for(int i = 0; i < rows; i++)
{
    for(int j = 0; j < columns; j++)
    {
        Console.Write($"\t{matrix[i, j]} ");
    }
    Console.WriteLine();
}
