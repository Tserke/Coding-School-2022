namespace Session_08
{
    partial class InstituteManager
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
            this.universityList = new System.Windows.Forms.ListBox();
            this.btnAddUniversity = new System.Windows.Forms.Button();
            this.btnDeleteUniversity = new System.Windows.Forms.Button();
            this.btnSaveUniversity = new System.Windows.Forms.Button();
            this.btnLoadUniversity = new System.Windows.Forms.Button();
            this.btnCloseUniversity = new System.Windows.Forms.Button();
            this.textBoxUniversityName = new System.Windows.Forms.TextBox();
            this.labelUniversityName = new System.Windows.Forms.Label();
            this.labelUniversityAge = new System.Windows.Forms.Label();
            this.textBoxUniversityAge = new System.Windows.Forms.TextBox();
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
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // universityList
            // 
            this.universityList.FormattingEnabled = true;
            this.universityList.ItemHeight = 20;
            this.universityList.Location = new System.Drawing.Point(7, 89);
            this.universityList.Name = "universityList";
            this.universityList.Size = new System.Drawing.Size(230, 344);
            this.universityList.TabIndex = 0;
            // 
            // btnAddUniversity
            // 
            this.btnAddUniversity.Location = new System.Drawing.Point(7, 36);
            this.btnAddUniversity.Name = "btnAddUniversity";
            this.btnAddUniversity.Size = new System.Drawing.Size(110, 47);
            this.btnAddUniversity.TabIndex = 1;
            this.btnAddUniversity.Text = "Add New";
            this.btnAddUniversity.UseVisualStyleBackColor = true;
            // 
            // btnDeleteUniversity
            // 
            this.btnDeleteUniversity.Location = new System.Drawing.Point(127, 36);
            this.btnDeleteUniversity.Name = "btnDeleteUniversity";
            this.btnDeleteUniversity.Size = new System.Drawing.Size(110, 47);
            this.btnDeleteUniversity.TabIndex = 2;
            this.btnDeleteUniversity.Text = "Delete";
            this.btnDeleteUniversity.UseVisualStyleBackColor = true;
            // 
            // btnSaveUniversity
            // 
            this.btnSaveUniversity.Location = new System.Drawing.Point(259, 386);
            this.btnSaveUniversity.Name = "btnSaveUniversity";
            this.btnSaveUniversity.Size = new System.Drawing.Size(131, 47);
            this.btnSaveUniversity.TabIndex = 3;
            this.btnSaveUniversity.Text = "Save";
            this.btnSaveUniversity.UseVisualStyleBackColor = true;
            // 
            // btnLoadUniversity
            // 
            this.btnLoadUniversity.Location = new System.Drawing.Point(396, 386);
            this.btnLoadUniversity.Name = "btnLoadUniversity";
            this.btnLoadUniversity.Size = new System.Drawing.Size(131, 47);
            this.btnLoadUniversity.TabIndex = 4;
            this.btnLoadUniversity.Text = "Load";
            this.btnLoadUniversity.UseVisualStyleBackColor = true;
            // 
            // btnCloseUniversity
            // 
            this.btnCloseUniversity.Location = new System.Drawing.Point(657, 386);
            this.btnCloseUniversity.Name = "btnCloseUniversity";
            this.btnCloseUniversity.Size = new System.Drawing.Size(131, 47);
            this.btnCloseUniversity.TabIndex = 5;
            this.btnCloseUniversity.Text = "Close";
            this.btnCloseUniversity.UseVisualStyleBackColor = true;
            // 
            // textBoxUniversityName
            // 
            this.textBoxUniversityName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUniversityName.Location = new System.Drawing.Point(396, 89);
            this.textBoxUniversityName.Name = "textBoxUniversityName";
            this.textBoxUniversityName.Size = new System.Drawing.Size(325, 28);
            this.textBoxUniversityName.TabIndex = 6;
            // 
            // labelUniversityName
            // 
            this.labelUniversityName.AutoSize = true;
            this.labelUniversityName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUniversityName.Location = new System.Drawing.Point(309, 89);
            this.labelUniversityName.Name = "labelUniversityName";
            this.labelUniversityName.Size = new System.Drawing.Size(64, 25);
            this.labelUniversityName.TabIndex = 7;
            this.labelUniversityName.Text = "Name";
            // 
            // labelUniversityAge
            // 
            this.labelUniversityAge.AutoSize = true;
            this.labelUniversityAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUniversityAge.Location = new System.Drawing.Point(309, 146);
            this.labelUniversityAge.Name = "labelUniversityAge";
            this.labelUniversityAge.Size = new System.Drawing.Size(155, 25);
            this.labelUniversityAge.TabIndex = 9;
            this.labelUniversityAge.Text = "Years In Service";
            // 
            // textBoxUniversityAge
            // 
            this.textBoxUniversityAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUniversityAge.Location = new System.Drawing.Point(480, 146);
            this.textBoxUniversityAge.Name = "textBoxUniversityAge";
            this.textBoxUniversityAge.Size = new System.Drawing.Size(87, 28);
            this.textBoxUniversityAge.TabIndex = 8;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.instituteMenuItem,
            this.universityMenu,
            this.professorMenu,
            this.studentMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 10;
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
            // InstituteManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.labelUniversityAge);
            this.Controls.Add(this.textBoxUniversityAge);
            this.Controls.Add(this.labelUniversityName);
            this.Controls.Add(this.textBoxUniversityName);
            this.Controls.Add(this.btnCloseUniversity);
            this.Controls.Add(this.btnLoadUniversity);
            this.Controls.Add(this.btnSaveUniversity);
            this.Controls.Add(this.btnDeleteUniversity);
            this.Controls.Add(this.btnAddUniversity);
            this.Controls.Add(this.universityList);
            this.Name = "InstituteManager";
            this.Text = "InstituteManager";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox universityList;
        private System.Windows.Forms.Button btnAddUniversity;
        private System.Windows.Forms.Button btnDeleteUniversity;
        private System.Windows.Forms.Button btnSaveUniversity;
        private System.Windows.Forms.Button btnLoadUniversity;
        private System.Windows.Forms.Button btnCloseUniversity;
        private System.Windows.Forms.TextBox textBoxUniversityName;
        private System.Windows.Forms.Label labelUniversityName;
        private System.Windows.Forms.Label labelUniversityAge;
        private System.Windows.Forms.TextBox textBoxUniversityAge;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem instituteMenuItem;
        private System.Windows.Forms.ToolStripMenuItem universityManageMenu;
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
    }
}