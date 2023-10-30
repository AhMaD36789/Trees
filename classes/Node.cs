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

        public Node(int value)
        {
            this.intValue = value;
            Left = null;
            Right = null;
        }
        public Node(int intvalue, string Value)
        {
            value = Value;
            intValue = intvalue;
            Left = null;
            Right = null;
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

            //a.Left = b;
            //a.Right = c;
            //b.Left = d;
            //b.Right = e;
            //c.Right = f;

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

            a.Left = b;
            a.Right = c;
            b.Left = d;
            b.Right = e;
            c.Left = f;
            c.Right = g;

            return a;

            //             a5
            //           /   \
            //         b11    c3
            //         / \     \
            //       d4  e15    f12

        }

    }
}
