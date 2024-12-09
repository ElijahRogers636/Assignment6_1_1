using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6_1_1
{
    public class CustomLinkedList
    {
        public Node Head { get; set; }
        public int Length { get; set; } = 0;

        public void AddFirst(House data)
        {
            Node newNode = new Node(data);
            Head = newNode;
            Length++;
        }

        public void AddLast(House data)
        {

            Node new_node = new Node(data);
            Node current = Head;
            if (Head == null)
            {
                Head = new_node;
                return;
            }

            while (current.Next != null)
            {
                current = current.Next;
            }

            current.Next = new_node;
            Length++;

        }

        public House FindElement(int houseNumber)
        {
            Node current = Head;
            House house = new House { HouseNum = 0, Address = "None", HouseType = "None"  };
            while (current != null)
            {
                if (current.Data.HouseNum == houseNumber)
                {
                    return current.Data;
                }
                current = current.Next;
            }
            return house;
        }
    }
}
