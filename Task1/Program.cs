// Задаем массив заполненный случайными трехзначными числами.
// Пишем программу, которая покажет КоличествО четных чесел в массиве!

// int[] array = GetRandomArray(5, 100, 999); 
// Console.WriteLine($"Массив случайных трехзначных чисел: {string.Join(", " , array)}");

// int res = GetResultEvenNumber(array);
// Console.WriteLine($"Количество четных чисел в заданном массиве равно: {string.Join(", " , res)}");

int[] array = GetRandomArray(5, 100, 999);
int res = GetResultEvenNumber(array);
Console.WriteLine($"В массиве случайных трехзначных чисел: {string.Join(", " , array)}, количество четных чисел =: {string.Join(", " , res)}");

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

int GetResultEvenNumber(int[] array)
{
  int result = 0;
  
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] % 2 == 0)
    {
      result++;
    }
  }

  return result;
}