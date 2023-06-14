Console.Write("Введите количество элементов массива: ");
int m = Convert.ToInt32(Console.ReadLine());
string[] Array = new string[m];

void Input(string[] Array) //вводим элементы начального массива
{
    for (int i = 0; i < Array.Length; i++)
    {
        Console.WriteLine($"Введите {i + 1} элемент массива: ");
        Array[i] = Console.ReadLine();
    }
}


string[] Value(string[] Array)  //считаем количество подходящих под условие задачи элементов
{
    int count = 0;
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i].Length <= 3)
            count++;
    }
    string[] result = new string[count]; //помещаем подходящие элементы в новую строку
    int j = 0;
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i].Length <= 3)
        {
            result[j] = Array[i];
            j++;
        }
    }
    return result;
}
void PrintNewArray(string[] Array) //выводим новый массив 
{
    Console.Write("[");
    for (int i = 0; i < Array.Length; i++)
    {
        Console.Write($"‘{Array[i]}’,");
    }
    Console.Write("]");
}

Input(Array);
PrintNewArray(Value(Array));

