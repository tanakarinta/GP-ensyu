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
    public partial class Member_fix : Form
    {
        public Member_fix()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            //戻るボタン
            this.Close();//この画面を閉じる
            Sub_menu sub = new Sub_menu();
            sub.Visible = true;//サブメニュー画面を表示
        }

        private void fixButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("修正してもよろしいですか？", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)//OKボタンを押したら
            {
                if (String.IsNullOrEmpty(idBox.Text)|| !numberBox.Text.All(char.IsDigit))
                {
                    DialogResult error = MessageBox.Show("会員番号を半角数字で入力してください。", "注意", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!String.IsNullOrEmpty(nameBox.Text) || !String.IsNullOrEmpty(numberBox.Text) ||
                    !String.IsNullOrEmpty(addressBox.Text))
                {
                    if (numberBox.Text.All(char.IsDigit))
                    {
                        //データ修正
                        using (SQLiteConnection con = new SQLiteConnection("Data Source=member.db"))
                        {
                            con.Open();
                            using (SQLiteTransaction trans = con.BeginTransaction())
                            {
                                SQLiteCommand cmd = con.CreateCommand();
                                //インサート
                                if (!String.IsNullOrEmpty(nameBox.Text))
                                {
                                    cmd.CommandText = "UPDATE t_product set member_name = @Name WHERE member_id = @Id";
                                    //パラメータセット
                                    cmd.Parameters.Add("Name", DbType.String);
                                    cmd.Parameters.Add("Id", DbType.Int64);
                                    //データ追加
                                    cmd.Parameters["Name"].Value = nameBox.Text;
                                    cmd.Parameters["Id"].Value = int.Parse(idBox.Text);
                                    cmd.ExecuteNonQuery();
                                    //コミット
                                    
                                }
                                if (!String.IsNullOrEmpty(addressBox.Text))
                                {
                                    cmd.CommandText = "UPDATE t_product set member_address = @Address WHERE member_id = @Id";
                                    //パラメータセット
                                    cmd.Parameters.Add("Address", DbType.String);
                                    cmd.Parameters.Add("Id", DbType.Int64);
                                    //データ追加
                                    cmd.Parameters["Address"].Value = addressBox.Text;
                                    cmd.Parameters["Id"].Value = int.Parse(idBox.Text);
                                    cmd.ExecuteNonQuery();
                                    //コミット
                                    
                                }
                                if (!String.IsNullOrEmpty(numberBox.Text))
                                {
                                    cmd.CommandText = "UPDATE t_product set member_phone_number = @Number WHERE member_id = @Id";
                                    //パラメータセット
                                    cmd.Parameters.Add("Number", DbType.String);
                                    cmd.Parameters.Add("Id", DbType.Int64);
                                    //データ追加
                                    cmd.Parameters["Number"].Value = numberBox.Text;
                                    cmd.Parameters["Id"].Value = int.Parse(idBox.Text);
                                    cmd.ExecuteNonQuery();
                                    //コミット
                                    
                                }
                                trans.Commit();
                                //cmd.CommandText = "UPDATE t_product set member_name = @Name, member_address = @Address, member_phone_number = @Number WHERE member_id = @Id";
                                ////パラメータセット
                                //cmd.Parameters.Add("Name", DbType.String);
                                //cmd.Parameters.Add("Address", DbType.String);
                                //cmd.Parameters.Add("Number", DbType.String);
                                //cmd.Parameters.Add("Id", DbType.Int64);
                                ////データ追加
                                //cmd.Parameters["Name"].Value = nameBox.Text;
                                //cmd.Parameters["Address"].Value = addressBox.Text;
                                //cmd.Parameters["Number"].Value = numberBox.Text;
                                //cmd.Parameters["Id"].Value = int.Parse(idBox.Text);
                                //cmd.ExecuteNonQuery();
                                ////コミット
                                //trans.Commit();
                            }
                        }
                    }
                    else
                    {
                        DialogResult error = MessageBox.Show("電話番号は半角数字のみで入力してください。", "注意", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    DialogResult error = MessageBox.Show("修正するデータを入力してください。", "注意", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
