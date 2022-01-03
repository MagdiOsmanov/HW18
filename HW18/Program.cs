using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW18
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string text = Console.ReadLine();
            int n,m,r;
            r = 0;
            m = 0;
            n = 0;
            text.ToCharArray();
            List<char> textArray = new List<char>();
            textArray.AddRange(text.ToCharArray());
            foreach (var l in textArray)
            {
                
                if (l == '(')
                {
                    n++;
                }
                if (l == ')')
                {
                    n--;
                }
                if (l == '{')
                {
                    m++;
                }
                if (l == '}')
                {
                    m--;
                }
                if (l == '[')
                {
                    r++;
                }
                if (l == ']')
                {
                    r--;
                }
            }
            if (n != 0||r!=0||m!=0)
            {
                Console.WriteLine("Не хватает скобки");
            }
            else
            {
                Console.WriteLine("Все гуд");
            }

        Console.ReadKey();

        }
    }
}
