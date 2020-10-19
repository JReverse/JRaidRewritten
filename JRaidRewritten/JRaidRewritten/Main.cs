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
using JRaidRewritten.Extensions;
using Discord;
using System.Diagnostics;
using Leaf.xNet;

namespace JRaidRewritten
{
    public partial class Main : Form
    {
        private List<DiscordClient> Accounts;
        private ToolStripStatusLabel Status;
        private ListBox Logs;
        private int Index;

        //Proxy Settings
        private string Host;
        private int Port;
        private string Username;
        private string Password;
        public Main()
        {
            InitializeComponent();
        }

        private void LoadAccounts()
        {
            Accounts = new List<DiscordClient>();
            var lines = File.ReadAllLines(Directory.GetCurrentDirectory() + "/Tokens.txt");

            foreach (string line in lines)
            {

                Accounts.Add(new DiscordClient(line));
            }

            toolStripStatusLabel1.SafeChangeText(string.Format("Accounts: {0}", Accounts.Count));
        }

        private void FriendFloodtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FriendForm FriendForm = new FriendForm())
            {
                FriendForm.ShowDialog();
                if (FriendForm.Start)
                {
                    Status = toolStripStatusLabel1;
                    Logs = listBox1;
                    Index = 0;

                    StartFriendFlood(FriendForm.ThreadsAmount, FriendForm.UserId);
                }
            }
        }

        private async void StartFriendFlood(int ThreadsAmount, ulong UserId)
        {
            await Task.Run(() =>
            {
                Status.SafeChangeText(string.Format("{0} of {1} Friend Requests", Index, Accounts.Count));

                List<Task> Threads = new List<Task>();

                for (int i = 0; i < ThreadsAmount; i++)
                {
                    Threads.Add(ThreadFriendFlood(UserId));
                }

                Task.WaitAll(Threads.ToArray());

                Status.SafeChangeText("Completed Frind Flood");

            });
        }
        private async void StartJoiner(int ThreadsAmount, string Invite)
        {
            await Task.Run(() =>
            {
                Status.SafeChangeText(string.Format("{0} of {1} Guild Join Requests", Index, Accounts.Count));

                List<Task> Threads = new List<Task>();

                for (int i = 0; i < ThreadsAmount; i++)
                {
                    Threads.Add(ThreadJoiner(Invite));
                }

                Task.WaitAll(Threads.ToArray());

                Status.SafeChangeText("Completed Joiner Threads");

            });
        }
        private async Task ThreadJoiner(string Invite)
        {
            while (true)
            {
                try
                {
                    DiscordClient DiscordClient = new DiscordClient(new DiscordConfig() { Proxy = new AnarchyProxy() { Host = Host, Port = Port, Username = Username, Password = Password, Type = AnarchyProxyType.HTTP } });

                    lock (Accounts)
                    {
                        if (Index >= Accounts.Count)
                            break;

                        DiscordClient = Accounts[Index];
                        Index += 1;
                    }

                    await DiscordClient.JoinGuildAsync(Invite);
                    Logs.SafeAddItem(string.Format("Joined Guild From: {0}", DiscordClient.User.Username));

                }
                catch (Exception ex)
                {
                    Logs.SafeAddItem(string.Format("Error: {0}", ex.Message));
                    Debug.Print(ex.Message);
                    Debug.Print(ex.StackTrace);
                }

                Status.SafeChangeText(string.Format("{0} of {1} Guild Join Requests", Index, Accounts.Count));
            }
        }
        private async Task ThreadFriendFlood(ulong UserId)
        {
            while (true)
            {
                try
                {
                    DiscordClient DiscordClient = new DiscordClient(new DiscordConfig() { Proxy = new AnarchyProxy() { Host = Host, Port = Port, Username = Username, Password = Password, Type = AnarchyProxyType.HTTP} }); 

                    lock (Accounts)
                    {
                        if (Index >= Accounts.Count)
                            break;

                        DiscordClient = Accounts[Index];
                        Index += 1;
                    }

                    await DiscordClient.SendFriendRequestAsync(UserId);
                    Logs.SafeAddItem(string.Format("Added User From: {0}", DiscordClient.User.Username));

                }
                catch (Exception ex)
                {
                    Logs.SafeAddItem(string.Format("Error: {0}", ex.Message));
                    Debug.Print(ex.Message);
                    Debug.Print(ex.StackTrace);
                }

                Status.SafeChangeText(string.Format("{0} of {1} Friend Requests", Index, Accounts.Count));
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            LoadAccounts();
        }

        private void SettingstoolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Settings Settings = new Settings())
            {
                Settings.ShowDialog();
                if (Settings.Save)
                {
                    Status = toolStripStatusLabel1;
                    Logs = listBox1;
                    Index = 0;
                    Host = Settings.IP;
                    Port = Settings.Port;
                    Username = Settings.Username;
                    Password = Settings.Password;
                }
            }
        }

        private void GuildJoinertoolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (GuildJoiner GuildJoiner = new GuildJoiner())
            {
                GuildJoiner.ShowDialog();
                if (GuildJoiner.Start)
                {
                    Status = toolStripStatusLabel1;
                    Logs = listBox1;
                    Index = 0;

                    StartJoiner(GuildJoiner.ThreadsAmount, GuildJoiner.Invite);
                }
            }
        }
    }
}
