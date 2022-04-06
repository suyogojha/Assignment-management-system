namespace Assignment_management_system
{
    partial class Assignment
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtremarks = new System.Windows.Forms.RichTextBox();
            this.txtstatus = new System.Windows.Forms.ComboBox();
            this.txtteacher = new System.Windows.Forms.ComboBox();
            this.txtsubject = new System.Windows.Forms.ComboBox();
            this.txtstudent = new System.Windows.Forms.ComboBox();
            this.txtdate = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txttid = new System.Windows.Forms.Label();
            this.txtsubjectid = new System.Windows.Forms.Label();
            this.txtstatusid = new System.Windows.Forms.Label();
            this.txtsid = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubmissionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Student = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Teacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtid = new System.Windows.Forms.Label();
            this.txtassignmentID = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(251, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(640, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "ASSIGNMENT INFORMATION";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Submission Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(98, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Student";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(98, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Subject";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(96, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Teacher";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(92, 366);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Remarks";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(102, 296);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Status";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txtremarks);
            this.panel1.Controls.Add(this.txtstatus);
            this.panel1.Controls.Add(this.txtteacher);
            this.panel1.Controls.Add(this.txtsubject);
            this.panel1.Controls.Add(this.txtstudent);
            this.panel1.Controls.Add(this.txtdate);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(3, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(391, 561);
            this.panel1.TabIndex = 7;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(276, 328);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(96, 44);
            this.button4.TabIndex = 17;
            this.button4.Text = "DELETE";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(276, 253);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 44);
            this.button3.TabIndex = 16;
            this.button3.Text = "RESET";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(276, 179);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 44);
            this.button2.TabIndex = 15;
            this.button2.Text = "UPDATE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(276, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 44);
            this.button1.TabIndex = 14;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtremarks
            // 
            this.txtremarks.Location = new System.Drawing.Point(9, 398);
            this.txtremarks.Name = "txtremarks";
            this.txtremarks.Size = new System.Drawing.Size(242, 101);
            this.txtremarks.TabIndex = 13;
            this.txtremarks.Text = "";
            // 
            // txtstatus
            // 
            this.txtstatus.FormattingEnabled = true;
            this.txtstatus.Location = new System.Drawing.Point(21, 328);
            this.txtstatus.Name = "txtstatus";
            this.txtstatus.Size = new System.Drawing.Size(218, 24);
            this.txtstatus.TabIndex = 12;
            this.txtstatus.SelectedIndexChanged += new System.EventHandler(this.txtstatus_SelectedIndexChanged);
            // 
            // txtteacher
            // 
            this.txtteacher.FormattingEnabled = true;
            this.txtteacher.Location = new System.Drawing.Point(21, 188);
            this.txtteacher.Name = "txtteacher";
            this.txtteacher.Size = new System.Drawing.Size(218, 24);
            this.txtteacher.TabIndex = 11;
            this.txtteacher.SelectedIndexChanged += new System.EventHandler(this.txtteacher_SelectedIndexChanged);
            // 
            // txtsubject
            // 
            this.txtsubject.FormattingEnabled = true;
            this.txtsubject.Location = new System.Drawing.Point(21, 258);
            this.txtsubject.Name = "txtsubject";
            this.txtsubject.Size = new System.Drawing.Size(218, 24);
            this.txtsubject.TabIndex = 10;
            this.txtsubject.SelectedIndexChanged += new System.EventHandler(this.txtsubject_SelectedIndexChanged);
            // 
            // txtstudent
            // 
            this.txtstudent.FormattingEnabled = true;
            this.txtstudent.Location = new System.Drawing.Point(21, 118);
            this.txtstudent.Name = "txtstudent";
            this.txtstudent.Size = new System.Drawing.Size(218, 24);
            this.txtstudent.TabIndex = 8;
            this.txtstudent.SelectedIndexChanged += new System.EventHandler(this.txtstudent_SelectedIndexChanged);
            // 
            // txtdate
            // 
            this.txtdate.CustomFormat = "YYYY-MM-DD";
            this.txtdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtdate.Location = new System.Drawing.Point(24, 50);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(212, 22);
            this.txtdate.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txttid);
            this.panel2.Controls.Add(this.txtsubjectid);
            this.panel2.Controls.Add(this.txtstatusid);
            this.panel2.Controls.Add(this.txtsid);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(400, 99);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(884, 561);
            this.panel2.TabIndex = 8;
            // 
            // txttid
            // 
            this.txttid.AutoSize = true;
            this.txttid.Location = new System.Drawing.Point(34, 179);
            this.txttid.Name = "txttid";
            this.txttid.Size = new System.Drawing.Size(74, 17);
            this.txttid.TabIndex = 4;
            this.txttid.Text = "TeacherID";
            this.txttid.Visible = false;
            // 
            // txtsubjectid
            // 
            this.txtsubjectid.AutoSize = true;
            this.txtsubjectid.Location = new System.Drawing.Point(42, 226);
            this.txtsubjectid.Name = "txtsubjectid";
            this.txtsubjectid.Size = new System.Drawing.Size(68, 17);
            this.txtsubjectid.TabIndex = 3;
            this.txtsubjectid.Text = "SubjectID";
            this.txtsubjectid.Visible = false;
            // 
            // txtstatusid
            // 
            this.txtstatusid.AutoSize = true;
            this.txtstatusid.Location = new System.Drawing.Point(42, 280);
            this.txtstatusid.Name = "txtstatusid";
            this.txtstatusid.Size = new System.Drawing.Size(61, 17);
            this.txtstatusid.TabIndex = 2;
            this.txtstatusid.Text = "StatusID";
            this.txtstatusid.Visible = false;
            // 
            // txtsid
            // 
            this.txtsid.AutoSize = true;
            this.txtsid.Location = new System.Drawing.Point(42, 136);
            this.txtsid.Name = "txtsid";
            this.txtsid.Size = new System.Drawing.Size(70, 17);
            this.txtsid.TabIndex = 1;
            this.txtsid.Text = "StudentID";
            this.txtsid.Visible = false;
            this.txtsid.Click += new System.EventHandler(this.txtsid_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.SubmissionDate,
            this.Student,
            this.Teacher,
            this.Subject,
            this.Status,
            this.Remarks});
            this.dataGridView1.Location = new System.Drawing.Point(19, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(989, 493);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Visible = false;
            this.ID.Width = 125;
            // 
            // SubmissionDate
            // 
            this.SubmissionDate.HeaderText = "Submission Date";
            this.SubmissionDate.MinimumWidth = 6;
            this.SubmissionDate.Name = "SubmissionDate";
            this.SubmissionDate.Width = 125;
            // 
            // Student
            // 
            this.Student.HeaderText = "Student";
            this.Student.MinimumWidth = 6;
            this.Student.Name = "Student";
            this.Student.Width = 125;
            // 
            // Teacher
            // 
            this.Teacher.HeaderText = "Teacher";
            this.Teacher.MinimumWidth = 6;
            this.Teacher.Name = "Teacher";
            this.Teacher.Width = 125;
            // 
            // Subject
            // 
            this.Subject.HeaderText = "Subject";
            this.Subject.MinimumWidth = 6;
            this.Subject.Name = "Subject";
            this.Subject.Width = 125;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.Width = 125;
            // 
            // Remarks
            // 
            this.Remarks.HeaderText = "Remarks";
            this.Remarks.MinimumWidth = 6;
            this.Remarks.Name = "Remarks";
            this.Remarks.Width = 125;
            // 
            // txtid
            // 
            this.txtid.AutoSize = true;
            this.txtid.Location = new System.Drawing.Point(27, 43);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(21, 17);
            this.txtid.TabIndex = 9;
            this.txtid.Text = "ID";
            this.txtid.Visible = false;
            // 
            // txtassignmentID
            // 
            this.txtassignmentID.AutoSize = true;
            this.txtassignmentID.Location = new System.Drawing.Point(9, 79);
            this.txtassignmentID.Name = "txtassignmentID";
            this.txtassignmentID.Size = new System.Drawing.Size(94, 17);
            this.txtassignmentID.TabIndex = 10;
            this.txtassignmentID.Text = "AssignmentID";
            this.txtassignmentID.Visible = false;
            // 
            // Assignment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1310, 672);
            this.Controls.Add(this.txtassignmentID);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Assignment";
            this.Text = "Assignment";
            this.Load += new System.EventHandler(this.Assignment_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox txtremarks;
        private System.Windows.Forms.ComboBox txtstatus;
        private System.Windows.Forms.ComboBox txtteacher;
        private System.Windows.Forms.ComboBox txtsubject;
        private System.Windows.Forms.ComboBox txtstudent;
        private System.Windows.Forms.DateTimePicker txtdate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubmissionDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Student;
        private System.Windows.Forms.DataGridViewTextBoxColumn Teacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remarks;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label txtid;
        private System.Windows.Forms.Label txttid;
        private System.Windows.Forms.Label txtsubjectid;
        private System.Windows.Forms.Label txtstatusid;
        private System.Windows.Forms.Label txtsid;
        private System.Windows.Forms.Label txtassignmentID;
    }
}