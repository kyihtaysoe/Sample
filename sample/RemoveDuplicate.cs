using System;
using System.Collections.Generic;
using System.Text;

namespace sample
{
    public class RemoveDuplicate
    {
        public void DoRemoveDuplicate()
        {
            Console.WriteLine("Enter String");
            string l_str = Console.ReadLine();
            string nonduplicate = "";
            nonduplicate += l_str[0];

            for (int i = 1; i < l_str.Length; i++)
            {
                if (l_str[i - 1] != l_str[i])
                    nonduplicate += l_str[i];
            }
            Console.WriteLine(nonduplicate);
        }

    }
}
