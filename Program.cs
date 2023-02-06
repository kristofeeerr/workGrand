using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workGrandMouther
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberPeople;

            Console.Write($" Введите количество человек:");
            numberPeople = Convert.ToInt32( Console.ReadLine());

            int totalMinutes = numberPeople * 10;
            int hoursBeforeVisit = totalMinutes / 60;
            int minutesBeforeVisit = totalMinutes - (hoursBeforeVisit * 60); 

            Console.WriteLine($"Вы отстоите в очереди {hoursBeforeVisit} часа и {minutesBeforeVisit} минут");
        }
    }
}
