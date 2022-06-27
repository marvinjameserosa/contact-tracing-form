namespace Contact_Tracing_Form
{
    partial class pageQRScanner
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnScan = new System.Windows.Forms.Button();
            this.cameraFeed = new System.Windows.Forms.PictureBox();
            this.cameraLabel = new System.Windows.Forms.Label();
            this.cameraChoice = new System.Windows.Forms.ComboBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.cameraFeed)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Location = new System.Drawing.Point(174, 455);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(188, 35);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "GO BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnScan
            // 
            this.btnScan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScan.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnScan.ForeColor = System.Drawing.Color.Black;
            this.btnScan.Location = new System.Drawing.Point(281, 11);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(90, 30);
            this.btnScan.TabIndex = 1;
            this.btnScan.Text = "SCAN";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // cameraFeed
            // 
            this.cameraFeed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cameraFeed.Location = new System.Drawing.Point(48, 49);
            this.cameraFeed.Name = "cameraFeed";
            this.cameraFeed.Size = new System.Drawing.Size(400, 400);
            this.cameraFeed.TabIndex = 2;
            this.cameraFeed.TabStop = false;
            // 
            // cameraLabel
            // 
            this.cameraLabel.AutoSize = true;
            this.cameraLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cameraLabel.Location = new System.Drawing.Point(44, 20);
            this.cameraLabel.Name = "cameraLabel";
            this.cameraLabel.Size = new System.Drawing.Size(68, 19);
            this.cameraLabel.TabIndex = 3;
            this.cameraLabel.Text = "Camera: ";
            // 
            // cameraChoice
            // 
            this.cameraChoice.FormattingEnabled = true;
            this.cameraChoice.Location = new System.Drawing.Point(118, 18);
            this.cameraChoice.Name = "cameraChoice";
            this.cameraChoice.Size = new System.Drawing.Size(121, 21);
            this.cameraChoice.TabIndex = 4;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timerFunc);
            // 
            // pageQRScanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.cameraChoice);
            this.Controls.Add(this.cameraLabel);
            this.Controls.Add(this.cameraFeed);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.btnBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "pageQRScanner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.closingQR);
            this.Load += new System.EventHandler(this.pageQRScanner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cameraFeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.PictureBox cameraFeed;
        private System.Windows.Forms.Label cameraLabel;
        private System.Windows.Forms.ComboBox cameraChoice;
        private System.Windows.Forms.Timer timer;
    }
}