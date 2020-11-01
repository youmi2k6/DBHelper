using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;
using DAL;
using System.Diagnostics;
using System.Threading;
using Utils;

namespace DBHelperTestWinform
{
    public partial class Form1 : Form
    {
        private BsOrderDal m_BsOrderDal = ServiceHelper.Get<BsOrderDal>();
        private int _n = 200;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //ThreadPool.SetMaxThreads(200, 200);
            //ThreadPool.SetMinThreads(100, 100);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                for (int i = 0; i < _n; i++)
                {

                }
                double d = stopwatch.Elapsed.TotalSeconds;
                Log("单线程耗时：" + d.ToString() + "秒");
                stopwatch.Stop();
            });
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TestSync();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TestAsync();
        }

        public void TestSync()
        {
            Task.Run(() =>
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                List<Task> taskList = new List<Task>();
                for (int i = 0; i < _n; i++)
                {
                    Task task = Task.Run(() =>
                    {
                        try
                        {

                        }
                        catch (Exception ex)
                        {
                            Log(ex.Message + "\r\n" + ex.StackTrace);
                        }
                    });
                    taskList.Add(task);
                }
                Task.WaitAll(taskList.ToArray());
                double d = stopwatch.Elapsed.TotalSeconds;
                Log("同步耗时：" + d.ToString() + "秒");
                stopwatch.Stop();
            });
        }

        public void TestAsync()
        {
            Task.Run(() =>
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                Task task = Task.Run(async () =>
                {
                    for (int i = 0; i < _n; i++)
                    {
                        try
                        {
                            await Task.Run(() => { });
                        }
                        catch (Exception ex)
                        {
                            Log(ex.Message + "\r\n" + ex.StackTrace);
                        }
                    }
                });
                task.Wait();
                double d = stopwatch.Elapsed.TotalSeconds;
                Log("异步耗时：" + d.ToString() + "秒");
                stopwatch.Stop();
            });
        }

        private void Log(string msg)
        {
            this.BeginInvoke(new Action(() =>
            {
                textBox1.AppendText(msg + "\r\n");
            }));
        }
    }
}
