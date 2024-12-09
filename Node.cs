using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6_1_1
{
    public class Node
    {
        public Node Next { get; set; }
        public House Data { get; set; }

        public Node(House h) 
        {
            Data = h;
            Next = null;
        }
    }
}
