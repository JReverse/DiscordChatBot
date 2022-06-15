using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiscordChatBot
{
    public partial class FormStart : Form
    {
        public bool Start = false;
        public ulong ChannelId;
        public int Delay;
        public bool IsGroupChat;
        public bool IsChannel;
        public FormStart()
        {
            InitializeComponent();
        }

        private void FormStart_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Start = true;
            Delay = (int)numericUpDown1.Value;
            IsGroupChat = checkBox4.Checked;
            IsChannel = checkBox6.Checked;
            Properties.Settings.Default.Save();
            if (IsChannel)
            {
                ChannelId = Convert.ToUInt64(textBox4.Text.Trim());
            }

            Close();
        }
    }
}
