using ScreenSize;
using Xamarin.Forms;

[assembly: Dependency(typeof(ScreenSize_Droid))]

namespace ScreenSize
{
    /// <summary>
    /// 画面サイズ取得用クラス
    /// </summary>
    public class ScreenSize_Droid : IScreenSize
    {
        /// <summary>
        /// 画面サイズを取得
        /// </summary>
        /// <returns>画面サイズ</returns>
        public Size GetScreenSize()
        {
            double statusBarHeight = 0.0;
            double totalHeight = 0.0;
            double contentHeight = 0.0;
            double contentwidth = 0.0;

            var resources = Forms.Context.Resources;
            var metrics = resources.DisplayMetrics;

            var resourceId = resources.GetIdentifier("status_bar_height", 
                                                     "dimen", 
                                                     "android");
            if (resourceId > 0)
            {
                // ステータスバーの高さを取得
                statusBarHeight = resources.GetDimensionPixelSize(resourceId) / metrics.Density;
                // 画面全体の高さを取得(ステータスバーを含む)
                totalHeight = metrics.HeightPixels / metrics.Density;
                // コンテンツ領域の高さを取得
                contentHeight = totalHeight - statusBarHeight;

                // 幅を取得
                contentwidth = metrics.WidthPixels / metrics.Density;
            }

            return new Size(contentwidth, contentHeight);
        }
    }
}
