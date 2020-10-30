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
    public partial class Teacher3 : Form
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

        public Teacher3()
        {
            InitializeComponent();

            sConn.ConnectionString = connString;
            sConn.Open();
            nConn = 1;
            sCmd.Connection = sConn;
        }

        public string GetAvg(string Colname, string Classnum)
        {
            string sSql = "";
            int iSum = 0;
            double dAvg=0;

            if (Classnum == "Total") sSql = $"SELECT id, {Colname} FROM Grade";
            else sSql = $"SELECT id, {Colname} FROM Grade WHERE id LIKE '{Classnum}%'";

            RunSql(sSql);

            for (int i = 0; i < dataGridView1.Rows.Count-1 ; i++) iSum += int.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString());

            dAvg = (double)iSum / (dataGridView1.Rows.Count-1);

            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();

            return dAvg.ToString();
        }

        public void InputData(string Colname) 
        {
            string sSql = "";
            int iVal = 0;

            sSql = $"SELECT id, {Colname} FROM Grade";

            RunSql(sSql);

            chart1.Series[0].Points.Clear();

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++) 
            {
                iVal = int.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString());
                chart1.Series[0].Points.Add(iVal);
            }
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();

        }



        private void btnKor_Click(object sender, EventArgs e)
        {



            InputData("kor");
            lblClass1.Text = GetAvg("kor","21");
            lblClass2.Text = GetAvg("kor", "22");
            lblClass3.Text = GetAvg("kor", "23");
            lblClassTotal.Text = GetAvg("kor", "Total");
            lblLabel.Text = "국어 성적 분포";

        }

        private void btnEng_Click(object sender, EventArgs e)
        {
            InputData("eng");
            lblClass1.Text = GetAvg("eng", "21");
            lblClass2.Text = GetAvg("eng", "22");
            lblClass3.Text = GetAvg("eng", "23");
            lblClassTotal.Text = GetAvg("eng", "Total");
            lblLabel.Text = "영어 성적 분포";
        }

        private void btnMat_Click(object sender, EventArgs e)
        {
            InputData("mat");
            lblClass1.Text = GetAvg("mat", "21");
            lblClass2.Text = GetAvg("mat", "22");
            lblClass3.Text = GetAvg("mat", "23");
            lblClassTotal.Text = GetAvg("mat", "Total");
            lblLabel.Text = "수학 성적 분포";
        }

        private void Teacher3_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (nConn == 1) { nConn = 0; sConn.Close(); }
        }

        private void Teacher3_Load(object sender, EventArgs e)
        {

        }
    }
}
