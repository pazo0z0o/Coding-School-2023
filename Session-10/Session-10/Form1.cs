using Lib;
using Microsoft.VisualBasic.Devices;
using System.Collections.Generic;
using System.Diagnostics;

namespace Session_10
{
    public partial class Form1 : Form
    {
        private List<Student>? _formStudents;
        private List<Course>? _formCourses;
        private List<Schedule>? _formScheduledCourse;
        private List<Grade>? _formGrades;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            PopulateStudents();
            PopulateCourses();
            GetStudents();  // Called here to solve some null reference issues with _formStudents
            GetCourses();  // Same: for _formCourses
            PopulateSchedule();
            PopulateGrades();
            SetControlProperties();

        }

        private void PopulateStudents()
        {
            List<University> unis = GetUniversities();

            Guid id = Guid.Parse("{D81AFE51-BCC0-4ADB-886E-952385A70098} ");
            Student stud1 = new Student()
            {
                RegistrationNumber = 1,
                ID = id,
                Name = "Kosmas Stamos",
                Age = 32,
                UniversityID = unis[0].ID
            };
            id = Guid.Parse("{19C62019-ADC6-41EC-958E-AF0A5482384E}");
            Student stud2 = new Student()
            {
                RegistrationNumber = 2,
                ID = id,
                Name = "Peter Ofori-Quaye",
                Age = 18,
                UniversityID = unis[1].ID
            };
            List<Student> Students = new List<Student>() { stud1, stud2 };
            _formStudents = Students; //round about way, to bypass object property restrictions
        
        bsStudents.DataSource = _formStudents;
        
        }
        

        private void PopulateCourses()
        {
            Guid id = Guid.Parse("{5A3DE839-C51E-4783-96FB-F7F192AA30F1} ");
            Course cour1 = new Course()
            {
                ID = id,
                Code = "MTH-1",
                Subject = "Applied Math-1"
            };

            id = Guid.Parse("{CBAA71F8-1202-4E2F-8250-E25BF15A7AD0}");
            Course cour2 = new Course()
            {
                ID = id,
                Code = "MTH-2",
                Subject = "Applied Math-2"
            };
            List<Course> Courses = new List<Course>() { cour1, cour2 };
            _formCourses = Courses;
            //round about way, to bypass object property restrictions
            bsCourses.DataSource = _formCourses;
        }
        private void PopulateGrades()
        {
            List<Student> pupil = _formStudents;   
            List<Course> lesson = _formCourses;

            Guid id = Guid.Parse("{3B407F08-DB94-4F02-A717-1BF6BE1B3B99} ");
            //  Guid StudID = 
            Grade gradeStud1 = new Grade()
            {
                ID = id,
                StudentID = pupil[0].ID,
                CourseID = lesson[0].ID,
                StudentGrade = 10
            };
            id = Guid.Parse("{5221E96A-34A6-4852-AA19-FCBC93EDEFBC}");
            Grade gradeStud2 = new Grade()
            {
                ID = id,
                StudentID = pupil[1].ID,
                CourseID = lesson[1].ID,
                StudentGrade = 7
            };
            //round about way, to bypass object property restrictions
            List<Grade> Grades = new List<Grade>(){ gradeStud1, gradeStud2 };
            _formGrades = Grades ;

           bsGrades.DataSource = _formGrades;
        }

        private void PopulateSchedule()
        {
            List<University> unis = GetUniversities();
            List<Course> pupil = _formCourses;

            Guid Sid = Guid.Parse("{F1A0C8E7-31FF-48A9-BB8A-B03000E1FAD8} ");
            Guid ProfID = Guid.Parse("{EAC4E63B-6FA0-43CA-A44D-4537071E127F}");

            Schedule schedule1 = new Schedule()
            {
                ID = Sid,
                ProfessorID = ProfID,
                CourseID = pupil[0].ID,
                Calendar = DateTime.Now,
                UniversityID = unis[0].ID
            };

            Sid = Guid.Parse("{76170444-B7D3-4B85-A0D4-1A9E92D48A76}");
            ProfID = Guid.Parse("{4818139F-7A50-400C-8E91-EB75325FC499}");

            Schedule schedule2 = new Schedule()
            {
                ID = Sid,
                ProfessorID = ProfID,
                CourseID = pupil[1].ID,
                Calendar = DateTime.Now,
                UniversityID = unis[1].ID
            };
            //round about way, to bypass object property restrictions
            List<Schedule> ScheduledCour = new List<Schedule>() { schedule1, schedule2 };
            _formScheduledCourse = ScheduledCour;

            bsSchedule.DataSource = ScheduledCour;
        }

        private List<University> GetUniversities()
        {
            Guid id = Guid.Parse("{72F9974A-370C-4FCE-AD99-9A73FC089E60}");
            University uni1 = new University()
            {
                ID = id,
                Name = "UoWM",
                YearsInService = 20
            };

            id = Guid.Parse("{D3DB7E60-9BDA-41F3-9FDE-A39C77FE03A9}");
            University uni2 = new University()
            {
                ID = id,
                Name = "AUTH",
                YearsInService = 70
            };

            University uni3 = new University()
            {
            };

            List<University> universities = new List<University>() { uni1, uni2, uni3 };
            return universities;
        }

        private List<Student> GetStudents()
        {   

            List<Student> studs = new List<Student>();
            studs = _formStudents;
            return studs;
        }

        private List<Course> GetCourses()
        {
            List<Course> cour = new List<Course>();
            cour = _formCourses;
            return cour;
        }

        /*private List<Schedule> GetSched(List<Schedule> schedCour)
        {
            List<Schedule> scheduledCourses = new List<Schedule>(schedCour);
            return scheduledCourses;
        }*/


        private void SetControlProperties()
        {
            grvSchedule.AutoGenerateColumns = false;
            grvStudents.AutoGenerateColumns = false;
            grvGrades.AutoGenerateColumns = false;
            grvCourses.AutoGenerateColumns = false;

            grvStudents.DataSource = bsStudents;
            grvGrades.DataSource = bsGrades;
            grvCourses.DataSource = bsCourses;
            grvSchedule.DataSource = bsSchedule;

            DataGridViewComboBoxColumn colUniversity = grvStudents.Columns["colUniversity"] as DataGridViewComboBoxColumn;
            colUniversity.DataSource = GetUniversities();
            colUniversity.DisplayMember = "Name";
            colUniversity.ValueMember = "ID";

            DataGridViewComboBoxColumn colUni2 = grvSchedule.Columns["UniversityID"] as DataGridViewComboBoxColumn;
            colUni2.DataSource = GetUniversities();
            colUni2.DisplayMember = "Name";
            colUni2.ValueMember = "ID";

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PopulateStudents();
        }

        private void button2_Click(object sender, EventArgs e)
        { 
            PopulateCourses();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PopulateGrades();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PopulateSchedule();         
        }

        private void button15_Click(object sender, EventArgs e)
        {
            grvCourses.EndEdit();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            grvSchedule.EndEdit();
        }

        private void StudEnd_Click(object sender, EventArgs e)
        {
            grvStudents.EndEdit();
        }

        private void GradesEnd_Click(object sender, EventArgs e)
        {
            grvGrades.EndEdit();
        }

        
    }
}