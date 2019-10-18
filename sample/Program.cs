using System;
namespace sample
{
    class Program
    {
        static void Main(string[] args)
        {
            RemoveDuplicate removeDuplicate = new RemoveDuplicate();
            removeDuplicate.DoRemoveDuplicate();
            ReadFileAsync readFileAsync = new ReadFileAsync();
            readFileAsync.DoReadFileAsync().Wait();
            PrintoutNumber1to1000 printoutNumber1To1000 = new PrintoutNumber1to1000();
            printoutNumber1To1000.Doprintoutnumber1to1000();
            DummyLargeFile.CreateLargeFile();
            SplitBigTextFileToSmallOne splitBigTextFile = new SplitBigTextFileToSmallOne();
            splitBigTextFile.DoSplitBigTextFileToSmall();
            Member member = new Member();
            var members = member.GenerateMembers();
        }
         
    }
}
