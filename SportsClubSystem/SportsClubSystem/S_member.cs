using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;

namespace SportsClubSystem
{
    public partial class S_member : Form
    {
        public S_member()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //  コネクションを開いてテーブル作成して閉じる
            using(var con = new SQLiteConnection("Data Source=member.db"))
            {
                con.Open();
                using(SQLiteCommand command = con.CreateCommand())
                {
                    //値を定義
                    command.CommandText =
                        "create table t_product(member_id INTEGER PRIMARY KEY AUTOINCREMENT,member_name " +
                        "TEXT,member_address TEXT,member_phone_number TEXT)";
                    command.ExecuteNonQuery();
                }
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //データ追加
            using(SQLiteConnection con=new SQLiteConnection("Data Source=member.db"))
            {
                con.Open();
                using (SQLiteTransaction trans = con.BeginTransaction())
                {
                    SQLiteCommand cmd = con.CreateCommand();
                    //インサート
                    cmd.CommandText = "INSERT INTO t_product (member_name, member_address, " +
                        "member_phone_number) VALUES (@Name, @Address, @Number)";
                    //パラメータセット
                    cmd.Parameters.Add("Name", DbType.String);
                    cmd.Parameters.Add("Address", DbType.String);
                    cmd.Parameters.Add("Number", DbType.String);
                    //データ追加
                    cmd.Parameters["Name"].Value = textBox1.Text;
                    cmd.Parameters["Address"].Value = textBox2.Text;
                    cmd.Parameters["Number"].Value = textBox7.Text;
                    cmd.ExecuteNonQuery();
                    //コミット
                    trans.Commit();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //データ表示
            using(SQLiteConnection con = new SQLiteConnection("Data Source=member.db"))
            {
                //DataTableを生成
                var dataTabel = new DataTable();
                //SQLの実行
                var adapter = new SQLiteDataAdapter("SELECT * FROM t_product", con);
                adapter.Fill(dataTabel);
                dataGridView1.DataSource = dataTabel;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //データ修正
            using (SQLiteConnection con = new SQLiteConnection("Data Source=member.db"))
            {
                con.Open();
                using (SQLiteTransaction trans = con.BeginTransaction())
                {
                    SQLiteCommand cmd = con.CreateCommand();
                    //インサート
                    cmd.CommandText = "UPDATE t_product set member_name = @Name, member_address" +
                        " = @Address, member_phone_number = @Number WHERE member_id = @Id";
                    //パラメータセット
                    cmd.Parameters.Add("Name", DbType.String);
                    cmd.Parameters.Add("Address", DbType.String);
                    cmd.Parameters.Add("Number", DbType.String);
                    cmd.Parameters.Add("Id", DbType.Int64);
                    //データ追加
                    cmd.Parameters["Name"].Value = textBox3.Text;
                    cmd.Parameters["Address"].Value = textBox8.Text;
                    cmd.Parameters["Number"].Value = textBox4.Text;
                    cmd.Parameters["Id"].Value = int.Parse(textBox5.Text);
                    cmd.ExecuteNonQuery();
                    //コミット
                    trans.Commit();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //データ削除
            using (SQLiteConnection con = new SQLiteConnection("Data Source=member.db"))
            {
                con.Open();
                using (SQLiteTransaction trans = con.BeginTransaction())    
                {
                    SQLiteCommand cmd = con.CreateCommand();
                    //インサート
                    cmd.CommandText = "DELETE FROM t_product WHERE member_id = @Id";
                    //パラメータセット
                    cmd.Parameters.Add("Id", DbType.Int64);
                    //データ削除
                    cmd.Parameters["Id"].Value = int.Parse(textBox6.Text);
                    cmd.ExecuteNonQuery();
                    //コミット
                    trans.Commit();
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //コネクションを開いてテーブル削除して閉じる
            using (var con = new SQLiteConnection("Data Source=member.db"))
            {
                con.Open();
                using (SQLiteCommand command = con.CreateCommand())
                {
                    command.CommandText =
                        "drop table t_product";
                    command.ExecuteNonQuery();
                }
                con.Close();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
             //データ表示
            using (SQLiteConnection con = new SQLiteConnection("Data Source=member.db"))
            {
                //検索番号を格納
                string serchId = textBox9.Text;
                if (serchId == "")
                {
                    //DataTableを生成
                    var dataTabel = new DataTable();
                    //SQLの実行
                    var adapter = new SQLiteDataAdapter("SELECT * FROM t_product", con);

                    adapter.Fill(dataTabel);
                    dataGridView1.DataSource = dataTabel;
                }
                else
                {
                    //DataTableを生成
                    var dataTabel = new DataTable();
                    //会員番号と検索番号が同じ行を表示
                    var adapter = new SQLiteDataAdapter("SELECT * FROM t_product WHERE " +
                        "t_product.member_id LIKE " + serchId, con);

                    adapter.Fill(dataTabel);
                    dataGridView1.DataSource = dataTabel;
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SubMenu sub = new SubMenu();
            sub.Visible = true;//サブメニュー画面を表示
        }
    }
}