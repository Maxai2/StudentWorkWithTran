using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentWorkWithTran
{
    public partial class fStudentWork : Form
    {
        public Library _db = new Library("Library_ru");
        private bool notchange = true;

        List<Student> students = new List<Student>();
        public List<Group> groupList = new List<Group>();
        List<Group> groupStud = new List<Group>();
        //-------------------------------------------------------------------------
        public fStudentWork()
        {
            InitializeComponent();

            if (!_db.OpenConnection())
            {
                MessageBox.Show("Some Errors!");
                Close();
            }

            groupList = _db.GetGroups();
            groupStud = _db.GetGroups();

            if (groupList != null)
            {
                cbGroups.DataSource = groupList;
                cbGroups.DisplayMember = "Info";
                cbGroups.ValueMember = "Id";
            }

            students = _db.GetStudents(1);

            if (students != null)
            {
                lbStudentList.DataSource = students;
                lbStudentList.DisplayMember = "Info";
                lbStudentList.ValueMember = "Id";
            }
        }
        //-------------------------------------------------------------------------
        private void bUpdate_Click(object sender, EventArgs e)
        {
            if (_db.UpdateStudent(tbFirstName.Text, tbLastName.Text, Convert.ToInt32(tbTerm.Text), cbCurrentGroup.SelectedIndex, students[lbStudentList.SelectedIndex].Id))
            {
                int index = lbStudentList.SelectedIndex;

                students[index].FirstName = tbFirstName.Text;
                students[index].LastName = tbLastName.Text;
                students[index].Term = Convert.ToInt32(tbTerm.Text);
                students[index].Id_Group = cbCurrentGroup.SelectedIndex;

                lbStudentList.DataSource = null;
                lbStudentList.Items.Clear();

                lbStudentList.DataSource = students;
                lbStudentList.DisplayMember = "Info";
                lbStudentList.ValueMember = "Id";
            }
        }
        //-------------------------------------------------------------------------
        private void bDelete_Click(object sender, EventArgs e)
        {
            if (_db.DeleteStudent(students[lbStudentList.SelectedIndex].Id))
            {
                students.RemoveAt(lbStudentList.SelectedIndex);

                lbStudentList.DataSource = null;
                lbStudentList.Items.Clear();

                lbStudentList.DataSource = students;
                lbStudentList.DisplayMember = "Info";
                lbStudentList.ValueMember = "Id";
            }
        }
        //-------------------------------------------------------------------------
        private void cbGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (notchange)
            {
                int index = cbGroups.SelectedIndex;

                students.Clear();

                if (students != null)
                {
                    lbStudentList.DataSource = null;
                    lbStudentList.Items.Clear();
                }

                students = _db.GetStudents(index);

                if (students != null && students.Count != 0)
                {
                    lbStudentList.DataSource = students;
                    lbStudentList.DisplayMember = "Info";
                    lbStudentList.ValueMember = "Id";
                }
                else
                {
                    tbFirstName.Clear();
                    tbFirstName.Enabled = false;
                    tbLastName.Clear();
                    tbLastName.Enabled = false;
                    tbTerm.Clear();
                    tbTerm.Enabled = false;

                    cbCurrentGroup.DataSource = null;
                    cbCurrentGroup.Items.Clear();
                    cbCurrentGroup.Enabled = false;

                    bDelete.Enabled = false;
                    bUpdate.Enabled = false;
                }
            }
        }
        //-------------------------------------------------------------------------
        private void lbStudentList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbStudentList.SelectedIndex != -1)
            {
                int index = lbStudentList.SelectedIndex;

                tbFirstName.Text = students[index].FirstName;
                tbLastName.Text = students[index].LastName;
                tbTerm.Text = Convert.ToString(students[index].Term);

                cbCurrentGroup.DataSource = groupStud;
                cbCurrentGroup.DisplayMember = "Info";
                cbCurrentGroup.ValueMember = "Id";
                cbCurrentGroup.SelectedIndex = cbGroups.SelectedIndex;

                tbFirstName.Enabled = true;
                tbLastName.Enabled = true;
                tbTerm.Enabled = true; 
                cbCurrentGroup.Enabled = true;
                notchange = true;

                bDelete.Enabled = true;
                bUpdate.Enabled = true;
            }
        }
        //-------------------------------------------------------------------------
        private void fStudentWork_FormClosing(object sender, FormClosingEventArgs e)
        {
            _db.CloseConnection();
        }
        //-------------------------------------------------------------------------
        private void bAdd_Click(object sender, EventArgs e)
        {
            var addWindow = new AddWindow(groupList, _db) { Owner = this };

            if (addWindow.ShowDialog() == DialogResult.OK)
            {
                if (addWindow.group != null && addWindow.student != null)
                {
                    groupList.Add(addWindow.group);
                    groupStud.Add(addWindow.group);

                    students.Add(addWindow.student);
                }
                else
                if (addWindow.group != null)
                {
                    groupList.Add(addWindow.group);
                    groupStud.Add(addWindow.group);
                }
                else
                if (addWindow.student != null)
                {
                    students.Add(addWindow.student);
                }

                if (students != null)
                {
                    lbStudentList.DataSource = null;
                    lbStudentList.Items.Clear();

                    lbStudentList.DataSource = students;
                    lbStudentList.DisplayMember = "Info";
                    lbStudentList.ValueMember = "Id";
                }

                int lastIndexGroupList = cbGroups.SelectedIndex;

                if (groupList != null)
                {
                    cbGroups.DataSource = null;
                    cbGroups.Items.Clear();

                    cbGroups.DataSource = groupList;
                    cbGroups.DisplayMember = "Info";
                    cbGroups.ValueMember = "Id";
                    cbGroups.SelectedIndex = lastIndexGroupList;
                }

                int lastIndexCurrentGroup = cbCurrentGroup.SelectedIndex;

                if (groupStud != null)
                {
                    cbCurrentGroup.DataSource = null;
                    cbCurrentGroup.Items.Clear();

                    cbCurrentGroup.DataSource = groupStud;
                    cbCurrentGroup.DisplayMember = "Info";
                    cbCurrentGroup.ValueMember = "Id";
                    cbCurrentGroup.SelectedIndex = lastIndexCurrentGroup;
                }

            }
        }
        //-------------------------------------------------------------------------

    }
}
