using System.CodeDom.Compiler;

namespace Radio_Button
{
    public partial class fTeaVsCofee : Form
    {
        public fTeaVsCofee()
        {
            InitializeComponent();
            rbChoice1.Checked = false;
            rbChoice2.Checked = false;
            pPanel1.Visible = false; ;
            pPanel2.Visible = false;
        }



        private void bEnter_Click(object sender, EventArgs e)
        {
            string result;
            string result2 = "";

            if (rbChoice1.Checked == true)
            {
                result = "Tea";
                if (rGreenTea.Checked == true) 
                { 
                    result2 = "Green Tea";
                    MessageBox.Show($"Result: \n {result} : {result2}");
                }
                else if (rBlackTea.Checked == true) 
                { 
                    result2 = "Black Tea";
                    MessageBox.Show($"Result: \n {result} : {result2}");
                }
                else { MessageBox.Show("Choose the specifics"); }

            }

            else if (rbChoice2.Checked == true)
            {
                result = "Coffee";
                if (rMocha.Checked == true) 
                {
                    result2 = "Mocha";
                    MessageBox.Show($"Result: \n {result} : {result2}");
                }
                else if (rBlackCofee.Checked == true) 
                { 
                    result2 = "Black Coffee"; 
                    MessageBox.Show($"Result: \n {result} : {result2}");
                }
                else { MessageBox.Show("Choose the specifics"); }
            }
            else
            {
                MessageBox.Show("Input a Choice");
            }

        }

        private void rbChoice1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbChoice1.Checked == true) { pPanel1.Visible = true; }
            else { pPanel1.Visible = false; }
        }

        private void rbChoice2_CheckedChanged(object sender, EventArgs e)
        {
            if(rbChoice2.Checked == true) {pPanel2.Visible = true; }
            else{ pPanel2.Visible = false; }
        }
    }
}
