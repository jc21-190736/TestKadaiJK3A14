﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_10
{
    public class JetCoaster
    {

       public static int ride(int k,int[] g,int r)
        {

            int ninzu = 0; //人数
            int a = k;//現在人数制限
            int count = 0;

            for (int j = 0; ; j += 1)//配列カウント
                {
                count += 1;
                if (count < g.Length)//同じ人が乗らないように
                {



                    if (r == 0)//rまで回す
                    {
                        break;
                    }

                    if (j > g.Length - 1)//配列上限まで行ったら最初に戻る
                    {
                        j = 0;
                    }

                    if (g.Length == 0)//配列は入っていないとき０
                    {
                        return 0;
                    }

                    if (g[j] <= a)//人数はいるとき
                    {
                        ninzu += g[j];
                        a -= g[j];
                    }

                    else//人数はいらないとき
                    {

                        a = k;
                        r -= 1;

                        if (j <= g.Length - 1)
                        {
                            j -= 1;
                        }
                        else
                        {
                            j = g.Length - 1;
                        }
                    }
                }
            }

             return ninzu;
        }
    }
}
