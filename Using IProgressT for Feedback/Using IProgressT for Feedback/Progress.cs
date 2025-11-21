using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Using_IProgressT_for_Feedback
{
    class Progress : IProgress<int>
    {
        public void Report(int value)
        {
            Console.WriteLine($"ПРОГРЕСС: [{value}]% выполнено");
        }
    }
}
