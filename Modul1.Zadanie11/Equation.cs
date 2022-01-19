using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul1.Zadanie11
{
    struct Equation
    {
        //закрытое поле структуры
        private double k;    
        private double b;
        //открытый конструктор - установка значения
        public Equation(double k, double b) 
        {
            // обращение к полю
            this.k = k; 
            this.b = b;
        }
        //метод для решения, аргументы b, k из структуры
        public string Root() 
        {
            double x = b / k;
            if (k == 0)
            return "На 0 делить нельзя";
            return $"Решение: x = {x:0.00}";
        }

    }
}

