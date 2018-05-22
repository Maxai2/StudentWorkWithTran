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
    public partial class AddWindow : Form
    {
        public Student student { get; set; }

        public AddWindow(List<Group> groups)
        {
            InitializeComponent();

            cbExistGroup.DataSource = groups;
            cbExistGroup.DisplayMember = "Info";
            cbExistGroup.ValueMember = "Id";

            tbTerm.Text = "1";
        }
        //-------------------------------------------------------
        private void bOk_Click(object sender, EventArgs e)
        {

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
