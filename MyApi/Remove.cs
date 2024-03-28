using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyApi
{
    public partial class Remove : Form
    {
        private int value { get; set; }
        public int Value { get { return value; } }
        public Remove()
        {
            InitializeComponent();
            value = 0;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (textBoxID.Text == "")
            {
                MessageBox.Show("Invalid input. The textbox is empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!int.TryParse(textBoxID.Text, out int n))
            {
                MessageBox.Show($"Invalid input. The {textBoxID.Text} is not a number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                value = int.Parse(textBoxID.Text);
                this.Close();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
