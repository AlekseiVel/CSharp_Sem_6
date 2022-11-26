// Задача 43: Напишите программу, которая найдёт точку пересечения 
// двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();

void FindIntersection (double k1, double b1, double k2, double b2)
{
    // float X = 0;
    // float Y = 0;
    if(k1 == k2 && b1 == b2)
    {
        System.Console.WriteLine("Прямые имеют бесконечное количество точек пересечения");
        return;
    }
    else if(k1 == k2)
    {
        System.Console.WriteLine("Прямые параллельны");
        return;
    }
    else if(k1 != k2)
    {
        double X = (b2 - b1) / (k1 - k2);
        double Y = k1 * X + b1;
        System.Console.Write($"[" + X + "; " + Y + "]");
    }    
}

System.Console.WriteLine("Прямая задается уравнением y = kx + b, найдем точку пересечения двух прямых");
System.Console.WriteLine("Введите коэфициент K для первой прямой?");
string help1;
help1 = Console.ReadLine();
double k1 = float.Parse(help1);
System.Console.WriteLine("Введите коэфициент B для первой прямой?");
string help2;
help2 = Console.ReadLine();
double b1 = float.Parse(help2);
System.Console.WriteLine("Введите коэфициент K для второй прямой?");
string help3;
help3 = Console.ReadLine();
double k2 = float.Parse(help3);
System.Console.WriteLine("Введите коэфициент B для второй прямой?");
string help4;
help4 = Console.ReadLine();
double b2 = float.Parse(help4);
System.Console.Write("Координата точки пересечения ваших прямых: ");
FindIntersection(k1, b1, k2, b2);