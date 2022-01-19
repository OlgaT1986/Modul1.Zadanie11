using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul1.Zadanie11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Решение линейного уравнения 0=kx+b");
            //ввод числовых коэффициентов
            Console.Write("Введите числовой коэффициент уравнения b=");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите числовой коэффициент уравнения k=");
            double k = Convert.ToDouble(Console.ReadLine());
            //создание экземпляра структуры
            Equation equation = new Equation(k, b);
            //вызов метода Root - метод вернет строку
            Console.WriteLine(equation.Root());
            Console.ReadKey();
        }
    }
}

