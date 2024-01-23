using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int x = 0;
            
            while(x<=10)
            {
                x++;
                Console.WriteLine(x);
               
            }

            */
            /*
            int x = 0;
            do
            {
                
                x++;
                Console.WriteLine(x);
            }
            while(x<=10);
            */
            /*
            for (int x = 0; x<=10; x++)
            {
                Console.WriteLine(x);
            }
            */
            //Задание 2. Вывести на экран целые числа из интервала от 1 до n (цикл с параметром)
            /*
            Console.WriteLine("Введите любое число");
            int y = int.Parse(Console.ReadLine());
            
            for (int x = 0;x <= y; x++ )
            {
                Console.WriteLine(x);
            }*/
            //Задание 3.Вывести в столбик 5 раз слово «Привет!» (циклы с условием)

            /*
            int x = 1;
            while (x <= 5)
            {
                x++;
                Console.WriteLine("Привет");

            }
            */
            /*
            int x = 1;
            do
            {
                
                x++;
                Console.WriteLine("Привет");
            }

            while(x<=5);
            */
            //Задание 4. С использованием цветового оформления консоли:
            //а) вывести на экран горизонтальную строку из 18 символов;
            //б) вывести на экран вертикальную строку из 25 символов.

            /*
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Black;
            for (int x = 1; x <= 18; x++)
            {
                x++;
                Console.Write("a");
            }*/
            /*
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            for (int x = 1; x <= 25; x++)
            {
                x++;
                
                Console.WriteLine("a");
            }

            */

            Console.ReadKey();
        }
    }
}
