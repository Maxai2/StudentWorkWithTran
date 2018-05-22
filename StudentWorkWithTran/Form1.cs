﻿using System;
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
        public Library _db = new Library();
        private bool notchange = true;


        List<Student> students = new List<Student>();
        public List<Group> groups = new List<Group>();
        //-------------------------------------------------------------------------
        public fStudentWork()
        {
            InitializeComponent();


            if (!_db.OpenConnection())
            {
                MessageBox.Show("Some Errors!");
                return;
            }

            groups = _db.GetGroups();

            if (groups != null)
            {
                cbGroups.DataSource = groups;
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

                cbCurrentGroup.DataSource = groups;
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
        private void cbCurrentGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        //-------------------------------------------------------------------------
        private void bAdd_Click(object sender, EventArgs e)
        {
            var addWindow = new AddWindow(groups, _db) { Owner = this };

            if (addWindow.ShowDialog() == DialogResult.OK)
            {
                
            }
        }
        //-------------------------------------------------------------------------

    }
}
