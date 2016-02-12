using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultipleScreens_Feb_11_2016
{
    public partial class PlayScreen : UserControl
    {
        public PlayScreen()
        {
            InitializeComponent();
            nameLabel.Text = Form1.name;
        }

        private void PlayScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
