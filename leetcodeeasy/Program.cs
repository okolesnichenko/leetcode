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

        static string[] FindWords(string[] words)
        {
            string upstr = "qwertyuiop";
            string midstr = "asdfghjkl";
            string dwnstr = "zxcvbnm";
            bool flag;
            int t = 0;
            int next = 0;
            int last = 0;
            string[] keywords = new string[words.Length];

            return keywords;
        } //not working

        static int FindComplement(int num)
        {
            IList<int> res2 = new List<int>();
            int res10 = 0;
            bool flag = false;
            while (num != 0)
            {
                res2.Add(1 - num % 2);
                num /= 2;
            }

            for (int i = res2.Count - 1; i >= 0; i--)
            {
                if (!flag)
                {
                    if (res2[i] == 1)
                    {
                        flag = true;
                        res10 = 1;
                        continue;
                    }
                }
                if (res2[i] == 0)
                {
                    res10 = res10 * 2;
                }
                else
                {
                    res10 = res10 * 2 + 1;
                }

            }

            return res10;
        }

        static string ToLowerCase(string str)
        {
            string res = "";
            res = str.ToLower();
            return res;
        }

        static int[][] FlipAndInvertImage(int[][] A)
        {

            for (int i = 0; i < A.Length - 1; i++)
            {
                A[i] = ReverseAndInvert(A[i]);
            }
            return A;
        } //not working

        static int[] ReverseAndInvert(int[] a)
        {
            int left = 0;
            int right = a.Length - 1;
            int tmp;
            while (left < right)
            {
                tmp = a[left];
                a[left] = a[right];
                a[right] = tmp;
                a[left] = 1 - a[left];
                a[right] = 1 - a[right];
                left++;
                right++;
            }
            return a;
        }

        static int[] ShortestToChar(string S, char C)
        {
            int j = 0;
            int cUp = 0;
            int[] res = new int[S.Length];
            int cDown = 0;
            for (int i = 0; i < S.Length; i++)
            {
                j = i;
                while ((j < S.Length && (S[j] != C)))
                {                    
                    cUp++;
                    if (j == S.Length - 1) cUp = Int32.MaxValue;
                    j++;
                }
                j = i;
                while ((j >= 0) && (S[j] != C))
                {                  
                    cDown++;
                    if (j == 0) cDown = Int32.MaxValue;
                    j--;                    
                }
                if (cUp < cDown)
                {
                    res[i] = cUp;
                }
                else
                {
                    res[i] = cDown;
                }
                cUp = 0;
                cDown = 0;
            }
            return res;
        }

        static void Main(string[] args)
        {
            ShortestToChar("abaa", 'b');

            //Console.WriteLine(ToLowerCase("Hello"));

            //Console.WriteLine(FindComplement(5));

            //string[] words = { "hello", "hlaska", "had", "peace" };
            //foreach (string str in FindWords(words))
            //{
            //    Console.Write("{0} ", str);
            //}

            //IList<int> aa = SelfDividingNumbers(1, 22);
            //foreach (int n in aa)
            //{
            //   Console.Write("{0} ", n);
            //}
            //Console.WriteLine(JudgeCircle("LRU"));
            //Console.WriteLine(HammingDistance(13, 16));
            //Console.WriteLine(NumJewelsInStones("adE", "sdasdafaA"));
            //Console.WriteLine(ReverseString("hello"));
            Console.ReadKey();
        }
    }
}
