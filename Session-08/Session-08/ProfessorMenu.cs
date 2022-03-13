using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using LibUniversity;
using System.Text.Json;
using Newtonsoft.Json;

namespace Session_08
{
    
    public partial class ProfessorMenu : Form
    {
        
        public  University University { get; set; }
        private Professor _professor;
        private Professor _selected;
        private Professor _original;
        public ProfessorMenu()
        {
            InitializeComponent();
        }
        private void ProfessorManager_Load(object sender, EventArgs e)
        {
            University university = new University();
            university.Professors = new List<Professor>();

            var Dimitris = new Professor()
            {
                Name = "Dimitris",
                Rank = "full",
                Age = 30,
            };
            university.Professors.Add(Dimitris);
        }

        private void universityManageMenu_Click(object sender, EventArgs e)
        {

        }

        private void btnCloseProfessor_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLoadProfessor_Click(object sender, EventArgs e)
        {
           

            foreach (Professor item in University.Professors)
            {
                if(item != null)
                {
                    professorList.Items.Add(string.Format("{0} {1}",item.Name,item.Rank));
                }
            }
        }

        private void professorList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Selected();
            Display();
        }

        public void Selected()
        {
            if (_selected != null)
            {
                _selected = University.Professors[professorList.SelectedIndex];
            }
        }

        public void Display()
        {
            if (_selected != null)
            {
                textBoxProfessorName.Text=_selected.Name;
                textBoxProfessorRank.Text=_selected.Rank;
            }
        }
        
       public void UpdateForm()
       {
            _original = _selected.ShallowCopy();
            _selected.Name=textBoxProfessorName.Text;
            _selected.Rank=textBoxProfessorRank.Text;
       }

        public Professor CreateProfessor()
        {
            ProfessorManager professorManager = new ProfessorManager();
            professorManager.Professors = University.Professors;

            Professor professor = professorManager.AddProfessor();
            return professor;
         }

        private void btnAddProfessor_Click(object sender, EventArgs e)
        {
            Professor professor =CreateProfessor();
            Display();
            professorList.SelectedIndex = University.Professors.IndexOf(professor);
        }

   

        public void btnSaveProfessor_Click(object sender, EventArgs e)
        {
     
            
      
        }

        private void Test_Click(object sender, EventArgs e)
        {
            Update();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainScreen mainScreen = new MainScreen();
            mainScreen.SaveData();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainScreen mainScreen = new MainScreen();
            mainScreen.LoadData();
        }
    }
}
