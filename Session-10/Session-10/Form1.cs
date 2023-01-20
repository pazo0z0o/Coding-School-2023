
using System.Windows.Forms;
using ClassLib_Session_10;

namespace Session_10 {
    public partial class Form1 : Form {

        List<Student> students;
        //List<Schedule> sched;

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

            SetControlProperties();
            PopulateStudents();
            PopulateSchedule();
            PopulateCourses();
            PopulateGrades();
        }
        private void PopulateSchedule()
        {
            List<University> unis = GetUniversities();
            grvSchedule.AutoGenerateColumns = false; 
            List<Schedule> schedule = new List<Schedule>();

            Schedule sched1= new Schedule()
            {
                UniversityID = unis[0].ID
            };
            schedule.Add(sched1);

            Schedule sched2 = new Schedule()
            {
                UniversityID = unis[0].ID
            };
            schedule.Add(sched2);

            grvSchedule.DataSource= schedule;
           // grvSchedule.AutoGenerateColumns = false;
        }
      
        private void PopulateGrades()
        {
            List<University> unis= GetUniversities();
            grvGrade.AutoGenerateColumns = false;
            List<Grade> grade = new List<Grade>();

            Grade grade1 = new Grade()
            {               
                StudentGrade= 10,
                UniID = unis[0].ID
            };
            grade.Add(grade1);
           
            Grade grade2 = new Grade()
            {               
                StudentGrade = 7,
                UniID = unis[1].ID
            };
            grade.Add(grade2);

            grvGrade.DataSource = grade;
           // grvGrade.AutoGenerateColumns = false;
        }


        private void PopulateCourses() 
        {
            List<University> unis = GetUniversities();
            grvCourse.AutoGenerateColumns = false;
            List<Course> courses = new List<Course>();

            Course cour1 = new Course()
            {
                Code = "mth1",
                Subject = "Applied Math 1",
                UniversID = unis[0].ID
            };
            courses.Add(cour1);

            Course cour2 = new Course()
            {               
                Code = "Tele1",
                Subject = "Telecom 1",
                UniversID = unis[1].ID
            };
            courses.Add(cour2);
        
            grvCourse.DataSource = courses; // grabs  elements of list courses- just visually
            //
        }


        private void PopulateStudents() {

            List<University> unis = GetUniversities();

            students = new List<Student>();

            Student student1 = new Student() {
                Name = "Dimitris",
                Surname = "Raptodimos",
                Gender = Student.GenderEnum.Male,
                Age = 40,
                Undergraduate = false,
                UniversityID = unis[0].ID
            };
            students.Add(student1);

            Student student2 = new Student() {
                Name = "Fotis",
                Surname = "Chrysoulas",
                Gender = Student.GenderEnum.Male,
                Age = 44,
                Undergraduate = true,
                UniversityID = unis[1].ID
            };
            students.Add(student2);


            bsStudents.DataSource = students;


            //Student student2 = new Student() {
            //    Name = "Dimitris",
            //    Surname = "Raptodimos",
            //    Gender = Student.GenderEnum.Male,
            //    Age = 40,
            //    Undergraduate = false
            //};

            //List<Student> students2 = new List<Student>() {
            //   student2
            //};

        }

        private List<University> GetUniversities() {


            Guid id = Guid.Parse("{72F9974A-370C-4FCE-AD99-9A73FC089E60}");

            University uni1 = new University(id) {
                Name = "NTUA",
                Region = "Athens"
            };

            id = Guid.Parse("{D3DB7E60-9BDA-41F3-9FDE-A39C77FE03A9}");
            University uni2 = new University(id) {
                Name = "UNIPI",
                Region = "Peiraeus"
            };

            University uni3 = new University(Guid.Empty) {
            };

            List<University> universities = new List<University>() { uni1, uni2, uni3 };
            return universities;
        }

        private void SetControlProperties() {

            grvStudents.AutoGenerateColumns = false;
            grvStudents.DataSource = bsStudents;

            DataGridViewComboBoxColumn colGender = grvStudents.Columns["colGender"] as DataGridViewComboBoxColumn;
            colGender.Items.Add(Student.GenderEnum.Male);
            colGender.Items.Add(Student.GenderEnum.Female);
            colGender.Items.Add(Student.GenderEnum.Other);

            DataGridViewComboBoxColumn colUniversity1 = grvStudents.Columns["colUniversity"] as DataGridViewComboBoxColumn;
            colUniversity1.DataSource = GetUniversities();
            colUniversity1.DisplayMember = "Name";
            colUniversity1.ValueMember = "ID";

            DataGridViewComboBoxColumn UniversityIDSched = grvSchedule.Columns["UniversiyID"] as DataGridViewComboBoxColumn;
            UniversityIDSched.DataSource = GetUniversities();
            UniversityIDSched.DisplayMember = "Name";
            UniversityIDSched.ValueMember = "ID";

            DataGridViewComboBoxColumn UniversityIDCourse = grvCourse.Columns["UniversID"] as DataGridViewComboBoxColumn;
            UniversityIDCourse.DataSource = GetUniversities();
            UniversityIDCourse.DisplayMember = "Name";
            UniversityIDCourse.ValueMember = "ID";

            DataGridViewComboBoxColumn UniversityIDGrade = grvGrade.Columns["UniID"] as DataGridViewComboBoxColumn;
            UniversityIDGrade.DataSource = GetUniversities();
            UniversityIDGrade.DisplayMember = "Name";
            UniversityIDGrade.ValueMember = "ID";
            
            grvStudents.CellContentClick += GrvStudents_CellContentClick;



        }

        private void GrvStudents_CellContentClick(object? sender, DataGridViewCellEventArgs e) {

            var grv = (DataGridView)sender;


            DataGridViewButtonColumn col = grv.Columns[e.ColumnIndex] as DataGridViewButtonColumn;

            if (col != null && col.Name == "colShowID" && e.RowIndex >= 0) {
                Student student = grv.CurrentRow.DataBoundItem as Student;
                MessageBox.Show($"The ID of student {student.Surname} {student.Name} is {student.ID}");
            }
        }


        Serializer serializer = new Serializer();
        /*serializer.SerializeToFile(university, "test.json");
        university = serializer.Deserialize<University>("test.json");*/

        private void btnRefresh_Click(object sender, EventArgs e) {
            PopulateStudents();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labCourses_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            grvStudents.EndEdit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            grvSchedule.EndEdit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            grvCourse.EndEdit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            grvGrade.EndEdit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PopulateSchedule();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            PopulateCourses();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            PopulateGrades();
        }

        private void grvCourse_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grvSchedule_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}