using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HangmanProject
{
    public partial class frmTitle : Form
    {
        public frmTitle()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblGradeChange_Click(object sender, EventArgs e)
        {
            switch (lblGrade.Text)
            {
                case "7th":
                    lblGrade.Text = "8th";
                    break;
                case "8th":
                    lblGrade.Text = "9th";
                    break;
                case "9th":
                    lblGrade.Text = "7th";
                    break;
                default:
                    break;
            }
        }

        private void lblBegin_Click_1(object sender, EventArgs e)
        {
            Hide();
            using (frmGame newForm = new frmGame())
            {
                newForm.lblGrade.Text = this.lblGrade.Text;
                newForm.ShowDialog();
            }
           Show();
        }

        private void lblGrade_Click(object sender, EventArgs e)
        {

        }

        private void pbSplatter_Click(object sender, EventArgs e)
        {

        }
    }
}
