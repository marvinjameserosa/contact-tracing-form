using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
namespace Contact_Tracing_Form
{
    public partial class index : Form
    {
        public index()
        {
            InitializeComponent();
        }

        // CAMERA CHOICE

        FilterInfoCollection filterInfo;
        VideoCaptureDevice captureDevice;
        private void index_Load(object sender, EventArgs e)
        {
            filterInfo = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filter in filterInfo)
            {
                cameraChoice.Items.Add(filter.Name);
            }
            cameraChoice.SelectedIndex = 0;
        }

        // NAVIGATION PANEL

        private void contactInfoNav_Click(object sender, EventArgs e)
        {
            mainTitle.Text = "Contact Tracing Form";
            mainTitle.Location = new Point(201, 18);
            title.Text = "CONTACT INFORMATION";
            contactInfo.Visible = true;
            healthQuestionnaire.Visible = false;
            qrScannerPannel.Visible = false;
            recordPanel.Visible = false;
            submitBTN.Visible = false;
        }

        private void healthQuestionnaireNav_Click(object sender, EventArgs e)
        {
            mainTitle.Text = "Contact Tracing Form";
            mainTitle.Location = new Point(201, 18);
            title.Text = "HEALTH QUESTIONNAIRE";
            contactInfo.Visible = false;
            healthQuestionnaire.Visible = true;
            qrScannerPannel.Visible = false;
            recordPanel.Visible = false;
            submitBTN.Visible = true;
        }

        private void qrNav_Click(object sender, EventArgs e)
        {
            mainTitle.Text = "Contact Tracing Form";
            mainTitle.Location = new Point(201, 18);
            title.Text = "QR CODE SCANNER";
            contactInfo.Visible = false;
            healthQuestionnaire.Visible = false;
            qrScannerPannel.Visible = true;
            recordPanel.Visible = false;
            submitBTN.Visible = false;
        }

        private void recordNav_Click(object sender, EventArgs e)
        {
            mainTitle.Text = "Copy of Records";
            mainTitle.Location = new Point(223, 18);
            title.Text = "RECORDS";
            contactInfo.Visible = false;
            healthQuestionnaire.Visible = false;
            qrScannerPannel.Visible = false;
            recordPanel.Visible = true;
            submitBTN.Visible = false;
            
        }

        // LOCATION

        string location = @"C:\Users\mjae0\OneDrive\Documents\University\Freshmen\secondSem\OOP\Assignment\Contact Tracing Form\Data\data.txt";

        // SAVE FUNCTION

        private void submitBTN_Click(object sender, EventArgs e)
        {
            datachecker();
        }

        private void write()
        {
            StreamWriter data = new StreamWriter(location, true);

            // ID
            data.Write(yearInput.Text);
            data.Write(monthInput.Text);
            data.WriteLine(dayInput.Text);

            // DATE INFO
            data.Write("Date: " + monthInput.Text + "/");
            data.Write(dayInput.Text + "/");
            data.WriteLine(yearInput.Text);
            data.WriteLine("Time: " + timeInput.Text);

            // CONTACT INFO

            data.WriteLine("Name: " + lnInput.Text + ", " + fnInput.Text);
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
            dayInput.Text = "";
            yearInput.Text = "";

            Q1Y.Checked = false;
            Q1N.Checked = false;
            Q2Y.Checked = false;
            Q2N.Checked = false;
            Q3Y.Checked = false;
            Q3N.Checked = false;
            Q4Y.Checked = false;
            Q4N.Checked = false;
        }
       
        // DATA FILLIED OUT CHECKER

        private void datachecker()
        {
            if (fnInput.Text.Length > 0 && lnInput.Text.Length > 0 && cnInput.Text.Length > 0 && eaInput.Text.Length > 0 && zcInput.Text.Length > 0
            && brgyInput.Text.Length > 0 && cityInput.Text.Length > 0 && regInput.Text.Length > 0 && tempInput.Text.Length > 0 && timeInput.Text.Length > 0
            && monthInput.Text.Length > 0)
            {
                datechecker();
            }
            else
            {
                MessageBox.Show("Please check if everything is filled out");
            }
        }

        // DATE CHECKER
        private void datechecker()
        {
            try
            {
                int monthVar = Int32.Parse(monthInput.Text);
                int dayVar = Int32.Parse(dayInput.Text);
                int yearVar = Int32.Parse(yearInput.Text);
                write();
                reset();
                
            }
            catch (Exception)
            {
                MessageBox.Show("Please Check the date");
            }
            
        }

        // Individual 
        class Person
        {
            public int idW { get; set; }
            public string dateW { get; set; }
            public string timeW { get; set; }
            public string nameW { get; set; }
            public string contactNoW { get; set; }
            public string emailW { get; set; }
            public string zipCodeW { get; set; }
            public string barangayW { get; set; }
            public string cityW { get; set; }
            public string regionW { get; set; }
            public string temperatureW { get; set; }
            public string Q1W { get; set; }
            public string Q2W { get; set; }
            public string Q3W { get; set; }
            public string Q4W { get; set; }

        }
        
        // LIST OF INDIVIDUAL

        List<Person> personList = new List<Person>();


