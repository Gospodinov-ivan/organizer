
namespace Organizer
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.органайзерToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tasks = new System.Windows.Forms.ToolStripMenuItem();
            this.Contacts = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HowToUseIt = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutDeveloper = new System.Windows.Forms.ToolStripMenuItem();
            this.MainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.StudentsDataGrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ButtonsLayout = new System.Windows.Forms.TableLayoutPanel();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.StudentsInfo = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.добавитьПользователяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsDataGrid)).BeginInit();
            this.ButtonsLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // органайзерToolStripMenuItem
            // 
            this.органайзерToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tasks,
            this.Contacts});
            this.органайзерToolStripMenuItem.Name = "органайзерToolStripMenuItem";
            this.органайзерToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.органайзерToolStripMenuItem.Text = "Органайзер";
            // 
            // Tasks
            // 
            this.Tasks.Name = "Tasks";
            this.Tasks.Size = new System.Drawing.Size(126, 22);
            this.Tasks.Text = "Задачи";
            // 
            // Contacts
            // 
            this.Contacts.Name = "Contacts";
            this.Contacts.Size = new System.Drawing.Size(126, 22);
            this.Contacts.Text = "Контакты";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // HowToUseIt
            // 
            this.HowToUseIt.Name = "HowToUseIt";
            this.HowToUseIt.Size = new System.Drawing.Size(228, 22);
            this.HowToUseIt.Text = "Как работать с программой";
            // 
            // AboutDeveloper
            // 
            this.AboutDeveloper.Name = "AboutDeveloper";
            this.AboutDeveloper.Size = new System.Drawing.Size(228, 22);
            this.AboutDeveloper.Text = "О разработчике";
            // 
            // MainLayout
            // 
            this.MainLayout.ColumnCount = 1;
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainLayout.Controls.Add(this.StudentsDataGrid, 0, 0);
            this.MainLayout.Controls.Add(this.ButtonsLayout, 0, 1);
            this.MainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLayout.Location = new System.Drawing.Point(0, 24);
            this.MainLayout.Name = "MainLayout";
            this.MainLayout.RowCount = 2;
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.50267F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.49733F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainLayout.Size = new System.Drawing.Size(800, 426);
            this.MainLayout.TabIndex = 1;
            // 
            // StudentsDataGrid
            // 
            this.StudentsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.StudentsDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StudentsDataGrid.Location = new System.Drawing.Point(3, 3);
            this.StudentsDataGrid.Name = "StudentsDataGrid";
            this.StudentsDataGrid.Size = new System.Drawing.Size(794, 371);
            this.StudentsDataGrid.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Группа";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Фамилия";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Экзамены";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "Зачеты";
            this.Column5.Name = "Column5";
            // 
            // ButtonsLayout
            // 
            this.ButtonsLayout.ColumnCount = 4;
            this.ButtonsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsLayout.Controls.Add(this.DeleteButton, 0, 0);
            this.ButtonsLayout.Controls.Add(this.StudentsInfo, 0, 0);
            this.ButtonsLayout.Controls.Add(this.AddButton, 0, 0);
            this.ButtonsLayout.Controls.Add(this.UpdateButton, 0, 0);
            this.ButtonsLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonsLayout.Location = new System.Drawing.Point(3, 380);
            this.ButtonsLayout.Name = "ButtonsLayout";
            this.ButtonsLayout.RowCount = 1;
            this.ButtonsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ButtonsLayout.Size = new System.Drawing.Size(794, 43);
            this.ButtonsLayout.TabIndex = 1;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeleteButton.Location = new System.Drawing.Point(399, 3);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(192, 37);
            this.DeleteButton.TabIndex = 6;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // StudentsInfo
            // 
            this.StudentsInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StudentsInfo.Location = new System.Drawing.Point(597, 3);
            this.StudentsInfo.Name = "StudentsInfo";
            this.StudentsInfo.Size = new System.Drawing.Size(194, 37);
            this.StudentsInfo.TabIndex = 5;
            this.StudentsInfo.Text = "Информация";
            this.StudentsInfo.UseVisualStyleBackColor = true;
            this.StudentsInfo.Click += new System.EventHandler(this.StudentsInfo_Click);
            // 
            // AddButton
            // 
            this.AddButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddButton.Location = new System.Drawing.Point(3, 3);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(192, 37);
            this.AddButton.TabIndex = 4;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UpdateButton.Location = new System.Drawing.Point(201, 3);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(192, 37);
            this.UpdateButton.TabIndex = 3;
            this.UpdateButton.Text = "Редактировать";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // добавитьПользователяToolStripMenuItem
            // 
            this.добавитьПользователяToolStripMenuItem.Name = "добавитьПользователяToolStripMenuItem";
            this.добавитьПользователяToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.добавитьПользователяToolStripMenuItem.Text = "Добавить пользователя";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainLayout);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Студенты";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.MainLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StudentsDataGrid)).EndInit();
            this.ButtonsLayout.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem органайзерToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Tasks;
        private System.Windows.Forms.ToolStripMenuItem Contacts;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HowToUseIt;
        private System.Windows.Forms.ToolStripMenuItem AboutDeveloper;
        private System.Windows.Forms.TableLayoutPanel MainLayout;
        private System.Windows.Forms.DataGridView StudentsDataGrid;
        private System.Windows.Forms.TableLayoutPanel ButtonsLayout;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button StudentsInfo;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.ToolStripMenuItem добавитьПользователяToolStripMenuItem;
    }
}

