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
    public partial class Student : Form
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

        public string GetScore(string Colname, string Keyname)
        {
            string sql = $"Select {Colname} from Grade where id='{Keyname}'";
            sCmd.CommandText = sql;

            string sRet = sCmd.ExecuteScalar().ToString();
            return sRet;
        }

        public string GetRank(string Colname, string Keyname, int GetClassRank=0) {
            string Rank="";
            string sSql = "";

            if (GetClassRank == 1) sSql = $"SELECT id, {Colname}, RANK() OVER (ORDER BY {Colname} DESC) as rank FROM Grade WHERE id LIKE '{Keyname.Substring(0,2)}%'"; 
            else sSql = $"SELECT id, {Colname}, RANK() OVER (ORDER BY {Colname} DESC) as rank FROM Grade"; 

            RunSql(sSql);

            for (int i = 0; i < dataGridView1.Rows.Count + 1; i++) {
                if (dataGridView1.Rows[i].Cells[0].Value.ToString() == Keyname) 
                { 
                Rank = dataGridView1.Rows[i].Cells[2].Value.ToString();
                break; 
                }
            }

            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();

            return Rank;

        }

        public string GetCount(string Colname, string Keyname, int GetClassCount=0) 
        {
            string sCount = "";
            string sSql = "";

            if (GetClassCount == 1) sSql = $"SELECT COUNT({Colname}) FROM Grade WHERE id LIKE '{Keyname.Substring(0, 2)}%'";
            else sSql = $"SELECT COUNT({Colname}) FROM Grade";

            sCmd.CommandText = sSql;

            sCount = sCmd.ExecuteScalar().ToString();
            return sCount;
        }

        public bool IDValidCheck(string Keyname) 
        {
            string sql = $"Select id from Grade where id='{Keyname}'";
            int iID;
            string sID;
            sCmd.CommandText = sql;
            try 
            {
                iID = (int)sCmd.ExecuteScalar();
                if (iID == 0) return false;
                else return true;
            }
            catch (Exception ex) {
                return false; }
        }

        public Student()
        {
            InitializeComponent();

            sConn.ConnectionString = connString;
            sConn.Open();
            nConn = 1;  //0이면 꺼지고 1이면 켜짐
            sCmd.Connection = sConn;
        }

        

        private void button1_Click(object sender, EventArgs e)
        {

            string sID = tbNum.Text;

            if (IDValidCheck(sID) == true) 
            {
                ScoreKor.Text = GetScore("kor", sID);
                ScoreEng.Text = GetScore("eng", sID);
                ScoreMat.Text = GetScore("mat", sID);
                ScoreAvg.Text = GetScore("avg", sID);

                TotRankKor.Text = $"{GetRank("kor", sID)}/{GetCount("kor", sID)}";
                TotRankEng.Text = $"{GetRank("eng", sID)}/{GetCount("eng", sID)}";
                TotRankMat.Text = $"{GetRank("mat", sID)}/{GetCount("mat", sID)}";
                TotRankAvg.Text = $"{GetRank("avg", sID)}/{GetCount("avg", sID)}";

                ClassRankKor.Text = $"{GetRank("kor", sID, 1)}/{GetCount("kor", sID, 1)}";
                ClassRankEng.Text = $"{GetRank("eng", sID, 1)}/{GetCount("eng", sID, 1)}";
                ClassRankMat.Text = $"{GetRank("mat", sID, 1)}/{GetCount("mat", sID, 1)}";
                ClassRankAvg.Text = $"{GetRank("avg", sID, 1)}/{GetCount("avg", sID, 1)}";
            }
            else { MessageBox.Show("학번을 똑바로 입력하세요ㅎ"); }

            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("이의신청은 거절한다");
        }

        private void Student_FormClosed(object sender, FormClosedEventArgs e)
        {
            sConn.Close();
            nConn = 0;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Student_Load(object sender, EventArgs e)
        {

        }
    }
}
