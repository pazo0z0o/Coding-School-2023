namespace Session_10
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.grvStudents = new System.Windows.Forms.DataGridView();
            this.registrationNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.universityIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUniversity = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bsStudents = new System.Windows.Forms.BindingSource(this.components);
            this.grvCourses = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsCourses = new System.Windows.Forms.BindingSource(this.components);
            this.grvGrades = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCourseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stud_Name = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Cour_Sub = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.studentGradeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsGrades = new System.Windows.Forms.BindingSource(this.components);
            this.grvSchedule = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.professorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calendarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UniversityID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bsSchedule = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.ScheduleEnd = new System.Windows.Forms.Button();
            this.StudEnd = new System.Windows.Forms.Button();
            this.CourseEnd = new System.Windows.Forms.Button();
            this.GradesEnd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grvStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvCourses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCourses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvGrades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsGrades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvSchedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSchedule)).BeginInit();
            this.SuspendLayout();
            // 
            // grvStudents
            // 
            this.grvStudents.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.grvStudents.AutoGenerateColumns = false;
            this.grvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.registrationNumberDataGridViewTextBoxColumn,
            this.universityIDDataGridViewTextBoxColumn,
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.colUniversity});
            this.grvStudents.DataSource = this.bsStudents;
            this.grvStudents.Location = new System.Drawing.Point(37, 62);
            this.grvStudents.Name = "grvStudents";
            this.grvStudents.RowTemplate.Height = 25;
            this.grvStudents.Size = new System.Drawing.Size(895, 95);
            this.grvStudents.TabIndex = 0;
            // 
            // registrationNumberDataGridViewTextBoxColumn
            // 
            this.registrationNumberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.registrationNumberDataGridViewTextBoxColumn.DataPropertyName = "RegistrationNumber";
            this.registrationNumberDataGridViewTextBoxColumn.HeaderText = "Reg. #";
            this.registrationNumberDataGridViewTextBoxColumn.Name = "registrationNumberDataGridViewTextBoxColumn";
            this.registrationNumberDataGridViewTextBoxColumn.Width = 65;
            // 
            // universityIDDataGridViewTextBoxColumn
            // 
            this.universityIDDataGridViewTextBoxColumn.DataPropertyName = "UniversityID";
            this.universityIDDataGridViewTextBoxColumn.HeaderText = "UniversityID";
            this.universityIDDataGridViewTextBoxColumn.Name = "universityIDDataGridViewTextBoxColumn";
            this.universityIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            // 
            // colUniversity
            // 
            this.colUniversity.DataPropertyName = "UniversityID";
            this.colUniversity.HeaderText = "University";
            this.colUniversity.Name = "colUniversity";
            // 
            // bsStudents
            // 
            this.bsStudents.DataSource = typeof(Lib.Student);
            // 
            // grvCourses
            // 
            this.grvCourses.AutoGenerateColumns = false;
            this.grvCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvCourses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn1,
            this.codeDataGridViewTextBoxColumn,
            this.subjectDataGridViewTextBoxColumn});
            this.grvCourses.DataSource = this.bsCourses;
            this.grvCourses.Location = new System.Drawing.Point(37, 247);
            this.grvCourses.Name = "grvCourses";
            this.grvCourses.RowTemplate.Height = 25;
            this.grvCourses.Size = new System.Drawing.Size(716, 91);
            this.grvCourses.TabIndex = 1;
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            this.iDDataGridViewTextBoxColumn1.Visible = false;
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "Code";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            // 
            // subjectDataGridViewTextBoxColumn
            // 
            this.subjectDataGridViewTextBoxColumn.DataPropertyName = "Subject";
            this.subjectDataGridViewTextBoxColumn.HeaderText = "Subject";
            this.subjectDataGridViewTextBoxColumn.Name = "subjectDataGridViewTextBoxColumn";
            // 
            // bsCourses
            // 
            this.bsCourses.DataSource = typeof(Lib.Course);
            // 
            // grvGrades
            // 
            this.grvGrades.AutoGenerateColumns = false;
            this.grvGrades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvGrades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn3,
            this.colCourseID,
            this.colStudentID,
            this.Stud_Name,
            this.Cour_Sub,
            this.studentGradeDataGridViewTextBoxColumn1});
            this.grvGrades.DataSource = this.bsGrades;
            this.grvGrades.Location = new System.Drawing.Point(37, 408);
            this.grvGrades.Name = "grvGrades";
            this.grvGrades.RowTemplate.Height = 25;
            this.grvGrades.Size = new System.Drawing.Size(716, 94);
            this.grvGrades.TabIndex = 2;
            // 
            // iDDataGridViewTextBoxColumn3
            // 
            this.iDDataGridViewTextBoxColumn3.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn3.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn3.Name = "iDDataGridViewTextBoxColumn3";
            this.iDDataGridViewTextBoxColumn3.Visible = false;
            // 
            // colCourseID
            // 
            this.colCourseID.DataPropertyName = "CourseID";
            this.colCourseID.HeaderText = "CourseID";
            this.colCourseID.Name = "colCourseID";
            this.colCourseID.Visible = false;
            // 
            // colStudentID
            // 
            this.colStudentID.DataPropertyName = "StudentID";
            this.colStudentID.HeaderText = "StudentID";
            this.colStudentID.Name = "colStudentID";
            this.colStudentID.Visible = false;
            // 
            // Stud_Name
            // 
            this.Stud_Name.DataPropertyName = "StudentID";
            this.Stud_Name.DataSource = this.bsStudents;
            this.Stud_Name.DisplayMember = "Name";
            this.Stud_Name.HeaderText = "Student Name";
            this.Stud_Name.Name = "Stud_Name";
            this.Stud_Name.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Stud_Name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Stud_Name.ValueMember = "ID";
            this.Stud_Name.Width = 200;
            // 
            // Cour_Sub
            // 
            this.Cour_Sub.DataPropertyName = "CourseID";
            this.Cour_Sub.DataSource = this.bsCourses;
            this.Cour_Sub.DisplayMember = "Subject";
            this.Cour_Sub.HeaderText = "Subject";
            this.Cour_Sub.Name = "Cour_Sub";
            this.Cour_Sub.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Cour_Sub.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Cour_Sub.ValueMember = "ID";
            this.Cour_Sub.Width = 200;
            // 
            // studentGradeDataGridViewTextBoxColumn1
            // 
            this.studentGradeDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.studentGradeDataGridViewTextBoxColumn1.DataPropertyName = "StudentGrade";
            this.studentGradeDataGridViewTextBoxColumn1.HeaderText = "Student Grade";
            this.studentGradeDataGridViewTextBoxColumn1.Name = "studentGradeDataGridViewTextBoxColumn1";
            this.studentGradeDataGridViewTextBoxColumn1.Width = 107;
            // 
            // bsGrades
            // 
            this.bsGrades.DataSource = typeof(Lib.Grade);
            // 
            // grvSchedule
            // 
            this.grvSchedule.AutoGenerateColumns = false;
            this.grvSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvSchedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn2,
            this.courseIDDataGridViewTextBoxColumn,
            this.professorIDDataGridViewTextBoxColumn,
            this.calendarDataGridViewTextBoxColumn,
            this.UniversityID});
            this.grvSchedule.DataSource = this.bsSchedule;
            this.grvSchedule.Location = new System.Drawing.Point(37, 613);
            this.grvSchedule.Name = "grvSchedule";
            this.grvSchedule.RowTemplate.Height = 25;
            this.grvSchedule.Size = new System.Drawing.Size(716, 93);
            this.grvSchedule.TabIndex = 3;
            // 
            // iDDataGridViewTextBoxColumn2
            // 
            this.iDDataGridViewTextBoxColumn2.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn2.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn2.Name = "iDDataGridViewTextBoxColumn2";
            this.iDDataGridViewTextBoxColumn2.Visible = false;
            // 
            // courseIDDataGridViewTextBoxColumn
            // 
            this.courseIDDataGridViewTextBoxColumn.DataPropertyName = "CourseID";
            this.courseIDDataGridViewTextBoxColumn.DataSource = this.bsCourses;
            this.courseIDDataGridViewTextBoxColumn.DisplayMember = "Subject";
            this.courseIDDataGridViewTextBoxColumn.HeaderText = "CourseID";
            this.courseIDDataGridViewTextBoxColumn.Name = "courseIDDataGridViewTextBoxColumn";
            this.courseIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.courseIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.courseIDDataGridViewTextBoxColumn.ValueMember = "ID";
            // 
            // professorIDDataGridViewTextBoxColumn
            // 
            this.professorIDDataGridViewTextBoxColumn.DataPropertyName = "ProfessorID";
            this.professorIDDataGridViewTextBoxColumn.HeaderText = "ProfessorID";
            this.professorIDDataGridViewTextBoxColumn.Name = "professorIDDataGridViewTextBoxColumn";
            this.professorIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // calendarDataGridViewTextBoxColumn
            // 
            this.calendarDataGridViewTextBoxColumn.DataPropertyName = "Calendar";
            this.calendarDataGridViewTextBoxColumn.HeaderText = "Calendar";
            this.calendarDataGridViewTextBoxColumn.Name = "calendarDataGridViewTextBoxColumn";
            // 
            // UniversityID
            // 
            this.UniversityID.DataPropertyName = "UniversityID";
            this.UniversityID.HeaderText = "University";
            this.UniversityID.Name = "UniversityID";
            this.UniversityID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.UniversityID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // bsSchedule
            // 
            this.bsSchedule.DataSource = typeof(Lib.Schedule);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Students";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Courses";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 390);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Grades";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 595);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Schedule";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(107, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(107, 221);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Refresh";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(107, 382);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Refresh";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(107, 584);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 11;
            this.button4.Text = "Refresh";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(759, 437);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 13;
            this.button6.Text = "Load";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(759, 408);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 14;
            this.button7.Text = "Save";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(938, 62);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 16;
            this.button8.Text = "Save";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(938, 91);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 15;
            this.button9.Text = "Load";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(759, 247);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 18;
            this.button10.Text = "Save";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(759, 276);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 23);
            this.button11.TabIndex = 17;
            this.button11.Text = "Load";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(759, 613);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 24);
            this.button5.TabIndex = 20;
            this.button5.Text = "Save";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(759, 642);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 24);
            this.button12.TabIndex = 19;
            this.button12.Text = "Load";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // ScheduleEnd
            // 
            this.ScheduleEnd.Location = new System.Drawing.Point(759, 683);
            this.ScheduleEnd.Name = "ScheduleEnd";
            this.ScheduleEnd.Size = new System.Drawing.Size(75, 23);
            this.ScheduleEnd.TabIndex = 21;
            this.ScheduleEnd.Text = "End Edit";
            this.ScheduleEnd.UseVisualStyleBackColor = true;
            this.ScheduleEnd.Click += new System.EventHandler(this.button13_Click);
            // 
            // StudEnd
            // 
            this.StudEnd.Location = new System.Drawing.Point(938, 134);
            this.StudEnd.Name = "StudEnd";
            this.StudEnd.Size = new System.Drawing.Size(75, 23);
            this.StudEnd.TabIndex = 22;
            this.StudEnd.Text = "End Edit";
            this.StudEnd.UseVisualStyleBackColor = true;
            this.StudEnd.Click += new System.EventHandler(this.StudEnd_Click);
            // 
            // CourseEnd
            // 
            this.CourseEnd.Location = new System.Drawing.Point(759, 315);
            this.CourseEnd.Name = "CourseEnd";
            this.CourseEnd.Size = new System.Drawing.Size(75, 23);
            this.CourseEnd.TabIndex = 23;
            this.CourseEnd.Text = "End Edit";
            this.CourseEnd.UseVisualStyleBackColor = true;
            this.CourseEnd.Click += new System.EventHandler(this.button15_Click);
            // 
            // GradesEnd
            // 
            this.GradesEnd.Location = new System.Drawing.Point(759, 479);
            this.GradesEnd.Name = "GradesEnd";
            this.GradesEnd.Size = new System.Drawing.Size(75, 23);
            this.GradesEnd.TabIndex = 24;
            this.GradesEnd.Text = "End Edit";
            this.GradesEnd.UseVisualStyleBackColor = true;
            this.GradesEnd.Click += new System.EventHandler(this.GradesEnd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1522, 864);
            this.Controls.Add(this.GradesEnd);
            this.Controls.Add(this.CourseEnd);
            this.Controls.Add(this.StudEnd);
            this.Controls.Add(this.ScheduleEnd);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grvSchedule);
            this.Controls.Add(this.grvGrades);
            this.Controls.Add(this.grvCourses);
            this.Controls.Add(this.grvStudents);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvCourses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCourses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvGrades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsGrades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvSchedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSchedule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView grvStudents;
        private DataGridView grvCourses;
        private DataGridView grvGrades;
        private DataGridView grvSchedule;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button5;
        private Button button12;
        private BindingSource bsStudents;
        private BindingSource bsCourses;
        private BindingSource bsGrades;
        private BindingSource bsSchedule;
        private Button ScheduleEnd;
        private Button StudEnd;
        private Button CourseEnd;
        private Button GradesEnd;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn subjectDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn universityIDDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn registrationNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn universityIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn colUniversity;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn colCourseID;
        private DataGridViewTextBoxColumn colStudentID;
        private DataGridViewComboBoxColumn Stud_Name;
        private DataGridViewComboBoxColumn Cour_Sub;
        private DataGridViewTextBoxColumn studentGradeDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn2;
        private DataGridViewComboBoxColumn courseIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn professorIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn calendarDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn UniversityID;
    }
}