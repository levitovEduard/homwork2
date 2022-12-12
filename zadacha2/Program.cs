// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
{

            int xa, ya, za, xb, yb, zb;
            Console.WriteLine("Введите координаты x y z точки А");
            xa = Convert.ToInt32(Console.ReadLine());
            ya = Convert.ToInt32(Console.ReadLine());
            za = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите координаты x y z точки B");
            xb = Convert.ToInt32(Console.ReadLine());
            yb = Convert.ToInt32(Console.ReadLine());
            zb = Convert.ToInt32(Console.ReadLine());

            double s = Math.Sqrt((xb - xa) * (xb - xa) + (yb - ya) * (yb - ya) + (zb - za) * (zb - za));

            Console.WriteLine("Расстояние между точками {0}", s);

            Console.ReadKey(true);
        }
        
    