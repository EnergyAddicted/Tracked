using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tracked.Forms
{
    public partial class New_User_Form : Form
    {
        public New_User_Form()
        {
            InitializeComponent();
        }

        private void Close(object sender, EventArgs e)
        {
            // Canceled. Kill the form. Return to the login form.
            this.Close();
        }

        private void SubmitNewAccount(object sender, EventArgs e)
        {
            // Called when the form is completed and submitted. Check to make sure all the fields are containing values, including 
            // a matching password. If all conditions are good, then submit a check for a valid new user. 
            // If an existing username/email is found, then cancel the user and inform. 
        }
    }
}
