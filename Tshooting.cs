namespace TargetShooting
{

    public struct Shoot
    {
        public int x;
        public int y;


    }

    internal class Tshooting
    {
        static void Main(string[] args)
        {

            Shoot a, b;
            Console.WriteLine("Создана мишень");

            Random t = new Random();

            a.x = t.Next(1, 10);
            a.y = t.Next(1, 12);

            b.x = 0;
            b.y = 0;







            Console.Write("Зарядка оружия, введите колличество патронов:");
            int ammunition = int.Parse(Console.ReadLine());


            int[] pointTargetX = new int[ammunition];
            int[] pointTargetY = new int[ammunition];


            for (int i = 0; i < pointTargetX.Length; i++)
            {


                Console.WriteLine($"Введите координату выстрела {i + 1} X:");
                pointTargetX[i] = int.Parse(Console.ReadLine());
                if (pointTargetX[i] == a.x)
                {
                    b.x = pointTargetX[i];
                }
                Console.WriteLine($"Введите координату выстрела {i + 1} Y:");
                pointTargetY[i] = int.Parse(Console.ReadLine());
                if (pointTargetX[i] == a.x)
                {
                    b.y = pointTargetX[i];
                }

            }

            int score10 = 0;
            int score5 = 0;
            int score2 = 0;

            for (int i = 0; i < pointTargetX.Length; i++)
            {
                if (pointTargetX[i] <= 1 && pointTargetY[i] <= 1)
                {
                    score10 += 10;
                }
                else if ((pointTargetX[i] > 1 && pointTargetX[i] <= 2) && (pointTargetY[i] > 1 && pointTargetY[i] <= 2))
                {
                    score5 += 5;
                }
                else if ((pointTargetX[i] > 2 && pointTargetX[i] >= 3) && (pointTargetY[i] > 2 && pointTargetY[i] >= 3))
                {
                    score2 += 2;
                }
            }





            bool intersection = a.x == b.x && a.y == b.y;

            if (intersection)
            {
                Console.WriteLine($"В яблочко!!!!!");
            }


            Console.WriteLine($"Цент мишени был: x {a.x}, y {a.y}");
            Console.WriteLine($"Количество очков:{score10 + score5 + score2}");





        }
    }
}