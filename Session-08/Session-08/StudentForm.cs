using LibUniversity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session_08
{
    public partial class StudentForm : Form
    { 
        private const string FILE_NAME = "studentList.json";
        private LibUniversity.University _university;
        public List<LibUniversity.Student> Students { get; set; }
        private LibUniversity.Student _selectedStudent;
        private LibUniversity.Student _originalStudent;
        public StudentForm()
        {
            InitializeComponent();
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            _university = new LibUniversity.University();
            _university.Students = new List<LibUniversity.Student>();

            var Dimitris = new LibUniversity.Student()
            {
                Name = "Dimitris",
                Age = 33,
                RegistrationNumber = 5445,
            };

            var Akis = new LibUniversity.Student()
            {
                Name = "Akis",
                Age = 22,
                RegistrationNumber = 4554,
            };
            _university.Students.Add(Dimitris);
            _university.Students.Add(Akis);

            ShowList();
            _selectedStudent = _university.Students[0];
        }

        private void studentList_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectStudent();
            DisplayStudent();
        }

        private void SelectStudent()
        {

            if (_selectedStudent != null && studentList.SelectedIndex>0)
            {
                _selectedStudent = _university.Students[studentList.SelectedIndex];
            }
            //else
            //{
            //    ShowList();
            //}
        }
        private void ShowList()
        {

            studentList.Items.Clear();

            foreach (LibUniversity.Student item in _university.Students)
            {

                if (item != null)
                    studentList.Items.Add(string.Format("{0}", item.Name));
            }
        }
        private void DisplayStudent()
        {

            if (_selectedStudent != null)
            {
                textBoxStudentName.Text = _selectedStudent.Name;
                textBoxStudentAge.Text = _selectedStudent.Age.ToString();
                textBoxStudentNumber.Text = _selectedStudent.RegistrationNumber.ToString();
            }
            else
            {
                textBoxStudentName.Text = string.Empty;
                textBoxStudentAge.Text = "0";
                textBoxStudentNumber.Text = "0";
            }
        }
        private void UpdateStudent()
        {

            _originalStudent = _selectedStudent.ShallowCopy();

            _selectedStudent.Name = textBoxStudentName.Text;
            _selectedStudent.Age = Convert.ToInt32(textBoxStudentAge.Text);
            _selectedStudent.RegistrationNumber = Convert.ToInt32(textBoxStudentNumber.Text);
        }

        private void btnLoadStudent_Click(object sender, EventArgs e)
        {
            

            ShowList();
        }

        private void btnCloseStudent_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteStudent();
        }

        private void DeleteStudent()
        {

            if (_selectedStudent != null)
            {

                _university.Students.Remove(_selectedStudent);

                _selectedStudent = null;



                ShowList();
            }
            DisplayStudent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CreateStudent();
            ShowList();
        }
        private LibUniversity.Student CreateStudent()
        {


            StudentManager manager = new StudentManager();
            manager.Students = _university.Students;

            Student student = manager.AddStudent();


            return student;
        }

        public void LoadData()
        {
            string data = File.ReadAllText(FILE_NAME);
            _university = (LibUniversity.University)JsonSerializer.Deserialize(data, typeof(LibUniversity.University)); 
        }

        public void SaveData()
        {
            string json = JsonSerializer.Serialize(_university);
            File.WriteAllText(FILE_NAME, json);
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentForm studentForm = new StudentForm();
            studentForm.Students = _university.Students;
            DisplayStudent();            
      
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateStudent();
        }

        private void btnSaveStudent_Click(object sender, EventArgs e)
        {
            
            SaveData();
            UpdateStudent();
            ShowList();
        }
    }
}