        // SEARCH FUNCTION
        private void searchFunc()
        {
            StreamReader streamReader = File.OpenText(location);

            int tick = 0;
            while (!(streamReader.EndOfStream))
            {
                personList.Add(new Person
                {
                    idW = Int32.Parse(streamReader.ReadLine()),
                    dateW = streamReader.ReadLine(),
                    timeW = streamReader.ReadLine(),
                    nameW = streamReader.ReadLine(),
                    contactNoW = streamReader.ReadLine(),
                    emailW = streamReader.ReadLine(),
                    zipCodeW = streamReader.ReadLine(),
                    barangayW = streamReader.ReadLine(),
                    cityW = streamReader.ReadLine(),
                    regionW = streamReader.ReadLine(),
                    temperatureW = streamReader.ReadLine(),
                    Q1W = streamReader.ReadLine(),
                    Q2W = streamReader.ReadLine(),
                    Q3W = streamReader.ReadLine(),
                    Q4W = streamReader.ReadLine(),
                });
                tick = tick + 1;
            }

            string searchVal = yearSearch.Text + monthSearch.Text + daySearch.Text;
            for (int run = 0; run < tick; run++)
            {
                if (personList[run].idW.ToString() == searchVal)
                {
                    string newLine = Environment.NewLine;
                    recordDisplay.AppendText(personList[run].dateW.ToString());
                    recordDisplay.AppendText(newLine);
                    recordDisplay.AppendText(personList[run].timeW.ToString());
                    recordDisplay.AppendText(newLine);
                    recordDisplay.AppendText(personList[run].nameW.ToString());
                    recordDisplay.AppendText(newLine);
                    recordDisplay.AppendText(personList[run].contactNoW.ToString());
                    recordDisplay.AppendText(newLine);
                    recordDisplay.AppendText(personList[run].emailW.ToString());
                    recordDisplay.AppendText(newLine);
                    recordDisplay.AppendText(personList[run].zipCodeW.ToString());
                    recordDisplay.AppendText(newLine);
                    recordDisplay.AppendText(personList[run].barangayW.ToString());
                    recordDisplay.AppendText(newLine);
                    recordDisplay.AppendText(personList[run].cityW.ToString());
                    recordDisplay.AppendText(newLine);
                    recordDisplay.AppendText(personList[run].regionW.ToString());
                    recordDisplay.AppendText(newLine);
                    recordDisplay.AppendText(personList[run].temperatureW.ToString());
                    recordDisplay.AppendText(newLine);
                    recordDisplay.AppendText(personList[run].Q1W.ToString());
                    recordDisplay.AppendText(newLine);
                    recordDisplay.AppendText(personList[run].Q2W.ToString());
                    recordDisplay.AppendText(newLine);
                    recordDisplay.AppendText(personList[run].Q3W.ToString());
                    recordDisplay.AppendText(newLine);
                    recordDisplay.AppendText(personList[run].Q4W.ToString());
                    recordDisplay.AppendText(newLine);
                    recordDisplay.AppendText(newLine);
                }  
            }
            
            
        }

        // SEARCH BUTTON
        int turn = 0;
        private void search_Click(object sender, EventArgs e)
        {
            turn ++;
            if (turn == 1)
            {
                recordDisplay.Text = "";
                searchFunc();
            }
            if (turn == 2)
            {
                recordDisplay.Text = "";
                turn = 0;
                searchFunc();
                
            }
            
        }

        // SEQUENCER
        private void organizeList()
        {
            StreamReader streamReader = File.OpenText(location);

            while (!(streamReader.EndOfStream))
            {
                personList.Add(new Person
                {
                    idW = int.Parse(streamReader.ReadLine()),
                    dateW = streamReader.ReadLine(),
                    timeW = streamReader.ReadLine(),
                    nameW = streamReader.ReadLine(),
                    contactNoW = streamReader.ReadLine(),
                    emailW = streamReader.ReadLine(),
                    zipCodeW = streamReader.ReadLine(),
                    barangayW = streamReader.ReadLine(),
                    cityW = streamReader.ReadLine(),
                    regionW = streamReader.ReadLine(),
                    temperatureW = streamReader.ReadLine(),
                    Q1W = streamReader.ReadLine(),
                    Q2W = streamReader.ReadLine(),
                    Q3W = streamReader.ReadLine(),
                    Q4W = streamReader.ReadLine(),
                });
            }

            personList = personList.OrderBy(x => x.idW).ToList();
        }
        
        // LIST ALL FUNCTION

        private void listAll_Click(object sender, EventArgs e)
        {
            organizeList();
            recordDisplay.Text = "";        

            for (int play = 0; play < personList.Count; play++)
            {
                string newLine = Environment.NewLine;
                recordDisplay.AppendText(personList[play].dateW.ToString());
                recordDisplay.AppendText(newLine);
                recordDisplay.AppendText(personList[play].timeW.ToString());
                recordDisplay.AppendText(newLine);
                recordDisplay.AppendText(personList[play].nameW.ToString());
                recordDisplay.AppendText(newLine);
                recordDisplay.AppendText(personList[play].contactNoW.ToString());
                recordDisplay.AppendText(newLine);
                recordDisplay.AppendText(personList[play].emailW.ToString());
                recordDisplay.AppendText(newLine);
                recordDisplay.AppendText(personList[play].zipCodeW.ToString());
                recordDisplay.AppendText(newLine);
                recordDisplay.AppendText(personList[play].barangayW.ToString());
                recordDisplay.AppendText(newLine);
                recordDisplay.AppendText(personList[play].cityW.ToString());
                recordDisplay.AppendText(newLine);
                recordDisplay.AppendText(personList[play].regionW.ToString());
                recordDisplay.AppendText(newLine);
                recordDisplay.AppendText(personList[play].temperatureW.ToString());
                recordDisplay.AppendText(newLine);
                recordDisplay.AppendText(personList[play].Q1W.ToString());
                recordDisplay.AppendText(newLine);
                recordDisplay.AppendText(personList[play].Q2W.ToString());
                recordDisplay.AppendText(newLine);
                recordDisplay.AppendText(personList[play].Q3W.ToString());
                recordDisplay.AppendText(newLine);
                recordDisplay.AppendText(personList[play].Q4W.ToString());
                recordDisplay.AppendText(newLine);
                recordDisplay.AppendText(newLine);
            }
        }

      
    }
}