using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mgv.form
{
    public partial class graphicViewer : UserControl
    {
        public graphicViewer(string graphic)
        {
            InitializeComponent();

            this.pictureBox1.Image = System.Drawing.Image.FromFile(graphic);
            this.pictureBox1.Size = this.pictureBox1.Image.Size;

            // ツールボックスと画像、大きいほうにサイズを合わせる
            this.Size = new Size((this.pictureBox1.Size.Width > this.toolStrip1.Size.Width) ? this.pictureBox1.Size.Width : this.toolStrip1.Size.Width,
                                 (this.pictureBox1.Size.Height > this.toolStrip1.Size.Height) ? this.pictureBox1.Size.Height : this.toolStrip1.Size.Height);
        }

        private graphicViewer()
        {
            InitializeComponent();
        }

        #region マウスオーバー時のみツールバーを表示
        // マウスオーバー時(子から呼ぶ用)
        public void OnMouseEnter(object obj, EventArgs e)
        {
            this.OnMouseEnter(e);
        }
        // マウスオーバー時
        protected override void OnMouseEnter(EventArgs e)
        {
            this.toolStrip1.Show();
            base.OnMouseEnter(e);
        }

        // マウスが離れたとき(子から呼ぶ用)
        public void OnMouseLeave(object obj, EventArgs e)
        {
            this.OnMouseLeave(e);
        }
        // マウスが離れたとき
        protected override void OnMouseLeave(EventArgs e)
        {
            this.toolStrip1.Hide();
            base.OnMouseLeave(e);
        }
        #endregion

        #region ツールバークリックイベント
        // 拡大縮小ボタンクリックイベント
        private void scaleButton_Click(object sender, EventArgs e)
        {

        }
        // 回転ボタンクリックイベント
        private void rotateButton_Click(object sender, EventArgs e)
        {

        }
        // 左右反転ボタンクリックイベント
        private void mirrorLRButton_Click(object sender, EventArgs e)
        {

        }
        // 上下反転ボタンクリックイベント
        private void mirrorUDButton_Click(object sender, EventArgs e)
        {

        }
        // 手の平ツールボタンクリックイベント
        private void clipToolButton_Click(object sender, EventArgs e)
        {

        }
        // 閉じるボタンクリックイベント
        private void quitButton_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
