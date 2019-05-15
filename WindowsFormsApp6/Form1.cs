using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int countDivides(int a)
        {
            int count = 0;
            for (int i = 1; i < a; i++)
                if (a % i == 0) count++;
            return count;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DateTime timestart = DateTime.Now;
            labelTimeStart.Text = timestart.ToString();
            this.Refresh();
            countDivides(1000000000);
            DateTime timeEnd = DateTime.Now;
            TimeSpan timeDelta = timeEnd - timestart;
            labelTimeEnd.Text = timeEnd.ToString();
            label3.Text = timeDelta.ToString();

            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
