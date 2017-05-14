namespace mgv.form
{
    partial class graphicViewer
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

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(graphicViewer));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.scaleButton = new System.Windows.Forms.ToolStripButton();
            this.rotateButton = new System.Windows.Forms.ToolStripButton();
            this.mirrorLRButton = new System.Windows.Forms.ToolStripButton();
            this.mirrorUDButton = new System.Windows.Forms.ToolStripButton();
            this.clipToolButton = new System.Windows.Forms.ToolStripButton();
            this.quitButton = new System.Windows.Forms.ToolStripButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scaleButton,
            this.rotateButton,
            this.mirrorLRButton,
            this.mirrorUDButton,
            this.clipToolButton,
            this.quitButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(150, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // scaleButton
            // 
            this.scaleButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.scaleButton.Image = ((System.Drawing.Image)(resources.GetObject("scaleButton.Image")));
            this.scaleButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.scaleButton.Name = "scaleButton";
            this.scaleButton.Size = new System.Drawing.Size(23, 22);
            this.scaleButton.Text = "toolStripButton1";
            this.scaleButton.Click += new System.EventHandler(this.scaleButton_Click);
            // 
            // rotateButton
            // 
            this.rotateButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rotateButton.Image = ((System.Drawing.Image)(resources.GetObject("rotateButton.Image")));
            this.rotateButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.rotateButton.Name = "rotateButton";
            this.rotateButton.Size = new System.Drawing.Size(23, 22);
            this.rotateButton.Text = "toolStripButton2";
            this.rotateButton.Click += new System.EventHandler(this.rotateButton_Click);
            // 
            // mirrorLRButton
            // 
            this.mirrorLRButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mirrorLRButton.Image = ((System.Drawing.Image)(resources.GetObject("mirrorLRButton.Image")));
            this.mirrorLRButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mirrorLRButton.Name = "mirrorLRButton";
            this.mirrorLRButton.Size = new System.Drawing.Size(23, 22);
            this.mirrorLRButton.Text = "toolStripButton3";
            this.mirrorLRButton.Click += new System.EventHandler(this.mirrorLRButton_Click);
            // 
            // mirrorUDButton
            // 
            this.mirrorUDButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mirrorUDButton.Image = ((System.Drawing.Image)(resources.GetObject("mirrorUDButton.Image")));
            this.mirrorUDButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mirrorUDButton.Name = "mirrorUDButton";
            this.mirrorUDButton.Size = new System.Drawing.Size(23, 22);
            this.mirrorUDButton.Text = "toolStripButton4";
            this.mirrorUDButton.Click += new System.EventHandler(this.mirrorUDButton_Click);
            // 
            // clipToolButton
            // 
            this.clipToolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.clipToolButton.Image = ((System.Drawing.Image)(resources.GetObject("clipToolButton.Image")));
            this.clipToolButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.clipToolButton.Name = "clipToolButton";
            this.clipToolButton.Size = new System.Drawing.Size(23, 22);
            this.clipToolButton.Text = "toolStripButton5";
            this.clipToolButton.Click += new System.EventHandler(this.clipToolButton_Click);
            // 
            // quitButton
            // 
            this.quitButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.quitButton.Image = ((System.Drawing.Image)(resources.GetObject("quitButton.Image")));
            this.quitButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(23, 22);
            this.quitButton.Text = "toolStripButton6";
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 147);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // graphicViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "graphicViewer";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton scaleButton;
        private System.Windows.Forms.ToolStripButton rotateButton;
        private System.Windows.Forms.ToolStripButton mirrorLRButton;
        private System.Windows.Forms.ToolStripButton mirrorUDButton;
        private System.Windows.Forms.ToolStripButton clipToolButton;
        private System.Windows.Forms.ToolStripButton quitButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
