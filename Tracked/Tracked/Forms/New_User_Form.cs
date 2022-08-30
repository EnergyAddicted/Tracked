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

            #region Checking for valid inputs before requesting a new account creation.
            // Check for missing information...
            if (
                String.IsNullOrEmpty(usernameInput.Text) || 
                String.IsNullOrEmpty(passwordInput.Text) ||
                String.IsNullOrEmpty(passwordConfirmation.Text) ||
                String.IsNullOrEmpty(firstNameInput.Text) ||
                String.IsNullOrEmpty(lastNameInput.Text) ||
                String.IsNullOrEmpty(emailInput.Text) 
                )
            {
                MessageBox.Show("Please fill out all the fields in the form to submit.", "So close...");
                return;
            }

            // Check to make sure the password matches...

            if (passwordInput.Text != passwordConfirmation.Text)
            {
                MessageBox.Show("Passwords don't match.", "So close...");
                return;
            }
            #endregion

        }
    }
}
