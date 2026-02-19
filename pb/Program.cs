

using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Tracing;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json.Serialization;
using ClassAndMethod;

namespace ClassAndMethod
{
    class Count
    {
        public static int sum(int add1, int add2)
        {
            int result = add1 + add2;
            return result;
        }
    }
}

namespace pb
{
    internal class Program
    {

        
        
        public class Customers() 
        {

            public int Id { get; set; }
            public string Name { get; set; }
            public int Telephone { get; set; }
        }
        static void Main(string[] args)
        {

            // Opdracht 1
            Console.WriteLine("Hello, World!\n This is my first c# program");

            // Opdracht 2
            Console.WriteLine("string \n short \n short\n int \n double");

            //Opdracht 3
            int x = 6;
            string y = "2";

            string result1 = x.ToString() + y;
            int result2 = x + int.Parse(y);

            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.WriteLine("Result 1 = 62 becuase you set the int to an string and add the y behind it'n result2 = 8 because you set y to an int and do them + eachother");

            //Opdracht 4
            Console.Write("Input Number: ");
            string sr = Console.ReadLine();
            int number = int.Parse(sr);


            try
            {
              if (number > 1 && number < 5)
              {
                    Console.WriteLine("In range");
              }
                else
                {
                    Console.WriteLine("Out of range");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Please enter a number between 1 and 5.");
            }

            //Opdracht 5
            Console.Write("Rect Width: ");
            string widths = Console.ReadLine();
            double width = Convert.ToDouble(widths);
            Console.Write("Rect Height: ");
            string heights = Console.ReadLine();
            double height = Convert.ToDouble(heights);
            Console.WriteLine($"The area of the rectangle is: {width * height}");

            //Opdracht 6
            Console.Write("Enter your birth year:");
            int birthYear = int.Parse(Console.ReadLine());
                int currentYear = DateTime.Now.Year;
                int age = currentYear - birthYear;
            Console.WriteLine($"You are {age} years old.");

            //Opdracht 7
            Console.Write("Enter my lucky number: ");
            ConsoleKeyInfo keyinfo = new ConsoleKeyInfo();
            keyinfo = Console.ReadKey();
            try
            {
                if (keyinfo.KeyChar == 5)
                {
                    Console.WriteLine("\nguessed number");
                }
                else
                {
                    Console.WriteLine("\nwrong number");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter a number between 1 and 5.");
            }

            //Opdracht 8
            Console.WriteLine("Whats my lucky word?");
            string word = Console.ReadLine();
            word.ToUpper();
            try
            {
                if (word == "LUCKY")
                {
                    Console.WriteLine("guessed word");
                }
                else
                {
                    Console.WriteLine("wrong word");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter the word lucky.");
            }

            //opdracht 9
            Console.WriteLine("Drink sizes: 1: Small, 2: Medium, 3: Large");
            Console.Write("Please enter your selection: ");
            int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("You selected Small.\nPlease insert 25 cents");
                        break;
                    case 2:
                        Console.WriteLine("You selected Medium.\nPlease insert 50 cents");
                        break;
                    case 3:
                        Console.WriteLine("You selected Large.\nPlease insert 75 cent");
                        break;
                    default:
                        Console.WriteLine("Invalid selection.");
                        break;
            }

            //opdracht 10
            for (int i = 1; i <= 10; i++)
            {
                if (i != 4)
                {
                    Console.WriteLine(i);
                }
            }

            //opdracht 11
            bool exited = false;
            ConsoleKeyInfo menuKeyInfo = new ConsoleKeyInfo();
            Console.WriteLine("**MENU**");
            Console.WriteLine("1. Menu 1");
            Console.WriteLine("2. Menu 2");
            Console.WriteLine("3. Exit");
            while (!exited)
            {
                menuKeyInfo = Console.ReadKey();
                try
                {
                    if (menuKeyInfo.KeyChar == '1')
                    {
                        Console.WriteLine("\nYou selected Menu 1");
                    }
                    else if (menuKeyInfo.KeyChar == '2')
                    {
                        Console.WriteLine("\nYou selected Menu 2");
                    }
                    else if (menuKeyInfo.KeyChar == '3')
                    {
                        Console.WriteLine("\nExiting...");
                        exited = true;
                    }
                    else
                    {
                        Console.WriteLine("\nInvalid selection. Please try again.");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("\nInvalid selection. Please try again.");
                }

            }

            //opdracht 12
            Console.WriteLine("Enter 5 names:");
            string[] names = new string[5];
            for (int i = 0; i < names.Length; i++)
            {
                Console.Write($"Name {i + 1}: ");
                names[i] = Console.ReadLine();
            }
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            //opdracht 13
            Console.WriteLine("Enter 5 numbers:");
            int[] numbers = new int[5];
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Number {i + 1}: ");
                try
                {
                    numbers[i] = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Please enter a valid number.");
                    i--; 
                }
            }
            foreach (int n in numbers)
            {
                Console.WriteLine(n);
            }

            //opdracht 14
            Console.WriteLine("13");

            //opdracht 15
            Console.WriteLine("Adding: \nPlease enter the first number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the second number");
            int num2 = int.Parse(Console.ReadLine());
          
            int total = Count.sum(num1, num2);
            Console.WriteLine($"The sum is {total}");

            //opdracht 16
            Console.WriteLine("Put in another folder calc");

            //opdracht 17
            string[] names1 = new string[5] { "Merry", "John", "Tim", "Matt", "Jeff" };
            try
            {
                Console.Write("Whats the length of the array: ");
                int lenth = int.Parse(Console.ReadLine());
                

                for (int i = 0; i < lenth; i++)
                {
                    Console.WriteLine(names1[i]);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Format error");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Out of range");
            }

            //opdracht 18

            Customers customer1 = new Customers();
            customer1.Id = 1;
            customer1.Name = "Merry";
            customer1.Telephone = 612345678;
            Customers customer2 = new Customers();
              customer2.Id = 2;
                customer2.Name = "John";
                customer2.Telephone = 612345677;
            Customers customer3 = new Customers();
              customer3.Id = 3;
                 customer3.Name = "Tim";
                 customer3.Telephone = 612345666;
            Customers customer4 = new Customers();
                customer4.Id = 4;
                    customer4.Name = "Matt";
                    customer4.Telephone = 61234555;
            Customers customer5 = new Customers();
                customer5.Id = 5;
                    customer5.Name = "Jeff";
                    customer5.Telephone = 61234444;
            List<Customers> customers = new List<Customers>();
              customers.Add(customer1);
                customers.Add(customer2);
                customers.Add(customer3);
                customers.Add(customer4);
                customers.Add(customer5);
            foreach (var customer in customers)
                {
                Console.WriteLine($"ID: {customer.Id}, Name: {customer.Name}, Telephone: {customer.Telephone}");
            }

            Console.ReadLine();


        }
    }
}