namespace TiecCuoi
{
    partial class frmChonDichVu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChonDichVu));
            this.bunifuGradientPanel3 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.flpanelCheckBox = new System.Windows.Forms.FlowLayoutPanel();
            this.panelButton = new System.Windows.Forms.Panel();
            this.btnXacNhan = new FontAwesome.Sharp.IconButton();
            this.btnThoat = new FontAwesome.Sharp.IconButton();
            this.bunifuGradientPanel3.SuspendLayout();
            this.panelButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel3
            // 
            this.bunifuGradientPanel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel3.BackgroundImage")));
            this.bunifuGradientPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel3.Controls.Add(this.flpanelCheckBox);
            this.bunifuGradientPanel3.Controls.Add(this.panelButton);
            this.bunifuGradientPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel3.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel3.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel3.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel3.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel3.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuGradientPanel3.Name = "bunifuGradientPanel3";
            this.bunifuGradientPanel3.Quality = 10;
            this.bunifuGradientPanel3.Size = new System.Drawing.Size(1220, 844);
            this.bunifuGradientPanel3.TabIndex = 10;
            // 
            // flpanelCheckBox
            // 
            this.flpanelCheckBox.AutoScroll = true;
            this.flpanelCheckBox.BackColor = System.Drawing.Color.White;
            this.flpanelCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpanelCheckBox.Location = new System.Drawing.Point(0, 0);
            this.flpanelCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.flpanelCheckBox.Name = "flpanelCheckBox";
            this.flpanelCheckBox.Size = new System.Drawing.Size(1220, 703);
            this.flpanelCheckBox.TabIndex = 49;
            // 
            // panelButton
            // 
            this.panelButton.Controls.Add(this.btnXacNhan);
            this.panelButton.Controls.Add(this.btnThoat);
            this.panelButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButton.Location = new System.Drawing.Point(0, 703);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(1220, 141);
            this.panelButton.TabIndex = 48;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(207)))), ((int)(((byte)(168)))));
            this.btnXacNhan.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnXacNhan.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.btnXacNhan.IconColor = System.Drawing.Color.White;
            this.btnXacNhan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXacNhan.IconSize = 40;
            this.btnXacNhan.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnXacNhan.Location = new System.Drawing.Point(189, 55);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(177, 55);
            this.btnXacNhan.TabIndex = 10;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = false;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(207)))), ((int)(((byte)(168)))));
            this.btnThoat.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThoat.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.btnThoat.IconColor = System.Drawing.Color.White;
            this.btnThoat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThoat.IconSize = 40;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnThoat.Location = new System.Drawing.Point(809, 55);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(177, 55);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmChonDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 844);
            this.Controls.Add(this.bunifuGradientPanel3);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmChonDichVu";
            this.Text = "Chọn dịch vụ";
            this.bunifuGradientPanel3.ResumeLayout(false);
            this.panelButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel3;
        private System.Windows.Forms.Panel panelButton;
        private System.Windows.Forms.FlowLayoutPanel flpanelCheckBox;
        private FontAwesome.Sharp.IconButton btnThoat;
        private FontAwesome.Sharp.IconButton btnXacNhan;
    }
}