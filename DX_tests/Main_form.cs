using System;
using System.Windows.Forms;
using DX_tests.TypeThinking;

namespace DX_tests
{
    public partial class Main_form : Form
    {
        public Main_form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SocialInt SI = new SocialInt();
            SI.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Profile PR = new Profile();
            PR.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
             Trevog TR = new Trevog();
             TR.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            IntPot IP = new IntPot();
            IP.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Emotions emo = new Emotions();
            emo.ShowDialog();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            ProfAdd PA = new ProfAdd();
            PA.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
           var TT = new TypeThinking.TypeThinking();
           TT.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var prBel = new Profile_Bel.Profile_Bel();
            prBel.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var chAndProf = new CharacterAndProf();
            chAndProf.ShowDialog();

        }

      }
    }

