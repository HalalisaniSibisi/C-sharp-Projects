using System.Security.Cryptography;
using System.Text;

namespace Password_Generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            string[] randomWords = [
                "Completed", "took",
                "Control", "Repository", "linux", "discovery", "seconds",
                "Wiley", "output", "Build", "show"
                ];

            int randomIndex = random.Next(0, randomWords.Length);
            string randomisedWord = randomWords[randomIndex].ToString();



            passwordOutput.Text = HashPassword(randomisedWord);
            passwordOutput.Visible = true;
            copyButton.Visible = true;

        }

        public static string HashPassword(string password)
        {
            byte[] inputBytes = Encoding.UTF8.GetBytes(password);

            byte[] hashBytes = SHA256.HashData(inputBytes);


            return Convert.ToHexString(hashBytes);
        }

        private void passwordOutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            string copyText = passwordOutput.Text;
            Clipboard.SetText(copyText);
        }
    }
}
