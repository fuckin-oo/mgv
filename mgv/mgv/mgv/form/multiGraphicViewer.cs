using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using mgv.sources;

namespace mgv
{
    public partial class multiGraphicViewer : Form
    {
        public multiGraphicViewer()
        {
            InitializeComponent();
        }

        #region メニュークリックイベント
        /*
         * 「ファイル」
         */
        // 新規画像読み込みクリックイベント
        private void newGraphicLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            DialogResult result = dialog.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                this.openGraphic(dialog.FileNames);
            }
        }

        // アプリケーションの終了クリックイベント
        private void ExitApplication_Click(object sender, EventArgs e)
        {
            this.ApplicationClose();
        }
        #endregion

        /**
         * ファイルのドラッグ&ドロップコールバック
         */
        private void multiGraphicViewer_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {

                // ドラッグ中のファイルやディレクトリの取得
                string[] drags = (string[])e.Data.GetData(DataFormats.FileDrop);

                foreach (string d in drags)
                {
                    if (!System.IO.File.Exists(d))
                    {
                        // ファイル以外であればイベント・ハンドラを抜ける
                        return;
                    }
                }
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void multiGraphicViewer_DragDrop(object sender, DragEventArgs e)
        {
            // ドラッグ＆ドロップされたファイル
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            this.openGraphic(files);
        }

        private void openGraphic(string[] files)
        {
            foreach (var file in files)
            {
                var viewer = viewerManager.getInstance().addGraphicViewer(file);
                if (viewer == null)
                {
                    // 開ける最大画像数を越えていたらエラーダイアログを出して弾く
                    MessageBox.Show("これ以上画像を開くことはできません",
                                    "警告",
                                    MessageBoxButtons.OK);
                    return;
                }

                this.flowLayoutPanel1.Controls.Add(viewer);
                //this.Controls.Add(viewer);
            }

            // ものが追加されたので、再レイアウト
            this.flowLayoutPanel1.PerformLayout();
        }

        /**
         * アプリケーションの終了
         */
        public void ApplicationClose()
        {
            // 確認ダイアログの表示
            string msg = "アプリケーションを終了します\nよろしいですか？";
            string caption = "終了確認";
            DialogResult result = MessageBox.Show(msg,
                                                  caption,
                                                  MessageBoxButtons.OKCancel);
            switch(result)
            {
                case DialogResult.OK:
                    this.Close();
                    break;

                case DialogResult.Cancel:
                default:
                    break;
            }
        }
    }
}
