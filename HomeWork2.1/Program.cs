using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2._1
{
    class Program
    {
        static void Main(string[] args)



        {
            #region 89
            //Услуги телефонной сети оплачиваются по следующему правилу: за разговоры до А минут в месяц — В грн., 
            //а разговоры сверх установленной нормы оплачиваются из расчета С грн. за минуту.
            //Написать программу, вычисляющую плату за пользование телефоном для введенного времени разговоров за месяц

            //Console.Write("Введіть час телефоних розмов протягом місяця,в хв.: ");

            //string number = Console.ReadLine();
            //double numb = Double.Parse(number);

            //double minPrice = 0.5;
            //double maxPrice = 0.8;

            //Console.Write($"Тариф до 1000 хв., коштує {minPrice} за хв.\nТариф від 1000 хв., коштує {maxPrice} за хв."); ;

            //Console.ReadKey();
            //Console.Clear();

            //if (numb < 1000)
            //{
            //    Console.WriteLine("Вартість {0} грн.", numb * minPrice);
            //}
            //else
            //{
            //    Console.WriteLine("Вартість {0} грн.", numb * maxPrice);
            //}
            //Console.ReadKey();
            #endregion

            #region 91
            //Грузовой автомобиль выехал из одного города в другой со скоростью V1 км/ч.
            //Через t ч в этом же направлении выехал легковой автомобиль со скоростью V2 км/ч.
            //Составить программу, определяющую, догонит ли легковой автомобиль грузовой через t1 ч после своего выезда.

            //Console.Write("Ведіть швидкість першого автомобіля, км/год : ");
            //string speed = Console.ReadLine();
            //double speedCar1 = Double.Parse(speed);


            //Console.Clear();

            //Console.Write("Ведіть час виїзду другого автомобіля, год : ");
            //string time = Console.ReadLine();
            //double timeCar2 = Double.Parse(time);

            //Console.Write("Ведіть швидкість другого автомобіля, км/год : ");
            //string speed1 = Console.ReadLine();
            //double speedCar2 = Double.Parse(speed1);


            //Console.Clear();

            //Console.Write("Ведіть час: ");
            //string userTime = Console.ReadLine();
            //double uTime = Double.Parse(userTime);

            //double way1 = speedCar1 * (timeCar2+uTime);
            //double way2 = speedCar2 * uTime;

            //Console.Clear();

            //if (way2 < way1)
            //{
            //    Console.WriteLine("Другий автомобіль не догнав перший! Відстань між ними {0}", way1 - way2);
            //}
            //else if (way2 > way1)
            //{
            //    Console.WriteLine("Другий автомобіль обігнав перший! Відстань між ними {0}", way2 - way1);
            //}
            //else
            //{
            //    Console.WriteLine("Другий автомобіль догнав перший! Відстань між ними {0}", way2 - way1);
            //}

            //Console.ReadKey();

            #endregion

            #region 122
            //Составить программу, осуществляющую перевод величин из радиан в градусы и наоборот. 
            //Программа должна запрашивать, какой перевод нужно осуществить, и выполнять указанное действие

            //Console.WriteLine("Оберіть:\n1. Радіан в Градус\n2. Градус в Радіан");

            //string number = Console.ReadLine();


            //switch (number)
            //{
            //    case "1":
            //        Console.Write("Ведіть число: ");
            //        string numb = Console.ReadLine();
            //        double rad = Double.Parse(numb);

            //        double resultCels = rad/ 0.0174533;
            //        Console.WriteLine($"Радіан: {rad} - Градус: {resultCels}");

            //        break;

            //    case "2":
            //        Console.Write("Ведіть число: ");
            //        string numb1 = Console.ReadLine();
            //        double cels = Double.Parse(numb1);

            //        double resultRad = cels * 0.0174533;
            //        Console.WriteLine($"Градус: {cels} - Радіан: {resultRad}");

            //        break;
            //}
            //Console.ReadKey();

            #endregion

            #region 127
            //Составить программу, которая проверяет, не приводит ли суммирование двух целых чисел А и В к переполнению (то есть к результату, большему чем 32 767).
            //При переполнении сообщить об этом, иначе вывести сумму этих чисел.

            //Console.Write("Ведіть перше число: ");
            //string number1 = Console.ReadLine();
            //int a = Int32.Parse(number1);

            //Console.Write("Ведіть друге число: ");
            //string number2 = Console.ReadLine();
            //int b = Int32.Parse(number1);

            //int result = a + b;

            //if (result < 32767 && result > -32768)
            //{
            //    Console.WriteLine($"Сума двох чисел не виходить з діапазона 32767...-32768, сума:{result}");
            //}
            //else
            //{
            //    Console.WriteLine("Помилка");
            //}
            //Console.ReadKey();
            #endregion

            #region 128

            //Написать программу, которая по паролю определяет уровень доступа сотрудника к секретной информации в базе данных.
            //Доступ к базе имеют только шесть человек, разбитых на три группы по уровням доступа.
            //Они имеют следующие пароли: 9583, 1747 — доступны модули баз А, В, С; 3331, 7922 — доступны модули баз В, С; 9455, 8997 — доступен модуль базы С.

            //Console.Write("Ведіть свій пароль: ");
            //string numb = Console.ReadLine();
            //int pass = Int32.Parse(numb);

            //Console.Clear();

            //switch (pass)
            //{
            //    case 9583:
            //    Console.WriteLine("Вам доступні бази: A,B,C");
            //    break;

            //    case 1747:
            //        Console.WriteLine("Вам доступні бази: A,B,C");
            //        break;

            //    case 3331:
            //    Console.WriteLine("Вам доступні бази: B,C");
            //    break;

            //    case 7922:
            //        Console.WriteLine("Вам доступні бази: B,C");
            //        break;

            //    case 9455 :
            //    Console.WriteLine("Вам доступні бази: B,C");
            //    break;

            //    case 8997:
            //        Console.WriteLine("Вам доступні бази: B,C");
            //        break;

            //    default:
            //        Console.WriteLine("Порушник!!!");
            //        Console.Beep();
            //        Console.Beep();
            //        Console.Beep();
            //        Console.Beep();
            //        Console.Beep();
            //        Console.Beep();
            //        Console.Beep();
            //        Console.Beep();

            //        break;
            //}

            //Console.ReadKey();
            #endregion

            #region 129
            //Составить программу, имитирующую применения компьютера в книжном магазине.
            //Компьютер запрашивает стоимость книг, сумму денег, внесенную покупателем; 
            //если сдачи не требуется, печатает на экране «спасибо»; если денег внесено больше, чем необходимо, то печатает «возьмите сдачу» и указывает сумму сдачи;
            //если денег недостаточно, то печатает сообщение об этом и указывает размер недостающей суммы.

            //Console.Write("Ведіть ціну книги: ");
            //string a = Console.ReadLine();
            //double price = Double.Parse(a);

            //Console.Write("Заплатіть за книгу: ");
            //string b = Console.ReadLine();
            //double money = Double.Parse(b);

            //if (price > money)
            //{
            //    Console.WriteLine("Ви заплатили не повну ціну доплатіть {0} грн.", price - money);
            //}
            //else if (price < money)
            //{
            //    Console.WriteLine("Дякую за покупку, заберіть решту {0} грн.", money - price);
            //}
            //else
            //{
            //    Console.WriteLine("Дякую, що без  решти");
            //}
            //Console.ReadKey();
            #endregion

            #region 130
            //. В ЭВМ поступают результаты соревнований по плаванию для трех спортсменов.
            //Составить программу, которая выбирает лучший результат и выводит его на экран с сообщением о том,
            //что это результат победителя заплыва.

            //Console.WriteLine("Час першого плавуна: ");
            //string a = Console.ReadLine();
            //double time1 = Double.Parse(a);

            //Console.WriteLine("Час другого плавуна: ");
            //string b = Console.ReadLine();
            //double time2 = Double.Parse(b);

            //Console.WriteLine("Час третього плавуна: ");
            //string c = Console.ReadLine();
            //double time3 = Double.Parse(c);



            //if (time1 < time2 && time1 < time3)
            //{
            //    Console.WriteLine("Плавець 1 виграв!");
            //}
            //else if (time2 < time1 && time2 < time3)
            //{
            //    Console.WriteLine("Плавець 2 виграв!");
            //}
            //else if (time3 < time1 && time3 < time2)
            //{
            //    Console.WriteLine("Плавець 3 виграв!");
            //}
            //Console.ReadKey();

            #endregion

            #region 135
            //Даны три вещественных числа a, b, с. Проверить:
            //а) выполняется ли неравенство а < b < с;
            //б) выполняется ли неравенство b > а > с.

            Console.Write("Число 1: ");
            string a = Console.ReadLine();
            double number1 = Double.Parse(a);

            Console.Write("Число 2: ");
            string b = Console.ReadLine();
            double number2 = Double.Parse(b);

            Console.Write("Число 3: ");
            string c = Console.ReadLine();
            double number3 = Double.Parse(c);



            if (number1<number2&&number1<number3)
            {
                Console.WriteLine(number1);
            }
            else if (number2<number1&&number2<number3)
            {
                Console.WriteLine(number2);
            }
            else if (number3<number1&&number3<number2)
            {
                Console.WriteLine(number3);
            }
            Console.ReadKey();
            #endregion
        }


    }
}
