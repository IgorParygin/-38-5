// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

float [] array = new float[10]; //создание массива

Random rand = new Random();
for (int i = 0; i < array.Length; i++) 
{
   array[i] = rand.Next(-99,99);
   Console.Write(array[i]+" ");
}
Console.WriteLine();

float max (float [] mas) //метод поиска максимального элемента
{
    float m = 0;
    for (int i = 0; i < mas.Length; i++ )
    {
        if (m < mas[i])
        m = mas[i];
    }
    return m;
}

float min (float [] mas) //метод поиска минимального числа
{
    float m = 0;
    for (int i = 0; i < mas.Length; i++ )
    {
        if (m > mas[i])
        m = mas[i];
    }
    return m;
}

float x = max (array);
Console.WriteLine("Максимальный элемент массива " + x);
float y = min (array);
Console.WriteLine("Минимальный элемент массива " + y);
Console.WriteLine (x - y);