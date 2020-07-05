using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace HomeWorkMore
{
    class Program
    {
       
        static void Main(string[] args)
        {
            
            Console.Write("Привіт, я Нагибатор3000!!))");
            Console.ReadKey();
            Console.Clear();

            Console.Write("Скільки тобі рочків?: ");
            string a = Console.ReadLine();
            int age = Int32.Parse(a);
                        
            Console.Clear();
                    

            if (age >= 18)
            {
                Console.Write("Все круто, робимо ставку: ");
                string b = Console.ReadLine();
                double bet = Double.Parse(b);

                String[] greeting = { "Овва, поїхали))", "Да ти багач!", "Що так мало, давай ще!", "Дивись не програй останні носки!" };
                Random rnd = new Random();
                int index = rnd.Next(0, greeting.Length);
                Console.WriteLine($"{greeting[index]}");

                Console.ReadKey();
                Console.Clear();

                var rand = new Random();
                int val = rand.Next(1, 1);
                int val1 = rand.Next(1, 1);
                int val2 = rand.Next(0, 0);

                Console.WriteLine($"{val}{val1}{val2}");

                string value = Convert.ToString(val);
                string value1 = Convert.ToString(val1);
                string value2 = Convert.ToString(val2);

                Console.Clear();

                string allValue = value + value1 + value2;
                
                switch (allValue)
                {
                    case "000":
                        double win = bet * 10 * 1.5;
                        Console.WriteLine($"Мої вітання !!! Ви виграли: {win}");
                        break;
                    case "111":
                        double win1 = bet * 10 * 1.5;
                        Console.WriteLine($"Мої вітання !!! Ви виграли: {win1}");
                        break;
                    case "222":
                        double win2 = bet * 10 * 1.5;
                        Console.WriteLine($"Мої вітання !!! Ви виграли: {win2}");
                        break;
                }
             /// ТУТ Я ЗДАЮСЬ, ВЗАГАЛІ НЕ РОЗУМІЮ ... 

            }
            else
            {
                Console.WriteLine("Сорямба , підрости трошки, тобі ще рано)))");
            }
            Console.ReadKey();
        }
        
    }
}
