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

        static void Main(string[] args) 
        {
            Console.WriteLine(NumJewelsInStones("adE", "sdasdafaA"));
            Console.WriteLine(ReverseString("hello"));
            Console.ReadKey();

        }
    }
}
