//NOY ELBAZ 315073122
using System;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace HW2_NoyElbaz
{
    public partial class Form2 : Form
    {
        private DataClasses1DataContext DB = new DataClasses1DataContext();
        private string option = "";
        public dynamic QueryEx { get; set; }
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = DB.TblStudents.Select(s => s.Id + " " + s.Name).Distinct().OrderBy(id => id);
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void OK_Click(object sender, EventArgs e) 
        {
            if (option == "a")
            {
                int num = Int32.Parse(textBox1.Text);
                QueryEx = (
                          from c in DB.TblCourses
                          from k in DB.TblCourseLecturers
                          where k.LecturerId == num && c.Id == k.CourseId
                          select new { course = c.CourseName }).Distinct();
            }
            else if(option == "b")
            {
                int value = Int32.Parse(Regex.Match(comboBox1.Text, @"\d+").Value);
                QueryEx = (from stud in DB.TblStudents
                           from lec in DB.TblLecturers
                           from studWithLec in stud.TblLecturesStudents
                           where stud.Id == value && stud.Id == studWithLec.LecturerId
                           select new { name = lec.Name }).Distinct();
            }
            else if (option == "c")
            {
                QueryEx = (
                      from student in DB.TblStudents
                      from k in DB.TblStudents_Courses

                      where student.Id == k.StudentId
                      select new
                      {
                          id = student.Id,
                          name = student.Name,
                          num_courses = (from s in DB.TblStudents_Courses where s.StudentId == student.Id select s).Count()
                      }).Distinct();

            }
            else if (option == "d")
            {
                QueryEx = (from student in DB.TblStudents select new { student.Id, student.Name, Age = Age(student.Birthday) }).Distinct();
            }

            DialogResult = System.Windows.Forms.DialogResult.OK;
            Close();
        }

        private void A_Click(object sender, EventArgs e) // FINISH IT
        {
            option = "a";
            textBox1.Text = "Please Enter Lecturer Id here...";
            textBox1.SelectAll();
            textBox1.Enabled = true;
            try
            {
                int input = Int32.Parse(textBox1.Text);
            }
            catch
            {
                Console.WriteLine("error");
            }     
        }

        private void B_Click(object sender, EventArgs e)
        {
            option = "b";
            QueryEx = (from student in DB.TblStudents select new { student.Name }).Distinct();
        }
        private void C_Click(object sender, EventArgs e) 
        {
            option = "c";   
        }
        private void D_Click(object sender, EventArgs e)
        {
            option = "d";           
        }
        public int Age(DateTime date)
        {
            return DateTime.Today.Year - date.Year;
        }
    }
}
