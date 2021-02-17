using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Telegram.Bot;
using Telegram.Bot.Types.ReplyMarkups;
using ControleRemotoBot.Model;
using System.Linq;
using System.IO;
using System.Threading.Tasks;

namespace ControleRemotoBot
{
    public partial class FrmMain : Form
    {
        TelegramBotClient bot;

        List<Command> commands;
        List<long> adminsIds;
        public FrmMain()
        {
            InitializeComponent();
            commands = new();
            adminsIds = new();
        }

        private async void OnMessage(object sender, Telegram.Bot.Args.MessageEventArgs e)
        {
            if (e.Message.Text.Replace("'", "").Equals("/id", StringComparison.InvariantCultureIgnoreCase))
            {
                await bot.SendTextMessageAsync(e.Message.Chat.Id, $"Your ID is: {e.Message.Chat.Id}");
                return;
            }

            if (!adminsIds.Contains(e.Message.Chat.Id)) return;

            var foundCommand = commands.FirstOrDefault(f => f.Alias.Equals(e.Message.Text, StringComparison.InvariantCultureIgnoreCase));

            if (foundCommand != null)
                foundCommand.CommandAction.Invoke();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            LoadCommands();

            LoadPersonalInfo();
        }

        private void LoadPersonalInfo()
        {
            if (File.Exists("info"))
            {
                var info = File.ReadAllLines("info");
                if (info.Any())
                {
                    txtAdmin.Text = info[0];
                    txtToken.Text = info.Length > 1 ? info[1] : "";
                }
            }
        }

        private void SavePersonalInfo() => File.WriteAllLines("info", new string[] { txtAdmin.Text, txtToken.Text });

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            bool isReceiving = false;

            if (bot != null && bot.IsReceiving)
            {
                bot.StopReceiving();
                btnStart.Text = "Start";

                Text = "Remote Control Bot - Stopped";

                isReceiving = false;
            }
            else
            {
                if (string.IsNullOrEmpty(txtToken.Text))
                {

                    MessageBox.Show("Please, inform the Telegram bot token.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    bot = new(txtToken.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Please, inform a valid Telegram bot token.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                bot.OnMessage += OnMessage;
                bot.StartReceiving();

                SendCommandsToUser();

                SavePersonalInfo();

                btnStart.Text = "Stop";
                Text = "Remote Control Bot - Started";

                isReceiving = true;
            }

            btnAddCommand.Enabled = !isReceiving;
            btnRemoveCommand.Enabled = !isReceiving;
            btnUp.Enabled = !isReceiving;
            btnDown.Enabled = !isReceiving;
            btnAddAll.Enabled = !isReceiving;

            txtAdmin.ReadOnly = isReceiving;
            txtToken.ReadOnly = isReceiving;
        }

        private void SendCommandsToUser()
        {
            var rkm = new ReplyKeyboardMarkup();
            var rows = new List<KeyboardButton[]>();
            var cols = new List<KeyboardButton>();

            for (var Index = 1; Index < ltbConfiguredCommands.Items.Count + 1; Index++)
            {
                cols.Add(new KeyboardButton("" + commands.First(f => f.Alias.Equals(ltbConfiguredCommands.Items[Index - 1].ToString(), StringComparison.InvariantCultureIgnoreCase)).Alias));
                if (Index % 4 != 0) continue;
                rows.Add(cols.ToArray());
                cols = new List<KeyboardButton>();
            }

            if (cols.Count > 0) { rows.Add(cols.ToArray()); }

            rkm.Keyboard = rows.ToArray();

            adminsIds.Clear();
            if (!string.IsNullOrEmpty(txtAdmin.Text))
                adminsIds.AddRange(txtAdmin.Text.Split(',').Select(s => long.Parse(s.Trim())));

            adminsIds.ForEach(async id =>
            {
                try
                {
                    await bot.SendTextMessageAsync(id, "Buttons successful configured.", replyMarkup: rkm);
                }
                catch { }
            });
        }

        private void btnAddCommand_Click(object sender, EventArgs e)
        {
            var frmNewCommand = new FrmNewCommand();

            var result = frmNewCommand.ShowDialog();

            if (result == DialogResult.OK && !commands.Any(c => c.Name == frmNewCommand._cmd.Name))
            {
                commands.Add(frmNewCommand._cmd);
                FillList();

                SaveCommands();
            }
        }

        private void FillList()
        {
            ltbConfiguredCommands.Items.Clear();

            ltbConfiguredCommands.Items.AddRange(commands.Select(s => s.ToString()).ToArray());
        }

        private void SaveCommands() => File.WriteAllLines("commands", commands.Select(s => s.ToSave()));
        private void LoadCommands()
        {
            if (File.Exists("commands"))
            {
                commands.AddRange(File.ReadAllLines("commands").Select(s => new Command(s)));
                FillList();
            }
        }

        private void btnRemoveCommand_Click(object sender, EventArgs e)
        {
            if (IsInvalid()) return;

            var item = ltbConfiguredCommands.SelectedItem as string;

            ltbConfiguredCommands.Items.Remove(ltbConfiguredCommands.SelectedItem);
            commands.Remove(commands.FirstOrDefault(f => f.Alias.Equals(item, StringComparison.InvariantCultureIgnoreCase)));

            SaveCommands();
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            SavePersonalInfo();
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            if (IsInvalid() || ltbConfiguredCommands.SelectedItem == null) return;

            var index = ltbConfiguredCommands.SelectedIndex;
            if (index == 0) return;

            var item = ltbConfiguredCommands.SelectedItem;
            index--;
            ltbConfiguredCommands.Items.RemoveAt(index + 1);
            ltbConfiguredCommands.Items.Insert(index, item);

            ltbConfiguredCommands.SelectedIndex = index;
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            if (IsInvalid() || ltbConfiguredCommands.SelectedItem == null) return;

            var index = ltbConfiguredCommands.SelectedIndex;
            if (index == ltbConfiguredCommands.Items.Count - 1) return;

            var item = ltbConfiguredCommands.SelectedItem;
            index++;
            ltbConfiguredCommands.Items.RemoveAt(index - 1);
            ltbConfiguredCommands.Items.Insert(index, item);

            ltbConfiguredCommands.SelectedIndex = index;            
        }

        private bool IsInvalid() => ltbConfiguredCommands.Items.Count <= 0 && (bot == null || bot.IsReceiving);

        private void btnAddAll_Click(object sender, EventArgs e)
        {
            commands.Clear();

            foreach (var command in Constants.AvailableCommands)
                commands.Add(new Command() { Alias = command.Key, Name = command.Key, CommandAction = command.Value });

            FillList();

            SaveCommands();
        }

        private void btnGetID_Click(object sender, EventArgs e)
            => MessageBox.Show("Click on Start and, on Telegram, send the '/id' message. \nThen, click on Stop and fill the Admin ID field with your ID.\nClick again on Start button.", "Getting ID", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}