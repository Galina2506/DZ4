using System;

namespace DZ_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetFullName("Тучин", "Роман", "Сергеевич"));
            Console.WriteLine(GetFullName("Куликова", "Ирина", "Вячславовна"));
            Console.WriteLine(GetFullName("Литвинова", "Варвара", "Александровна"));
            Console.WriteLine(GetFullName("Сычева", "Анна", "Владиславовна"));
            Console.WriteLine();



            Console.Write("Введите цифры через пробел: ");
            Console.WriteLine(GetSum(Console.ReadLine()));
            Console.WriteLine();

        }
    }
}
