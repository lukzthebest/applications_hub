namespace applications.Forms
{
    partial class FormUserManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitContainer = new SplitContainer();
            treeViewUserList = new TreeView();
            button1 = new Button();
            checkBoxAllowed = new CheckBox();
            checkBoxShowPassword = new CheckBox();
            checkBoxAdmin = new CheckBox();
            textBoxManagementEmail = new TextBox();
            labelManagementEmail = new Label();
            maskedTextBoxPassword = new MaskedTextBox();
            labelManagementPassword = new Label();
            textBoxManagementUsername = new TextBox();
            labelManagementUsername = new Label();
            panelUserManager = new Panel();
            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel1.SuspendLayout();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
            panelUserManager.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer
            // 
            splitContainer.Dock = DockStyle.Fill;
            splitContainer.Location = new Point(0, 0);
            splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            splitContainer.Panel1.Controls.Add(treeViewUserList);
            // 
            // splitContainer.Panel2
            // 
            splitContainer.Panel2.Controls.Add(button1);
            splitContainer.Panel2.Controls.Add(checkBoxAllowed);
            splitContainer.Panel2.Controls.Add(checkBoxShowPassword);
            splitContainer.Panel2.Controls.Add(checkBoxAdmin);
            splitContainer.Panel2.Controls.Add(textBoxManagementEmail);
            splitContainer.Panel2.Controls.Add(labelManagementEmail);
            splitContainer.Panel2.Controls.Add(maskedTextBoxPassword);
            splitContainer.Panel2.Controls.Add(labelManagementPassword);
            splitContainer.Panel2.Controls.Add(textBoxManagementUsername);
            splitContainer.Panel2.Controls.Add(labelManagementUsername);
            splitContainer.Size = new Size(1203, 818);
            splitContainer.SplitterDistance = 401;
            splitContainer.TabIndex = 1;
            // 
            // treeViewUserList
            // 
            treeViewUserList.Dock = DockStyle.Fill;
            treeViewUserList.Location = new Point(0, 0);
            treeViewUserList.Name = "treeViewUserList";
            treeViewUserList.Size = new Size(401, 818);
            treeViewUserList.TabIndex = 0;
            treeViewUserList.AfterSelect += treeViewUserList_AfterSelect;
            // 
            // button1
            // 
            button1.Location = new Point(182, 706);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 11;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // checkBoxAllowed
            // 
            checkBoxAllowed.AutoSize = true;
            checkBoxAllowed.Location = new Point(36, 280);
            checkBoxAllowed.Name = "checkBoxAllowed";
            checkBoxAllowed.Size = new Size(142, 36);
            checkBoxAllowed.TabIndex = 10;
            checkBoxAllowed.Text = "Allowed?";
            checkBoxAllowed.UseVisualStyleBackColor = true;
            checkBoxAllowed.CheckedChanged += checkBoxAllowed_CheckedChanged;
            // 
            // checkBoxShowPassword
            // 
            checkBoxShowPassword.AutoSize = true;
            checkBoxShowPassword.Location = new Point(49, 139);
            checkBoxShowPassword.Name = "checkBoxShowPassword";
            checkBoxShowPassword.Size = new Size(219, 36);
            checkBoxShowPassword.TabIndex = 9;
            checkBoxShowPassword.Text = "Show Password?";
            checkBoxShowPassword.UseVisualStyleBackColor = true;
            checkBoxShowPassword.CheckedChanged += checkBoxShowPassword_CheckedChanged;
            // 
            // checkBoxAdmin
            // 
            checkBoxAdmin.AutoSize = true;
            checkBoxAdmin.Location = new Point(36, 232);
            checkBoxAdmin.Name = "checkBoxAdmin";
            checkBoxAdmin.Size = new Size(201, 36);
            checkBoxAdmin.TabIndex = 8;
            checkBoxAdmin.Text = "Administrator?";
            checkBoxAdmin.UseVisualStyleBackColor = true;
            checkBoxAdmin.CheckedChanged += checkBoxAdmin_CheckedChanged;
            // 
            // textBoxManagementEmail
            // 
            textBoxManagementEmail.Location = new Point(158, 182);
            textBoxManagementEmail.Name = "textBoxManagementEmail";
            textBoxManagementEmail.Size = new Size(252, 39);
            textBoxManagementEmail.TabIndex = 7;
            // 
            // labelManagementEmail
            // 
            labelManagementEmail.AutoSize = true;
            labelManagementEmail.Location = new Point(26, 185);
            labelManagementEmail.Name = "labelManagementEmail";
            labelManagementEmail.Size = new Size(76, 32);
            labelManagementEmail.TabIndex = 6;
            labelManagementEmail.Text = "Email:";
            // 
            // maskedTextBoxPassword
            // 
            maskedTextBoxPassword.Location = new Point(158, 92);
            maskedTextBoxPassword.Name = "maskedTextBoxPassword";
            maskedTextBoxPassword.PasswordChar = '*';
            maskedTextBoxPassword.Size = new Size(252, 39);
            maskedTextBoxPassword.TabIndex = 5;
            // 
            // labelManagementPassword
            // 
            labelManagementPassword.AutoSize = true;
            labelManagementPassword.Location = new Point(26, 95);
            labelManagementPassword.Name = "labelManagementPassword";
            labelManagementPassword.Size = new Size(116, 32);
            labelManagementPassword.TabIndex = 2;
            labelManagementPassword.Text = "Password:";
            // 
            // textBoxManagementUsername
            // 
            textBoxManagementUsername.Location = new Point(158, 34);
            textBoxManagementUsername.Name = "textBoxManagementUsername";
            textBoxManagementUsername.Size = new Size(252, 39);
            textBoxManagementUsername.TabIndex = 1;
            // 
            // labelManagementUsername
            // 
            labelManagementUsername.AutoSize = true;
            labelManagementUsername.Location = new Point(26, 37);
            labelManagementUsername.Name = "labelManagementUsername";
            labelManagementUsername.Size = new Size(126, 32);
            labelManagementUsername.TabIndex = 0;
            labelManagementUsername.Text = "Username:";
            // 
            // panelUserManager
            // 
            panelUserManager.Controls.Add(splitContainer);
            panelUserManager.Dock = DockStyle.Fill;
            panelUserManager.Location = new Point(0, 0);
            panelUserManager.Name = "panelUserManager";
            panelUserManager.Size = new Size(1203, 818);
            panelUserManager.TabIndex = 0;
            // 
            // FormUserManager
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1203, 818);
            Controls.Add(panelUserManager);
            Name = "FormUserManager";
            Text = "FormUserManager";
            splitContainer.Panel1.ResumeLayout(false);
            splitContainer.Panel2.ResumeLayout(false);
            splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            panelUserManager.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer;
        private TreeView treeViewUserList;
        private Panel panelUserManager;
        private Label labelManagementUsername;
        private TextBox textBoxManagementUsername;
        private Label labelManagementPassword;
        private MaskedTextBox maskedTextBoxPassword;
        private TextBox textBoxManagementEmail;
        private Label labelManagementEmail;
        private CheckBox checkBoxAdmin;
        private CheckBox checkBoxShowPassword;
        private CheckBox checkBoxAllowed;
        private Button button1;
    }
}