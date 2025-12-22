using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.KadralinovaAT.Sprint7.Project.V7
{
    public partial class FormAddStr : Form
    {
        FormMain fmain;
        public FormAddStr(FormMain form)
        {
            InitializeComponent();
            this.fmain = form;
        }

        private void buttonAddStr_KAT_Click(object sender, EventArgs e)
        {
                fmain.dataGridViewTab_KAT.Rows.Add(textBoxNumP_KAT.Text, textBoxNumRoom_KAT.Text, textBoxRoom_KAT.Text, textBoxS_KAT.Text, comboBoxDolg_KAT.Text, textBoxChild_KAT.Text);
                this.Close();
        }
        private void textBoxNumP_KAT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void textBoxNumRoom_KAT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void textBoxRoom_KAT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void textBoxS_KAT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }
        private void textBoxChild_KAT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }
    }
}
