using ScreenSize;
using UIKit;
using Xamarin.Forms;

[assembly: Dependency(typeof(ScreenSize_iOS))]

namespace ScreenSize
{
    /// <summary>
    /// 画面サイズ取得用クラス
    /// </summary>
    public class ScreenSize_iOS : IScreenSize
    {
        /// <summary>
        /// 画面サイズを取得
        /// </summary>
        /// <returns>画面サイズ</returns>
        public Size GetScreenSize()
        {
            return new Size(UIScreen.MainScreen.Bounds.Width,
                            UIScreen.MainScreen.Bounds.Height);
        }
    }
}
