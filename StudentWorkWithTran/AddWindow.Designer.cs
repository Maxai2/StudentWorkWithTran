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
            this.cbExistGroup = new System.Windows.Forms.ComboBox();
            this.rbGroup = new System.Windows.Forms.RadioButton();
            this.tbNewGroup = new System.Windows.Forms.TextBox();
            this.rbNGroup = new System.Windows.Forms.RadioButton();
            this.bOk = new System.Windows.Forms.Button();
            this.gbGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // lFirstNameAdd
            // 
            this.lFirstNameAdd.AutoSize = true;
            this.lFirstNameAdd.Location = new System.Drawing.Point(13, 16);
            this.lFirstNameAdd.Name = "lFirstNameAdd";
            this.lFirstNameAdd.Size = new System.Drawing.Size(57, 13);
            this.lFirstNameAdd.TabIndex = 0;
            this.lFirstNameAdd.Text = "First Name";
            // 
            // lLastNameAdd
            // 
            this.lLastNameAdd.AutoSize = true;
            this.lLastNameAdd.Location = new System.Drawing.Point(13, 43);
            this.lLastNameAdd.Name = "lLastNameAdd";
            this.lLastNameAdd.Size = new System.Drawing.Size(58, 13);
            this.lLastNameAdd.TabIndex = 1;
            this.lLastNameAdd.Text = "Last Name";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(80, 13);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(100, 20);
            this.tbFirstName.TabIndex = 2;
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(80, 40);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(100, 20);
            this.tbLastName.TabIndex = 3;
            // 
            // lTermAdd
            // 
            this.lTermAdd.AutoSize = true;
            this.lTermAdd.Location = new System.Drawing.Point(13, 69);
            this.lTermAdd.Name = "lTermAdd";
            this.lTermAdd.Size = new System.Drawing.Size(31, 13);
            this.lTermAdd.TabIndex = 4;
            this.lTermAdd.Text = "Term";
            // 
            // tbTerm
            // 
            this.tbTerm.Location = new System.Drawing.Point(80, 66);
            this.tbTerm.Name = "tbTerm";
            this.tbTerm.Size = new System.Drawing.Size(100, 20);
            this.tbTerm.TabIndex = 5;
            // 
            // gbGroup
            // 
            this.gbGroup.Controls.Add(this.cbExistGroup);
            this.gbGroup.Controls.Add(this.rbGroup);
            this.gbGroup.Controls.Add(this.tbNewGroup);
            this.gbGroup.Controls.Add(this.rbNGroup);
            this.gbGroup.Location = new System.Drawing.Point(16, 92);
            this.gbGroup.Name = "gbGroup";
            this.gbGroup.Size = new System.Drawing.Size(164, 131);
            this.gbGroup.TabIndex = 6;
            this.gbGroup.TabStop = false;
            this.gbGroup.Text = "Group";
            // 
            // cbExistGroup
            // 
            this.cbExistGroup.FormattingEnabled = true;
            this.cbExistGroup.Location = new System.Drawing.Point(7, 42);
            this.cbExistGroup.Name = "cbExistGroup";
            this.cbExistGroup.Size = new System.Drawing.Size(121, 21);
            this.cbExistGroup.TabIndex = 5;
            // 
            // rbGroup
            // 
            this.rbGroup.AutoSize = true;
            this.rbGroup.Checked = true;
            this.rbGroup.Location = new System.Drawing.Point(7, 19);
            this.rbGroup.Name = "rbGroup";
            this.rbGroup.Size = new System.Drawing.Size(79, 17);
            this.rbGroup.TabIndex = 4;
            this.rbGroup.TabStop = true;
            this.rbGroup.Text = "Exist Group";
            this.rbGroup.UseVisualStyleBackColor = true;
            this.rbGroup.CheckedChanged += new System.EventHandler(this.rbGroup_CheckedChanged);
            // 
            // tbNewGroup
            // 
            this.tbNewGroup.Enabled = false;
            this.tbNewGroup.Location = new System.Drawing.Point(7, 103);
            this.tbNewGroup.Name = "tbNewGroup";
            this.tbNewGroup.Size = new System.Drawing.Size(100, 20);
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
            // bOk
            // 
            this.bOk.Location = new System.Drawing.Point(57, 230);
            this.bOk.Name = "bOk";
            this.bOk.Size = new System.Drawing.Size(75, 23);
            this.bOk.TabIndex = 7;
            this.bOk.Text = "Ok";
            this.bOk.UseVisualStyleBackColor = true;
            this.bOk.Click += new System.EventHandler(this.bOk_Click);
            // 
            // AddWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(190, 259);
            this.Controls.Add(this.bOk);
            this.Controls.Add(this.gbGroup);
            this.Controls.Add(this.tbTerm);
            this.Controls.Add(this.lTermAdd);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.lLastNameAdd);
            this.Controls.Add(this.lFirstNameAdd);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddWindow";
            this.gbGroup.ResumeLayout(false);
            this.gbGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.RadioButton rbGroup;
        private System.Windows.Forms.TextBox tbNewGroup;
        private System.Windows.Forms.RadioButton rbNGroup;
        private System.Windows.Forms.Button bOk;
    }
}