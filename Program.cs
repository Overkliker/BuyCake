using System;
using System.IO;
using Microsoft.Win32;


namespace BuyCake
{
    public class Programm
    {

        static void Main(string[] argrs)
        {
            int pose = 2;
            Cake newCake = new Cake();

            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey();

                if (key.Key == ConsoleKey.UpArrow)
                {
                    if (pose <= 2)
                    {
                        pose += 6;
                    }
                    else
                    {
                        pose--;
                    }

                }
                else if (key.Key == ConsoleKey.DownArrow)
                {

                    if (pose >= 8)
                    {
                        pose -= 6;
                    }
                    else
                    {
                        pose++;
                    }

                }

                if (key.Key == ConsoleKey.Enter)
                {
                    checkMenu(pose, newCake);
                }
                Console.Clear();
                MenuMain(pose);
                Console.SetCursorPosition(0, pose);
                Console.Write("->");

            }
        }

        public static void MenuMain(int pose)
        {
            Console.WriteLine(" Таки это еврейская кондитерская, выберете параметры для тортика");
            Console.WriteLine("....................................................");
            Console.WriteLine("   Форма");
            Console.WriteLine("   Размер");
            Console.WriteLine("   Вкус");
            Console.WriteLine("   Количество");
            Console.WriteLine("   Глазурь");
            Console.WriteLine("   Декор");
            Console.WriteLine("   Конец заказа");
            Console.WriteLine();
            Console.WriteLine("Цена: " + pose);
            Console.WriteLine("Ваш заказ: ");

            
        }

        public static void checkMenu(int pose, Cake ck)
        {
            Dictionary<string, int> l1 = new Dictionary<string, int> { { "Треугольный", 300}, { "Квадратный", 310}, { "Круглый", 290} };
            Dictionary<string, int> l2 = new Dictionary<string, int> { { "60 см", 3000}, { "40 см", 2100}, { "30 см", 1900} };
            Dictionary<string, int> l3 = new Dictionary<string, int> { { "Клубника", 500}, { "Шоколад", 400}, { "Ваниль", 450} };
            Dictionary<string, int> l4 = new Dictionary<string, int> { { "Розовая", 500}, { "Чёрная", 500}, { "Жёлтая", 500} };
            Dictionary<string, int> l5 = new Dictionary<string, int> { { "Звёздочки", 100}, { "Квыдратики", 100} };
            switch (pose)
            {
                case 2:
                    Console.Clear();
                    spawnForm(ck, l1, pose);
                    break;
                case 3:
                    Console.Clear();
                    spawnForm(ck, l2, pose);
                    break;
                case 4:
                    Console.Clear();
                    spawnForm(ck, l3, pose);
                    break;
                case 5:
                    break;
                case 6:
                    Console.Clear();
                    spawnForm(ck, l4, pose);
                    break;
                case 7:
                    Console.Clear();
                    spawnForm(ck, l5, pose);
                    break;
                case 8:
                    break;

            }
        }

        public static Cake spawnForm(Cake ck, Dictionary<string, int> form, int myPose)
        {
            int pose = 2;
            int lastPose = form.Count() + 1;
            int rasn = lastPose - pose;

            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey();

                if (key.Key == ConsoleKey.UpArrow)
                {
                    if (pose <= 2)
                    {
                        pose += rasn;
                    }
                    else
                    {
                        pose--;
                    }

                }
                else if (key.Key == ConsoleKey.DownArrow)
                {

                    if (pose >= lastPose)
                    {
                        pose -= rasn;
                    }
                    else
                    {
                        pose++;
                    }

                }

                else if (key.Key == ConsoleKey.Enter)
                {
                    for (int i = pose; i <= lastPose; i++)
                    {
                        if (form[pose - 1].Values)
                    }
                }

                else if (key.Key == ConsoleKey.Escape)
                {
                    break;
                }

                Console.Clear();
                switch (myPose)
                {
                    case 2:
                        Console.WriteLine("Выберите форму");
                        break;
                    case 3:
                        Console.WriteLine("Выберите размер");
                        break;
                    case 4:
                        Console.WriteLine("Выберите вкус");
                        break;
                    case 6:
                        Console.WriteLine("Выберите глазурь");
                        break;
                    case 7:
                        Console.WriteLine("Выберите декор");
                        break;

                }
                Console.WriteLine("..........................");
                foreach (var znach in form)
                {
                    Console.WriteLine($"   {znach.Key} - {znach.Value} шекелей");
                }
                Console.SetCursorPosition(0, pose);
                Console.Write("->");
            }
            return ck;
        }

    }
}
         