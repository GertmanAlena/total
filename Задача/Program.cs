//Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо 
// равна трём символам. Первоначальный массив модно ввести с клавиатуры либо задать на старте выполнения алгоритма

Console.Clear();
Console.Write("Введите строку из стихотворения: ");
#pragma warning disable CS8602 // Разыменование вероятной пустой ссылки.
string[] myText = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
#pragma warning restore CS8602 // Разыменование вероятной пустой ссылки.
string[] myText2 = SearchWord(myText);

PrintArray(myText);
Console.Write(" -> ");
PrintArray(myText2);

string[] SearchWord(string[] mass)
{
    int z = 0;
    for (int i = 0; i < mass.Length; i++)
    {
        if (mass[i].Length > 3) z++;
    }

    int k = 0;
    string[] newMass = new string[mass.Length - z]; //тут будет новый масив из подходящих слов
    for (int i = 0; i < mass.Length; i++)
    {
        if (mass[i].Length <= 3)
        {
            newMass[k] = mass[i];
            k++;
        }
    }
    return newMass;
}

void PrintArray(string[] inArray)
{
    // Console.Write("[");
    for (int i = 0; i < inArray.Length; i++)
    {
        
        // Console.Write($"'{inArray[i]}',");
    }
    Console.Write("[" + string.Join(", ", inArray) + "]");
    // Console.Write("]");
}
