using System;
using System.Windows.Forms;

namespace DiscordChatBot.Extensions
{
    public static class Extensions
    {
        internal static void SafeChangeText(this ToolStripItem item, string value)
        {
            if (item.Owner != null && item.Owner.InvokeRequired)
            {
                item.Owner.Invoke(() => SafeChangeText(item, value));
                return;
            }

            item.Text = "Status: " + value;
        }

        internal static void SafeChangeText(this Label item, string value)
        {
            if (item != null && item.InvokeRequired)
            {
                item.Invoke(() => SafeChangeText(item, value));
                return;
            }

            item.Text = "Status: " + value;
        }

        internal static void SafeAddItem(this ListBox item, string value)
        {
            if (item != null && item.InvokeRequired)
            {
                item.Invoke(() => SafeAddItem(item, value));
                return;
            }
            item.Items.Add(string.Format("[{0}]  -{1}", string.Format("{0:dd/MM/yyyy HH:mm:ss}", DateTime.Now), value));
        }

        internal static void UpdateCell(this DataGridViewRow row, int i, object value)
        {
            if (i > row.Cells.Count - 1)
            {
                return;
            }

            if (row.DataGridView != null && row.DataGridView.InvokeRequired)
            {
                row.DataGridView.Invoke(() => row.UpdateCell(i, value));
                return;
            }

            row.Cells[i].Value = value;
        }

        internal static void Invoke(this Control control, Action action)
        {
            control.Invoke(action);
        }
    }
}
