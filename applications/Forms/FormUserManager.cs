using applications.User;
using System;
using System.Security.Cryptography.Xml;
using System.Windows.Forms;

namespace applications.Forms
{
    public partial class FormUserManager : Form
    {
        private bool isPasswordVisible = false; // Initial Zustand für Passwortsichtbarkeit
        TreeNode adminNode = new TreeNode("Admins");
        TreeNode usersNode = new TreeNode("Users");
        TreeNode notAllowedNode = new TreeNode("Not Allowed");

        User.User currentUser = null;
        
        public FormUserManager()
        {
            InitializeComponent();
            treeViewUserList.Nodes.Add(adminNode);
            treeViewUserList.Nodes.Add(usersNode);
            treeViewUserList.Nodes.Add(notAllowedNode);

            this.AddUserToList();
        }


        public void AddUserToList()
        {
            treeViewUserList.ExpandAll();

            foreach (var user in Program.Instance.UserManager.Users)
            {
                TreeNode userNode = new TreeNode(user.Username)
                {
                    Tag = user // Tag User
                };

                switch (user.Allowed)
                {
                    case 0:
                        notAllowedNode.Nodes.Add(userNode);
                        break;
                    case 1:
                        switch (user.Admin)
                        {
                            case 0:
                                usersNode.Nodes.Add(userNode);
                                break;
                            case 1:
                                adminNode.Nodes.Add(userNode);
                                break;
                        }
                        break;
                }
            }
        }

        private void FillWithUserInfos(User.User selectedUser)
        {
            this.currentUser = selectedUser;
            this.textBoxManagementUsername.Text = currentUser.Username;
            this.maskedTextBoxPassword.Text = currentUser.Password;
            this.textBoxManagementEmail.Text = currentUser.Email;
            bool admin = false;
            bool allowed = false;
            switch (currentUser.Admin)
            {
                case 1:
                    admin = true;
                    break;
                default:
                    admin = false;
                    break;
            }
            switch (currentUser.Allowed)
            {
                case 1:
                    allowed = true;
                    break;
                default:
                    allowed = false;
                    break;
            }
            this.checkBoxAdmin.Checked = admin;
            this.checkBoxAllowed.Checked = allowed;

        }

        private void treeViewUserList_AfterSelect(object sender, TreeViewEventArgs e)
        {
            this.currentUser = null;
            this.checkBoxShowPassword.Checked = false;
            if (!(e.Node.Tag is User.User selectedUser)) // Überprüfen, ob das Tag ein User-Objekt ist
            {
                this.textBoxManagementUsername.Text = "";
                this.textBoxManagementUsername.Visible = false;
                this.maskedTextBoxPassword.Text = "";
                this.maskedTextBoxPassword.Visible = false;
                this.textBoxManagementEmail.Text = "";
                this.textBoxManagementEmail.Visible = false;
                this.labelManagementUsername.Visible = false;
                this.labelManagementPassword.Visible = false;
                this.labelManagementEmail.Visible = false;
                this.checkBoxAdmin.Checked = false;
                this.checkBoxAllowed.Checked = false;
                this.checkBoxAdmin.Visible = false;
                this.checkBoxAllowed.Visible = false;
                this.checkBoxShowPassword.Visible = false;
            }
            else
            {
                this.currentUser = selectedUser;
                this.FillWithUserInfos(currentUser);
                this.textBoxManagementUsername.Visible = true;
                this.maskedTextBoxPassword.Visible = true;
                this.textBoxManagementEmail.Visible = true;
                this.labelManagementUsername.Visible = true;
                this.labelManagementPassword.Visible = true;
                this.labelManagementEmail.Visible = true;
                this.checkBoxAdmin.Visible = true;
                this.checkBoxAllowed.Visible = true;
                this.checkBoxShowPassword.Visible = true;
            }

        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            // Toggle password visibility based on the current state
            isPasswordVisible = !isPasswordVisible;

            if (isPasswordVisible)
            {
                this.maskedTextBoxPassword.PasswordChar = '\0'; // Show password
            }
            else
            {
                this.maskedTextBoxPassword.PasswordChar = '*'; // Hide password
            }

        }

        public void ClearAllNodes()
        {
            this.adminNode.Nodes.Clear();
            this.usersNode.Nodes.Clear();
            this.notAllowedNode.Nodes.Clear();
        }


        private void Reload()
        {
            this.ClearAllNodes();
            Program.Instance.UserManager.InitUsers();
            this.AddUserToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Reload();
        }

        private void checkBoxAdmin_CheckedChanged(object sender, EventArgs e)
        {
            if (currentUser != null) {
                Program.Instance.UserManager.UpdateUserStatus(currentUser.ID, checkBoxAdmin.Checked, 0);
                this.Reload();
                currentUser = null;
            }
        }

        private void checkBoxAllowed_CheckedChanged(object sender, EventArgs e)
        {
            if (currentUser != null)
            {
                Program.Instance.UserManager.UpdateUserStatus(currentUser.ID, checkBoxAllowed.Checked, 1);
                this.Reload();
                currentUser = null;
            }
        }
    }
}
