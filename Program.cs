using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace MyCSharpTest
{
    class MyString
    {

    }
  

    class Program
    {

        static void ProgramEnd()
        {
            WriteLine("\n");
            WriteLine("Press Any Key...");
            ReadKey();
        }

        static UInt32 GetSize(char[] str)
        {
            UInt32 size = 0;

            while (str[size] != '\0')
            {
                size++;
            }

            return size;
        }

        static void Main(string[] args)
        {
            string str = "hello world";
            char frequent = '\0';
            UInt32 highest = 0;
            for (UInt32 i = 0; i < str.Length; i++)
            {
                UInt32 counter = 0;
                char ch = str[Convert.ToInt32(i)];
                for (UInt32 j = 0; j < str.Length; j++)
                {
                    if (ch == str[Convert.ToInt32(j)])
                    {
                        counter++;
                    }
                }
                //WriteLine(counter);

                if (counter >= highest)
                {
                    frequent = ch;
                    highest = counter;
                }
            }

            WriteLine(frequent);
            WriteLine(highest);

            ProgramEnd();
        }
    }
}
