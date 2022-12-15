
namespace SportsClubSystem
{
    partial class Registration_check
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.yesButton = new System.Windows.Forms.Button();
            this.noButton = new System.Windows.Forms.Button();
            this.sqLiteCommand1 = new System.Data.SQLite.SQLiteCommand();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "氏名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "住所";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "電話番号";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(31, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(268, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "登録内容に誤りはありませんか？";
            // 
            // yesButton
            // 
            this.yesButton.Location = new System.Drawing.Point(111, 227);
            this.yesButton.Name = "yesButton";
            this.yesButton.Size = new System.Drawing.Size(78, 30);
            this.yesButton.TabIndex = 4;
            this.yesButton.Text = "YES";
            this.yesButton.UseVisualStyleBackColor = true;
            // 
            // noButton
            // 
            this.noButton.Location = new System.Drawing.Point(270, 227);
            this.noButton.Name = "noButton";
            this.noButton.Size = new System.Drawing.Size(78, 30);
            this.noButton.TabIndex = 5;
            this.noButton.Text = "NO";
            this.noButton.UseVisualStyleBackColor = true;
            this.noButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // sqLiteCommand1
            // 
            this.sqLiteCommand1.CommandText = null;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(129, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(129, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(129, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "label7";
            // 
            // Registration_check
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 282);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.noButton);
            this.Controls.Add(this.yesButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Registration_check";
            this.Text = "登録確認";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button yesButton;
        private System.Windows.Forms.Button noButton;
        private System.Data.SQLite.SQLiteCommand sqLiteCommand1;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label7;
    }
}