namespace Tracked
{
    public partial class Launch_Form : Form
    {
        public Launch_Form()
        {
            InitializeComponent();
            this.Text = "Tracked " + Application.ProductVersion;
        }

        private void Close(object sender, EventArgs e)
        {
            // Kill the application, and anything else that happens to be running along with it.
            // This is the final "exit" button. 
            Application.Exit();
        }

        private void NewUserAccount(object sender, EventArgs e)
        {
            // Open the form for creating a new user account in the program.
        }

        private void Authenticate(object sender, EventArgs e)
        {
            // Called when the user hits Login. Take the given credentials, convert to hash values, and verify the combination is valid.
            // If either field is empty; reject the attempt. 
            // If the authentication fails; inform the user - Track login attempts and timing. If more than five attempts in 10s, delay 
            // the next login attempt by 30s. This is to limit the usage of brute forcing and/or db traffic. 
            // If valid, hide the form, wipe the fields, and land on their dashboard. 
        }
    }
}