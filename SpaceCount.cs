using System;
using System.Collections.Generic;
using System.Text;

namespace AccessSpecifier
{
    class SpaceCount
    {
        public static void Main()
        {
            string input = "Shraddha Kirnalli";
            int spaces = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ' ')
                {
                    spaces++;
                }
            }
            Console.WriteLine("SPACES: " + spaces);
        }
    }
}
