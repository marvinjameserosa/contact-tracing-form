namespace Contact_Tracing_Form
{
    public partial class index : Form
    {
        public index()
        {
            InitializeComponent();
        }

        // NAVIGATION PANEL
        
        private void contactInfoNav_Click(object sender, EventArgs e)
        {
            title.Text = "CONTACT INFORMATION";
            contactInfo.Visible = true;
            healthQuestionnaire.Visible = false;
            submitBTN.Visible = false;
        }

        private void healthQuestionnaireNav_Click(object sender, EventArgs e)
        {
            title.Text = "HEALTH QUESTIONNAIRE";
            contactInfo.Visible = false;
            healthQuestionnaire.Visible = true;
            submitBTN.Visible = true;
        }

        // SAVE FUNCTION

        private void submitBTN_Click(object sender, EventArgs e)
        {
            StreamWriter data = new StreamWriter(@"C:\Users\Public\Desktop\test\data.txt", true);


            // CONTACT INFO

            data.WriteLine("First Name: " + lnInput.Text);
            data.WriteLine("Last Name: " + fnInput.Text);
            data.WriteLine("Contact Number: " + cnInput.Text);
            data.WriteLine("Email Address: " + eaInput.Text);
            data.WriteLine("Zip Code: " + zcInput.Text);
            data.WriteLine("Barangay: " + brgyInput.Text);
            data.WriteLine("City: " + cityInput.Text);
            data.WriteLine("Region: " + regInput.Text);
            

            // HEALTH QUESTIONNAIRE

            data.WriteLine("Temperature: " + tempInput.Text);
            data.WriteLine("Time: " + timeInput.Text);
            data.WriteLine("Date: " + dateInput.Text);
            if (Q1Y.Checked)
            {
                data.WriteLine("Q1: YES");
            }
            else if (Q1N.Checked)
            {
                data.WriteLine("Q1: NO");
            }
            if (Q2Y.Checked)
            {
                data.WriteLine("Q2: YES");
            }
            else if (Q2N.Checked)
            {
                data.WriteLine("Q2: NO");
            }
            if (Q3Y.Checked)
            {
                data.WriteLine("Q3: YES");
            }
            else if (Q3N.Checked)
            {
                data.WriteLine("Q3: NO");
            }
            if (Q4Y.Checked)
            {
                data.WriteLine("Q4: YES");
            }
            else if (Q4N.Checked)
            {
                data.WriteLine("Q4: NO");
            }

            data.WriteLine();
            data.Close();
            MessageBox.Show("Thanks for submitting :)");
        }
    }
}