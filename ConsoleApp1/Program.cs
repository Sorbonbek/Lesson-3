using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
                                  // Задача №1
            
            
            int money;
            double sale_1, sale_2, price_total;
            sale_1 = 0.03; //скидка 3%
            sale_2 = 0.05; //скидка 5%
            
            money = Convert.ToInt32(Console.ReadLine()); //ввод суммы покупки
            
            if(money > 500 && money <= 1000)
            {
                price_total = money - money * sale_1; //из суммы покупки вычитаем скиду (3%)
            
                Console.WriteLine($"Сумма покупки с учетом скидки, составляет: { price_total } ");
            }
            
            if(money > 1000)
            {
                price_total = money - money * sale_2;
            
                Console.WriteLine($"Сумма покупки с учетом скидки, составляет: { price_total } ");
            }
            
                                  // Задача №3
            
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());
            int D = int.Parse(Console.ReadLine());
            if(!(A <= B && B <= C && C <= D) && !(A == B && B == C && C == D))
            {
                Console.WriteLine("Числа не расположены по возрастанию!");
                if(A < B && A < C && A < D)
                {
                    Console.WriteLine("Наименьшее Число: " + A);
                }
                if(B < A && B < C && B < D)
                {
                    Console.WriteLine("Наименьшее Число: " + B);
                }

                if(C < A && C < B && C < D)
                {
                    Console.WriteLine("Наименьшее Число: " + C);
                }

                if(D < A && D < C && D < B)
                {
                    Console.WriteLine("Наименьшее Число: " + D);
                }
            }
            if(A == B && B == C && C == D)
            {
                Console.WriteLine("Числа равны, их произведение " + (A * B * C * D));
            }
            if(A <= B && B <= C && C <= D && !(A == B && B == C && C == D))
            {
                Console.WriteLine("Числа расположены по возрастанию!");
            }
            
            // Задача №3
            
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());
            if((A>=B)&&(B>=C))
                Console.WriteLine($"{A} >= {B} >= {C}");
            else if((B >= A) && (A >= C))
                Console.WriteLine($"{B} >= {A} >= {C}");
            else if((A >= C) && (C >= B))
                Console.WriteLine($"{A} >= {C} >= {B}");
            else if((B > C) && (C > A))
                Console.WriteLine($"{B} >= {C} >= {A}");
            else if((C >= A) && (A >= B))
                Console.WriteLine($"{C} >= {A} >= {B}");
            else
                Console.WriteLine($"{C} >= {B} >= {A}");
        }
    }
}