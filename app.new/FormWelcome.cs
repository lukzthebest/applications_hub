using app;
using App.New.App.User;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.New
{
    public partial class FormWelcome : Form
    {
        public FormWelcome()
        {
            InitializeComponent();
        }

        private void labelStatus_Click(object sender, EventArgs e)
        {

        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxUsername.Text.IsNullOrEmpty())
                return;

            if (textBoxPassword.Text.IsNullOrEmpty())
                return;

            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            foreach(User user in Program.Instance.UserManager.users)
            {

            }    
        }
    }
}
