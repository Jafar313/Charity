namespace IJCharityDotNetFramwork.App.SettingsForm
{
    partial class DbConnectionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DbConnectionsForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOpenStartupPath = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.comboDbOffice = new System.Windows.Forms.ComboBox();
            this.comboDbNozorat = new System.Windows.Forms.ComboBox();
            this.comboDbManategh = new System.Windows.Forms.ComboBox();
            this.comboDbAnbar = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkSqlAuth = new System.Windows.Forms.CheckBox();
            this.txtSqlPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSqlUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtServerAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnOpenStartupPath);
            this.groupBox1.Font = new System.Drawing.Font("B Yekan", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox1.Location = new System.Drawing.Point(12, 327);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(1240, 328);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "سایر تنظیمات";
            // 
            // btnOpenStartupPath
            // 
            this.btnOpenStartupPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenStartupPath.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnOpenStartupPath.Image = global::IJCharityDotNetFramwork.App.Properties.Resources.icons8_browse_folder_48;
            this.btnOpenStartupPath.Location = new System.Drawing.Point(1093, 48);
            this.btnOpenStartupPath.Name = "btnOpenStartupPath";
            this.btnOpenStartupPath.Size = new System.Drawing.Size(141, 60);
            this.btnOpenStartupPath.TabIndex = 12;
            this.btnOpenStartupPath.Text = "نمایش فایل های چاپ";
            this.btnOpenStartupPath.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnOpenStartupPath.UseVisualStyleBackColor = true;
            this.btnOpenStartupPath.Click += new System.EventHandler(this.btnOpenStartupPath_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnSaveSettings);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Font = new System.Drawing.Font("B Yekan", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(1240, 309);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "تنظیمات بانک اطلاعاتی";
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnSaveSettings.Location = new System.Drawing.Point(254, 258);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(141, 45);
            this.btnSaveSettings.TabIndex = 10;
            this.btnSaveSettings.Text = "ذخیره تنظیمات";
            this.btnSaveSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSaveSettings.UseVisualStyleBackColor = true;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.comboDbOffice);
            this.groupBox4.Controls.Add(this.comboDbNozorat);
            this.groupBox4.Controls.Add(this.comboDbManategh);
            this.groupBox4.Controls.Add(this.comboDbAnbar);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Location = new System.Drawing.Point(401, 30);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(524, 273);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "اسامی بانک های اطلاعاتی";
            // 
            // comboDbOffice
            // 
            this.comboDbOffice.FormattingEnabled = true;
            this.comboDbOffice.Location = new System.Drawing.Point(173, 198);
            this.comboDbOffice.Name = "comboDbOffice";
            this.comboDbOffice.Size = new System.Drawing.Size(170, 31);
            this.comboDbOffice.TabIndex = 9;
            // 
            // comboDbNozorat
            // 
            this.comboDbNozorat.FormattingEnabled = true;
            this.comboDbNozorat.Location = new System.Drawing.Point(173, 146);
            this.comboDbNozorat.Name = "comboDbNozorat";
            this.comboDbNozorat.Size = new System.Drawing.Size(170, 31);
            this.comboDbNozorat.TabIndex = 8;
            // 
            // comboDbManategh
            // 
            this.comboDbManategh.FormattingEnabled = true;
            this.comboDbManategh.Location = new System.Drawing.Point(173, 98);
            this.comboDbManategh.Name = "comboDbManategh";
            this.comboDbManategh.Size = new System.Drawing.Size(170, 31);
            this.comboDbManategh.TabIndex = 7;
            // 
            // comboDbAnbar
            // 
            this.comboDbAnbar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDbAnbar.FormattingEnabled = true;
            this.comboDbAnbar.Location = new System.Drawing.Point(173, 46);
            this.comboDbAnbar.Name = "comboDbAnbar";
            this.comboDbAnbar.Size = new System.Drawing.Size(170, 31);
            this.comboDbAnbar.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(349, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 23);
            this.label7.TabIndex = 0;
            this.label7.Text = "سیستم مدیریت نذورات";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(349, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "سیستم مدیریت انبار";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(349, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "سیستم مدیریت اداری";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(349, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "سیستم مدیریت مناطق";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkSqlAuth);
            this.groupBox3.Controls.Add(this.txtSqlPassword);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtSqlUserName);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtServerAddress);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(931, 30);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(303, 273);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "تنظیمات اتصال";
            // 
            // checkSqlAuth
            // 
            this.checkSqlAuth.AutoSize = true;
            this.checkSqlAuth.Location = new System.Drawing.Point(15, 112);
            this.checkSqlAuth.Name = "checkSqlAuth";
            this.checkSqlAuth.Size = new System.Drawing.Size(200, 27);
            this.checkSqlAuth.TabIndex = 2;
            this.checkSqlAuth.Text = "SQL Server Authentication";
            this.checkSqlAuth.UseVisualStyleBackColor = true;
            this.checkSqlAuth.CheckedChanged += new System.EventHandler(this.checkSqlAuth_CheckedChanged);
            // 
            // txtSqlPassword
            // 
            this.txtSqlPassword.Enabled = false;
            this.txtSqlPassword.Location = new System.Drawing.Point(15, 198);
            this.txtSqlPassword.Name = "txtSqlPassword";
            this.txtSqlPassword.Size = new System.Drawing.Size(168, 30);
            this.txtSqlPassword.TabIndex = 4;
            this.txtSqlPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSqlPassword.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(189, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "رمز عبور";
            // 
            // txtSqlUserName
            // 
            this.txtSqlUserName.Enabled = false;
            this.txtSqlUserName.Location = new System.Drawing.Point(15, 146);
            this.txtSqlUserName.Name = "txtSqlUserName";
            this.txtSqlUserName.Size = new System.Drawing.Size(168, 30);
            this.txtSqlUserName.TabIndex = 3;
            this.txtSqlUserName.Text = "Sa";
            this.txtSqlUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "نام کاربری SQL";
            // 
            // txtServerAddress
            // 
            this.txtServerAddress.Location = new System.Drawing.Point(15, 46);
            this.txtServerAddress.MaxLength = 15;
            this.txtServerAddress.Name = "txtServerAddress";
            this.txtServerAddress.Size = new System.Drawing.Size(168, 30);
            this.txtServerAddress.TabIndex = 1;
            this.txtServerAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtServerAddress.Leave += new System.EventHandler(this.txtServerAddress_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "آدرس سرور";
            // 
            // DbConnectionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 667);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "DbConnectionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "تنظیمات";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOpenStartupPath;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtServerAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSqlPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSqlUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkSqlAuth;
        private System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.ComboBox comboDbAnbar;
        private System.Windows.Forms.ComboBox comboDbOffice;
        private System.Windows.Forms.ComboBox comboDbNozorat;
        private System.Windows.Forms.ComboBox comboDbManategh;
    }
}

