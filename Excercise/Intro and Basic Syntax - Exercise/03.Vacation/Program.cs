using System;

namespace _03.Vacation
{
    class Program
    {
        static void Main()
        {
            double numberOfGroup = double.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string dayOfWeekend = Console.ReadLine();

            double pricePerPerson = 0.00;
            double totalPrice = 0.00;
            double discount = 0.00;
            double price = 0.00;

            if (dayOfWeekend == "Friday")
            {
                if (typeOfGroup == "Students")
                {
                    pricePerPerson = 8.45;
                    if (numberOfGroup >= 30)
                    {
                        totalPrice = (numberOfGroup * pricePerPerson);
                        discount = totalPrice * 0.15;
                        price = totalPrice - discount;
                        Console.WriteLine($"Total price: {price:F2}");
                    }
                    else
                    {
                        totalPrice = numberOfGroup * pricePerPerson;
                        Console.WriteLine($"Total price: {totalPrice:F2}");
                    }
                }
                else if (typeOfGroup == "Business")
                {
                    pricePerPerson = 10.90;
                    if (numberOfGroup >= 100)
                    {
                        totalPrice = ((numberOfGroup-10) * pricePerPerson);
                        Console.WriteLine($"Total price: {totalPrice:F2}");
                    }
                    else
                    {
                        totalPrice = numberOfGroup * pricePerPerson;
                        Console.WriteLine($"Total price: {totalPrice:F2}");
                    }
                }
                else if (typeOfGroup == "Regular")
                {
                    pricePerPerson = 15.00;
                    if (numberOfGroup >= 10 && numberOfGroup<=20)
                    {
                        totalPrice = (numberOfGroup * pricePerPerson);
                        discount = totalPrice * 0.05;
                        price = totalPrice - discount;
                        Console.WriteLine($"Total price: {price:F2}");
                    }
                    else
                    {
                        totalPrice = numberOfGroup * pricePerPerson;
                        Console.WriteLine($"Total price: {totalPrice:F2}");
                    }
                }
            }
            else if (dayOfWeekend == "Saturday")
            {
                if (typeOfGroup == "Students")
                {
                    pricePerPerson = 9.80;
                    if (numberOfGroup >= 30)
                    {
                        totalPrice = (numberOfGroup * pricePerPerson);
                        discount = totalPrice * 0.15;
                        price = totalPrice - discount;
                        Console.WriteLine($"Total price: {price:F2}");
                    }
                    else
                    {
                        totalPrice = numberOfGroup * pricePerPerson;
                        Console.WriteLine($"Total price: {totalPrice:F2}");
                    }
                }
                else if (typeOfGroup == "Business")
                {
                    pricePerPerson = 15.60;
                    if (numberOfGroup >= 100)
                    {
                        totalPrice = ((numberOfGroup - 10) * pricePerPerson);
                        Console.WriteLine($"Total price: {totalPrice:F2}");
                    }
                    else
                    {
                        totalPrice = numberOfGroup * pricePerPerson;
                        Console.WriteLine($"Total price: {totalPrice:F2}");
                    }
                }
                else if (typeOfGroup == "Regular")
                {
                    pricePerPerson = 20.00;
                    if (numberOfGroup >= 10 && numberOfGroup <= 20)
                    {
                        totalPrice = (numberOfGroup * pricePerPerson);
                        discount = totalPrice * 0.05;
                        price = totalPrice - discount;
                        Console.WriteLine($"Total price: {price:F2}");
                    }
                    else
                    {
                        totalPrice = numberOfGroup * pricePerPerson;
                        Console.WriteLine($"Total price: {totalPrice:F2}");
                    }
                }
            }
            if (dayOfWeekend == "Sunday")
            {
                if (typeOfGroup == "Students")
                {
                    pricePerPerson = 10.46;
                    if (numberOfGroup >= 30)
                    {
                        totalPrice = (numberOfGroup * pricePerPerson);
                        discount =totalPrice * 0.15;
                        price = totalPrice - discount;
                        Console.WriteLine($"Total price: {price:F2}");
                    }
                    else
                    {
                        totalPrice = numberOfGroup * pricePerPerson;
                        Console.WriteLine($"Total price: {totalPrice:F2}");
                    }
                }
                else if (typeOfGroup == "Business")
                {
                    pricePerPerson = 16.00;
                    if (numberOfGroup >= 100)
                    {
                        totalPrice = ((numberOfGroup - 10) * pricePerPerson);
                        Console.WriteLine($"Total price: {totalPrice:F2}");
                    }
                    else
                    {
                        totalPrice = numberOfGroup * pricePerPerson;
                        Console.WriteLine($"Total price: {totalPrice:F2}");
                    }
                }
                else if (typeOfGroup == "Regular")
                {
                    pricePerPerson = 22.50;
                    if (numberOfGroup >= 10 && numberOfGroup <= 20)
                    {
                        totalPrice = (numberOfGroup * pricePerPerson);
                        discount =totalPrice * 0.05;
                        price = totalPrice - discount;
                        Console.WriteLine($"Total price: {price:F2}");
                    }
                    else
                    {
                        totalPrice = numberOfGroup * pricePerPerson;
                        Console.WriteLine($"Total price: {totalPrice:F2}");
                    }
                }
            }
        }
    }
}