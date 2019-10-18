using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace sample
{
    public class SplitBigTextFileToSmallOne
    {
        public void DoSplitBigTextFileToSmall()
        {
            long l_filesize = new System.IO.FileInfo("huge_dummy_file.txt").Length;
            using (System.IO.StreamReader sr = new System.IO.StreamReader("huge_dummy_file.txt"))
            {
                int fileNumber = 0;

                while (!sr.EndOfStream)
                {
                    int count = 0;

                    using (System.IO.StreamWriter sw = new System.IO.StreamWriter("SplitSmallFile" + ++fileNumber+".txt"))
                    {
                        sw.AutoFlush = true;

                        while (!sr.EndOfStream && ++count < 1024*1024)
                        {
                            sw.WriteLine(sr.ReadLine());
                        }
                    }
                }
            }
        }
    }
}
