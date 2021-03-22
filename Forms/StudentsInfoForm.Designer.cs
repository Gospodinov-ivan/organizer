
namespace Organizer.Forms
{
    partial class StudentsInfoForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Groups = new System.Windows.Forms.ComboBox();
            this.StudentsData = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.D5 = new System.Windows.Forms.Label();
            this.D4 = new System.Windows.Forms.Label();
            this.D3 = new System.Windows.Forms.Label();
            this.D2 = new System.Windows.Forms.Label();
            this.D1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label11 = new System.Windows.Forms.Label();
            this.debtors = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsData)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.Groups, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.StudentsData, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.splitContainer1, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.42857F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.08075F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.832298F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(505, 322);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Groups
            // 
            this.Groups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Groups.FormattingEnabled = true;
            this.Groups.Location = new System.Drawing.Point(3, 3);
            this.Groups.Name = "Groups";
            this.Groups.Size = new System.Drawing.Size(499, 21);
            this.Groups.TabIndex = 0;
            this.Groups.SelectedIndexChanged += new System.EventHandler(this.Groups_SelectedIndexChanged);
            // 
            // StudentsData
            // 
            this.StudentsData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentsData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.StudentsData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StudentsData.Location = new System.Drawing.Point(3, 19);
            this.StudentsData.Name = "StudentsData";
            this.StudentsData.Size = new System.Drawing.Size(499, 223);
            this.StudentsData.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.D5, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.D4, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.D3, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.D2, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.D1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label5, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 248);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(499, 48);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // D5
            // 
            this.D5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.D5.AutoSize = true;
            this.D5.Location = new System.Drawing.Point(441, 29);
            this.D5.Name = "D5";
            this.D5.Size = new System.Drawing.Size(13, 13);
            this.D5.TabIndex = 9;
            this.D5.Text = "0";
            // 
            // D4
            // 
            this.D4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.D4.AutoSize = true;
            this.D4.Location = new System.Drawing.Point(340, 29);
            this.D4.Name = "D4";
            this.D4.Size = new System.Drawing.Size(13, 13);
            this.D4.TabIndex = 8;
            this.D4.Text = "0";
            // 
            // D3
            // 
            this.D3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.D3.AutoSize = true;
            this.D3.Location = new System.Drawing.Point(241, 29);
            this.D3.Name = "D3";
            this.D3.Size = new System.Drawing.Size(13, 13);
            this.D3.TabIndex = 7;
            this.D3.Text = "0";
            // 
            // D2
            // 
            this.D2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.D2.AutoSize = true;
            this.D2.Location = new System.Drawing.Point(142, 29);
            this.D2.Name = "D2";
            this.D2.Size = new System.Drawing.Size(13, 13);
            this.D2.TabIndex = 6;
            this.D2.Text = "0";
            // 
            // D1
            // 
            this.D1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.D1.AutoSize = true;
            this.D1.Location = new System.Drawing.Point(43, 29);
            this.D1.Name = "D1";
            this.D1.Size = new System.Drawing.Size(13, 13);
            this.D1.TabIndex = 5;
            this.D1.Text = "0";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(408, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Дисциплина 5";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(307, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Дисциплина 4";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(208, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Дисциплина 3";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Дисциплина 2";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Дисциплина 1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 302);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label11);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.debtors);
            this.splitContainer1.Size = new System.Drawing.Size(499, 17);
            this.splitContainer1.SplitterDistance = 166;
            this.splitContainer1.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Location = new System.Drawing.Point(0, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Задолжников в общем";
            // 
            // debtors
            // 
            this.debtors.AutoSize = true;
            this.debtors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.debtors.Location = new System.Drawing.Point(0, 0);
            this.debtors.Name = "debtors";
            this.debtors.Size = new System.Drawing.Size(13, 13);
            this.debtors.TabIndex = 1;
            this.debtors.Text = "0";
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Фамилия";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Средний балл";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Количество задолженностей";
            this.Column3.Name = "Column3";
            // 
            // StudentsInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 322);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "StudentsInfoForm";
            this.Text = "Информация о студентах";
            this.Load += new System.EventHandler(this.StudentsInfo_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StudentsData)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox Groups;
        private System.Windows.Forms.DataGridView StudentsData;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label D5;
        private System.Windows.Forms.Label D4;
        private System.Windows.Forms.Label D3;
        private System.Windows.Forms.Label D2;
        private System.Windows.Forms.Label D1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label debtors;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}