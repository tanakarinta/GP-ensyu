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
        /// Loadの設定
        /// </summary>
        public MemberDelete()
        {
            InitializeComponent();
            Load += MemberDeleteLoad;
            //×ボタン消す
            ControlBox = false;
        }
        /// <summary>
        /// ロード時の処理
        /// </summary>
        private void MemberDeleteLoad(object sender, EventArgs e)
        {
            //データ表示
            using (SQLiteConnection con = new SQLiteConnection("Data Source=member.db"))
            {
                //DataTableを生成
                var dataTabel = new DataTable();
                //SQLの実行
                var adapter = new SQLiteDataAdapter("SELECT * FROM t_product", con);

                adapter.Fill(dataTabel);
                //列の名称設定
                dataGridView_d.DataSource = dataTabel;
                dataGridView_d.Columns[0].HeaderText = "会員番号";
                dataGridView_d.Columns[1].HeaderText = "氏名";
                dataGridView_d.Columns[2].HeaderText = "住所";
                dataGridView_d.Columns[3].HeaderText = "電話番号";
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
                            cmd.Parameters["Id"].Value = int.Parse(deleteBox.Text);
                            cmd.ExecuteNonQuery();
                            //コミット
                            trans.Commit();
                            var dataTabel = new DataTable();
                            //会員番号と検索番号が同じ行を表示
                            var adapter = new SQLiteDataAdapter("SELECT * FROM t_product", con);
                            adapter.Fill(dataTabel);
                            dataGridView_d.DataSource = dataTabel;
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
            using (SQLiteConnection con = new SQLiteConnection("Data Source=member.db"))
            {
                //検索番号を格納
                string serchId = deleteBox.Text;
                if (serchId == "")
                {
                    //DataTableを生成
                    var dataTabel = new DataTable();
                    //SQLの実行
                    var adapter = new SQLiteDataAdapter("SELECT * FROM t_product", con);

                    adapter.Fill(dataTabel);
                    dataGridView_d.DataSource = dataTabel;
                }
                else
                {
                    //数字なら
                    if (serchId.All(char.IsDigit))
                    {
                        //DataTableを生成
                        var dataTabel = new DataTable();
                        //会員番号と検索番号が同じ行を表示
                        var adapter = new SQLiteDataAdapter("SELECT * FROM t_product WHERE " +
                            "t_product.member_id LIKE " + serchId, con);

                        adapter.Fill(dataTabel);
                        dataGridView_d.DataSource = dataTabel;
                    }
                    else
                    {
                        //数字じゃなければエラーメッセージ
                        DialogResult result = MessageBox.Show("数字以外は入力出来ません。",
                            "注意", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
