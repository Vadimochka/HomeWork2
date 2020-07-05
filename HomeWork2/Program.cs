using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Составить блок-схему алгоритма вычисления стоимости покупки с учетом скидки. 
            ///Скидка в 3% предоставляется, если сумма покупки больше 500 грн, в 5% — если сумма больше 1000 грн.

            Console.WriteLine("Стоимость покупки с учетом скидки.");
            Console.Write("Введите стоимость: ");

            string value = Console.ReadLine();
            double price = Double.Parse(value);

            string currency = " грн.";


            if (price < 500)
            {
                Console.WriteLine($"Для данной стоимости покупки не предусмотрена скидка!Чтобы получить скидку купите товар свыше 500{currency}\nПОЛНАЯ СТОИМОСТЬ:{price}" + currency);
            }
            else if (price > 500 && price < 1000)
            {
                double percent1 = (price / 100) * 3;
                Console.WriteLine("Вы получили скидку 3%.\nПОЛНАЯ СТОИМОСТЬ: {0}" + currency, price - percent1);
            }
            if (price > 1000)
            {
                double percent2 = (price / 100) * 5;
                Console.WriteLine("Вы получили скидку 5%.\nПОЛНАЯ СТОИМОСТЬ: {0}" + currency, price - percent2);
            }
            Console.ReadKey();


            ////Напишите программу проверки знания истории архитектуры. Программа должна вывести вопрос и три варианта ответа. 
            /////Пользователь должен выбрать правильный ответ и ввести его номер.

            Console.WriteLine("Дайте ответ на вопрос.");
            Console.ReadKey();

            Console.Clear();

            Console.WriteLine("Кто Архитектор Исаакиевского собора?");
            Console.WriteLine("1.Доменико Трезини\n2.Огюст Монферран\n3.Карл Росси");

            Console.ReadKey();
            Console.Clear();

            Console.Write("\nВведите номер правильного ответа и нажмите <Enter>: ");



            string name = Console.ReadLine();

            switch (name)
            {
                case "1":
                    Console.WriteLine("\nОтвет неверный! Верный ответ: Огюст Монферран!");
                    break;

                case "2":
                    Console.WriteLine("\nПоздравляю правильный ответ!)");
                    break;

                case "3":
                    Console.WriteLine("\nОтвет неверный! Верный ответ: Огюст Монферран!");
                    break;
            }
            Console.ReadKey();


            



        }
    }
}
