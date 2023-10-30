namespace Trees.classes
{
    public class Node
    {
        public string value { get; set; }
        public int intValue { get; set; }
        public Node? left { get; set; }
        public Node? right { get; set; }

        public Node()
        {
            value = string.Empty;
            left = null;
            right = null;
        }

        public Node(string value)
        {
            this.value = value;
            left = null;
            right = null;
        }

        public Node(int value)
        {
            this.intValue = value;
            left = null;
            right = null;
        }
        public Node(int intvalue, string Value)
        {
            value = Value;
            intValue = intvalue;
            left = null;
            right = null;
        }

        public Node TreeInitialization()
        {
            ///old testing values
            ///

            //Node a = new Node("a");
            //Node b = new Node("b");
            //Node c = new Node("c");
            //Node d = new Node("d");
            //Node e = new Node("e");
            //Node f = new Node("f");

            //a.intValue = 5;
            //b.intValue = 11;
            //c.intValue = 3;
            //d.intValue = 4;
            //e.intValue = 15;
            //f.intValue = 12;

            //a.left = b;
            //a.right = c;
            //b.left = d;
            //b.right = e;
            //c.right = f;

            Node a = new Node("a");
            Node b = new Node("b");
            Node c = new Node("c");
            Node d = new Node("d");
            Node e = new Node("e");
            Node f = new Node("f");
            Node g = new Node("g");

            a.intValue = 7;
            b.intValue = 4;
            c.intValue = 12;
            d.intValue = 3;
            e.intValue = 5;
            f.intValue = 11;
            g.intValue = 15;

            a.left = b;
            a.right = c;
            b.left = d;
            b.right = e;
            c.left = f;
            c.right = g;

            return a;

            //             a5
            //           /   \
            //         b11    c3
            //         / \     \
            //       d4  e15    f12

        }

    }
}
