using System;
using System.Threading.Tasks;
using Quartz;

namespace testQuartJob
{
    /// <summary>
    /// A sample job that just prints info on console for demostration purposes.
    /// </summary>
    public class SampleJob : IJob
    {
        public async Task Execute(IJobExecutionContext context)
        {
            System.Console.WriteLine("My SampleJob running...");
            await Task.Delay(TimeSpan.FromSeconds(10));
            System.Console.WriteLine("My SampleJob finished");
         
        }
    }
}