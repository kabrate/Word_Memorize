using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Mem_Word
{
    public partial class Save : Form
    {
        OpenFileDialog ofd = new OpenFileDialog();
        string voice;//声音文件路径
        int Time;
        public Save()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //try
            //{
            SQLiteConnection conn = new SQLiteConnection("Data Source=memorize.db;");
            conn.Open();
            SQLiteCommand cmd = conn.CreateCommand();
            //cmd.CommandText = string.Format("INSERT INTO Word VALUES('{0}','{1}','{2}','{3}','{4}',{5},{6})", Word.Text, Meaning.Text, Prct.Text, voice, Example.Text, Common.Time(), 0);

            cmd.CommandText = "INSERT INTO Word VALUES(@Word,@Meaning,@Prct,@mp3,@Example,@Date,@Time)";
            SQLiteParameter[] parameters = {
            new SQLiteParameter("@Word"),
            new SQLiteParameter("@Meaning"),
            new SQLiteParameter("@Prct"),
            new SQLiteParameter("@mp3"),
            new SQLiteParameter("@Example"),
            new SQLiteParameter("@Date"),
            new SQLiteParameter("@Time")};
            parameters[0].Value = Word.Text;
            parameters[1].Value = Meaning.Text;
            parameters[2].Value = Prct.Text;
            parameters[3].Value = voice;
            parameters[4].Value = Example.Text;
            parameters[5].Value = Common.Time();
            parameters[6].Value = 0;
            for (int i = 0; i < parameters.Length; i++)
            {
                cmd.Parameters.Add(parameters[i]);
            }
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("存入成功");
            voice = null;
            Word.Text = "";
            Prct.Text = "";
            Meaning.Text = "";
            Example.Text = "";

            //cmd.CommandText = string.Format("INSERT INTO Word VALUES('{0}','{1}','{2}','{3}','{4}',{5},{6})", Word.Text, Meaning.Text, Prct.Text, Byte, Example.Text, Common.Time(), 0);
            //cmd.CommandText = "INSERT INTO Word VALUES(@Word,@Meaning,@Prct,@mp3,@Example,@Date,@Time)";
            //SQLiteParameter[] parameters = {
            //new SQLiteParameter("@Word"),
            //new SQLiteParameter("@Meaning"),
            //new SQLiteParameter("@Prct"),
            //new SQLiteParameter("@mp3"),
            //new SQLiteParameter("@Example"),
            //new SQLiteParameter("@Date"),
            //new SQLiteParameter("@Time")};
            //parameters[0].Value = Word.Text;
            //parameters[1].Value = Meaning.Text;
            //parameters[2].Value = Prct.Text;
            //parameters[3].Value = Byte;
            //parameters[4].Value = Example.Text;
            //parameters[5].Value = Common.Time();
            //parameters[6].Value = 0;
            //for (int i = 0; i < parameters.Length; i++)
            //{
            //    cmd.Parameters.Add(parameters[i]);
            //}
            //cmd.ExecuteNonQuery();  
            //conn.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("存入失败");

            //}


        }

        private void button3_Click(object sender, EventArgs e)
        {
            ofd.Multiselect = false;
            ofd.Filter = "声音(*.mp3)|*.mp3";  //过滤文件类型  只显示bmp jpg gif文件
            if (ofd.ShowDialog() == DialogResult.OK)//如果正常打开图片的话
            {
                voice = ofd.FileName;
                voice = voice.Replace("C:\\Users\\付景昌\\Desktop\\Mem_Word\\Mem_Word\\bin\\Debug\\","");
               //System.IO.FileStream fs = new System.IO.FileStream(ofd.FileName, System.IO.FileMode.Open, System.IO.FileAccess.Read);
               //byte[] Byte = new byte[fs.Length];
               //fs.Read(Byte, 0, (int)fs.Length);
               //fs.Close();
               //fs = null;
               //SQLiteConnection conn = new SQLiteConnection("Data Source=memorize.db;");
               //conn.Open();
               //SQLiteCommand cmd = conn.CreateCommand();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
