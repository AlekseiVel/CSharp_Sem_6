// Задача 43: Напишите программу, которая найдёт точку пересечения 
// двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();

void FindIntersection (int argB1, int argK1, int argB2, int argK2)
{
    int coordinateX = 0;
    int coordinateY = 0;
    if(argK1 == argK2)
    {
        System.Console.WriteLine("Прямые параллельны или не пересекаются!");
    }
    else if(argK1 != argK2)
    {
        coordinateX = (argB2 - argB1) / (argK1 - argK2);
        coordinateY = argK2 * coordinateX + argB2;
    }
    System.Console.Write($"[" + coordinateX + "; " + coordinateY + "]");
}

System.Console.WriteLine("Прямая задается уравнением y = kx + b, найдем точку пересечения двух прямых");
System.Console.WriteLine("Введите коэфициент K для первой прямой?");
int argK1 = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите коэфициент B для первой прямой?");
int argB1 = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите коэфициент K для второй прямой?");
int argK2 = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите коэфициент B для второй прямой?");
int argB2 = int.Parse(Console.ReadLine());
System.Console.Write("Координата точек пересечения ваших прямых: ");
FindIntersection(argK1, argB1, argK2, argB2);
