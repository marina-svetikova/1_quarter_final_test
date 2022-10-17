// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
//  Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется
//   пользоваться коллекциями, лучше обойтись исключительно массивами.

string [] array = {"hello","2","world",":-)"};

int CountLengthArray(string[] array) //Метод определения длины нового массива
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count = count + 1;
        }
    }
    return count;//длина нового массива
}

string [] GetNewArray (string [] array, int count)// Метод создания нового массива
{
    string [] NewArray = new string [count];
    int j = 0;// индекс нового массива
    for (int i=0;i<array.Length;i++)
    {
        if (array[i].Length<=3)
        {
           NewArray[j] = array [i];
           j++;
        }
    }
    return NewArray;
}
Console.WriteLine($"Задан массив строк: {(string.Join(", ", array))}");
int count = CountLengthArray(array);// Метод определения длины нового массива
Console.WriteLine($"Длина нового массива, после проведения рассчетов, составала: {count} элемента");
string [] NewArray = GetNewArray (array,count);// Метод создания нового массива
Console.Write($"Массив из строк, длина которых меньше или ровна {3}:  ");
Console.Write(string.Join(",", NewArray));

