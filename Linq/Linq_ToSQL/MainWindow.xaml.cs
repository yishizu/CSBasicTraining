using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Configuration;
using Linq_ToSQL.TutorialsDBDataSetTableAdapters;

namespace Linq_ToSQL
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        LinqToSqlDataClassesDataContext dataContext;
        public MainWindow()
        {
            InitializeComponent();
          
            string connectionString = ConfigurationManager.ConnectionStrings["Linq_ToSQL.Properties.Settings.TutorialsDBConnectionString"].ConnectionString;
            dataContext = new LinqToSqlDataClassesDataContext(connectionString);
            //InsertUniversities();
            //InsertStudent();
            // InsertLectures(); 
            //nsertStudentLectureAssocions();
            // GetUniversityToni();
            //GetLecturesFromToni();
            //GetAllStudentFromYale();
            //GetAllUniversitiesWithTransgenders();
            // GetAllLectureFromEthz();
            //UpdateToni();
            DeleteJame();
        }

        public void InsertUniversities()
        {
            dataContext.ExecuteCommand("delete from University");
            University yale = new University();
            yale.Name = "Yale";
            dataContext.Universities.InsertOnSubmit(yale);

            University ethz = new University();
            ethz.Name = "Ethz";
            dataContext.Universities.InsertOnSubmit(ethz);

            dataContext.SubmitChanges();

            MainDataGrid.ItemsSource = dataContext.Universities;
        }

        public void InsertStudent()
        {
            University yale = dataContext.Universities.First(un => un.Name.Equals("Yale"));
            University ethz = dataContext.Universities.First(un => un.Name.Equals("Ethz"));

            List<Student> students = new List<Student>();

            students.Add(new Student { Name = "Carla", Gender = "female", UniversityId = yale.Id });
            students.Add(new Student { Name = "Toni", Gender = "female", UniversityId = yale.Id });
            students.Add(new Student { Name = "Mark", Gender = "male", UniversityId = ethz.Id });
            students.Add(new Student { Name = "Jame", Gender = "trans-gender", UniversityId = ethz.Id });

            dataContext.Students.InsertAllOnSubmit(students);
            dataContext.SubmitChanges();

            MainDataGrid.ItemsSource = dataContext.Students;
            

        }

        public void InsertLectures()
        {
            dataContext.Lectures.InsertOnSubmit(new Lecture { Name = "Math" });
            dataContext.Lectures.InsertOnSubmit(new Lecture { Name = "History" });

            dataContext.SubmitChanges();

            MainDataGrid.ItemsSource = dataContext.Lectures;
        }

        public void InsertStudentLectureAssocions()
        {
            Student Carla = dataContext.Students.First(st => st.Name.Equals("Carla"));
            Student Toni = dataContext.Students.First(st => st.Name.Equals("Toni"));
            Student Mark = dataContext.Students.First(st => st.Name.Equals("Mark"));
            Student Jame = dataContext.Students.First(st => st.Name.Equals("Jame"));

            Lecture Math = dataContext.Lectures.First(lc => lc.Name.Equals("Math"));
            Lecture History = dataContext.Lectures.First(lc => lc.Name.Equals("History"));

            dataContext.StudentLectures.InsertOnSubmit(new StudentLecture { Student = Carla, Lecture = Math });
            dataContext.StudentLectures.InsertOnSubmit(new StudentLecture { Student = Toni, Lecture = Math });
            dataContext.StudentLectures.InsertOnSubmit(new StudentLecture { Student = Mark, Lecture = History });
            dataContext.StudentLectures.InsertOnSubmit(new StudentLecture { Student = Jame, Lecture = History });

            dataContext.SubmitChanges();

            MainDataGrid.ItemsSource = dataContext.StudentLectures;
        }

        public void GetUniversityToni()
        {
            Student Toni = dataContext.Students.First(st => st.Name.Equals("Toni"));

            University ToniUniversity = Toni.University;
            List<University> universities = new List<University>();
            universities.Add(ToniUniversity);

            MainDataGrid.ItemsSource = universities;
        }

        public void GetLecturesFromToni()
        {
            Student Toni = dataContext.Students.First(st => st.Name.Equals("Toni"));
            var tnoslectures = from si in Toni.StudentLectures select si.Lecture;
            MainDataGrid.ItemsSource = tnoslectures;
        }

        public void GetAllStudentFromYale()
        {
            var studentFromYale = from student in dataContext.Students
                                  where student.University.Name == "Yale"
                                  select student;
            MainDataGrid.ItemsSource = studentFromYale;
        }

        public void GetAllUniversitiesWithTransgenders()
        {
            var transgenderwithuniversity = from student in dataContext.Students
                                            join university in dataContext.Universities
                                            on student.University equals university
                                            where student.Gender == "trans-gender"
                                            select university;
            MainDataGrid.ItemsSource = transgenderwithuniversity;


        }

        public void GetAllLectureFromEthz()
        {
            var lectureFromEthz = from sl in dataContext.StudentLectures
                                  join student in dataContext.Students on sl.StudentId equals student.Id
                                  where student.University.Name == "Ethz"
                                  select sl.Lecture;

            MainDataGrid.ItemsSource = lectureFromEthz;
        }

        public void UpdateToni()
        {
            Student Toni = dataContext.Students.FirstOrDefault(st => st.Name == "Toni");
            Toni.Name = "Antonio";

            dataContext.SubmitChanges();

            MainDataGrid.ItemsSource = dataContext.Students;

        }

        public void DeleteJame()
        {
            Student Jame = dataContext.Students.FirstOrDefault(st => st.Name == "Jame");
            dataContext.Students.DeleteOnSubmit(Jame);
            dataContext.SubmitChanges();

            MainDataGrid.ItemsSource = dataContext.Students;

        }
    }
}
