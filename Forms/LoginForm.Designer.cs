
namespace Organizer
{
    partial class LoginForm
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
            this.loginLayout = new System.Windows.Forms.TableLayoutPanel();
            this.LoginText = new System.Windows.Forms.TextBox();
            this.PasswordText = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.LogInButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.LockPicture = new System.Windows.Forms.PictureBox();
            this.loginLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LockPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // loginLayout
            // 
            this.loginLayout.ColumnCount = 1;
            this.loginLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.loginLayout.Controls.Add(this.LoginText, 0, 2);
            this.loginLayout.Controls.Add(this.PasswordText, 0, 3);
            this.loginLayout.Controls.Add(this.LockPicture, 0, 0);
            this.loginLayout.Controls.Add(this.label1, 0, 1);
            this.loginLayout.Controls.Add(this.splitContainer1, 0, 4);
            this.loginLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginLayout.Location = new System.Drawing.Point(0, 0);
            this.loginLayout.Name = "loginLayout";
            this.loginLayout.RowCount = 5;
            this.loginLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.47663F));
            this.loginLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.15888F));
            this.loginLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.03704F));
            this.loginLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.03704F));
            this.loginLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.loginLayout.Size = new System.Drawing.Size(274, 259);
            this.loginLayout.TabIndex = 0;
            // 
            // LoginText
            // 
            this.LoginText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginText.Location = new System.Drawing.Point(3, 167);
            this.LoginText.Name = "LoginText";
            this.LoginText.Size = new System.Drawing.Size(268, 20);
            this.LoginText.TabIndex = 2;
            // 
            // PasswordText
            // 
            this.PasswordText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PasswordText.Location = new System.Drawing.Point(3, 192);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.PasswordChar = '*';
            this.PasswordText.Size = new System.Drawing.Size(268, 20);
            this.PasswordText.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Для продолжения введите логин и пароль";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 217);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.LogInButton);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.ExitButton);
            this.splitContainer1.Size = new System.Drawing.Size(268, 39);
            this.splitContainer1.SplitterDistance = 123;
            this.splitContainer1.TabIndex = 6;
            // 
            // LogInButton
            // 
            this.LogInButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogInButton.Location = new System.Drawing.Point(0, 0);
            this.LogInButton.Name = "LogInButton";
            this.LogInButton.Size = new System.Drawing.Size(123, 39);
            this.LogInButton.TabIndex = 5;
            this.LogInButton.Text = "Войти";
            this.LogInButton.UseVisualStyleBackColor = true;
            this.LogInButton.Click += new System.EventHandler(this.LogInButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExitButton.Location = new System.Drawing.Point(0, 0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(141, 39);
            this.ExitButton.TabIndex = 6;
            this.ExitButton.Text = "Закрыть программу";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // LockPicture
            // 
            this.LockPicture.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LockPicture.Image = global::Organizer.Properties.Resources._lock;
            this.LockPicture.Location = new System.Drawing.Point(84, 15);
            this.LockPicture.Name = "LockPicture";
            this.LockPicture.Size = new System.Drawing.Size(106, 93);
            this.LockPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LockPicture.TabIndex = 0;
            this.LockPicture.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 259);
            this.Controls.Add(this.loginLayout);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(290, 298);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(290, 298);
            this.Name = "LoginForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Войти";
            this.loginLayout.ResumeLayout(false);
            this.loginLayout.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LockPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel loginLayout;
        private System.Windows.Forms.PictureBox LockPicture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LoginText;
        private System.Windows.Forms.MaskedTextBox PasswordText;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button LogInButton;
        private System.Windows.Forms.Button ExitButton;
    }
}