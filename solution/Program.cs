//РЕШЕНИЕ 1 (с использованием двух массивов)
/*
int n = 0;
Console.Write("Сколько элементов Вы хотите ввести? ");
int.TryParse(Console.ReadLine()!, out n);

string[] input = new string[n];
for (int i = 0; i < n; i++)
{
    Console.WriteLine($"Введите {i+1}-й элемент: ");
    string element = Convert.ToString(Console.ReadLine());
    input[i] = element;
}

string[] output = new string[n];
int len = 3;
int pos = 0;

for (int j = 0; j < n; j++)
{
    if (input[j].Length <= len)
    {
        output[pos] = input[j];
        pos++;
    }
}

Console.WriteLine();
PrintArray(output);
*/
// РЕШЕНИЕ 2 (с использованием одного массива)
int n = 0;
Console.Write("Сколько элементов Вы хотите ввести? ");
int.TryParse(Console.ReadLine()!, out n);
string[] input = new string[n];
int len = 3;
int pos = 0;
for (int i = 0; i < n; i++)
{
 Console.WriteLine($"Введите {i+1}-й элемент: ");
 string element = Convert.ToString(Console.ReadLine());
 if (element.Length <= len)
    {
 input[pos] = element;
 pos++;
    }
}
Console.WriteLine();
PrintArray(input);


// _____________Блок вспомогательных методов_____________


void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}