using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timetable_Sujit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dunamic Timetable Generator");
            int workingDays = GetInput("Enter the number of working days (1-7):",1, 7);
            int subjectsPerDay = GetInput("Enter the number of subjects per day (1-8):", 1, 8);
            int totalSubjects = GetInput("Enter the total number of subjects:", 1, 10);

            int totalHours = workingDays * subjectsPerDay;
            
            if (totalHours != totalSubjects) {

                Console.WriteLine("Total hours for the week do not match total subjects. Please try again");
                Console.ReadLine();
                return;
            }

            string[,] timetable= new string[workingDays, subjectsPerDay];

            for(int day=0; day<workingDays; day++)
            {
                Console.WriteLine($"Enter subjects for Day {day + 1} ({subjectsPerDay} subjects):");
                for(int subject=0; subject<subjectsPerDay; subject++)
                {
                    Console.Write($"Subject {subject + 1}:");
                    timetable[day,subject]= Console.ReadLine();
                }
            }

            Console.WriteLine("\n Generated Timetable:");
            for(int day=0;day<workingDays; day++)
            {
                Console.WriteLine($"Day {day + 1}:");
                for (int subject=0;subject<subjectsPerDay; subject++)
                {
                    Console.WriteLine(timetable[day, subject]);
                    
                }

            }
            Console.ReadLine();


        }

        static int GetInput(string message,int minValue, int maxValue)
        {
            int value;
            do
            {
                Console.Write(message);
            }
            while (!int.TryParse(Console.ReadLine(), out value) || value < minValue || value > maxValue) ;
            return value;
        }
    }
}
