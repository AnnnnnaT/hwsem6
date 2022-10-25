
void ShowArray (int []array)

{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int [] CreateArray (int size)
{
    
    int [] array = new int [size];
       for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Input {i+1} number of array: ");
        array [i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

int CountPosNums (int [] array)
{
  int count = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array [i]>0)
    count ++;
  }
  return count;
}

void Show2dArray (int [,] array)
{
    for (int i = 0; i< array.GetLength(0); i++)
    {
        for  (int j = 0; j< array.GetLength(1); j++)
       {    
            Console.Write(array [i,j] + " ");
       }

      Console.WriteLine();
    }
    
}



// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
Console.WriteLine("How many numbers you gonna input: ");
int size = Convert.ToInt32(Console.ReadLine());

int [] array = CreateArray(size);
ShowArray (array);
int count = CountPosNums(array);
Console.WriteLine(count);
*/

// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
int [,]  Coordinates ()
{
    Console.WriteLine("Input b1 value for equation y = k1 * x + b1:  ");
    int b1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input k1 value for equation y = k1 * x + b1:  ");
    int k1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input b2 value for equation y = k2 * x + b2:  ");
    int b2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input k2 value for equation y = k2 * x + b2:  ");
    int k2 = Convert.ToInt32(Console.ReadLine());


    int [,] array = new int [1,2];
    int x = (b2-b1)/(k1-k2);
    int y =k2*x +b2;
    array[0,0] = x;
    array[0,1] = y;
       return array;

}

// int [,] coordinates = Coordinates();
// Show2dArray(coordinates);

// с помощью void:
void PointOfIntersection()
{
    Console.WriteLine("Input b1 value for equation y = k1 * x + b1:  ");
    double b1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Input k1 value for equation y = k1 * x + b1:  ");
    double k1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Input b2 value for equation y = k2 * x + b2:  ");
    double b2 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Input k2 value for equation y = k2 * x + b2:  ");
    double k2 = Convert.ToDouble(Console.ReadLine());
     
    if(k1==k2)
     {
        Console.WriteLine("Lines are parallel.");
     }
     
     if(k1==0||k2==0)
     {
        Console.WriteLine("Check k1 or k2 coefficient, k1 and k2 can't be equal to 0." );
     }

    double x = (b2-b1)/(k1-k2);
    double y =k2*x +b2;
   Console.WriteLine($"Point of intersection of lines has coordinates:({x};{y}).");

}

PointOfIntersection();


