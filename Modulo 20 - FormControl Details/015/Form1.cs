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

namespace _015
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

            List<Task> tasks = new List<Task>();

            tasks.Add(new Task(new Action(() =>
            {
                Thread.Sleep(2000);
                progressBar.Invoke(new Action(() =>
                {
                    progressBar.Value ++;
                }));
            })));

            tasks.Add(new Task(new Action(() =>
            {
                Thread.Sleep(2000);
                progressBar.Invoke(new Action(() =>
                {
                    progressBar.PerformStep();
                }));
            })));

            tasks.Add(new Task(new Action(() =>
            {
                Thread.Sleep(2000);
                progressBar.Invoke(new Action(() =>
                {
                    progressBar.PerformStep();
                }));
            })));

            tasks.Add(new Task(new Action(() =>
            {
                Thread.Sleep(2000);
                progressBar.Invoke(new Action(() =>
                {
                    progressBar.PerformStep();
                }));
            })));

            progressBar.Maximum = tasks.Count;
            progressBar.Step = 1;

            for (int i = 0; i < tasks.Count; i++)
            {
                tasks[i].Start();
            }
        }
    }
}
