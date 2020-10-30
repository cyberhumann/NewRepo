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
    public partial class Teacher2 : Form
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
                    sr.Close();
                }

            }
            catch (Exception e1)
            {

            }

            return 0;
        }

        public Teacher2()
        {
            InitializeComponent();

            sConn.ConnectionString = connString;
            sConn.Open();
            nConn = 1;
            sCmd.Connection = sConn;

        }

        public bool RangeCheck(string Score) {
            if (int.Parse(Score) <= 100 && int.Parse(Score) >= 0) return true;
            else return false; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sID, sName, sKor, sEng, sMat, sAvg;

            sID = textBox1.Text;
            sName = textBox2.Text;
            sKor = textBox3.Text;
            sEng = textBox4.Text;
            sMat = textBox5.Text;

            if (RangeCheck(sKor) || RangeCheck(sEng) || RangeCheck(sMat)) 
            {
                sAvg = string.Format("{0:f2}", (double)(int.Parse(sKor) + int.Parse(sEng) + int.Parse(sMat)) / 3);

                string sSql = $"INSERT INTO Grade (id, name, kor, eng, mat, avg) VALUES ('{sID}', '{sName}', {sKor}, {sEng}, {sMat}, {sAvg})";

                RunSql(sSql);

                sConn.Close();
                nConn = 0;
                this.Close();
            }

            else { MessageBox.Show("입력가능한 범위는 0~100이다"); }

            
        }

        private void Teacher2_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (nConn == 1) { nConn = 0; sConn.Close(); }
        }
    }
}
