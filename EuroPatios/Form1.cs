namespace EuroPatios
{
    public partial class frmEstimate : Form
    {
        public frmEstimate()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Changing the heading text color to red
            lblHeading.ForeColor = Color.Red;

            //Default for brick option is selected
            rBBrick.Checked = true;

            //Hiding certain textboxes and labels
            gbFoundations.Visible = false;
            lblLength.Visible = false;
            lblWidth.Visible = false;
            lblMetres1.Visible = false;
            lblMetres2.Visible = false;
            tbLength.Visible = false;
            tbWidth.Visible = false;
            lblEuro.Visible = false;
            lblGbp.Visible = false;
            tbGBP.Visible = false;
            tbEURO.Visible = false;
            cmdCalculate.Visible = false;
            cmdClear.Visible = false;
            //lblSelection.Visible = false;        

            
        }

        private void cmdStart_Click(object sender, EventArgs e)
        {        
            //cmdStart.Visible=false;
            string r = checktextbox();
            if(r== "yes")
            {
                visibility();
            }
            if (r == "no")
            {                   
                MessageBox.Show("Exchange Rate or Prices not entered", "Reminder", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbExchangeRate.Text = null;
                tbBrick.Text = null;
                tbConcrete.Text = null;
                tbTarmac.Text = null;
                tbGravel.Text = null;
            } 
            
        }

        private void visibility()
        {
            cmdStart.Visible = false;
            //Changing the visibility status of all the controls to true
            foreach(Control c in Controls)
            {
                if (c.Visible==false)
                {
                    c.Visible = true;
                }
            }

            //Changing the visibility to false for the foll controls
            tbBrick.Visible = false;
            tbConcrete.Visible = false;
            tbTarmac.Visible = false;
            tbGravel.Visible = false;
            lblPricePerSq.Visible = false;
            cmdStart.Visible = false;
                            
            lblOutput.BorderStyle = BorderStyle.FixedSingle;
            lblOutput.BackColor = Color.Green;
            lblOutput.ForeColor= Color.Green;

            lblHeading.ForeColor= Color.Green;

            rbStandard.Checked = true;
            tbGBP.Text = "1";
            tbEURO.Text=tbExchangeRate.Text;
        }

        private string checktextbox()
        {
            string[] values = {tbExchangeRate.Text,tbBrick.Text,tbConcrete.Text,tbGravel.Text,tbTarmac.Text};
            string result="";
            double numvalue;
            foreach(var value in values)
            {
                if(double.TryParse(value, out numvalue) && value!=string.Empty)
                {   result = "yes";
                    continue;
                }
                else
                {
                    result = "no";
                    break;                   
                }
            }
            return result;       
        }

        private void cmdCalculate_Click(object sender, EventArgs e)
        {
            if (float.TryParse(tbLength.Text, out float length) && tbLength.Text != String.Empty)
            {
                if (float.TryParse(tbWidth.Text, out float width) && tbWidth.Text != String.Empty)
                {
                    //Code to run if length and width paramaters are correctly entered
                    float materialPrice = 0f;
                    string materialName = "";
                    string foundationSelection = "";
                    if (rBBrick.Checked) { materialPrice = float.Parse(tbBrick.Text);materialName = "Brick"; }
                    else if (rBConcrete.Checked) { materialPrice = float.Parse(tbConcrete.Text);materialName = "Concrete"; }
                    else if (rBGravel.Checked) {materialPrice = float.Parse(tbGravel.Text); materialName = "Gravel"; }
                    else { materialPrice = float.Parse(tbTarmac.Text); materialName = "Tarmac"; }

                    float lengthPrice = float.Parse(tbLength.Text);
                    float widthPrice=float.Parse(tbWidth.Text);

                    float totalPrice = materialPrice * lengthPrice * widthPrice;
                    if (rbExtraDeep.Checked)
                    {
                        totalPrice += 0.25f;
                        foundationSelection = "Extra Deep foundation";
                    }
                    else { foundationSelection = "Standard foundation"; }

                    lblOutput.BorderStyle = BorderStyle.FixedSingle;
                    lblOutput.BackColor = Color.White;
                    lblOutput.Font =new Font("Times New Roman",12,FontStyle.Bold);
                    lblOutput.ForeColor=Color.Black;
                    lblOutput.Text = $"{materialName} selected with {foundationSelection}";

                    float europrice = totalPrice * float.Parse(tbExchangeRate.Text);
                    tbGBP.Text = "£"+totalPrice.ToString("F");
                    tbEURO.Text = "€"+europrice.ToString("F");                   
                }
                else
                {
                    MessageBox.Show("Length,Width not entered.\nPlease enter dimensions", "Reminder", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    tbWidth.Focus();
                    tbWidth.SelectAll();
                }
            }
            else
            {
                MessageBox.Show("Length,Width not entered.\nPlease enter dimensions", "Reminder", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbLength.Focus();
                tbLength.SelectAll();
            }

        }

        private void lblresult_Click(object sender, EventArgs e)
        {

        }

        private void rbExtraDeep_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit this application?","Exit",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            { 
                Application.Exit();
            }
        }

        private void cmdClear_Click(object sender, EventArgs e)
        {
            tbLength.Text = String.Empty;
            tbWidth.Text = String.Empty;

            lblOutput.BorderStyle = BorderStyle.FixedSingle;
            lblOutput.BackColor = Color.Green;
            lblOutput.ForeColor = Color.Green;
            //lblresult.Text=String.Empty;

            tbGBP.Text = "1";
            tbEURO.Text = tbExchangeRate.Text;

        }
    }
}