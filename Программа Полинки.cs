using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            { 
                Console.WriteLine("Введите номер задачи: ");
            int _CaseNumber = Convert.ToInt32(Console.ReadLine());
            switch (_CaseNumber)
            {
                case 1:
                    _Questionnaire();
                    break;
                case 2:
                    _BodyMassIndex();
                    break;
                case 3:
                    _Сoordinates();
                    break;
                case 4:
                    _Exchange();
                    break;
                case 5:
                    _NameCity();
                    break;
                case 6:
                    _MyProgram();
                    break;
                default:
                    Console.WriteLine("Введите существующую задачу (1-6).");
                    break;
            }

            Console.ReadLine();
        }
        static void _Questionnaire()
        {
            Console.WriteLine("Анкета");

            Console.Write("Имя: ");
            string name = Console.ReadLine();

            Console.Write("Фамилия: ");
            string surname = Console.ReadLine();

            Console.Write("Возраст: ");
            string age = Console.ReadLine();

            Console.Write("Рост: ");
            string h = Console.ReadLine();

            Console.Write("Вес: ");
            string m = Console.ReadLine();

            Console.WriteLine(name + " " + surname + " " + age + " " + h + " " + m);
            Console.WriteLine("{0} {1} {2} {3} {4}", name, surname, age, h, m);
            Console.WriteLine($"{name} {surname} {age} {h} {m}");
        }
        static void _BodyMassIndex()
        {
            Console.WriteLine("Рост, м: ");
            double h = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Вес, кг: ");
            
                    double m = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Индекс массы тела = " + m / (h * h));
        }
        static void _Сoordinates()
        {
            Console.Write("x1 = ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y1 = ");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("x2 = ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y2 = ");
            double y2 = Convert.ToDouble(Console.ReadLine());

            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("{0:F2}", r);
            Console.WriteLine("{0:F2}", Distance(x1, y1, x2, y2));
        }

        static double Distance(double x1, double y1, double x2, double y2)
        {
            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return r;
        }
        static void _Exchange()
        {
            int a = 1;
            int b = 2;
            Console.WriteLine(a + " " + b);

            int t = a;
            a = b;
            b = t;
            Console.WriteLine(a + " " + b);

            b = a + b;
            a = b - a;
            b = b - a;
            Console.WriteLine(a + " " + b);
        }
        static void _NameCity()
        {
            string name = "Полина";
            string surname = "Терентьевская";
            string city = "Москва";

            Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2);

            Console.WriteLine("{0} {1} {2}", name, surname, city);
            PrintInCenter(name + " " + surname + " " + city, Console.WindowWidth / 2, Console.WindowHeight / 2 + 1);
        }

        static void PrintInCenter(string message, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(message);
        }
        static void _MyProgram()
        { 
            _MyProgramClass.Input("Введите значение: ");
        }
        }
  }
}



