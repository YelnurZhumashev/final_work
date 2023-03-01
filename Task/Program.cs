// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

void PrintArray (string[] array1)
{
    Console.Write("[");
    for (int i = 0; i < array1.Length; i++)
    {
        if(i < array1.Length - 1) Console.Write($"{array1[i]}, ");
        else Console.Write($"{array1[i]}");

    }
    Console.Write("]");
}

string[] NewArray (string[] array1)
{
    int length = array1.Length;			
	string[] result = new string[length];
	int count = 0;

    for (int i = 0; i < array1.Length; i++)
    {
        if(array1[i].Length <= 3)
        {
            result[count] = array1[i];
            count++;
        }
    }
   	Array.Resize(ref result, count);
			
	return result;
}

void PrintArrayNew(string[] result)
{
    Console.Write("[");
    for (int i = 0; i < result.Length; i++)
    {
        if(i < result.Length - 1) Console.Write($"{result[i]}, ");
        else Console.Write($"{result[i]}");
    }
    Console.Write("]");
}

Console.Write("Введите элементы(через пробел): ");
string[] array1 = Console.ReadLine().Split();
PrintArray(array1);
Console.Write($" -> ");
string[] newArr = NewArray(array1);
PrintArrayNew(newArr);