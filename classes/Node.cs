namespace Trees.classes
{
    public class Node
    {
        public string value { get; set; }
        public int intValue { get; set; }
        public Node? Left { get; set; }
        public Node? Right { get; set; }

        public Node()
        {
            value = string.Empty;
            Left = null;
            Right = null;
        }

        public Node(string value)
        {
            this.value = value;
            Left = null;
            Right = null;
        }

        public Node TreeInitialization()
        {
            Node a = new Node("a");
            Node b = new Node("b");
            Node c = new Node("c");
            Node d = new Node("d");
            Node e = new Node("e");
            Node f = new Node("f");

            a.intValue = 5;
            b.intValue = 11;
            c.intValue = 3;
            d.intValue = 4;
            e.intValue = 15;
            f.intValue = 12;

            a.Left = b;
            a.Right = c;
            b.Left = d;
            b.Right = e;
            c.Right = f;

            return a;

            //             a5
            //           /   \
            //         b11    c3
            //         / \     \
            //       d4  e15    f12

        }

        public Queue<Node> DepthFirstIterative(Node root)
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
                Console.WriteLine(current.value);

                if (current.Right != null)
                    stack.Push(current.Right);

                if (current.Left != null)
                    stack.Push(current.Left);

            }

            return values;
        }

        public Queue<Node> DepthFirstRecursive(Node root)
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
    }
}
