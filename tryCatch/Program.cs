using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            FirstTask();
            SecondTask();
        }

        private static void SecondTask()
        {
            int[] a = new int[4];
            try
            {
                a[5] = 4; 
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Завершена обработка массива");
            }
            Console.ReadLine();
        }

        private static void FirstTask()
        {  
            string firstNumber="12";
            string secondNumber="4";
            if (firstNumber==null && secondNumber==null) throw new ArgumentNullException();
            if (secondNumber == "0") throw new ArgumentException();
            Console.ReadLine();
        }
    }
}
