using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace HangmanProject
{
    public partial class frmGame : Form
    {

        public void chooseLogic(char character)
        {
            char chr = character;
            if (lblWord.Text.Contains(chr))
            {
                int index = 0;
                String word = lblCodedWord.Text;
                do
                {
                    int indexOf = lblWord.Text.IndexOf(chr, index);
                    StringBuilder strB = new StringBuilder(word);
                    strB[indexOf * 2] = chr;
                    word = strB.ToString();
                    index = indexOf + 1;
                } while ((lblWord.Text.IndexOf(chr, index) != -1));
                lblCodedWord.Text = word;
            }
            else
            {
                changeImg();
            }
            checkWin();
            checkLose();
        }

        public void checkLose()
        {
            if (lblCnt.Text == "6")
            {
                string message = "You lost! Try again?";
                string caption = "Game Lost";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                result = MessageBox.Show(message, caption, buttons);
                if (result == DialogResult.Yes)
                {
                    newGame();
                }
                else
                {
                    closeFrm();
                }
            }
        }

        public void checkWin()
        {
            if (!(lblCodedWord.Text.Contains('_')))
            {
                string message = "You won! Congratulations! Another game?";
                string caption = "Game Won";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                result = MessageBox.Show(message, caption, buttons);
                if (result == DialogResult.Yes)
                {
                    newGame();
                }
                else
                {
                    closeFrm();
                }
            }
        }

        public void changeImg()
        {
            switch (lblCnt.Text)
            {
                case "0":
                    lblCnt.Text = "1";
                    pbHangman.Image = HangmanProject.Properties.Resources.Hangman_1;
                    break;
                case "1":
                    lblCnt.Text = "2";
                    pbHangman.Image = HangmanProject.Properties.Resources.Hangman_2;
                    break;
                case "2":
                    lblCnt.Text = "3";
                    pbHangman.Image = HangmanProject.Properties.Resources.Hangman_3;
                    break;
                case "3":
                    lblCnt.Text = "4";
                    pbHangman.Image = HangmanProject.Properties.Resources.Hangman_4;
                    break;
                case "4":
                    lblCnt.Text = "5";
                    pbHangman.Image = HangmanProject.Properties.Resources.Hangman_5;
                    break;
                case "5":
                    lblCnt.Text = "6";
                    pbHangman.Image = HangmanProject.Properties.Resources.Hangman_6;
                    break;
                default:
                    break;
            }
        }

        public void newGame()
        {
            lblCnt.Text = "0";
            pbHangman.Image = HangmanProject.Properties.Resources.Hangman_0;
            List<String> wordsList = new List<String>();
            String str;
            foreach (var lbl in pnLabels.Controls.OfType<Label>())
            {
                lbl.Enabled = true;
            }
               
            switch (this.lblGrade.Text)
            {
                case "7th":
                    str = Resources.Text_Files.Resource.txtEasy.ToString().Replace("\r\n", " ");
                    lblCodedWord.Text = "_ _ _ _ _ _ _";
                    break;
                case "8th":
                    str = Resources.Text_Files.Resource.txtMedium.ToString().Replace("\r\n", " ");
                    lblCodedWord.Text = "_ _ _ _ _ _ _ _";
                    break;
                case "9th":
                    str = Resources.Text_Files.Resource.txtHard.ToString().Replace("\r\n", " ");
                    lblCodedWord.Text = "_ _ _ _ _ _ _ _ _";
                    break;
                default:
                    str = Resources.Text_Files.Resource.txtEasy.ToString().Replace("\r\n", " ");
                    break;
            }
            wordsList.AddRange(str.Split());
            var rnd = new Random(Guid.NewGuid().GetHashCode());
            int rndNum = rnd.Next(0, 20);
            String word = wordsList[rndNum];
            lblWord.Text = word;
        }

        public void closeFrm()
        {
            this.Close();
        }

        public frmGame()
        {
            InitializeComponent();
        }

        private void frmGame_Load(object sender, EventArgs e)
        {
            newGame();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            closeFrm();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            lblA.Enabled = false;
            chooseLogic('a');
        }

        private void lblB_Click(object sender, EventArgs e)
        {
            lblB.Enabled = false;
            chooseLogic('b');
        }

        private void lblC_Click(object sender, EventArgs e)
        {
            lblC.Enabled = false;
            chooseLogic('c');
        }

        private void label3_Click(object sender, EventArgs e)
        {
            lblD.Enabled = false;
            chooseLogic('d');
        }

        private void lblE_Click(object sender, EventArgs e)
        {
            lblE.Enabled = false;
            chooseLogic('e');
        }

        private void lblF_Click(object sender, EventArgs e)
        {
            lblF.Enabled = false;
            chooseLogic('f');
        }

        private void lblG_Click(object sender, EventArgs e)
        {
            lblG.Enabled = false;
            chooseLogic('g');
        }

        private void lblH_Click(object sender, EventArgs e)
        {
            lblH.Enabled = false;
            chooseLogic('h');
        }

        private void lblI_Click(object sender, EventArgs e)
        {
            lblI.Enabled = false;
            chooseLogic('i');
        }

        private void lblJ_Click(object sender, EventArgs e)
        {
            lblJ.Enabled = false;
            chooseLogic('j');
        }

        private void lblK_Click(object sender, EventArgs e)
        {
            lblK.Enabled = false;
            chooseLogic('k');
        }

        private void lblL_Click(object sender, EventArgs e)
        {
            lblL.Enabled = false;
            chooseLogic('l');
        }

        private void lblM_Click(object sender, EventArgs e)
        {
            lblM.Enabled = false;
            chooseLogic('m');
        }

        private void lblN_Click(object sender, EventArgs e)
        {
            lblN.Enabled = false;
            chooseLogic('n');
        }

        private void lblO_Click(object sender, EventArgs e)
        {
            lblO.Enabled = false;
            chooseLogic('o');
        }

        private void lblP_Click(object sender, EventArgs e)
        {
            lblP.Enabled = false;
            chooseLogic('p');
        }

        private void lblQ_Click(object sender, EventArgs e)
        {
            lblQ.Enabled = false;
            chooseLogic('q');
        }

        private void lblR_Click(object sender, EventArgs e)
        {
            lblR.Enabled = false;
            chooseLogic('r');
        }

        private void lblS_Click(object sender, EventArgs e)
        {
            lblS.Enabled = false;
            chooseLogic('s');
        }

        private void lblT_Click(object sender, EventArgs e)
        {
            lblT.Enabled = false;
            chooseLogic('t');
        }

        private void lblU_Click(object sender, EventArgs e)
        {
            lblU.Enabled = false;
            chooseLogic('u');
        }

        private void lblV_Click(object sender, EventArgs e)
        {
            lblV.Enabled = false;
            chooseLogic('v');
        }

        private void lblW_Click(object sender, EventArgs e)
        {
            lblW.Enabled = false;
            chooseLogic('w');
        }

        private void lblX_Click(object sender, EventArgs e)
        {
            lblX.Enabled = false;
            chooseLogic('x');
        }

        private void lblY_Click(object sender, EventArgs e)
        {
            lblY.Enabled = false;
            chooseLogic('y');
        }

        private void lblZ_Click(object sender, EventArgs e)
        {
            lblZ.Enabled = false;
            chooseLogic('z');
        }

        private void pbSplatter_Click(object sender, EventArgs e)
        {
            lblWord.Visible = true;
            lblGrade.Visible = true;
            lblCnt.Visible = true;
        }
    }
}
