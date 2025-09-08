
namespace Quanlybanhangluuniem
{
    partial class F_Dangnhap
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
            this.id_thoat = new System.Windows.Forms.Button();
            this.id_dangnhap = new System.Windows.Forms.Button();
            this.id_quenmk = new System.Windows.Forms.LinkLabel();
            this.id_hienthimk = new System.Windows.Forms.CheckBox();
            this.id_matkhau = new System.Windows.Forms.TextBox();
            this.id_taikhoan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // id_thoat
            // 
            this.id_thoat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.id_thoat.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.id_thoat.Location = new System.Drawing.Point(471, 442);
            this.id_thoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.id_thoat.Name = "id_thoat";
            this.id_thoat.Size = new System.Drawing.Size(208, 44);
            this.id_thoat.TabIndex = 17;
            this.id_thoat.Text = "Thoát";
            this.id_thoat.UseVisualStyleBackColor = false;
            this.id_thoat.Click += new System.EventHandler(this.id_thoat_Click);
            // 
            // id_dangnhap
            // 
            this.id_dangnhap.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.id_dangnhap.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_dangnhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.id_dangnhap.Location = new System.Drawing.Point(219, 442);
            this.id_dangnhap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.id_dangnhap.Name = "id_dangnhap";
            this.id_dangnhap.Size = new System.Drawing.Size(192, 44);
            this.id_dangnhap.TabIndex = 16;
            this.id_dangnhap.Text = "Đăng nhập";
            this.id_dangnhap.UseVisualStyleBackColor = false;
            this.id_dangnhap.Click += new System.EventHandler(this.id_dangnhap_Click);
            // 
            // id_quenmk
            // 
            this.id_quenmk.AutoSize = true;
            this.id_quenmk.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_quenmk.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.id_quenmk.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.id_quenmk.Location = new System.Drawing.Point(519, 382);
            this.id_quenmk.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.id_quenmk.Name = "id_quenmk";
            this.id_quenmk.Size = new System.Drawing.Size(159, 27);
            this.id_quenmk.TabIndex = 19;
            this.id_quenmk.TabStop = true;
            this.id_quenmk.Text = "Quên mật khẩu";
            // 
            // id_hienthimk
            // 
            this.id_hienthimk.AutoSize = true;
            this.id_hienthimk.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_hienthimk.Location = new System.Drawing.Point(175, 382);
            this.id_hienthimk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.id_hienthimk.Name = "id_hienthimk";
            this.id_hienthimk.Size = new System.Drawing.Size(206, 31);
            this.id_hienthimk.TabIndex = 18;
            this.id_hienthimk.Text = "Hiển thị mật khẩu";
            this.id_hienthimk.UseVisualStyleBackColor = true;
            this.id_hienthimk.CheckedChanged += new System.EventHandler(this.id_hienthimk_CheckedChanged);
            // 
            // id_matkhau
            // 
            this.id_matkhau.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_matkhau.Location = new System.Drawing.Point(299, 283);
            this.id_matkhau.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.id_matkhau.Name = "id_matkhau";
            this.id_matkhau.PasswordChar = '*';
            this.id_matkhau.Size = new System.Drawing.Size(379, 30);
            this.id_matkhau.TabIndex = 24;
            this.id_matkhau.TextChanged += new System.EventHandler(this.id_matkhau_TextChanged);
            // 
            // id_taikhoan
            // 
            this.id_taikhoan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_taikhoan.Location = new System.Drawing.Point(299, 207);
            this.id_taikhoan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.id_taikhoan.Name = "id_taikhoan";
            this.id_taikhoan.Size = new System.Drawing.Size(379, 30);
            this.id_taikhoan.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(87, 281);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 39);
            this.label3.TabIndex = 22;
            this.label3.Text = "Mật khẩu";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(80, 207);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 39);
            this.label2.TabIndex = 21;
            this.label2.Text = "Tài khoản";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(155, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(486, 45);
            this.label1.TabIndex = 20;
            this.label1.Text = "ĐĂNG NHẬP HỆ THỐNG";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // F_Dangnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 554);
            this.Controls.Add(this.id_thoat);
            this.Controls.Add(this.id_dangnhap);
            this.Controls.Add(this.id_quenmk);
            this.Controls.Add(this.id_hienthimk);
            this.Controls.Add(this.id_matkhau);
            this.Controls.Add(this.id_taikhoan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "F_Dangnhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button id_thoat;
        private System.Windows.Forms.Button id_dangnhap;
        private System.Windows.Forms.LinkLabel id_quenmk;
        private System.Windows.Forms.CheckBox id_hienthimk;
        private System.Windows.Forms.TextBox id_matkhau;
        private System.Windows.Forms.TextBox id_taikhoan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

