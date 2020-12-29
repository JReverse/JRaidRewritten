using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JRaidRewritten
{
    public partial class VCSpammer : Form
    {
        public bool Start = false;
        public ulong VoiceChannelID;
        public ulong GuildID;
        public int ThreadsAmount;
        public Stream File;
        public VCSpammer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog FileDialog = new OpenFileDialog();
            if (FileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((File = FileDialog.OpenFile()) != null)
                    {
                        using (File)
                        {
                            Start = true;
                            ThreadsAmount = (int)numericUpDown1.Value;
                            GuildID = Convert.ToUInt64(textBox2.Text.Trim());
                            VoiceChannelID = Convert.ToUInt64(textBox1.Text.Trim());
                            this.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void VCSpammer_Load(object sender, EventArgs e)
        {

        }
    }
}
