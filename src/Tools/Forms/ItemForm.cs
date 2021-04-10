using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToolLibrary.Caches;
using ToolLibrary.Entities;
using ToolLibrary.Methods;
using ToolLibrary.Enums;
using ToolLibrary.Configs;
using System.Reflection;
using System.Diagnostics;

namespace Tools.Forms
{
    public partial class ItemForm : Form
    {
        #region Properties

        ItemEntity Item = null;

        #endregion

        public ItemForm()
        {
            InitializeComponent();
            ItemToolMethods.Initialize();

            int RegionIndex = 0;

            foreach (RegionType Region in (RegionType[])Enum.GetValues(typeof(RegionType)))
            {
                RegionComboBox.Items.Add(Region.ToString());
                if (Region != GlobalToolConfig.Region)
                {
                    RegionIndex++;
                    continue;
                }

                RegionComboBox.SelectedIndex = RegionIndex;
            }

            Assembly assembly = Assembly.GetExecutingAssembly();
            FileVersionInfo fileVersionInfo = FileVersionInfo.GetVersionInfo(assembly.Location);
            VersionLbl.Text = "Version: " + fileVersionInfo.ProductVersion;

            Initialize();
        }

        #region Click

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not added feature. Please, wait or add it (and do a pull request :).");
        }

        #endregion

        #region Selected Index Changed

        private void RegionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReloadRegion();
        }

        private void VnumComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeItem(SearchType.Vnum);
        }

        private void NameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeItem(SearchType.Name);
        }

        #endregion
        
        #region Key Press

        private void VnumComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                ChangeItem(SearchType.Vnum);
            }
        }

        private void NameComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                ChangeItem(SearchType.Name);
            }
        }

        private void RegionComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                ReloadRegion();
            }
        }

        #endregion

        #region Methods

        private Task Initialize()
        {
            foreach (ItemEntity Entity in ItemToolCache.Items)
            {
                if (Entity.Vnum == -1 || string.IsNullOrEmpty(Entity.Name))
                {
                    continue;
                }
                VnumComboBox.Items.Add(Entity.Vnum);
                NameComboBox.Items.Add(Entity.Name);
            }
            return Task.CompletedTask;
        }

        private Task ChangeItem(SearchType Search)
        {
            DescriptionTxtBox.Text = string.Empty;
            ValuesTxtBox.Text = string.Empty;
            if (Search == SearchType.Name)
            {
                Item = ItemToolMethods.GetByName(NameComboBox.Text).Result;
                ReloadForm();
                return Task.CompletedTask;
            }
            short vnum = Convert.ToInt16(VnumComboBox.Text);
            Item = ItemToolMethods.GetByVNum(vnum).Result;
            ReloadForm();
            return Task.CompletedTask;
        }

        private Task ReloadForm()
        {
            VnumComboBox.Text = Item.Vnum.ToString();
            NameComboBox.Text = Item.Name;
            DescriptionTxtBox.Lines = string.IsNullOrEmpty(Item.Description) ? new string[] {"This item dont have description."} : Item.Description.Replace("[n]", "\n").Split('\n');
            ImagePicBox.ImageLocation = ItemToolConfig.ImgDir + Item.Image + ".png";
            return Task.CompletedTask;
        }

        private Task ReloadRegion()
        {
            VnumComboBox.Text = "";
            NameComboBox.Text = "";
            DescriptionTxtBox.Text = "";
            ValuesTxtBox.Text = "";
            VnumComboBox.Items.Clear();
            NameComboBox.Items.Clear();

            foreach (RegionType Region in (RegionType[])Enum.GetValues(typeof(RegionType)))
            {
                if (Region.ToString().Equals(RegionComboBox.Text))
                {
                    GlobalToolConfig.Region = Region;
                    ItemToolMethods.ReloadTxt();
                    Initialize();
                }
            }

            return Task.CompletedTask;
        }

        #endregion

        
    }
}
