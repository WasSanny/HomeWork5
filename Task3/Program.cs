// Задаём массив вещественных чисел. Осуществляем поиск разницы между максимальным
// и минимальным элементами массива.
// [3 7 22 2 78] -> 76

double[] array = GetRandomArray(5);
Console.WriteLine($"Массив случайных вещественных чисел: {string.Join(", " , array)}");

double maxArray = GetMaxNumber(array);
Console.WriteLine($"Максимальное чиcло массива: {string.Join(", " , maxArray)}");

double minArray = GetMinNumber(array);
Console.WriteLine($"Минимальное число массива: {string.Join(", " , minArray)}");

double res = GetResultFromMaxEndMin(array);
Console.WriteLine($"Разница между максимальным и минимальным значением равна: {string.Join(", " , res)}");

double[] GetRandomArray(int length) 
{
  double[] array = new double [length]; 
  Random rnd = new Random();

  for (int i = 0; i < length; i++)
  {
    array[i] = rnd.NextDouble() * 10;
  }

  return array;
}

double GetMaxNumber(double[] array)
{
  double max = array[0];
  
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] > max)
    {
      max = array[i];
    }
  }

  return max;
}

double GetMinNumber(double[] array)
{
  double min = array[0];
  
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] < min)
    {
      min = array[i];
    }
  }

  return min;
}


double GetResultFromMaxEndMin(double[] array)
{
  double result =  GetMaxNumber(array) - GetMinNumber(array);
  return result;
}
