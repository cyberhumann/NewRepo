using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GaulHighschool
{
    public partial class Teacher1 : Form
    {
        SqlConnection sConn = new SqlConnection();
        SqlCommand sCmd = new SqlCommand();
        string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\KOSTA\source\repos\WinApp2\MyTable.mdf;Integrated Security=True;Connect Timeout=30";
        int nConn;

        public string GetToken(int n, string str, string sep = ",") // ","
        {
            int i, j, k;  // local index
            int n1 = 0, n2 = 0, n3 = 0;  // temp int 변수
            string sRet;

            for (i = 0, n1 = 0; i < n; i++)  // 0  1  2  3  4  5 ...
            {   // IndexOf : 문자가 없을 경우 -1
                n1 = str.IndexOf(sep, n1) + 1;  // i 번째 구분자   
                if (n1 == 0) return "";
            }   // n1 : n 번째 필드 시작

            n2 = str.IndexOf(sep, n1);  // n+1 번째 구분자
            if (n2 == -1) n2 = str.Length;
            n3 = n2 - n1;  // 문자열 길이 계산

            sRet = str.Substring(n1, n3);
            return sRet;
        }
        public int RunSql(string sSql)
        {
            try
            {
                sCmd.CommandText = sSql;
                int i, j, k;
                // "select....   Select ...
                string s1 = GetToken(0, sSql, " ").ToUpper();  // "SELECT FCODE,FNAME FROM FACILITY"
                if (s1 != "SELECT")
                    sCmd.ExecuteNonQuery(); // return 값이 없는 쿼리문 (ex) insert/update/delete
                else     //  쿼리문이 Select 인 경우
                {
                    SqlDataReader sr = sCmd.ExecuteReader();    // select 문 처리결과 수신

                    dataGridView1.Columns.Clear();
                    dataGridView1.Rows.Clear();

                    for (i = 0; i < sr.FieldCount; i++)
                    {
                        dataGridView1.Columns.Add(sr.GetName(i), sr.GetName(i));
                    }
                    for (i = 0; sr.Read(); i++)  // 처리할 데이터가 있으면 1라인씩 처리
                    {
                        if (dataGridView1.RowCount < i + 2) dataGridView1.Rows.Add();
                        for (j = 0; j < sr.FieldCount; j++)
                        {
                            object o2 = sr.GetValue(j);
                            string buf = $"{o2}";
                            dataGridView1.Rows[i].Cells[j].Value = buf;
                            //dataGridView1.Rows[i].Cells[j].Value = $"{sr.GetValue(j)}";
                        }
                    }
                    sr.Close();
                }

            }
            catch (Exception e1)
            {

            }

            return 0;
        }

        public Teacher1()
        {
            InitializeComponent();

            sConn.ConnectionString = connString;
            sConn.Open();
            nConn = 1;  //0이면 꺼지고 1이면 켜짐
            sCmd.Connection = sConn;

            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox4.SelectedIndex = 0;
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            sConn.Close();
            nConn = 0;
            Teacher2 dlg = new Teacher2();
            dlg.ShowDialog();
        }

        private void btnInquiry_Click(object sender, EventArgs e)
        {
            if (nConn == 0) { sConn.Open(); nConn = 1; }

            string classnum;
            if (comboBox1.Text == "1") { classnum = "WHERE id LIKE '21%'"; }
            else if (comboBox1.Text == "2") { classnum = "WHERE id LIKE '22%'"; }
            else if (comboBox1.Text == "3") { classnum = "WHERE id LIKE '23%'"; }
            else { classnum = ""; }
                
            string subject, subject2="";
            if (comboBox2.Text == "국어") { subject = "SELECT id, name, kor"; subject2 = "kor";  }
            else if (comboBox2.Text == "영어") { subject = "SELECT id, name, eng"; subject2 = "eng"; }
            else if (comboBox2.Text == "수학") { subject = "SELECT id, name, mat"; subject2 = "mat"; }
            else { subject = "SELECT id, name, kor,eng, mat, avg"; subject2 = "avg"; }

            string rank="", order="";
            if (comboBox4.Text == "학번순") { order = "ORDER BY id ASC"; } 
            else { rank = $",RANK() OVER (ORDER BY {subject2} DESC) as rank"; }



            string sql = $"{subject} {rank} FROM Grade {classnum} {order}";
            RunSql(sql);
        }

        private void Teacher1_FormClosed(object sender, FormClosedEventArgs e)
        {
            sConn.Close();
            nConn = 0;
        }

        private void btnStatic_Click(object sender, EventArgs e)
        {
            sConn.Close();
            nConn = 0;
            Teacher3 dlg = new Teacher3();
            dlg.ShowDialog();
        }
    }
}
