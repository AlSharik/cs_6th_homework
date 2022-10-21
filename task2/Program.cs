// Задача 2: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2
// задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int Prompt()
{
    System.Console.WriteLine("Write number");
    int a = Convert.ToInt32(Console.ReadLine());
    return a; 
}
// straight[0] - это k, straight[1] - это b
int[] Straight()
{
    int[] straight = new int [2];
    for (int i = 0; i < 2; i++)
    {
        straight[i] = Prompt();
    }
    return straight;
}
// Функция о поиске точки пересечения была написана инициализирована как int 
// Поскольку я не был уверен, что break будет работать как я хочу
int IntersectionPoint(int[] straight1, int[] straight2)
{
    if(straight1[1] == straight2[1])
    {
        if(straight1[0] == straight2[0])
        {
            System.Console.WriteLine("Это две одинаковых прямых");
            return 0;
        }
        else
        {
            System.Console.WriteLine($"Точка пересечния x = 0 y = {straight1[1]}");
            return 0;
        }
    }
    else
    {
        if(straight1[0] == straight2[0])
        {
            System.Console.WriteLine("Они паралельны, следовательно точки пересечения нет");
            return 0;
        }
    }
    int x = (straight2[1] - straight1[1])/(straight1[0] - straight2[0]);
    int y = straight1[0] * x + straight1[1];
    System.Console.WriteLine($"Точка пересечения x = {x} y = {y}");
    return 0;
}
int[] straight1 = Straight();
int[] straight2 = Straight();
IntersectionPoint(straight1, straight2);
