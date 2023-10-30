namespace Trees.classes
{
    public class Methods
    {

        public static void print(Queue<Node> nodes)
        {
            foreach (Node node in nodes)
            {
                Console.WriteLine(node.value);
            }
        }

        public static Queue<Node> DepthFirstIterative(Node root)
        {
            Stack<Node> stack = new Stack<Node>();
            Queue<Node> values = new Queue<Node>();

            stack.Push(root);
            if (root == null)
            {
                return values;
            }

            if (root.Left == null && root.Right == null)
            {
                values.Enqueue(root);
                return values;
            }

            while (stack.Count > 0)
            {
                Node current = stack.Pop();
                values.Enqueue(current);

                if (current.Right != null)
                    stack.Push(current.Right);

                if (current.Left != null)
                    stack.Push(current.Left);

            }

            return values;
        }

        public static Queue<Node> DepthFirstRecursive(Node root)
        {
            Queue<Node> values = new Queue<Node>();

            if (root == null)
            {
                return values;
            }

            Queue<Node> left = DepthFirstRecursive(root.Left); // [b,d,e]
            Queue<Node> right = DepthFirstRecursive(root.Right); // [c,f]

            values.Enqueue(root);

            while (left.Count > 0)
            {
                values.Enqueue(left.Dequeue());
            }

            while (right.Count > 0)
            {
                values.Enqueue(right.Dequeue());
            }

            return values;

        }

        public static Queue<Node> BreadthFirstIterative(Node root)
        {
            Queue<Node> values = new Queue<Node>();
            Queue<Node> traversal = new Queue<Node>();
            if (root == null)
                return values;

            values.Enqueue(root);

            while (values.Count != 0)
            {
                Node current = values.Dequeue();

                traversal.Enqueue(current);

                if (current.Left != null)
                    values.Enqueue(current.Left);
                if (current.Right != null)
                    values.Enqueue(current.Right);
            }

            return traversal;
        }

        public static bool BreadthFirstSearch(Node root, string searchFor)
        {
            if (
                root == null ||
                searchFor == null ||
                root.value != searchFor && root.Left == null && root.Right == null
                )

                return false;

            Queue<Node> values = new Queue<Node>();
            values.Enqueue(root);

            while (values.Count != 0)
            {
                Node current = values.Dequeue();

                if (current.value == searchFor)
                    return true;

                if (current.Left != null)
                    values.Enqueue(current.Left);

                if (current.Right != null)
                    values.Enqueue(current.Right);
            }

            return false;
        }

        public static bool DepthFirstSearch(Node root, string searchFor)
        {
            if (
                root == null ||
                searchFor == null ||
                root.value != searchFor && root.Left == null && root.Right == null
                )

                return false;

            if (root.value == searchFor)
                return true;

            if (DepthFirstSearch(root.Left, searchFor) || DepthFirstSearch(root.Right, searchFor))
                return true;

            return false;
        }

        public static int TreeSum(Node root)
        {
            if (root == null)
                return 0;

            if (root.Left == null && root.Right == null)
                return root.intValue;

            return root.intValue + TreeSum(root.Left) + TreeSum(root.Right);
        }

        public static int TreeMinRecursive(Node root)
        {
            if (root == null)
                return int.MaxValue;

            int min = Math.Min(TreeMinRecursive(root.Left), TreeMinRecursive(root.Right));

            return Math.Min(min, root.intValue);
        }

        public static int TreeMinIterative(Node root)
        {
            if (root == null)
                return int.MaxValue;

            int minValue = int.MaxValue;

            Queue<Node> traversal = new Queue<Node>();
            traversal.Enqueue(root);

            while (traversal.Count > 0)
            {
                Node current = traversal.Dequeue();

                if (current.intValue < minValue)
                {
                    minValue = current.intValue;
                }

                if (current.Left != null)
                    traversal.Enqueue(current.Left);
                if (current.Right != null)
                    traversal.Enqueue(current.Right);
            }
            return minValue;
        }
        public static int MaxRootToLeafSum(Node root)
        {
            if (root == null)
                return int.MinValue;

            if (root.Left == null && root.Right == null)
                return root.intValue;

            return root.intValue +
                Math.Max
                (
                    MaxRootToLeafSum(root.Left),
                    MaxRootToLeafSum(root.Right)
                );
        }
    }
}
