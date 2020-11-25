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
            this.panel7 = new System.Windows.Forms.Panel();
            this.tbTenCoDau = new Bunifu.Framework.UI.BunifuTextbox();
            this.tbTenChuRe = new Bunifu.Framework.UI.BunifuTextbox();
            this.dtpTraCuuTiec = new Bunifu.Framework.UI.BunifuDatepicker();
            this.panelTitle2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelComboBox = new System.Windows.Forms.Panel();
            this.cmbCa = new Bunifu.Framework.UI.BunifuDropdown();
            this.cmbTenSanh = new Bunifu.Framework.UI.BunifuDropdown();
            this.cmbMaHopDong = new Bunifu.Framework.UI.BunifuDropdown();
            this.cmbMaKhachHang = new Bunifu.Framework.UI.BunifuDropdown();
            this.panelTitle = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.panelRightBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraCuTiec)).BeginInit();
            this.panelThongTinMonAn.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panelTitle2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelComboBox.SuspendLayout();
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
            this.panelRightBar.Location = new System.Drawing.Point(0, 62);
            this.panelRightBar.Margin = new System.Windows.Forms.Padding(4);
            this.panelRightBar.Name = "panelRightBar";
            this.panelRightBar.Quality = 10;
            this.panelRightBar.Size = new System.Drawing.Size(1220, 782);
            this.panelRightBar.TabIndex = 11;
            // 
            // dgvTraCuTiec
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvTraCuTiec.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTraCuTiec.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvTraCuTiec.BorderStyle = System.Windows.Forms.BorderStyle.None;
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
            this.dgvTraCuTiec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTraCuTiec.DoubleBuffered = true;
            this.dgvTraCuTiec.EnableHeadersVisualStyles = false;
            this.dgvTraCuTiec.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dgvTraCuTiec.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.dgvTraCuTiec.Location = new System.Drawing.Point(0, 176);
            this.dgvTraCuTiec.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTraCuTiec.Name = "dgvTraCuTiec";
            this.dgvTraCuTiec.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvTraCuTiec.RowHeadersWidth = 51;
            this.dgvTraCuTiec.Size = new System.Drawing.Size(1220, 606);
            this.dgvTraCuTiec.TabIndex = 3;
            // 
            // panelThongTinMonAn
            // 
            this.panelThongTinMonAn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelThongTinMonAn.BackgroundImage")));
            this.panelThongTinMonAn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelThongTinMonAn.Controls.Add(this.panel7);
            this.panelThongTinMonAn.Controls.Add(this.panelTitle2);
            this.panelThongTinMonAn.Controls.Add(this.panelComboBox);
            this.panelThongTinMonAn.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelThongTinMonAn.GradientBottomLeft = System.Drawing.Color.White;
            this.panelThongTinMonAn.GradientBottomRight = System.Drawing.Color.White;
            this.panelThongTinMonAn.GradientTopLeft = System.Drawing.Color.White;
            this.panelThongTinMonAn.GradientTopRight = System.Drawing.Color.White;
            this.panelThongTinMonAn.Location = new System.Drawing.Point(0, 0);
            this.panelThongTinMonAn.Margin = new System.Windows.Forms.Padding(4);
            this.panelThongTinMonAn.Name = "panelThongTinMonAn";
            this.panelThongTinMonAn.Quality = 10;
            this.panelThongTinMonAn.Size = new System.Drawing.Size(1220, 176);
            this.panelThongTinMonAn.TabIndex = 2;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.tbTenCoDau);
            this.panel7.Controls.Add(this.tbTenChuRe);
            this.panel7.Controls.Add(this.dtpTraCuuTiec);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1220, 86);
            this.panel7.TabIndex = 3;
            // 
            // tbTenCoDau
            // 
            this.tbTenCoDau.BackColor = System.Drawing.Color.Silver;
            this.tbTenCoDau.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbTenCoDau.BackgroundImage")));
            this.tbTenCoDau.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbTenCoDau.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbTenCoDau.ForeColor = System.Drawing.Color.SeaGreen;
            this.tbTenCoDau.Icon = ((System.Drawing.Image)(resources.GetObject("tbTenCoDau.Icon")));
            this.tbTenCoDau.Location = new System.Drawing.Point(627, 36);
            this.tbTenCoDau.Margin = new System.Windows.Forms.Padding(5);
            this.tbTenCoDau.Name = "tbTenCoDau";
            this.tbTenCoDau.Size = new System.Drawing.Size(593, 50);
            this.tbTenCoDau.TabIndex = 2;
            this.tbTenCoDau.text = "Tên cô dâu";
            // 
            // tbTenChuRe
            // 
            this.tbTenChuRe.BackColor = System.Drawing.Color.Silver;
            this.tbTenChuRe.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbTenChuRe.BackgroundImage")));
            this.tbTenChuRe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbTenChuRe.Dock = System.Windows.Forms.DockStyle.Left;
            this.tbTenChuRe.ForeColor = System.Drawing.Color.SeaGreen;
            this.tbTenChuRe.Icon = ((System.Drawing.Image)(resources.GetObject("tbTenChuRe.Icon")));
            this.tbTenChuRe.Location = new System.Drawing.Point(0, 36);
            this.tbTenChuRe.Margin = new System.Windows.Forms.Padding(5);
            this.tbTenChuRe.Name = "tbTenChuRe";
            this.tbTenChuRe.Size = new System.Drawing.Size(627, 50);
            this.tbTenChuRe.TabIndex = 2;
            this.tbTenChuRe.text = "Tên chú rể";
            // 
            // dtpTraCuuTiec
            // 
            this.dtpTraCuuTiec.BackColor = System.Drawing.Color.SeaGreen;
            this.dtpTraCuuTiec.BorderRadius = 0;
            this.dtpTraCuuTiec.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtpTraCuuTiec.ForeColor = System.Drawing.Color.White;
            this.dtpTraCuuTiec.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpTraCuuTiec.FormatCustom = null;
            this.dtpTraCuuTiec.Location = new System.Drawing.Point(0, 0);
            this.dtpTraCuuTiec.Margin = new System.Windows.Forms.Padding(5);
            this.dtpTraCuuTiec.Name = "dtpTraCuuTiec";
            this.dtpTraCuuTiec.Size = new System.Drawing.Size(1220, 36);
            this.dtpTraCuuTiec.TabIndex = 5;
            this.dtpTraCuuTiec.Value = new System.DateTime(2020, 11, 24, 18, 54, 25, 555);
            // 
            // panelTitle2
            // 
            this.panelTitle2.Controls.Add(this.panel6);
            this.panelTitle2.Controls.Add(this.panel5);
            this.panelTitle2.Controls.Add(this.panel4);
            this.panelTitle2.Controls.Add(this.panel3);
            this.panelTitle2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelTitle2.Location = new System.Drawing.Point(0, 86);
            this.panelTitle2.Margin = new System.Windows.Forms.Padding(4);
            this.panelTitle2.Name = "panelTitle2";
            this.panelTitle2.Size = new System.Drawing.Size(1220, 36);
            this.panelTitle2.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label4);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(912, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(304, 36);
            this.panel6.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(129, 6);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ca";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label3);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(608, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(304, 36);
            this.panel5.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(89, 6);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên sảnh";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(304, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(304, 36);
            this.panel4.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã hợp đồng";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(304, 36);
            this.panel3.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã khách hàng";
            // 
            // panelComboBox
            // 
            this.panelComboBox.Controls.Add(this.cmbCa);
            this.panelComboBox.Controls.Add(this.cmbTenSanh);
            this.panelComboBox.Controls.Add(this.cmbMaHopDong);
            this.panelComboBox.Controls.Add(this.cmbMaKhachHang);
            this.panelComboBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelComboBox.Location = new System.Drawing.Point(0, 122);
            this.panelComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.panelComboBox.Name = "panelComboBox";
            this.panelComboBox.Size = new System.Drawing.Size(1220, 54);
            this.panelComboBox.TabIndex = 0;
            // 
            // cmbCa
            // 
            this.cmbCa.BackColor = System.Drawing.Color.Transparent;
            this.cmbCa.BorderRadius = 3;
            this.cmbCa.Dock = System.Windows.Forms.DockStyle.Left;
            this.cmbCa.ForeColor = System.Drawing.Color.White;
            this.cmbCa.Items = new string[0];
            this.cmbCa.Location = new System.Drawing.Point(912, 0);
            this.cmbCa.Margin = new System.Windows.Forms.Padding(5);
            this.cmbCa.Name = "cmbCa";
            this.cmbCa.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.cmbCa.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.cmbCa.selectedIndex = -1;
            this.cmbCa.Size = new System.Drawing.Size(305, 54);
            this.cmbCa.TabIndex = 5;
            // 
            // cmbTenSanh
            // 
            this.cmbTenSanh.BackColor = System.Drawing.Color.Transparent;
            this.cmbTenSanh.BorderRadius = 3;
            this.cmbTenSanh.Dock = System.Windows.Forms.DockStyle.Left;
            this.cmbTenSanh.ForeColor = System.Drawing.Color.White;
            this.cmbTenSanh.Items = new string[0];
            this.cmbTenSanh.Location = new System.Drawing.Point(608, 0);
            this.cmbTenSanh.Margin = new System.Windows.Forms.Padding(5);
            this.cmbTenSanh.Name = "cmbTenSanh";
            this.cmbTenSanh.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.cmbTenSanh.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.cmbTenSanh.selectedIndex = -1;
            this.cmbTenSanh.Size = new System.Drawing.Size(304, 54);
            this.cmbTenSanh.TabIndex = 5;
            // 
            // cmbMaHopDong
            // 
            this.cmbMaHopDong.BackColor = System.Drawing.Color.Transparent;
            this.cmbMaHopDong.BorderRadius = 3;
            this.cmbMaHopDong.Dock = System.Windows.Forms.DockStyle.Left;
            this.cmbMaHopDong.ForeColor = System.Drawing.Color.White;
            this.cmbMaHopDong.Items = new string[0];
            this.cmbMaHopDong.Location = new System.Drawing.Point(304, 0);
            this.cmbMaHopDong.Margin = new System.Windows.Forms.Padding(5);
            this.cmbMaHopDong.Name = "cmbMaHopDong";
            this.cmbMaHopDong.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.cmbMaHopDong.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.cmbMaHopDong.selectedIndex = -1;
            this.cmbMaHopDong.Size = new System.Drawing.Size(304, 54);
            this.cmbMaHopDong.TabIndex = 5;
            // 
            // cmbMaKhachHang
            // 
            this.cmbMaKhachHang.BackColor = System.Drawing.Color.Transparent;
            this.cmbMaKhachHang.BorderRadius = 3;
            this.cmbMaKhachHang.Dock = System.Windows.Forms.DockStyle.Left;
            this.cmbMaKhachHang.ForeColor = System.Drawing.Color.White;
            this.cmbMaKhachHang.Items = new string[0];
            this.cmbMaKhachHang.Location = new System.Drawing.Point(0, 0);
            this.cmbMaKhachHang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbMaKhachHang.Name = "cmbMaKhachHang";
            this.cmbMaKhachHang.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.cmbMaKhachHang.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.cmbMaKhachHang.selectedIndex = -1;
            this.cmbMaKhachHang.Size = new System.Drawing.Size(304, 54);
            this.cmbMaKhachHang.TabIndex = 5;
            // 
            // panelTitle
            // 
            this.panelTitle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelTitle.BackgroundImage")));
            this.panelTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.GradientBottomLeft = System.Drawing.Color.White;
            this.panelTitle.GradientBottomRight = System.Drawing.Color.White;
            this.panelTitle.GradientTopLeft = System.Drawing.Color.White;
            this.panelTitle.GradientTopRight = System.Drawing.Color.White;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Margin = new System.Windows.Forms.Padding(4);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Quality = 10;
            this.panelTitle.Size = new System.Drawing.Size(1220, 62);
            this.panelTitle.TabIndex = 10;
            // 
            // frmTraCuuTiec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 844);
            this.Controls.Add(this.panelRightBar);
            this.Controls.Add(this.panelTitle);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTraCuuTiec";
            this.Text = "Tra cứu tiệc";
            this.panelRightBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraCuTiec)).EndInit();
            this.panelThongTinMonAn.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panelTitle2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panelComboBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel panelRightBar;
        private Bunifu.Framework.UI.BunifuGradientPanel panelThongTinMonAn;
        private Bunifu.Framework.UI.BunifuGradientPanel panelTitle;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvTraCuTiec;
        private System.Windows.Forms.Panel panel7;
        private Bunifu.Framework.UI.BunifuTextbox tbTenCoDau;
        private Bunifu.Framework.UI.BunifuTextbox tbTenChuRe;
        private Bunifu.Framework.UI.BunifuDatepicker dtpTraCuuTiec;
        private System.Windows.Forms.Panel panelTitle2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelComboBox;
        private Bunifu.Framework.UI.BunifuDropdown cmbCa;
        private Bunifu.Framework.UI.BunifuDropdown cmbTenSanh;
        private Bunifu.Framework.UI.BunifuDropdown cmbMaHopDong;
        private Bunifu.Framework.UI.BunifuDropdown cmbMaKhachHang;
    }
}