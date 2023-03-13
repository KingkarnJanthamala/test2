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
            int food = 10; // food คือ จำนวนชุดอาหาร
            while (i <= 10) {
                Console.Write("Input menu: ");
                string menu = Console.ReadLine();
                if ((menu == "Breakfast Set") || (menu == "Weekend Set") || (menu == "Coffee")) {
                    if (((menu == "Breakfast Set") && ((time > 11) && (time <= 18))) || ((menu == "Weekend Set") && (day != 6) && (day != 7))) {
                        Console.WriteLine("Sorry your order is not available");
                        continue;
                    } else {
                        if (food >= 1) {
                            food = food - i; // food คือ จำนวนชุดอาหาร
                        } else if (food == 0) {
                            Console.WriteLine("Sorry your order is out of stock");
                            continue;
                        }
                    }   
                } else if ((menu != "Breakfast Set") || (menu != "Weekend Set") || (menu != "Coffee") || (menu != "End")) {
                    Console.WriteLine("Please enter a valid menu");
                    continue;
                } else if (menu == "End"){
                    break;
                }
                i++;
            }
        }
    }
}