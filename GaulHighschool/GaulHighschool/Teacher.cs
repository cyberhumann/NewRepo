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
    public partial class Teacher : Form
    {
        public Teacher()
        {
            InitializeComponent();
        }

        private void btnPwd_Click(object sender, EventArgs e)
        {
            string pwd = "1024";
            if (tbPwd.Text == pwd)
            {
                Teacher1 dlg = new Teacher1();
                dlg.ShowDialog();
                ActiveForm.Close();
            }
            else if (tbPwd.Text == "") { MessageBox.Show("비번을 입력하지 않으셨네요"); }
            else { MessageBox.Show("비번이 틀리셨네요"); }
        }
    }
}
