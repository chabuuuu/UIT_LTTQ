namespace ThuocTinhTabPages_TabControl1
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Trangchu = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Profile = new System.Windows.Forms.TabPage();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Bangdiem = new System.Windows.Forms.TabPage();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.Trangchu.SuspendLayout();
            this.Profile.SuspendLayout();
            this.Bangdiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Trangchu);
            this.tabControl1.Controls.Add(this.Profile);
            this.tabControl1.Controls.Add(this.Bangdiem);
            this.tabControl1.Location = new System.Drawing.Point(31, 38);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(692, 373);
            this.tabControl1.TabIndex = 0;
            // 
            // Trangchu
            // 
            this.Trangchu.AutoScroll = true;
            this.Trangchu.Controls.Add(this.label1);
            this.Trangchu.Controls.Add(this.textBox1);
            this.Trangchu.Location = new System.Drawing.Point(4, 25);
            this.Trangchu.Name = "Trangchu";
            this.Trangchu.Padding = new System.Windows.Forms.Padding(3);
            this.Trangchu.Size = new System.Drawing.Size(684, 344);
            this.Trangchu.TabIndex = 0;
            this.Trangchu.Text = "Trang chu";
            this.Trangchu.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(254, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "ĐÂY LÀ TRANG CHỦ UIT";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "uit/home";
            // 
            // Profile
            // 
            this.Profile.Controls.Add(this.label2);
            this.Profile.Controls.Add(this.textBox2);
            this.Profile.Location = new System.Drawing.Point(4, 25);
            this.Profile.Name = "Profile";
            this.Profile.Padding = new System.Windows.Forms.Padding(3);
            this.Profile.Size = new System.Drawing.Size(684, 344);
            this.Profile.TabIndex = 1;
            this.Profile.Text = "Profile";
            this.Profile.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(0, 0);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 0;
            this.textBox2.Text = "uit/profile";
            // 
            // Bangdiem
            // 
            this.Bangdiem.Controls.Add(this.label3);
            this.Bangdiem.Controls.Add(this.textBox3);
            this.Bangdiem.Location = new System.Drawing.Point(4, 25);
            this.Bangdiem.Name = "Bangdiem";
            this.Bangdiem.Size = new System.Drawing.Size(684, 344);
            this.Bangdiem.TabIndex = 2;
            this.Bangdiem.Text = "Bang diem";
            this.Bangdiem.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(0, 0);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 0;
            this.textBox3.Text = "uit/bangdiem";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "ĐÂY LÀ TRANG PROFILE";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(254, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "ĐÂY LÀ TRANG BẢNG ĐIỂM";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.Trangchu.ResumeLayout(false);
            this.Trangchu.PerformLayout();
            this.Profile.ResumeLayout(false);
            this.Profile.PerformLayout();
            this.Bangdiem.ResumeLayout(false);
            this.Bangdiem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Trangchu;
        private System.Windows.Forms.TabPage Profile;
        private System.Windows.Forms.TabPage Bangdiem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

