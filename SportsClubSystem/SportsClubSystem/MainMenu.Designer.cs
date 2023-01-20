
namespace SportsClubSystem
{
    partial class MainMenu
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.subMenuButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // subMenuButton
            // 
            this.subMenuButton.Location = new System.Drawing.Point(230, 119);
            this.subMenuButton.Name = "subMenuButton";
            this.subMenuButton.Size = new System.Drawing.Size(335, 80);
            this.subMenuButton.TabIndex = 0;
            this.subMenuButton.Text = "会員登録管理";
            this.subMenuButton.UseVisualStyleBackColor = true;
            this.subMenuButton.Click += new System.EventHandler(this.subMenuButtonClick);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(230, 239);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(335, 80);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "終了";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButtonClick);
            // 
            // Main_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.subMenuButton);
            this.Name = "Main_menu";
            this.Text = "メインメニュー";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button subMenuButton;
        private System.Windows.Forms.Button exitButton;
    }
}

