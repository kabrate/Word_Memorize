using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
using WMPLib;

namespace Mem_Word
{
    public partial class Review : Form
    {
        public Review()
        {
            InitializeComponent();
        }
        string voice;//声音文件路径
        int Time;//复习次数
        int count = 0;//正在复习的单词序号
        DataTable dt = new DataTable();//存储该复习的结果
        SQLiteDataAdapter da;
        SQLiteConnection conn;
        bool viewed = false;//是否复习完当天的内容
        int remaining;//剩余当天要复习的
        public static WMPLib.WindowsMediaPlayer music_player = new WMPLib.WindowsMediaPlayer();
        private void Review_Load(object sender, EventArgs e)
        {
            conn = new SQLiteConnection("Data Source=memorize.db;");//导出7天的倍数以前记录的单词
            conn.Open();
            SQLiteCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * from Word WHERE (@day-Date)%7=0 AND Time<8 AND @day!=Date";
            SQLiteParameter parameter = new SQLiteParameter("@day");
            parameter.Value = Common.Time();
            cmd.Parameters.Add(parameter);
            cmd.ExecuteNonQuery();
            da = new SQLiteDataAdapter(cmd);//直接把数据结果放到datatable中，           
            da.Fill(dt);
            SQLiteCommandBuilder thisbuilder = new SQLiteCommandBuilder(da);
            //for (int i = 0; i < dt.Rows.Count; i++)//所有该复习的Time加1
            //{
            //voice = dt.Rows[i]["Voice"].ToString();
            //Word.Text = dt.Rows[i]["Word"].ToString();
            //Prct.Text = dt.Rows[i]["Prct"].ToString();
            //Meaning.Text = dt.Rows[i]["Meaning"].ToString();
            //Example.Text = dt.Rows[i]["Example"].ToString();
            //    Time = int.Parse(dt.Rows[i]["Time"].ToString());
            //    Time++;
            //    dt.Rows[i]["Time"] = Time;
            //}
            if (dt.Rows.Count != 0)
            {
                Word.Text = dt.Rows[count]["Word"].ToString();
                Time = int.Parse(dt.Rows[count]["Time"].ToString());
                Time++;
                dt.Rows[count]["Time"] = Time;
                da.Update(dt);//将表中的数据更新  
                label6.Text = dt.Rows.Count.ToString();
                remaining = dt.Rows.Count;
            }
            else
            {
                MessageBox.Show("今天没有要复习的单词");
                this.Close();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Show_Click(object sender, EventArgs e)//显示单词的详细信息
        {
            voice = dt.Rows[count]["Voice"].ToString();
            Prct.Text = dt.Rows[count]["Prct"].ToString();
            Meaning.Text = dt.Rows[count]["Meaning"].ToString();
            Example.Text = dt.Rows[count]["Example"].ToString();
        }

        private void Next_Click(object sender, EventArgs e)//复习下一个单词
        {
            Prct.Text = "";
            Meaning.Text = "";
            Example.Text = "";

            if (count < dt.Rows.Count-1)
            {
                count++;
            }
                
            else
            {
                count = 0;
                viewed = true;
            }
                
            Word.Text = dt.Rows[count]["Word"].ToString();
            if(viewed==false)//当天的复习结束后不再增加复习次数
            {
                Time = int.Parse(dt.Rows[count]["Time"].ToString());
                Time++;
                dt.Rows[count]["Time"] = Time;
                da.Update(dt);//将表中的数据更新  
            }
            if (remaining > 0)
                remaining--;
            else remaining = 0;
            label6.Text = remaining.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(voice!=null)
            music_player.URL = voice;
            
        }


    }
}
