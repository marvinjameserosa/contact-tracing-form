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
            this.contactInfo = new System.Windows.Forms.Panel();
            this.region = new System.Windows.Forms.Label();
            this.regInput = new System.Windows.Forms.TextBox();
            this.city = new System.Windows.Forms.Label();
            this.cityInput = new System.Windows.Forms.TextBox();
            this.barangay = new System.Windows.Forms.Label();
            this.brgyInput = new System.Windows.Forms.TextBox();
            this.zipCode = new System.Windows.Forms.Label();
            this.zcInput = new System.Windows.Forms.TextBox();
            this.street = new System.Windows.Forms.Label();
            this.stInput = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.Label();
            this.lnInput = new System.Windows.Forms.TextBox();
            this.contactNo = new System.Windows.Forms.Label();
            this.cnInput = new System.Windows.Forms.TextBox();
            this.firstName = new System.Windows.Forms.Label();
            this.fnInput = new System.Windows.Forms.TextBox();
            this.submitBTN = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.header.SuspendLayout();
            this.navPanel.SuspendLayout();
            this.body.SuspendLayout();
            this.contactInfo.SuspendLayout();
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
            // 
            // navPanel
            // 
            this.navPanel.Controls.Add(this.healthQuestionnaireNav);
            this.navPanel.Controls.Add(this.contactInfoNav);
            this.navPanel.Location = new System.Drawing.Point(73, 563);
            this.navPanel.Name = "navPanel";
            this.navPanel.Size = new System.Drawing.Size(490, 60);
            this.navPanel.TabIndex = 0;
            // 
            // body
            // 
            this.body.BackColor = System.Drawing.Color.Transparent;
            this.body.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.body.Controls.Add(this.contactInfo);
            this.body.Controls.Add(this.submitBTN);
            this.body.Controls.Add(this.title);
            this.body.ForeColor = System.Drawing.Color.Black;
            this.body.Location = new System.Drawing.Point(73, 110);
            this.body.Name = "body";
            this.body.Size = new System.Drawing.Size(490, 422);
            this.body.TabIndex = 0;
            // 
            // contactInfo
            // 
            this.contactInfo.Controls.Add(this.region);
            this.contactInfo.Controls.Add(this.regInput);
            this.contactInfo.Controls.Add(this.city);
            this.contactInfo.Controls.Add(this.cityInput);
            this.contactInfo.Controls.Add(this.barangay);
            this.contactInfo.Controls.Add(this.brgyInput);
            this.contactInfo.Controls.Add(this.zipCode);
            this.contactInfo.Controls.Add(this.zcInput);
            this.contactInfo.Controls.Add(this.street);
            this.contactInfo.Controls.Add(this.stInput);
            this.contactInfo.Controls.Add(this.lastName);
            this.contactInfo.Controls.Add(this.lnInput);
            this.contactInfo.Controls.Add(this.contactNo);
            this.contactInfo.Controls.Add(this.cnInput);
            this.contactInfo.Controls.Add(this.firstName);
            this.contactInfo.Controls.Add(this.fnInput);
            this.contactInfo.Location = new System.Drawing.Point(0, 50);
            this.contactInfo.Name = "contactInfo";
            this.contactInfo.Size = new System.Drawing.Size(489, 322);
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
            // zipCode
            // 
            this.zipCode.AutoSize = true;
            this.zipCode.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.zipCode.Location = new System.Drawing.Point(259, 100);
            this.zipCode.Name = "zipCode";
            this.zipCode.Size = new System.Drawing.Size(62, 18);
            this.zipCode.TabIndex = 30;
            this.zipCode.Text = "Zip Code";
            // 
            // zcInput
            // 
            this.zcInput.Location = new System.Drawing.Point(259, 130);
            this.zcInput.Name = "zcInput";
            this.zcInput.Size = new System.Drawing.Size(200, 23);
            this.zcInput.TabIndex = 4;
            // 
            // street
            // 
            this.street.AutoSize = true;
            this.street.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.street.Location = new System.Drawing.Point(30, 175);
            this.street.Name = "street";
            this.street.Size = new System.Drawing.Size(46, 18);
            this.street.TabIndex = 28;
            this.street.Text = "Street";
            // 
            // stInput
            // 
            this.stInput.Location = new System.Drawing.Point(30, 205);
            this.stInput.Name = "stInput";
            this.stInput.Size = new System.Drawing.Size(200, 23);
            this.stInput.TabIndex = 5;
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
            // submitBTN
            // 
            this.submitBTN.BackColor = System.Drawing.Color.White;
            this.submitBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitBTN.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.submitBTN.Location = new System.Drawing.Point(348, 373);
            this.submitBTN.Name = "submitBTN";
            this.submitBTN.Size = new System.Drawing.Size(110, 28);
            this.submitBTN.TabIndex = 100;
            this.submitBTN.Text = "SUBMIT";
            this.submitBTN.UseVisualStyleBackColor = false;
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
            // index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(634, 656);
            this.Controls.Add(this.body);
            this.Controls.Add(this.navPanel);
            this.Controls.Add(this.header);
            this.Name = "index";
            this.Text = "Contact Tracing Form";
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.navPanel.ResumeLayout(false);
            this.body.ResumeLayout(false);
            this.body.PerformLayout();
            this.contactInfo.ResumeLayout(false);
            this.contactInfo.PerformLayout();
            this.ResumeLayout(false);

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
        private Label zipCode;
        private TextBox zcInput;
        private Label street;
        private TextBox stInput;
        private Label lastName;
        private TextBox lnInput;
        private Label contactNo;
        private TextBox cnInput;
        private Label firstName;
        private TextBox fnInput;
    }
}