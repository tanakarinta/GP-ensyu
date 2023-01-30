
namespace SportsClubSystem
{
    partial class MemberRegistration
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
            this.nameBox = new System.Windows.Forms.TextBox();
            this.numberBox = new System.Windows.Forms.TextBox();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.registButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(229, 129);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(333, 22);
            this.nameBox.TabIndex = 0;
            // 
            // numberBox
            // 
            this.numberBox.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.numberBox.Location = new System.Drawing.Point(229, 241);
            this.numberBox.Name = "numberBox";
            this.numberBox.Size = new System.Drawing.Size(333, 22);
            this.numberBox.TabIndex = 2;
            // 
            // addressBox
            // 
            this.addressBox.Location = new System.Drawing.Point(229, 185);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(333, 22);
            this.addressBox.TabIndex = 1;
            // 
            // registButton
            // 
            this.registButton.Location = new System.Drawing.Point(350, 278);
            this.registButton.Name = "registButton";
            this.registButton.Size = new System.Drawing.Size(81, 24);
            this.registButton.TabIndex = 3;
            this.registButton.Text = "登録";
            this.registButton.UseVisualStyleBackColor = true;
            this.registButton.Click += new System.EventHandler(this.registButtonClick);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(350, 349);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(81, 24);
            this.backButton.TabIndex = 4;
            this.backButton.Text = "戻る";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButtonClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(226, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "氏名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "住所";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(226, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "電話番号";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pictureBox2.Enabled = false;
            this.pictureBox2.Image = global::SportsClubSystem.Properties.Resources.登録アイコン;
            this.pictureBox2.Location = new System.Drawing.Point(12, 358);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(80, 80);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // MemberRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.registButton);
            this.Controls.Add(this.addressBox);
            this.Controls.Add(this.numberBox);
            this.Controls.Add(this.nameBox);
            this.Name = "MemberRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "会員登録画面";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox numberBox;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.Button registButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}