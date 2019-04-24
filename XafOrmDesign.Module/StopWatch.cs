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
        public static Tuple<string, double> Start(Action Action, string MethodDescription)
        {
            // Create new stopwatch

            System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();

            // Begin timing
            stopwatch.Start();
            Action.Invoke();
            // End timing
            stopwatch.Stop();

            string value = $"Time taken by {MethodDescription} : {stopwatch.Elapsed.TotalMilliseconds}";
            Debug.WriteLine(value);
            return new Tuple<string, double>(value, stopwatch.Elapsed.TotalMilliseconds);
        }
    }
}