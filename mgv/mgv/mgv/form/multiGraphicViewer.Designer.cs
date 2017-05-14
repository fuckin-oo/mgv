namespace mgv
{
    partial class multiGraphicViewer
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(multiGraphicViewer));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.newGraphicLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolMenu});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // FileToolMenu
            // 
            this.FileToolMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGraphicLoad,
            this.toolStripMenuItem1,
            this.ExitApplication});
            this.FileToolMenu.Name = "FileToolMenu";
            resources.ApplyResources(this.FileToolMenu, "FileToolMenu");
            // 
            // newGraphicLoad
            // 
            this.newGraphicLoad.Name = "newGraphicLoad";
            resources.ApplyResources(this.newGraphicLoad, "newGraphicLoad");
            this.newGraphicLoad.Click += new System.EventHandler(this.newGraphicLoad_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            // 
            // ExitApplication
            // 
            this.ExitApplication.Name = "ExitApplication";
            resources.ApplyResources(this.ExitApplication, "ExitApplication");
            this.ExitApplication.Click += new System.EventHandler(this.ExitApplication_Click);
            // 
            // flowLayoutPanel1
            // 
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // multiGraphicViewer
            // 
            this.AllowDrop = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "multiGraphicViewer";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.multiGraphicViewer_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.multiGraphicViewer_DragEnter);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        // 「ファイル」
        private System.Windows.Forms.ToolStripMenuItem FileToolMenu;
        private System.Windows.Forms.ToolStripMenuItem newGraphicLoad;
        private System.Windows.Forms.ToolStripMenuItem ExitApplication;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

