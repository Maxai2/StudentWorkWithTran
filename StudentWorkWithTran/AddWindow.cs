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

        public AddWindow(List<Group> groups, Library db)
        {
            InitializeComponent();

            _db = db;

            cbExistGroup.DataSource = groups;
            cbExistGroup.DisplayMember = "Info";
            cbExistGroup.ValueMember = "Id";

            tbTerm.Text = "1";
        }
        //-------------------------------------------------------
        private void bOk_Click(object sender, EventArgs e)
        {
            if (tbFirstName.Text == "" || tbLastName.Text == "")
            {
                MessageBox.Show("First or Last name is empty!");
                return;
            }

            try
            {
                SqlTransaction tran = _db.
            }
            catch (SqlException)
            {

                throw;
            }

            student.FirstName = tbFirstName.Text;
            student.LastName = tbLastName.Text;
            student.Term = Convert.ToInt32(tbTerm.Text);
        }
        //-------------------------------------------------------
        private bool change = true;

        private void rbGroup_CheckedChanged(object sender, EventArgs e)
        {
            cbExistGroup.Enabled = !change;
            tbNewGroup.Enabled = change;

            change = !change;
        }
    }
}
