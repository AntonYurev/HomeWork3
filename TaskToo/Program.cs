// принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Console.WriteLine("Введите координаты первой точки: ");
Console.Write("X1 = ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y1 = ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z1 = ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки: ");
Console.Write("X2 = ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y2 = ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z2 = ");
int z2 = Convert.ToInt32(Console.ReadLine());
double rezalt = Math.Round(Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1)), 2);
Console.WriteLine("Расстояние между точками = " + rezalt);