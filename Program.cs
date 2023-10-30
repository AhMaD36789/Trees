using Trees.classes;

namespace Trees
{
    public class Program
    {
        static void Main(string[] args)
        {
            Node test = new Node();

            test = test.TreeInitialization();


            var depthFirstIterative = Methods.DepthFirstIterative(test);

            //Methods.print(depthFirstIterative);

            //Console.WriteLine();

            var depthFirstRecursive = Methods.DepthFirstRecursive(test);

            //Methods.print(depthFirstRecursive);

            var breadthFirstIterative = Methods.BreadthFirstIterative(test);

            //Methods.print(breadthFirstIterative);

            //Console.WriteLine(Methods.BreadthFirstSearch(test, "c"));

            //Console.WriteLine(Methods.DepthFirstSearch(test, "c"));

            //Console.WriteLine(Methods.TreeSum(test));

            //Console.WriteLine(Methods.TreeMinIterative(test));

            //Console.WriteLine(Methods.TreeMinRecursive(test));

            Console.WriteLine(Methods.MaxRootToLeafSum(test));
        }
    }
}
