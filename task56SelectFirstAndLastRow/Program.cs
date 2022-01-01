// Написать программу, которая обменивает элементы первой строки и последней строки.

Console.Write("Enter row array: ");
int columnAr = int.Parse(Console.ReadLine());
Console.Write("Enter column array: ");
int rowAr = int.Parse(Console.ReadLine());



int[,] array = new int[rowAr, columnAr];
int[] tempArray = new int[columnAr];


void FillArray(int[,] fill)
{
    for (int row = 0; row < fill.GetLength(0); row++)
    {
        for (int column = 0; column < fill.GetLength(1); column++)
        {
            fill[row, column] = new Random().Next(0, 10);
        }
    }
}

void SelectRow(int[,] mrArray, int[] mrBrainTemt, int rowArray)
{
    for (int column = 0; column < mrBrainTemt.Length; column++)
    {
        mrBrainTemt[column] = mrArray[0, column];
        mrArray[0, column] = mrArray[rowArray - 1, column];
        mrArray[rowArray - 1, column] = mrBrainTemt[column];
    }
}



void PrintArray(int[,] print)
{
    for (int row = 0; row < print.GetLength(0); row++)
    {
        for (int column = 0; column < print.GetLength(1); column++)
        {
            Console.Write(print[row, column] + " ");
        }
        Console.WriteLine();
    }
}


FillArray(array);
PrintArray(array);
SelectRow(array, tempArray, rowAr);
Console.WriteLine();
PrintArray(array);

