using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's find out what weekday you were born!");

            while (true)
            {
                // Get year from user
                Console.Write("What year were you born (4 digits)? ");
                int input_year;
                bool isValidYear = int.TryParse(Console.ReadLine(), out input_year);

                //CHECK - if user input i 4 digits
                if (isValidYear && input_year >= 1000 && input_year <= 9999)
                {

                    int m;
                    string m_display;
                    while (true)
                    {
                        // Get month from user
                        Console.Write("What month were you born (1-12 digits)? ");
                        m = Convert.ToInt32(Console.ReadLine());

                        //CHECK - if user input is 1-12 digits
                        if (m >= 1 && m <= 12)
                        {

                            m_display = m.ToString("D2");

                            if (m < 3)
                            {
                                m = m + 12;
                                input_year = input_year - 1;
                            }


                            int c = input_year / 100;
                            int y = input_year % 100;


                            int d;
                            string d_display;
                            while (true)
                            {

                                // Get day from user
                                Console.Write("What day were you born (1-31 digits)? ");
                                d = Convert.ToInt32(Console.ReadLine());

                                //CHECK - if user input is between 1-31 digits
                                if (d >= 1 && d <= 31)
                                {

                                    d_display = d.ToString("D2");
                                    //console date formatted
                                    Console.WriteLine($"Birthdate: {c}{y}:{m_display}:{d_display}");

                                    int calc1 = (13 * (m + 1)) / 5;
                                    int calc2 = y + (y / 4) + (c / 4) + 5 * c;
                                    int weekday = (d + calc1 + calc2) % 7;

                                    // Array with weekdays
                                    string[] weekdays = { "Saturday", "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };

                                    // Output the correct weekday 
                                    string wd = weekdays[weekday];
                                    Console.WriteLine($"Day of the week: {wd}");

                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Invalid input. Please enter a day with a number between 1-31.");
                                }
                            }
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a month with a number between 1-12.");
                        }
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a 4-digit year.");
                }
            }
        }
    }
}
