
namespace SportsClubSystem
{
    partial class SubMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.searchButton = new System.Windows.Forms.Button();
            this.registButton = new System.Windows.Forms.Button();
            this.fixButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(90, 52);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(163, 69);
            this.searchButton.TabIndex = 0;
            this.searchButton.Text = "検索画面";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButtonClick);
            // 
            // registButton
            // 
            this.registButton.Location = new System.Drawing.Point(336, 52);
            this.registButton.Name = "registButton";
            this.registButton.Size = new System.Drawing.Size(168, 69);
            this.registButton.TabIndex = 1;
            this.registButton.Text = "登録画面";
            this.registButton.UseVisualStyleBackColor = true;
            this.registButton.Click += new System.EventHandler(this.registButtonClick);
            // 
            // fixButton
            // 
            this.fixButton.Location = new System.Drawing.Point(90, 144);
            this.fixButton.Name = "fixButton";
            this.fixButton.Size = new System.Drawing.Size(163, 73);
            this.fixButton.TabIndex = 2;
            this.fixButton.Text = "修正画面";
            this.fixButton.UseVisualStyleBackColor = true;
            this.fixButton.Click += new System.EventHandler(this.fixButtonClick);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(336, 144);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(168, 73);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "削除画面";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButtonClick);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(220, 250);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(157, 60);
            this.backButton.TabIndex = 4;
            this.backButton.Text = "戻る";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButtonClick);
            // 
            // Sub_menu
            // 
            this.ClientSize = new System.Drawing.Size(600, 360);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.fixButton);
            this.Controls.Add(this.registButton);
            this.Controls.Add(this.searchButton);
            this.Name = "Sub_menu";
            this.Text = "サブメニュー";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button registButton;
        private System.Windows.Forms.Button fixButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button backButton;
    }
}