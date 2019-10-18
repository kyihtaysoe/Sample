using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace sample
{
    public class ReadFileAsync
    {
        public async Task DoReadFileAsync()
        {
             
            using (var reader = File.OpenText("Word.txt"))
            {
                var fileText = await reader.ReadToEndAsync();
                
            }

        }
    }
}
