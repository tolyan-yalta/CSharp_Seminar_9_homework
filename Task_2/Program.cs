// Напишите программу, которая заполнит спирально двумерный массив 4 на 4.

int EnteringSize()          // Ввод размера матрицы
{
    Console.Write("Введите размер двумерного массива: ");
    int size = Convert.ToInt32(Console.ReadLine());
    return size;
}

int size = EnteringSize();

bool checkInputData = false;    // Проверка входных данных
while(checkInputData != true)
{
    if(size < 2)
    {
        Console.WriteLine("При размере матрицы меньше 2-х, программа не имеет смысла");
        size = EnteringSize();
    }
    else
    {
        checkInputData = true;
    }
}

int number = 1;

int[,] matrix = new int[size, size];

void FillRowUp(int[,] matrix, int rowUp, int start, int stop, ref int number)   // Функция заполнения верхней строки
{

    for(int i = start; i < stop; i++)
    {
        matrix[rowUp, i] = number;
        number += 1;
    }
}

int rowUp = 0;
int startRowUp = 0;
int stopRowUp = size;

void FillColumnRight(int[,] matrix, int columnRight, int start, int stop, ref int number)   // Функция заполнения правого столбца
{
    for(int i = start; i < stop; i++)
    {
        matrix[i, columnRight] = number;
        number += 1;
    }

}

int columnRight = matrix.GetLength(1) - 1;
int startColumnRigth = 1;
int stopColumnRigth = size;

void FillRowDown(int[,] matrix, int rowDown, int start, int stop, ref int number)    // Функция заполнения нижней строки
{

    for(int i = start; i > stop; i--)
    {
        matrix[rowDown, i] = number;
        number += 1;
    }
}

int rowDown = matrix.GetLength(0) - 1;
int startRowDown = size - 2;
int stopRowDown = -1;

void FillColumnLeft(int[,] matrix, int columnLeft, int start, int stop, ref int number)  // Функция заполнения левого столбца
{
    for(int i = start; i > stop; i--)
    {
        matrix[i, columnLeft] = number;
        number += 1;
    }

}

int columnLeft = 0;
int startColumnLeft = size - 2;
int stopColumnLeft = 0;

int index;
if(size % 2 == 0)
{
    index = size / 2;
}
else
{
    index = size / 2 + 1;
}

while(index > 0)
{

    FillRowUp(matrix, rowUp, startRowUp, stopRowUp, ref number);
    rowUp++;
    startRowUp++;
    stopRowUp -= 1;
    FillColumnRight(matrix, columnRight, startColumnRigth, stopColumnRigth, ref number);
    columnRight--;
    startColumnRigth++;
    stopColumnRigth -= 1;
    FillRowDown(matrix, rowDown, startRowDown, stopRowDown, ref number);
    rowDown--;
    startRowDown -= 1;
    stopRowDown++;
    FillColumnLeft(matrix, columnLeft, startColumnLeft, stopColumnLeft, ref number);
    columnLeft++;
    startColumnLeft -= 1;
    stopColumnLeft ++;

    index--;
}

for(int i = 0; i < size; i++)
{
    for(int j = 0; j < size; j++)
    {
        Console.Write($"\t{matrix[i, j]} ");
    }
    Console.WriteLine();
}
