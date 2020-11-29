namespace TiecCuoi
{
    partial class frmTraCuuTiec
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTraCuuTiec));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelRightBar = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.dgvTraCuTiec = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.panelThongTinMonAn = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.panelUpperBar = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panelTitle2 = new System.Windows.Forms.Panel();
            this.panelComboBox = new System.Windows.Forms.Panel();
            this.cmbMaKhachHang = new System.Windows.Forms.ComboBox();
            this.cmbMaHopDong = new System.Windows.Forms.ComboBox();
            this.cmbTenSanh = new System.Windows.Forms.ComboBox();
            this.cmbCa = new System.Windows.Forms.ComboBox();
            this.tbTenChuRe = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.tbTenCoDau = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.dtpNgayToChuc = new Bunifu.Framework.UI.BunifuDatepicker();
            this.panelRightBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraCuTiec)).BeginInit();
            this.panelThongTinMonAn.SuspendLayout();
            this.panelUpperBar.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panelTitle2.SuspendLayout();
            this.panelComboBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelRightBar
            // 
            this.panelRightBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelRightBar.BackgroundImage")));
            this.panelRightBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelRightBar.Controls.Add(this.dgvTraCuTiec);
            this.panelRightBar.Controls.Add(this.panelThongTinMonAn);
            this.panelRightBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRightBar.GradientBottomLeft = System.Drawing.Color.White;
            this.panelRightBar.GradientBottomRight = System.Drawing.Color.White;
            this.panelRightBar.GradientTopLeft = System.Drawing.Color.White;
            this.panelRightBar.GradientTopRight = System.Drawing.Color.White;
            this.panelRightBar.Location = new System.Drawing.Point(0, 0);
            this.panelRightBar.Name = "panelRightBar";
            this.panelRightBar.Quality = 10;
            this.panelRightBar.Size = new System.Drawing.Size(915, 609);
            this.panelRightBar.TabIndex = 11;
            // 
            // dgvTraCuTiec
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvTraCuTiec.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTraCuTiec.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvTraCuTiec.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTraCuTiec.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTraCuTiec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTraCuTiec.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvTraCuTiec.DoubleBuffered = true;
            this.dgvTraCuTiec.EnableHeadersVisualStyles = false;
            this.dgvTraCuTiec.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dgvTraCuTiec.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.dgvTraCuTiec.Location = new System.Drawing.Point(0, 175);
            this.dgvTraCuTiec.Name = "dgvTraCuTiec";
            this.dgvTraCuTiec.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvTraCuTiec.RowHeadersWidth = 51;
            this.dgvTraCuTiec.Size = new System.Drawing.Size(915, 434);
            this.dgvTraCuTiec.TabIndex = 3;
            // 
            // panelThongTinMonAn
            // 
            this.panelThongTinMonAn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelThongTinMonAn.BackgroundImage")));
            this.panelThongTinMonAn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelThongTinMonAn.Controls.Add(this.panelComboBox);
            this.panelThongTinMonAn.Controls.Add(this.panelTitle2);
            this.panelThongTinMonAn.Controls.Add(this.panelUpperBar);
            this.panelThongTinMonAn.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelThongTinMonAn.GradientBottomLeft = System.Drawing.Color.White;
            this.panelThongTinMonAn.GradientBottomRight = System.Drawing.Color.White;
            this.panelThongTinMonAn.GradientTopLeft = System.Drawing.Color.White;
            this.panelThongTinMonAn.GradientTopRight = System.Drawing.Color.White;
            this.panelThongTinMonAn.Location = new System.Drawing.Point(0, 0);
            this.panelThongTinMonAn.Name = "panelThongTinMonAn";
            this.panelThongTinMonAn.Quality = 10;
            this.panelThongTinMonAn.Size = new System.Drawing.Size(915, 143);
            this.panelThongTinMonAn.TabIndex = 2;
            // 
            // panelUpperBar
            // 
            this.panelUpperBar.Controls.Add(this.dtpNgayToChuc);
            this.panelUpperBar.Controls.Add(this.iconPictureBox2);
            this.panelUpperBar.Controls.Add(this.iconPictureBox1);
            this.panelUpperBar.Controls.Add(this.tbTenCoDau);
            this.panelUpperBar.Controls.Add(this.tbTenChuRe);
            this.panelUpperBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUpperBar.Location = new System.Drawing.Point(0, 0);
            this.panelUpperBar.Name = "panelUpperBar";
            this.panelUpperBar.Size = new System.Drawing.Size(915, 66);
            this.panelUpperBar.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(228, 29);
            this.panel3.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã khách hàng";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(228, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(228, 29);
            this.panel4.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã hợp đồng";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.label3);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(456, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(228, 29);
            this.panel5.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(88, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên sảnh";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.label4);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(684, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(231, 29);
            this.panel6.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(109, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ca";
            // 
            // panelTitle2
            // 
            this.panelTitle2.Controls.Add(this.panel6);
            this.panelTitle2.Controls.Add(this.panel5);
            this.panelTitle2.Controls.Add(this.panel4);
            this.panelTitle2.Controls.Add(this.panel3);
            this.panelTitle2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle2.Location = new System.Drawing.Point(0, 66);
            this.panelTitle2.Name = "panelTitle2";
            this.panelTitle2.Size = new System.Drawing.Size(915, 29);
            this.panelTitle2.TabIndex = 5;
            // 
            // panelComboBox
            // 
            this.panelComboBox.BackColor = System.Drawing.Color.Green;
            this.panelComboBox.Controls.Add(this.cmbCa);
            this.panelComboBox.Controls.Add(this.cmbTenSanh);
            this.panelComboBox.Controls.Add(this.cmbMaHopDong);
            this.panelComboBox.Controls.Add(this.cmbMaKhachHang);
            this.panelComboBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelComboBox.Location = new System.Drawing.Point(0, 95);
            this.panelComboBox.Name = "panelComboBox";
            this.panelComboBox.Size = new System.Drawing.Size(915, 44);
            this.panelComboBox.TabIndex = 6;
            // 
            // cmbMaKhachHang
            // 
            this.cmbMaKhachHang.Dock = System.Windows.Forms.DockStyle.Left;
            this.cmbMaKhachHang.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMaKhachHang.FormattingEnabled = true;
            this.cmbMaKhachHang.Location = new System.Drawing.Point(0, 0);
            this.cmbMaKhachHang.Name = "cmbMaKhachHang";
            this.cmbMaKhachHang.Size = new System.Drawing.Size(228, 29);
            this.cmbMaKhachHang.TabIndex = 0;
            // 
            // cmbMaHopDong
            // 
            this.cmbMaHopDong.Dock = System.Windows.Forms.DockStyle.Left;
            this.cmbMaHopDong.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMaHopDong.FormattingEnabled = true;
            this.cmbMaHopDong.Location = new System.Drawing.Point(228, 0);
            this.cmbMaHopDong.Name = "cmbMaHopDong";
            this.cmbMaHopDong.Size = new System.Drawing.Size(228, 29);
            this.cmbMaHopDong.TabIndex = 1;
            // 
            // cmbTenSanh
            // 
            this.cmbTenSanh.Dock = System.Windows.Forms.DockStyle.Left;
            this.cmbTenSanh.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTenSanh.FormattingEnabled = true;
            this.cmbTenSanh.Location = new System.Drawing.Point(456, 0);
            this.cmbTenSanh.Name = "cmbTenSanh";
            this.cmbTenSanh.Size = new System.Drawing.Size(228, 29);
            this.cmbTenSanh.TabIndex = 2;
            // 
            // cmbCa
            // 
            this.cmbCa.Dock = System.Windows.Forms.DockStyle.Left;
            this.cmbCa.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCa.FormattingEnabled = true;
            this.cmbCa.Location = new System.Drawing.Point(684, 0);
            this.cmbCa.Name = "cmbCa";
            this.cmbCa.Size = new System.Drawing.Size(231, 29);
            this.cmbCa.TabIndex = 3;
            // 
            // tbTenChuRe
            // 
            this.tbTenChuRe.BackColor = System.Drawing.Color.White;
            this.tbTenChuRe.BorderColorFocused = System.Drawing.Color.Blue;
            this.tbTenChuRe.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbTenChuRe.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.tbTenChuRe.BorderThickness = 3;
            this.tbTenChuRe.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbTenChuRe.Dock = System.Windows.Forms.DockStyle.Left;
            this.tbTenChuRe.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbTenChuRe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbTenChuRe.isPassword = false;
            this.tbTenChuRe.Location = new System.Drawing.Point(0, 0);
            this.tbTenChuRe.Margin = new System.Windows.Forms.Padding(4);
            this.tbTenChuRe.Name = "tbTenChuRe";
            this.tbTenChuRe.Size = new System.Drawing.Size(312, 66);
            this.tbTenChuRe.TabIndex = 0;
            this.tbTenChuRe.Text = "Tên chú rể";
            this.tbTenChuRe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbTenCoDau
            // 
            this.tbTenCoDau.BackColor = System.Drawing.Color.White;
            this.tbTenCoDau.BorderColorFocused = System.Drawing.Color.Blue;
            this.tbTenCoDau.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbTenCoDau.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.tbTenCoDau.BorderThickness = 3;
            this.tbTenCoDau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbTenCoDau.Dock = System.Windows.Forms.DockStyle.Left;
            this.tbTenCoDau.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbTenCoDau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbTenCoDau.isPassword = false;
            this.tbTenCoDau.Location = new System.Drawing.Point(312, 0);
            this.tbTenCoDau.Margin = new System.Windows.Forms.Padding(4);
            this.tbTenCoDau.Name = "tbTenCoDau";
            this.tbTenCoDau.Size = new System.Drawing.Size(312, 66);
            this.tbTenCoDau.TabIndex = 1;
            this.tbTenCoDau.Text = "Tên cô dâu";
            this.tbTenCoDau.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.White;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 40;
            this.iconPictureBox1.Location = new System.Drawing.Point(15, 14);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(41, 40);
            this.iconPictureBox1.TabIndex = 2;
            this.iconPictureBox1.TabStop = false;
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.White;
            this.iconPictureBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            this.iconPictureBox2.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 40;
            this.iconPictureBox2.Location = new System.Drawing.Point(325, 14);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(40, 40);
            this.iconPictureBox2.TabIndex = 2;
            this.iconPictureBox2.TabStop = false;
            // 
            // dtpNgayToChuc
            // 
            this.dtpNgayToChuc.BackColor = System.Drawing.Color.SeaGreen;
            this.dtpNgayToChuc.BorderRadius = 0;
            this.dtpNgayToChuc.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayToChuc.ForeColor = System.Drawing.Color.White;
            this.dtpNgayToChuc.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpNgayToChuc.FormatCustom = null;
            this.dtpNgayToChuc.Location = new System.Drawing.Point(624, 4);
            this.dtpNgayToChuc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpNgayToChuc.Name = "dtpNgayToChuc";
            this.dtpNgayToChuc.Size = new System.Drawing.Size(291, 60);
            this.dtpNgayToChuc.TabIndex = 3;
            this.dtpNgayToChuc.Value = new System.DateTime(2020, 11, 29, 15, 57, 24, 553);
            // 
            // frmTraCuuTiec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 609);
            this.Controls.Add(this.panelRightBar);
            this.Name = "frmTraCuuTiec";
            this.Text = "Tra cứu tiệc";
            this.panelRightBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraCuTiec)).EndInit();
            this.panelThongTinMonAn.ResumeLayout(false);
            this.panelUpperBar.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panelTitle2.ResumeLayout(false);
            this.panelComboBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel panelRightBar;
        private Bunifu.Framework.UI.BunifuGradientPanel panelThongTinMonAn;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvTraCuTiec;
        private System.Windows.Forms.Panel panelUpperBar;
        private System.Windows.Forms.Panel panelComboBox;
        private System.Windows.Forms.ComboBox cmbCa;
        private System.Windows.Forms.ComboBox cmbTenSanh;
        private System.Windows.Forms.ComboBox cmbMaHopDong;
        private System.Windows.Forms.ComboBox cmbMaKhachHang;
        private System.Windows.Forms.Panel panelTitle2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuDatepicker dtpNgayToChuc;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbTenCoDau;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbTenChuRe;
    }
}