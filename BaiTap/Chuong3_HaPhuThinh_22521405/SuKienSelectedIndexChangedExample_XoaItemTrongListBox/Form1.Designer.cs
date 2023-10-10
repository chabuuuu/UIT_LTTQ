namespace SuKienSelectedIndexChangedExample_XoaItemTrongListBox
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
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.LBMonHoc = new System.Windows.Forms.ListBox();
            this.txtMonHoc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnExit
            // 
            this.BtnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.BtnExit.Location = new System.Drawing.Point(466, 361);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(119, 34);
            this.BtnExit.TabIndex = 7;
            this.BtnExit.Text = "Thoát";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.BtnAdd.Location = new System.Drawing.Point(456, 55);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(119, 34);
            this.BtnAdd.TabIndex = 6;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // LBMonHoc
            // 
            this.LBMonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.LBMonHoc.FormattingEnabled = true;
            this.LBMonHoc.ItemHeight = 29;
            this.LBMonHoc.Location = new System.Drawing.Point(215, 124);
            this.LBMonHoc.Name = "LBMonHoc";
            this.LBMonHoc.Size = new System.Drawing.Size(360, 207);
            this.LBMonHoc.TabIndex = 5;
            this.LBMonHoc.SelectedIndexChanged += new System.EventHandler(this.LBMonHoc_SelectedIndexChanged);
            // 
            // txtMonHoc
            // 
            this.txtMonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtMonHoc.Location = new System.Drawing.Point(215, 55);
            this.txtMonHoc.Name = "txtMonHoc";
            this.txtMonHoc.Size = new System.Drawing.Size(235, 34);
            this.txtMonHoc.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.LBMonHoc);
            this.Controls.Add(this.txtMonHoc);
            this.Name = "Form1";
            this.Text = "Demo Listbox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.ListBox LBMonHoc;
        private System.Windows.Forms.TextBox txtMonHoc;
    }
}

