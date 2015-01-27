using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PluginInterface;

namespace KingdomHearts2
{
    public partial class ctlMain : UserControl
    {
        /// <summary> 
        /// NetCheat Interface Host
        /// </summary>
        public static IPluginHost NCInterface = null;

        public ctlMain()
        {
            InitializeComponent();
        }
        ///
        //-Help Window-
        ///
        private void helpbtn_Click(object sender, EventArgs e)
        {
            helpwindow secondForm = new helpwindow();
            secondForm.Show();
        }
        ///
        //Sora Changer Tab Start
        ///
        uint sor1 = 0;
        private void sora1_CheckedChanged(object sender, EventArgs e)
        {

            string code = "0 027F6A88 005A";

           if (sora1.Checked)
            {
                sor1 = NCInterface.ConstCodeAdd(code, true);
            }
           else
           {
               NCInterface.ConstCodeRemove(sor1);
           }
        }

        uint sor2 = 0;
        private void sora2_CheckedChanged(object sender, EventArgs e)
        {

            string code = "0 027F6A88 0323";

            if (sora2.Checked)
            {
                sor2 = NCInterface.ConstCodeAdd(code, true);
            }
            else
            {
                NCInterface.ConstCodeRemove(sor2);
            }
        }

        uint sor3 = 0;
        private void sora3_CheckedChanged(object sender, EventArgs e)
        {
            string code = "0 027F6A88 005B";

            if (sora3.Checked)
            {
                sor3 = NCInterface.ConstCodeAdd(code, true);
            }
            else
            {
                NCInterface.ConstCodeRemove(sor3);
            }
        }

        uint sor4 = 0;
        private void sora4_CheckedChanged(object sender, EventArgs e)
        {
            string code = "0 027F6A88 0318";

            if (sora4.Checked)
            {
                sor4 = NCInterface.ConstCodeAdd(code, true);
            }
            else
            {
                NCInterface.ConstCodeRemove(sor4);
            }
        }
        uint sor5 = 0;
        private void sora5_CheckedChanged(object sender, EventArgs e)
        {
            string code = "0 027F6A88 005C";

            if (sora5.Checked)
            {
                sor5 = NCInterface.ConstCodeAdd(code, true);
            }
            else
            {
                NCInterface.ConstCodeRemove(sor5);
            }
        }
        uint sor6 = 0;
        private void sora6_CheckedChanged(object sender, EventArgs e)
        {
            string code = "0 027F6A88 005D";

            if (sora6.Checked)
            {
                sor6 = NCInterface.ConstCodeAdd(code, true);
            }
            else
            {
                NCInterface.ConstCodeRemove(sor6);
            }
        }
        uint sor7 = 0;
        private void sora7_CheckedChanged(object sender, EventArgs e)
        {
            string code = "0 027F6A88 02B5";

            if (sora7.Checked)
            {
                sor7 = NCInterface.ConstCodeAdd(code, true);
            }
            else
            { 
                NCInterface.ConstCodeRemove(sor7);
            }
        }
        uint sor8 = 0;
        private void sora8_CheckedChanged(object sender, EventArgs e)
        {
            string code = "0 027F6A88 029E";

            if (sora8.Checked)
            {
                sor8 = NCInterface.ConstCodeAdd(code, true);
            }
            else
            {
                NCInterface.ConstCodeRemove(sor8);
            }
        }
        uint sor9 = 0;
        private void sora9_CheckedChanged(object sender, EventArgs e)
        {
            string code = "0 027F6A88 029D";

            if (sora9.Checked)
            {
                sor9 = NCInterface.ConstCodeAdd(code, true);
            }
            else
            {
                NCInterface.ConstCodeRemove(sor9);
            }
        }
        uint sor10 = 0;
        private void sora10_CheckedChanged(object sender, EventArgs e)
        {
            string code = "0 027F6A88 0955";
            if (sora10.Checked)
            {
                sor10 = NCInterface.ConstCodeAdd(code, true);
            }
            else
            {
                NCInterface.ConstCodeRemove(sor10);
            }
        }
        uint sor11 = 0;
        private void sora11_CheckedChanged(object sender, EventArgs e)
        {
            string code = "0 027F6A88 095B";
            if (sora11.Checked)
            {
                sor11 = NCInterface.ConstCodeAdd(code, true);
            }
            else
            {
                NCInterface.ConstCodeRemove(sor11);
            }
        }
        uint sor12 = 0;
        private void sora12_CheckedChanged(object sender, EventArgs e)
        {
            string code = "0 027F6A88 095C";
            if (sora12.Checked)
            {
                sor12 = NCInterface.ConstCodeAdd(code, true);
            }
            else
            {
                NCInterface.ConstCodeRemove(sor12);
            }
        }



    }
}
