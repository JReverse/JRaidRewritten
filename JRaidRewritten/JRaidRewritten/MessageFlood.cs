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
    public partial class MessageFlood : Form
    {
        public bool Start = false;
        public string Message;
        public int ThreadsAmount;
        public ulong ChannelID;
        public bool TTS;
        public MessageFlood()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Start = true;
            ThreadsAmount = (int)numericUpDown1.Value;
            Message = textBox1.Text.Trim();
            ChannelID = Convert.ToUInt64(textBox2.Text.Trim());
            TTS = checkBox1.Checked;
            this.Close();
        }

        private void MessageFlood_Load(object sender, EventArgs e)
        {

        }
    }
}
