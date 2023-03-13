using System;

namespace test1 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Select Day of Week");
            Console.WriteLine("1 = Monday");
            Console.WriteLine("2 = Tuesday");
            Console.WriteLine("3 = Wednesday");
            Console.WriteLine("4 = Thursday");
            Console.WriteLine("5 = Friday");
            Console.WriteLine("6 = Saturday");
            Console.WriteLine("7 = Sunday");
            Console.Write("Input Day of Week (Input number): ");
            int day = int.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------------");

            Console.WriteLine("Select Time of Day");
            Console.WriteLine("8 = 8.00");
            Console.WriteLine("9 = 9.00");
            Console.WriteLine("10 = 10.00");
            Console.WriteLine("11 = 11.00");
            Console.WriteLine("12 = 12.00");
            Console.WriteLine("13 = 13.00");
            Console.WriteLine("14 = 14.00");
            Console.WriteLine("15 = 15.00");
            Console.WriteLine("16 = 16.00");
            Console.WriteLine("17 = 17.00");
            Console.WriteLine("18 = 18.00");
            Console.Write("Input Time of Day (Input number): ");
            int time = int.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------------");

            Console.WriteLine("Select 1 Menu");
            Console.WriteLine("Breakfast Set");
            Console.WriteLine("Weekend Set");
            Console.WriteLine("Coffee");

            int i = 1;
            int breakfast_set = 5; // 
            int weekend_set = 2;
            int coffee = 3;
            while ((i <= 10) && (breakfast_set <= 5 && breakfast_set >= 0) && (weekend_set <=2 && weekend_set >= 0) && (coffee <= 3 && coffee >= 0)) {
                Console.Write("Input menu: ");
                string menu = Console.ReadLine();
                if ((menu == "Breakfast Set") && (breakfast_set > 0) && (time < 11) && (time >= 8)) {
                    breakfast_set = breakfast_set - 1;
                    i++;
                } else if ((menu == "Breakfast Set") && (breakfast_set == 0) && (time < 11) && (time >= 8)) {
                    Console.WriteLine("Sorry your order is out of stock");
                } else if ((menu == "Weekend Set") && (weekend_set > 0) && (day == 6) && (day >= 7)) {
                    weekend_set = weekend_set - 1;
                    i++;
                } else if ((menu == "Weekend Set") && (weekend_set == 0) && (day == 6) && (day >= 7)) {
                    Console.WriteLine("Sorry your order is out of stock");
                } else if ((menu == "Coffee") && (coffee > 0)) {
                    coffee = coffee - 1;
                    i++;
                } else if ((menu == "Coffee") && (coffee == 0)) {
                    Console.WriteLine("Sorry your order is out of stock");
                } else if ((menu != "Breakfast Set") || (menu != "Weekend Set") || (menu != "Coffee") || (menu != "End")) {
                    Console.WriteLine("Please enter a valid menu");
                } else if (((menu == "Breakfast Set") && ((time > 11) && (time <= 18))) || ((menu == "Weekend Set") && (day != 6) && (day != 7))) {
                    Console.WriteLine("Sorry your order is not available");
                } else if (menu == "End"){
                    break;
                }
            }
        }
    }
}
