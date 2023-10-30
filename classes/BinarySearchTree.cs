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
                    traversal = traversal.left;

                else
                    traversal = traversal.right;

            }
            return false;
        }

        public void AddToBinarySearchTreeIterative(int value)
        {
            Node traversal = Root;

            while (true)
            {
                if (traversal.intValue == value)
                    throw new Exception("value already exists");

                if (value < traversal.intValue)

                    if (traversal.left == null)
                    {
                        traversal.left = new Node(value, "h");
                        break;
                    }
                    else
                        traversal = traversal.left;

                else
                {
                    if (traversal.right == null)
                    {
                        traversal.right = new Node(value, "h");
                        break;
                    }
                    else
                        traversal = traversal.right;
                }
            }
        }
    }
}
