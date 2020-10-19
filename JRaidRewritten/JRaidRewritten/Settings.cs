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
    public partial class Settings : Form
    {
        public bool Save = false;
        public string IP;
        public int Port;
        public string Username;
        public string Password;
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Save = true;
            IP = textBox1.Text.Trim();
            Port = (int)numericUpDown1.Value;
            Username = textBox2.Text.Trim();
            Password = textBox3.Text.Trim();
            this.Close();
        }
    }
}
