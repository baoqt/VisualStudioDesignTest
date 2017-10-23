using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignTest
{
    public partial class DesignTest : Form
    {
        public DesignTest()
        {
            InitializeComponent();
        }

        private void KeyWordTextBox_TextChanged(object sender, EventArgs e)
        {
            if (KeyWordTextBox.Text == ("Key Word"))
            {
                ConfirmationLabel.Text = "Is Key Word";
            }
            else
            {
                ConfirmationLabel.Text = "Not Key Word";
            }
        }
    }
}
