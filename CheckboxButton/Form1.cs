using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckboxButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //This is our click handler for the button1 click event
        private void button1_Click(object sender, EventArgs e)
        {
            //Get reference to checkbox
            CheckBox cb = checkBox1;

            //Branch on the state of the checkbox
            if (cb.Checked) {
                //Show the dialog
                MessageBox.Show("You clicked it!");
            }
        }
    }
}
