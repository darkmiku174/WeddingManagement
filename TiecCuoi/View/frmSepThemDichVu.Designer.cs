namespace TiecCuoi.View
{
    partial class frmSepThemDichVu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSepThemDichVu));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGetPicture = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbMaDichVu = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.tbTenDichVu = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.tbGiaTien = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLuu = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 193);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(375, 250);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnGetPicture
            // 
            this.btnGetPicture.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnGetPicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnGetPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGetPicture.BorderRadius = 0;
            this.btnGetPicture.ButtonText = "Get Picture";
            this.btnGetPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGetPicture.DisabledColor = System.Drawing.Color.Gray;
            this.btnGetPicture.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGetPicture.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnGetPicture.Iconimage")));
            this.btnGetPicture.Iconimage_right = null;
            this.btnGetPicture.Iconimage_right_Selected = null;
            this.btnGetPicture.Iconimage_Selected = null;
            this.btnGetPicture.IconMarginLeft = 0;
            this.btnGetPicture.IconMarginRight = 0;
            this.btnGetPicture.IconRightVisible = true;
            this.btnGetPicture.IconRightZoom = 0D;
            this.btnGetPicture.IconVisible = true;
            this.btnGetPicture.IconZoom = 90D;
            this.btnGetPicture.IsTab = false;
            this.btnGetPicture.Location = new System.Drawing.Point(139, 144);
            this.btnGetPicture.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnGetPicture.Name = "btnGetPicture";
            this.btnGetPicture.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnGetPicture.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnGetPicture.OnHoverTextColor = System.Drawing.Color.White;
            this.btnGetPicture.selected = false;
            this.btnGetPicture.Size = new System.Drawing.Size(132, 41);
            this.btnGetPicture.TabIndex = 1;
            this.btnGetPicture.Text = "Get Picture";
            this.btnGetPicture.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGetPicture.Textcolor = System.Drawing.Color.White;
            this.btnGetPicture.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên dịch vụ :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(87, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Giá tiền :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(90, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã dịch vụ :";
            // 
            // tbMaDichVu
            // 
            this.tbMaDichVu.BorderColorFocused = System.Drawing.Color.Blue;
            this.tbMaDichVu.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbMaDichVu.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.tbMaDichVu.BorderThickness = 3;
            this.tbMaDichVu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbMaDichVu.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbMaDichVu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbMaDichVu.isPassword = false;
            this.tbMaDichVu.Location = new System.Drawing.Point(182, 13);
            this.tbMaDichVu.Margin = new System.Windows.Forms.Padding(4);
            this.tbMaDichVu.Name = "tbMaDichVu";
            this.tbMaDichVu.Size = new System.Drawing.Size(144, 31);
            this.tbMaDichVu.TabIndex = 4;
            this.tbMaDichVu.Text = "Mã dịch vụ";
            this.tbMaDichVu.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tbTenDichVu
            // 
            this.tbTenDichVu.BorderColorFocused = System.Drawing.Color.Blue;
            this.tbTenDichVu.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbTenDichVu.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.tbTenDichVu.BorderThickness = 3;
            this.tbTenDichVu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbTenDichVu.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbTenDichVu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbTenDichVu.isPassword = false;
            this.tbTenDichVu.Location = new System.Drawing.Point(182, 52);
            this.tbTenDichVu.Margin = new System.Windows.Forms.Padding(4);
            this.tbTenDichVu.Name = "tbTenDichVu";
            this.tbTenDichVu.Size = new System.Drawing.Size(144, 31);
            this.tbTenDichVu.TabIndex = 4;
            this.tbTenDichVu.Text = "Tên dịch vụ";
            this.tbTenDichVu.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tbGiaTien
            // 
            this.tbGiaTien.BorderColorFocused = System.Drawing.Color.Blue;
            this.tbGiaTien.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbGiaTien.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.tbGiaTien.BorderThickness = 3;
            this.tbGiaTien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbGiaTien.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbGiaTien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbGiaTien.isPassword = false;
            this.tbGiaTien.Location = new System.Drawing.Point(182, 91);
            this.tbGiaTien.Margin = new System.Windows.Forms.Padding(4);
            this.tbGiaTien.Name = "tbGiaTien";
            this.tbGiaTien.Size = new System.Drawing.Size(144, 31);
            this.tbGiaTien.TabIndex = 4;
            this.tbGiaTien.Text = "Gía tiền";
            this.tbGiaTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tbGiaTien);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbTenDichVu);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbMaDichVu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 136);
            this.panel1.TabIndex = 5;
            // 
            // btnLuu
            // 
            this.btnLuu.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnLuu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLuu.BorderRadius = 0;
            this.btnLuu.ButtonText = "Lưu";
            this.btnLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuu.DisabledColor = System.Drawing.Color.Gray;
            this.btnLuu.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLuu.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnLuu.Iconimage")));
            this.btnLuu.Iconimage_right = null;
            this.btnLuu.Iconimage_right_Selected = null;
            this.btnLuu.Iconimage_Selected = null;
            this.btnLuu.IconMarginLeft = 0;
            this.btnLuu.IconMarginRight = 0;
            this.btnLuu.IconRightVisible = true;
            this.btnLuu.IconRightZoom = 0D;
            this.btnLuu.IconVisible = true;
            this.btnLuu.IconZoom = 90D;
            this.btnLuu.IsTab = false;
            this.btnLuu.Location = new System.Drawing.Point(139, 451);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(5);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnLuu.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnLuu.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLuu.selected = false;
            this.btnLuu.Size = new System.Drawing.Size(132, 41);
            this.btnLuu.TabIndex = 1;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Textcolor = System.Drawing.Color.White;
            this.btnLuu.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // frmSepThemDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 500);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnGetPicture);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmSepThemDichVu";
            this.Text = "frmSepThemDichVu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuFlatButton btnGetPicture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbMaDichVu;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbTenDichVu;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbGiaTien;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnLuu;
    }
}