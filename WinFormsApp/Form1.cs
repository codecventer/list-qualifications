using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        ArrayList al = new ArrayList();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtDept.Text != "" && txtYears.Text != "")
            {
                if (lstQuals.Items.Contains(txtName.Text))
                {
                    MessageBox.Show(txtName.Text + " qualification has already been added!", "Duplicate");
                } else
                {
                    al.Add(txtName.Text);
                    lstQuals.Items.AddRange(new object[]
                    {
                        txtName.Text
                    });
                    txtName.Text = "";
                    txtDept.Text = "";
                    txtYears.Text = "";
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            lstQuals.Items.Remove(lstQuals.SelectedItem);
        }
    }
}
