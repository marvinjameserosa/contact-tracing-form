namespace Contact_Tracing_Form
{
    partial class index
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainTitle = new System.Windows.Forms.Label();
            this.header = new System.Windows.Forms.Panel();
            this.contactInfoNav = new System.Windows.Forms.Button();
            this.healthQuestionnaireNav = new System.Windows.Forms.Button();
            this.navPanel = new System.Windows.Forms.Panel();
            this.body = new System.Windows.Forms.Panel();
            this.submitBTN = new System.Windows.Forms.Button();
            this.contactInfo = new System.Windows.Forms.Panel();
            this.region = new System.Windows.Forms.Label();
            this.regInput = new System.Windows.Forms.TextBox();
            this.city = new System.Windows.Forms.Label();
            this.cityInput = new System.Windows.Forms.TextBox();
            this.barangay = new System.Windows.Forms.Label();
            this.brgyInput = new System.Windows.Forms.TextBox();
            this.emailAdd = new System.Windows.Forms.Label();
            this.eaInput = new System.Windows.Forms.TextBox();
            this.zipCode = new System.Windows.Forms.Label();
            this.zcInput = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.Label();
            this.lnInput = new System.Windows.Forms.TextBox();
            this.contactNo = new System.Windows.Forms.Label();
            this.cnInput = new System.Windows.Forms.TextBox();
            this.firstName = new System.Windows.Forms.Label();
            this.fnInput = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.Label();
            this.healthQuestionnaire = new System.Windows.Forms.Panel();
            this.Q4panel = new System.Windows.Forms.Panel();
            this.Q4Y = new System.Windows.Forms.RadioButton();
            this.Q4N = new System.Windows.Forms.RadioButton();
            this.Q3panel = new System.Windows.Forms.Panel();
            this.Q3Y = new System.Windows.Forms.RadioButton();
            this.Q3N = new System.Windows.Forms.RadioButton();
            this.Q2panel = new System.Windows.Forms.Panel();
            this.Q2Y = new System.Windows.Forms.RadioButton();
            this.Q2N = new System.Windows.Forms.RadioButton();
            this.Q1panel = new System.Windows.Forms.Panel();
            this.Q1Y = new System.Windows.Forms.RadioButton();
            this.Q1N = new System.Windows.Forms.RadioButton();
            this.Q4 = new System.Windows.Forms.Label();
            this.Q3 = new System.Windows.Forms.Label();
            this.Q2 = new System.Windows.Forms.Label();
            this.Q1 = new System.Windows.Forms.Label();
            this.temp = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.header.SuspendLayout();
            this.navPanel.SuspendLayout();
            this.body.SuspendLayout();
            this.contactInfo.SuspendLayout();
            this.healthQuestionnaire.SuspendLayout();
            this.Q4panel.SuspendLayout();
            this.Q3panel.SuspendLayout();
            this.Q2panel.SuspendLayout();
            this.Q1panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTitle
            // 
            this.mainTitle.AutoSize = true;
            this.mainTitle.BackColor = System.Drawing.Color.Transparent;
            this.mainTitle.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mainTitle.ForeColor = System.Drawing.Color.White;
            this.mainTitle.Location = new System.Drawing.Point(201, 18);
            this.mainTitle.Name = "mainTitle";
            this.mainTitle.Size = new System.Drawing.Size(244, 33);
            this.mainTitle.TabIndex = 0;
            this.mainTitle.Text = "Contact Tracing Form";
            // 
            // header
            // 
            this.header.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.header.AutoSize = true;
            this.header.BackColor = System.Drawing.Color.Black;
            this.header.Controls.Add(this.mainTitle);
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(635, 75);
            this.header.TabIndex = 0;
            // 
            // contactInfoNav
            // 
            this.contactInfoNav.BackColor = System.Drawing.Color.White;
            this.contactInfoNav.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.contactInfoNav.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.contactInfoNav.Location = new System.Drawing.Point(42, 14);
            this.contactInfoNav.Name = "contactInfoNav";
            this.contactInfoNav.Size = new System.Drawing.Size(195, 35);
            this.contactInfoNav.TabIndex = 9;
            this.contactInfoNav.Text = "CONTACT INFORMATION";
            this.contactInfoNav.UseVisualStyleBackColor = false;
            this.contactInfoNav.Click += new System.EventHandler(this.contactInfoNav_Click);
            // 
            // healthQuestionnaireNav
            // 
            this.healthQuestionnaireNav.BackColor = System.Drawing.Color.White;
            this.healthQuestionnaireNav.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.healthQuestionnaireNav.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.healthQuestionnaireNav.Location = new System.Drawing.Point(258, 14);
            this.healthQuestionnaireNav.Name = "healthQuestionnaireNav";
            this.healthQuestionnaireNav.Size = new System.Drawing.Size(195, 35);
            this.healthQuestionnaireNav.TabIndex = 10;
            this.healthQuestionnaireNav.Text = "HEALTH QUESTIONNAIRE";
            this.healthQuestionnaireNav.UseVisualStyleBackColor = false;
            this.healthQuestionnaireNav.Click += new System.EventHandler(this.healthQuestionnaireNav_Click);
            // 
            // navPanel
            // 
            this.navPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.navPanel.Controls.Add(this.healthQuestionnaireNav);
            this.navPanel.Controls.Add(this.contactInfoNav);
            this.navPanel.Location = new System.Drawing.Point(73, 563);
            this.navPanel.Name = "navPanel";
            this.navPanel.Size = new System.Drawing.Size(490, 60);
            this.navPanel.TabIndex = 0;
            // 
            // body
            // 
            this.body.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.body.BackColor = System.Drawing.Color.Transparent;
            this.body.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.body.Controls.Add(this.submitBTN);
            this.body.Controls.Add(this.contactInfo);
            this.body.Controls.Add(this.title);
            this.body.ForeColor = System.Drawing.Color.Black;
            this.body.Location = new System.Drawing.Point(73, 110);
            this.body.Name = "body";
            this.body.Size = new System.Drawing.Size(490, 422);
            this.body.TabIndex = 0;
            // 
            // submitBTN
            // 
            this.submitBTN.BackColor = System.Drawing.Color.White;
            this.submitBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitBTN.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.submitBTN.Location = new System.Drawing.Point(348, 373);
            this.submitBTN.Name = "submitBTN";
            this.submitBTN.Size = new System.Drawing.Size(110, 28);
            this.submitBTN.TabIndex = 20;
            this.submitBTN.Text = "SUBMIT";
            this.submitBTN.UseVisualStyleBackColor = false;
            this.submitBTN.Visible = false;
            this.submitBTN.Click += new System.EventHandler(this.submitBTN_Click);
            // 
            // contactInfo
            // 
            this.contactInfo.Controls.Add(this.region);
            this.contactInfo.Controls.Add(this.regInput);
            this.contactInfo.Controls.Add(this.city);
            this.contactInfo.Controls.Add(this.cityInput);
            this.contactInfo.Controls.Add(this.barangay);
            this.contactInfo.Controls.Add(this.brgyInput);
            this.contactInfo.Controls.Add(this.emailAdd);
            this.contactInfo.Controls.Add(this.eaInput);
            this.contactInfo.Controls.Add(this.zipCode);
            this.contactInfo.Controls.Add(this.zcInput);
            this.contactInfo.Controls.Add(this.lastName);
            this.contactInfo.Controls.Add(this.lnInput);
            this.contactInfo.Controls.Add(this.contactNo);
            this.contactInfo.Controls.Add(this.cnInput);
            this.contactInfo.Controls.Add(this.firstName);
            this.contactInfo.Controls.Add(this.fnInput);
            this.contactInfo.Location = new System.Drawing.Point(0, 50);
            this.contactInfo.Name = "contactInfo";
            this.contactInfo.Size = new System.Drawing.Size(489, 371);
            this.contactInfo.TabIndex = 0;
            // 
            // region
            // 
            this.region.AutoSize = true;
            this.region.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.region.Location = new System.Drawing.Point(259, 248);
            this.region.Name = "region";
            this.region.Size = new System.Drawing.Size(51, 18);
            this.region.TabIndex = 36;
            this.region.Text = "Region";
            // 
            // regInput
            // 
            this.regInput.Location = new System.Drawing.Point(259, 278);
            this.regInput.Name = "regInput";
            this.regInput.Size = new System.Drawing.Size(200, 23);
            this.regInput.TabIndex = 8;
            // 
            // city
            // 
            this.city.AutoSize = true;
            this.city.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.city.Location = new System.Drawing.Point(30, 248);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(32, 18);
            this.city.TabIndex = 34;
            this.city.Text = "City";
            // 
            // cityInput
            // 
            this.cityInput.Location = new System.Drawing.Point(30, 278);
            this.cityInput.Name = "cityInput";
            this.cityInput.Size = new System.Drawing.Size(200, 23);
            this.cityInput.TabIndex = 7;
            // 
            // barangay
            // 
            this.barangay.AutoSize = true;
            this.barangay.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.barangay.Location = new System.Drawing.Point(259, 175);
            this.barangay.Name = "barangay";
            this.barangay.Size = new System.Drawing.Size(64, 18);
            this.barangay.TabIndex = 32;
            this.barangay.Text = "Barangay";
            // 
            // brgyInput
            // 
            this.brgyInput.Location = new System.Drawing.Point(259, 205);
            this.brgyInput.Name = "brgyInput";
            this.brgyInput.Size = new System.Drawing.Size(200, 23);
            this.brgyInput.TabIndex = 6;
            // 
            // emailAdd
            // 
            this.emailAdd.AutoSize = true;
            this.emailAdd.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.emailAdd.Location = new System.Drawing.Point(259, 100);
            this.emailAdd.Name = "emailAdd";
            this.emailAdd.Size = new System.Drawing.Size(95, 18);
            this.emailAdd.TabIndex = 30;
            this.emailAdd.Text = "Email Address";
            // 
            // eaInput
            // 
            this.eaInput.Location = new System.Drawing.Point(259, 130);
            this.eaInput.Name = "eaInput";
            this.eaInput.Size = new System.Drawing.Size(200, 23);
            this.eaInput.TabIndex = 4;
            // 
            // zipCode
            // 
            this.zipCode.AutoSize = true;
            this.zipCode.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.zipCode.Location = new System.Drawing.Point(30, 175);
            this.zipCode.Name = "zipCode";
            this.zipCode.Size = new System.Drawing.Size(62, 18);
            this.zipCode.TabIndex = 28;
            this.zipCode.Text = "Zip Code";
            // 
            // zcInput
            // 
            this.zcInput.Location = new System.Drawing.Point(30, 205);
            this.zcInput.Name = "zcInput";
            this.zcInput.Size = new System.Drawing.Size(200, 23);
            this.zcInput.TabIndex = 5;
            // 
            // lastName
            // 
            this.lastName.AutoSize = true;
            this.lastName.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lastName.Location = new System.Drawing.Point(259, 22);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(72, 18);
            this.lastName.TabIndex = 26;
            this.lastName.Text = "Last Name";
            // 
            // lnInput
            // 
            this.lnInput.Location = new System.Drawing.Point(259, 55);
            this.lnInput.Name = "lnInput";
            this.lnInput.Size = new System.Drawing.Size(200, 23);
            this.lnInput.TabIndex = 2;
            // 
            // contactNo
            // 
            this.contactNo.AutoSize = true;
            this.contactNo.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.contactNo.Location = new System.Drawing.Point(30, 100);
            this.contactNo.Name = "contactNo";
            this.contactNo.Size = new System.Drawing.Size(109, 18);
            this.contactNo.TabIndex = 24;
            this.contactNo.Text = "Contact Number";
            // 
            // cnInput
            // 
            this.cnInput.Location = new System.Drawing.Point(30, 130);
            this.cnInput.Name = "cnInput";
            this.cnInput.Size = new System.Drawing.Size(200, 23);
            this.cnInput.TabIndex = 3;
            // 
            // firstName
            // 
            this.firstName.AutoSize = true;
            this.firstName.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.firstName.Location = new System.Drawing.Point(30, 25);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(75, 18);
            this.firstName.TabIndex = 22;
            this.firstName.Text = "First Name";
            // 
            // fnInput
            // 
            this.fnInput.Location = new System.Drawing.Point(30, 55);
            this.fnInput.Name = "fnInput";
            this.fnInput.Size = new System.Drawing.Size(200, 23);
            this.fnInput.TabIndex = 1;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.title.ForeColor = System.Drawing.Color.Black;
            this.title.Location = new System.Drawing.Point(30, 23);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(212, 24);
            this.title.TabIndex = 0;
            this.title.Text = "CONTACT INFORMATION";
            // 
            // healthQuestionnaire
            // 
            this.healthQuestionnaire.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.healthQuestionnaire.Controls.Add(this.Q4panel);
            this.healthQuestionnaire.Controls.Add(this.Q3panel);
            this.healthQuestionnaire.Controls.Add(this.Q2panel);
            this.healthQuestionnaire.Controls.Add(this.Q1panel);
            this.healthQuestionnaire.Controls.Add(this.Q4);
            this.healthQuestionnaire.Controls.Add(this.Q3);
            this.healthQuestionnaire.Controls.Add(this.Q2);
            this.healthQuestionnaire.Controls.Add(this.Q1);
            this.healthQuestionnaire.Controls.Add(this.temp);
            this.healthQuestionnaire.Controls.Add(this.textBox1);
            this.healthQuestionnaire.Location = new System.Drawing.Point(74, 155);
            this.healthQuestionnaire.Name = "healthQuestionnaire";
            this.healthQuestionnaire.Size = new System.Drawing.Size(486, 323);
            this.healthQuestionnaire.TabIndex = 37;
            this.healthQuestionnaire.Visible = false;
            // 
            // Q4panel
            // 
            this.Q4panel.Controls.Add(this.Q4Y);
            this.Q4panel.Controls.Add(this.Q4N);
            this.Q4panel.Location = new System.Drawing.Point(290, 272);
            this.Q4panel.Name = "Q4panel";
            this.Q4panel.Size = new System.Drawing.Size(169, 35);
            this.Q4panel.TabIndex = 0;
            // 
            // Q4Y
            // 
            this.Q4Y.AutoSize = true;
            this.Q4Y.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Q4Y.Location = new System.Drawing.Point(16, 9);
            this.Q4Y.Name = "Q4Y";
            this.Q4Y.Size = new System.Drawing.Size(43, 18);
            this.Q4Y.TabIndex = 18;
            this.Q4Y.TabStop = true;
            this.Q4Y.Text = "Yes";
            this.Q4Y.UseVisualStyleBackColor = true;
            // 
            // Q4N
            // 
            this.Q4N.AutoSize = true;
            this.Q4N.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Q4N.Location = new System.Drawing.Point(99, 9);
            this.Q4N.Name = "Q4N";
            this.Q4N.Size = new System.Drawing.Size(40, 18);
            this.Q4N.TabIndex = 19;
            this.Q4N.TabStop = true;
            this.Q4N.Text = "No";
            this.Q4N.UseVisualStyleBackColor = true;
            // 
            // Q3panel
            // 
            this.Q3panel.Controls.Add(this.Q3Y);
            this.Q3panel.Controls.Add(this.Q3N);
            this.Q3panel.Location = new System.Drawing.Point(290, 211);
            this.Q3panel.Name = "Q3panel";
            this.Q3panel.Size = new System.Drawing.Size(169, 35);
            this.Q3panel.TabIndex = 0;
            // 
            // Q3Y
            // 
            this.Q3Y.AutoSize = true;
            this.Q3Y.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Q3Y.Location = new System.Drawing.Point(16, 9);
            this.Q3Y.Name = "Q3Y";
            this.Q3Y.Size = new System.Drawing.Size(43, 18);
            this.Q3Y.TabIndex = 16;
            this.Q3Y.TabStop = true;
            this.Q3Y.Text = "Yes";
            this.Q3Y.UseVisualStyleBackColor = true;
            // 
            // Q3N
            // 
            this.Q3N.AutoSize = true;
            this.Q3N.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Q3N.Location = new System.Drawing.Point(99, 9);
            this.Q3N.Name = "Q3N";
            this.Q3N.Size = new System.Drawing.Size(40, 18);
            this.Q3N.TabIndex = 17;
            this.Q3N.TabStop = true;
            this.Q3N.Text = "No";
            this.Q3N.UseVisualStyleBackColor = true;
            // 
            // Q2panel
            // 
            this.Q2panel.Controls.Add(this.Q2Y);
            this.Q2panel.Controls.Add(this.Q2N);
            this.Q2panel.Location = new System.Drawing.Point(290, 127);
            this.Q2panel.Name = "Q2panel";
            this.Q2panel.Size = new System.Drawing.Size(169, 35);
            this.Q2panel.TabIndex = 0;
            // 
            // Q2Y
            // 
            this.Q2Y.AutoSize = true;
            this.Q2Y.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Q2Y.Location = new System.Drawing.Point(16, 9);
            this.Q2Y.Name = "Q2Y";
            this.Q2Y.Size = new System.Drawing.Size(43, 18);
            this.Q2Y.TabIndex = 14;
            this.Q2Y.TabStop = true;
            this.Q2Y.Text = "Yes";
            this.Q2Y.UseVisualStyleBackColor = true;
            // 
            // Q2N
            // 
            this.Q2N.AutoSize = true;
            this.Q2N.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Q2N.Location = new System.Drawing.Point(99, 9);
            this.Q2N.Name = "Q2N";
            this.Q2N.Size = new System.Drawing.Size(40, 18);
            this.Q2N.TabIndex = 15;
            this.Q2N.TabStop = true;
            this.Q2N.Text = "No";
            this.Q2N.UseVisualStyleBackColor = true;
            // 
            // Q1panel
            // 
            this.Q1panel.Controls.Add(this.Q1Y);
            this.Q1panel.Controls.Add(this.Q1N);
            this.Q1panel.Location = new System.Drawing.Point(290, 61);
            this.Q1panel.Name = "Q1panel";
            this.Q1panel.Size = new System.Drawing.Size(169, 35);
            this.Q1panel.TabIndex = 0;
            // 
            // Q1Y
            // 
            this.Q1Y.AutoSize = true;
            this.Q1Y.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Q1Y.Location = new System.Drawing.Point(16, 9);
            this.Q1Y.Name = "Q1Y";
            this.Q1Y.Size = new System.Drawing.Size(43, 18);
            this.Q1Y.TabIndex = 12;
            this.Q1Y.TabStop = true;
            this.Q1Y.Text = "Yes";
            this.Q1Y.UseVisualStyleBackColor = true;
            // 
            // Q1N
            // 
            this.Q1N.AutoSize = true;
            this.Q1N.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Q1N.Location = new System.Drawing.Point(99, 9);
            this.Q1N.Name = "Q1N";
            this.Q1N.Size = new System.Drawing.Size(40, 18);
            this.Q1N.TabIndex = 13;
            this.Q1N.TabStop = true;
            this.Q1N.Text = "No";
            this.Q1N.UseVisualStyleBackColor = true;
            // 
            // Q4
            // 
            this.Q4.AutoSize = true;
            this.Q4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Q4.Location = new System.Drawing.Point(30, 283);
            this.Q4.Name = "Q4";
            this.Q4.Size = new System.Drawing.Size(164, 18);
            this.Q4.TabIndex = 0;
            this.Q4.Text = "Are you fully Vaccinated?\r\n";
            // 
            // Q3
            // 
            this.Q3.AutoSize = true;
            this.Q3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Q3.Location = new System.Drawing.Point(30, 220);
            this.Q3.Name = "Q3";
            this.Q3.Size = new System.Drawing.Size(257, 36);
            this.Q3.TabIndex = 0;
            this.Q3.Text = "Do you have Covid - Like symptioms?\r\nI.e.: Fever, Cough, Difficulty of Breathing";
            // 
            // Q2
            // 
            this.Q2.AutoSize = true;
            this.Q2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Q2.Location = new System.Drawing.Point(31, 139);
            this.Q2.Name = "Q2";
            this.Q2.Size = new System.Drawing.Size(248, 54);
            this.Q2.TabIndex = 0;
            this.Q2.Text = "Have you been exposed to a Covid - 19 \r\npositve person or have tested positive \r\n" +
    "for the past month?\r\n";
            // 
            // Q1
            // 
            this.Q1.AutoSize = true;
            this.Q1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Q1.Location = new System.Drawing.Point(30, 73);
            this.Q1.Name = "Q1";
            this.Q1.Size = new System.Drawing.Size(242, 36);
            this.Q1.TabIndex = 0;
            this.Q1.Text = "Have you travelled ouside the city for \r\nthe past week?";
            // 
            // temp
            // 
            this.temp.AutoSize = true;
            this.temp.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.temp.Location = new System.Drawing.Point(30, 25);
            this.temp.Name = "temp";
            this.temp.Size = new System.Drawing.Size(88, 18);
            this.temp.TabIndex = 0;
            this.temp.Text = "Temperature";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Location = new System.Drawing.Point(122, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(49, 23);
            this.textBox1.TabIndex = 11;
            // 
            // index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(634, 656);
            this.Controls.Add(this.healthQuestionnaire);
            this.Controls.Add(this.body);
            this.Controls.Add(this.navPanel);
            this.Controls.Add(this.header);
            this.Name = "index";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contact Tracing Form";
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.navPanel.ResumeLayout(false);
            this.body.ResumeLayout(false);
            this.body.PerformLayout();
            this.contactInfo.ResumeLayout(false);
            this.contactInfo.PerformLayout();
            this.healthQuestionnaire.ResumeLayout(false);
            this.healthQuestionnaire.PerformLayout();
            this.Q4panel.ResumeLayout(false);
            this.Q4panel.PerformLayout();
            this.Q3panel.ResumeLayout(false);
            this.Q3panel.PerformLayout();
            this.Q2panel.ResumeLayout(false);
            this.Q2panel.PerformLayout();
            this.Q1panel.ResumeLayout(false);
            this.Q1panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label mainTitle;
        private Panel header;
        private Button contactInfoNav;
        private Button healthQuestionnaireNav;
        private Panel navPanel;
        private Panel body;
        private Button submitBTN;
        private Label title;
        private Panel contactInfo;
        private Label region;
        private TextBox regInput;
        private Label city;
        private TextBox cityInput;
        private Label barangay;
        private TextBox brgyInput;
        private Label emailAdd;
        private TextBox eaInput;
        private Label zipCode;
        private TextBox zcInput;
        private Label lastName;
        private TextBox lnInput;
        private Label contactNo;
        private TextBox cnInput;
        private Label firstName;
        private TextBox fnInput;
        private Panel healthQuestionnaire;
        private RadioButton Q1Y;
        private Label Q1;
        private Label temp;
        private TextBox textBox1;
        private Label Q3;
        private Label Q2;
        private RadioButton Q1N;
        private Label Q4;
        private Panel Q1panel;
        private Panel Q4panel;
        private RadioButton Q4Y;
        private RadioButton Q4N;
        private Panel Q3panel;
        private RadioButton Q3Y;
        private RadioButton Q3N;
        private Panel Q2panel;
        private RadioButton Q2Y;
        private RadioButton Q2N;
    }
}