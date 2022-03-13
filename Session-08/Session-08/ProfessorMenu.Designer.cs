namespace Session_08
{
    partial class ProfessorMenu
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
            this.coursesProfessorMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.gradesProfessorMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.labelProfessorAge = new System.Windows.Forms.Label();
            this.textBoxProfessorAge = new System.Windows.Forms.TextBox();
            this.labelProfessorName = new System.Windows.Forms.Label();
            this.textBoxProfessorName = new System.Windows.Forms.TextBox();
            this.btnCloseProfessor = new System.Windows.Forms.Button();
            this.btnLoadProfessor = new System.Windows.Forms.Button();
            this.btnSaveProfessor = new System.Windows.Forms.Button();
            this.btnDeleteProfessor = new System.Windows.Forms.Button();
            this.btnAddProfessor = new System.Windows.Forms.Button();
            this.professorList = new System.Windows.Forms.ListBox();
            this.labelRank = new System.Windows.Forms.Label();
            this.textBoxProfessorRank = new System.Windows.Forms.TextBox();
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
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuMain";
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
            // labelProfessorAge
            // 
            this.labelProfessorAge.AutoSize = true;
            this.labelProfessorAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProfessorAge.Location = new System.Drawing.Point(309, 155);
            this.labelProfessorAge.Name = "labelProfessorAge";
            this.labelProfessorAge.Size = new System.Drawing.Size(48, 25);
            this.labelProfessorAge.TabIndex = 20;
            this.labelProfessorAge.Text = "Age";
            // 
            // textBoxProfessorAge
            // 
            this.textBoxProfessorAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProfessorAge.Location = new System.Drawing.Point(396, 152);
            this.textBoxProfessorAge.Name = "textBoxProfessorAge";
            this.textBoxProfessorAge.Size = new System.Drawing.Size(66, 28);
            this.textBoxProfessorAge.TabIndex = 19;
            // 
            // labelProfessorName
            // 
            this.labelProfessorName.AutoSize = true;
            this.labelProfessorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProfessorName.Location = new System.Drawing.Point(309, 98);
            this.labelProfessorName.Name = "labelProfessorName";
            this.labelProfessorName.Size = new System.Drawing.Size(64, 25);
            this.labelProfessorName.TabIndex = 18;
            this.labelProfessorName.Text = "Name";
            // 
            // textBoxProfessorName
            // 
            this.textBoxProfessorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProfessorName.Location = new System.Drawing.Point(396, 98);
            this.textBoxProfessorName.Name = "textBoxProfessorName";
            this.textBoxProfessorName.Size = new System.Drawing.Size(325, 28);
            this.textBoxProfessorName.TabIndex = 17;
            // 
            // btnCloseProfessor
            // 
            this.btnCloseProfessor.Location = new System.Drawing.Point(657, 395);
            this.btnCloseProfessor.Name = "btnCloseProfessor";
            this.btnCloseProfessor.Size = new System.Drawing.Size(131, 47);
            this.btnCloseProfessor.TabIndex = 16;
            this.btnCloseProfessor.Text = "Close";
            this.btnCloseProfessor.UseVisualStyleBackColor = true;
            this.btnCloseProfessor.Click += new System.EventHandler(this.btnCloseProfessor_Click);
            // 
            // btnLoadProfessor
            // 
            this.btnLoadProfessor.Location = new System.Drawing.Point(396, 395);
            this.btnLoadProfessor.Name = "btnLoadProfessor";
            this.btnLoadProfessor.Size = new System.Drawing.Size(131, 47);
            this.btnLoadProfessor.TabIndex = 15;
            this.btnLoadProfessor.Text = "Load";
            this.btnLoadProfessor.UseVisualStyleBackColor = true;
            this.btnLoadProfessor.Click += new System.EventHandler(this.btnLoadProfessor_Click);
            // 
            // btnSaveProfessor
            // 
            this.btnSaveProfessor.Location = new System.Drawing.Point(259, 395);
            this.btnSaveProfessor.Name = "btnSaveProfessor";
            this.btnSaveProfessor.Size = new System.Drawing.Size(131, 47);
            this.btnSaveProfessor.TabIndex = 14;
            this.btnSaveProfessor.Text = "Save";
            this.btnSaveProfessor.UseVisualStyleBackColor = true;
            this.btnSaveProfessor.Click += new System.EventHandler(this.btnSaveProfessor_Click);
            // 
            // btnDeleteProfessor
            // 
            this.btnDeleteProfessor.Location = new System.Drawing.Point(127, 45);
            this.btnDeleteProfessor.Name = "btnDeleteProfessor";
            this.btnDeleteProfessor.Size = new System.Drawing.Size(110, 47);
            this.btnDeleteProfessor.TabIndex = 13;
            this.btnDeleteProfessor.Text = "Delete";
            this.btnDeleteProfessor.UseVisualStyleBackColor = true;
            // 
            // btnAddProfessor
            // 
            this.btnAddProfessor.Location = new System.Drawing.Point(7, 45);
            this.btnAddProfessor.Name = "btnAddProfessor";
            this.btnAddProfessor.Size = new System.Drawing.Size(110, 47);
            this.btnAddProfessor.TabIndex = 12;
            this.btnAddProfessor.Text = "Add New";
            this.btnAddProfessor.UseVisualStyleBackColor = true;
            this.btnAddProfessor.Click += new System.EventHandler(this.btnAddProfessor_Click);
            // 
            // professorList
            // 
            this.professorList.FormattingEnabled = true;
            this.professorList.ItemHeight = 20;
            this.professorList.Location = new System.Drawing.Point(7, 98);
            this.professorList.Name = "professorList";
            this.professorList.Size = new System.Drawing.Size(230, 344);
            this.professorList.TabIndex = 11;
            this.professorList.SelectedIndexChanged += new System.EventHandler(this.professorList_SelectedIndexChanged);
            // 
            // labelRank
            // 
            this.labelRank.AutoSize = true;
            this.labelRank.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRank.Location = new System.Drawing.Point(491, 155);
            this.labelRank.Name = "labelRank";
            this.labelRank.Size = new System.Drawing.Size(57, 25);
            this.labelRank.TabIndex = 23;
            this.labelRank.Text = "Rank";
            // 
            // textBoxProfessorRank
            // 
            this.textBoxProfessorRank.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProfessorRank.Location = new System.Drawing.Point(562, 152);
            this.textBoxProfessorRank.Name = "textBoxProfessorRank";
            this.textBoxProfessorRank.Size = new System.Drawing.Size(159, 28);
            this.textBoxProfessorRank.TabIndex = 22;
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
            // ProfessorMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelRank);
            this.Controls.Add(this.textBoxProfessorRank);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.labelProfessorAge);
            this.Controls.Add(this.textBoxProfessorAge);
            this.Controls.Add(this.labelProfessorName);
            this.Controls.Add(this.textBoxProfessorName);
            this.Controls.Add(this.btnCloseProfessor);
            this.Controls.Add(this.btnLoadProfessor);
            this.Controls.Add(this.btnSaveProfessor);
            this.Controls.Add(this.btnDeleteProfessor);
            this.Controls.Add(this.btnAddProfessor);
            this.Controls.Add(this.professorList);
            this.Name = "ProfessorMenu";
            this.Text = "ProfessorManager";
            this.Load += new System.EventHandler(this.ProfessorManager_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem professorMenu;
        private System.Windows.Forms.ToolStripMenuItem coursesProfessorMenu;
        private System.Windows.Forms.ToolStripMenuItem gradesProfessorMenu;
        private System.Windows.Forms.Label labelProfessorAge;
        private System.Windows.Forms.TextBox textBoxProfessorAge;
        private System.Windows.Forms.Label labelProfessorName;
        private System.Windows.Forms.TextBox textBoxProfessorName;
        private System.Windows.Forms.Button btnCloseProfessor;
        private System.Windows.Forms.Button btnLoadProfessor;
        private System.Windows.Forms.Button btnSaveProfessor;
        private System.Windows.Forms.Button btnDeleteProfessor;
        private System.Windows.Forms.Button btnAddProfessor;
        private System.Windows.Forms.ListBox professorList;
        private System.Windows.Forms.Label labelRank;
        private System.Windows.Forms.TextBox textBoxProfessorRank;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
    }
}