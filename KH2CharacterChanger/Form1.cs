using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KingdomHearts2
{
    public partial class helpwindow : Form
    {
        public helpwindow()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.dropbox.com/s/yqwarqnz3nm0ubp/KH2CharacterChanger.dll?dl=0");
        }

        private void srclink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://github.com/Neriek/KH2CharacterChanger/");
        }

        private void nguthread_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.nextgenupdate.com/forums/ps3-cheats-customization/794889-kingdom-hearts-2-5-character-changer-netcheat-ps3-plugin.html");
        }
    }
}
