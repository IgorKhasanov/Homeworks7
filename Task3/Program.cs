// Задайте произвольный массив. Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.

void Main()
{
    int[] array = { 1, 2, 5, 0, 10, 34 };
    ReversArr(array, array.Length - 1);
}
void ReversArr(int[] array, int i)
{
    if (i < 0) return;
    Console.Write(array[i] + " ");
    ReversArr(array, i - 1);
}
Main();
