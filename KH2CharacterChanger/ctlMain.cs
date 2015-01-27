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
    public partial class  ctlMain : UserControl
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
        uint sor1 = 0; // Roxas
        uint sor2 = 0; // Roxas Dual Wield
        uint sor3 = 0; // Mickey Coat
        uint sor4 = 0; // Mickey
        uint sor5 = 0; // Donald
        uint sor6 = 0; // Goofy
        uint sor7 = 0; // Halloween Sora
        uint sor8 = 0; // Halloween Donald
        uint sor9 = 0; // Halloween Goofy
        uint sor10 = 0; // Xmas Sora
        uint sor11 = 0; // Xmas Donald
        uint sor12 = 0; // Xmas Goofy

        private void sora0_CheckedChanged(object sender, EventArgs e)
        {

            if (sora0.Checked)
            {
                NCInterface.ConstCodeRemove(sor1);
                NCInterface.ConstCodeRemove(sor2);
                NCInterface.ConstCodeRemove(sor3);
                NCInterface.ConstCodeRemove(sor4);
                NCInterface.ConstCodeRemove(sor5);
                NCInterface.ConstCodeRemove(sor6);
                NCInterface.ConstCodeRemove(sor7);
                NCInterface.ConstCodeRemove(sor8);
                NCInterface.ConstCodeRemove(sor9);
                NCInterface.ConstCodeRemove(sor10);
                NCInterface.ConstCodeRemove(sor11);
                NCInterface.ConstCodeRemove(sor12);

            }

        }

        private void sora1_CheckedChanged(object sender, EventArgs e)
        {

            string code = "0 027F6A88 005A";

           if (sora1.Checked)
            {
                NCInterface.ConstCodeRemove(sor2);
                NCInterface.ConstCodeRemove(sor3);
                NCInterface.ConstCodeRemove(sor4);
                NCInterface.ConstCodeRemove(sor5);
                NCInterface.ConstCodeRemove(sor6);
                NCInterface.ConstCodeRemove(sor7);
                NCInterface.ConstCodeRemove(sor8);
                NCInterface.ConstCodeRemove(sor9);
                NCInterface.ConstCodeRemove(sor10);
                NCInterface.ConstCodeRemove(sor11);
                NCInterface.ConstCodeRemove(sor12);

                sor1 = NCInterface.ConstCodeAdd(code, true);
            }
           else
           {
                NCInterface.ConstCodeRemove(sor1);
           }
        }

        private void sora2_CheckedChanged(object sender, EventArgs e)
        {

            string code = "0 027F6A88 0323";

            if (sora2.Checked)
            {
                NCInterface.ConstCodeRemove(sor1);
                NCInterface.ConstCodeRemove(sor3);
                NCInterface.ConstCodeRemove(sor4);
                NCInterface.ConstCodeRemove(sor5);
                NCInterface.ConstCodeRemove(sor6);
                NCInterface.ConstCodeRemove(sor7);
                NCInterface.ConstCodeRemove(sor8);
                NCInterface.ConstCodeRemove(sor9);
                NCInterface.ConstCodeRemove(sor10);
                NCInterface.ConstCodeRemove(sor11);
                NCInterface.ConstCodeRemove(sor12);

                sor2 = NCInterface.ConstCodeAdd(code, true);
            }
            else
            {
                NCInterface.ConstCodeRemove(sor2);
            }
        }

        private void sora3_CheckedChanged(object sender, EventArgs e)
        {
            string code = "0 027F6A88 005B";

            if (sora3.Checked)
            {
                NCInterface.ConstCodeRemove(sor1);
                NCInterface.ConstCodeRemove(sor2);
                NCInterface.ConstCodeRemove(sor4);
                NCInterface.ConstCodeRemove(sor5);
                NCInterface.ConstCodeRemove(sor6);
                NCInterface.ConstCodeRemove(sor7);
                NCInterface.ConstCodeRemove(sor8);
                NCInterface.ConstCodeRemove(sor9);
                NCInterface.ConstCodeRemove(sor10);
                NCInterface.ConstCodeRemove(sor11);
                NCInterface.ConstCodeRemove(sor12);

                sor3 = NCInterface.ConstCodeAdd(code, true);
            }
            else
            {
                NCInterface.ConstCodeRemove(sor3);
            }
        }

        private void sora4_CheckedChanged(object sender, EventArgs e)
        {
            string code = "0 027F6A88 0318";

            if (sora4.Checked)
            {
                NCInterface.ConstCodeRemove(sor1);
                NCInterface.ConstCodeRemove(sor2);
                NCInterface.ConstCodeRemove(sor3);
                NCInterface.ConstCodeRemove(sor5);
                NCInterface.ConstCodeRemove(sor6);
                NCInterface.ConstCodeRemove(sor7);
                NCInterface.ConstCodeRemove(sor8);
                NCInterface.ConstCodeRemove(sor9);
                NCInterface.ConstCodeRemove(sor10);
                NCInterface.ConstCodeRemove(sor11);
                NCInterface.ConstCodeRemove(sor12);

                sor4 = NCInterface.ConstCodeAdd(code, true);
            }
            else
            {
                NCInterface.ConstCodeRemove(sor4);
            }
        }

        private void sora5_CheckedChanged(object sender, EventArgs e)
        {
            string code = "0 027F6A88 005C";

            if (sora5.Checked)
            {
                NCInterface.ConstCodeRemove(sor1);
                NCInterface.ConstCodeRemove(sor2);
                NCInterface.ConstCodeRemove(sor3);
                NCInterface.ConstCodeRemove(sor4);
                NCInterface.ConstCodeRemove(sor6);
                NCInterface.ConstCodeRemove(sor7);
                NCInterface.ConstCodeRemove(sor8);
                NCInterface.ConstCodeRemove(sor9);
                NCInterface.ConstCodeRemove(sor10);
                NCInterface.ConstCodeRemove(sor11);
                NCInterface.ConstCodeRemove(sor12);

                sor5 = NCInterface.ConstCodeAdd(code, true);
            }
            else
            {
                NCInterface.ConstCodeRemove(sor5);
            }
        }

        private void sora6_CheckedChanged(object sender, EventArgs e)
        {
            string code = "0 027F6A88 005D";

            if (sora6.Checked)
            {
                NCInterface.ConstCodeRemove(sor1);
                NCInterface.ConstCodeRemove(sor2);
                NCInterface.ConstCodeRemove(sor3);
                NCInterface.ConstCodeRemove(sor4);
                NCInterface.ConstCodeRemove(sor5);
                NCInterface.ConstCodeRemove(sor7);
                NCInterface.ConstCodeRemove(sor8);
                NCInterface.ConstCodeRemove(sor9);
                NCInterface.ConstCodeRemove(sor10);
                NCInterface.ConstCodeRemove(sor11);
                NCInterface.ConstCodeRemove(sor12);

                sor6 = NCInterface.ConstCodeAdd(code, true);
            }
            else
            {
                NCInterface.ConstCodeRemove(sor6);
            }
        }

        private void sora7_CheckedChanged(object sender, EventArgs e)
        {
            string code = "0 027F6A88 02B5";

            if (sora7.Checked)
            {
                NCInterface.ConstCodeRemove(sor1);
                NCInterface.ConstCodeRemove(sor2);
                NCInterface.ConstCodeRemove(sor3);
                NCInterface.ConstCodeRemove(sor4);
                NCInterface.ConstCodeRemove(sor5);
                NCInterface.ConstCodeRemove(sor6);
                NCInterface.ConstCodeRemove(sor8);
                NCInterface.ConstCodeRemove(sor9);
                NCInterface.ConstCodeRemove(sor10);
                NCInterface.ConstCodeRemove(sor11);
                NCInterface.ConstCodeRemove(sor12);

                sor7 = NCInterface.ConstCodeAdd(code, true);
            }
            else
            {
                NCInterface.ConstCodeRemove(sor7);
            }
        }

        private void sora8_CheckedChanged(object sender, EventArgs e)
        {
            string code = "0 027F6A88 029E";

            if (sora8.Checked)
            {
                NCInterface.ConstCodeRemove(sor1);
                NCInterface.ConstCodeRemove(sor2);
                NCInterface.ConstCodeRemove(sor3);
                NCInterface.ConstCodeRemove(sor4);
                NCInterface.ConstCodeRemove(sor5);
                NCInterface.ConstCodeRemove(sor6);
                NCInterface.ConstCodeRemove(sor7);
                NCInterface.ConstCodeRemove(sor9);
                NCInterface.ConstCodeRemove(sor10);
                NCInterface.ConstCodeRemove(sor11);
                NCInterface.ConstCodeRemove(sor12);

                sor8 = NCInterface.ConstCodeAdd(code, true);
            }
            else
            {
                NCInterface.ConstCodeRemove(sor8);
            }
        }

        private void sora9_CheckedChanged(object sender, EventArgs e)
        {
            string code = "0 027F6A88 029D";

            if (sora9.Checked)
            {
                NCInterface.ConstCodeRemove(sor1);
                NCInterface.ConstCodeRemove(sor2);
                NCInterface.ConstCodeRemove(sor3);
                NCInterface.ConstCodeRemove(sor4);
                NCInterface.ConstCodeRemove(sor5);
                NCInterface.ConstCodeRemove(sor6);
                NCInterface.ConstCodeRemove(sor7);
                NCInterface.ConstCodeRemove(sor8);
                NCInterface.ConstCodeRemove(sor10);
                NCInterface.ConstCodeRemove(sor11);
                NCInterface.ConstCodeRemove(sor12);

                sor9 = NCInterface.ConstCodeAdd(code, true);
            }
            else
            {
                NCInterface.ConstCodeRemove(sor9);
            }
        }
        
        private void sora10_CheckedChanged(object sender, EventArgs e)
        {
            string code = "0 027F6A88 0955";
            if (sora10.Checked)
            {
                NCInterface.ConstCodeRemove(sor1);
                NCInterface.ConstCodeRemove(sor2);
                NCInterface.ConstCodeRemove(sor3);
                NCInterface.ConstCodeRemove(sor4);
                NCInterface.ConstCodeRemove(sor5);
                NCInterface.ConstCodeRemove(sor6);
                NCInterface.ConstCodeRemove(sor7);
                NCInterface.ConstCodeRemove(sor8);
                NCInterface.ConstCodeRemove(sor9);
                NCInterface.ConstCodeRemove(sor11);
                NCInterface.ConstCodeRemove(sor12);

                sor10 = NCInterface.ConstCodeAdd(code, true);
            }
            else
            {
                NCInterface.ConstCodeRemove(sor10);
            }
        }
        
        private void sora11_CheckedChanged(object sender, EventArgs e)
        {
            string code = "0 027F6A88 095B";
            if (sora11.Checked)
            {
                NCInterface.ConstCodeRemove(sor1);
                NCInterface.ConstCodeRemove(sor2);
                NCInterface.ConstCodeRemove(sor3);
                NCInterface.ConstCodeRemove(sor4);
                NCInterface.ConstCodeRemove(sor5);
                NCInterface.ConstCodeRemove(sor6);
                NCInterface.ConstCodeRemove(sor7);
                NCInterface.ConstCodeRemove(sor8);
                NCInterface.ConstCodeRemove(sor9);
                NCInterface.ConstCodeRemove(sor10);
                NCInterface.ConstCodeRemove(sor12);

                sor11 = NCInterface.ConstCodeAdd(code, true);
            }
            else
            {
                NCInterface.ConstCodeRemove(sor11);
            }
        }

        private void sora12_CheckedChanged(object sender, EventArgs e)
        {
            string code = "0 027F6A88 095C";
            if (sora12.Checked)
            {
                NCInterface.ConstCodeRemove(sor1);
                NCInterface.ConstCodeRemove(sor2);
                NCInterface.ConstCodeRemove(sor3);
                NCInterface.ConstCodeRemove(sor4);
                NCInterface.ConstCodeRemove(sor5);
                NCInterface.ConstCodeRemove(sor6);
                NCInterface.ConstCodeRemove(sor7);
                NCInterface.ConstCodeRemove(sor8);
                NCInterface.ConstCodeRemove(sor9);
                NCInterface.ConstCodeRemove(sor10);
                NCInterface.ConstCodeRemove(sor11);

                sor12 = NCInterface.ConstCodeAdd(code, true);
            }
            else
            {
                NCInterface.ConstCodeRemove(sor12);
            }
        }



        


    }
}
