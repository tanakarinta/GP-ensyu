using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace SportsClubSystem
{
    public partial class Member_registration : Form
    {
        public Member_registration()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //戻るボタン
            this.Close();//この画面を閉じる
            Sub_menu sub = new Sub_menu();
            sub.Visible = true;//サブメニュー画面を表示
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //データ追加
            using (SQLiteConnection con = new SQLiteConnection("Data Source=member.db"))
            {
                con.Open();
                using (SQLiteTransaction trans = con.BeginTransaction())
                {
                    SQLiteCommand cmd = con.CreateCommand();
                    //インサート
                    cmd.CommandText = "INSERT INTO t_product (member_name, member_address, member_phone_number) VALUES (@Name, @Address, @Number)";
                    //パラメータセット
                    cmd.Parameters.Add("Name", DbType.String);
                    cmd.Parameters.Add("Address", DbType.String);
                    cmd.Parameters.Add("Number", DbType.String);
                    //データ追加
                    cmd.Parameters["Name"].Value = textBox1.Text;
                    cmd.Parameters["Address"].Value = textBox3.Text;
                    cmd.Parameters["Number"].Value = textBox2.Text;
                    cmd.ExecuteNonQuery();
                    //コミット
                    trans.Commit();
                }
            }
        }
    }
}
