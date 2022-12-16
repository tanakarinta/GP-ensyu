using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Data.SQLite;

namespace SportsClubSystem
{
    public partial class Member_fix : Form
    {
        public Member_fix()
        {
            InitializeComponent();
            this.Load += Member_fix_load;
        }

        private void Member_fix_load(object sender, EventArgs e)
        {
            //データ表示
            using (SQLiteConnection con = new SQLiteConnection("Data Source=member.db"))
            {
                //DataTableを生成
                var dataTabel = new DataTable();
                //SQLの実行
                var adapter = new SQLiteDataAdapter("SELECT * FROM t_product", con);

                adapter.Fill(dataTabel);
                dataGridView_f.DataSource = dataTabel;
                dataGridView_f.Columns[0].HeaderText = "会員番号";
                dataGridView_f.Columns[1].HeaderText = "氏名";
                dataGridView_f.Columns[2].HeaderText = "住所";
                dataGridView_f.Columns[3].HeaderText = "電話番号";
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            //戻るボタン
            this.Close();//この画面を閉じる
            Sub_menu sub = new Sub_menu();
            sub.Visible = true;//サブメニュー画面を表示
        }

        private void fixButton_Click(object sender, EventArgs e)
        {
            //確認表示
            DialogResult result = MessageBox.Show("修正してもよろしいですか？", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)//OKボタンを押したら
            {
                //ボックスが空もしくは数字以外
                if (String.IsNullOrEmpty(idBox.Text)|| !numberBox.Text.All(char.IsDigit))
                {
                    //エラーを表示
                    DialogResult error = MessageBox.Show("会員番号を半角数字で入力してください。", "注意", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //修正情報が全部空なら
                else if (!String.IsNullOrEmpty(nameBox.Text) || !String.IsNullOrEmpty(numberBox.Text) ||
                    !String.IsNullOrEmpty(addressBox.Text))
                {
                    //電話番号が数字だったら
                    if (numberBox.Text.All(char.IsDigit))
                    {
                        //データ修正
                        using (SQLiteConnection con = new SQLiteConnection("Data Source=member.db"))
                        {
                            con.Open();
                            using (SQLiteTransaction trans = con.BeginTransaction())
                            {
                                SQLiteCommand cmd = con.CreateCommand();
                                //入力があったら
                                if (!String.IsNullOrEmpty(nameBox.Text))
                                {
                                    //名前
                                    cmd.CommandText = "UPDATE t_product set member_name = @Name WHERE member_id = @Id";
                                    //パラメータセット
                                    cmd.Parameters.Add("Name", DbType.String);
                                    cmd.Parameters.Add("Id", DbType.Int64);
                                    //データ追加
                                    cmd.Parameters["Name"].Value = nameBox.Text;
                                    cmd.Parameters["Id"].Value = int.Parse(idBox.Text);
                                    cmd.ExecuteNonQuery();
                                }
                                if (!String.IsNullOrEmpty(addressBox.Text))
                                {
                                    //住所
                                    cmd.CommandText = "UPDATE t_product set member_address = @Address WHERE member_id = @Id";
                                    //パラメータセット
                                    cmd.Parameters.Add("Address", DbType.String);
                                    cmd.Parameters.Add("Id", DbType.Int64);
                                    //データ追加
                                    cmd.Parameters["Address"].Value = addressBox.Text;
                                    cmd.Parameters["Id"].Value = int.Parse(idBox.Text);
                                    cmd.ExecuteNonQuery();
                                }
                                if (!String.IsNullOrEmpty(numberBox.Text))
                                {
                                    //電話番号
                                    cmd.CommandText = "UPDATE t_product set member_phone_number = @Number WHERE member_id = @Id";
                                    //パラメータセット
                                    cmd.Parameters.Add("Number", DbType.String);
                                    cmd.Parameters.Add("Id", DbType.Int64);
                                    //データ追加
                                    cmd.Parameters["Number"].Value = numberBox.Text;
                                    cmd.Parameters["Id"].Value = int.Parse(idBox.Text);
                                    cmd.ExecuteNonQuery(); 
                                }
                                //コミット
                                trans.Commit();
                                string serchId = idBox.Text;
                                //DataTableを生成
                                var dataTabel = new DataTable();
                                //会員番号と検索番号が同じ行を表示
                                var adapter = new SQLiteDataAdapter("SELECT * FROM t_product WHERE t_product.member_id LIKE " + serchId, con);

                                adapter.Fill(dataTabel);
                                dataGridView_f.DataSource = dataTabel;
                            }
                        }
                    }
                    else
                    {
                        //エラーを表示
                        DialogResult error = MessageBox.Show("電話番号は半角数字のみで入力してください。", "注意", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    //エラーを表示
                    DialogResult error = MessageBox.Show("修正するデータを入力してください。", "注意", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            //データ表示
            using (SQLiteConnection con = new SQLiteConnection("Data Source=member.db"))
            {
                //検索番号を格納
                string serchId = idBox.Text;
                if (serchId == "")
                {
                    //DataTableを生成
                    var dataTabel = new DataTable();
                    //SQLの実行
                    var adapter = new SQLiteDataAdapter("SELECT * FROM t_product", con);

                    adapter.Fill(dataTabel);
                    dataGridView_f.DataSource = dataTabel;
                }
                else
                {
                    //数字なら
                    if (serchId.All(char.IsDigit))
                    {
                        //DataTableを生成
                        var dataTabel = new DataTable();
                        //会員番号と検索番号が同じ行を表示
                        var adapter = new SQLiteDataAdapter("SELECT * FROM t_product WHERE t_product.member_id LIKE " + serchId, con);

                        adapter.Fill(dataTabel);
                        dataGridView_f.DataSource = dataTabel;
                    }
                    else
                    {
                        //数字じゃなければエラーメッセージ
                        DialogResult result = MessageBox.Show("数字以外は入力出来ません。", "注意", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
