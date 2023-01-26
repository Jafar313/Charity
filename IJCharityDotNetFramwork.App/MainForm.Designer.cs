namespace IJCharityDotNetFramwork.App
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainmenu = new System.Windows.Forms.MenuStrip();
            this.مدیریتبخشاداریToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.مدیریتبخشنذوراتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AnbarMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.saleReportbyNoeKhanevadeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ManateghMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.settingMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.connectionStringsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.FamilyFilesMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.FamilyMembersMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mainmenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainmenu
            // 
            this.mainmenu.Font = new System.Drawing.Font("B Yekan", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.mainmenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.مدیریتبخشاداریToolStripMenuItem,
            this.مدیریتبخشنذوراتToolStripMenuItem,
            this.AnbarMenu,
            this.ManateghMenu,
            this.settingMenu});
            this.mainmenu.Location = new System.Drawing.Point(0, 0);
            this.mainmenu.Name = "mainmenu";
            this.mainmenu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mainmenu.Size = new System.Drawing.Size(1264, 31);
            this.mainmenu.TabIndex = 0;
            // 
            // مدیریتبخشاداریToolStripMenuItem
            // 
            this.مدیریتبخشاداریToolStripMenuItem.Name = "مدیریتبخشاداریToolStripMenuItem";
            this.مدیریتبخشاداریToolStripMenuItem.Size = new System.Drawing.Size(132, 27);
            this.مدیریتبخشاداریToolStripMenuItem.Text = "مدیریت بخش اداری";
            // 
            // مدیریتبخشنذوراتToolStripMenuItem
            // 
            this.مدیریتبخشنذوراتToolStripMenuItem.Name = "مدیریتبخشنذوراتToolStripMenuItem";
            this.مدیریتبخشنذوراتToolStripMenuItem.Size = new System.Drawing.Size(144, 27);
            this.مدیریتبخشنذوراتToolStripMenuItem.Text = "مدیریت بخش نذورات";
            // 
            // AnbarMenu
            // 
            this.AnbarMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saleReportbyNoeKhanevadeMenu});
            this.AnbarMenu.Name = "AnbarMenu";
            this.AnbarMenu.Size = new System.Drawing.Size(124, 27);
            this.AnbarMenu.Text = "&مدیریت بخش انبار";
            // 
            // saleReportbyNoeKhanevadeMenu
            // 
            this.saleReportbyNoeKhanevadeMenu.Name = "saleReportbyNoeKhanevadeMenu";
            this.saleReportbyNoeKhanevadeMenu.Size = new System.Drawing.Size(258, 28);
            this.saleReportbyNoeKhanevadeMenu.Text = "آمار خروجی کالا به تفکیک خانواده";
            this.saleReportbyNoeKhanevadeMenu.Click += new System.EventHandler(this.saleReportbyNoeKhanevadeMenu_Click);
            // 
            // ManateghMenu
            // 
            this.ManateghMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FamilyFilesMenu,
            this.FamilyMembersMenu});
            this.ManateghMenu.Name = "ManateghMenu";
            this.ManateghMenu.Size = new System.Drawing.Size(133, 27);
            this.ManateghMenu.Text = "م&دیریت بخش مناطق";
            // 
            // settingMenu
            // 
            this.settingMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectionStringsMenu});
            this.settingMenu.Name = "settingMenu";
            this.settingMenu.Size = new System.Drawing.Size(66, 27);
            this.settingMenu.Text = "تنظیمات";
            // 
            // connectionStringsMenu
            // 
            this.connectionStringsMenu.Name = "connectionStringsMenu";
            this.connectionStringsMenu.Size = new System.Drawing.Size(286, 28);
            this.connectionStringsMenu.Text = "تنظیم بانک اطلاعاتی و فایل های اجرایی";
            this.connectionStringsMenu.Click += new System.EventHandler(this.connectionStringsMenu_Click);
            // 
            // FamilyFilesMenu
            // 
            this.FamilyFilesMenu.Name = "FamilyFilesMenu";
            this.FamilyFilesMenu.Size = new System.Drawing.Size(180, 28);
            this.FamilyFilesMenu.Text = "لیست پرونده ها";
            this.FamilyFilesMenu.Click += new System.EventHandler(this.FamilyFilesMenu_Click);
            // 
            // FamilyMembersMenu
            // 
            this.FamilyMembersMenu.Name = "FamilyMembersMenu";
            this.FamilyMembersMenu.Size = new System.Drawing.Size(180, 28);
            this.FamilyMembersMenu.Text = "لیست افراد";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::IJCharityDotNetFramwork.App.Properties.Resources.image_Vector_abstract_background_technology_innovation_of_the_future__stocky_ai_24971064;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 729);
            this.Controls.Add(this.mainmenu);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mainmenu;
            this.Name = "MainForm";
            this.Text = "سامانه مدیریت امور خیریه";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mainmenu.ResumeLayout(false);
            this.mainmenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainmenu;
        private System.Windows.Forms.ToolStripMenuItem AnbarMenu;
        private System.Windows.Forms.ToolStripMenuItem ManateghMenu;
        private System.Windows.Forms.ToolStripMenuItem مدیریتبخشنذوراتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem مدیریتبخشاداریToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saleReportbyNoeKhanevadeMenu;
        private System.Windows.Forms.ToolStripMenuItem settingMenu;
        private System.Windows.Forms.ToolStripMenuItem connectionStringsMenu;
        private System.Windows.Forms.ToolStripMenuItem FamilyFilesMenu;
        private System.Windows.Forms.ToolStripMenuItem FamilyMembersMenu;
    }
}