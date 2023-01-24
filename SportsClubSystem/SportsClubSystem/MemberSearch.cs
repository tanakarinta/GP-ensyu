using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Data.SQLite;

//会員情報検索画面
namespace SportsClubSystem
{
    public partial class MemberSearch : Form
    {
        //検索方法の初期値
        string searchType = "member_id";

        /// <summary>
        /// Loadの設定
        /// </summary>
        public MemberSearch()
        {
            InitializeComponent();
            Load += MemberSearchLoad;
            //×ボタン消す
            ControlBox = false;
        }

        /// <summary>
        /// ロード時の処理
        /// </summary>
        private void MemberSearchLoad(object sender, EventArgs e)
        {
            //データ表示
            using (SQLiteConnection connection = new SQLiteConnection("Data Source=member.db"))
            {
                //DataTableを生成
                DataTable dataTabel = new DataTable();
                //SQLの実行
                SQLiteDataAdapter adapter = new SQLiteDataAdapter("SELECT * FROM t_product", connection);

                adapter.Fill(dataTabel);
                dataGridViewS.DataSource = dataTabel;
                dataGridViewS.Columns[0].HeaderText = "会員番号";
                dataGridViewS.Columns[1].HeaderText = "氏名";
                dataGridViewS.Columns[2].HeaderText = "住所";
                dataGridViewS.Columns[3].HeaderText = "電話番号";
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
        /// ID検索ラジオボタン
        /// </summary>
        private void idButtonCheckedChanged(object sender, EventArgs e)
        {
            //検索タイプをID検索にする
            searchType = "member_id";
        }

        /// <summary>
        /// 名前検索ラジオボタン
        /// </summary>
        private void radioButton2CheckedChanged(object sender, EventArgs e)
        {
            //検索タイプを名前検索にする
            searchType = "member_name";
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
                string serchId = searchBox.Text;
                if (serchId == "")
                {
                    //DataTableを生成
                    DataTable dataTabel = new DataTable();
                    //SQLの実行
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter("SELECT * FROM t_product", connection);

                    adapter.Fill(dataTabel);
                    dataGridViewS.DataSource = dataTabel;
                }
                else
                {
                    //数字または名前検索なら
                    if (serchId.All(char.IsDigit)|| searchType == "member_name")
                    {
                        //DataTableを生成
                        DataTable dataTabel = new DataTable();
                        //会員番号と検索番号が同じ行を表示
                        SQLiteDataAdapter adapter = new SQLiteDataAdapter("SELECT * FROM t_product WHERE " +
                            "t_product." + searchType + " LIKE  '"+ serchId +"'", connection);

                        adapter.Fill(dataTabel);
                        dataGridViewS.DataSource = dataTabel;
                    }
                    //ID検索で数字以外なら
                    else if(searchType== "member_id")
                    {
                        //数字じゃなければエラーメッセージ
                        DialogResult result = MessageBox.Show("数字以外は入力出来ません。", 
                            "注意", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                int cnt = dataGridViewS.Rows.Count;
                //検索結果が０件でID検索だったら
                if (cnt==0&& searchType == "member_id")
                {
                    //ダイアログ表示
                    DialogResult result = MessageBox.Show("会員番号　"+ searchBox.Text+"　は登録されていません。",
                            "注意", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //DataTableを生成
                    DataTable dataTabel = new DataTable();
                    //SQLの実行
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter("SELECT * FROM t_product", connection);

                    adapter.Fill(dataTabel);
                    dataGridViewS.DataSource = dataTabel;
                }
                //検索結果が０件で名前検索だったら
                else if(cnt == 0 && searchType == "member_name")
                {
                    //ダイアログ表示
                    DialogResult result = MessageBox.Show("登録されていません。",
                            "注意", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //DataTableを生成
                    DataTable dataTabel = new DataTable();
                    //SQLの実行
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter("SELECT * FROM t_product", connection);

                    adapter.Fill(dataTabel);
                    dataGridViewS.DataSource = dataTabel;
                }
            }
        }
    }
}