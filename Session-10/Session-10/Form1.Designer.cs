﻿namespace Session_10 {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.grvStudents = new System.Windows.Forms.DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUndergraduate = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colGender = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colUniversity = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colShowID = new System.Windows.Forms.DataGridViewButtonColumn();
            this.bsStudents = new System.Windows.Forms.BindingSource(this.components);
            this.btnOK = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.grvSchedule = new System.Windows.Forms.DataGridView();
            this.ProfessorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calendar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UniversiyID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.universityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grvCourse = new System.Windows.Forms.DataGridView();
            this.universityBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.grvGrade = new System.Windows.Forms.DataGridView();
            this.labSchedule = new System.Windows.Forms.Label();
            this.labCourses = new System.Windows.Forms.Label();
            this.labGrades = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.CourID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentGrade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UniID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UniversID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grvStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvSchedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvCourse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvGrade)).BeginInit();
            this.SuspendLayout();
            // 
            // grvStudents
            // 
            this.grvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colSurname,
            this.colAge,
            this.colUndergraduate,
            this.colGender,
            this.colUniversity,
            this.colShowID});
            this.grvStudents.Location = new System.Drawing.Point(12, 60);
            this.grvStudents.Name = "grvStudents";
            this.grvStudents.RowTemplate.Height = 25;
            this.grvStudents.Size = new System.Drawing.Size(776, 95);
            this.grvStudents.TabIndex = 0;
            // 
            // colName
            // 
            this.colName.DataPropertyName = "Name";
            this.colName.HeaderText = "Name";
            this.colName.Name = "colName";
            this.colName.Width = 120;
            // 
            // colSurname
            // 
            this.colSurname.DataPropertyName = "Surname";
            this.colSurname.HeaderText = "Surname";
            this.colSurname.Name = "colSurname";
            this.colSurname.Width = 200;
            // 
            // colAge
            // 
            this.colAge.DataPropertyName = "Age";
            this.colAge.HeaderText = "Age";
            this.colAge.Name = "colAge";
            this.colAge.Width = 60;
            // 
            // colUndergraduate
            // 
            this.colUndergraduate.DataPropertyName = "Undergraduate";
            this.colUndergraduate.HeaderText = "Undergraduate";
            this.colUndergraduate.Name = "colUndergraduate";
            // 
            // colGender
            // 
            this.colGender.DataPropertyName = "Gender";
            this.colGender.HeaderText = "Gender";
            this.colGender.Name = "colGender";
            this.colGender.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colGender.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colUniversity
            // 
            this.colUniversity.DataPropertyName = "UniversityID";
            this.colUniversity.HeaderText = "University";
            this.colUniversity.Name = "colUniversity";
            // 
            // colShowID
            // 
            this.colShowID.HeaderText = "";
            this.colShowID.Name = "colShowID";
            this.colShowID.Text = "Show ID";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(103, 31);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(119, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(12, 31);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(85, 23);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // grvSchedule
            // 
            this.grvSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvSchedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProfessorID,
            this.CourseID,
            this.Calendar,
            this.UniversiyID});
            this.grvSchedule.Location = new System.Drawing.Point(12, 182);
            this.grvSchedule.Name = "grvSchedule";
            this.grvSchedule.RowTemplate.Height = 25;
            this.grvSchedule.Size = new System.Drawing.Size(776, 77);
            this.grvSchedule.TabIndex = 3;
            this.grvSchedule.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvSchedule_CellContentClick);
            // 
            // ProfessorID
            // 
            this.ProfessorID.DataPropertyName = "ProfessorID";
            this.ProfessorID.HeaderText = "Professor ID";
            this.ProfessorID.Name = "ProfessorID";
            // 
            // CourseID
            // 
            this.CourseID.DataPropertyName = "CourseID";
            this.CourseID.HeaderText = "CourseID";
            this.CourseID.Name = "CourseID";
            // 
            // Calendar
            // 
            this.Calendar.DataPropertyName = "Calendar";
            this.Calendar.HeaderText = "Calendar Date";
            this.Calendar.Name = "Calendar";
            // 
            // UniversiyID
            // 
            this.UniversiyID.DataPropertyName = "UniversityID";
            this.UniversiyID.HeaderText = "University";
            this.UniversiyID.Name = "UniversiyID";
            // 
            // universityBindingSource
            // 
            this.universityBindingSource.DataSource = typeof(Session_10.University);
            // 
            // grvCourse
            // 
            this.grvCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvCourse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Code,
            this.Subject,
            this.UniversID});
            this.grvCourse.Location = new System.Drawing.Point(12, 288);
            this.grvCourse.Name = "grvCourse";
            this.grvCourse.RowTemplate.Height = 25;
            this.grvCourse.Size = new System.Drawing.Size(776, 86);
            this.grvCourse.TabIndex = 4;
            this.grvCourse.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvCourse_CellContentClick);
            // 
            // universityBindingSource1
            // 
            this.universityBindingSource1.DataSource = typeof(Session_10.University);
            // 
            // grvGrade
            // 
            this.grvGrade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvGrade.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CourID,
            this.StudID,
            this.StudentGrade,
            this.UniID});
            this.grvGrade.Location = new System.Drawing.Point(12, 407);
            this.grvGrade.Name = "grvGrade";
            this.grvGrade.RowTemplate.Height = 25;
            this.grvGrade.Size = new System.Drawing.Size(776, 86);
            this.grvGrade.TabIndex = 5;
            // 
            // labSchedule
            // 
            this.labSchedule.AutoSize = true;
            this.labSchedule.Location = new System.Drawing.Point(12, 164);
            this.labSchedule.Name = "labSchedule";
            this.labSchedule.Size = new System.Drawing.Size(86, 15);
            this.labSchedule.TabIndex = 6;
            this.labSchedule.Text = "grrid Schedule ";
            this.labSchedule.Click += new System.EventHandler(this.label1_Click);
            // 
            // labCourses
            // 
            this.labCourses.AutoSize = true;
            this.labCourses.Location = new System.Drawing.Point(12, 270);
            this.labCourses.Name = "labCourses";
            this.labCourses.Size = new System.Drawing.Size(73, 15);
            this.labCourses.TabIndex = 7;
            this.labCourses.Text = "grid Courses";
            this.labCourses.Click += new System.EventHandler(this.labCourses_Click);
            // 
            // labGrades
            // 
            this.labGrades.AutoSize = true;
            this.labGrades.Location = new System.Drawing.Point(12, 389);
            this.labGrades.Name = "labGrades";
            this.labGrades.Size = new System.Drawing.Size(67, 15);
            this.labGrades.TabIndex = 8;
            this.labGrades.Text = "grid Grades";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(794, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 28);
            this.button1.TabIndex = 9;
            this.button1.Text = "End Edit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(794, 231);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 28);
            this.button2.TabIndex = 10;
            this.button2.Text = "End Edit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(794, 346);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 28);
            this.button3.TabIndex = 11;
            this.button3.Text = "End Edit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(794, 465);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(109, 28);
            this.button4.TabIndex = 12;
            this.button4.Text = "End Edit";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(794, 202);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(85, 23);
            this.button5.TabIndex = 13;
            this.button5.Text = "Refresh";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(794, 317);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(85, 23);
            this.button6.TabIndex = 14;
            this.button6.Text = "Refresh";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(794, 436);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(85, 23);
            this.button7.TabIndex = 15;
            this.button7.Text = "Refresh";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // CourID
            // 
            this.CourID.DataPropertyName = "CourID";
            this.CourID.HeaderText = "Course ID";
            this.CourID.Name = "CourID";
            this.CourID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // StudID
            // 
            this.StudID.DataPropertyName = "StudID";
            this.StudID.HeaderText = "Student ID";
            this.StudID.Name = "StudID";
            // 
            // StudentGrade
            // 
            this.StudentGrade.DataPropertyName = "StudentGrade";
            this.StudentGrade.HeaderText = "Grade";
            this.StudentGrade.Name = "StudentGrade";
            this.StudentGrade.Width = 50;
            // 
            // UniID
            // 
            this.UniID.DataPropertyName = "UniID";
            this.UniID.HeaderText = "University";
            this.UniID.Name = "UniID";
            this.UniID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.UniID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Code
            // 
            this.Code.DataPropertyName = "Code";
            this.Code.HeaderText = "Course Code";
            this.Code.Name = "Code";
            // 
            // Subject
            // 
            this.Subject.DataPropertyName = "Subject";
            this.Subject.HeaderText = "Course Subject";
            this.Subject.Name = "Subject";
            this.Subject.Width = 200;
            // 
            // UniversID
            // 
            this.UniversID.DataPropertyName = "UniversID";
            this.UniversID.HeaderText = "University";
            this.UniversID.Name = "UniversID";
            this.UniversID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.UniversID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1351, 505);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labGrades);
            this.Controls.Add(this.labCourses);
            this.Controls.Add(this.labSchedule);
            this.Controls.Add(this.grvGrade);
            this.Controls.Add(this.grvCourse);
            this.Controls.Add(this.grvSchedule);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.grvStudents);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvSchedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvCourse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvGrade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView grvStudents;
        private Button btnOK;
        private Button btnRefresh;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colSurname;
        private DataGridViewTextBoxColumn colAge;
        private DataGridViewCheckBoxColumn colUndergraduate;
        private DataGridViewComboBoxColumn colGender;
        private DataGridViewComboBoxColumn colUniversity;
        private DataGridViewButtonColumn colShowID;
        private BindingSource bsStudents;
        private DataGridView grvSchedule;
        private DataGridView grvCourse;
        private DataGridView grvGrade;
        private Label labSchedule;
        private Label labCourses;
        private Label labGrades;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private DataGridViewTextBoxColumn ProfessorID;
        private DataGridViewTextBoxColumn CourseID;
        private DataGridViewTextBoxColumn Calendar;
        private DataGridViewComboBoxColumn UniversiyID;
        private BindingSource universityBindingSource;
        private BindingSource universityBindingSource1;
        private DataGridViewTextBoxColumn CourID;
        private DataGridViewTextBoxColumn StudID;
        private DataGridViewTextBoxColumn StudentGrade;
        private DataGridViewComboBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn Code;
        private DataGridViewTextBoxColumn Subject;
        private DataGridViewComboBoxColumn UniversityID;
        private DataGridViewComboBoxColumn DataGridViewComboBoxColumn;
        private DataGridViewComboBoxColumn UniID;
        private DataGridViewComboBoxColumn UniversID;
    }
}