// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear();

int[] FillArray(int size)
{
    int[] numbersArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine("Вводите ваши числа по одному: ");
        numbersArray[i] = int.Parse(Console.ReadLine()!);
    }
    return numbersArray;
}

int SearchCountOfPositive(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
        count++;
    }
    return count;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}



Console.WriteLine("Какое количество чисел вы хотите ввести?");
int size = int.Parse(Console.ReadLine()!);
int[] array = FillArray(size);
Console.WriteLine("Введенные числа:");
PrintArray(array);
Console.WriteLine("Количество положительных чисел:" + SearchCountOfPositive(array));
