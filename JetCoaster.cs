using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_10
{
    public class JetCoaster
    {



        public static int ride
        (int k, int[] g, int r)
        {
            int youso = 0;//配列の要素
            int goukei = 0;//乗った人数の合計

            if (g.Length == 0)//行列が0の場合の処理
            {
                return 0;
            }
            while (r > 0)
            {
                int i = 0;//1回ごとに乗る人数
                int count = youso;//要素が同じものを読み込まないよう判定するためのポインタ
                while (i < k + 1)//今の人数と乗れる人数の比較（乗れる上限の数を含む）
                {
                    i += g[youso];
                    if (i > k)//上でいれた人数が超えていたら超えた分を除外する
                    {
                        i -= g[youso];
                        goukei += i;

                        break;
                    }
                    youso += 1;

                    if (youso > g.Length - 1)//ypousoが配列を超えたとき0に戻す処理
                    {
                        youso = 0;
                    }
                    if (youso == count)//yousoが１回の乗車で乗る人に同じ人を参照したときの処理
                    {
                        goukei += i;
                        break;
                    }
                }
                r -= 1;
            }
            return goukei;
        }



    }
}