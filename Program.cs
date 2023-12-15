// Задача 1: Задайте одномерный массив из 10 целых чисел от 1 до 100. 
// Найдите количество элементов массива, значения которых лежат в отрезке [20,90].

int[] array = new int[10];
for (int i = 0; i < array.Length; i++)
{
System.Console.WriteLine("Введите числа массива");
array[i] = Convert.ToInt32(Console.ReadLine());    
}
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 19 && array[i] < 90)
    count = count + 1;
}
System.Console.WriteLine($"Количество элементов массива = {count}");