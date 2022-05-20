using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GRP11_Castro_Jocson_FinalProject
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void logInBtn_Click(object sender, EventArgs e)
        {
            if (usernameTextBox.Text == "mine" && passwordTextBox.Text == "craft")
            {
                MessageBox.Show("Log In Successful!", "Log In Success", MessageBoxButtons.OK);
                MainWindow mainWindow = new MainWindow();
                mainWindow.setUsername(usernameTextBox.Text);
                mainWindow.ShowDialog();
            }
            else if (usernameTextBox.Text != "mine" || passwordTextBox.Text == "craft")
            {
                MessageBox.Show("Invalid Username", "Invalid Username. Please try again.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (usernameTextBox.Text == "mine" || passwordTextBox.Text != "craft")
            {
                MessageBox.Show("Incorrect Password", "Incorrect password. Please try again.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            usernameTextBox.Text = "";
            passwordTextBox.Text = "";
        }
    }
}
