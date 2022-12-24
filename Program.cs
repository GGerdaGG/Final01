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

// Этап 3: "Выбрали элементы соответствущие условию"

string[] ChooseElements(string[] finArray)
{
    int size = 0;
    for (int i = 0; i < finArray.Length; i++)
    {
        if (finArray[i].Length <= 3) size++;
    }
    string[] finArray2 = new string[size];
    int k = 0;
    for (int i = 0; i < finArray.Length; i++)
    {
        if (finArray[i].Length <= 3)
            finArray2[k++] = finArray[i];
    }
    return finArray2;
}


PrintArray(MakeArray(finalArray));
Console.Write("=>");
PrintArray(ChooseElements(finalArray));



//Другой способ с выводом соответствующих условию элементов, но без массива

// string[] final = { "hello", "2", "world", ":-)", "1234", "1567", "-2", "computer science", "Sunday", "Russian", "Denmark", "Kazan" };

// string[] ChooseElements(string[] fin)
// {
//     string[] arrayFinal = new string[fin.GetLength(0)];

//     for (int i = 0; i < fin.GetLength(0); i++)
//     {
//         if (fin[i].Length <= 3)
//         {
//             Console.WriteLine($"Элемент длина которого меньше либо равна 3 символа: {fin[i]}");
//         }
//     }
//     return arrayFinal;
// }

// ChooseElements(final);



