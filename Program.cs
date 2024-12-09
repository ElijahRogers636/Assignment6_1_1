
using System;

namespace Assignment6_1_1
{
    //Implement a single linked list with each node representing a house.
    //You may add data in it like house number, brief address, type of house(like Ranch, Colonial).
    //each house(node) will be linked to next.
    //Give facility to the user to search a house by its number and then display the details. (Windows / Console)
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomLinkedList houses = new CustomLinkedList();
            House curr;
            int inputHouseNum = 2;
            houses.AddFirst(new House { HouseNum = 1, Address = "Place", HouseType = "Victorian" });
            houses.AddLast(new House { HouseNum = 2, Address = "Place 2", HouseType = "Old" });
            houses.AddLast(new House { HouseNum = 3, Address = "Place 3", HouseType = "Trailer" });

            curr = houses.FindElement(inputHouseNum);
            Console.WriteLine($"House Number: { curr.HouseNum }\nAddress: { curr.Address }\nHouse Type: { curr.HouseType }");
            Console.WriteLine();

            inputHouseNum = 1;
            curr = houses.FindElement(inputHouseNum);
            Console.WriteLine($"House Number: { curr.HouseNum }\nAddress: { curr.Address }\nHouse Type: { curr.HouseType }");
            Console.WriteLine();

            inputHouseNum = 3;
            curr = houses.FindElement(inputHouseNum);
            Console.WriteLine($"House Number: { curr.HouseNum }\nAddress: { curr.Address }\nHouse Type: { curr.HouseType }");
            Console.WriteLine();

            inputHouseNum = 4;
            curr = houses.FindElement(inputHouseNum);
            Console.WriteLine($"House Number: { curr.HouseNum }\nAddress: { curr.Address }\nHouse Type: { curr.HouseType }");
            Console.WriteLine();

        }
    }
}
