﻿
namespace SportsClubSystem
{
    partial class Member_fix
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
            this.idBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.fixButton = new System.Windows.Forms.Button();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.numberBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(250, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "会員番号を入力";
            // 
            // idBox
            // 
            this.idBox.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.idBox.Location = new System.Drawing.Point(253, 84);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(291, 22);
            this.idBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "電話番号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "住所";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(231, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "氏名";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(355, 398);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(81, 24);
            this.backButton.TabIndex = 6;
            this.backButton.Text = "戻る";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // fixButton
            // 
            this.fixButton.Location = new System.Drawing.Point(355, 342);
            this.fixButton.Name = "fixButton";
            this.fixButton.Size = new System.Drawing.Size(81, 24);
            this.fixButton.TabIndex = 5;
            this.fixButton.Text = "修正";
            this.fixButton.UseVisualStyleBackColor = true;
            this.fixButton.Click += new System.EventHandler(this.fixButton_Click);
            // 
            // addressBox
            // 
            this.addressBox.Location = new System.Drawing.Point(234, 234);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(333, 22);
            this.addressBox.TabIndex = 3;
            // 
            // numberBox
            // 
            this.numberBox.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.numberBox.Location = new System.Drawing.Point(234, 290);
            this.numberBox.Name = "numberBox";
            this.numberBox.Size = new System.Drawing.Size(333, 22);
            this.numberBox.TabIndex = 4;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(234, 178);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(333, 22);
            this.nameBox.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(274, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(254, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "修正したい箇所にデータを入力してください";
            // 
            // Member_fix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.fixButton);
            this.Controls.Add(this.addressBox);
            this.Controls.Add(this.numberBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idBox);
            this.Name = "Member_fix";
            this.Text = "会員修正画面";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button fixButton;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.TextBox numberBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label5;
    }
}