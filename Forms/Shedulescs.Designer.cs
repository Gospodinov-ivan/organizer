
namespace Organizer.Forms
{
    partial class Shedulescs
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.SheduleData = new System.Windows.Forms.DataGridView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.DelSheduleText = new System.Windows.Forms.ComboBox();
            this.DelButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.AddSheduleText = new System.Windows.Forms.RichTextBox();
            this.AddSheduleDate = new System.Windows.Forms.DateTimePicker();
            this.AddButton = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SheduleData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(749, 392);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.SheduleData);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(741, 366);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Планировщик";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.splitContainer1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(741, 366);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Управление";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // SheduleData
            // 
            this.SheduleData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SheduleData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.SheduleData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SheduleData.Location = new System.Drawing.Point(3, 3);
            this.SheduleData.Name = "SheduleData";
            this.SheduleData.Size = new System.Drawing.Size(735, 360);
            this.SheduleData.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.DelButton);
            this.splitContainer1.Panel1.Controls.Add(this.DelSheduleText);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.AddButton);
            this.splitContainer1.Panel2.Controls.Add(this.AddSheduleDate);
            this.splitContainer1.Panel2.Controls.Add(this.AddSheduleText);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Size = new System.Drawing.Size(735, 360);
            this.splitContainer1.SplitterDistance = 245;
            this.splitContainer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Удалить задачу";
            // 
            // DelSheduleText
            // 
            this.DelSheduleText.FormattingEnabled = true;
            this.DelSheduleText.Location = new System.Drawing.Point(5, 108);
            this.DelSheduleText.Name = "DelSheduleText";
            this.DelSheduleText.Size = new System.Drawing.Size(237, 21);
            this.DelSheduleText.TabIndex = 1;
            // 
            // DelButton
            // 
            this.DelButton.Location = new System.Drawing.Point(3, 135);
            this.DelButton.Name = "DelButton";
            this.DelButton.Size = new System.Drawing.Size(239, 23);
            this.DelButton.TabIndex = 2;
            this.DelButton.Text = "Удалить";
            this.DelButton.UseVisualStyleBackColor = true;
            this.DelButton.Click += new System.EventHandler(this.DelButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Добавить задачу";
            // 
            // AddSheduleText
            // 
            this.AddSheduleText.Location = new System.Drawing.Point(64, 86);
            this.AddSheduleText.Name = "AddSheduleText";
            this.AddSheduleText.Size = new System.Drawing.Size(344, 211);
            this.AddSheduleText.TabIndex = 1;
            this.AddSheduleText.Text = "";
            // 
            // AddSheduleDate
            // 
            this.AddSheduleDate.Location = new System.Drawing.Point(64, 58);
            this.AddSheduleDate.Name = "AddSheduleDate";
            this.AddSheduleDate.Size = new System.Drawing.Size(200, 20);
            this.AddSheduleDate.TabIndex = 2;
            this.AddSheduleDate.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(208, 303);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 3;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column1.HeaderText = "КОД";
            this.Column1.Name = "Column1";
            this.Column1.Width = 56;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Текст Задачи";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Дата Выполнения";
            this.Column3.Name = "Column3";
            // 
            // Shedulescs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 392);
            this.Controls.Add(this.tabControl1);
            this.Name = "Shedulescs";
            this.Text = "Планировщик";
            this.Load += new System.EventHandler(this.Shedulescs_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SheduleData)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView SheduleData;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button DelButton;
        private System.Windows.Forms.ComboBox DelSheduleText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.DateTimePicker AddSheduleDate;
        private System.Windows.Forms.RichTextBox AddSheduleText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}