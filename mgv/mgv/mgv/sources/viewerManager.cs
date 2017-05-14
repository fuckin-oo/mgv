using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mgv.form;

namespace mgv.sources
{
    class viewerManager
    {
        #region インスタンス管理
        static viewerManager _instance = null;
        public static viewerManager getInstance()
        {
            if (_instance == null)
            {
                _instance = new viewerManager();
            }
            return _instance;
        }
        private viewerManager() { }
        #endregion

        // 画像ビューワの作成
        private graphicViewer createGraphicViewer(string graphic)
        {
            graphicViewer viewer = new graphicViewer(graphic);
            return viewer;
        }

        // 画像ビューワの追加
        public graphicViewer addGraphicViewer(string graphic)
        {
            // 最大表示可能数を超えたらはじく
            if (_viewerList.Count >= _viewerMaxCount)
            {
                return null;
            }

            graphicViewer viewer = createGraphicViewer(graphic);
            if (viewer != null)
            {
                _viewerList.Add(viewer);
            }

            return viewer;
        }

        // 画像ビューワの削除
        public bool deleteGraphicViewer(graphicViewer viewer)
        {
            foreach(var item in _viewerList)
            {
                if (item == viewer)
                {
                    _viewerList.Remove(item);
                    return true;
                }
            }

            return false;
        }

        public bool deleteGraphicViewer(int index)
        {
            if (_viewerList.Count > index)
            {
                _viewerList.RemoveAt(index);
                return true;
            }

            return false;
        }

        List<graphicViewer> _viewerList = new List<graphicViewer>();
        const int _viewerMaxCount = 4;
    }
}
