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

namespace AsyncAndAwait
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            Task.Factory.StartNew(() => BigLongImportantMethod("Hugues")).ContinueWith((prevTask) => label1.Text = prevTask.Result, TaskScheduler.FromCurrentSynchronizationContext());
            CallBigImportantMethod();
            label1.Text = "Waiting....";
        }

        private async void CallBigImportantMethod()
        {
            var result = await BigLongImportantMethodAsync("Hugues");
            label1.Text = result;
        }

        private Task<string> BigLongImportantMethodAsync(string name)
        {
            return Task.Factory.StartNew(() => BigLongImportantMethod(name));        
        }

        private string BigLongImportantMethod(string name)
        {
            Thread.Sleep(2000);
            return $"Hello {name}";
        }
    }
}
