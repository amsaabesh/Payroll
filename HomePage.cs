using PayrollApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            // Create an instance of MainForm (or Form1)
            MainForm mainForm = new MainForm(); // You can change MainForm to Form1 if it's named differently

            // Show MainForm
            mainForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            // Create an instance of MainForm (or Form1)
            Form2 form2 = new Form2(); // You can change MainForm to Form1 if it's named differently

            // Show MainForm
            form2.Show();
        }

        
    }
}
