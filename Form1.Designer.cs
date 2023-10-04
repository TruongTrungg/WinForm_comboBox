namespace BaiTapTuan3
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
            this.cb = new System.Windows.Forms.ComboBox();
            this.bnt_capNhat = new System.Windows.Forms.Button();
            this.txt_Nhap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.list_capNhat = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.bnt_TSU = new System.Windows.Forms.Button();
            this.bnt_SLUSChan = new System.Windows.Forms.Button();
            this.SLUSNT = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb
            // 
            this.cb.FormattingEnabled = true;
            this.cb.Location = new System.Drawing.Point(13, 43);
            this.cb.Name = "cb";
            this.cb.Size = new System.Drawing.Size(166, 21);
            this.cb.TabIndex = 0;
            this.cb.SelectedIndexChanged += new System.EventHandler(this.cb_SelectedIndexChanged);
            // 
            // bnt_capNhat
            // 
            this.bnt_capNhat.Location = new System.Drawing.Point(104, 8);
            this.bnt_capNhat.Name = "bnt_capNhat";
            this.bnt_capNhat.Size = new System.Drawing.Size(75, 29);
            this.bnt_capNhat.TabIndex = 3;
            this.bnt_capNhat.Text = "Cap nhat";
            this.bnt_capNhat.UseVisualStyleBackColor = true;
            this.bnt_capNhat.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bnt_capNhat_MouseClick);
            // 
            // txt_Nhap
            // 
            this.txt_Nhap.Location = new System.Drawing.Point(13, 13);
            this.txt_Nhap.Name = "txt_Nhap";
            this.txt_Nhap.Size = new System.Drawing.Size(85, 20);
            this.txt_Nhap.TabIndex = 4;
            this.txt_Nhap.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Nhap_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nhap so";
            // 
            // list_capNhat
            // 
            this.list_capNhat.FormattingEnabled = true;
            this.list_capNhat.Location = new System.Drawing.Point(279, 29);
            this.list_capNhat.Name = "list_capNhat";
            this.list_capNhat.Size = new System.Drawing.Size(138, 56);
            this.list_capNhat.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(276, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Danh Sach Cac Uoc SO";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(141, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 11;
            this.button1.Text = "Thoat";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // bnt_TSU
            // 
            this.bnt_TSU.Location = new System.Drawing.Point(264, 104);
            this.bnt_TSU.Name = "bnt_TSU";
            this.bnt_TSU.Size = new System.Drawing.Size(172, 29);
            this.bnt_TSU.TabIndex = 12;
            this.bnt_TSU.Text = "Tong cac uoc so";
            this.bnt_TSU.UseVisualStyleBackColor = true;
            this.bnt_TSU.Click += new System.EventHandler(this.bnt_TSU_Click);
            // 
            // bnt_SLUSChan
            // 
            this.bnt_SLUSChan.Location = new System.Drawing.Point(264, 138);
            this.bnt_SLUSChan.Name = "bnt_SLUSChan";
            this.bnt_SLUSChan.Size = new System.Drawing.Size(172, 29);
            this.bnt_SLUSChan.TabIndex = 13;
            this.bnt_SLUSChan.Text = "So luong cac uoc so chan";
            this.bnt_SLUSChan.UseVisualStyleBackColor = true;
            this.bnt_SLUSChan.Click += new System.EventHandler(this.bnt_SLUSChan_Click);
            // 
            // SLUSNT
            // 
            this.SLUSNT.Location = new System.Drawing.Point(264, 173);
            this.SLUSNT.Name = "SLUSNT";
            this.SLUSNT.Size = new System.Drawing.Size(172, 29);
            this.SLUSNT.TabIndex = 14;
            this.SLUSNT.Text = "So luong cac uoc so nguyen to";
            this.SLUSNT.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cb);
            this.panel1.Controls.Add(this.txt_Nhap);
            this.panel1.Controls.Add(this.bnt_capNhat);
            this.panel1.Location = new System.Drawing.Point(37, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(203, 86);
            this.panel1.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(264, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(172, 86);
            this.panel2.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 214);
            this.Controls.Add(this.SLUSNT);
            this.Controls.Add(this.bnt_SLUSChan);
            this.Controls.Add(this.bnt_TSU);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.list_capNhat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb;
        private System.Windows.Forms.Button bnt_capNhat;
        private System.Windows.Forms.TextBox txt_Nhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox list_capNhat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bnt_TSU;
        private System.Windows.Forms.Button bnt_SLUSChan;
        private System.Windows.Forms.Button SLUSNT;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

