using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarTopologyProject
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
        }

        private void Loading_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            guna2ProgressBar1.Value += 3;
            if(guna2ProgressBar1.Value >= 100)
            {
                timer1.Stop();
                Form1 getStarted = new Form1();
                getStarted.Show();
                this.Hide();
            }
        }
    }
}
