namespace GaulHighschool
{
    partial class Student
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNum = new System.Windows.Forms.TextBox();
            this.btnsInquiry = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TotRankKor = new System.Windows.Forms.Label();
            this.ClassRankKor = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.ScoreEng = new System.Windows.Forms.Label();
            this.TotRankEng = new System.Windows.Forms.Label();
            this.ClassRankEng = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.ScoreMat = new System.Windows.Forms.Label();
            this.TotRankMat = new System.Windows.Forms.Label();
            this.ClassRankMat = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.ScoreAvg = new System.Windows.Forms.Label();
            this.TotRankAvg = new System.Windows.Forms.Label();
            this.ClassRankAvg = new System.Windows.Forms.Label();
            this.ScoreKor = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 18F);
            this.label1.Location = new System.Drawing.Point(29, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "중간고사 성적 확인";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 12F);
            this.label2.Location = new System.Drawing.Point(34, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "학번을 입력하세요";
            // 
            // tbNum
            // 
            this.tbNum.Location = new System.Drawing.Point(229, 80);
            this.tbNum.Name = "tbNum";
            this.tbNum.Size = new System.Drawing.Size(219, 25);
            this.tbNum.TabIndex = 2;
            // 
            // btnsInquiry
            // 
            this.btnsInquiry.Location = new System.Drawing.Point(476, 82);
            this.btnsInquiry.Name = "btnsInquiry";
            this.btnsInquiry.Size = new System.Drawing.Size(75, 23);
            this.btnsInquiry.TabIndex = 3;
            this.btnsInquiry.Text = "확인";
            this.btnsInquiry.UseVisualStyleBackColor = true;
            this.btnsInquiry.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(458, 346);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 41);
            this.button2.TabIndex = 5;
            this.button2.Text = "이의신청";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.TotRankKor, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.ClassRankKor, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.ScoreEng, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.TotRankEng, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.ClassRankEng, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.label15, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.ScoreMat, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.TotRankMat, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.ClassRankMat, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.label19, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.ScoreAvg, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.TotRankAvg, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.ClassRankAvg, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.ScoreKor, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(38, 133);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(513, 207);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(132, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "점수";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(259, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "전체석차";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(386, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "학급석차";
            // 
            // TotRankKor
            // 
            this.TotRankKor.AutoSize = true;
            this.TotRankKor.Location = new System.Drawing.Point(259, 43);
            this.TotRankKor.Name = "TotRankKor";
            this.TotRankKor.Size = new System.Drawing.Size(15, 15);
            this.TotRankKor.TabIndex = 6;
            this.TotRankKor.Text = "-";
            // 
            // ClassRankKor
            // 
            this.ClassRankKor.AutoSize = true;
            this.ClassRankKor.Location = new System.Drawing.Point(386, 43);
            this.ClassRankKor.Name = "ClassRankKor";
            this.ClassRankKor.Size = new System.Drawing.Size(15, 15);
            this.ClassRankKor.TabIndex = 7;
            this.ClassRankKor.Text = "-";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 84);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 15);
            this.label11.TabIndex = 8;
            this.label11.Text = "영어";
            // 
            // ScoreEng
            // 
            this.ScoreEng.AutoSize = true;
            this.ScoreEng.Location = new System.Drawing.Point(132, 84);
            this.ScoreEng.Name = "ScoreEng";
            this.ScoreEng.Size = new System.Drawing.Size(15, 15);
            this.ScoreEng.TabIndex = 9;
            this.ScoreEng.Text = "-";
            // 
            // TotRankEng
            // 
            this.TotRankEng.AutoSize = true;
            this.TotRankEng.Location = new System.Drawing.Point(259, 84);
            this.TotRankEng.Name = "TotRankEng";
            this.TotRankEng.Size = new System.Drawing.Size(15, 15);
            this.TotRankEng.TabIndex = 10;
            this.TotRankEng.Text = "-";
            // 
            // ClassRankEng
            // 
            this.ClassRankEng.AutoSize = true;
            this.ClassRankEng.Location = new System.Drawing.Point(386, 84);
            this.ClassRankEng.Name = "ClassRankEng";
            this.ClassRankEng.Size = new System.Drawing.Size(15, 15);
            this.ClassRankEng.TabIndex = 11;
            this.ClassRankEng.Text = "-";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(5, 125);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(37, 15);
            this.label15.TabIndex = 12;
            this.label15.Text = "수학";
            // 
            // ScoreMat
            // 
            this.ScoreMat.AutoSize = true;
            this.ScoreMat.Location = new System.Drawing.Point(132, 125);
            this.ScoreMat.Name = "ScoreMat";
            this.ScoreMat.Size = new System.Drawing.Size(15, 15);
            this.ScoreMat.TabIndex = 13;
            this.ScoreMat.Text = "-";
            // 
            // TotRankMat
            // 
            this.TotRankMat.AutoSize = true;
            this.TotRankMat.Location = new System.Drawing.Point(259, 125);
            this.TotRankMat.Name = "TotRankMat";
            this.TotRankMat.Size = new System.Drawing.Size(15, 15);
            this.TotRankMat.TabIndex = 14;
            this.TotRankMat.Text = "-";
            // 
            // ClassRankMat
            // 
            this.ClassRankMat.AutoSize = true;
            this.ClassRankMat.Location = new System.Drawing.Point(386, 125);
            this.ClassRankMat.Name = "ClassRankMat";
            this.ClassRankMat.Size = new System.Drawing.Size(15, 15);
            this.ClassRankMat.TabIndex = 15;
            this.ClassRankMat.Text = "-";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(5, 166);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(67, 15);
            this.label19.TabIndex = 16;
            this.label19.Text = "전체평균";
            // 
            // ScoreAvg
            // 
            this.ScoreAvg.AutoSize = true;
            this.ScoreAvg.Location = new System.Drawing.Point(132, 166);
            this.ScoreAvg.Name = "ScoreAvg";
            this.ScoreAvg.Size = new System.Drawing.Size(15, 15);
            this.ScoreAvg.TabIndex = 17;
            this.ScoreAvg.Text = "-";
            // 
            // TotRankAvg
            // 
            this.TotRankAvg.AutoSize = true;
            this.TotRankAvg.Location = new System.Drawing.Point(259, 166);
            this.TotRankAvg.Name = "TotRankAvg";
            this.TotRankAvg.Size = new System.Drawing.Size(15, 15);
            this.TotRankAvg.TabIndex = 18;
            this.TotRankAvg.Text = "-";
            // 
            // ClassRankAvg
            // 
            this.ClassRankAvg.AutoSize = true;
            this.ClassRankAvg.Location = new System.Drawing.Point(386, 166);
            this.ClassRankAvg.Name = "ClassRankAvg";
            this.ClassRankAvg.Size = new System.Drawing.Size(15, 15);
            this.ClassRankAvg.TabIndex = 19;
            this.ClassRankAvg.Text = "-";
            // 
            // ScoreKor
            // 
            this.ScoreKor.AutoSize = true;
            this.ScoreKor.Location = new System.Drawing.Point(132, 43);
            this.ScoreKor.Name = "ScoreKor";
            this.ScoreKor.Size = new System.Drawing.Size(15, 15);
            this.ScoreKor.TabIndex = 5;
            this.ScoreKor.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "국어";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(38, 347);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(302, 67);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.Visible = false;
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 399);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnsInquiry);
            this.Controls.Add(this.tbNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Student";
            this.Text = "Student";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Student_FormClosed);
            this.Load += new System.EventHandler(this.Student_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNum;
        private System.Windows.Forms.Button btnsInquiry;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label TotRankKor;
        private System.Windows.Forms.Label ClassRankKor;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label ScoreEng;
        private System.Windows.Forms.Label TotRankEng;
        private System.Windows.Forms.Label ClassRankEng;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label ScoreMat;
        private System.Windows.Forms.Label TotRankMat;
        private System.Windows.Forms.Label ClassRankMat;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label ScoreAvg;
        private System.Windows.Forms.Label TotRankAvg;
        private System.Windows.Forms.Label ClassRankAvg;
        private System.Windows.Forms.Label ScoreKor;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}