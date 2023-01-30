using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;

namespace SportsClubSystem
{
    public partial class Smember : Form
    {
        public Smember()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //  コネクションを開いてテーブル作成して閉じる
            using(var connection = new SQLiteConnection("Data Source=member.db"))
            {
                connection.Open();
                using(SQLiteCommand command = connection.CreateCommand())
                {
                    //値を定義
                    command.CommandText =
                        "create table t_product(member_id INTEGER PRIMARY KEY AUTOINCREMENT,member_name " +
                        "TEXT,member_address TEXT,member_phone_number TEXT)";
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //データ追加
            using(SQLiteConnection connection=new SQLiteConnection("Data Source=member.db"))
            {
                connection.Open();
                using (SQLiteTransaction trans = connection.BeginTransaction())
                {
                    SQLiteCommand command = connection.CreateCommand();
                    //インサート
                    command.CommandText = "INSERT INTO t_product (member_name, member_address, " +
                        "member_phone_number) VALUES (@Name, @Address, @Number)";
                    //パラメータセット
                    command.Parameters.Add("Name", DbType.String);
                    command.Parameters.Add("Address", DbType.String);
                    command.Parameters.Add("Number", DbType.String);
                    //データ追加
                    command.Parameters["Name"].Value = nameBox.Text;
                    command.Parameters["Address"].Value = addressBox.Text;
                    command.Parameters["Number"].Value = numberBox.Text;
                    command.ExecuteNonQuery();
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
                dataGridViewS.DataSource = dataTabel;
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
                    SQLiteCommand command = con.CreateCommand();
                    //インサート
                    command.CommandText = "UPDATE t_product set member_name = @Name, member_address" +
                        " = @Address, member_phone_number = @Number WHERE member_id = @Id";
                    //パラメータセット
                    command.Parameters.Add("Name", DbType.String);
                    command.Parameters.Add("Address", DbType.String);
                    command.Parameters.Add("Number", DbType.String);
                    command.Parameters.Add("Id", DbType.Int64);
                    //データ追加
                    command.Parameters["Name"].Value = nameFixBox.Text;
                    command.Parameters["Address"].Value = addressFixBox.Text;
                    command.Parameters["Number"].Value = numberFixBox.Text;
                    command.Parameters["Id"].Value = int.Parse(seachCdBox.Text);
                    command.ExecuteNonQuery();
                    //コミット
                    trans.Commit();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //データ削除
            using (SQLiteConnection connection = new SQLiteConnection("Data Source=member.db"))
            {
                connection.Open();
                using (SQLiteTransaction trans = connection.BeginTransaction())    
                {
                    SQLiteCommand command = connection.CreateCommand();
                    //インサート
                    command.CommandText = "DELETE FROM t_product WHERE member_id = @Id";
                    //パラメータセット
                    command.Parameters.Add("Id", DbType.Int64);
                    //データ削除
                    command.Parameters["Id"].Value = int.Parse(searchCdBox.Text);
                    command.ExecuteNonQuery();
                    //コミット
                    trans.Commit();
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //コネクションを開いてテーブル削除して閉じる
            using (var connection = new SQLiteConnection("Data Source=member.db"))
            {
                connection.Open();
                using (SQLiteCommand command = connection.CreateCommand())
                {
                    command.CommandText =
                        "drop table t_product";
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
             //データ表示
            using (SQLiteConnection connection = new SQLiteConnection("Data Source=member.db"))
            {
                //検索番号を格納
                string serchId = seachBox.Text;
                if (serchId == "")
                {
                    //DataTableを生成
                    var dataTabel = new DataTable();
                    //SQLの実行
                    var adapter = new SQLiteDataAdapter("SELECT * FROM t_product", connection);

                    adapter.Fill(dataTabel);
                    dataGridViewS.DataSource = dataTabel;
                }
                else
                {
                    //DataTableを生成
                    var dataTabel = new DataTable();
                    //会員番号と検索番号が同じ行を表示
                    var adapter = new SQLiteDataAdapter("SELECT * FROM t_product WHERE " +
                        "t_product.member_id LIKE " + serchId, connection);

                    adapter.Fill(dataTabel);
                    dataGridViewS.DataSource = dataTabel;
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