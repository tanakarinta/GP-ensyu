using System;
using System.Data;
using System.Linq;
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

        private void backButton_Click(object sender, EventArgs e)
        {
            //戻るボタン
            this.Close();//この画面を閉じる
            Sub_menu sub = new Sub_menu();
            sub.Visible = true;//サブメニュー画面を表示
        }

        private void registButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("登録してもよろしいですか？", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)//OKボタンを押したら
            {
                //入力項目がすべて入力されていたら
                if (!String.IsNullOrEmpty(nameBox.Text) && !String.IsNullOrEmpty(numberBox.Text) &&
                    !String.IsNullOrEmpty(addressBox.Text))
                {
                    if (numberBox.Text.All(char.IsDigit))
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
                                cmd.Parameters["Name"].Value = nameBox.Text;
                                cmd.Parameters["Address"].Value = addressBox.Text;
                                cmd.Parameters["Number"].Value = numberBox.Text;
                                cmd.ExecuteNonQuery();
                                //コミット
                                trans.Commit();
                                ////会員番号を表示
                                //DialogResult memberId = MessageBox.Show("会員番号は〇〇です。", "確認", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    DialogResult error = MessageBox.Show("必要な情報が入力されていません。", "注意", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
