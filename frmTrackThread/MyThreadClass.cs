using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace frmTrackThread
{
    internal class MyThreadClass
    {
        public static void Thread1()
        {
            for (int LoopCount = 0;  LoopCount < 3; LoopCount++) {
                Thread thread = Thread.CurrentThread;
                Thread.Sleep(500);
                Console.WriteLine("Name of Thread" + thread.Name + "=" + LoopCount);
                    
            }
        }
        public static void Thread2()
        {
            for (int LoopCount = 0; LoopCount < 6; LoopCount++) {
                Thread thread = Thread.CurrentThread;
                Thread.Sleep(1500);
                Console.WriteLine("Name of Thread" + thread.Name + "=" + LoopCount);
            }
        }
    }
}
