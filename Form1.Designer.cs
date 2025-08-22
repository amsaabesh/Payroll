namespace PayrollApp
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label basicSalaryLabel;
        private System.Windows.Forms.Label totalWorkingDaysLabel;
        private System.Windows.Forms.Label attendedDaysLabel;
        private System.Windows.Forms.Label overtimeHoursLabel;
        private System.Windows.Forms.Label additionalPaymentLabel;
        private System.Windows.Forms.Label deductionLabel;
        private System.Windows.Forms.Label wfhHoursLabel;
        private System.Windows.Forms.Label lateDaysLabel;
        private System.Windows.Forms.Label absentDaysLabel;
        private System.Windows.Forms.Label transportDaysLabel;
        private System.Windows.Forms.Label weekendsLabel;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label salaryLabel;

        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox basicSalaryTextBox;
        private System.Windows.Forms.TextBox totalWorkingDaysTextBox;
        private System.Windows.Forms.TextBox attendedDaysTextBox;
        private System.Windows.Forms.TextBox overtimeHoursTextBox;
        private System.Windows.Forms.TextBox additionalPaymentTextBox;
        private System.Windows.Forms.TextBox deductionTextBox;
        private System.Windows.Forms.TextBox wfhHoursTextBox;
        private System.Windows.Forms.TextBox lateDaysTextBox;
        private System.Windows.Forms.TextBox absentDaysTextBox;
        private System.Windows.Forms.TextBox transportDaysTextBox;
        private System.Windows.Forms.TextBox weekendsTextBox;

        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button downloadButton;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.nameLabel = new System.Windows.Forms.Label();
            this.basicSalaryLabel = new System.Windows.Forms.Label();
            this.totalWorkingDaysLabel = new System.Windows.Forms.Label();
            this.attendedDaysLabel = new System.Windows.Forms.Label();
            this.overtimeHoursLabel = new System.Windows.Forms.Label();
            this.additionalPaymentLabel = new System.Windows.Forms.Label();
            this.deductionLabel = new System.Windows.Forms.Label();
            this.wfhHoursLabel = new System.Windows.Forms.Label();
            this.lateDaysLabel = new System.Windows.Forms.Label();
            this.absentDaysLabel = new System.Windows.Forms.Label();
            this.transportDaysLabel = new System.Windows.Forms.Label();
            this.weekendsLabel = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.salaryLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.basicSalaryTextBox = new System.Windows.Forms.TextBox();
            this.totalWorkingDaysTextBox = new System.Windows.Forms.TextBox();
            this.attendedDaysTextBox = new System.Windows.Forms.TextBox();
            this.overtimeHoursTextBox = new System.Windows.Forms.TextBox();
            this.additionalPaymentTextBox = new System.Windows.Forms.TextBox();
            this.deductionTextBox = new System.Windows.Forms.TextBox();
            this.wfhHoursTextBox = new System.Windows.Forms.TextBox();
            this.lateDaysTextBox = new System.Windows.Forms.TextBox();
            this.absentDaysTextBox = new System.Windows.Forms.TextBox();
            this.transportDaysTextBox = new System.Windows.Forms.TextBox();
            this.weekendsTextBox = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.downloadButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Addi_Desc = new System.Windows.Forms.TextBox();
            this.Ded_Desc = new System.Windows.Forms.MaskedTextBox();
            this.Late_Desc = new System.Windows.Forms.MaskedTextBox();
            this.Abs_Desc = new System.Windows.Forms.MaskedTextBox();
            this.Trans_Desc = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.Location = new System.Drawing.Point(20, 20);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(100, 23);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Employee\'s Name:";
            // 
            // basicSalaryLabel
            // 
            this.basicSalaryLabel.Location = new System.Drawing.Point(20, 60);
            this.basicSalaryLabel.Name = "basicSalaryLabel";
            this.basicSalaryLabel.Size = new System.Drawing.Size(100, 23);
            this.basicSalaryLabel.TabIndex = 1;
            this.basicSalaryLabel.Text = "Basic Salary:";
            // 
            // totalWorkingDaysLabel
            // 
            this.totalWorkingDaysLabel.Location = new System.Drawing.Point(20, 100);
            this.totalWorkingDaysLabel.Name = "totalWorkingDaysLabel";
            this.totalWorkingDaysLabel.Size = new System.Drawing.Size(100, 23);
            this.totalWorkingDaysLabel.TabIndex = 2;
            this.totalWorkingDaysLabel.Text = "Total Working Days:";
            // 
            // attendedDaysLabel
            // 
            this.attendedDaysLabel.Location = new System.Drawing.Point(20, 140);
            this.attendedDaysLabel.Name = "attendedDaysLabel";
            this.attendedDaysLabel.Size = new System.Drawing.Size(100, 23);
            this.attendedDaysLabel.TabIndex = 3;
            this.attendedDaysLabel.Text = "Attended Days:";
            // 
            // overtimeHoursLabel
            // 
            this.overtimeHoursLabel.Location = new System.Drawing.Point(20, 180);
            this.overtimeHoursLabel.Name = "overtimeHoursLabel";
            this.overtimeHoursLabel.Size = new System.Drawing.Size(100, 23);
            this.overtimeHoursLabel.TabIndex = 4;
            this.overtimeHoursLabel.Text = "Overtime Hours:";
            // 
            // additionalPaymentLabel
            // 
            this.additionalPaymentLabel.Location = new System.Drawing.Point(20, 220);
            this.additionalPaymentLabel.Name = "additionalPaymentLabel";
            this.additionalPaymentLabel.Size = new System.Drawing.Size(100, 23);
            this.additionalPaymentLabel.TabIndex = 5;
            this.additionalPaymentLabel.Text = "Additional Payment:";
            // 
            // deductionLabel
            // 
            this.deductionLabel.Location = new System.Drawing.Point(20, 260);
            this.deductionLabel.Name = "deductionLabel";
            this.deductionLabel.Size = new System.Drawing.Size(100, 23);
            this.deductionLabel.TabIndex = 6;
            this.deductionLabel.Text = "Deduction:";
            // 
            // wfhHoursLabel
            // 
            this.wfhHoursLabel.Location = new System.Drawing.Point(20, 300);
            this.wfhHoursLabel.Name = "wfhHoursLabel";
            this.wfhHoursLabel.Size = new System.Drawing.Size(100, 23);
            this.wfhHoursLabel.TabIndex = 7;
            this.wfhHoursLabel.Text = "WFH Hours:";
            // 
            // lateDaysLabel
            // 
            this.lateDaysLabel.Location = new System.Drawing.Point(20, 340);
            this.lateDaysLabel.Name = "lateDaysLabel";
            this.lateDaysLabel.Size = new System.Drawing.Size(100, 23);
            this.lateDaysLabel.TabIndex = 8;
            this.lateDaysLabel.Text = "Late Days:";
            // 
            // absentDaysLabel
            // 
            this.absentDaysLabel.Location = new System.Drawing.Point(20, 380);
            this.absentDaysLabel.Name = "absentDaysLabel";
            this.absentDaysLabel.Size = new System.Drawing.Size(100, 23);
            this.absentDaysLabel.TabIndex = 9;
            this.absentDaysLabel.Text = "Absent Days:";
            // 
            // transportDaysLabel
            // 
            this.transportDaysLabel.Location = new System.Drawing.Point(20, 420);
            this.transportDaysLabel.Name = "transportDaysLabel";
            this.transportDaysLabel.Size = new System.Drawing.Size(100, 23);
            this.transportDaysLabel.TabIndex = 10;
            this.transportDaysLabel.Text = "Transport Days:";
            // 
            // weekendsLabel
            // 
            this.weekendsLabel.Location = new System.Drawing.Point(20, 460);
            this.weekendsLabel.Name = "weekendsLabel";
            this.weekendsLabel.Size = new System.Drawing.Size(100, 23);
            this.weekendsLabel.TabIndex = 11;
            this.weekendsLabel.Text = "Weekends:";
            // 
            // errorLabel
            // 
            this.errorLabel.Location = new System.Drawing.Point(0, 0);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(100, 23);
            this.errorLabel.TabIndex = 0;
            // 
            // salaryLabel
            // 
            this.salaryLabel.Location = new System.Drawing.Point(0, 0);
            this.salaryLabel.Name = "salaryLabel";
            this.salaryLabel.Size = new System.Drawing.Size(100, 23);
            this.salaryLabel.TabIndex = 0;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(180, 20);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(200, 19);
            this.nameTextBox.TabIndex = 12;
            // 
            // basicSalaryTextBox
            // 
            this.basicSalaryTextBox.Location = new System.Drawing.Point(180, 60);
            this.basicSalaryTextBox.Name = "basicSalaryTextBox";
            this.basicSalaryTextBox.Size = new System.Drawing.Size(200, 19);
            this.basicSalaryTextBox.TabIndex = 13;
            // 
            // totalWorkingDaysTextBox
            // 
            this.totalWorkingDaysTextBox.Location = new System.Drawing.Point(180, 100);
            this.totalWorkingDaysTextBox.Name = "totalWorkingDaysTextBox";
            this.totalWorkingDaysTextBox.Size = new System.Drawing.Size(200, 19);
            this.totalWorkingDaysTextBox.TabIndex = 14;
            // 
            // attendedDaysTextBox
            // 
            this.attendedDaysTextBox.Location = new System.Drawing.Point(180, 140);
            this.attendedDaysTextBox.Name = "attendedDaysTextBox";
            this.attendedDaysTextBox.Size = new System.Drawing.Size(200, 19);
            this.attendedDaysTextBox.TabIndex = 15;
            // 
            // overtimeHoursTextBox
            // 
            this.overtimeHoursTextBox.Location = new System.Drawing.Point(180, 180);
            this.overtimeHoursTextBox.Name = "overtimeHoursTextBox";
            this.overtimeHoursTextBox.Size = new System.Drawing.Size(200, 19);
            this.overtimeHoursTextBox.TabIndex = 16;
            // 
            // additionalPaymentTextBox
            // 
            this.additionalPaymentTextBox.Location = new System.Drawing.Point(180, 220);
            this.additionalPaymentTextBox.Name = "additionalPaymentTextBox";
            this.additionalPaymentTextBox.Size = new System.Drawing.Size(200, 19);
            this.additionalPaymentTextBox.TabIndex = 17;
            // 
            // deductionTextBox
            // 
            this.deductionTextBox.Location = new System.Drawing.Point(180, 260);
            this.deductionTextBox.Name = "deductionTextBox";
            this.deductionTextBox.Size = new System.Drawing.Size(200, 19);
            this.deductionTextBox.TabIndex = 18;
            // 
            // wfhHoursTextBox
            // 
            this.wfhHoursTextBox.Location = new System.Drawing.Point(180, 300);
            this.wfhHoursTextBox.Name = "wfhHoursTextBox";
            this.wfhHoursTextBox.Size = new System.Drawing.Size(200, 19);
            this.wfhHoursTextBox.TabIndex = 19;
            // 
            // lateDaysTextBox
            // 
            this.lateDaysTextBox.Location = new System.Drawing.Point(180, 340);
            this.lateDaysTextBox.Name = "lateDaysTextBox";
            this.lateDaysTextBox.Size = new System.Drawing.Size(200, 19);
            this.lateDaysTextBox.TabIndex = 20;
            // 
            // absentDaysTextBox
            // 
            this.absentDaysTextBox.Location = new System.Drawing.Point(180, 380);
            this.absentDaysTextBox.Name = "absentDaysTextBox";
            this.absentDaysTextBox.Size = new System.Drawing.Size(200, 19);
            this.absentDaysTextBox.TabIndex = 21;
            // 
            // transportDaysTextBox
            // 
            this.transportDaysTextBox.Location = new System.Drawing.Point(180, 420);
            this.transportDaysTextBox.Name = "transportDaysTextBox";
            this.transportDaysTextBox.Size = new System.Drawing.Size(200, 19);
            this.transportDaysTextBox.TabIndex = 22;
            // 
            // weekendsTextBox
            // 
            this.weekendsTextBox.Location = new System.Drawing.Point(180, 460);
            this.weekendsTextBox.Name = "weekendsTextBox";
            this.weekendsTextBox.Size = new System.Drawing.Size(200, 19);
            this.weekendsTextBox.TabIndex = 23;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(130, 520);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(200, 30);
            this.submitButton.TabIndex = 24;
            this.submitButton.Text = "Calculate Salary";
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // downloadButton
            // 
            this.downloadButton.Location = new System.Drawing.Point(130, 560);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(200, 30);
            this.downloadButton.TabIndex = 25;
            this.downloadButton.Text = "Download Receipt";
            this.downloadButton.Click += new System.EventHandler(this.downloadButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(418, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Addi_Desc
            // 
            this.Addi_Desc.Location = new System.Drawing.Point(411, 224);
            this.Addi_Desc.Name = "Addi_Desc";
            this.Addi_Desc.Size = new System.Drawing.Size(100, 19);
            this.Addi_Desc.TabIndex = 27;
            // 
            // Ded_Desc
            // 
            this.Ded_Desc.Location = new System.Drawing.Point(411, 261);
            this.Ded_Desc.Name = "Ded_Desc";
            this.Ded_Desc.Size = new System.Drawing.Size(100, 19);
            this.Ded_Desc.TabIndex = 28;
            // 
            // Late_Desc
            // 
            this.Late_Desc.Location = new System.Drawing.Point(411, 337);
            this.Late_Desc.Name = "Late_Desc";
            this.Late_Desc.Size = new System.Drawing.Size(100, 19);
            this.Late_Desc.TabIndex = 29;
            // 
            // Abs_Desc
            // 
            this.Abs_Desc.Location = new System.Drawing.Point(411, 377);
            this.Abs_Desc.Name = "Abs_Desc";
            this.Abs_Desc.Size = new System.Drawing.Size(100, 19);
            this.Abs_Desc.TabIndex = 30;
            // 
            // Trans_Desc
            // 
            this.Trans_Desc.Location = new System.Drawing.Point(411, 420);
            this.Trans_Desc.Name = "Trans_Desc";
            this.Trans_Desc.Size = new System.Drawing.Size(100, 19);
            this.Trans_Desc.TabIndex = 31;
            this.Trans_Desc.Tag = "";
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(541, 600);
            this.Controls.Add(this.Trans_Desc);
            this.Controls.Add(this.Abs_Desc);
            this.Controls.Add(this.Late_Desc);
            this.Controls.Add(this.Ded_Desc);
            this.Controls.Add(this.Addi_Desc);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.basicSalaryLabel);
            this.Controls.Add(this.totalWorkingDaysLabel);
            this.Controls.Add(this.attendedDaysLabel);
            this.Controls.Add(this.overtimeHoursLabel);
            this.Controls.Add(this.additionalPaymentLabel);
            this.Controls.Add(this.deductionLabel);
            this.Controls.Add(this.wfhHoursLabel);
            this.Controls.Add(this.lateDaysLabel);
            this.Controls.Add(this.absentDaysLabel);
            this.Controls.Add(this.transportDaysLabel);
            this.Controls.Add(this.weekendsLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.basicSalaryTextBox);
            this.Controls.Add(this.totalWorkingDaysTextBox);
            this.Controls.Add(this.attendedDaysTextBox);
            this.Controls.Add(this.overtimeHoursTextBox);
            this.Controls.Add(this.additionalPaymentTextBox);
            this.Controls.Add(this.deductionTextBox);
            this.Controls.Add(this.wfhHoursTextBox);
            this.Controls.Add(this.lateDaysTextBox);
            this.Controls.Add(this.absentDaysTextBox);
            this.Controls.Add(this.transportDaysTextBox);
            this.Controls.Add(this.weekendsTextBox);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.downloadButton);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payroll Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox Addi_Desc;
        private System.Windows.Forms.MaskedTextBox Ded_Desc;
        private System.Windows.Forms.MaskedTextBox Late_Desc;
        private System.Windows.Forms.MaskedTextBox Abs_Desc;
        private System.Windows.Forms.MaskedTextBox Trans_Desc;
    }
}
