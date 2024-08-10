namespace App.New
{
    partial class FormWelcome
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
            labelWelcome = new Label();
            labelUsername = new Label();
            labelPassword = new Label();
            labelStatus = new Label();
            textBoxUsername = new TextBox();
            textBoxPassword = new TextBox();
            buttonLogin = new Button();
            textBoxNews = new TextBox();
            SuspendLayout();
            // 
            // labelWelcome
            // 
            labelWelcome.AutoSize = true;
            labelWelcome.Font = new Font("Verdana Pro Cond", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelWelcome.Location = new Point(218, 61);
            labelWelcome.Name = "labelWelcome";
            labelWelcome.Size = new Size(556, 65);
            labelWelcome.TabIndex = 0;
            labelWelcome.Text = "Welcome! Please Login!";
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Verdana Pro Cond", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelUsername.Location = new Point(52, 195);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(258, 65);
            labelUsername.TabIndex = 1;
            labelUsername.Text = "Username";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Verdana Pro Cond", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPassword.Location = new Point(68, 304);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(242, 65);
            labelPassword.TabIndex = 2;
            labelPassword.Text = "Password";
            // 
            // labelStatus
            // 
            labelStatus.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelStatus.AutoSize = true;
            labelStatus.Font = new Font("Verdana Pro Cond", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelStatus.Location = new Point(827, 655);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(166, 65);
            labelStatus.TabIndex = 3;
            labelStatus.Text = "status";
            labelStatus.Click += labelStatus_Click;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Font = new Font("Verdana Pro Cond", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxUsername.Location = new Point(316, 195);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(566, 66);
            textBoxUsername.TabIndex = 4;
            textBoxUsername.TextChanged += textBoxUsername_TextChanged;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Font = new Font("Verdana Pro Cond", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxPassword.Location = new Point(316, 317);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(566, 66);
            textBoxPassword.TabIndex = 5;
            // 
            // buttonLogin
            // 
            buttonLogin.Font = new Font("Verdana Pro Cond", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonLogin.Location = new Point(851, 524);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(128, 128);
            buttonLogin.TabIndex = 6;
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // textBoxNews
            // 
            textBoxNews.Location = new Point(52, 424);
            textBoxNews.Multiline = true;
            textBoxNews.Name = "textBoxNews";
            textBoxNews.Size = new Size(774, 228);
            textBoxNews.TabIndex = 7;
            // 
            // FormWelcome
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1005, 729);
            Controls.Add(textBoxNews);
            Controls.Add(buttonLogin);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUsername);
            Controls.Add(labelStatus);
            Controls.Add(labelPassword);
            Controls.Add(labelUsername);
            Controls.Add(labelWelcome);
            Name = "FormWelcome";
            Text = "FormWelcome";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelWelcome;
        private Label labelUsername;
        private Label labelPassword;
        private Label labelStatus;
        private TextBox textBoxUsername;
        private TextBox textBoxPassword;
        private Button buttonLogin;
        private TextBox textBoxNews;
    }
}