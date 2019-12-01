using System;

namespace AdventOfCode2019
{
    public class Tasks
    {
        static void Main(string[] args)
        {
            int taskNumber=0;
            if (!int.TryParse(args[0], out taskNumber))
                throw new ArgumentException($"Wrong task number argument {args[0]}");
            
            switch (taskNumber)
            {
                case 1:
                    Console.Out.WriteLine("Run Task1");
                    Task1 task1 = new Task1();
                    task1.Run();
                    break;
            }
        }
    }
}