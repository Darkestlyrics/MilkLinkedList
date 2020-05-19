namespace Milk.LinkedList.Classes
{
    internal class TraversalResult
    {
        internal MilkNode PreviousNode { get; set; }
        internal MilkNode CurrentNode { get; set; }
        internal MilkNode NextNode { get; set; }

        public TraversalResult(MilkNode previousNode, MilkNode currentNode, MilkNode nextNode)
        {
            PreviousNode = previousNode;
            CurrentNode = currentNode;
            NextNode = nextNode;
        }
    }
}