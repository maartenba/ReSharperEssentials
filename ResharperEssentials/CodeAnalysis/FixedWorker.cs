using System;

namespace ResharperEssentials.CodeAnalysis
{
    public class FixedWorker
    {
        private readonly string _task;

        public void DoWork(int n)
        {
            var workload = new[] { 1, 2, 3, 4, 5, n };

            foreach (var work in workload)
            {
                if (work % 2 == 0)
                {
                    Console.WriteLine("Time for break!");
                }
                else
                {
                    Console.WriteLine(_task);
                }
            }
        }

        public FixedWorker()
        {
            _task = "Shoveling";

            DoWork(123);
        }
    }
}