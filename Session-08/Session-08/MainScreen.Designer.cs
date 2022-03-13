namespace Session_08
{
    partial class MainScreen
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.instituteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.universityManageMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.universityMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.professorManageMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.studentManageMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.courseManageMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.professorMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.coursesProfessorMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.gradesProfessorMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.studentMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.coursesStudentMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.gradesStudentMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleStudentMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.instituteMenuItem,
            this.universityMenu,
            this.professorMenu,
            this.studentMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuMain";
            // 
            // instituteMenuItem
            // 
            this.instituteMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.universityManageMenu});
            this.instituteMenuItem.Name = "instituteMenuItem";
            this.instituteMenuItem.Size = new System.Drawing.Size(92, 29);
            this.instituteMenuItem.Text = "Institute";
            // 
            // universityManageMenu
            // 
            this.universityManageMenu.Name = "universityManageMenu";
            this.universityManageMenu.Size = new System.Drawing.Size(191, 34);
            this.universityManageMenu.Text = "University";
            this.universityManageMenu.Click += new System.EventHandler(this.universityManageMenu_Click);
            // 
            // universityMenu
            // 
            this.universityMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.professorManageMenu,
            this.studentManageMenu,
            this.courseManageMenu});
            this.universityMenu.Name = "universityMenu";
            this.universityMenu.Size = new System.Drawing.Size(105, 29);
            this.universityMenu.Text = "University";
            // 
            // professorManageMenu
            // 
            this.professorManageMenu.Name = "professorManageMenu";
            this.professorManageMenu.Size = new System.Drawing.Size(197, 34);
            this.professorManageMenu.Text = "Professors";
            this.professorManageMenu.Click += new System.EventHandler(this.professorManageMenu_Click);
            // 
            // studentManageMenu
            // 
            this.studentManageMenu.Name = "studentManageMenu";
            this.studentManageMenu.Size = new System.Drawing.Size(197, 34);
            this.studentManageMenu.Text = "Students";
            // 
            // courseManageMenu
            // 
            this.courseManageMenu.Name = "courseManageMenu";
            this.courseManageMenu.Size = new System.Drawing.Size(197, 34);
            this.courseManageMenu.Text = "Courses";
            // 
            // professorMenu
            // 
            this.professorMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.coursesProfessorMenu,
            this.gradesProfessorMenu});
            this.professorMenu.Name = "professorMenu";
            this.professorMenu.Size = new System.Drawing.Size(103, 29);
            this.professorMenu.Text = "Professor";
            // 
            // coursesProfessorMenu
            // 
            this.coursesProfessorMenu.Name = "coursesProfessorMenu";
            this.coursesProfessorMenu.Size = new System.Drawing.Size(207, 34);
            this.coursesProfessorMenu.Text = "My Courses";
            // 
            // gradesProfessorMenu
            // 
            this.gradesProfessorMenu.Name = "gradesProfessorMenu";
            this.gradesProfessorMenu.Size = new System.Drawing.Size(207, 34);
            this.gradesProfessorMenu.Text = "Grades";
            // 
            // studentMenu
            // 
            this.studentMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.coursesStudentMenu,
            this.gradesStudentMenu,
            this.scheduleStudentMenu});
            this.studentMenu.Name = "studentMenu";
            this.studentMenu.Size = new System.Drawing.Size(89, 29);
            this.studentMenu.Text = "Student";
            // 
            // coursesStudentMenu
            // 
            this.coursesStudentMenu.Name = "coursesStudentMenu";
            this.coursesStudentMenu.Size = new System.Drawing.Size(215, 34);
            this.coursesStudentMenu.Text = "My Courses";
            // 
            // gradesStudentMenu
            // 
            this.gradesStudentMenu.Name = "gradesStudentMenu";
            this.gradesStudentMenu.Size = new System.Drawing.Size(215, 34);
            this.gradesStudentMenu.Text = "My Grades";
            // 
            // scheduleStudentMenu
            // 
            this.scheduleStudentMenu.Name = "scheduleStudentMenu";
            this.scheduleStudentMenu.Size = new System.Drawing.Size(215, 34);
            this.scheduleStudentMenu.Text = "My Schedule";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainScreen";
            this.Text = "Institute";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem universityMenu;
        private System.Windows.Forms.ToolStripMenuItem professorManageMenu;
        private System.Windows.Forms.ToolStripMenuItem studentManageMenu;
        private System.Windows.Forms.ToolStripMenuItem courseManageMenu;
        private System.Windows.Forms.ToolStripMenuItem professorMenu;
        private System.Windows.Forms.ToolStripMenuItem coursesProfessorMenu;
        private System.Windows.Forms.ToolStripMenuItem gradesProfessorMenu;
        private System.Windows.Forms.ToolStripMenuItem studentMenu;
        private System.Windows.Forms.ToolStripMenuItem coursesStudentMenu;
        private System.Windows.Forms.ToolStripMenuItem gradesStudentMenu;
        private System.Windows.Forms.ToolStripMenuItem scheduleStudentMenu;
        private System.Windows.Forms.ToolStripMenuItem instituteMenuItem;
        private System.Windows.Forms.ToolStripMenuItem universityManageMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
    }
}

