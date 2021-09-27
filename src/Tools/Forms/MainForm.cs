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
using ToolLibrary.Configs;
using ToolLibrary.Helpers;
using Tools.Forms.Buffs;
using Tools.Forms.Items;

namespace Tools.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ItemButton_Click(object sender, EventArgs e)
        {
            new ItemForm().Show();
        }

        private void BuffButton_Click(object sender, EventArgs e)
        {
            new BCardForm().Show();
        }

        private void PacketCleanerButton_Click(object sender, EventArgs e)
        {
            if (!File.Exists(GlobalToolConfig.PacketDirectory))
            {
                MessageBox.Show("Packet.txt not exists");
                return;
            }
            List<string> list = new();
            using (StreamReader streamReader = new StreamReader(GlobalToolConfig.PacketDirectory))
            {
                string text;
                while ((text = streamReader.ReadLine()) != null)
                {
                    string[] arr = text.Split(' ');
                    if (!list.Contains(text) &&
                        (arr[0] == "at" ||
                        arr[0] == "wp" ||
                        arr[0] == "gp" ||
                        arr[0] == "rbr" ||
                        arr[0] == "n_run" ||
                        arr[0] == "m_list" ||
                        arr[0] == "pdtse" ||
                        arr[0] == "c_map" ||
                        arr[0] == "in" ||
                        arr[0] == "n_inv"))
                    {
                        list.Add(text);
                    }
                }
            }
            File.Delete(GlobalToolConfig.PacketDirectory);
            using (var writer = File.CreateText(GlobalToolConfig.PacketDirectory))
            {
                foreach (string str in list)
                {
                    writer.WriteLine(str);
                }
            }
            MessageBox.Show("Packet.txt cleaned");
        }
    }
}
