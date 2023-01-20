
namespace SportsClubSystem
{
    partial class MemberSearch
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
            this.idButton = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_s)).BeginInit();
            this.SuspendLayout();
            // 
            // searchBox
            // 
            this.searchBox.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.searchBox.Location = new System.Drawing.Point(215, 83);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(291, 22);
            this.searchBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(230, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "検索条件を選択";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(511, 81);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(81, 26);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "検索";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButtonClick);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(349, 390);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(81, 26);
            this.backButton.TabIndex = 3;
            this.backButton.Text = "戻る";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButtonClick);
            // 
            // dataGridView_s
            // 
            this.dataGridView_s.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_s.Location = new System.Drawing.Point(106, 133);
            this.dataGridView_s.Name = "dataGridView_s";
            this.dataGridView_s.RowHeadersWidth = 51;
            this.dataGridView_s.RowTemplate.Height = 24;
            this.dataGridView_s.Size = new System.Drawing.Size(586, 225);
            this.dataGridView_s.TabIndex = 4;
            // 
            // idButton
            // 
            this.idButton.AutoSize = true;
            this.idButton.Checked = true;
            this.idButton.Location = new System.Drawing.Point(407, 45);
            this.idButton.Name = "idButton";
            this.idButton.Size = new System.Drawing.Size(88, 19);
            this.idButton.TabIndex = 5;
            this.idButton.TabStop = true;
            this.idButton.Text = "会員番号";
            this.idButton.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(512, 45);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(58, 19);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "氏名";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // Member_search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.idButton);
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
        private System.Windows.Forms.RadioButton idButton;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}