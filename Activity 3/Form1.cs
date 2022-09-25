using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_3
{
    public partial class activity3GUI : Form
    {
        public activity3GUI()
        {
            InitializeComponent();
        }

        private void yesButton_Click(object sender, EventArgs e) // Event handler for "yes" button
        {
            // Create message that displays when user clicks "yes". 
            MessageBox.Show("Great! I like your taste!");
        }

        private void noButton_Click(object sender, EventArgs e) // Event handler for "no" button. 
        {
            // Create message that displays when user clicks "no". 
            MessageBox.Show("That's okay!");
        }
    }
}
