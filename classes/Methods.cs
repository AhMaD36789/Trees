namespace Trees.classes
{
    public static class Methods
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

            if (root.left == null && root.right == null)
            {
                values.Enqueue(root);
                return values;
            }

            while (stack.Count > 0)
            {
                Node current = stack.Pop();
                values.Enqueue(current);

                if (current.right != null)
                    stack.Push(current.right);

                if (current.left != null)
                    stack.Push(current.left);

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

            values.Enqueue(root);
            Queue<Node> left = DepthFirstRecursive(root.left); // [b,d,e]
            Queue<Node> right = DepthFirstRecursive(root.right); // [c,f]

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

                if (current.left != null)
                    values.Enqueue(current.left);
                if (current.right != null)
                    values.Enqueue(current.right);
            }

            return traversal;
        }

        public static bool BreadthFirstSearch(Node root, string searchFor)
        {
            if (
                root == null ||
                searchFor == null ||
                root.value != searchFor && root.left == null && root.right == null
                )

                return false;

            Queue<Node> values = new Queue<Node>();
            values.Enqueue(root);

            while (values.Count != 0)
            {
                Node current = values.Dequeue();

                if (current.value == searchFor)
                    return true;

                if (current.left != null)
                    values.Enqueue(current.left);

                if (current.right != null)
                    values.Enqueue(current.right);
            }

            return false;
        }

        public static bool DepthFirstSearch(Node root, string searchFor)
        {
            if (
                root == null ||
                searchFor == null ||
                root.value != searchFor && root.left == null && root.right == null
                )

                return false;

            if (root.value == searchFor)
                return true;

            if (DepthFirstSearch(root.left, searchFor) || DepthFirstSearch(root.right, searchFor))
                return true;

            return false;
        }

        public static int TreeSum(Node root)
        {
            if (root == null)
                return 0;

            if (root.left == null && root.right == null)
                return root.intValue;

            return root.intValue + TreeSum(root.left) + TreeSum(root.right);
        }

        public static int TreeMinRecursive(Node root)
        {
            if (root == null)
                return int.MaxValue;

            int min = Math.Min(TreeMinRecursive(root.left), TreeMinRecursive(root.right));

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

                if (current.left != null)
                    traversal.Enqueue(current.left);
                if (current.right != null)
                    traversal.Enqueue(current.right);
            }
            return minValue;
        }

        /// longest path between two nodes
        /// diameter of a binary tree: same code but instead of returning the value stored return 1
        /// instead of max combine all the values
        /// 

        /// the difference between the longest path in the left and the right == 1
        /// balanced tree: same code but instead of returning the value stored return 1
        /// the difference between left and right must equal at most 1
        /// 

        public static int MaxRootToLeafSum(Node root)
        {
            if (root == null)
                return int.MinValue;
            //return 0;

            if (root.left == null && root.right == null)
                return root.intValue;
            //return 1;

            return root.intValue +
                Math.Max
                (
                    MaxRootToLeafSum(root.left),
                    MaxRootToLeafSum(root.right)
                );
            // return 1 + MaxRootToLeafSum(root.left) + MaxRootToLeafSum(root.right);
        }

        public static int height(Node root)
        {
            if (root == null)
                return 0;

            if (root.left == null && root.right == null)
                return 1;

            int left = 0;
            int right = 0;

            left += height(root.left);
            right += height(root.right);
            return Math.Max(left, right) + 1;
        }

        public static void mirror(Node root)
        {
            if (root == null)
                return;

            Node temp = root.left;
            root.left = root.right;
            root.right = temp;

            mirror(root.left);
            mirror(root.right);
        }

        public static bool symmetric(Node root)
        {
            if (root == null)
                return false;

            if (root.left == null && root.right == null)
                return true;

            Queue<Node> queue = new Queue<Node>();

            queue.Enqueue(root.left);
            queue.Enqueue(root.right);

            while (queue.Count > 0)
            {
                Node left = queue.Dequeue();
                Node right = queue.Dequeue();

                if (left == null && right == null)
                    continue;

                if (left == null || right == null)
                    return false;

                if (left.value != right.value)
                    return false;

                queue.Enqueue(left.left);
                queue.Enqueue(right.right);
                queue.Enqueue(left.right);
                queue.Enqueue(right.left);

            }

            return true;
        }

        //recheck all below
        public static int ChildrenSumParent(Node root)
        {
            int leftData = 0;
            int rightData = 0;

            if (root == null || root.left == null && root.right == null)
                return 1;

            if (root.left != null)
                leftData = root.left.intValue;
            if (root.right != null)
                rightData = root.right.intValue;

            if (root.intValue == leftData + rightData &&
                ChildrenSumParent(root.left) == 1 &&
                ChildrenSumParent(root.right) == 1)
                return 1;
            else
                return 0;

        }

        public static bool IdenticalTrees(Node root1, Node root2)
        {
            if (root1 == null && root2 == null)
                return true;

            if (root1 == null || root2 == null)
                return false;

            if (root1.intValue != root2.intValue)
                return false;

            return IdenticalTrees(root1.left, root2.left) &&
            IdenticalTrees(root1.right, root2.right);

        }
    }
}
