namespace BinarySearchTreeProgamm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BinaryTree<int> binaryTree = new BinaryTree<int>();
            binaryTree.InsertData(56);
            binaryTree.InsertData(30);
            binaryTree.InsertData(90);
            binaryTree.Display(binaryTree.GetRoot());
        }
    }
}