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
    public partial class Member_fix : Form
    {
        public Member_fix()
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

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("修正してもよろしいですか？", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)//OKボタンを押したら
            {
                //データ修正
                using (SQLiteConnection con = new SQLiteConnection("Data Source=member.db"))
                {
                    con.Open();
                    using (SQLiteTransaction trans = con.BeginTransaction())
                    {
                        SQLiteCommand cmd = con.CreateCommand();
                        //インサート
                        cmd.CommandText = "UPDATE t_product set member_name = @Name, member_address = @Address, member_phone_number = @Number WHERE member_id = @Id";
                        //パラメータセット
                        cmd.Parameters.Add("Name", DbType.String);
                        cmd.Parameters.Add("Address", DbType.String);
                        cmd.Parameters.Add("Number", DbType.String);
                        cmd.Parameters.Add("Id", DbType.Int64);
                        //データ追加
                        cmd.Parameters["Name"].Value = textBox4.Text;
                        cmd.Parameters["Address"].Value = textBox3.Text;
                        cmd.Parameters["Number"].Value = textBox2.Text;
                        cmd.Parameters["Id"].Value = int.Parse(textBox1.Text);
                        cmd.ExecuteNonQuery();
                        //コミット
                        trans.Commit();
                    }
                }
            }
        }
    }
}
