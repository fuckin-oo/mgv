using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mgv
{
    static class multiGraphicViewerManager
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            activeForm = new multiGraphicViewer();
            Application.Run(activeForm);

            while(Application.OpenForms.Count > 0)
            {
                Update();
            }
        }

        /// <summary>
        /// 毎フレーム行う処理がある場合はここに記述
        /// </summary>
        static void Update()
        {
        }

        static Form activeForm = null;
    }
}
