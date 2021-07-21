using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DataStructurePrograms
{
    class UnorderedList
    {
        LinkedList<string> list;
        string filePath = @"D:\tvstraining\AlgorithmPrograms\DataStructurePrograms\TextFile.txt";
        public UnorderedList()
        {

            string listOfWords = File.ReadAllText(filePath);
            string[] words = listOfWords.Split(' ');
            list = new LinkedList<string>(words);
        }
        public void ReadInput()
        {
            Console.WriteLine("List of words : ");
            Display(list);
            Console.WriteLine("Enter a word to search : ");
            string word = Console.ReadLine();
            if (list.Find(word) == null)
                list.AddLast(word);
            else
                list.Remove(word);
            Console.Write(" List of Words : ");
            Display(list);
            string newText = String.Join(' ', list);
            File.WriteAllText(filePath, newText);
        }
        private static void Display(LinkedList<string> list)
        {
            foreach (string word in list)
            {
                Console.Write(word + " ");
            }
            Console.WriteLine();
        }
    }
}
