namespace Tracked
{
    partial class Launch_Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Cancel_Btn = new System.Windows.Forms.Button();
            this.Login_Btn = new System.Windows.Forms.Button();
            this.LaunchMsg_Lbl = new System.Windows.Forms.Label();
            this.NewUser_Btn = new System.Windows.Forms.Button();
            this.Username_Lbl = new System.Windows.Forms.Label();
            this.Password_Lbl = new System.Windows.Forms.Label();
            this.Username_Input = new System.Windows.Forms.TextBox();
            this.Password_Input = new System.Windows.Forms.TextBox();
            this.ConnectionStatus_Lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Cancel_Btn
            // 
            this.Cancel_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Cancel_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel_Btn.Location = new System.Drawing.Point(411, 208);
            this.Cancel_Btn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Cancel_Btn.Name = "Cancel_Btn";
            this.Cancel_Btn.Size = new System.Drawing.Size(86, 33);
            this.Cancel_Btn.TabIndex = 5;
            this.Cancel_Btn.Text = "Bye";
            this.Cancel_Btn.UseVisualStyleBackColor = true;
            this.Cancel_Btn.Click += new System.EventHandler(this.Close);
            // 
            // Login_Btn
            // 
            this.Login_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Login_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login_Btn.Location = new System.Drawing.Point(14, 208);
            this.Login_Btn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Login_Btn.Name = "Login_Btn";
            this.Login_Btn.Size = new System.Drawing.Size(86, 33);
            this.Login_Btn.TabIndex = 3;
            this.Login_Btn.Text = "Login";
            this.Login_Btn.UseVisualStyleBackColor = true;
            this.Login_Btn.Click += new System.EventHandler(this.Authenticate);
            // 
            // LaunchMsg_Lbl
            // 
            this.LaunchMsg_Lbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LaunchMsg_Lbl.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LaunchMsg_Lbl.Location = new System.Drawing.Point(14, 11);
            this.LaunchMsg_Lbl.Name = "LaunchMsg_Lbl";
            this.LaunchMsg_Lbl.Size = new System.Drawing.Size(483, 97);
            this.LaunchMsg_Lbl.TabIndex = 2;
            this.LaunchMsg_Lbl.Text = "Welcome to Tracked! \r\nThis software is still a WIP. \r\nPlease report any issues to" +
    " the Issues section on GitHub.\r\nFree simple budget management.\r\n...in a jank, ye" +
    "t modern style!\r\n";
            this.LaunchMsg_Lbl.Click += new System.EventHandler(this.LaunchMsg_Lbl_Click);
            // 
            // NewUser_Btn
            // 
            this.NewUser_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NewUser_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewUser_Btn.Location = new System.Drawing.Point(106, 208);
            this.NewUser_Btn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.NewUser_Btn.Name = "NewUser_Btn";
            this.NewUser_Btn.Size = new System.Drawing.Size(86, 33);
            this.NewUser_Btn.TabIndex = 4;
            this.NewUser_Btn.Text = "New";
            this.NewUser_Btn.UseVisualStyleBackColor = true;
            this.NewUser_Btn.Click += new System.EventHandler(this.NewUserAccount);
            // 
            // Username_Lbl
            // 
            this.Username_Lbl.AutoSize = true;
            this.Username_Lbl.Location = new System.Drawing.Point(14, 125);
            this.Username_Lbl.Name = "Username_Lbl";
            this.Username_Lbl.Size = new System.Drawing.Size(72, 17);
            this.Username_Lbl.TabIndex = 4;
            this.Username_Lbl.Text = "Username";
            // 
            // Password_Lbl
            // 
            this.Password_Lbl.AutoSize = true;
            this.Password_Lbl.Location = new System.Drawing.Point(319, 125);
            this.Password_Lbl.Name = "Password_Lbl";
            this.Password_Lbl.Size = new System.Drawing.Size(72, 17);
            this.Password_Lbl.TabIndex = 5;
            this.Password_Lbl.Text = "Password";
            // 
            // Username_Input
            // 
            this.Username_Input.Location = new System.Drawing.Point(14, 146);
            this.Username_Input.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Username_Input.Name = "Username_Input";
            this.Username_Input.PlaceholderText = "Cool Alias Here";
            this.Username_Input.Size = new System.Drawing.Size(178, 23);
            this.Username_Input.TabIndex = 0;
            // 
            // Password_Input
            // 
            this.Password_Input.Location = new System.Drawing.Point(319, 146);
            this.Password_Input.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Password_Input.Name = "Password_Input";
            this.Password_Input.PasswordChar = '#';
            this.Password_Input.PlaceholderText = "Top Sneaky";
            this.Password_Input.Size = new System.Drawing.Size(178, 23);
            this.Password_Input.TabIndex = 1;
            // 
            // ConnectionStatus_Lbl
            // 
            this.ConnectionStatus_Lbl.AutoSize = true;
            this.ConnectionStatus_Lbl.Location = new System.Drawing.Point(14, 174);
            this.ConnectionStatus_Lbl.Name = "ConnectionStatus_Lbl";
            this.ConnectionStatus_Lbl.Size = new System.Drawing.Size(256, 17);
            this.ConnectionStatus_Lbl.TabIndex = 6;
            this.ConnectionStatus_Lbl.Text = "Filing Cabinet Status: Unknown?";
            // 
            // Launch_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(511, 256);
            this.Controls.Add(this.ConnectionStatus_Lbl);
            this.Controls.Add(this.Password_Input);
            this.Controls.Add(this.Username_Input);
            this.Controls.Add(this.Password_Lbl);
            this.Controls.Add(this.Username_Lbl);
            this.Controls.Add(this.NewUser_Btn);
            this.Controls.Add(this.LaunchMsg_Lbl);
            this.Controls.Add(this.Login_Btn);
            this.Controls.Add(this.Cancel_Btn);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Launch_Form";
            this.Text = "Tracked";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Cancel_Btn;
        private Button Login_Btn;
        private Label LaunchMsg_Lbl;
        private Button NewUser_Btn;
        private Label Username_Lbl;
        private Label Password_Lbl;
        private TextBox Username_Input;
        private TextBox Password_Input;
        private Label ConnectionStatus_Lbl;
    }
}