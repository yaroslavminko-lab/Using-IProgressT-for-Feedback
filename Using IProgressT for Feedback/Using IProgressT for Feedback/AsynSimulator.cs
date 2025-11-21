using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Using_IProgressT_for_Feedback
{
    class AsynSimulator
    {
        public async Task DoSomething(IProgress<int> progress)
        {
            await Task.Delay(100);
            progress.Report(20);

            await Task.Delay(200);
            progress.Report(40);

            await Task.Delay(300);
            progress.Report(60);

            await Task.Delay(100);
            progress.Report(80);

            await Task.Delay(200);
            progress.Report(100);
        }
    }
}
