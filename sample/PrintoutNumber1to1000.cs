using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace sample
{
    public class PrintoutNumber1to1000
    {
        public void Doprintoutnumber1to1000()
        {
            int number = 1000;
            Parallel.For(0, number,
                new ParallelOptions { MaxDegreeOfParallelism = 5 },
                count =>
                {
                    int currentThread = Thread.CurrentThread.ManagedThreadId;
                    Console.WriteLine("{\"Worker\":{\"WorkerID\":" + currentThread + ", \"Number\":" + count + "}}");
                });
        }

    }
}
