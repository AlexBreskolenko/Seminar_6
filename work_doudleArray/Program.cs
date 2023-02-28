Console.Clear();

//Создание двухмерного массива(на 2 строки и 3 столбца) 
string[,] array = new string[3, 3];

//Метод приглашения на ввод(вернет число)
int EnterMessang(string messang)
{
    Console.WriteLine(messang);
    int result = int.Parse(Console.ReadLine());
    return result;
}
//Метод создания массива string
string[,] CreateArrayString(int sizeCol, int sizeRow)
{
    return new string[sizeCol, sizeRow];
}
//Метод создания массива int
int[,] CreateArrayInt(int sizeCol, int sizeRow)
{
    return new int[sizeCol, sizeRow];
}
//Метод вывода массива(string)
void PrintArrayString(string[,] arr, int colLength, int rowLength)
{
    for (int col = 0; col < colLength; col++)
    {
        for (int row = 0; row < rowLength; row++)
        {
            Console.Write($"-{arr[col, row]}- ");
        }
        Console.WriteLine();
    }
}
//Метод вывода массива(string)
void PrintArrayInt(int[,] arr, int colLength, int rowLength)
{
    for (int col = 0; col < colLength; col++)
    {
        for (int row = 0; rowLength < 3; row++)
        {
            Console.Write($"-{arr[col, row]}- ");
        }
        Console.WriteLine();
    }
}
//метод вывода массива через GetLength
void PrintArrayGet(int[,] arr)
{
    for (int col = 0; col < arr.GetLength(0); col++)
    {
        for (int row = 0; row < arr.GetLength(1); row++)
        {
            Console.Write($"-{arr[col, row]}-");
        }
        Console.WriteLine();
    }
}
//Метод заполнения массива случайными числами
void FillRandomArray(int[,] arr)
{
    for (int col = 0; col < arr.GetLength(0); col++)
    {
        for (int row = 0; row < arr.GetLength(1); row++)
        {
            arr[col, row] = new Random().Next(1, 10);
        }
    }
}

int colums = EnterMessang("Введите размер столбца - ");
int rows = EnterMessang("Введите размер строки - ");

int[,] arr = CreateArrayInt(colums, rows);

FillRandomArray(arr);
PrintArrayGet(arr);

