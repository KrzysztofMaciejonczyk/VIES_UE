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
    public partial class OrderBy : Form
    {
        private string value {  get; set; }
        public string Value { get{ return value; } }
        public OrderBy()
        {
            InitializeComponent();
            value = string.Empty;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (radioButtonAddress.Checked) { value = radioButtonAddress.Text; }
            else if (radioButtonName.Checked) { value = radioButtonName.Text; }
            else if (radioButtonDate.Checked) { value = radioButtonDate.Text; }
            else if (radioButtonVAT.Checked) { value = radioButtonVAT.Text; }
            else if (radioButtonValid.Checked) { value = radioButtonValid.Text; }
            this.Close();
        }
    }
}
