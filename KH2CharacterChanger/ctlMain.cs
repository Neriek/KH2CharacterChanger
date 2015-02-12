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
        uint sor13 = 0; // Tron Sora
        uint sor14 = 0; // Tron Donald
        uint sor15 = 0; // Tron Goofy
        uint sor16 = 0; // Timeless Sora
        uint sor17 = 0; // Timeless Donald
        uint sor18 = 0; // Timeless Goofy
        uint sor19 = 0; // Sora - Kingdom Hearts 1 Outfit
        ///
        // Model Modifier Tab Start
        ///
        uint sormoda1 = 0; // Normal Sora Valor Clothes
        uint sormoda2 = 0; // Wisdom Clothes
        uint sormoda3 = 0; // Master CLothes
        uint sormoda4 = 0; // Final Clothes
        uint sormoda5 = 0; // Anti Clothes
        uint sormoda6 = 0; // Limit Clothes
        uint sormodb1 = 0; // Valor Sora Normal Clothes
        uint sormodb2 = 0; // Wisdom Clothes
        uint sormodb3 = 0; // Master Clothes
        uint sormodb4 = 0; // Final Clothes
        uint sormodb5 = 0; // Anti Clothes
        uint sormodb6 = 0; // Limit Clothes
        uint sormodc1 = 0; // Wisdom Sora Normal Clothes
        uint sormodc2 = 0; // Valor Clothes
        uint sormodc3 = 0; // Master Clothes
        uint sormodc4 = 0; // Final Clothes
        uint sormodc5 = 0; // Anti Clothes
        uint sormodc6 = 0; // Limit Clothes
        uint sormodd1 = 0; // Master Sora Normal Clothes
        uint sormodd2 = 0; // Valor Clothes
        uint sormodd3 = 0; // Wisdom Clothes
        uint sormodd4 = 0; // Final Clothes
        uint sormodd5 = 0; // Anti Clothes
        uint sormodd6 = 0; // Limit Clothes
        uint sormode1 = 0; // Final Sora Normal Clothes
        uint sormode2 = 0; // Valor Clothes
        uint sormode3 = 0; // Wisdom Clothes
        uint sormode4 = 0; // Master Clothes
        uint sormode5 = 0; // Anti Clothes
        uint sormode6 = 0; // Limit Clothes
 /*       uint sormodf1 = 0; // Anti Sora Normal Clothes
        uint sormodf2 = 0; // Valor Clothes
        uint sormodf3 = 0; // Wisdom Clothes
        uint sormodf4 = 0; // Master Clothes
        uint sormodf5 = 0; // Final Clothes
        uint sormodf6 = 0; // Limit Clothes */
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
                NCInterface.ConstCodeRemove(sor13);
                NCInterface.ConstCodeRemove(sor14);
                NCInterface.ConstCodeRemove(sor15);
                NCInterface.ConstCodeRemove(sor16);
                NCInterface.ConstCodeRemove(sor17);
                NCInterface.ConstCodeRemove(sor18);


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
                NCInterface.ConstCodeRemove(sor13);
                NCInterface.ConstCodeRemove(sor14);
                NCInterface.ConstCodeRemove(sor15);
                NCInterface.ConstCodeRemove(sor16);
                NCInterface.ConstCodeRemove(sor17);
                NCInterface.ConstCodeRemove(sor18);

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
                NCInterface.ConstCodeRemove(sor13);
                NCInterface.ConstCodeRemove(sor14);
                NCInterface.ConstCodeRemove(sor15);
                NCInterface.ConstCodeRemove(sor16);
                NCInterface.ConstCodeRemove(sor17);
                NCInterface.ConstCodeRemove(sor18);

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
                NCInterface.ConstCodeRemove(sor13);
                NCInterface.ConstCodeRemove(sor14);
                NCInterface.ConstCodeRemove(sor15);
                NCInterface.ConstCodeRemove(sor16);
                NCInterface.ConstCodeRemove(sor17);
                NCInterface.ConstCodeRemove(sor18);

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
                NCInterface.ConstCodeRemove(sor13);
                NCInterface.ConstCodeRemove(sor14);
                NCInterface.ConstCodeRemove(sor15);
                NCInterface.ConstCodeRemove(sor16);
                NCInterface.ConstCodeRemove(sor17);
                NCInterface.ConstCodeRemove(sor18);

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
                NCInterface.ConstCodeRemove(sor13);
                NCInterface.ConstCodeRemove(sor14);
                NCInterface.ConstCodeRemove(sor15);
                NCInterface.ConstCodeRemove(sor16);
                NCInterface.ConstCodeRemove(sor17);
                NCInterface.ConstCodeRemove(sor18);

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
                NCInterface.ConstCodeRemove(sor13);
                NCInterface.ConstCodeRemove(sor14);
                NCInterface.ConstCodeRemove(sor15);
                NCInterface.ConstCodeRemove(sor16);
                NCInterface.ConstCodeRemove(sor17);
                NCInterface.ConstCodeRemove(sor18);

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
                NCInterface.ConstCodeRemove(sor13);
                NCInterface.ConstCodeRemove(sor14);
                NCInterface.ConstCodeRemove(sor15);
                NCInterface.ConstCodeRemove(sor16);
                NCInterface.ConstCodeRemove(sor17);
                NCInterface.ConstCodeRemove(sor18);

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
                NCInterface.ConstCodeRemove(sor13);
                NCInterface.ConstCodeRemove(sor14);
                NCInterface.ConstCodeRemove(sor15);
                NCInterface.ConstCodeRemove(sor16);
                NCInterface.ConstCodeRemove(sor17);
                NCInterface.ConstCodeRemove(sor18);

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
                NCInterface.ConstCodeRemove(sor13);
                NCInterface.ConstCodeRemove(sor14);
                NCInterface.ConstCodeRemove(sor15);
                NCInterface.ConstCodeRemove(sor16);
                NCInterface.ConstCodeRemove(sor17);
                NCInterface.ConstCodeRemove(sor18);

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
                NCInterface.ConstCodeRemove(sor13);
                NCInterface.ConstCodeRemove(sor14);
                NCInterface.ConstCodeRemove(sor15);
                NCInterface.ConstCodeRemove(sor16);
                NCInterface.ConstCodeRemove(sor17);
                NCInterface.ConstCodeRemove(sor18);

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
                NCInterface.ConstCodeRemove(sor13);
                NCInterface.ConstCodeRemove(sor14);
                NCInterface.ConstCodeRemove(sor15);
                NCInterface.ConstCodeRemove(sor16);
                NCInterface.ConstCodeRemove(sor17);
                NCInterface.ConstCodeRemove(sor18);

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
                NCInterface.ConstCodeRemove(sor13);
                NCInterface.ConstCodeRemove(sor14);
                NCInterface.ConstCodeRemove(sor15);
                NCInterface.ConstCodeRemove(sor16);
                NCInterface.ConstCodeRemove(sor17);
                NCInterface.ConstCodeRemove(sor18);

                sor12 = NCInterface.ConstCodeAdd(code, true);
            }
            else
            {
                NCInterface.ConstCodeRemove(sor12);
            }
        }

        private void sora13_CheckedChanged(object sender, EventArgs e)
        {
            string code = "0 027F6A88 0656";
            if (sora13.Checked)
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
                NCInterface.ConstCodeRemove(sor14);
                NCInterface.ConstCodeRemove(sor15);
                NCInterface.ConstCodeRemove(sor16);
                NCInterface.ConstCodeRemove(sor17);
                NCInterface.ConstCodeRemove(sor18);

                sor13 = NCInterface.ConstCodeAdd(code, true);
            }
            else
            {
                NCInterface.ConstCodeRemove(sor13);
            }
        }

        private void sora14_CheckedChanged(object sender, EventArgs e)
        {
            string code = "0 027F6A88 055A";
            if (sora14.Checked)
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
                NCInterface.ConstCodeRemove(sor13);
                NCInterface.ConstCodeRemove(sor15);
                NCInterface.ConstCodeRemove(sor16);
                NCInterface.ConstCodeRemove(sor17);
                NCInterface.ConstCodeRemove(sor18);

                sor14 = NCInterface.ConstCodeAdd(code, true);
            }
            else
            {
                NCInterface.ConstCodeRemove(sor14);
            }
        }

        private void sora15_CheckedChanged(object sender, EventArgs e)
        {
            string code = "0 027F6A88 0554";
            if (sora15.Checked)
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
                NCInterface.ConstCodeRemove(sor13);
                NCInterface.ConstCodeRemove(sor14);
                NCInterface.ConstCodeRemove(sor16);
                NCInterface.ConstCodeRemove(sor17);
                NCInterface.ConstCodeRemove(sor18);
                                
                sor15 = NCInterface.ConstCodeAdd(code, true);
            }
            else
            {
                NCInterface.ConstCodeRemove(sor15);
            }
        }

        private void sora16_CheckedChanged(object sender, EventArgs e)
        {
            string code = "0 027F6A88 0657";
            if (sora16.Checked)
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
                NCInterface.ConstCodeRemove(sor13);
                NCInterface.ConstCodeRemove(sor14);
                NCInterface.ConstCodeRemove(sor15);
                NCInterface.ConstCodeRemove(sor17);
                NCInterface.ConstCodeRemove(sor18);

                sor16 = NCInterface.ConstCodeAdd(code, true);
            }
            else
            {
                NCInterface.ConstCodeRemove(sor16);
            }
        }

        private void sora17_CheckedChanged(object sender, EventArgs e)
        {
            string code = "0 027F6A88 05CF";
            if (sora17.Checked)
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
                NCInterface.ConstCodeRemove(sor13);
                NCInterface.ConstCodeRemove(sor14);
                NCInterface.ConstCodeRemove(sor15);
                NCInterface.ConstCodeRemove(sor16);
                NCInterface.ConstCodeRemove(sor18);

                sor17 = NCInterface.ConstCodeAdd(code, true);
            }
            else
            {
                NCInterface.ConstCodeRemove(sor17);
            }
        }

        private void sora18_CheckedChanged(object sender, EventArgs e)
        {
            string code = "0 027F6A88 04F5";
            if (sora18.Checked)
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
                NCInterface.ConstCodeRemove(sor13);
                NCInterface.ConstCodeRemove(sor14);
                NCInterface.ConstCodeRemove(sor15);
                NCInterface.ConstCodeRemove(sor16);
                NCInterface.ConstCodeRemove(sor17);

                sor18 = NCInterface.ConstCodeAdd(code, true);
            }
            else
            {
                NCInterface.ConstCodeRemove(sor18);
            }
        }

        private void sora19_CheckedChanged(object sender, EventArgs e)
        {
            string code = "0 027F6A88 06C1";
            if (sora19.Checked)
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
                NCInterface.ConstCodeRemove(sor13);
                NCInterface.ConstCodeRemove(sor14);
                NCInterface.ConstCodeRemove(sor15);
                NCInterface.ConstCodeRemove(sor16);
                NCInterface.ConstCodeRemove(sor17);
                NCInterface.ConstCodeRemove(sor18);

                sor19 = NCInterface.ConstCodeAdd(code, true);
            }
            else
            {
                NCInterface.ConstCodeRemove(sor19);
            }
        }
        
        string codeA = "0 0280E984 313030";
        string codeB = "0 0280E9E4 313030";
        string codeC = "0 0280EA44 313030";
        string codeD = "0 0280EAA4 313030";
        string codeE = "0 0280EB04 313030";
        private void soramoda0_CheckedChanged(object sender, EventArgs e)
        {
            if (soramoda0.Checked)
            {
                NCInterface.ConstCodeRemove(sormoda1);
                NCInterface.ConstCodeRemove(sormoda2);
                NCInterface.ConstCodeRemove(sormoda3);
                NCInterface.ConstCodeRemove(sormoda4);
                NCInterface.ConstCodeRemove(sormoda5);
                NCInterface.ConstCodeRemove(sormoda6);
            }
        }

        ///
        //Normal Sora Model Modifier Start
        ///
        private void soramoda1_CheckedChanged(object sender, EventArgs e)
        {
            string code = "0 0280E987 5F42544C46";

            if (soramoda1.Checked)
            {
                sormoda1 = NCInterface.ConstCodeAdd(code, true);
                sormoda1 = NCInterface.ConstCodeAdd(codeA, true);
            }
            else
            {
                NCInterface.ConstCodeRemove(sormoda1);
            }
        }

        private void soramoda2_CheckedChanged(object sender, EventArgs e)
        {
            string code = "0 0280E987 5F4D414746";
            if (soramoda2.Checked)
            {
                sormoda2 = NCInterface.ConstCodeAdd(code, true);
                sormoda2 = NCInterface.ConstCodeAdd(codeA, true);
            }
            else
            {
                NCInterface.ConstCodeRemove(sormoda2);
            }
        }

        private void soramoda3_CheckedChanged(object sender, EventArgs e)
        {
            string code = "0 0280E987 5F54524946";
            if (soramoda3.Checked)
            {
                sormoda3 = NCInterface.ConstCodeAdd(code, true);
                sormoda3 = NCInterface.ConstCodeAdd(codeA, true);
            }
            else
            {
                NCInterface.ConstCodeRemove(sormoda3);
            }
        }

        private void soramoda4_CheckedChanged(object sender, EventArgs e)
        {
            string code = "0 0280E987 5F554C5446";
            if (soramoda4.Checked)
            {
                sormoda4 = NCInterface.ConstCodeAdd(code, true);
                sormoda4 = NCInterface.ConstCodeAdd(codeA, true);
            }
            else
            {
                NCInterface.ConstCodeRemove(sormoda4);
            }
        }

        private void soramoda5_CheckedChanged(object sender, EventArgs e)
        {
            string code = "0 0280E987 5F48544C46";
            if (soramoda5.Checked)
            {
                sormoda5 = NCInterface.ConstCodeAdd(code, true);
                sormoda5 = NCInterface.ConstCodeAdd(codeA, true);
            }
            else
            {
                NCInterface.ConstCodeRemove(sormoda5);
            }
        }

        private void soramoda6_CheckedChanged(object sender, EventArgs e)
        {
            string code = "0 0280E987 5F4B483146";
            if (soramoda6.Checked)
            {
                sormoda6 = NCInterface.ConstCodeAdd(code, true);
                sormoda6 = NCInterface.ConstCodeAdd(codeA, true);
            }
            else
            {
                NCInterface.ConstCodeRemove(sormoda6);
            }
        }

        ///
        //Valor Sora Model Modifier
        ///
        private void soramodb0_CheckedChanged(object sender, EventArgs e)
        {
            if (soramodb0.Checked)
            {
                NCInterface.ConstCodeRemove(sormodb1);
                NCInterface.ConstCodeRemove(sormodb2);
                NCInterface.ConstCodeRemove(sormodb3);
                NCInterface.ConstCodeRemove(sormodb4);
                NCInterface.ConstCodeRemove(sormodb5);
                NCInterface.ConstCodeRemove(sormodb6);
            }
        }

        private void soramodb1_CheckedChanged(object sender, EventArgs e)
        {
            string code = "0 0280E9E7 00000000";
            if (soramodb1.Checked)
            {
                sormodb1 = NCInterface.ConstCodeAdd(codeB, true);
                sormodb1 = NCInterface.ConstCodeAdd(code, true);
            }
            else
            {
                NCInterface.ConstCodeRemove(sormodb1);
            }
        }

        private void soramodb2_CheckedChanged(object sender, EventArgs e)
            {
                string code = "0 0280E9E7 5F4D414746";
                if (soramodb2.Checked)
                {
                    sormodb2 = NCInterface.ConstCodeAdd(codeB, true);
                    sormodb2 = NCInterface.ConstCodeAdd(code, true);
                }
                else
                {
                    NCInterface.ConstCodeRemove(sormodb2);
                }
            }

        private void soramodb3_CheckedChanged(object sender, EventArgs e)
        {
            string code = "0 0280E9E7 5F54524946";
            if (soramodb2.Checked)
            {
                sormodb2 = NCInterface.ConstCodeAdd(codeB, true);
                sormodb2 = NCInterface.ConstCodeAdd(code, true);
            }
            else
            {
                NCInterface.ConstCodeRemove(sormodb2);
            }
        }

        private void soramodb4_CheckedChanged(object sender, EventArgs e)
        {
            string code = "0 0280E9E7 5F554C5446";
            if (soramodb4.Checked)
            {
                sormodb4 = NCInterface.ConstCodeAdd(codeB, true);
                sormodb4 = NCInterface.ConstCodeAdd(code, true);
            }
            else
            {
                NCInterface.ConstCodeRemove(sormodb4);
            }
        }

        private void soramodb5_CheckedChanged(object sender, EventArgs e)
        {
            string code = "0 0280E9E7 5F48544C46";
            if (soramodb5.Checked)
            {
                sormodb5 = NCInterface.ConstCodeAdd(codeB, true);
                sormodb5 = NCInterface.ConstCodeAdd(code, true);
            }
            else
            {
                NCInterface.ConstCodeRemove(sormodb5);
            }
        }

        private void soramodb6_CheckedChanged(object sender, EventArgs e)
        {
            string code = "0 0280E9E7 5F4B483146";
            if (soramodb6.Checked)
            {
                sormodb6 = NCInterface.ConstCodeAdd(codeB, true);
                sormodb6 = NCInterface.ConstCodeAdd(code, true);
            }
            else
            {
                NCInterface.ConstCodeRemove(sormodb6);
            }
        }


        ///
        // Wisdom Sora
        ///
        private void soramodc0_CheckedChanged(object sender, EventArgs e)
        {
            if (soramodc0.Checked)
            {
                NCInterface.ConstCodeRemove(sormodc1);
                NCInterface.ConstCodeRemove(sormodc2);
                NCInterface.ConstCodeRemove(sormodc3);
                NCInterface.ConstCodeRemove(sormodc4);
                NCInterface.ConstCodeRemove(sormodc5);
                NCInterface.ConstCodeRemove(sormodc6);
            }
        }
        ///
        // Master Sora
        ///
        private void soramodd0_CheckedChanged(object sender, EventArgs e)
        {
            if (soramodd0.Checked)
            {

                NCInterface.ConstCodeRemove(sormodd1);
                NCInterface.ConstCodeRemove(sormodd2);
                NCInterface.ConstCodeRemove(sormodd3);
                NCInterface.ConstCodeRemove(sormodd4);
                NCInterface.ConstCodeRemove(sormodd5);
                NCInterface.ConstCodeRemove(sormodd6);
            }
        }
        ///
        // Final Sora
        ///
        private void soramode0_CheckedChanged(object sender, EventArgs e)
        {
            if (soramode0.Checked)
            {
                NCInterface.ConstCodeRemove(sormode1);
                NCInterface.ConstCodeRemove(sormode2);
                NCInterface.ConstCodeRemove(sormode3);
                NCInterface.ConstCodeRemove(sormode4);
                NCInterface.ConstCodeRemove(sormode5);
                NCInterface.ConstCodeRemove(sormode6);
            }
        }

    }
}
