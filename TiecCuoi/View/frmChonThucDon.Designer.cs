namespace TiecCuoi
{
    partial class frmChonMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChonMenu));
            this.panelContainer = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.flpanelCheckBox = new System.Windows.Forms.FlowLayoutPanel();
            this.panelButton = new System.Windows.Forms.Panel();
            this.btnXacNhan = new FontAwesome.Sharp.IconButton();
            this.btnThoat = new FontAwesome.Sharp.IconButton();
            this.panelContainer.SuspendLayout();
            this.panelButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelContainer.BackgroundImage")));
            this.panelContainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelContainer.Controls.Add(this.flpanelCheckBox);
            this.panelContainer.Controls.Add(this.panelButton);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.GradientBottomLeft = System.Drawing.Color.White;
            this.panelContainer.GradientBottomRight = System.Drawing.Color.White;
            this.panelContainer.GradientTopLeft = System.Drawing.Color.White;
            this.panelContainer.GradientTopRight = System.Drawing.Color.White;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Margin = new System.Windows.Forms.Padding(4);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Quality = 10;
            this.panelContainer.Size = new System.Drawing.Size(1220, 844);
            this.panelContainer.TabIndex = 8;
            // 
            // flpanelCheckBox
            // 
            this.flpanelCheckBox.AutoScroll = true;
            this.flpanelCheckBox.BackColor = System.Drawing.Color.White;
            this.flpanelCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpanelCheckBox.Location = new System.Drawing.Point(0, 0);
            this.flpanelCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.flpanelCheckBox.Name = "flpanelCheckBox";
            this.flpanelCheckBox.Size = new System.Drawing.Size(1220, 688);
            this.flpanelCheckBox.TabIndex = 7;
            // 
            // panelButton
            // 
            this.panelButton.Controls.Add(this.btnXacNhan);
            this.panelButton.Controls.Add(this.btnThoat);
            this.panelButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButton.Location = new System.Drawing.Point(0, 688);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(1220, 156);
            this.panelButton.TabIndex = 6;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(207)))), ((int)(((byte)(168)))));
            this.btnXacNhan.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhan.ForeColor = System.Drawing.Color.White;
            this.btnXacNhan.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.btnXacNhan.IconColor = System.Drawing.Color.White;
            this.btnXacNhan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXacNhan.IconSize = 40;
            this.btnXacNhan.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnXacNhan.Location = new System.Drawing.Point(284, 43);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(177, 55);
            this.btnXacNhan.TabIndex = 9;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = false;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(207)))), ((int)(((byte)(168)))));
            this.btnThoat.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.btnThoat.IconColor = System.Drawing.Color.White;
            this.btnThoat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThoat.IconSize = 40;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnThoat.Location = new System.Drawing.Point(799, 43);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(177, 55);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmChonMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 844);
            this.Controls.Add(this.panelContainer);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmChonMenu";
            this.Text = "Chọn thực đơn";
            this.panelContainer.ResumeLayout(false);
            this.panelButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuGradientPanel panelContainer;
        private System.Windows.Forms.Panel panelButton;
        private System.Windows.Forms.FlowLayoutPanel flpanelCheckBox;
        private FontAwesome.Sharp.IconButton btnXacNhan;
        private FontAwesome.Sharp.IconButton btnThoat;
    }
}