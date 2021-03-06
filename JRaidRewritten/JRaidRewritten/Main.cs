﻿using System;
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
using System.Data.SqlTypes;

namespace JRaidRewritten
{
    public partial class Main : Form
    {
        private List<string> Accounts;
        private ToolStripStatusLabel Status;
        private ListBox Logs;
        private int Index;

        //Proxy Settings
        private string Host;
        private int Port;
        private string Username;
        private string Password;
        private int Delay { get; set; } = 555;
        public Main()
        {
            InitializeComponent();
        }
        private void LoadAccounts()
        {
            Accounts = new List<string>();
            var lines = File.ReadAllLines(Directory.GetCurrentDirectory() + "/Tokens.txt");

            foreach (string line in lines)
            {
                Accounts.Add(line);
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

                Status.SafeChangeText("Completed Friend Flood");

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
        private async void StartLeaver(int ThreadsAmount, ulong GuildID)
        {
            await Task.Run(() =>
            {
                Status.SafeChangeText(string.Format("{0} of {1} Guild Leave Requests", Index, Accounts.Count));

                List<Task> Threads = new List<Task>();

                for (int i = 0; i < ThreadsAmount; i++)
                {
                    Threads.Add(ThreadLeaver(GuildID));
                }

                Task.WaitAll(Threads.ToArray());

                Status.SafeChangeText("Completed Guild Leaver Threads");

            });
        }
        private async Task ThreadJoiner(string Invite)
        {
            while (true)
            {
                try
                {
                    DiscordClient DiscordClient;
                    if (Host != null) { DiscordClient = new DiscordClient(new DiscordConfig() { Proxy = new AnarchyProxy() { Host = Host, Port = Port, Username = Username, Password = Password, Type = AnarchyProxyType.HTTP } }); }
                    DiscordClient = new DiscordClient();

                    lock (Accounts)
                    {
                        if (Index >= Accounts.Count)
                            break;

                        DiscordClient.Token = Accounts[Index];
                        Index += 1;
                    }

                    await DiscordClient.JoinGuildAsync(Invite);
                    await Task.Delay(Delay);
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
        private async Task ThreadLeaver(ulong GuildID)
        {
            while (true)
            {
                try
                {
                    DiscordClient DiscordClient;
                    if (Host != null) { DiscordClient = new DiscordClient(new DiscordConfig() { Proxy = new AnarchyProxy() { Host = Host, Port = Port, Username = Username, Password = Password, Type = AnarchyProxyType.HTTP } }); }
                    DiscordClient = new DiscordClient();

                    lock (Accounts)
                    {
                        if (Index >= Accounts.Count)
                            break;

                        DiscordClient.Token = Accounts[Index];
                        Index += 1;
                    }

                    await DiscordClient.LeaveGuildAsync(GuildID);
                    await Task.Delay(Delay);
                    Logs.SafeAddItem(string.Format("Left Guild From: {0}", DiscordClient.User.Username));

                }
                catch (Exception ex)
                {
                    Logs.SafeAddItem(string.Format("Error: {0}", ex.Message));
                    Debug.Print(ex.Message);
                    Debug.Print(ex.StackTrace);
                }

                Status.SafeChangeText(string.Format("{0} of {1} Guild Leave Requests", Index, Accounts.Count));
            }
        }
        private async void StartMessage(int ThreadsAmount, ulong ChanngelID, string Message, bool tts)
        {
            await Task.Run(() =>
            {
                Status.SafeChangeText(string.Format("{0} of {1} Message Requests", Index, Accounts.Count));

                List<Task> Threads = new List<Task>();

                for (int i = 0; i < ThreadsAmount; i++)
                {
                    Threads.Add(ThreadMessage(ChanngelID, Message, tts));
                }

                Task.WaitAll(Threads.ToArray());

                Status.SafeChangeText("Completed Message Threads");

            });
        }
        private async void StartDMMessage(int ThreadsAmount, ulong UserID, string Message, bool tts)
        {
            await Task.Run(() =>
            {
                Status.SafeChangeText(string.Format("{0} of {1} Direct Message Requests", Index, Accounts.Count));

                List<Task> Threads = new List<Task>();

                for (int i = 0; i < ThreadsAmount; i++)
                {
                    Threads.Add(ThreadDMMessage(UserID, Message, tts));
                }

                Task.WaitAll(Threads.ToArray());

                Status.SafeChangeText("Completed Direct Message Threads");

            });
        }
        private async Task ThreadDMMessage(ulong UserID, string Message, bool tts)
        {
            while (true)
            {
                try
                {
                    DiscordClient DiscordClient;
                    if (Host != null) { DiscordClient = new DiscordClient(new DiscordConfig() { Proxy = new AnarchyProxy() { Host = Host, Port = Port, Username = Username, Password = Password, Type = AnarchyProxyType.HTTP } }); }
                    DiscordClient = new DiscordClient();

                    lock (Accounts)
                    {
                        if (Index >= Accounts.Count)
                            break;

                        DiscordClient.Token = Accounts[Index];
                        Index += 1;
                    }
                    var dm = await DiscordClient.CreateDMAsync(UserID);
                    await dm.SendMessageAsync(Message, false);
                    await Task.Delay(Delay);
                    Logs.SafeAddItem(string.Format("Messaged User From: {0}", DiscordClient.User.Username));

                }
                catch (Exception ex)
                {
                    Logs.SafeAddItem(string.Format("Error: {0}", ex.Message));
                    Debug.Print(ex.Message);
                    Debug.Print(ex.StackTrace);
                }

                Status.SafeChangeText(string.Format("{0} of {1} Direct Message Requests", Index, Accounts.Count));
            }
        }
        private async Task ThreadMessage(ulong ChanngelID, string Message, bool tts)
        {
            while (true)
            {
                try
                {
                    DiscordClient DiscordClient;
                    if (Host != null) { DiscordClient = new DiscordClient(new DiscordConfig() { Proxy = new AnarchyProxy() { Host = Host, Port = Port, Username = Username, Password = Password, Type = AnarchyProxyType.HTTP } }); }
                    DiscordClient = new DiscordClient();

                    lock (Accounts)
                    {
                        if (Index >= Accounts.Count)
                            break;

                        DiscordClient.Token = Accounts[Index];
                        Index += 1;
                    }

                    await DiscordClient.SendMessageAsync(ChanngelID, Message, tts);
                    await Task.Delay(Delay);
                    Logs.SafeAddItem(string.Format("Messaged Guild From: {0}", DiscordClient.User.Username));

                }
                catch (Exception ex)
                {
                    Logs.SafeAddItem(string.Format("Error: {0}", ex.Message));
                    Debug.Print(ex.Message);
                    Debug.Print(ex.StackTrace);
                }

                Status.SafeChangeText(string.Format("{0} of {1} Message Requests", Index, Accounts.Count));
            }
        }
        private async Task ThreadFriendFlood(ulong UserId)
        {
            while (true)
            {
                try
                {
                    DiscordClient DiscordClient;
                    if (Host != null) { DiscordClient = new DiscordClient(new DiscordConfig() { Proxy = new AnarchyProxy() { Host = Host, Port = Port, Username = Username, Password = Password, Type = AnarchyProxyType.HTTP } }); }
                    DiscordClient = new DiscordClient();

                    lock (Accounts)
                    {
                        if (Index >= Accounts.Count)
                            break;

                        DiscordClient.Token = Accounts[Index];
                        Index += 1;
                    }

                    await DiscordClient.SendFriendRequestAsync(UserId);
                    await Task.Delay(Delay);
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
                    Delay = Settings.Delay;
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

        private void messageFloodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (MessageFlood MessageFlood = new MessageFlood())
            {
                MessageFlood.ShowDialog();
                if (MessageFlood.Start)
                {
                    Status = toolStripStatusLabel1;
                    Logs = listBox1;
                    Index = 0;

                    StartMessage(MessageFlood.ThreadsAmount, MessageFlood.ChannelID, MessageFlood.Message, MessageFlood.TTS);
                }
            }
        }

        private void guildLeaverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                using (GuildLeaver GuildLeaver = new GuildLeaver())
                {
                    GuildLeaver.ShowDialog();
                    if (GuildLeaver.Start)
                    {
                        Status = toolStripStatusLabel1;
                        Logs = listBox1;
                        Index = 0;

                        StartLeaver(GuildLeaver.ThreadsAmount, GuildLeaver.GuildID);
                    }
                }
            }
        }

        private void dMFloodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (DMSpam DMSpam = new DMSpam())
            {
                DMSpam.ShowDialog();
                if (DMSpam.Start)
                {
                    Status = toolStripStatusLabel1;
                    Logs = listBox1;
                    Index = 0;

                    StartDMMessage(DMSpam.ThreadsAmount, DMSpam.USERID, DMSpam.Message, DMSpam.TTS);
                }
            }
        }
    }
}