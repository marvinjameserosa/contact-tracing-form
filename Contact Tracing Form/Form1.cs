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
            mainTitle.Text = "Contact Tracing Form";
            mainTitle.Left = this.Width / 2 - 123;
            title.Text = "CONTACT INFORMATION";
            contactInfo.Visible = true;
            healthQuestionnaire.Visible = false;
            submitBTN.Visible = false;
        }

        private void healthQuestionnaireNav_Click(object sender, EventArgs e)
        {
            mainTitle.Text = "Contact Tracing Form";
            mainTitle.Left = this.Width / 2 - 123;
            title.Text = "HEALTH QUESTIONNAIRE";
            contactInfo.Visible = false;
            healthQuestionnaire.Visible = true;
            submitBTN.Visible = true;
        }

        private void recordNav_Click(object sender, EventArgs e)
        {
            mainTitle.Text = "Copy of Records";
            mainTitle.Left = this.Width / 2 - 95;
            title.Text = "RECORDS";
            contactInfo.Visible = false;
            healthQuestionnaire.Visible = false;
            submitBTN.Visible = false;
        }
        // SAVE FUNCTION

        private void submitBTN_Click(object sender, EventArgs e)
        {
            checker();
        }

        private void write()
        {
            StreamWriter data = new StreamWriter(@"C:\Users\Public\Desktop\test\data.txt", true);

            // DATE INFO
            data.Write("Date: " + monthInput.Text + "/");
            data.Write(dayInput.Text + "/");
            data.WriteLine(yearInput.Text);
            data.WriteLine("Time: " + timeInput.Text);

            // CONTACT INFO

            data.WriteLine("First Name: " + fnInput.Text);
            data.WriteLine("Last Name: " + lnInput.Text);
            data.WriteLine("Contact Number: " + cnInput.Text);
            data.WriteLine("Email Address: " + eaInput.Text);
            data.WriteLine("Zip Code: " + zcInput.Text);
            data.WriteLine("Barangay: " + brgyInput.Text);
            data.WriteLine("City: " + cityInput.Text);
            data.WriteLine("Region: " + regInput.Text);


            // HEALTH QUESTIONNAIRE

            data.WriteLine("Temperature: " + tempInput.Text);

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

        // RESET FUNCTION
        private void reset()
        {
            contactInfoNav.PerformClick();
            fnInput.Text = "";
            lnInput.Text = "";
            cnInput.Text = "";
            eaInput.Text = "";
            zcInput.Text = "";
            brgyInput.Text = "";
            cityInput.Text = "";
            regInput.Text = "";
            tempInput.Text = "";
            timeInput.Text = "";
            monthInput.Text = "";

            Q1Y.Checked = false;
            Q1N.Checked = false;
            Q2Y.Checked = false;
            Q2N.Checked = false;
            Q3Y.Checked = false;
            Q3N.Checked = false;
            Q4Y.Checked = false;
            Q4N.Checked = false;
        }
       
        // DATE VARIABLE
        private void checker()
        {
            try
            {
                int monthVar = Int32.Parse(monthInput.Text);
                int dayVar = Int32.Parse(dayInput.Text); ;
                int yearVar = Int32.Parse(yearInput.Text);
                write();
                reset();
                
            }
            catch (Exception)
            {
                MessageBox.Show("Please Check the date");
            }
            
        }
        

    }
}