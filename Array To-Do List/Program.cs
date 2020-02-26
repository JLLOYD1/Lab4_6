using System;
using System.Collections;


namespace Array_To_Do_List
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Days = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            string[] Tasks = new string[7];

            for (int i = 0; i < Days.Length; i++)
            {
                Console.WriteLine(" Type your plans for the day" + Days[i]);
                Tasks[i] = Days[i] + ":" + Console.ReadLine();
            }

            for (int i = 0; i < Days.Length; i++) 
            {
                Console.WriteLine(Tasks[i]);
            }
        }
    }
}
