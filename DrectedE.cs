using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_10
{
    class DrectedE
    {
        public static int SEARCH(int[] edgeFirst, int[] edgeNext, int[] start)
        {
            int n = n;
            int m = m;
            int[] end = ;
            int[] current = ;
            int[] serched = ;
            int[] path = ;
            for (int i = 1; i < n; i += 1)
            {
                current[i] = edgeFirst[i]
            }
            int top = 1;
            int last = m;
            int x = 1;

            while(last <= 1)
            {
                if(current[x] != 0)
                {
                    temp = current[x];
                    searched[top] = temp;
                    current[x] = edgeNext[temp];
                    x = end[temp];
                    top = top + 1;
                }
                else
                {
                    top = top - 1;
                    temp = searched[top];
                    path[last] = temp;
                    x = start[temp];
                    last = last - 1;
                }
            }
            
        }
    }
}
