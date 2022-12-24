// Этап 0: "Условие задачи"

// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:

// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []

// Этап 1: "Сформировали массив с клавиатуры"

Console.Write("Какого размера будет массив? ");
int size = Convert.ToInt32(Console.ReadLine());
string[] finalArray = new string[size];


string[] MakeArray(string[] array)
{
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите элемент {i + 1}: ");
        string MakeElement = Convert.ToString(Console.ReadLine());
        array[i] = MakeElement;
    }
    return array;
}

// Этап 2: "Создали метод для вывода"

void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + ", ");
        else Console.Write(arr[i]);
    }
    Console.Write("]");
}