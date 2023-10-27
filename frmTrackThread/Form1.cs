using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmTrackThread
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine(label1.Text.ToString());
            label1.Text = "-THREAD RUNNING-";
            Thread ThreadA = new Thread(MyThreadClass.Thread1);
            Thread ThreadB = new Thread(MyThreadClass.Thread2);
            Thread ThreadC = new Thread(MyThreadClass.Thread1);
            Thread ThreadD = new Thread(MyThreadClass.Thread2);


            ThreadA.Name = "Thread A Process";
            ThreadB.Name = "Thread B Process";
            ThreadC.Name = "Thread C Process";
            ThreadD.Name = "Thread D Process";


            ThreadA.Priority = ThreadPriority.Highest;
            ThreadB.Priority = ThreadPriority.Normal;
            ThreadC.Priority = ThreadPriority.AboveNormal;
            ThreadD.Priority = ThreadPriority.BelowNormal;


            ThreadA.Start();
            ThreadB.Start();
            ThreadC.Start();
            ThreadD.Start();


            ThreadA.Join();
            ThreadB.Join();
            ThreadC.Join();
            ThreadD.Join();


            label1.Text = "-END OF THREAD-";
            Console.WriteLine(label1.Text.ToString());
        }
    }
}
