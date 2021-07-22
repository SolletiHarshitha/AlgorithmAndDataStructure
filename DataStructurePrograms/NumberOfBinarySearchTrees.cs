using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructurePrograms
{
    class NumberOfBinarySearchTrees
    {
        //Finding number of binary search trees for n nodes
        public int NumberOfBSTs(int n)
        {
            int n1, n2, sum = 0;

            // Base cases
            if (n == 1 || n == 0)
                return 1;

            // Find the nth Catalan number
            for (int i = 1; i <= n; i++)
            {
                // Recursive calls
                n1 = NumberOfBSTs(i - 1);
                n2 = NumberOfBSTs(n - i);
                sum += n1 * n2;
            }

            // Return the nth Catalan number
            return sum;
        }
    }
}
