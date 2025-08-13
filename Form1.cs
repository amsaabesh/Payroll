using Payroll;
using System;
using System.IO;
using System.Windows.Forms;

namespace PayrollApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent(); // Initialize components (this links Designer.cs with the form)
        }

        // Button click event handler to calculate salary
        private void submitButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Read inputs from TextBox fields
                string name = nameTextBox.Text;
                decimal basicSalary = decimal.Parse(basicSalaryTextBox.Text);
                int totalWorkingDays = int.Parse(totalWorkingDaysTextBox.Text);
                int attendedDays = int.Parse(attendedDaysTextBox.Text);
                decimal overtimeHours = decimal.Parse(overtimeHoursTextBox.Text);
                decimal additionalPayment = decimal.Parse(additionalPaymentTextBox.Text);
                decimal deduction = decimal.Parse(deductionTextBox.Text);
                decimal wfhHours = decimal.Parse(wfhHoursTextBox.Text);
                int lateDays = int.Parse(lateDaysTextBox.Text);
                int absentDays = int.Parse(absentDaysTextBox.Text);
                int transportDays = int.Parse(transportDaysTextBox.Text);
                string weekends = weekendsTextBox.Text;

                // Validation checks
                if (basicSalary <= 0 || totalWorkingDays <= 0 || attendedDays < 0 || overtimeHours < 0 || deduction < 0 || wfhHours < 0 || lateDays < 0 || absentDays < 0 || transportDays < 0)
                {
                    errorLabel.Text = "Please enter valid positive numbers for all fields.";
                    return;
                }

                // Salary Calculation Logic
                decimal perDaySalary = basicSalary / totalWorkingDays;
                decimal mainSalary = attendedDays * perDaySalary;
                decimal perHourSalary = perDaySalary / 9;
                decimal overtimeSalary = overtimeHours * perHourSalary;
                decimal wfhSalary = wfhHours * perHourSalary * 0.7m;
                decimal transportAllowance = transportDays * 100;
                decimal finalSalary = mainSalary + overtimeSalary + additionalPayment + wfhSalary + transportAllowance - deduction;

                // Display results
                salaryLabel.Text = $"Total Salary: ৳ {finalSalary:F2}";
                errorLabel.Text = ""; // Clear error label if calculation is successful
                MessageBox.Show($"Total Salary: ৳ {finalSalary:F2}");
            }
            catch (FormatException)
            {
                errorLabel.Text = "Invalid input format. Please enter valid numbers.";
            }
        }

        // Event handler for download receipt button
        private void downloadButton_Click(object sender, EventArgs e)
        {
            // Set the file path to a valid location (e.g., user's Documents folder)
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "salary_receipt.txt");

            try
            {
                string directoryPath = Path.GetDirectoryName(filePath);
                if (!Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath); // Create the directory if it doesn't exist
                }

                // Calculate the necessary values again
                decimal perDaySalary = decimal.Parse(basicSalaryTextBox.Text) / int.Parse(totalWorkingDaysTextBox.Text);
                decimal perHourSalary = perDaySalary / 9;
                decimal overtimeSalary = perHourSalary * decimal.Parse(overtimeHoursTextBox.Text);
                decimal wfhSalary = decimal.Parse(wfhHoursTextBox.Text) * perHourSalary * 0.7m;

                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    // Write the data to the text file
                    writer.WriteLine("Payroll Receipt\n\n");
                    writer.WriteLine($"Employee Name: {nameTextBox.Text}");
                    writer.WriteLine($"\nBasic Salary: {basicSalaryTextBox.Text}");
                    writer.WriteLine($"\nWeekends: {weekendsTextBox.Text}");
                    writer.WriteLine($"\nTotal Working Days: {totalWorkingDaysTextBox.Text}");
                    writer.WriteLine($"\nAttended Days: {attendedDaysTextBox.Text}");
                    writer.WriteLine($"\nPer Day Salary: {perDaySalary:F2}");
                    writer.WriteLine($"\nMain Salary: {attendedDaysTextBox.Text} * {perDaySalary:F2} = {basicSalaryTextBox.Text}");
                    writer.WriteLine($"\nPer Hour Salary: {perHourSalary:F2}");
                    writer.WriteLine($"\nOvertime Hours: {overtimeHoursTextBox.Text}");
                    writer.WriteLine($"\nOvertime Salary: {overtimeSalary:F2}");
                    writer.WriteLine($"\nWFH Salary: {wfhSalary:F2}");
                    writer.WriteLine($"\nFinal Salary: {salaryLabel.Text}");
                    writer.WriteLine($"\nLate: {lateDaysTextBox.Text} days");
                    writer.WriteLine($"\nAbsent: {absentDaysTextBox.Text} days");
                    writer.WriteLine($"\nTransport: {transportDaysTextBox.Text} days");

                    // Show success message
                    MessageBox.Show("Receipt has been downloaded successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving the receipt: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();

            HomePage homePage = new HomePage(); // You can change MainForm to Form1 if it's named differently

            // Show MainForm
            homePage.Show();
        }
    }
}
