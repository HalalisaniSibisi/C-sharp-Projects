using System.Security.Cryptography;
using System.Text;

namespace PasswordGeneratorv2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void generatePassword_Click(object sender, EventArgs e)
        {
            string name = userName.Text;
            string surname = userSurname.Text;

            

            string full_name = $"{name.Trim()} {surname.Trim()}";

            full_name = HashPassword(full_name);


            if (string.IsNullOrEmpty(name) && string.IsNullOrEmpty(surname) ) 
            {
                MessageBox.Show("Please enter your name and surname", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }



            if (numberOfCharacters.SelectedIndex == 0)
            {

                passwordOutput.Text = full_name.Substring(0, 10);


            }
            else if (numberOfCharacters.SelectedIndex == 1)
            {

                passwordOutput.Text = full_name.Substring(0, 12);
            }

            else if (numberOfCharacters.SelectedIndex == 2)
            {

                passwordOutput.Text = full_name.Substring(0, 14);
            }
            else if(numberOfCharacters.SelectedIndex == 3)
            {
                passwordOutput.Text = full_name.Substring (0, 16);
            }
            


            generatePasswordLabel.Visible = true;
            passwordOutput.Visible = true;
            copyToClipboard.Visible = true;
            copyToClipboard.Visible = true;


        }

        public static string HashPassword(string password)
        {
            byte[] inputByte = Encoding.UTF8.GetBytes(password);
            byte[] hashByte = SHA256.HashData(inputByte);

            return Convert.ToHexString(hashByte);
        }

        private void copyToClipboard_Click(object sender, EventArgs e)
        {
            string copyText = passwordOutput.Text;

            Clipboard.SetText(copyText);

        }

        private void numberOfCharacters_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
