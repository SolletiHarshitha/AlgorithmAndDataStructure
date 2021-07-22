using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructurePrograms
{
    class Palindrome
    {
        //Checking the string is palindrome or not
        public void ReadInput()
        {
            Dequeue<char> dequeue = new Dequeue<char>();
            bool palindrome = true;
            Console.WriteLine("Enter a word :");
            string word = Console.ReadLine();
            word = word.ToLower();
            for(int i=0;i<word.Length;i++)
            {
                dequeue.AddFront(word[i]);
            }
            while (dequeue.CheckEqual() == 1)
            {
                char first = dequeue.RemoveFront();
                char last = dequeue.RemoveRear();
                if (!(first.Equals(last)))
                {
                    palindrome = false;
                    break;
                }
            }
            if (palindrome)
                Console.WriteLine("The Word \"" + word + "\" is a palindrome");
            else
                Console.WriteLine("The Word \"" + word + "\" is not a palindrome");

        }
    }
}
