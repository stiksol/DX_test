using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace DX_tests
{
    public partial class IntPot2 : Form
    {
        public IntPot2()
        {
            InitializeComponent();
            if (DX_tests.Properties.Settings.Default.t1 == "+" )
                { 
                    Bitmap image1 = new Bitmap(DX_tests.Properties.Resources.yes);
                    pictureBox5.Image = (image1);
                }
            else 
                {
                    Bitmap image1 = new Bitmap(DX_tests.Properties.Resources.no);
                    pictureBox5.Image = (image1);
                }
//***********************************************************************************************************************
                   if (DX_tests.Properties.Settings.Default.t2 == "+" )
                { 
                    Bitmap image1 = new Bitmap(DX_tests.Properties.Resources.yes);
                    pictureBox6.Image = (image1);
                }
            else 
                {
                    Bitmap image1 = new Bitmap(DX_tests.Properties.Resources.no);
                    pictureBox6.Image = (image1);
                }
//***********************************************************************************************************************
                   if (DX_tests.Properties.Settings.Default.t3 == "+" )
                { 
                    Bitmap image1 = new Bitmap(DX_tests.Properties.Resources.yes);
                    pictureBox7.Image = (image1);
                }
            else 
                {
                    Bitmap image1 = new Bitmap(DX_tests.Properties.Resources.no);
                    pictureBox7.Image = (image1);
                }
//***********************************************************************************************************************
                   if (DX_tests.Properties.Settings.Default.t4 == "+" )
                { 
                    Bitmap image1 = new Bitmap(DX_tests.Properties.Resources.yes);
                    pictureBox8.Image = (image1);
                }
            else 
                {
                    Bitmap image1 = new Bitmap(DX_tests.Properties.Resources.no);
                    pictureBox8.Image = (image1);
                }
//***********************************************************************************************************************
        }

      
    }
}
