using Tyuiu.GaninAS.Sprint2.Task1.V2.Lib;
namespace Tyuiu.GaninAS.Sprint2.Task1.V2
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int a = 135;
            int b = 156;
            int c = 154;
            int d = 174;
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);

            Console.Title = "Спринт #2 | Выполнил: Ганин Андрей Сергеевич | ПКТБ-25-1";
            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Операции сравнения                                                      *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #2                                                              *");
            Console.WriteLine("* Выполнил: Ганин Андрей Сергеевич | ПКТБ-25-1                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");

            Console.WriteLine("*Написать программу из операций сравнений (==, !=, <, >, <=, >=, последова*");
            Console.WriteLine("*ательность можно чередовать, но использовать один раз в выражении) и логи*");
            Console.WriteLine("*ических операций (|, &, ||, &&, !, ^, последовательность операций не долж*");
            Console.WriteLine("*жна нарушаться), а также арифметических выражений, которая вернет логичес*");
            Console.WriteLine("*скую последовательность(массив): (True, True, True, True, True, False)   *");
            Console.WriteLine("*), при a = 135, b = 156, c = 154, d = 174.                               *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("c = " + c);
            Console.WriteLine("d = " + d);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");


            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }
            Console.ReadKey();
        }
    }
}