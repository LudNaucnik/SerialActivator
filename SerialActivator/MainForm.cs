using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SerialOperations;

namespace SerialActivator
{
    public partial class MainForm : Form
    {
        Operations SOperations = new Operations();
        public MainForm()
        {
            InitializeComponent();
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            SerialKeyTextBox.Text = SOperations.GenerateSerial();
        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            if(SOperations.VerifyCode(CheckerTextBox.Text)==true)
            {
                MessageBox.Show("Your Serial is Valid", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Your Serial is Invalid", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
