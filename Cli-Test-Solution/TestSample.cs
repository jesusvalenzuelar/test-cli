using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cli_Test_Solution
{
    public class TestSample
    {
        // Violation: missing access modifier
        void DoSomething()
        {
            Console.WriteLine("line 1");
            Console.WriteLine("line 2");
            Console.WriteLine("line 3");
        }

        // Violation: returns Task but no Async suffix
        public async Task FetchData()
        {
            await Task.Delay(100);
            Console.WriteLine("fetching...");
        }

        // Violation: method too long (exceeds maxMethodLines)
        public void ProcessEverything()
        {
            Console.WriteLine("step 1");
            Console.WriteLine("step 2");
            Console.WriteLine("step 3");
            Console.WriteLine("step 4");
            Console.WriteLine("step 5");
            Console.WriteLine("step 6");
            Console.WriteLine("step 7");
            Console.WriteLine("step 8");
            Console.WriteLine("step 9");
            Console.WriteLine("step 10");
            Console.WriteLine("step 11");
            Console.WriteLine("step 12");
            Console.WriteLine("step 13");
            Console.WriteLine("step 14");
            Console.WriteLine("step 15");
            Console.WriteLine("step 16");
            Console.WriteLine("step 17");
            Console.WriteLine("step 18");
            Console.WriteLine("step 19");
            Console.WriteLine("step 20");
            Console.WriteLine("step 21");
            Console.WriteLine("step 22");
            Console.WriteLine("step 23");
            Console.WriteLine("step 24");
            Console.WriteLine("step 25");
            Console.WriteLine("step 26");
            Console.WriteLine("step 27");
        }
    }
}
