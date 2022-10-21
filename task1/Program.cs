// Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте,
//сколько чисел больше 0 ввёл пользователь. Разделить ввод данных, от расчета данных 
//(Одна функция вводит данные, другая функция подсчитывает количество положительных)
//1, -7, 567, 89, 223-> 3
//0, 7, 8, -2, -2 -> 2

int Prompt()
{
    System.Console.WriteLine("Write number");
    int a = Convert.ToInt32(Console.ReadLine());
    return a; 
}
int[] Array(int len)
{
    int[] array = new int [len];
    for (int i = 0; i < len; i++)
    {
        array[i] = Prompt();
    }
    return array;
}
int Count( int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) count++;
    }
    System.Console.WriteLine($" Положительных чисел {count}");
    return count;
}

int length = Prompt();
int[] numbers = Array(length);
Count( numbers);

