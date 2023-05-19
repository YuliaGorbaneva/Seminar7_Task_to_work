// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.



// InitMassiv();
void InitMassiv()
{
    int [,] array = FillArray();
    FillElement(array);
    PrintElements(array);
    Console.WriteLine();
    ChengMain(array);
} 

int [,] FillArray( )
{
    Console.WriteLine("Введите количесво строк: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите количество столбцов: ");
        int b = int.Parse(Console.ReadLine());
        return  new int [a, b];

}

void FillElement(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array [i,j] = new Random().Next(0, 10);
            }
        }
}

void ChengMain(int [,] array)
{
    
    for(int j = 0; j < array.GetLength(1); j ++)
    {
       int temp = array[0, j];
        array[0,j] = array[array.GetLength(0)-1, j];
        array[array.GetLength(0)-1, j] = temp;
    }
     PrintElements(array);         
}

void PrintElements(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]}  ");
                }
            Console.WriteLine();
        }
}
Console.WriteLine();

// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.
// Task_55();

void Task_55()
{
    int [,] array = FillArray();
    FillElement(array);
    Console.WriteLine();
    PrintElements(array);
    Console.WriteLine();
    ArrayFalse(array);
    ArrayChenge(array);
}

void ArrayFalse(int [,] array)
{
     if (array.GetLength(0) !=  array.GetLength(1) )
     {
        Console.WriteLine("Замена не возможна");
        return;
     }
     
}

int [,] ArrayChenge (int [,] array) 
{
    int [,] newArray = new int[array.GetLength(1), array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            newArray[j,i] = array[i,j];
        }
    }
    PrintElements(newArray);
    return newArray;
}

// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.

Dictionary<int, int> dict = new Dictionary<int, int>();

 int[,] array = ReadArray();
 PrintArr(array);
 Console.WriteLine();

 for (int i = 0; i < array.GetLength(0); i++)
 {
     for (int j = 0; j < array.GetLength(1); j++)
     {
         if (dict.ContainsKey(array[i,j]))
         {
             dict[array[i,j]]++;

         }
         else
         {
             dict.Add(array[i,j], 1);
         }
     }
 }

 foreach (var item in dict.OrderBy(x => x.Key))
 {
     Console.WriteLine($"{item.Key} --- {item.Value}");
 }



 int[,] ReadArray()
 {
     Console.WriteLine("Input");
     int length = int.Parse(Console.ReadLine());
     int length1 = int.Parse(Console.ReadLine());

     int[,] array = new int[length, length1];

     for (int i = 0; i < array.GetLength(0); i++)
     {
         for (int j = 0; j < array.GetLength(1); j++)
         {
             array[i,j] = new Random().Next(0, 10);
         }
     }
     return array;
 }

 void PrintArr(int [,] array)
 {
     for (int i = 0; i < array.GetLength(0); i++)
     {
         for (int j = 0; j < array.GetLength(1); j++)
         {
             Console.Write($"{array[i, j]}  ");
         }
         Console.WriteLine();
     }
    
 }


// Задача 59: Задайтедвумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.

int [,] array1 = FillArray1();
Arrya1(array1);
PrintPrint(array1);
Console.WriteLine();
int [] min = MinElement(array1);
int [,] array2 = CreatNewMatrix(array1, min);
PrintPrint(array2);


int [,] FillArray1( )
{
    Console.WriteLine("Введите количесво строк: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите количество столбцов: ");
        int b = int.Parse(Console.ReadLine());
        return  new int [a, b];

}

void Arrya1(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array [i,j] = new Random().Next(0, 10);
            }
        }
}

int [] MinElement(int [,] array)
{
    int [] minElement = new int [] {0,0};
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i,j] < array[minElement[0], minElement[1]])
            {
                minElement[0] = i;
                minElement[1] = j;
            }
        }
    }
    return minElement;
}

int [,] CreatNewMatrix(int [,] array,int [] min)
{
    int Xshift = 0;
    int Yshift = 0;
    int [,] midlSize = new int [array.GetLength(1) - 1, array.GetLength(0) - 1];
    for (int i = 0; i < midlSize.GetLength(0); i++)
    {
        if (min [0] == i)
        {
            Xshift = 1;
        }
        for (int j = 0; j < midlSize.GetLength(1); j++)
        {
            if (min [1] == j)
            {
                Yshift = 1;
            }
            midlSize [i,j] = array [i + Xshift, j + Yshift];
        }
        Yshift = 0;
    }
    return  midlSize;
}
void PrintPrint(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j]);
        }
        Console.WriteLine();
    }   
}
