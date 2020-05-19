using System;
using System.Collections.Generic;
using System.Text;

namespace Milk.LinkedList.Classes
{
    public class MilkNode
    {
        public MilkNode PreviousNode { get; set; }
        public MilkNode NextNode { get; set; }
        public object Data { get; set; } //technically cheating but it needs something for the ToString

        public MilkNode(MilkNode prev, object data, MilkNode nextNode = null)
        {
            PreviousNode = prev;
            NextNode = nextNode;
            Data = data;
        }

        public override string ToString()
        {
            return Data.ToString();
        }
    }
}
