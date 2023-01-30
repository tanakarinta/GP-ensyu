using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Linq;

//会員削除画面
namespace SportsClubSystem
{
    public partial class MemberDelete : Form
    {
        /// <summary>
        /// ロード時の処理
        /// </summary>
        public MemberDelete()
        {
            InitializeComponent();
            //×ボタン消す
            ControlBox = false;
            //データ表示
            using (SQLiteConnection connection = new SQLiteConnection("Data Source=member.db"))
            {
                //DataTableを生成
                DataTable dataTabel = new DataTable();
                //SQLの実行
                SQLiteDataAdapter adapter = new SQLiteDataAdapter("SELECT * FROM t_product", connection);

                adapter.Fill(dataTabel);
                //列の名称設定
                dataGridViewD.DataSource = dataTabel;
                dataGridViewD.Columns[0].HeaderText = "会員番号";
                dataGridViewD.Columns[1].HeaderText = "氏名";
                dataGridViewD.Columns[2].HeaderText = "住所";
                dataGridViewD.Columns[3].HeaderText = "電話番号";
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
        /// 削除ボタン
        /// </summary>
        private void deleteButtonClick(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("削除してもよろしいですか？", "確認",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            //OKボタンを押したら
            if (result == DialogResult.OK)
            {
                if (String.IsNullOrEmpty(deleteBox.Text) || !deleteBox.Text.All(char.IsDigit))
                {
                    //エラーを表示
                    DialogResult error = MessageBox.Show("会員番号を半角数字で入力してください。",
                        "注意", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //データ削除
                    using (SQLiteConnection connection = new SQLiteConnection("Data Source=member.db"))
                    {
                        connection.Open();
                        using (SQLiteTransaction transaction = connection.BeginTransaction())
                        {
                            SQLiteCommand command = connection.CreateCommand();
                            //インサート
                            command.CommandText = "DELETE FROM t_product WHERE member_id = @Id";
                            //パラメータセット
                            command.Parameters.Add("Id", DbType.Int64);
                            //データ削除
                            command.Parameters["Id"].Value = int.Parse(deleteBox.Text);
                            command.ExecuteNonQuery();
                            //コミット
                            transaction.Commit();
                            DataTable dataTabel = new DataTable();
                            //会員番号と検索番号が同じ行を削除
                            SQLiteDataAdapter adapter = new SQLiteDataAdapter("SELECT * FROM t_product", connection);
                            adapter.Fill(dataTabel);
                            dataGridViewD.DataSource = dataTabel;
                            //成功メッセージ
                            DialogResult memberId = MessageBox.Show("会員番号　" + deleteBox.Text + "　を削除しました。",
                            "確認", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
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
                string serchId = deleteBox.Text;
                if (serchId == "")
                {
                    //DataTableを生成
                    DataTable dataTabel = new DataTable();
                    //SQLの実行
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter("SELECT * FROM t_product", connection);

                    adapter.Fill(dataTabel);
                    dataGridViewD.DataSource = dataTabel;
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
                        dataGridViewD.DataSource = dataTabel;
                    }
                    else
                    {
                        //数字じゃなければエラーメッセージ
                        DialogResult result = MessageBox.Show("数字以外は入力出来ません。",
                            "注意", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                //検索結果が０件だったら
                int cnt = dataGridViewD.Rows.Count;
                if (cnt == 0)
                {
                    //ダイアログ表示
                    DialogResult result = MessageBox.Show("会員番号　" + deleteBox.Text + "　は登録されていません。",
                            "注意", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
