namespace StudentWorkWithTran
{
    partial class fStudentWork
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
            this.SuspendLayout();
            // 
            // fStudentWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "fStudentWork";
            this.Text = "Students Work";
            this.ResumeLayout(false);

            this.cbGroups = new System.Windows.Forms.ComboBox();
            this.lbStudentList = new System.Windows.Forms.ListBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.bUpdate = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.bAdd = new System.Windows.Forms.Button();
            this.lFirstName = new System.Windows.Forms.Label();
            this.lLastName = new System.Windows.Forms.Label();
            this.lGroup = new System.Windows.Forms.Label();
            this.cbCurrentGroup = new System.Windows.Forms.ComboBox();
            this.gbStudentInfo = new System.Windows.Forms.GroupBox();
            this.lTerm = new System.Windows.Forms.Label();
            this.tbTerm = new System.Windows.Forms.TextBox();
            this.gbStudentInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbGroups
            // 
            this.cbGroups.FormattingEnabled = true;
            this.cbGroups.Location = new System.Drawing.Point(13, 13);
            this.cbGroups.Name = "cbGroups";
            this.cbGroups.Size = new System.Drawing.Size(143, 21);
            this.cbGroups.TabIndex = 0;
            this.cbGroups.SelectedIndexChanged += new System.EventHandler(this.cbGroups_SelectedIndexChanged);
            // 
            // lbStudentList
            // 
            this.lbStudentList.FormattingEnabled = true;
            this.lbStudentList.Location = new System.Drawing.Point(13, 41);
            this.lbStudentList.Name = "lbStudentList";
            this.lbStudentList.Size = new System.Drawing.Size(143, 199);
            this.lbStudentList.TabIndex = 1;
            this.lbStudentList.SelectedIndexChanged += new System.EventHandler(this.lbStudentList_SelectedIndexChanged);
            // 
            // tbFirstName
            // 
            this.tbFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbFirstName.Location = new System.Drawing.Point(88, 37);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(121, 21);
            this.tbFirstName.TabIndex = 3;
            // 
            // tbLastName
            // 
            this.tbLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbLastName.Location = new System.Drawing.Point(88, 69);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(121, 21);
            this.tbLastName.TabIndex = 4;
            // 
            // bUpdate
            // 
            this.bUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bUpdate.Location = new System.Drawing.Point(26, 173);
            this.bUpdate.Name = "bUpdate";
            this.bUpdate.Size = new System.Drawing.Size(75, 23);
            this.bUpdate.TabIndex = 6;
            this.bUpdate.Text = "Update";
            this.bUpdate.UseVisualStyleBackColor = true;
            this.bUpdate.Click += new System.EventHandler(this.bUpdate_Click);
            // 
            // bDelete
            // 
            this.bDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bDelete.Location = new System.Drawing.Point(119, 173);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(75, 23);
            this.bDelete.TabIndex = 7;
            this.bDelete.Text = "Delete";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // bAdd
            // 
            this.bAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bAdd.Location = new System.Drawing.Point(73, 202);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(75, 23);
            this.bAdd.TabIndex = 8;
            this.bAdd.Text = "Add";
            this.bAdd.UseVisualStyleBackColor = true;
            // 
            // lFirstName
            // 
            this.lFirstName.AutoSize = true;
            this.lFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lFirstName.Location = new System.Drawing.Point(14, 40);
            this.lFirstName.Name = "lFirstName";
            this.lFirstName.Size = new System.Drawing.Size(67, 15);
            this.lFirstName.TabIndex = 9;
            this.lFirstName.Text = "First Name";
            // 
            // lLastName
            // 
            this.lLastName.AutoSize = true;
            this.lLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lLastName.Location = new System.Drawing.Point(14, 72);
            this.lLastName.Name = "lLastName";
            this.lLastName.Size = new System.Drawing.Size(67, 15);
            this.lLastName.TabIndex = 10;
            this.lLastName.Text = "Last Name";
            // 
            // lGroup
            // 
            this.lGroup.AutoSize = true;
            this.lGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lGroup.Location = new System.Drawing.Point(14, 137);
            this.lGroup.Name = "lGroup";
            this.lGroup.Size = new System.Drawing.Size(41, 15);
            this.lGroup.TabIndex = 11;
            this.lGroup.Text = "Group";
            // 
            // cbCurrentGroup
            // 
            this.cbCurrentGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbCurrentGroup.FormattingEnabled = true;
            this.cbCurrentGroup.Location = new System.Drawing.Point(88, 134);
            this.cbCurrentGroup.Name = "cbCurrentGroup";
            this.cbCurrentGroup.Size = new System.Drawing.Size(121, 23);
            this.cbCurrentGroup.TabIndex = 12;
            this.cbCurrentGroup.SelectedIndexChanged += new System.EventHandler(this.cbCurrentGroup_SelectedIndexChanged);
            // 
            // gbStudentInfo
            // 
            this.gbStudentInfo.Controls.Add(this.tbTerm);
            this.gbStudentInfo.Controls.Add(this.lTerm);
            this.gbStudentInfo.Controls.Add(this.tbFirstName);
            this.gbStudentInfo.Controls.Add(this.cbCurrentGroup);
            this.gbStudentInfo.Controls.Add(this.tbLastName);
            this.gbStudentInfo.Controls.Add(this.lGroup);
            this.gbStudentInfo.Controls.Add(this.bUpdate);
            this.gbStudentInfo.Controls.Add(this.lLastName);
            this.gbStudentInfo.Controls.Add(this.bDelete);
            this.gbStudentInfo.Controls.Add(this.lFirstName);
            this.gbStudentInfo.Controls.Add(this.bAdd);
            this.gbStudentInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbStudentInfo.Location = new System.Drawing.Point(162, 13);
            this.gbStudentInfo.Name = "gbStudentInfo";
            this.gbStudentInfo.Size = new System.Drawing.Size(234, 231);
            this.gbStudentInfo.TabIndex = 13;
            this.gbStudentInfo.TabStop = false;
            this.gbStudentInfo.Text = "Student Info";
            // 
            // lTerm
            // 
            this.lTerm.AutoSize = true;
            this.lTerm.Location = new System.Drawing.Point(14, 103);
            this.lTerm.Name = "lTerm";
            this.lTerm.Size = new System.Drawing.Size(41, 17);
            this.lTerm.TabIndex = 13;
            this.lTerm.Text = "Term";
            // 
            // tbTerm
            // 
            this.tbTerm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbTerm.Location = new System.Drawing.Point(88, 100);
            this.tbTerm.Name = "tbTerm";
            this.tbTerm.Size = new System.Drawing.Size(121, 21);
            this.tbTerm.TabIndex = 14;
            // 
            // fStudentWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 252);
            this.Controls.Add(this.gbStudentInfo);
            this.Controls.Add(this.lbStudentList);
            this.Controls.Add(this.cbGroups);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "fStudentWork";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Work";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fStudentWork_FormClosing);
            this.gbStudentInfo.ResumeLayout(false);
            this.gbStudentInfo.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ComboBox cbGroups;
        private System.Windows.Forms.ListBox lbStudentList;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Button bUpdate;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Label lFirstName;
        private System.Windows.Forms.Label lLastName;
        private System.Windows.Forms.Label lGroup;
        private System.Windows.Forms.ComboBox cbCurrentGroup;
        private System.Windows.Forms.GroupBox gbStudentInfo;
        private System.Windows.Forms.TextBox tbTerm;
        private System.Windows.Forms.Label lTerm;

    }
}

