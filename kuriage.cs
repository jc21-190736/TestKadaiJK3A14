using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_10
{
    public class kuriage
    {
        public static int kuriage10(int j)
        {
            if (j % 10 != 0)
            {
                if (j > 0)
                {
                    j = j / 10;
                    j += 1;
                    j = j * 10;
                }
                else if (j == 0)
                {
                    j = 0;
                }
                else
                {
                    j = j / 10;
                    j -= 1;
                    j = j * 10;
                }
            }

            return j;

        }
    }
}
