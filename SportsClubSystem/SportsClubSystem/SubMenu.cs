using System;
using System.Windows.Forms;

//サブメニュー
namespace SportsClubSystem
{
    public partial class SubMenu : Form
    {
        public SubMenu()
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
            MainMenu main = new MainMenu();
            //メインメニュー画面を表示
            main.Visible = true;
        }

        /// <summary>
        /// 検索ボタン
        /// </summary>
        private void searchButtonClick(object sender, EventArgs e)
        {
            MemberSearch search = new MemberSearch();
            //会員検索画面へ移動
            search.Show();
            //この画面を非表示
            this.Visible = false;
        }

        /// <summary>
        /// 登録ボタン
        /// </summary>
        private void registButtonClick(object sender, EventArgs e)
        {
            MemberRegistration registration = new MemberRegistration();
            //会員登録画面へ移動
            registration.Show();
            //この画面を非表示
            this.Visible = false;
        }

        /// <summary>
        /// 修正ボタン
        /// </summary>
        private void fixButtonClick(object sender, EventArgs e)
        {
            MemberFix fix = new MemberFix();
            //会員修正画面に移動
            fix.Show();
            //この画面を非表示
            this.Visible = false;
        }

        /// <summary>
        /// 削除ボタン
        /// </summary>
        private void deleteButtonClick(object sender, EventArgs e)
        {
            MemberDelete delete = new MemberDelete();
            //会員削除画面へ移動
            delete.Show();
            //この画面を非表示
            this.Visible = false;
        }
    }
}
