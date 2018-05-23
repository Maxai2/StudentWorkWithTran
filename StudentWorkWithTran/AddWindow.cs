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

        Library _db;

        bool canClose = false;

        List<Faculties> faculties;

        public AddWindow(List<Group> groups, Library db)
        {
            InitializeComponent();

            _db = db;

            faculties = _db.GetFaculties();

            cbExistGroup.DataSource = groups;
            cbExistGroup.DisplayMember = "Info";
            cbExistGroup.ValueMember = "Id";

            cbFaculties.DataSource = faculties;
            cbFaculties.DisplayMember = "Info";
            cbFaculties.ValueMember = "Id";

            cbFacultiesForNewGroup.DataSource = faculties;
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
        private void AddWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (canClose)
            {
                student.FirstName = tbFirstName.Text;
                student.LastName = tbLastName.Text;
                student.Term = Convert.ToInt32(tbTerm.Text);
            }
        }
        //-------------------------------------------------------
        private void bAddStudent_Click(object sender, EventArgs e)
        {
            if (tbFirstName.Text == "" || tbLastName.Text == "")
            {
                MessageBox.Show("First or Last name is empty!");
                return;
            }

            canClose = true;

            if (rbEGroup.Checked == true)
                _db.AddStudent(tbFirstName.Text, tbLastName.Text, Convert.ToInt32(tbTerm.Text), cbExistGroup.SelectedIndex);
            else
                _db.AddStudent(tbFirstName.Text, tbLastName.Text, Convert.ToInt32(tbTerm.Text), 0, tbNewGroup.Text, cbFaculties.SelectedIndex);
        }
        //-------------------------------------------------------
        private void bAddGroup_Click(object sender, EventArgs e)
        {
            if (tbGroupName.Text == "")
            {
                MessageBox.Show("Group name is empty!");
                return;
            }

            canClose = true;

            
        }
        //-------------------------------------------------------

    }
}
