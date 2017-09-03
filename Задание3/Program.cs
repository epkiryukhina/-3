using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание3
{
    class Program
    {
        public static double Imput()//Ввод чисел
        {
            bool rightValue;
            double value;

            do
            {
                string userImput = Console.ReadLine();
                rightValue = double.TryParse(userImput, out value);
                if (!rightValue) Console.Write(@"Ожидалось число. Повторите ввод - ");
            }
            while (!rightValue);

            return value;
        }

        static void Main(string[] args)
        {
            Console.Write(@"Введите координату х: ");//Ввод координат
            double x = Imput();
            Console.Write(@"Введите координату у: ");
            double y = Imput();

            if (((x > 0) && (y > 0) && (y > -2 * x + 1)) || ((x > 0) && (y < 0) && (y < 2 * x - 1)) || ((x <= 0) && (y >= 0) && (y > 2 * x + 1)) || ((x <= 0) && (y <= 0) && (y < -2 * x - 1)))//Описание области
                Console.WriteLine("Не принадлежит");//Вывод рез-ов
            else Console.WriteLine("Принадлежит");

            Console.ReadLine();
        }
    }
}
