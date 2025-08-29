namespace PasswordGeneratorv2
{
    partial class Form1
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
            label1 = new Label();
            userName = new TextBox();
            userSurname = new TextBox();
            label2 = new Label();
            label3 = new Label();
            generatePassword = new Button();
            passwordOutput = new TextBox();
            generatePasswordLabel = new Label();
            copyToClipboard = new Button();
            numberOfCharacters = new ComboBox();
            numberOfCharactersLabel = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(200, 57);
            label1.Name = "label1";
            label1.Size = new Size(368, 40);
            label1.TabIndex = 0;
            label1.Text = "Password Generator v2";
            // 
            // userName
            // 
            userName.Location = new Point(172, 144);
            userName.Name = "userName";
            userName.Size = new Size(217, 27);
            userName.TabIndex = 1;
            // 
            // userSurname
            // 
            userSurname.Location = new Point(172, 200);
            userSurname.Name = "userSurname";
            userSurname.Size = new Size(217, 27);
            userSurname.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 148);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 3;
            label2.Text = "Name: ";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 200);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 4;
            label3.Text = "Surname";
            // 
            // generatePassword
            // 
            generatePassword.BackColor = Color.DarkCyan;
            generatePassword.FlatStyle = FlatStyle.Flat;
            generatePassword.Font = new Font("Microsoft YaHei", 10F);
            generatePassword.ForeColor = SystemColors.ButtonFace;
            generatePassword.Location = new Point(599, 148);
            generatePassword.Name = "generatePassword";
            generatePassword.Size = new Size(189, 59);
            generatePassword.TabIndex = 5;
            generatePassword.Text = "Generate";
            generatePassword.UseVisualStyleBackColor = false;
            generatePassword.Click += generatePassword_Click;
            // 
            // passwordOutput
            // 
            passwordOutput.Location = new Point(175, 336);
            passwordOutput.Name = "passwordOutput";
            passwordOutput.ReadOnly = true;
            passwordOutput.Size = new Size(393, 27);
            passwordOutput.TabIndex = 6;
            passwordOutput.Visible = false;
            // 
            // generatePasswordLabel
            // 
            generatePasswordLabel.AutoSize = true;
            generatePasswordLabel.Location = new Point(301, 298);
            generatePasswordLabel.Name = "generatePasswordLabel";
            generatePasswordLabel.Size = new Size(143, 20);
            generatePasswordLabel.TabIndex = 7;
            generatePasswordLabel.Text = "Generated Password";
            generatePasswordLabel.Visible = false;
            // 
            // copyToClipboard
            // 
            copyToClipboard.BackColor = Color.SeaGreen;
            copyToClipboard.FlatStyle = FlatStyle.Flat;
            copyToClipboard.ForeColor = SystemColors.Control;
            copyToClipboard.Location = new Point(263, 383);
            copyToClipboard.Name = "copyToClipboard";
            copyToClipboard.Size = new Size(221, 55);
            copyToClipboard.TabIndex = 8;
            copyToClipboard.Text = "Copy to Clipboard";
            copyToClipboard.UseVisualStyleBackColor = false;
            copyToClipboard.Visible = false;
            copyToClipboard.Click += copyToClipboard_Click;
            // 
            // numberOfCharacters
            // 
            numberOfCharacters.FormattingEnabled = true;
            numberOfCharacters.Items.AddRange(new object[] { "10 Characters", "12 Characters", "14 Characters", "16 Characters" });
            numberOfCharacters.Location = new Point(172, 245);
            numberOfCharacters.Name = "numberOfCharacters";
            numberOfCharacters.Size = new Size(214, 28);
            numberOfCharacters.TabIndex = 9;
            numberOfCharacters.SelectedIndexChanged += numberOfCharacters_SelectedIndexChanged;
            // 
            // numberOfCharactersLabel
            // 
            numberOfCharactersLabel.AutoSize = true;
            numberOfCharactersLabel.Location = new Point(12, 248);
            numberOfCharactersLabel.Name = "numberOfCharactersLabel";
            numberOfCharactersLabel.Size = new Size(157, 20);
            numberOfCharactersLabel.TabIndex = 10;
            numberOfCharactersLabel.Text = "Number of Characters:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(800, 450);
            Controls.Add(numberOfCharactersLabel);
            Controls.Add(numberOfCharacters);
            Controls.Add(copyToClipboard);
            Controls.Add(generatePasswordLabel);
            Controls.Add(passwordOutput);
            Controls.Add(generatePassword);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(userSurname);
            Controls.Add(userName);
            Controls.Add(label1);
            Name = "Form1";
            Text = "PasswordGenerator v2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox userName;
        private TextBox userSurname;
        private Label label2;
        private Label label3;
        private Button generatePassword;
        private TextBox passwordOutput;
        private Label generatePasswordLabel;
        private Button copyToClipboard;
        private ComboBox numberOfCharacters;
        private Label numberOfCharactersLabel;
    }
}
