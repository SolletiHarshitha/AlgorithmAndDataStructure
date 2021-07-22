using System;

namespace DataStructurePrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------DataStructure Programs-------------");
            bool alive = true;
            while (alive)
            {
                Console.WriteLine("\n1.Unordered List");
                Console.WriteLine("2.Balanced Paranthesis");
                Console.WriteLine("3.Palindreome Checker");
                Console.WriteLine("4.Number of Binary Search Trees");
                Console.WriteLine("0.Exit");

                Console.WriteLine("Choose an option : ");
                int option = Convert.ToInt32(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        UnorderedList unordered = new UnorderedList();
                        unordered.ReadInput();
                        break;
                    case 2:
                        BalancedParanthesis paranthesis = new BalancedParanthesis();
                        paranthesis.ReadInput();
                        break;
                    case 3:
                        Palindrome palindrome = new Palindrome();
                        palindrome.ReadInput();
                        break;
                    case 4:
                        NumberOfBinarySearchTrees bst = new NumberOfBinarySearchTrees();
                        Console.WriteLine("Enter number of nodes :");
                        int node = Convert.ToInt32(Console.ReadLine());
                        int result=bst.NumberOfBSTs(node);
                        Console.WriteLine("The number of binary search trees :"+result);
                        break;
                    case 0:
                        alive = false;
                        break;
                }
                
            }
        }
    }
}
