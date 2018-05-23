namespace StudentWorkWithTran
{
    partial class AddWindow
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
            this.lFirstNameAdd = new System.Windows.Forms.Label();
            this.lLastNameAdd = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.lTermAdd = new System.Windows.Forms.Label();
            this.tbTerm = new System.Windows.Forms.TextBox();
            this.gbGroup = new System.Windows.Forms.GroupBox();
            this.cbFaculties = new System.Windows.Forms.ComboBox();
            this.lFaculties = new System.Windows.Forms.Label();
            this.cbExistGroup = new System.Windows.Forms.ComboBox();
            this.rbEGroup = new System.Windows.Forms.RadioButton();
            this.tbNewGroup = new System.Windows.Forms.TextBox();
            this.rbNGroup = new System.Windows.Forms.RadioButton();
            this.bAddStudent = new System.Windows.Forms.Button();
            this.tcAddStudentGroup = new System.Windows.Forms.TabControl();
            this.tpAddStudent = new System.Windows.Forms.TabPage();
            this.tbAddGroup = new System.Windows.Forms.TabPage();
            this.bAddGroup = new System.Windows.Forms.Button();
            this.lFacultiesForNewGroup = new System.Windows.Forms.Label();
            this.cbFacultiesForNewGroup = new System.Windows.Forms.ComboBox();
            this.tbGroupName = new System.Windows.Forms.TextBox();
            this.lGroupName = new System.Windows.Forms.Label();
            this.gbGroup.SuspendLayout();
            this.tcAddStudentGroup.SuspendLayout();
            this.tpAddStudent.SuspendLayout();
            this.tbAddGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // lFirstNameAdd
            // 
            this.lFirstNameAdd.AutoSize = true;
            this.lFirstNameAdd.Location = new System.Drawing.Point(7, 10);
            this.lFirstNameAdd.Name = "lFirstNameAdd";
            this.lFirstNameAdd.Size = new System.Drawing.Size(55, 13);
            this.lFirstNameAdd.TabIndex = 0;
            this.lFirstNameAdd.Text = "First name";
            // 
            // lLastNameAdd
            // 
            this.lLastNameAdd.AutoSize = true;
            this.lLastNameAdd.Location = new System.Drawing.Point(7, 37);
            this.lLastNameAdd.Name = "lLastNameAdd";
            this.lLastNameAdd.Size = new System.Drawing.Size(56, 13);
            this.lLastNameAdd.TabIndex = 1;
            this.lLastNameAdd.Text = "Last name";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(74, 7);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(144, 20);
            this.tbFirstName.TabIndex = 2;
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(74, 34);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(144, 20);
            this.tbLastName.TabIndex = 3;
            // 
            // lTermAdd
            // 
            this.lTermAdd.AutoSize = true;
            this.lTermAdd.Location = new System.Drawing.Point(7, 63);
            this.lTermAdd.Name = "lTermAdd";
            this.lTermAdd.Size = new System.Drawing.Size(31, 13);
            this.lTermAdd.TabIndex = 4;
            this.lTermAdd.Text = "Term";
            // 
            // tbTerm
            // 
            this.tbTerm.Location = new System.Drawing.Point(74, 60);
            this.tbTerm.Name = "tbTerm";
            this.tbTerm.Size = new System.Drawing.Size(144, 20);
            this.tbTerm.TabIndex = 5;
            // 
            // gbGroup
            // 
            this.gbGroup.Controls.Add(this.cbFaculties);
            this.gbGroup.Controls.Add(this.lFaculties);
            this.gbGroup.Controls.Add(this.cbExistGroup);
            this.gbGroup.Controls.Add(this.rbEGroup);
            this.gbGroup.Controls.Add(this.tbNewGroup);
            this.gbGroup.Controls.Add(this.rbNGroup);
            this.gbGroup.Location = new System.Drawing.Point(10, 86);
            this.gbGroup.Name = "gbGroup";
            this.gbGroup.Size = new System.Drawing.Size(208, 164);
            this.gbGroup.TabIndex = 6;
            this.gbGroup.TabStop = false;
            this.gbGroup.Text = "Group";
            // 
            // cbFaculties
            // 
            this.cbFaculties.Enabled = false;
            this.cbFaculties.FormattingEnabled = true;
            this.cbFaculties.Location = new System.Drawing.Point(64, 130);
            this.cbFaculties.Name = "cbFaculties";
            this.cbFaculties.Size = new System.Drawing.Size(136, 21);
            this.cbFaculties.TabIndex = 7;
            // 
            // lFaculties
            // 
            this.lFaculties.AutoSize = true;
            this.lFaculties.Location = new System.Drawing.Point(8, 133);
            this.lFaculties.Name = "lFaculties";
            this.lFaculties.Size = new System.Drawing.Size(49, 13);
            this.lFaculties.TabIndex = 6;
            this.lFaculties.Text = "Faculties";
            // 
            // cbExistGroup
            // 
            this.cbExistGroup.FormattingEnabled = true;
            this.cbExistGroup.Location = new System.Drawing.Point(7, 42);
            this.cbExistGroup.Name = "cbExistGroup";
            this.cbExistGroup.Size = new System.Drawing.Size(193, 21);
            this.cbExistGroup.TabIndex = 5;
            // 
            // rbEGroup
            // 
            this.rbEGroup.AutoSize = true;
            this.rbEGroup.Checked = true;
            this.rbEGroup.Location = new System.Drawing.Point(7, 19);
            this.rbEGroup.Name = "rbEGroup";
            this.rbEGroup.Size = new System.Drawing.Size(79, 17);
            this.rbEGroup.TabIndex = 4;
            this.rbEGroup.TabStop = true;
            this.rbEGroup.Text = "Exist Group";
            this.rbEGroup.UseVisualStyleBackColor = true;
            this.rbEGroup.CheckedChanged += new System.EventHandler(this.rbGroup_CheckedChanged);
            // 
            // tbNewGroup
            // 
            this.tbNewGroup.Enabled = false;
            this.tbNewGroup.Location = new System.Drawing.Point(7, 103);
            this.tbNewGroup.Name = "tbNewGroup";
            this.tbNewGroup.Size = new System.Drawing.Size(193, 20);
            this.tbNewGroup.TabIndex = 2;
            // 
            // rbNGroup
            // 
            this.rbNGroup.AutoSize = true;
            this.rbNGroup.Location = new System.Drawing.Point(7, 80);
            this.rbNGroup.Name = "rbNGroup";
            this.rbNGroup.Size = new System.Drawing.Size(79, 17);
            this.rbNGroup.TabIndex = 0;
            this.rbNGroup.Text = "New Group";
            this.rbNGroup.UseVisualStyleBackColor = true;
            // 
            // bAddStudent
            // 
            this.bAddStudent.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bAddStudent.Location = new System.Drawing.Point(83, 256);
            this.bAddStudent.Name = "bAddStudent";
            this.bAddStudent.Size = new System.Drawing.Size(75, 23);
            this.bAddStudent.TabIndex = 7;
            this.bAddStudent.Text = "Add";
            this.bAddStudent.UseVisualStyleBackColor = true;
            this.bAddStudent.Click += new System.EventHandler(this.bAddStudent_Click);
            // 
            // tcAddStudentGroup
            // 
            this.tcAddStudentGroup.Controls.Add(this.tpAddStudent);
            this.tcAddStudentGroup.Controls.Add(this.tbAddGroup);
            this.tcAddStudentGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcAddStudentGroup.Location = new System.Drawing.Point(0, 0);
            this.tcAddStudentGroup.Name = "tcAddStudentGroup";
            this.tcAddStudentGroup.SelectedIndex = 0;
            this.tcAddStudentGroup.Size = new System.Drawing.Size(236, 309);
            this.tcAddStudentGroup.TabIndex = 8;
            // 
            // tpAddStudent
            // 
            this.tpAddStudent.BackColor = System.Drawing.Color.LightSkyBlue;
            this.tpAddStudent.Controls.Add(this.lFirstNameAdd);
            this.tpAddStudent.Controls.Add(this.bAddStudent);
            this.tpAddStudent.Controls.Add(this.lLastNameAdd);
            this.tpAddStudent.Controls.Add(this.gbGroup);
            this.tpAddStudent.Controls.Add(this.tbFirstName);
            this.tpAddStudent.Controls.Add(this.tbTerm);
            this.tpAddStudent.Controls.Add(this.tbLastName);
            this.tpAddStudent.Controls.Add(this.lTermAdd);
            this.tpAddStudent.Location = new System.Drawing.Point(4, 22);
            this.tpAddStudent.Name = "tpAddStudent";
            this.tpAddStudent.Padding = new System.Windows.Forms.Padding(3);
            this.tpAddStudent.Size = new System.Drawing.Size(228, 283);
            this.tpAddStudent.TabIndex = 0;
            this.tpAddStudent.Text = "Student";
            // 
            // tbAddGroup
            // 
            this.tbAddGroup.BackColor = System.Drawing.Color.PaleGreen;
            this.tbAddGroup.Controls.Add(this.bAddGroup);
            this.tbAddGroup.Controls.Add(this.lFacultiesForNewGroup);
            this.tbAddGroup.Controls.Add(this.cbFacultiesForNewGroup);
            this.tbAddGroup.Controls.Add(this.tbGroupName);
            this.tbAddGroup.Controls.Add(this.lGroupName);
            this.tbAddGroup.Location = new System.Drawing.Point(4, 22);
            this.tbAddGroup.Name = "tbAddGroup";
            this.tbAddGroup.Padding = new System.Windows.Forms.Padding(3);
            this.tbAddGroup.Size = new System.Drawing.Size(228, 283);
            this.tbAddGroup.TabIndex = 1;
            this.tbAddGroup.Text = "Group";
            // 
            // bAddGroup
            // 
            this.bAddGroup.Location = new System.Drawing.Point(92, 156);
            this.bAddGroup.Name = "bAddGroup";
            this.bAddGroup.Size = new System.Drawing.Size(75, 23);
            this.bAddGroup.TabIndex = 4;
            this.bAddGroup.Text = "Add";
            this.bAddGroup.UseVisualStyleBackColor = true;
            this.bAddGroup.Click += new System.EventHandler(this.bAddGroup_Click);
            // 
            // lFacultiesForNewGroup
            // 
            this.lFacultiesForNewGroup.AutoSize = true;
            this.lFacultiesForNewGroup.Location = new System.Drawing.Point(8, 123);
            this.lFacultiesForNewGroup.Name = "lFacultiesForNewGroup";
            this.lFacultiesForNewGroup.Size = new System.Drawing.Size(49, 13);
            this.lFacultiesForNewGroup.TabIndex = 3;
            this.lFacultiesForNewGroup.Text = "Faculties";
            // 
            // cbFacultiesForNewGroup
            // 
            this.cbFacultiesForNewGroup.FormattingEnabled = true;
            this.cbFacultiesForNewGroup.Location = new System.Drawing.Point(78, 120);
            this.cbFacultiesForNewGroup.Name = "cbFacultiesForNewGroup";
            this.cbFacultiesForNewGroup.Size = new System.Drawing.Size(142, 21);
            this.cbFacultiesForNewGroup.TabIndex = 2;
            // 
            // tbGroupName
            // 
            this.tbGroupName.Location = new System.Drawing.Point(78, 85);
            this.tbGroupName.Name = "tbGroupName";
            this.tbGroupName.Size = new System.Drawing.Size(142, 20);
            this.tbGroupName.TabIndex = 1;
            // 
            // lGroupName
            // 
            this.lGroupName.AutoSize = true;
            this.lGroupName.Location = new System.Drawing.Point(8, 88);
            this.lGroupName.Name = "lGroupName";
            this.lGroupName.Size = new System.Drawing.Size(65, 13);
            this.lGroupName.TabIndex = 0;
            this.lGroupName.Text = "Group name";
            // 
            // AddWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 309);
            this.Controls.Add(this.tcAddStudentGroup);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddWindow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddWindow_FormClosing);
            this.gbGroup.ResumeLayout(false);
            this.gbGroup.PerformLayout();
            this.tcAddStudentGroup.ResumeLayout(false);
            this.tpAddStudent.ResumeLayout(false);
            this.tpAddStudent.PerformLayout();
            this.tbAddGroup.ResumeLayout(false);
            this.tbAddGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lFirstNameAdd;
        private System.Windows.Forms.Label lLastNameAdd;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label lTermAdd;
        private System.Windows.Forms.TextBox tbTerm;
        private System.Windows.Forms.GroupBox gbGroup;
        private System.Windows.Forms.ComboBox cbExistGroup;
        private System.Windows.Forms.RadioButton rbEGroup;
        private System.Windows.Forms.TextBox tbNewGroup;
        private System.Windows.Forms.RadioButton rbNGroup;
        private System.Windows.Forms.Button bAddStudent;
        private System.Windows.Forms.ComboBox cbFaculties;
        private System.Windows.Forms.Label lFaculties;
        private System.Windows.Forms.TabControl tcAddStudentGroup;
        private System.Windows.Forms.TabPage tpAddStudent;
        private System.Windows.Forms.TabPage tbAddGroup;
        private System.Windows.Forms.Button bAddGroup;
        private System.Windows.Forms.Label lFacultiesForNewGroup;
        private System.Windows.Forms.ComboBox cbFacultiesForNewGroup;
        private System.Windows.Forms.TextBox tbGroupName;
        private System.Windows.Forms.Label lGroupName;
    }
}