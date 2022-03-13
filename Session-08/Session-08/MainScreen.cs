using LibUniversity;
using Newtonsoft.Json;
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
    public partial class MainScreen : Form
    {
        private University _university;
        const string FILE_NAME = "Professors.json";
        public MainScreen()
        {
            InitializeComponent();
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {

        }

        private void universityManageMenu_Click(object sender, EventArgs e)
        {
            InstituteManager manager = new InstituteManager();
            manager.ShowDialog();
        }

        private void professorManageMenu_Click(object sender, EventArgs e)
        {
            ProfessorMenu manager = new ProfessorMenu();
            manager.ShowDialog();
        }

        public void SaveData()
        {
            string json = System.Text.Json.JsonSerializer.Serialize(_university);
            File.WriteAllText(FILE_NAME, json);
            MessageBox.Show("Saved!" + MessageBoxButtons.OK);
        }

        public void LoadData()
        {   
            var jsonFile = File.ReadAllText(FILE_NAME);
            _university.Professors = JsonConvert.DeserializeObject<List<Professor>>(jsonFile);
            //Professors = Professors;
            //_university = (University)System.Text.Json.JsonSerializer.Deserialize(jsonFile, typeof(University));
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }

}
