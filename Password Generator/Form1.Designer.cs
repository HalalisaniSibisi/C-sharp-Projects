namespace Password_Generator
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
            passwordOutput = new TextBox();
            generateButton = new Button();
            copyButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(243, 16, 16);
            label1.Location = new Point(209, 82);
            label1.Name = "label1";
            label1.Size = new Size(366, 45);
            label1.TabIndex = 0;
            label1.Text = "Password Generator";
            // 
            // passwordOutput
            // 
            passwordOutput.Location = new Point(183, 275);
            passwordOutput.Name = "passwordOutput";
            passwordOutput.ReadOnly = true;
            passwordOutput.Size = new Size(392, 27);
            passwordOutput.TabIndex = 1;
            passwordOutput.Visible = false;
            passwordOutput.TextChanged += passwordOutput_TextChanged;
            // 
            // generateButton
            // 
            generateButton.BackColor = Color.Chocolate;
            generateButton.Cursor = Cursors.Hand;
            generateButton.FlatStyle = FlatStyle.Flat;
            generateButton.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            generateButton.ForeColor = SystemColors.ButtonFace;
            generateButton.Location = new Point(286, 175);
            generateButton.Name = "generateButton";
            generateButton.Size = new Size(195, 58);
            generateButton.TabIndex = 2;
            generateButton.Text = "Generate";
            generateButton.UseVisualStyleBackColor = false;
            generateButton.Click += generateButton_Click;
            // 
            // copyButton
            // 
            copyButton.BackColor = Color.Blue;
            copyButton.FlatStyle = FlatStyle.Flat;
            copyButton.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            copyButton.ForeColor = Color.White;
            copyButton.Location = new Point(286, 317);
            copyButton.Name = "copyButton";
            copyButton.Size = new Size(186, 41);
            copyButton.TabIndex = 3;
            copyButton.Text = "Copy to clipboard";
            copyButton.UseVisualStyleBackColor = false;
            copyButton.Visible = false;
            copyButton.Click += copyButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(52, 137, 169);
            ClientSize = new Size(800, 450);
            Controls.Add(copyButton);
            Controls.Add(generateButton);
            Controls.Add(passwordOutput);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Password Generator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox passwordOutput;
        private Button generateButton;
        private Button copyButton;
    }
}
