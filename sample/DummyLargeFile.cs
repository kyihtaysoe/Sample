using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace sample
{
    class DummyLargeFile
    {
        public static void CreateLargeFile()
        {
            if (File.Exists(@"huge_dummy_file.txt"))
            {
                File.Delete(@"huge_dummy_file");
            }
            using (var fs = new FileStream(@"huge_dummy_file.txt", FileMode.Create))
            {
                using (var sw = new StreamWriter(fs, System.Text.Encoding.Default))
                {
                    for (int i = 0; i < 10000000; i++)
                    {
                        sw.WriteLine("dummy");
                    }
                }
            }
        }
    }
}
