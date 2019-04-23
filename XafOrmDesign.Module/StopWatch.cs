using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XafOrmDesign.Module
{
    public static class StopWatch
    {
        public static Tuple<string, Double, double> Start(Action Action, string MethodDescription)
        {
            // Create new stopwatch
            var InitialMemory = GC.GetTotalMemory(false);
            System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();

            // Begin timing
            stopwatch.Start();
            Action.Invoke();
            // End timing
            stopwatch.Stop();
            var FinalMemory = GC.GetTotalMemory(false);
            var TotalMemory = (FinalMemory - InitialMemory) / 1000;

            string value = $"Time taken by {MethodDescription} : {stopwatch.Elapsed.TotalMilliseconds} memory usage {TotalMemory}";
            Debug.WriteLine(value);
            return new Tuple<string, double, double>(value, stopwatch.Elapsed.TotalMilliseconds, TotalMemory);
        }
    }
}