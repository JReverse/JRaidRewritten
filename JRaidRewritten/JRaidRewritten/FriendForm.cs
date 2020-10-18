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
    public partial class FriendForm : Form
    {
        public bool Start = false;
        public ulong Username;
        public int ThreadsAmount;
        public bool FriendFlood;
        public FriendForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Start = true;
            ThreadsAmount = (int)numericUpDown1.Value;
            Username = Convert.ToUInt64(textBox1.Text.Trim());
            FriendFlood = true;
            this.Close();
        }
    }
}
