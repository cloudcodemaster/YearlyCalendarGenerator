
    Console.WriteLine("Enter the year: ");
    int year;
    while (!int.TryParse(Console.ReadLine(), out year) || year <= 0)
    {
        Console.WriteLine("Invalid input. Please enter a valid year: ");
    }

    DisplayYearlyCalendar(year);
    

    static void DisplayYearlyCalendar(int year)
    {
        string[] months = 
        {
            "January", "February", "March", "April", "May", "June", 
            "July", "August", "September", "October", "November", "December"
        };

        for (int month = 1; month <= 12; month++)
        {
            Console.WriteLine($"\n{months[month - 1]} {year}");
            Console.WriteLine("Su Mo Tu We Th Fr Sa");

            int daysInMonth = DateTime.DaysInMonth(year, month);
            int startDay = (int)new DateTime(year, month, 1).DayOfWeek;

            for (int i = 0; i < startDay; i++)
            {
                Console.Write("   ");
            }

            for (int day = 1; day <= daysInMonth; day++)
            {
                Console.Write($"{day,2} ");
                if ((day + startDay) % 7 == 0)
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
        }
    }

