using BankAreUSEFCore.Domain.Models;
using System;
using System.Linq;
using BankAreUSEFCore.Data;
using static System.Console;

namespace BankAreUSEFCore
{
    class Program
    {

        static BankAreUsContext context = new BankAreUsContext();
        static void Main(string[] args)
        {
            Program.Menu();
        }
        static void Menu()
        {
            bool shouldNotExit = true;

            while (shouldNotExit)
            {


                Clear();

                WriteLine("1.Registrera kund");
                WriteLine("2.Lable2");
                WriteLine("3.Lable3");
                WriteLine("4. Exit");

                ConsoleKeyInfo keyPressed = ReadKey(true);


                switch (keyPressed.Key)
                {

                    case ConsoleKey.D1:

                        RegisterCustomer();

                        break;

                    case ConsoleKey.D2:

                        break;

                    case ConsoleKey.D3:

                        break;

                    case ConsoleKey.D4:

                        shouldNotExit = false;

                        break;

                }

            }
        }

        private static void RegisterCustomer()
        {
            bool isCorrect = false;

            Customer customer =null;

            do
            {
                Clear();

                WriteLine("Förnamn: ");
                string firstName = ReadLine();
                WriteLine("Efternamn: ");
                string LastName = ReadLine();
                WriteLine("Personummer: ");
                string socialSecurityNumber = ReadLine();
                WriteLine("Gata: ");
                string street = ReadLine();
                WriteLine("Ort: ");
                string city = ReadLine();
                WriteLine("Postnummer: ");
                string zipCode = ReadLine();


                Console.WriteLine("Är detta korrekt? (J)a (N)ej");

                ConsoleKeyInfo input = ReadKey(true);
                bool isValidKey;

                do
                {

                    input = ReadKey(true);

                    isValidKey = input.Key == ConsoleKey.J || input.Key == ConsoleKey.N;


                } while (!isValidKey);



                if (input.Key == ConsoleKey.J)
                {
                    isCorrect = true;
                    Address address = new Address(street, city, zipCode);


                    customer = new Customer(firstName, LastName, socialSecurityNumber, address);

                    SaveCustomer(customer);

                }




            } while (!isCorrect);





        }

        private static void SaveCustomer(Customer customer)
        {
            context.Customer.Add(customer);

            context.SaveChanges();

        }
    }
}
