using Assignment4_N01600569.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Assignment4_N01600569
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = textBoxEmail.Text;
            string password = textBoxPass.Text;
            // Check if email and password are provided
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both email and password.");
                return;
            }
            using (var context = new MMABooksContext())
            {
                var user = context.Users.FirstOrDefault(u => u.Email == email && u.Password == password);

                if (user != null)
                {
                    // Authentication successful
                    // Open the main application form
                    FormMainApplication formMain = new FormMainApplication(user);
                    formMain.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid email or password. Please try again.");
                }
            }
        }
    }
}
