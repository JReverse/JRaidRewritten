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
    public partial class DMSpam : Form
    {
        public bool Start = false;
        public string Message;
        public int ThreadsAmount;
        public ulong USERID;
        public bool TTS;
        public DMSpam()
        {
            InitializeComponent();
        }

        private void DMSpam_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Start = true;
            ThreadsAmount = (int)numericUpDown1.Value;
            Message = textBox1.Text.Trim();
            USERID = Convert.ToUInt64(textBox2.Text.Trim());
            TTS = checkBox1.Checked;
            this.Close();
        }
    }
}
