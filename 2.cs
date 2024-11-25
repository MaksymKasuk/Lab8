using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab8
{
    internal class _2
    {

        delegate void DaySchedule();

        static void Main(string[] args)
        {
            Console.WriteLine("Введіть номер дня тижня (1-7):");
            string input = Console.ReadLine();

            int day;
            if (!int.TryParse(input, out day) || day < 1 || day > 7)
            {
                Console.WriteLine("Введено некоректний номер дня");
                return;
            }

            DaySchedule schedule = null;

            if (day == 1) schedule = Monday;
            else if (day == 2) schedule = Tuesday;
            else if (day == 3) schedule = Wednesday;
            else if (day == 4) schedule = Thursday;
            else if (day == 5) schedule = Friday;
            else if (day == 6) schedule = Saturday;
            else if (day == 7) schedule = Sunday;

            if (schedule != null)
            {
                schedule.Invoke();
            }
        }

        static void Monday() => Console.WriteLine("Понеділок: Математика, Фізика, Історія");
        static void Tuesday() => Console.WriteLine("Вівторок: Хімія, Література, Англійська");
        static void Wednesday() => Console.WriteLine("Середа: Географія, Біологія, Музика");
        static void Thursday() => Console.WriteLine("Четвер: Інформатика, Трудове, Фізика");
        static void Friday() => Console.WriteLine("П'ятниця: Література, Математика, Фізкультура");
        static void Saturday() => Console.WriteLine("Субота: Історія, Мистецтво, Вільний час");
        static void Sunday() => Console.WriteLine("Неділя: Вихідний день");
    }
}
