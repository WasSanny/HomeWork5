// Задаем одномерный массив, заполненный случайными числами. Находим
// сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] array = GetRandomArray(7, -99, 99);
Console.WriteLine($"Одномерный массив случайных чисел: {string.Join(", " , array)}");

int sumPosition = GetResultOddPosition(array);
Console.WriteLine($"Сумма элементов стоящих на нечетных позициях =: {sumPosition}");


int[] GetRandomArray(int length, int min, int max) 
{
  int[] array = new int [length]; 
  Random rnd = new Random();

  for (int i = 0; i < length; i++)
  {
    array[i] = rnd.Next(min, max + 1);
  }

  return array;
}

int GetResultOddPosition(int[] array)
{
  int count = 0;
  int result = 0;
  
  for (int i = 0; i < array.Length; i++)
  {
    if (i % 2 != 0)
    {
      result = result + array[i];
      count++;
    }
  }

  return result;
}
