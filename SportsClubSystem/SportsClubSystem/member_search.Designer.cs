
namespace SportsClubSystem
{
    partial class Member_search
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
            this.searchBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.dataGridView_s = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_s)).BeginInit();
            this.SuspendLayout();
            // 
            // searchBox
            // 
            this.searchBox.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.searchBox.Location = new System.Drawing.Point(248, 45);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(291, 22);
            this.searchBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(245, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "会員番号を入力";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(349, 73);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(81, 24);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "検索";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(349, 400);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(81, 23);
            this.backButton.TabIndex = 3;
            this.backButton.Text = "戻る";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // dataGridView_s
            // 
            this.dataGridView_s.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_s.Location = new System.Drawing.Point(103, 118);
            this.dataGridView_s.Name = "dataGridView_s";
            this.dataGridView_s.RowHeadersWidth = 51;
            this.dataGridView_s.RowTemplate.Height = 24;
            this.dataGridView_s.Size = new System.Drawing.Size(586, 225);
            this.dataGridView_s.TabIndex = 4;
            // 
            // Member_search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView_s);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchBox);
            this.Name = "Member_search";
            this.Text = "会員検索画面";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_s)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.DataGridView dataGridView_s;
    }
}