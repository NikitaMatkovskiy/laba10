using System;

namespace laba10
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int i, N, x, a, b;
                Console.WriteLine("введите количество чисел массива");
                N = int.Parse(Console.ReadLine());
                int[] array = new int[N];
                Console.WriteLine("введите элементы массива");
                for (i = 0; i < N; i++)
                {
                    array[i] = Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine("начальное число отрезка А=");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("конечное число отрезка B=");
                b = int.Parse(Console.ReadLine());

                for (i = 0; i < N; i++)
                {
                    if ((i >= a - 1) && (i <= b - 1)) { Console.WriteLine("{0}", array[i]); }
                }
            }
            catch (ArgumentOutOfRangeException error1)
            {
                Console.WriteLine("Возникло исключение! генерируется, если значение аргумента находится вне диапазона допустимых значений", error1.Message);
            }
            catch (FormatException error2)
            {
                Console.WriteLine("Возникло исключение! формат аргумента не соответствует спецификациям параметра вызываемого метода", error2.Message);
            }
            catch (ArgumentException error3)
            {
                Console.WriteLine("Возникло исключение! в метод для параметра передается некорректное значение", error3.Message);
            }
            catch (IndexOutOfRangeException error4)
            {
                Console.WriteLine("Возникло исключение! индекс элемента массива или коллекции находится вне диапазона допустимых значений", error4.Message);
            }
            Console.ReadLine();
        }
    }
}
