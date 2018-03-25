using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcodeeasy
{
    class Program
    {
        static string ReverseString(string s)
        {
            char[] str = s.ToCharArray();
            int halfSize = s.Length / 2;
            int count = 0;
            char tmp;
            while (count < halfSize)
            {
                tmp = str[s.Length - count - 1];
                str[s.Length - count - 1] = str[count];
                str[count] = tmp;
                count++;
            }
            return new string(str);
        }

        static int NumJewelsInStones(string J, string S)
        {
            int count = 0;
            int jCnt = 0;
            int sCnt = 0;
            while (sCnt < S.Length)
            {
                while (jCnt < J.Length)
                {
                    if (J[jCnt] == S[sCnt])
                    {

                        count++;
                    }
                    jCnt++;
                }
                jCnt = 0;
                sCnt++;
            }
            return count;
        }

        static int HammingDistance(int x, int y)
        {
            int count = 0;
            int tmp;

            if (y > x)
            {
                tmp = y;
                y = x;
                x = tmp;
            }

            while (x != 0)
            {
                if (x % 2 != y % 2)
                {
                    count++;
                }
                x /= 2;
                y /= 2;
            }

            return count;
        }

        static bool JudgeCircle(string moves)
        {
            int i = 0;
            int Ucnt = 0, Dcnt = 0, Rcnt = 0, Lcnt = 0;
            while (i < moves.Length)
            {
                switch (moves[i])
                {
                    case 'U':
                        Ucnt++;
                        break;
                    case 'D':
                        Dcnt++;
                        break;
                    case 'R':
                        Rcnt++;
                        break;
                    case 'L':
                        Lcnt++;
                        break;
                    default:
                        break;
                }
                i++;
            }

            return (Ucnt == Dcnt) && (Rcnt == Lcnt);
        }

        static IList<int> SelfDividingNumbers(int left, int right)
        {
            IList<int> self = new List<int>();
            int buf = left;
            int buf2 = left;
            bool flag = false;
            while (buf <= right)
            {
                buf2 = buf;
                while (buf2 != 0)
                {
                    if (buf2 % 10 != 0)
                    {
                        if (buf % (buf2 % 10) == 0)
                        {
                            flag = true;
                        }
                        else
                        {
                            flag = false;
                            break;
                        }
                    }
                    else
                    {
                        flag = false;
                        break;
                    }
                    buf2 /= 10;
                }
                
                if (flag)
                {
                    self.Add(buf);
                }
                buf++;
                flag = false;
            }
            return self;
        }

        static void Main(string[] args)
        {
            IList<int> aa = SelfDividingNumbers(1, 22);
            foreach (int n in aa)
            {
                Console.Write("{0} ", n);
            }
            //Console.WriteLine(JudgeCircle("LRU"));
            //Console.WriteLine(HammingDistance(13, 16));
            //Console.WriteLine(NumJewelsInStones("adE", "sdasdafaA"));
            //Console.WriteLine(ReverseString("hello"));
            Console.ReadKey();
        }
    }
}
