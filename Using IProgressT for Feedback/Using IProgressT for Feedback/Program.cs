using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Using_IProgressT_for_Feedback
{
    class Program
    {
        static void Main(string[] args)
        {
            var progress = new Progress<int>(X =>
            {
                Console.WriteLine($"ПРОГРЕСС: [{X}]% выполнено");
            });

            var simulator = new AsynSimulator();

            _ = simulator.DoSomething(progress);

            Console.ReadKey();
        }
    }
}
