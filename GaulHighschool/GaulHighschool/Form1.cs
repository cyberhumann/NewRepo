using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GaulHighschool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            Student dlg = new Student();
            dlg.ShowDialog();
        }

        private void btnTeacher_Click(object sender, EventArgs e)
        {
            Teacher dlg = new Teacher();
            dlg.ShowDialog();
        }
    }
}
