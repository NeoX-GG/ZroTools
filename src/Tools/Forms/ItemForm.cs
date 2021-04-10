using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToolLibrary.Caches;
using ToolLibrary.Entities;
using ToolLibrary.Methods;
using ToolLibrary.Enums;
using ToolLibrary.Configs;

namespace Tools.Forms
{
    public partial class ItemForm : Form
    {
        public ItemForm()
        {
            InitializeComponent();
            ItemToolMethods.Initialize();

            int RegionIndex = 0;
            foreach(RegionType Region in (RegionType[])Enum.GetValues(typeof(RegionType)))
            {
                RegionComboBox.Items.Add(Region.ToString());
                if (Region != GlobalToolConfig.Region)
                {
                    RegionIndex++;
                    continue;
                }

                RegionComboBox.SelectedIndex = RegionIndex;
            }

            foreach(ItemEntity Entity in ItemToolCache.Items)
            {
                if (Entity.Vnum == -1 || string.IsNullOrEmpty(Entity.Name))
                {
                    continue;
                }
                VnumComboBox.Items.Add(Entity.Vnum);
                NameComboBox.Items.Add(Entity.Name);
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not added feature. Please, wait or add it (and do a pull request :).");
        }
    }
}
