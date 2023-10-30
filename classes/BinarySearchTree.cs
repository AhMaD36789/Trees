namespace Trees.classes
{
    public class BinarySearchTree
    {
        public Node Root { get; set; }

        public bool Contains(int value)
        {
            Node traversal = Root;

            while (traversal != null)
            {
                if (traversal.intValue == value)
                    return true;

                else if (traversal.intValue > value)
                    traversal = traversal.Left;
                else
                    traversal = traversal.Right;

            }
            return false;
        }

        public void AddToBinarySearchTree(int value)
        {
            Node traversal = Root;

            while (true)
            {
                if (traversal.intValue == value)
                    throw new Exception("value already exists");

                if (value < traversal.intValue)
                    if (traversal.Left == null)
                    {
                        traversal.Left = new Node(value, "h");
                        break;
                    }
                    else
                        traversal = traversal.Left;

                else
                {
                    if (traversal.Right == null)
                    {
                        traversal.Right = new Node(value, "h");
                        break;
                    }
                    else
                        traversal = traversal.Right;
                }
            }
        }
    }
}
