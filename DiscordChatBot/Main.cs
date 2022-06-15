using Discord;
using DiscordChatBot.Extensions;
using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiscordChatBot
{
    public partial class Main : Form
    {
        private ToolStripStatusLabel Status;
        private ListBox Logs;
        private readonly string currentPath = Directory.GetCurrentDirectory();
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        public static string RemoveSpecialCharacters(string str)
        {
            return Regex.Replace(str, "[^a-zA-Z0-9_.]+", "", RegexOptions.Compiled);
        }

        private async void Start(bool IsGroupChat, bool IsChannel, ulong ChannelId, int Delay)
        {
            //TODO LOGIC
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            using (FormStart FormStart = new FormStart())
            {
                FormStart.ShowDialog();
                if (FormStart.Start)
                {
                    Logs = listBox1;

                    Start(FormStart.IsGroupChat, FormStart.IsChannel, FormStart.ChannelId, FormStart.Delay);
                }
            }
        }
    }
}
