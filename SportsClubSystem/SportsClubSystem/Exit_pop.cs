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
    public partial class Exit_pop : Form
    {
        public Exit_pop()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //はいボタン
            Application.Exit();//終了
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //いいえボタン
            Main_menu main = new Main_menu();
            this.Close();//この画面を閉じる
        }
    }
}