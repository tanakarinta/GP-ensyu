using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Data.SQLite;

//会員情報修正画面
namespace SportsClubSystem
{
    public partial class MemberFix : Form
    {
        /// <summary>
        /// ロード時の処理
        /// </summary>
        public MemberFix()
        {
            InitializeComponent();
            //×ボタン消す
            ControlBox = false;

            using (SQLiteConnection connection = new SQLiteConnection("Data Source=member.db"))
            {
                //DataTableを生成
                DataTable dataTabel = new DataTable();
                //SQLの実行
                SQLiteDataAdapter adapter = new SQLiteDataAdapter("SELECT * FROM t_product", connection);

                adapter.Fill(dataTabel);
                //列の名称設定
                dataGridViewF.DataSource = dataTabel;
                dataGridViewF.Columns[0].HeaderText = "会員番号";
                dataGridViewF.Columns[1].HeaderText = "氏名";
                dataGridViewF.Columns[2].HeaderText = "住所";
                dataGridViewF.Columns[3].HeaderText = "電話番号";
            }
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
        /// 修正ボタン
        /// </summary>
        private void fixButtonClick(object sender, EventArgs e)
        {
            //確認表示
            DialogResult result = MessageBox.Show("修正してもよろしいですか？", "確認", 
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            //OKボタンを押したら
            if (result == DialogResult.OK)
            {
                //ボックスが空もしくは数字以外
                if (String.IsNullOrEmpty(idBox.Text)|| !idBox.Text.All(char.IsDigit))
                {
                    //エラーを表示
                    DialogResult error = MessageBox.Show("会員番号を半角数字で入力してください。",
                        "注意", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //修正情報が入ってたら
                else if (!String.IsNullOrEmpty(nameBox.Text) || !String.IsNullOrEmpty(numberBox.Text) ||
                    !String.IsNullOrEmpty(addressBox.Text))
                {
                    //電話番号が数字だったら
                    if (numberBox.Text.All(char.IsDigit))
                    {
                        //データ修正
                        using (SQLiteConnection connection = new SQLiteConnection("Data Source=member.db"))
                        {
                            connection.Open();
                            using (SQLiteTransaction transaction = connection.BeginTransaction())
                            {
                                SQLiteCommand command = connection.CreateCommand();
                                //入力があったら
                                if (!String.IsNullOrEmpty(nameBox.Text))
                                {
                                    //名前
                                    command.CommandText = "UPDATE t_product set member_name = @Name WHERE " +
                                        "member_id = @Id";
                                    //パラメータセット
                                    command.Parameters.Add("Name", DbType.String);
                                    command.Parameters.Add("Id", DbType.Int64);
                                    //データ追加
                                    command.Parameters["Name"].Value = nameBox.Text;
                                    command.Parameters["Id"].Value = int.Parse(idBox.Text);
                                    command.ExecuteNonQuery();
                                }
                                if (!String.IsNullOrEmpty(addressBox.Text))
                                {
                                    //住所
                                    command.CommandText = "UPDATE t_product set member_address = @Address WHERE " +
                                        "member_id = @Id";
                                    //パラメータセット
                                    command.Parameters.Add("Address", DbType.String);
                                    command.Parameters.Add("Id", DbType.Int64);
                                    //データ追加
                                    command.Parameters["Address"].Value = addressBox.Text;
                                    command.Parameters["Id"].Value = int.Parse(idBox.Text);
                                    command.ExecuteNonQuery();
                                }
                                if (!String.IsNullOrEmpty(numberBox.Text))
                                {
                                    //電話番号
                                    command.CommandText = "UPDATE t_product set member_phone_number = @Number WHERE " +
                                        "member_id = @Id";
                                    //パラメータセット
                                    command.Parameters.Add("Number", DbType.String);
                                    command.Parameters.Add("Id", DbType.Int64);
                                    //データ追加
                                    command.Parameters["Number"].Value = numberBox.Text;
                                    command.Parameters["Id"].Value = int.Parse(idBox.Text);
                                    command.ExecuteNonQuery(); 
                                }
                                //コミット
                                transaction.Commit();
                                string serchId = idBox.Text;
                                //DataTableを生成
                                DataTable dataTabel = new DataTable();
                                //会員番号と検索番号が同じ行を表示
                                SQLiteDataAdapter adapter = new SQLiteDataAdapter("SELECT * FROM t_product WHERE " +
                                    "t_product.member_id LIKE " + serchId, connection);
                                adapter.Fill(dataTabel);
                                dataGridViewF.DataSource = dataTabel;
                                //成功メッセージ
                                DialogResult memberId = MessageBox.Show("修正に成功しました。",
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
                    DialogResult error = MessageBox.Show("修正するデータを入力してください。", "注意",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// 検索ボタン
        /// </summary>
        private void searchButtonClick(object sender, EventArgs e)
        {
            //データ表示
            using (SQLiteConnection connection = new SQLiteConnection("Data Source=member.db"))
            {
                //検索番号を格納
                string serchId = idBox.Text;
                if (serchId == "")
                {
                    //DataTableを生成
                    DataTable dataTabel = new DataTable();
                    //SQLの実行
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter("SELECT * FROM t_product", connection);

                    adapter.Fill(dataTabel);
                    dataGridViewF.DataSource = dataTabel;
                }
                else
                {
                    //数字なら
                    if (serchId.All(char.IsDigit))
                    {
                        //DataTableを生成
                        DataTable dataTabel = new DataTable();
                        //会員番号と検索番号が同じ行を表示
                        SQLiteDataAdapter adapter = new SQLiteDataAdapter("SELECT * FROM t_product WHERE " +
                            "t_product.member_id LIKE " + serchId, connection);

                        adapter.Fill(dataTabel);
                        dataGridViewF.DataSource = dataTabel;
                    }
                    else
                    {
                        //数字じゃなければエラーメッセージ
                        DialogResult result = MessageBox.Show("数字以外は入力出来ません。", 
                            "注意", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                //検索結果が０件だったら
                int cnt = dataGridViewF.Rows.Count;
                if (cnt == 0)
                {
                    //ダイアログ表示
                    DialogResult result = MessageBox.Show("会員番号　" + idBox.Text + "　は登録されていません。",
                            "注意", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}