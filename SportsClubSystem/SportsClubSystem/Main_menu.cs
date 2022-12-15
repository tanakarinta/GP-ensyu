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
    public partial class Main_menu : Form
    {
        public Main_menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //会員登録管理ボタン
            Sub_menu sub = new Sub_menu();
            sub.Show();//サブメニューに移動
            this.Visible = false;//この画面を非表示
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("終了してもよろしいですか？", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)//OKボタンを押したら
            {
                Application.Exit();
            }
        }
    }
}