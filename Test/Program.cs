using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //    int[] numbers = { -5, -4, 1, 3, 9, 8, 6, 7, 2 };
            //int oddNumbers = numbers.Count(x => x % 2 == 0); // количество четных чисел в массиве
            //Console.WriteLine(oddNumbers);


            //  int number = numbers.First(x => x > 0); // получение первого положительного числа в массиве
            //  int zz = numbers.ToList().IndexOf(number); // получение его индекса
            //  Console.WriteLine(number);
            //  Console.WriteLine(zz);


            // Array.Sort(numbers);  // сортировка массива
            // Array.Reverse(numbers); // обратная сортировка


            //    var orderedNumbers = from i in numbers
            //                         orderby i descending // по убыванию  
            //                       //  orderby i ascending // по возрастанию
            //                         select i;

            //    foreach (int i in orderedNumbers)
            //    {
            //        Console.WriteLine(i);
            //    }

            string str = "Hello";
            char[] tmp = str.ToCharArray(); // В массив чаров
            Array.Reverse(tmp);             // инвертируем
            str = String.Join("",tmp);      // соединяем чары в строку
            
            Console.WriteLine(str);

            Temp temp = new Temp();
            temp.PrintModels();



            Console.ReadKey();
        }
    }
}
