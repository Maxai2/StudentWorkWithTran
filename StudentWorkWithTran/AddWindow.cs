using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentWorkWithTran
{
    public partial class AddWindow : Form
    {
        public Student student { get; set; }
        public Group group { get; set; }

        Library _db;

        List<Faculties> facultiesStud;
        List<Faculties> facultiesGroup;
        List<Group> Groups;

        bool canClose = true;

        public AddWindow(List<Group> groups, Library db)
        {
            InitializeComponent();

            _db = db;

            facultiesStud = new List<Faculties>();
            facultiesGroup = new List<Faculties>();

            facultiesStud = _db.GetFaculties();
            facultiesGroup = _db.GetFaculties();

            Groups = groups;

            cbExistGroup.DataSource = Groups;
            cbExistGroup.DisplayMember = "Info";
            cbExistGroup.ValueMember = "Id";

            cbFaculties.DataSource = facultiesStud;
            cbFaculties.DisplayMember = "Info";
            cbFaculties.ValueMember = "Id";
            
            cbFacultiesForNewGroup.DataSource = facultiesGroup;
            cbFacultiesForNewGroup.DisplayMember = "Info";
            cbFacultiesForNewGroup.ValueMember = "Id";

            tbTerm.Text = "1";
        }
        //-------------------------------------------------------
        private bool change = true;

        private void rbGroup_CheckedChanged(object sender, EventArgs e)
        {
            cbExistGroup.Enabled = !change;
            tbNewGroup.Enabled = change;
            cbFaculties.Enabled = change;

            change = !change;
        }
        //-------------------------------------------------------
        private void bAddStudent_Click(object sender, EventArgs e)
        {
            if (tbFirstName.Text == "" || tbLastName.Text == "")
            {
                MessageBox.Show("First or Last name is empty!");
                canClose = false;
                return;
            }

            if (rbEGroup.Checked == true)
                _db.AddStudentGroup(tbFirstName.Text, tbLastName.Text, Convert.ToInt32(tbTerm.Text), cbExistGroup.SelectedIndex + 2);
            else
            {
                string tempGroup = tbNewGroup.Text;

                if (HaveGroup(tempGroup))
                {
                    MessageBox.Show($"'{tempGroup}' is exist!");
                    canClose = false;
                    return;
                }
                else
                {
                    _db.AddStudentGroup(tbFirstName.Text, tbLastName.Text, Convert.ToInt32(tbTerm.Text), -1, tempGroup, cbFaculties.SelectedIndex);

                    group = new Group();

                    group.Id = _db.GetNewGroupId();
                    group.Name = tempGroup;
                    group.Id_Faculty = cbFaculties.SelectedIndex;
                }
            }

            student = new Student();

            student.Id = _db.GetNewStudId();
            student.FirstName = tbFirstName.Text;
            student.LastName = tbLastName.Text;
            student.Term = Convert.ToInt32(tbTerm.Text);
        }
        //-------------------------------------------------------
        private void bAddGroup_Click(object sender, EventArgs e)
        {
            string tempGroup = tbGroupName.Text;

            if (tempGroup == "")
            {
                MessageBox.Show("Group name is empty!");
                canClose = false;
                return;
            }

            if (HaveGroup(tempGroup))
            {
                MessageBox.Show($"'{tempGroup}' is exist!");
                canClose = false;
            }
            else
            {
                _db.AddGroup(tempGroup, cbFacultiesForNewGroup.SelectedIndex);

                group = new Group();

                group.Id = _db.GetNewGroupId();
                group.Name = tempGroup;
                group.Id_Faculty = cbFacultiesForNewGroup.SelectedIndex;
            }
        }
        //-------------------------------------------------------
        private bool HaveGroup(string groupName)
        {
            for (int i = 0; i < Groups.Count; i++)
            {
                if (Groups[i].Name == groupName)
                {
                    return true;
                }
            }

            return false;
        }
        //-------------------------------------------------------
        private void AddWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!canClose)
            {
                e.Cancel = true;
                canClose = true;
            }
        }
        //-------------------------------------------------------
    }
}
