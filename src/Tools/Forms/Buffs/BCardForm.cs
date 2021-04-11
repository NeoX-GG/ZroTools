using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToolLibrary.Entities;

namespace Tools.Forms.Buffs
{
    public partial class BCardForm : Form
    {
        List<BCardEntity> List = null;
        bool IsAInstance = false;

        public BCardForm(List<BCardEntity> _list = null)
        {
            InitializeComponent();
            List = _list;
            if (List != null)
            {
                //Load all bcards
            }
        }
    }
}
