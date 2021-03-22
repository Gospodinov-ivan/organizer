
namespace Organizer.Forms
{
    partial class ShowDebtorsForm
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.DabtorsData = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.сортироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SortByGroup = new System.Windows.Forms.ToolStripMenuItem();
            this.SortBySurname = new System.Windows.Forms.ToolStripMenuItem();
            this.SortByDebt = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Subject = new System.Windows.Forms.ComboBox();
            this.Mark = new System.Windows.Forms.ComboBox();
            this.ChangeExem = new System.Windows.Forms.Button();
            this.Students = new System.Windows.Forms.ComboBox();
            this.DelStudents = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DabtorsData)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.DabtorsData, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.DelStudents, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.350649F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.64935F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(626, 385);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // DabtorsData
            // 
            this.DabtorsData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DabtorsData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.DabtorsData.ContextMenuStrip = this.contextMenuStrip1;
            this.DabtorsData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DabtorsData.Location = new System.Drawing.Point(3, 3);
            this.DabtorsData.Name = "DabtorsData";
            this.DabtorsData.Size = new System.Drawing.Size(620, 302);
            this.DabtorsData.TabIndex = 0;
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
            this.Column4.HeaderText = "Количество Задолженностей";
            this.Column4.Name = "Column4";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сортироватьToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(146, 26);
            // 
            // сортироватьToolStripMenuItem
            // 
            this.сортироватьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SortByGroup,
            this.SortBySurname,
            this.SortByDebt});
            this.сортироватьToolStripMenuItem.Name = "сортироватьToolStripMenuItem";
            this.сортироватьToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.сортироватьToolStripMenuItem.Text = "Сортировать";
            // 
            // SortByGroup
            // 
            this.SortByGroup.Name = "SortByGroup";
            this.SortByGroup.Size = new System.Drawing.Size(184, 22);
            this.SortByGroup.Text = "по группе";
            this.SortByGroup.Click += new System.EventHandler(this.SortByGroup_Click);
            // 
            // SortBySurname
            // 
            this.SortBySurname.Name = "SortBySurname";
            this.SortBySurname.Size = new System.Drawing.Size(184, 22);
            this.SortBySurname.Text = "по фамилии";
            this.SortBySurname.Click += new System.EventHandler(this.SortBySurname_Click);
            // 
            // SortByDebt
            // 
            this.SortByDebt.Name = "SortByDebt";
            this.SortByDebt.Size = new System.Drawing.Size(184, 22);
            this.SortByDebt.Text = "по задолженностям";
            this.SortByDebt.Click += new System.EventHandler(this.SortByDebt_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.9085F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.00436F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel2.Controls.Add(this.Subject, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.Mark, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.ChangeExem, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.Students, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 311);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(620, 29);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // Subject
            // 
            this.Subject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Subject.FormattingEnabled = true;
            this.Subject.Items.AddRange(new object[] {
            "Дисциплина 1",
            "Дисциплина 2",
            "Дисциплина 3",
            "Дисциплина 4",
            "Дисциплина 5"});
            this.Subject.Location = new System.Drawing.Point(449, 3);
            this.Subject.Name = "Subject";
            this.Subject.Size = new System.Drawing.Size(120, 21);
            this.Subject.TabIndex = 8;
            this.Subject.Text = "Дисциплина 1";
            // 
            // Mark
            // 
            this.Mark.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Mark.FormattingEnabled = true;
            this.Mark.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5"});
            this.Mark.Location = new System.Drawing.Point(575, 3);
            this.Mark.Name = "Mark";
            this.Mark.Size = new System.Drawing.Size(42, 21);
            this.Mark.TabIndex = 6;
            this.Mark.Text = "2";
            // 
            // ChangeExem
            // 
            this.ChangeExem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChangeExem.Location = new System.Drawing.Point(3, 3);
            this.ChangeExem.Name = "ChangeExem";
            this.ChangeExem.Size = new System.Drawing.Size(223, 23);
            this.ChangeExem.TabIndex = 3;
            this.ChangeExem.Text = "Изменить результат экзамена";
            this.ChangeExem.UseVisualStyleBackColor = true;
            this.ChangeExem.Click += new System.EventHandler(this.ChangeExem_Click);
            // 
            // Students
            // 
            this.Students.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Students.FormattingEnabled = true;
            this.Students.Location = new System.Drawing.Point(232, 3);
            this.Students.Name = "Students";
            this.Students.Size = new System.Drawing.Size(211, 21);
            this.Students.TabIndex = 7;
            // 
            // DelStudents
            // 
            this.DelStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DelStudents.Location = new System.Drawing.Point(3, 346);
            this.DelStudents.Name = "DelStudents";
            this.DelStudents.Size = new System.Drawing.Size(620, 36);
            this.DelStudents.TabIndex = 4;
            this.DelStudents.Text = "Отчислить студентов с 3 и более задолженостями";
            this.DelStudents.UseVisualStyleBackColor = true;
            this.DelStudents.Click += new System.EventHandler(this.DelStudents_Click);
            // 
            // ShowDebtorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 385);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ShowDebtorsForm";
            this.Text = "Задолжники";
            this.Load += new System.EventHandler(this.ShowDebtorsForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DabtorsData)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView DabtorsData;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button ChangeExem;
        private System.Windows.Forms.Button DelStudents;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem сортироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SortByGroup;
        private System.Windows.Forms.ToolStripMenuItem SortBySurname;
        private System.Windows.Forms.ToolStripMenuItem SortByDebt;
        private System.Windows.Forms.ComboBox Subject;
        private System.Windows.Forms.ComboBox Mark;
        private System.Windows.Forms.ComboBox Students;
    }
}