using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JRaidRewritten
{
    public partial class CallSpam : Form
    {
        public bool Start = false;
        public ulong UserID;
        public int ThreadsAmount;
        public CallSpam()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Start = true;
            ThreadsAmount = (int)numericUpDown1.Value;
            UserID = Convert.ToUInt64(textBox1.Text.Trim());
            this.Close();
        }

        private void CallSpam_Load(object sender, EventArgs e)
        {

        }
    }
}
