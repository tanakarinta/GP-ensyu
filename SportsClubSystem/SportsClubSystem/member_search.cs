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
    public partial class Member_search : Form
    {
        public Member_search()
        {
            InitializeComponent();
            this.Load += Member_search_load;
        }

        private void Member_search_load(object sender, EventArgs e)
        {
            //データ表示
            using (SQLiteConnection con = new SQLiteConnection("Data Source=member.db"))
            {
                //DataTableを生成
                var dataTabel = new DataTable();
                //SQLの実行
                var adapter = new SQLiteDataAdapter("SELECT * FROM t_product", con);

                adapter.Fill(dataTabel);
                dataGridView1.DataSource = dataTabel;
                dataGridView1.Columns[0].HeaderText = "会員番号";
                dataGridView1.Columns[1].HeaderText = "氏名";
                dataGridView1.Columns[2].HeaderText = "住所";
                dataGridView1.Columns[3].HeaderText = "電話番号";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //戻るボタン
            this.Close();//この画面を閉じる
            Sub_menu sub = new Sub_menu();
            sub.Visible = true;//サブメニュー画面を表示
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //データ表示
            using (SQLiteConnection con = new SQLiteConnection("Data Source=member.db"))
            {
                //検索番号を格納
                string serchId = textBox1.Text;
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
                    var adapter = new SQLiteDataAdapter("SELECT * FROM t_product WHERE t_product.member_id LIKE " + serchId, con);

                    adapter.Fill(dataTabel);
                    dataGridView1.DataSource = dataTabel;
                }
            }
        }
    }
}
