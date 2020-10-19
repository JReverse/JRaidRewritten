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
    public partial class GuildJoiner : Form
    {
        public bool Start = false;
        public string Invite;
        public int ThreadsAmount;
        public GuildJoiner()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Start = true;
            ThreadsAmount = (int)numericUpDown1.Value;
            Invite = textBox1.Text.Trim();
            this.Close();
        }

        private void GuildJoiner_Load(object sender, EventArgs e)
        {

        }
    }
}
