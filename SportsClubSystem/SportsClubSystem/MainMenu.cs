using System;
using System.Windows.Forms;

//メインメニュー
namespace SportsClubSystem
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            //×ボタン消す
            ControlBox = false;
        }

        /// <summary>
        /// 会員登録管理ボタン
        /// </summary>
        private void subMenuButtonClick(object sender, EventArgs e)
        {
            SubMenu sub = new SubMenu();
            //サブメニューに移動
            sub.Show();
            //この画面を非表示
            this.Visible = false;
        }

        /// <summary>
        /// 終了ボタン
        /// </summary>
        private void exitButtonClick(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("終了してもよろしいですか？", "確認", 
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            //OKボタンを押したら
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}