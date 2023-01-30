using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Data.SQLite;

//会員登録画面
namespace SportsClubSystem
{
    public partial class MemberRegistration : Form
    {
        int currentId;
        public MemberRegistration()
        {
            InitializeComponent();
            //×ボタン消す
            ControlBox = false;
        }

        /// <summary>
        /// 戻るボタン
        /// </summary>
        private void backButtonClick(object sender, EventArgs e)
        {
            //この画面を閉じる
            this.Close();
            SubMenu sub = new SubMenu();
            //サブメニュー画面を表示
            sub.Visible = true;
        }

        /// <summary>
        /// 登録ボタン
        /// </summary>
        private void registButtonClick(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("登録してもよろしいですか？", "確認",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            //OKボタンを押したら
            if (result == DialogResult.OK)
            {
                //入力項目がすべて入力されていたら
                if (!String.IsNullOrEmpty(nameBox.Text) && !String.IsNullOrEmpty(numberBox.Text) &&
                    !String.IsNullOrEmpty(addressBox.Text))
                {
                    if (numberBox.Text.All(char.IsDigit))
                    {
                        //データ追加
                        using (SQLiteConnection connection = new SQLiteConnection("Data Source=member.db"))
                        {
                            connection.Open();
                            using (SQLiteTransaction transaction = connection.BeginTransaction())
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
                                transaction.Commit();
                                //会員番号取得
                                command.CommandText = "SELECT last_insert_rowid()";
                                SQLiteDataReader reader = command.ExecuteReader();
                                while (reader.Read())
                                {
                                    currentId = reader.GetInt32(0);
                                }
                                reader.Close();
                                connection.Close();
                                //成功メッセージ
                                DialogResult memberId = MessageBox.Show("会員番号は　" + currentId + "　です。",
                                "確認", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    else
                    {
                        //エラーを表示
                        DialogResult error = MessageBox.Show("電話番号は半角数字のみで入力してください。",
                            "注意", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    //エラーを表示
                    DialogResult error = MessageBox.Show("必要な情報が入力されていません。",
                        "注意", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}