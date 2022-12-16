using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportsClubSystem
{
    public partial class Sub_menu : Form
    {
        public Sub_menu()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            //戻るボタン
            this.Close();//この画面を閉じる
            Main_menu main = new Main_menu();
            main.Visible = true;//メインメニュー画面を表示
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            //検索ボタン
            Member_search search = new Member_search();
            search.Show();//会員検索画面へ移動
            this.Visible = false;//この画面を非表示
        }

        private void registButton_Click(object sender, EventArgs e)
        {
            //登録ボタン
            Member_registration registration = new Member_registration();
            registration.Show();//会員登録画面へ移動
            this.Visible = false;//この画面を非表示
        }

        private void fixButton_Click(object sender, EventArgs e)
        {
            //修正ボタン
            Member_fix fix = new Member_fix();
            fix.Show();//会員修正画面に移動
            this.Visible = false;//この画面を非表示
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            //削除ボタン
            Member_delete delete = new Member_delete();
            delete.Show();//会員削除画面へ移動
            this.Visible = false;//この画面を非表示
        }
    }
}
